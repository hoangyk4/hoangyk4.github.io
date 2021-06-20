using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.WebApp.Constants;

namespace TodoListApp.WebApp.DBModel
{
    [Table("Categories")]
    public class Category
    {
        public Category()
        {

        }
        [Key]
        public int ID { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public CategoryStatus? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}

