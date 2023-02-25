using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFConsole.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? Name { get; set; }
        [ForeignKey("Standard")]
        public int StandardRefId { get; set; }
        public Standard ?Standard { get; set; } 
    }
    public class Standard
    {
            [Key]
            public int StandardId { get; set; }
            public string? StandardName { get; set; }
            ICollection<Student>? Students { get; set; }
        }
       
    
}