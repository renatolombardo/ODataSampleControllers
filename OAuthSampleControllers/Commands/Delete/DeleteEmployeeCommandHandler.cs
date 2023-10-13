using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OAuthSampleControllers.Data;
using OAuthSampleControllers.Data.Entities;

namespace ODataSampleControllers.Commands.Delete
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, EmployeeCommandResponse>
    {
        private readonly MyWorldDbContext _dbContext;

        public DeleteEmployeeCommandHandler(MyWorldDbContext worldDbContext)
        {
            _dbContext = worldDbContext;
        }

        public Task<EmployeeCommandResponse>? Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _dbContext.Employee
                .Include(x => x.EmployeeAddresses)
                .FirstOrDefault(x => x.Id == request.Id);

            if (employee is null)
                return default;

            _dbContext.Employee.Remove(employee);

            _dbContext.SaveChangesAsync();

            var response = employee.Adapt<EmployeeCommandResponse>();

            return Task.FromResult(response);

        }
    }
}
