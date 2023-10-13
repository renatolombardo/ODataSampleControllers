using MediatR;
using OAuthSampleControllers.Data.Entities;

namespace ODataSampleControllers.Commands.Update
{
    public class UpdateEmployeeCommand : IRequest<EmployeeCommandResponse>
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Salary { get; set; }
        public string? JobRole { get; set; }
        public List<UpdateEmployeeAddressesCommand>? EmployeeAddresses { get; set; }
    }
}
