using System.ComponentModel.DataAnnotations;

namespace Pronia.Areas.Admin.ViewModels
{
    public class CreateCategoryVM
    {
        [Required(ErrorMessage = "Zehmet olmasa doldurun")]
        public string Name { get; set; } = null!;
    }
}
