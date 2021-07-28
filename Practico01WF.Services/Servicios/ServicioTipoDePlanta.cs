using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Data.Repositorios;
using Practico01WF.Data.Repositorios.Facades;
using Practico01WF.Entities;
using Practico01WF.Services.Servicios.Facades;

namespace Practico01WF.Services.Servicios
{
    public class ServicioTipoDePlanta : IServicioTipoDePlanta
    {
        private IRepositorioTipoDePlanta repositorioTipoDePlanta;

        public ServicioTipoDePlanta()
        {
            repositorioTipoDePlanta = new RepositorioTipoDePlanta();
        }
        public bool EstaRelacionado(TipoDePlanta tipoDePlanta)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            try
            {
                return repositorioTipoDePlanta.GetCantidad();
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
                return repositorioTipoDePlanta.Existe(tipoDePlanta);
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
                return repositorioTipoDePlanta.GetLista();
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
                return repositorioTipoDePlanta.GetTipoDePlantaPorId(id);
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
                repositorioTipoDePlanta.Guardar(tipoDePlanta);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int id)
        {
            try
            {
                repositorioTipoDePlanta.Borrar(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
