using MediatR;
using OAuthWithMediatrSample.Data.Entities;

namespace OAuthWithMediatrSample.Commands
{
    public class CreatePersonRequestCommand : IRequest<Person>
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}
