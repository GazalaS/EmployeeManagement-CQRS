using EmployeeManagement.Models;

namespace EmployeeManagement.Repository
{
    //Create, Read, Update and Delete actions
    public interface IDataAccess
    {
        Employee CreateEmployee();
        Employee UpdateEmployee();
        Employee DeleteEmployee();
        Employee GetEmployee();
        Employee GetEmployeeById(int id);
    }

    public class DataAccess : IDataAccess
    {
        private List<Employee> _employees;
        public Employee CreateEmployee()
        {
            Employee newEmployee = new Employee();
            newEmployee.Id = new Guid();
            return newEmployee;
        }

        public Employee DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault();
        }

        public Employee UpdateEmployee()
        {
            throw new NotImplementedException();
        }
    }
}