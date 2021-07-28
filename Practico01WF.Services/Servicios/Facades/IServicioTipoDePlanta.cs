﻿using Practico01WF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01WF.Services.Servicios.Facades
{
    public interface IServicioTipoDePlanta
    {
        List<TipoDePlanta> GetLista();

        TipoDePlanta GetTipoDePlantaPorId(int id);
        void Guardar(TipoDePlanta tipoDePlanta);

        bool Existe(TipoDePlanta tipoDePlanta);

        bool EstaRelacionado(TipoDePlanta tipoDePlanta);
        int GetCantidad();
        void Borrar(int id);
    }
}