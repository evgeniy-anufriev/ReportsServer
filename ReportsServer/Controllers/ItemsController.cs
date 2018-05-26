using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBRepository;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReportsServer
{
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        IAeEventRepository _aeEventRepository;
        public ItemsController(IAeEventRepository aeEventRepository )
        {
            _aeEventRepository = aeEventRepository;
        }

        [HttpGet("from={dateFrom}&to={dateTo}")]
        public async Task<List<EventHistory>> GetItems(DateTime dateFrom, DateTime dateTo)
        {
            return await _aeEventRepository.GetItems(dateFrom, dateTo);
        }
    

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
