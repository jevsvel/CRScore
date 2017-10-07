using System.ComponentModel.DataAnnotations;

namespace CRScore.Models
{
    public class Exercise
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
