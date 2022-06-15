using EmployeeManagement.Models;
using EmployeeManagement.Repository.Queries;
using MediatR;

namespace EmployeeManagement.Repository.Handlers
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IDataAccess _dataAccess;
        public Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetEmployee());
        }
    }
}
