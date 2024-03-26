using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class PersonModel
    {
        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Invalid FirstName length")]
        public string FirstName { get; set; }
        [StringLength(5, MinimumLength = 2, ErrorMessage = "Invalid LastName length")]
        public string LastName { get; set; }

        [Range(1, 125,ErrorMessage = "You need to enter a valid age")]
        public int Age { get; set; }
        
        [Range(typeof(bool),"true","true",ErrorMessage = "You need to give concent to continue.")]
        public bool GaveConcent { get; set; }
    }
}
