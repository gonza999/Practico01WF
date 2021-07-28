using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Entities;

namespace Practico01WF.Data.EntityTypeConfigurations
{
    public class PlantaEntityTypeConfiguration:EntityTypeConfiguration<Planta>
    {
        public PlantaEntityTypeConfiguration()
        {
            ToTable("Plantas");
            HasKey(p=>p.PlantaId);
            Property(p => p.Descripcion).IsRequired().HasMaxLength(50);
        }
    }
}
