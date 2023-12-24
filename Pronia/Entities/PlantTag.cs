namespace Pronia.Entities
{
    public class PlantTag
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public int TagId { get; set; }
        public Plant Plant { get; set; } = null!;
        public Tag Tag { get; set; } = null!;


        public override string ToString()
        {
            return Tag.Name;
        }
    }
}

