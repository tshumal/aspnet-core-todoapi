using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.Models;

namespace TodoApi.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly DataContext _context;

        public TodoItemService(DataContext context)
        {
            _context = context;
            if(_context.TodoItems.Count() == 0)
            {
                _context.TodoItems.Add(new TodoItem {Name = "Item 1", Title = "Item 1 Title"});
                _context.SaveChanges();
            }
        }
        public async Task<List<TodoItem>> GetIncompleteItemsAsync()
        {
            return await _context.TodoItems
                .Where(x => x.IsComplete == false)
                .ToListAsync();            
        }

        public async Task<TodoItem> GetByIdAsync(long id)
        {
            return await _context.TodoItems
                .FindAsync(id);          
        }

        public async Task<List<TodoItem>> GetAllAsync()
        {
            return await _context.TodoItems
                .ToListAsync();
        }

        public async Task<bool> AddTodoItem(TodoItem todoItem)
        {
            _context.TodoItems.Add(todoItem);
            var saveResult = await _context.SaveChangesAsync();

            return saveResult == 1;
        }        
    }
}
