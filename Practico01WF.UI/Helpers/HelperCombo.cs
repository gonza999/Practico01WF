using Practico01WF.Entities;
using Practico01WF.Services.Servicios;
using Practico01WF.Services.Servicios.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico01WF.UI.Helpers
{
    public class HelperCombo
    {
        public static void CargarComboTipoPlanta(ref ComboBox combo)
        {
            IServicioTipoDePlanta servicio=new ServicioTipoDePlanta();
            List<TipoDePlanta> lista = new List<TipoDePlanta>();
            lista = servicio.GetLista();
            TipoDePlanta defaultTipo = new TipoDePlanta()
            {
                TipoDePlantaId = 0,
                Descripcion = "--Seleccione--"
            };
            lista.Insert(0,defaultTipo);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TipoDePlantaId";
            combo.SelectedIndex = 0;
        }
        public static void CargarComboTipoEnvase(ref ComboBox combo)
        {
            IServicioTipoDeEnvase servicio = new ServicioTipoDeEnvase();
            List<TipoDeEnvase> lista = new List<TipoDeEnvase>();
            lista = servicio.GetLista();
            TipoDeEnvase defaultTipo = new TipoDeEnvase()
            {
                TipoDeEnvaseId = 0,
                Descripcion = "--Seleccione--"
            };
            lista.Insert(0, defaultTipo);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TipoDeEnvaseId";
            combo.SelectedIndex = 0;
        }
    }
}
