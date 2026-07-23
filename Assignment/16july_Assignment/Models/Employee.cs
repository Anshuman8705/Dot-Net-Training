namespace EmployeeManagementSystem.Models
{
    // ==================================================================
    // Employee
    // A plain data class - just holds the details of one employee.
    // Lives in the Models folder, as required by the assignment.
    // ==================================================================
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
    }
}