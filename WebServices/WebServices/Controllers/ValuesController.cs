using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServices.Models;

namespace WebServices.Controllers
{
    public class ValuesController : ApiController
    {
        private ApplicationDbContext db;
        public IHttpActionResult Get()
        {
            db = new ApplicationDbContext();
            return Ok(db.Items.ToList());
        } 
    }
}


