using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.WebApp.DBModel
{
    [Table("StudentInfo")]
    public class Student
    {
        public Student() { }

        [Key]
        public int SID { get; set; }

        [Column("Name", TypeName = "ntext")]
        [MaxLength(20)]
        public string StudentName { get; set; }

        [NotMapped]
        public int? Age { get; set; }

        public int StdId { get; set; }

    }
}
