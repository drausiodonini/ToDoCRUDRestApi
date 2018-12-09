using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoCRUDRestApi.DataContext;
using ToDoCRUDRestApi.Interfaces;
using ToDoCRUDRestApi.Models;

namespace ToDoCRUDRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private ToDoDataContext _context;
        private IToDoService _toDoService;

        public ToDoController(IToDoService toDoService, ToDoDataContext context)
        {
            _toDoService = toDoService;
            _context = context;
        }

        // GET api/ToDo
        [HttpGet]
        public ActionResult<IEnumerable<ToDoModel>> Get()
        {
            return _toDoService.GetToDos(_context).ToArray();
        }

        // GET api/ToDo/#id
        [HttpGet("{id}")]
        public ActionResult<ToDoModel> Get(int id)
        {
            return _toDoService.GetToDo(_context, id);
        }

        // POST api/ToDo
        [HttpPost]
        public ActionResult Post([FromBody] ToDoModel todo)
        {
            _toDoService.SaveToDo(_context, todo);
            return Ok();
        }

        // PUT api/ToDo/#id
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ToDoModel todo)
        {
            _toDoService.UpdateToDo(_context, id, todo);
            return Ok();
        }

        // DELETE api/ToDo/#id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _toDoService.DeleteToDo(_context, id);
        }
    }
}
