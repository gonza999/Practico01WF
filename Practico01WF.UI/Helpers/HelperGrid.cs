using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico01WF.UI.Helpers
{
    public class HelperGrid
    {
        public static void LimpiarGrilla(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        internal static DataGridViewRow CrearFila(DataGridView datosDgv)
        {
            var r = new DataGridViewRow();
            r.CreateCells(datosDgv);
            return r;
        }

        internal static void AgregarFila(DataGridViewRow r, DataGridView datosDgv)
        {
            datosDgv.Rows.Add(r);
        }

        internal static void BorrarFila(DataGridViewRow r, DataGridView datosDgv)
        {
            datosDgv.Rows.Remove(r);
        }
    }
}
