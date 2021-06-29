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
        [StringLength(200)]
        public string UserName { get; set; }
        [StringLength(200)]
        public string Password { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public DateTime? Birth { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(200)]
        public string Phone { get; set; }
        public string Note { get; set; }

    }
}
