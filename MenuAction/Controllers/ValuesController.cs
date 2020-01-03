using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MenuAction;

namespace MenuAction.Controllers
{
    public class Customer
    {
        [BindRequired]
        public int Id { get; set; }

        [BindRequired]
        public int Age { get; set; }

        [Required]
        public string Address { get; set; }
    }

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

    


        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok();
        }




        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // POST api/values
        //[HttpPost]
        //public string Post(int id)
        //{
        //    return "post";

        //}

        //POST api/values
        //[HttpPost]
        // public void Post([FromBody]string value)
        // {

        // }

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
}
