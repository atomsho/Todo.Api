using System.Collections.Generic;
using Todo.Api.Models;

namespace Todo.Api.Services{

    public class TodoRepository : ITodoRepository
    {
        [HttpGet]
        private List<TodoItems> _items = new List<TodoItems>()
        {
            new TodoItem{ Id = 1, Action= "Thing one.", IsDone =true},
            new TodoItem{ Id = 2, Action= "Thing two.", IsDone= false},

        };

        public List<TodoItems> Items { get => _items; set => _items = value; }

        public IEnumerable<TodoItem> GetAllTodoItems(){
            return Items;
        }
    }
}