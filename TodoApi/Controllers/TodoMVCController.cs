using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Services;


namespace TodoAPI.Controllers
{
    public class TodomvcController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodomvcController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _todoItemService.GetIncompleteItemsAsync();

            var model = new TodoViewModel()
            {
                Items = items
            };

            return View(model);
        }
    } 
}