using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OAuthSampleControllers.Data;

namespace ODataSampleControllers.Commands.Update
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, EmployeeCommandResponse>
    {
        private readonly MyWorldDbContext _context;

        public UpdateEmployeeCommandHandler(MyWorldDbContext context)
        {
            _context = context;
        }

        public async Task<EmployeeCommandResponse> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _context.Employee
                .Include(x => x.EmployeeAddresses)
                .FirstOrDefault(x => x.Id == request.Id);

            if (employee is null)
                return default;

            request.Adapt(employee);

            await _context.SaveChangesAsync();

            var response = employee.Adapt<EmployeeCommandResponse>();

            return response;
        }
    }
}
