using AutoMapper;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventManagement.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            AllowNullCollections = true;


            CreateMap<Database.UserRoles, Model.UserRoles>();

            CreateMap<Users, User>()
                .AfterMap((src, dest) => {
                    if ((bool)src.UserRoles?.Any())
                    {
                        ICollection<Model.UserRoles> userRoles = new List<Model.UserRoles>();

                        foreach (var role in src.UserRoles)
                        {
                            Model.UserRoles newRole = new Model.UserRoles();

                            newRole.RoleId = role.RoleId;
                            newRole.UserId = role.UserId;
                            newRole.UserRoleId = role.UserRoleId;

                            if (role.Role != null)
                            {
                                newRole.Role = new Role { Name = role.Role.Name, RoleId = role.Role.RoleId };
                            }
                            if (role.User != null)
                            {
                                newRole.User = new User { Active = role.User.Active, Email = role.User.Email, FirstName = role.User.FirstName, Username = role.User.Username, UserId = role.User.UserId };
                            }
                            userRoles.Add(newRole);
                        }
                        dest.UserRoles = userRoles;
                    } else
                    {
                        dest.UserRoles = new List<Model.UserRoles>();
                    }
                });
            CreateMap<Events, Event>();
            CreateMap<Categories, Category>();
            CreateMap<Ratings, Rating>();
            CreateMap<Roles, Role>();
            CreateMap<Database.Participants, Model.Participants>();
            CreateMap<Organizations, Organization>();
            CreateMap<Ratings, RatingUpsertRequest>().ReverseMap();
            CreateMap<Database.Participants, ParticipantUpsertRequest>().ReverseMap();
            CreateMap<Organizations, OrganizationUpsertRequest>().ReverseMap();
            CreateMap<Categories, CategoryUpsertRequest>().ReverseMap();
            CreateMap<Users, UserInsertRequest>().ReverseMap();
            CreateMap<Events, EventUpsertRequest>().ReverseMap();
        }
    }
}
