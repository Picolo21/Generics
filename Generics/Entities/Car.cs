namespace Generics.Entities
{
    public class Car : Vehicle
    {
        public Car(string brand, string model, int numberPassengers) : base(brand, model)
        {
            NumberPassengers = numberPassengers;
        }

        public int NumberPassengers { get; set; }
    }
}
