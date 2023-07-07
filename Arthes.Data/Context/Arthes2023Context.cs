using System.Data.Entity;

using Arthes.Data.Maps;
using Arthes.Domain.Entities;

namespace Arthes.Data.Context
{
    public class Arthes2023Context : DbContext
    {
        public Arthes2023Context() : base("ArthesConn")
        {
            //Database.SetInitializer<Arthes2023Context>(new DropCreateDatabaseAlways<Arthes2023Context>());
            //Database.SetInitializer(new RevistaDBInitializer());
        }

        /*-----ENTIDADES-----*/
        public DbSet<Revista> Revistas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            _ = modelBuilder.Configurations.Add(new RevistaMap());
        }
    }
}
