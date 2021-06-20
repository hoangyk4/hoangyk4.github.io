using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.WebApp.Constants;

namespace TodoListApp.WebApp.DBModel
{
    [Table("Tasks")]
    public class Task
    {
        public Task()
        {

        }
        [Key]
        public int ID { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public TasksStatus? Status { get; set; }
        public int? Owner { get; set; }
        public int? CategoryID { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? OverDue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
