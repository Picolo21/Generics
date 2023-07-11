using Generics.Entities;
using Generics.Utils;

public class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car("BMW", "X6", 5);
        Motorcycle motorcycle = new Motorcycle("Yamaha", "MT-09", 115, 850);
        Truck truck = new Truck("Volvo", "SL500", 6);

        SaveVehicle(car);
        SaveVehicle(motorcycle);
        SaveVehicle(truck);
    }

    private static void SaveVehicle<T>(T vehicle)
    {
        Serializer<T> serializer = new Serializer<T>();
        SaveFile saveFile = new SaveFile();

        string objSerialized = serializer.Serialize(vehicle);
        string vehicles = $"{vehicle.GetType().Name}.json";
        string path = @"C:\Users\" + Environment.UserName + @"\";
        string pathVehicle = path + vehicles;
        saveFile.Save(objSerialized, pathVehicle);
    }
}