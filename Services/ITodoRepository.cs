using System.Collections.Generic;
using Todo.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Todo.Api.Services
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> GetAllTodoItems();
    }
}