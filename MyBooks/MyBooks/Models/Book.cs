using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBooks.Models;

public class Book
{
    public int Id { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [StringLength(60, MinimumLength = 1)]
    [Required]
    public string? Title { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [StringLength(40, MinimumLength = 3)]
    [Required]
    public string? Author { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [StringLength(20, MinimumLength = 3)]
    [Required]
    public string? Genre { get; set; }
    [Range(1, 4000)]
    [Required]
    public int Pages { get; set; }
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime? ReleaseDate { get; set; }
}