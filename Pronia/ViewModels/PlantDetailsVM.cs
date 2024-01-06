using Pronia.Entities;

namespace Pronia.ViewModels
{
    public class PlantDetailsVM
    {
        public Plant Plant { get; set; } = null!;
        public ICollection<Plant> Relateds { get; set; } = null!;
    }
}
