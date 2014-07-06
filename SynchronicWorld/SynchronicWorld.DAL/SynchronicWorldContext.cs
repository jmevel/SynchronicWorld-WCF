using SynchronicWorld.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynchronicWorld.DAL
{
    public class SynchronicWorldContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Contribution> Contributions { get; set; }

        //public DbSet<Contribution> Contributions { get; set; }

        //connectionString="Data Source=C:\Users\koenigs\documents\visual studio 2012\Projects\SynchronicWorld\SynchronicWorld.DAL\SynchronicWorldLocalDatabase.sdf" providerName="System.Data.SqlClient"/>
        //: base("(LocalDb)\v11.0;Initial Catalog=SynchronicWorldLocalDatabase;Integrated Security=true")
        //: base(@"C:\Users\koenigs\documents\visual studio 2012\Projects\SynchronicWorld\SynchronicWorld.DAL\SynchronicWorldLocalDatabase.sdf")
        //: base("SynchronicWorldContext") 
        //: base(@"C:\Users\koenigs\documents\visual studio 2012\Projects\SynchronicWorld\SynchronicWorld.DAL\SynchronicWorldLocalDatabase.sdf")
        // : base("Data Source=machinename\\SqlExpress;Initial Catalog=AwesomeDB;Integrated Security=True")
        //  : base(@"C:\Users\koenigs\documents\visual studio 2012\Projects\SynchronicWorld\SynchronicWorld.DAL\SynchronicWorldLocalDatabase.sdf")
        //: base("SynchronicWorldContext")
        public SynchronicWorldContext()
        {
        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MyDbContextInitializer());

            base.OnModelCreating(modelBuilder);
        }
    }

    public class MyDbContextInitializer : DropCreateDatabaseIfModelChanges<SynchronicWorldContext>
    {
        protected override void Seed(SynchronicWorldContext dbContext)
        {
            //base.Seed(dbContext);
        }
    }
}
