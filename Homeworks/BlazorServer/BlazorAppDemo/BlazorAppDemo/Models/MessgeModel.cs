using System.ComponentModel.DataAnnotations;

namespace BlazorAppDemo.Models;


public class MessgeModel
{
    [Required]
    [StringLength(10,MinimumLength = 5)]
    public string Message { get; set; }
}
