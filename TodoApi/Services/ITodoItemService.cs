using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Services
{
    public interface ITodoItemService
    {
        public Task<List<TodoItem>> GetIncompleteItemsAsync();

        public Task<TodoItem> GetByIdAsync(long id); 

        public Task<List<TodoItem>> GetAllAsync();           
    }
}