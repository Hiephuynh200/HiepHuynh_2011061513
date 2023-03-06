﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HiepHuynh_2011061513.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecture { get; set; }
        [Required]
        public string LectureId { get; set; }
        [Required]
        [StringLength(225)]
        public string Place { get; set; }
        public DateTime Datetime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
   
}