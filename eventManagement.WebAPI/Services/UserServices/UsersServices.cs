using AutoMapper;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Database;
using eventManagement.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eventManagement.WebAPI.Services.UserServices
{
    public class UsersServices : IUsersService
    {
        private readonly eventsContext _context;
        private readonly IMapper _mapper;

        public UsersServices(eventsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<User> Get(UserSearchRequest request)
        {
            var query = _context.Users.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.FirstName))
            {
                query = query.Where(x => x.FirstName.StartsWith(request.FirstName));
            }

            if (!string.IsNullOrWhiteSpace(request?.LastName))
            {
                query = query.Where(x => x.LastName.StartsWith(request.LastName));
            }

            if (!string.IsNullOrWhiteSpace(request?.Username))
            {
                query = query.Where(x => x.Username == request.Username);
            }

            if (request?.RoleId.HasValue == true)
            {
                query = query.Include("UserRoles.Role").Where(x => x.UserRoles.Any(c => c.RoleId == request.RoleId));
            }

            var list = query.ToList();
            return _mapper.Map<List<User>>(list);
        }


        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }


        public User GetById(int id)
        {
            var entity = _context.Users.Include("UserRoles.Role").Where(x => x.UserId == id).FirstOrDefault();

            return _mapper.Map<User>(entity);
        }

        public User Insert(UserInsertRequest request)
        {
            var entity = _mapper.Map<Users>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Lozinke se ne slažu");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            _context.Users.Add(entity);
            _context.SaveChanges();

            foreach (var role in request.Roles)
            {
                _context.UserRoles.Add(new Database.UserRoles()
                {
                    RoleId = role,
                    UserId = entity.UserId,
                });
            }

            _context.SaveChanges();

            return _mapper.Map<User>(entity);
        }

        public User Update(int id, UserInsertRequest request)
        {
            var entity = _context.Users.Include("UserRoles.Role").Where(x => x.UserId == id).FirstOrDefault();

            _context.Users.Attach(entity);
            _context.Users.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("Lozinke se ne slažu");
                }

                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }

            var existingRoles = entity.UserRoles.Where(x => x.UserId == id);

            foreach (var role in existingRoles)
            {
                if (!request.Roles.Contains(role.RoleId))
                {
                    _context.UserRoles.Remove(role);
                }
            }

            foreach (var role in request.Roles)
            {
                Database.UserRoles existingRole = entity.UserRoles.Where(x => x.RoleId == (int)role).FirstOrDefault();
                if (existingRole == null)
                {
                    _context.UserRoles.Add(new Database.UserRoles()
                    {
                        RoleId = role,
                        UserId = entity.UserId,
                    });
                }
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<User>(entity);
        }

        public User Authenticate(string username, string pass)
        {
            var user = _context.Users.Include("UserRoles.Role").FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, pass);

                if (newHash == user.PasswordHash)
                {
                    return _mapper.Map<User>(user);
                }
            }
            return null;
        }
    }
}
