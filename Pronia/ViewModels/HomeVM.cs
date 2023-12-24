using Pronia.Entities;

namespace Pronia.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; } = null!;
        public ICollection<Plant> Plants { get; set; } = null!;
    }
}