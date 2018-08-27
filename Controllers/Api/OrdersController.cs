using FoodStall_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodStall_MVC.Controllers.Api
{
    public class OrdersController : ApiController
    {
        // GET: api/Orders
        public IHttpActionResult Get()
        {
            return Ok(BizLogic.GetOrders());
        }

        // GET: api/Orders/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Orders
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Orders/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Orders/5
        public void Delete(int id)
        {
        }
    }
}
