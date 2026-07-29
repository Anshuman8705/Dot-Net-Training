using _29July.Models;

namespace _29July.Services
{
    public interface IEmployeeService
    {
        List<Employee> getEmployees();
        Employee getEmployees(int deptid);
        Employee getEmployees(string name);
        Employee addEmployees(Employee employee);
    }
}

// controller ----- IEmployeeService ----- EmployeeService
// loose coupling , easy testing , easy replacement 