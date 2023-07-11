namespace Generics.Entities
{
    public abstract class Vehicle
    {
        protected Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
