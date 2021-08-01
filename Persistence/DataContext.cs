using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //This is gonna represent a table in the DB, the table name will be called Activities
        //Properties inside the table are gonna be based on the Activity class
        public DbSet<Activity> Activities { get; set; }
    }
}