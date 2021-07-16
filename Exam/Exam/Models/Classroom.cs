using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{
    public class Classroom
    {
        [Key]
        public int ClassroomID { get; set; }
        [Required(ErrorMessage = "Please enter the correct Classroom")]
        public string ClassroomName { get; set; }
    }
}