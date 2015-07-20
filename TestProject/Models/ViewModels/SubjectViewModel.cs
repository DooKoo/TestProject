using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Models.ViewModels
{
    public class SubjectViewModel
    {
        [Required]
        [StringLength(600)]
        public string Title { get; set; }
        public int Step { get; set; }
        public string Description { get; set; }
        public List<Student> Students { get; set; }
    }
}