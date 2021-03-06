﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CRScore.Models
{
    public class Athlete
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public char Gender { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
