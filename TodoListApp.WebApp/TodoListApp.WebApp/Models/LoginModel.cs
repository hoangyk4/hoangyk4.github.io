using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.WebApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời nhập Tên Truy cập")]
        [Display(Name ="Tên Truy Cập")]
        [StringLength(15, ErrorMessage = "(Độ dài từ 4-15 ký tự)", MinimumLength = 5)]
        public string UserName { set; get; }
        [Required(ErrorMessage = "Mời nhập Mật khẩu")]
        [StringLength(15, ErrorMessage = "(Độ dài từ 3-15 ký tự)", MinimumLength = 3)]
        [Display(Name = "Mật Khẩu")]
        [DataType(DataType.Password)]
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }

}
