using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.Utilities.Exceptions
{
    public class TodoListException : Exception
    {
        public TodoListException()
        {
        }

        public TodoListException(string message)
            : base(message)
        {
        }

        public TodoListException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}