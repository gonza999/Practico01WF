using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practico01WF.Entities
{
    public class TipoDeEnvase
    {
        public TipoDeEnvase()
        {

        }

        public int TipoDeEnvaseId { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<Planta> Plantas { get; set; } = new HashSet<Planta>();
    }
}
