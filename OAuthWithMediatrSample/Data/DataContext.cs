using Microsoft.EntityFrameworkCore;
using OAuthWithMediatrSample.Data.Entities;

namespace OAuthWithMediatrSample.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
    }
}
