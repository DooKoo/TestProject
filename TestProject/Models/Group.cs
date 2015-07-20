﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Student> Students { get; set; } 
    }
}