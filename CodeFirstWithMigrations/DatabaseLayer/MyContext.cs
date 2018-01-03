using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class MyContext : DbContext
    {
        public MyContext() : base("TimeDb")
        {
            // Disable db migration
            Database.SetInitializer<MyContext>(null);
        }

        public DbSet<TimeLogItem> TimeLogItems { get; set; }
    }
}
