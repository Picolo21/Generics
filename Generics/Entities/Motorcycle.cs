namespace Generics.Entities
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(
            string brand,
            string model,
            int horsepower,
            int cylinders) : base(brand, model)
        {
            Horsepower = horsepower;
            Cylinders = cylinders;
        }

        public int Horsepower { get; set; }
        public int Cylinders { get; set; }
    }
}
