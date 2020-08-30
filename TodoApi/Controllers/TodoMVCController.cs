using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Services;

namespace TodoAPI.Controllers
{
    public class TodoMVCController : Controller

    {
        private readonly ITodoItemService _todoItemService;

        public TodoMVCController(ITodoItemService todoItemService){
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _todoItemService.GetIncompleteItemsAsync();
        // Get to-do items from database

        // Put items into a model

        // Render view using the model”

        }
    } 
}