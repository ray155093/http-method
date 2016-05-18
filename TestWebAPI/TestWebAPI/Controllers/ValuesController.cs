using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections;

namespace TestWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        
       
        public static List<string> Result = new List<string> { "value1", "value2", "value3", "value4", "value5", "value6" };
        
        // GET api/values
        public IEnumerable<string> Get()
        {
            return Result;
        }

        // GET api/values/id
        /// <summary>
        /// memo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetByID(  int id)
        {
            return Result[id];
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<string> Post(string value)
        {
            Result.Add(value);

            return Result;
        }

        // PUT api/values/5
        [HttpPut]
        public IEnumerable<string> Put(int id, string value)
        {
            Result[id] = value;
            return Result;
        }

        // DELETE api/values/5
        [HttpDelete]
        public IEnumerable<string> DeleteByID(int id)
        {
            Result[id].Remove(id);
            return Result;
        }
       
    }
}
