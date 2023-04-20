using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Person
    {
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
