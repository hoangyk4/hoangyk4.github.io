using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.Data.Enums;

namespace TodoListApp.Data.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Status? Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
