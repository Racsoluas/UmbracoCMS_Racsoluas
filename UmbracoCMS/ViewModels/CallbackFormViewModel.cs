using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace UmbracoCMS.ViewModels;

public class CallbackFormViewModel
{
    [Required(ErrorMessage = "Name is required")]
    [Display(Name = "Name")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "Email is required")]
    [Display(Name = "Email address")]
    [RegularExpression(@"^(?=.{2,}@)(?!\.)(?!.*\.\.)[A-Za-z0-9_%+-]+(?:\.[A-Za-z0-9_%+-]+)*@[A-Za-z0-9][A-Za-z0-9-]{0,61}[A-Za-z0-9](?:\.[A-Za-z0-9](?:[A-Za-z0-9-]{0,61}[A-Za-z0-9]))*\.[A-Za-z]{2,}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Phone is required")]
    [Display(Name = "Phone")]
    public string Phone { get; set; } = null!;

    [Required(ErrorMessage = "Please select an option")]
    public string SelectedOption { get; set; } = null!;

    [BindNever]
    public IEnumerable<string> Options { get; set; } = [];
}
