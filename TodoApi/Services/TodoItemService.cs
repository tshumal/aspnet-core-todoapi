using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Services
{
    public class TodoItemService : ITodoItemService
    {
        Task<TodoItem[]> ITodoItemService.GetIncompleteItemsAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
