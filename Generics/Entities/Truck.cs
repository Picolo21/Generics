namespace Generics.Entities
{
    public class Truck : Vehicle
    {
        public Truck(string brand, string model, int axes) : base(brand, model)
        {
            Axes = axes;
        }

        public int Axes { get; set; }
    }
}
