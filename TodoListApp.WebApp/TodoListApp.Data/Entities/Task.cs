using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.Data.Enums;

namespace TodoListApp.Data.Entities
{
    public class Task
    {
        public int  ID { get; set; }
        public string Name { get; set; }
        public StatusTask? Status { get; set; }
        public int? Owner { get; set; }
        public int? CategoryID { get; set; }
        public IsCompelete? IsCompleted { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? OverDue { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        
    }
}
