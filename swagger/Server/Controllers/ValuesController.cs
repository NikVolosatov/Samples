using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server.Dto;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<MyData> Get()
        {
            var user = new User
            {
                Name = "Петр",
                LastName = "Петров",
                MiddleName = "Петрович"
            };


            var props = new DataProperties
            {
                { "prop1", "value" },
                { "prop2", DateTime.Now },
                { "prop3", new string[] { "val1", "val2", "val3" } }
            };


            var systemProps = new SystemProperties
            {
                { SystemType.Type1, "value" },
                { SystemType.Type2, DateTime.Now },
                { SystemType.Type3, new string[] { "val1", "val2", "val3" } }
            };

            var data = new MyData
            {
                ID = 1,
                Date = DateTime.Now,
                Name = "Babuta",
                Properties = props,
                User = user,
                SystemProperties = systemProps
            };

            return data;
        }
    }
}
