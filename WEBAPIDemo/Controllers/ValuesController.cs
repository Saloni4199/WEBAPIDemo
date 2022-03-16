using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPIDemo.Controllers
{
    /*[Authorize]*/
    public class ValuesController : ApiController
    {
        static List<string> testString = new List<string>()
        {
            "value0","value1","value2"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return testString;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return testString[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            testString.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            testString[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            testString.RemoveAt(id);
        }
    }
}
