using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProj.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value: ID "+id;
        }

        // GET api/values/5
        public string Get(string name,string city)
        {
            return "Name: " + name + " City :" + city;
        }



        // POST api/values
        public string Post([FromBody]string value)
        {
            return value;
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]string value)
        {
            return "updated data for id " + id + " value " + value;
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            return "Deleted data with id " + id;
        }
    }
}
