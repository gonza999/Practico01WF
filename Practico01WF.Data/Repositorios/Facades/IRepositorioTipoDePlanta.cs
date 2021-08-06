using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico01WF.Entities;

namespace Practico01WF.Data.Repositorios.Facades
{
    public interface IRepositorioTipoDePlanta
    {
        List<TipoDePlanta> GetLista();

        TipoDePlanta GetTipoDePlantaPorId(int id);
        void Guardar(TipoDePlanta tipoDePlanta);

        bool Existe(TipoDePlanta tipoDePlanta);

        bool EstaRelacionado(TipoDePlanta tipoDePlanta);
        int GetCantidad();
        void Borrar(int id);

        List<IGrouping<int, Planta>> GetGrupos();
    }
}
