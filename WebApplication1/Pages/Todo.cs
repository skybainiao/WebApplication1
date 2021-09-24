using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WebApplication1.Data;

namespace WebApplication1.Pages
{
    public partial class Todo:ComponentBase
    {
        private ICollection<TodoItem> todos = new List<TodoItem>();
        private string newTodo;

        public void addTodo()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem
                {
                    title = newTodo
                });
                newTodo = string.Empty;
            }
        }
    }
}