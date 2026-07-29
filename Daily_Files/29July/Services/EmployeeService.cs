using _29July.Models;

namespace _29July.Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id = 101,
                Name = "Anshu",
                PhoneNum = 9876543210,
                DeptId = 101,
                Email = "anshu@gmail.com"
            },
            new Employee
            {
                Id = 102,
                Name = "Rahul",
                PhoneNum = 9876543211,
                DeptId = 102,
                Email = "rahul@gmail.com"
            },
            new Employee
            {
                Id = 103,
                Name = "Priya",
                PhoneNum = 9876543212,
                DeptId = 103,
                Email = "priya@gmail.com"
            },
            new Employee
            {
                Id = 104,
                Name = "Sneha",
                PhoneNum = 9876543213,
                DeptId = 104,
                Email = "sneha@gmail.com"
            },
            new Employee
            {
                Id = 105,
                Name = "Amit",
                PhoneNum = 9876543214,
                DeptId = 105,
                Email = "amit@gmail.com"
            }
        };

        // Get all employees
        public List<Employee> getEmployees()
        {
            return employees;
        }

        // Get employee by department id
        public Employee getEmployees(int deptid)
        {
            return employees.FirstOrDefault(e => e.DeptId == deptid);
        }

        // Get employee by name
        public Employee getEmployees(string name)
        {
            return employees.FirstOrDefault(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Add a new employee
        public Employee addEmployees(Employee employee)
        {
            employees.Add(employee);
            return employee;
        }
    }
}