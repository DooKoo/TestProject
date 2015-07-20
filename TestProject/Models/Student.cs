using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Student
    {
        public enum SexEnum
        {
            Male,
            Female
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(600)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(600)]
        public string LastName { get; set; }

        [Required]
        [Range(17, 120)]
        public int Age { get; set; }

        [Required]
        public virtual Group Group { get; set; }

        [Required]
        public SexEnum Sex { get; set; }

        [StringLength(600)]
        public string Nationality { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

        [NotMapped]
        public List<Subject> SelectedSubjects { get; set; }
    }
}