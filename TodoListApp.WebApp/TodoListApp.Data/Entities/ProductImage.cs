using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.Data.Entities
{
    public class ProductImage
    {
        public int ID { get; set; }
        public int CategoryId { get; set; }
        public string ImagePath { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
