using System;
using System.ComponentModel.DataAnnotations;

namespace CRScore.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
