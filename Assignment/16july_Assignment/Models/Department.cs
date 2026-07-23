namespace EmployeeManagementSystem.Models
{
    // ==================================================================
    // Department
    // A plain data class - just holds the details of one department.
    // ==================================================================
    public class Department
    {
        public string DeptName { get; set; }
        public string DepartmentHead { get; set; }
        public string HeadContact { get; set; }
        public string HeadEmail { get; set; }
    }
}