using MediatR;
using OAuthSampleControllers.Data.Entities;

namespace ODataSampleControllers.Commands.Delete
{
    public class DeleteEmployeeCommand : IRequest<EmployeeCommandResponse>
    {
        public int Id { get; set; } 
    }
}
