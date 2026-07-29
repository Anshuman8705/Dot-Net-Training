using _29July_Assignment.Models;

namespace _29July_Assignment.Services
{
    public class VehicleService : IVehicleService
    {
        public List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle { Id = 101, VehicleNumber = "MH20AB1234", Name = "Swift", OwnerName = "Anshu" },
            new Vehicle { Id = 102, VehicleNumber = "MH20AB1235", Name = "Activa", OwnerName = "Rahul" },
            new Vehicle { Id = 103, VehicleNumber = "MH20AB1236", Name = "Innova", OwnerName = "Priya" },
            new Vehicle { Id = 104, VehicleNumber = "MH20AB1237", Name = "Duke", OwnerName = "Sneha" },
            new Vehicle { Id = 105, VehicleNumber = "MH20AB1238", Name = "City", OwnerName = "Amit" }
        };

        // Get all vehicles
        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        }

        // Get vehicle by Id
        public Vehicle GetVehicleById(int id)
        {
            return vehicles.FirstOrDefault(v => v.Id == id);
        }

        // Get vehicle by Vehicle Number
        public Vehicle GetVehicleByNumber(string vehicleNumber)
        {
            return vehicles.FirstOrDefault(v => v.VehicleNumber.Equals(vehicleNumber, StringComparison.OrdinalIgnoreCase));
        }

        // Add a new vehicle
        public Vehicle AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            return vehicle;
        }
    }
}