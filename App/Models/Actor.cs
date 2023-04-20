using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Actor : Person
    {
        [Key]
        public int ActorId { get; set; }
        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
