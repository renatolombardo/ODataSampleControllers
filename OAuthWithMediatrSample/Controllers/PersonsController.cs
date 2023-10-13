using Microsoft.AspNet.OData;
using OAuthWithMediatrSample.Data;
using OAuthWithMediatrSample.Data.Entities;

namespace OAuthWithMediatrSample.Controllers
{
    public class PersonsController : ODataController
    {
        private readonly DataContext _dataContext;

        public PersonsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [EnableQuery]
        public SingleResult<Person> GetPerson(Guid id)
        {
            return new SingleResult<Person>(_dataContext.Persons.Where(x => x.Id == id));

        }

        [EnableQuery]
        public IQueryable<Person> GetPersons()
        {
            return _dataContext.Persons;
        }
    }
}
