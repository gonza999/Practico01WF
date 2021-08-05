using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Data.Repositorios.Facades;
using Practico01WF.Entities;

namespace Practico01WF.Data.Repositorios
{
    public class RepositorioTipoDeEnvase:IRepositorioTipoDeEnvase
    {
        private ViveroDbContext context;

        public RepositorioTipoDeEnvase()
        {
            context = new ViveroDbContext();
        }
        public bool EstaRelacionado(TipoDeEnvase tipoDeEnvase)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            try
            {
                return context.TiposDeEnvases.Count();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool Existe(TipoDeEnvase tipoDeEnvase)
        {
            try
            {
                if (tipoDeEnvase.TipoDeEnvaseId == 0)
                {
                    return context.TiposDeEnvases.Any(tp => tp.Descripcion == tipoDeEnvase.Descripcion);
                }

                return context.TiposDeEnvases.Any(tp =>
                    tp.Descripcion == tipoDeEnvase.Descripcion &&
                    tp.TipoDeEnvaseId != tipoDeEnvase.TipoDeEnvaseId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<TipoDeEnvase> GetLista()
        {
            try
            {
                return context.TiposDeEnvases
                    .OrderBy(te=>te.Descripcion)
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public TipoDeEnvase GetTipoDeEnvasePorId(int id)
        {
            try
            {
                return context.TiposDeEnvases.SingleOrDefault(tp => tp.TipoDeEnvaseId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public void Guardar(TipoDeEnvase tipoDeEnvase)
        {
            try
            {
                if (tipoDeEnvase.TipoDeEnvaseId == 0)
                {
                    context.TiposDeEnvases.Add(tipoDeEnvase);
                }
                else
                {
                    var tipoEnvaseInDb = context.TiposDeEnvases.SingleOrDefault(tp =>
                        tp.TipoDeEnvaseId == tipoDeEnvase.TipoDeEnvaseId);
                    if (tipoEnvaseInDb == null)
                    {
                        throw new Exception("Tipo de planta inexistente");
                    }
                    tipoEnvaseInDb.Descripcion = tipoDeEnvase.Descripcion;
                    context.Entry(tipoEnvaseInDb).State = EntityState.Modified;
                }
                context.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
