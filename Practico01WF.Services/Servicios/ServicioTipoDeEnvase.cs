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
    public class ServicioTipoDeEnvase:IServicioTipoDeEnvase
    {
        private IRepositorioTipoDeEnvase repositorioTipoDeEnvase;

        public ServicioTipoDeEnvase()
        {
            repositorioTipoDeEnvase = new RepositorioTipoDeEnvase();
        }
        public bool EstaRelacionado(TipoDeEnvase tipoDeEnvase)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            try
            {
                return repositorioTipoDeEnvase.GetCantidad();
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
                return repositorioTipoDeEnvase.Existe(tipoDeEnvase);
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
                return repositorioTipoDeEnvase.GetLista();
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
                return repositorioTipoDeEnvase.GetTipoDeEnvasePorId(id);
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
                repositorioTipoDeEnvase.Guardar(tipoDeEnvase);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
