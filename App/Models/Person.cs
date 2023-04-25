using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Person
    {
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }
    }
}
