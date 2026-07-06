using Factory_Pattern;

class Program
{
    static void Main()
    {
        IVehicle vehicle = VehicleFactory.GetVehicle("Bike");

        vehicle.Drive();
    }
}