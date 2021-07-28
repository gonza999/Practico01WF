using Practico01WF.Data.Repositorios.Facades;
using Practico01WF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01WF.Data.Repositorios
{
    public class RepositorioPlanta : IRepositorioPlanta
    {
        private ViveroDbContext context;
        public RepositorioPlanta()
        {
            context = new ViveroDbContext();
        }
        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Planta planta)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            try
            {
                return context.Plantas.Count();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }

        public List<Planta> GetLista(int cantidad,int pagina)
        {
            try
            {
                return context.Plantas.AsNoTracking()
                    .OrderBy(p => p.PlantaId)
                    .Skip(cantidad * (pagina - 1))
                    .Take(cantidad).
                    ToList();
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
