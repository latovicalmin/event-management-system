using AutoMapper;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventManagement.WebAPI.Services.CategoryServices
{
    public class CategoriesService : BaseCRUDService<Category, CategorySearchRequest, Categories, CategoryUpsertRequest, CategoryUpsertRequest>
    {
        public CategoriesService(eventsContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Category> Get(CategorySearchRequest search)
        {
            var query = _context.Set<Categories>().AsQueryable();

            if (!String.IsNullOrEmpty(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().StartsWith(search.Name.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Category>>(list);
        }
    }
}
