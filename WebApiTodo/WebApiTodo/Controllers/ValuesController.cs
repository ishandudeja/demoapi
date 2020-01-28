using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.Mvc;
using WebApiTodo.Service;
namespace WebApiTodo.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        private readonly IServiceContainer _serviceContainer;
        public ValuesController(IServiceContainer serviceContainer) {
            this._serviceContainer = serviceContainer;
        }

        // GET api/values
        public JsonResult< List<string>> Get()
        {
          return  Json(_serviceContainer.FruitsList()); //new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
