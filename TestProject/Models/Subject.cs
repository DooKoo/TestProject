using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(600)]
        public string Title { get; set; }

        public string Description { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}