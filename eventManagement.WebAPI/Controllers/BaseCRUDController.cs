using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventManagement.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eventManagement.WebAPI.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service = null;
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public T Insert(TInsert request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public T Update(int id, TUpdate request)
        {
            return _service.Update(id, request);
        }

        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            _service.Remove(id);
            return true;
        }
    }
}