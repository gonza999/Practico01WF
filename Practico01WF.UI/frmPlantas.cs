using Practico01WF.Entities;
using Practico01WF.Services.Servicios;
using Practico01WF.Services.Servicios.Facades;
using Practico01WF.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico01WF.UI
{
    public partial class frmPlantas : Form
    {
        public frmPlantas()
        {
            InitializeComponent();
        }
        private IServicioPlanta servicio;
        private List<Planta> lista;
        private int Cantidad;
        private int CantidadPaginas;
        private int CantidadPorPaginas=20;
        private int paginaActual;
        private void frmPlantas_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioPlanta();
                paginaActual = 1;
                Cantidad = servicio.GetCantidad();
                CantidadPaginas = Cantidad / CantidadPorPaginas+1;
                MostrarPaginado(paginaActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosDgv);
            foreach (var p in lista)
            {
                var r = HelperGrid.CrearFila(DatosDgv);
                SetearFila(r,p);
                HelperGrid.AgregarFila(r,DatosDgv);
            }
            CantidadLbl.Text = Cantidad.ToString();
            CantidadPaginasLbl.Text = CantidadPaginas.ToString();
            PaginaActualLbl.Text = paginaActual.ToString();
        }

        private void SetearFila(DataGridViewRow r, Planta p)
        {
            r.Cells[CmnPlanta.Index].Value = p.Descripcion;
            r.Cells[CmnTipoPlanta.Index].Value = p.TipoDePlanta.Descripcion;
            r.Cells[cmnTipoEnvase.Index].Value = p.TipoDeEnvase.Descripcion;
            r.Tag = p;
        }

        private void SiguienteBtn_Click(object sender, EventArgs e)
        {
            paginaActual++;
            if (paginaActual>CantidadPaginas)
            {
                paginaActual = CantidadPaginas;
            }
            MostrarPaginado(paginaActual);
        }

        private void AnteriorBtn_Click(object sender, EventArgs e)
        {
            paginaActual--;
            if (paginaActual < 1)
            {
                paginaActual = 1;
            }
            MostrarPaginado(paginaActual);
        }

        private void UltimoBtn_Click(object sender, EventArgs e)
        {
            paginaActual = CantidadPaginas;
            MostrarPaginado(paginaActual);
        }

        private void PrimeroBtn_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            MostrarPaginado(paginaActual);
        }

        private void MostrarPaginado(int paginaActual)
        {
            lista = servicio.GetLista(CantidadPorPaginas, paginaActual);
            MostrarDatosEnGrilla();
        }

    }
}
