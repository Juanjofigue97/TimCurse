using System.ComponentModel.DataAnnotations;

namespace BlazorPersonApp.Models;

public class PersonModel
{
    [Required]
    [StringLength(20, MinimumLength = 5)]
    public string FirstName { get; set; }
    [Required]
    [StringLength(20, MinimumLength = 5)]
    public string LastName { get; set; }

}
