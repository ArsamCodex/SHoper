using System.Reflection.Metadata;

namespace SHoper.Model.Emplyee
{
    public class Vacation
    {
        public int VacationID { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string? VacationText { get; set; }
        public int EmployeeID { get; set; } // Required foreign key property
        public Employee? Employees { get; set; }
    }
}
