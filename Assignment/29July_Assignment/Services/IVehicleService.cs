using _29July_Assignment.Models;

namespace _29July_Assignment.Services
{
    public interface IVehicleService
    {
        List<Vehicle> GetVehicles();
        Vehicle GetVehicleById(int id);
        Vehicle GetVehicleByNumber(string vehicleNumber);
        Vehicle AddVehicle(Vehicle vehicle);
    }
}

// controller ----- IVehicleService ----- VehicleService
// loose coupling , easy testing , easy replacement