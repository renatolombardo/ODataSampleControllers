using MediatR;
using OAuthSampleControllers.Data.Entities;

namespace ODataSampleControllers.Commands.Create
{
    public class CreateEmployeeCommand : IRequest<EmployeeCommandResponse>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Salary { get; set; }
        public string? JobRole { get; set; }

        public List<CreateEmployeeAddressesCommand>? EmployeeAddresses { get; set; }
    }
}
