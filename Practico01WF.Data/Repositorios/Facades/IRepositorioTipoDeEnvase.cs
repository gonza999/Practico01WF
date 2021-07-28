using Practico01WF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01WF.Data.Repositorios.Facades
{
    public interface IRepositorioTipoDeEnvase
    {
        List<TipoDeEnvase> GetLista();

        TipoDeEnvase GetTipoDeEnvasePorId(int id);
        void Guardar(TipoDeEnvase tipoDeEnvase);

        bool Existe(TipoDeEnvase tipoDeEnvase);

        bool EstaRelacionado(TipoDeEnvase tipoDeEnvase);
        int GetCantidad();
    }
}
