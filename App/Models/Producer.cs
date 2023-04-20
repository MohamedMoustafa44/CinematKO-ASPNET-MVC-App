using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Producer : Person
    {
        [Key]
        public int ProducerId { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
