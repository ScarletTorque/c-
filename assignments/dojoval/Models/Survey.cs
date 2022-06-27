using System.ComponentModel.DataAnnotations;
namespace dojoval.Models;
// #pragma warning disable CS8618
public class Survey
{
    [Required(ErrorMessage = "Name is required")]
    [MinLength(2)]
    public string Name {get;set;} = null!;
    [Required]
    public string Location {get;set;} = null!;
    [Required]
    public string Language {get;set;} = null!;
    [MinLength(21)]
    public string? Comment {get;set;}
}