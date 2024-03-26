namespace SHoper.Model.Emplyee
{
    public class EmployeeTask
    {
        public int EmployeeTaskID { get; set; }
        public string? TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? YourText { get; set; }
        public int EmployeeID { get; set; } // Required foreign key property
        public Employee? Employees { get; set; } = null;
        
    }
}
