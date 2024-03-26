

using Microsoft.AspNetCore.Identity;

namespace SHoper.Model.Emplyee
{
    public class Employee 
    {
        public int EmployeeID { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public ICollection<Vacation> Vacations { get; } = new List<Vacation>();
        public ICollection<EmployeeTask> Tasks { get; } = new List<EmployeeTask>();
        //public ICollection<Department> Departments { get; } = new List<Department>();

   
    }

}