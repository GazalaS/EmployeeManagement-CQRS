using EmployeeManagement.Models;
using MediatR;

namespace EmployeeManagement.Repository.Queries
{
    public record GetEmployeeByIdQuery(Guid Id): IRequest<Employee>;
}
