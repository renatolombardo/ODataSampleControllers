using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using OAuthSampleControllers.Data;
using OAuthSampleControllers.Data.Entities;
using ODataSampleControllers.Commands.Create;
using ODataSampleControllers.Commands.Delete;
using ODataSampleControllers.Commands.Update;

namespace OAuthSampleControllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly MyWorldDbContext _myWorldDbContext;
        public EmployeeController(MyWorldDbContext myWorldDbContext)
        {
            _myWorldDbContext = myWorldDbContext;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_myWorldDbContext.Employee.AsQueryable());
        }

        [HttpPost]
        public async Task<IResult> Post(IMediator mediator, CreateEmployeeCommand employee)
        {
            var response = await mediator.Send(employee);

            return response is not null ? Results.Ok(response) : Results.NotFound();
        }

        [HttpPut]
        public async Task<IResult> Put(IMediator mediator, UpdateEmployeeCommand employee)
        {
            var response = await mediator.Send(employee);

            return response is not null ? Results.Ok(response) : Results.NotFound();
        }

        [HttpDelete]
        public async Task<IResult> Delete(IMediator mediator, DeleteEmployeeCommand employee)
        {
            var response = await mediator.Send(employee);

            return response is not null ? Results.Ok(response) : Results.NotFound();
        }

    }
}
