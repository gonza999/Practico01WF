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
    public class RepositorioTipoDePlanta : IRepositorioTipoDePlanta
    {
        private ViveroDbContext context;

        public RepositorioTipoDePlanta()
        {
            context = new ViveroDbContext();
        }
        public bool EstaRelacionado(TipoDePlanta tipoDePlanta)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            try
            {
                return context.TiposDePlantas.Count();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool Existe(TipoDePlanta tipoDePlanta)
        {
            try
            {
                if (tipoDePlanta.TipoDePlantaId==0)
                {
                    return context.TiposDePlantas.Any(tp => tp.Descripcion == tipoDePlanta.Descripcion);
                }

                return context.TiposDePlantas.Any(tp =>
                    tp.Descripcion == tipoDePlanta.Descripcion &&
                    tp.TipoDePlantaId != tipoDePlanta.TipoDePlantaId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<TipoDePlanta> GetLista()
        {
            try
            {
                return context.TiposDePlantas
                    .OrderBy(tp=>tp.Descripcion)
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }

        public TipoDePlanta GetTipoDePlantaPorId(int id)
        {
            try
            {
                return context.TiposDePlantas.SingleOrDefault(tp=>tp.TipoDePlantaId==id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public void Guardar(TipoDePlanta tipoDePlanta)
        {
            try
            {
                if (tipoDePlanta.TipoDePlantaId==0)
                {
                    context.TiposDePlantas.Add(tipoDePlanta);
                }
                else
                {
                    var tipoPlantaInDb = context.TiposDePlantas.SingleOrDefault(tp=>
                        tp.TipoDePlantaId==tipoDePlanta.TipoDePlantaId);
                    if (tipoPlantaInDb==null)
                    {
                        throw new Exception("Tipo de planta inexistente");
                    }
                    tipoPlantaInDb.Descripcion = tipoDePlanta.Descripcion;
                    context.Entry(tipoPlantaInDb).State = EntityState.Modified;
                }
                context.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int id)
        {
            TipoDePlanta tipoPInDb=null;
            try
            {
                tipoPInDb = context.TiposDePlantas.SingleOrDefault(tp=>tp.TipoDePlantaId==id);
                if (tipoPInDb==null)
                {
                    return;
                }
                context.Entry(tipoPInDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                context.Entry(tipoPInDb).State = EntityState.Unchanged;
                throw new Exception(e.Message);
            }
        }
    }
}
