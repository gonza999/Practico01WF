using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Entities;

namespace Practico01WF.Data.EntityTypeConfigurations
{
    public class TipoDeEnvaseEntityTypeConfiguration:EntityTypeConfiguration<TipoDeEnvase>
    {
        public TipoDeEnvaseEntityTypeConfiguration()
        {
            ToTable("TiposDeEnvases");
            HasKey(te => te.TipoDeEnvaseId);
            Property(te => te.Descripcion).IsRequired().HasMaxLength(50);
        }
    }
}
