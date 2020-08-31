using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Data;
using TodoApi.Models;
using TodoApi.Services;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        [HttpGet("incomplete-items")]
        public async Task<ActionResult<List<TodoItem>>> GetIncompleteItems()
        {
            var items =  await _todoItemService.GetIncompleteItemsAsync();
            return items;
        }

        [HttpGet]
        public async Task<ActionResult<List<TodoItem>>> GetAll()
        {
            var items =  await _todoItemService.GetAllAsync();
            return items;
        }

        [HttpGet("{id}", Name = "GetToDo")]
        public async Task<ActionResult<TodoItem>> GetById(long id)
        {
            var item = await _todoItemService.GetByIdAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }    
}