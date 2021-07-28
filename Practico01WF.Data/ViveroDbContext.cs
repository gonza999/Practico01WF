using Practico01WF.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;

namespace Practico01WF.Data
{
    public class ViveroDbContext : DbContext
    {
        public ViveroDbContext()
            : base("name=ViveroDbContext")
        {
        }

        public virtual DbSet<Planta> Plantas { get; set; }
        public virtual DbSet<TipoDeEnvase> TiposDeEnvases { get; set; }
        public virtual DbSet<TipoDePlanta> TiposDePlantas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           Database.SetInitializer<ViveroDbContext>(null);
           modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
           modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
