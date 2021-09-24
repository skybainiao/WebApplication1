using System;

namespace WebApplication1.Data
{
    public class TodoItem
    {

        public string title { get; set; }

        public Boolean IsDone()
        {
            return true;
        }
    }
}