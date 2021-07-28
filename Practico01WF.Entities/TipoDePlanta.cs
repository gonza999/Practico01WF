using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practico01WF.Entities
{
    public class TipoDePlanta:ICloneable
    {
        public TipoDePlanta()
        {

        }
        public int TipoDePlantaId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Planta> Plantas { get; set; } = new HashSet<Planta>();

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
