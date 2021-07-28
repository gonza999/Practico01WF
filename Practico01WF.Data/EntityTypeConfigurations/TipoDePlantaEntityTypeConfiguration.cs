using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Entities;

namespace Practico01WF.Data.EntityTypeConfigurations
{
    public class TipoDePlantaEntityTypeConfiguration:EntityTypeConfiguration<TipoDePlanta>
    {
        public TipoDePlantaEntityTypeConfiguration()
        {
            ToTable("TiposDePlantas");
            HasKey(tp=>tp.TipoDePlantaId);
            Property(tp =>tp.Descripcion).IsRequired().HasMaxLength(50);
        }


    }
}
