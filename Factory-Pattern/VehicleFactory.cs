using Factory_Pattern;

public class VehicleFactory
{
    public static IVehicle GetVehicle(string vehicleType)
    {
        if (vehicleType == "Car")
            return new Car();

        if (vehicleType == "Bike")
            return new Bike();

        if (vehicleType == "Truck")
            return new Truck();

        throw new Exception("Invalid Vehicle Type");
    }
}