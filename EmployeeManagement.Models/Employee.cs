namespace EmployeeManagement.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int EmployeeNumber { get; set; }
        public IList<Languages> Languages { get; set; }

    }
}