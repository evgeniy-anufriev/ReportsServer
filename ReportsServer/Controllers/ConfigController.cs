using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DBRepository;
using Microsoft.AspNetCore.Mvc;
using Models.ConfigurationDB;

namespace ReportsServer
{
    [Route("api/[controller]")]
    public class ConfigController : Controller
    {
        ConfigRepository _confsRepository;
        public ConfigController(ConfigRepository confsRepository)
        {
            _confsRepository = confsRepository;
        }

        [HttpGet("{table}")]
        public async Task<IList> GetItems(string table)
        {
            return await _confsRepository.GetItems(table);
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
