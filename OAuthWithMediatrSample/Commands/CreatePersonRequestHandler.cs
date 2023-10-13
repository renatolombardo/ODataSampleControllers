using MediatR;
using OAuthWithMediatrSample.Data;
using OAuthWithMediatrSample.Data.Entities;

namespace OAuthWithMediatrSample.Commands
{
    public class CreatePersonRequestHandler : IRequestHandler<CreatePersonRequestCommand, Person>
    {
        private readonly DataContext _dataContext;

        public CreatePersonRequestHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Person> Handle(CreatePersonRequestCommand request, CancellationToken cancellationToken)
        {
            var person = new Person
            {
                Age = request.Age,
                FirstName = request.FirstName
            };

            _dataContext.Add(person);

            await _dataContext.SaveChangesAsync();

            return person;
        }
    }

}
