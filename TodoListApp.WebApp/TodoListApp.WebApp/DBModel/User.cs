using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.WebApp.DBModel
{
    [Table("Users")]
    public class User
    {
        public User()
        {

        }
        [Key]
        public int ID { get; set;}

        [StringLength(8, ErrorMessage = "Tên truy cập từ 4-8 ký tự.", MinimumLength = 4)]
        [Required(ErrorMessage ="Bạn chưa nhập Tài khoản")]
        public string UserName { get; set; }

        [StringLength(8, ErrorMessage = "Mật khẩu từ 6-8 ký tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(200)]
        public string Name { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? Birth { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(200)]
        public string Phone { get; set; }
        public string Note { get; set; }

    }
}
