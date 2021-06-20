using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.ViewModels.System.Users
{
    public class RegisterRequest
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Note { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
