namespace SHoper.Model.Emplyee
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string? DepartmentName { get; set; }
        public int EmployeeID { get; set; } // Required foreign key property
        public Employee? Employees { get; set; } = null;
    }
}
