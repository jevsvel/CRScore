﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CRScore.Models
{
    public class Score
    {
        [Key]
        public int ID { get; set; }
        public int Place { get; set; }
        public int Points { get; set; }
    }
}
