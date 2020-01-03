using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;
using MenuAction.Models;
namespace TodoApi.Controllers {
    [Route("api/[controller]")]
    //[ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;
        public TodoController(TodoContext context) {
            _context = context;
            //if (_context.TodoItems.Count() == 0)
            //{
            //    // Create a new TodoItem if collection is empty,
            //    // which means you can't delete all TodoItems. 
            //    _context.TodoItems.Add(new TodoItem { Name = "Item1" });
            //    _context.SaveChanges(); }
        }




        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
          return  _context.frmMenuInfo.Select(s=>s.MenuName);
           // return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public int Post(int x)
        {
            return x;
        }

    }
} 