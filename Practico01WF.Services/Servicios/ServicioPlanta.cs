using Practico01WF.Data.Repositorios;
using Practico01WF.Data.Repositorios.Facades;
using Practico01WF.Entities;
using Practico01WF.Services.Servicios.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01WF.Services.Servicios
{
    public class ServicioPlanta : IServicioPlanta
    {
        private IRepositorioPlanta repositorioPlanta;
        public ServicioPlanta()
        {
            repositorioPlanta = new RepositorioPlanta();
        }
        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Planta planta)
        {
            throw new NotImplementedException();
        }

        public List<Planta> Find(Func<Planta, bool> predicate, int cantidad, int pagina)
        {
            try
            {
                return repositorioPlanta.Find(predicate,cantidad,pagina);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }

        public int GetCantidad()
        {
            try
            {
                return repositorioPlanta.GetCantidad();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }

        public int GetCantidad(Func<Planta, bool> predicate)
        {
            try
            {
                return repositorioPlanta.GetCantidad(predicate);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }

        public List<Planta> GetLista(int cantidad, int pagina)
        {
            try
            {
                return repositorioPlanta.GetLista(cantidad,pagina);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }

        public Planta GetPlantaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Planta planta)
        {
            throw new NotImplementedException();
        }
    }
}
