
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class APIDbContext :DbContext
    {
        public APIDbContext() : base("ApiConnection")
        {

        }
        static APIDbContext()
        {
            Database.SetInitializer<APIDbContext>(new IdentityDbInit());
        }

        public static APIDbContext create()
        {
            return new APIDbContext();
        }
        public override int SaveChanges()
        {

            return base.SaveChanges();
        }
        internal class IdentityDbInit : DropCreateDatabaseIfModelChanges<APIDbContext>
        {
            public void Seed(APIDbContext context)
            {
                PerformInit();
                base.Seed(context);
            }

            public void PerformInit()
            {

            }
        }
        public DbSet<City> Citys { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Country> Countrys { get; set; }

    }
}
