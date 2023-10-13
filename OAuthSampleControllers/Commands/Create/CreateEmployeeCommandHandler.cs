using Mapster;
using MediatR;
using OAuthSampleControllers.Data;
using OAuthSampleControllers.Data.Entities;

namespace ODataSampleControllers.Commands.Create
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, EmployeeCommandResponse>
    {
        private readonly MyWorldDbContext _dbContext;

        public CreateEmployeeCommandHandler(MyWorldDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<EmployeeCommandResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            //Mapster - não precisa registrar o servico no Program.cs nem criar profiles.
            
            var employee = request.Adapt<Employee>();

            _dbContext.Employee.Add(employee);

            _dbContext.SaveChanges();

            var response = employee.Adapt<EmployeeCommandResponse>();

            return response;
        }
    }
}
