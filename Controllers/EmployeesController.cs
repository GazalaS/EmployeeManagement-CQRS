using EmployeeManagement.Models;
using EmployeeManagement.Repository.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //GET: api/<EmployeesController>
        [HttpGet]
        public async Task<Employee> Get()
        {
            return await _mediator.Send(new GetEmployeeByIdQuery());
        }
    }
}