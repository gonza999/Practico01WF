using Practico01WF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01WF.Services.Servicios.Facades
{
    public interface IServicioPlanta
    {
        List<Planta> GetLista(int cantidad, int pagina);

        List<Planta> Find(Func<Planta, bool> predicate, int cantidad, int pagina);

        Planta GetPlantaPorId(int id);

        void Guardar(Planta planta);

        bool Existe(Planta planta);

        int GetCantidad();

        int GetCantidad(Func<Planta, bool> predicate);


        void Borrar(int id);
    }
}
