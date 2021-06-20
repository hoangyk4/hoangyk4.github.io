using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.Application.System.Users
{
    public interface IUserSevice
    {
        Task<bool> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
    }
}
