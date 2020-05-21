using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public List<Information> Get()
        {
            List<Information> _list = new List<Information>();

            Information info1 = new Information(1000, "Project Jenkins", "Generate a CI CD with jenkins for .net Core", DateTime.Now);
            Information info2 = new Information(2000, "Project Docker", "integrate .net Core with jenkins", DateTime.Now);
            Information info3 = new Information(3000, "Project .Net Core", "Generate a .net core application", DateTime.Now);
            Information info4 = new Information(4000, "Project Integration", "Generate an Integration linux/Microsoft", DateTime.Now);

            _list.Add(info1);
            _list.Add(info2);
            _list.Add(info3);
            _list.Add(info4);

            return _list;
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class Information
    {
        public Information(int id, string description, string project, DateTime dateTimeInformation)
        {
            Id = id;
            Description = description;
            Project = project;
            DateTimeInformation = dateTimeInformation;
        }

        public int Id { get; set; }
        public String Description { get; set; }
        public String Project { get; set; }
        public DateTime DateTimeInformation { get; set; }
    }

}
