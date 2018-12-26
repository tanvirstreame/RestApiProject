using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestApiProject.Models;

namespace RestApiProject.Controllers
{
   
    public class HomeController : ApiController
    {

        List<Student> listData = new List<Student>()
        {

            new Student(){Id=1,Name="Tanvir"},
            new Student(){Id=2,Name="Streame"}
        };


        [HttpGet]
        public IEnumerable<Student> GetData()
        {
            return listData;
        }
        [Route("api/Home/Name/{id}")]
        public String GetName(int id)
        {
            return listData[id].Name;
        }
        [Route("api/Home/{id}/Name")]
        public String GetIdName(int id)
        {
            return listData[id].Name;
        }

    }
}
