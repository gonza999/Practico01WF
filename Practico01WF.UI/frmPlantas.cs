using Practico01WF.Entities;
using Practico01WF.Entities.Enums;
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
        private Filtro filtro=Filtro.off;
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
                InicializarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void CreateButtons(int paginas)
        {
            BotonesPnl.Controls.Clear();
            for (int i = 0; i < paginas; i++)
            {
                Button b = new Button();
                b.Text = $"{i + 1}";
                b.Location=new Point(15+(32*i), 28);
                b.Size = new Size(30,30);
                b.BackColor = Color.Black;
                b.ForeColor = Color.White;
                b.FlatStyle = FlatStyle.Popup;
                b.Click += MiClick;//se agrega un manejador al evento
                BotonesPnl.Controls.Add(b);
            }
        }

        private void MiClick(object sender, EventArgs e)
        {
            Button b =(Button) sender;
            paginaActual =int.Parse( b.Text);
            MostrarPaginado(paginaActual);
        }

        private int CalcularCantidadPorPaginas(int cantidad,int cantidadPorPaginas)
        {
            if (cantidad< cantidadPorPaginas)
            {
                return 1;
            }
            if (cantidad%cantidadPorPaginas>0)
            {
               return cantidad / (cantidadPorPaginas + 1);
            }
            else
            {
                return cantidad / cantidadPorPaginas;
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

        //private void SiguienteBtn_Click(object sender, EventArgs e)
        //{
        //    paginaActual++;
        //    if (paginaActual>CantidadPaginas)
        //    {
        //        paginaActual = CantidadPaginas;
        //    }
        //    MostrarPaginado(paginaActual);
        //}

        //private void AnteriorBtn_Click(object sender, EventArgs e)
        //{
        //    paginaActual--;
        //    if (paginaActual < 1)
        //    {
        //        paginaActual = 1;
        //    }
        //    MostrarPaginado(paginaActual);
        //}

        //private void UltimoBtn_Click(object sender, EventArgs e)
        //{
        //    paginaActual = CantidadPaginas;
        //    MostrarPaginado(paginaActual);
        //}

        //private void PrimeroBtn_Click(object sender, EventArgs e)
        //{
        //    paginaActual = 1;
        //    MostrarPaginado(paginaActual);
        //}

        private void MostrarPaginado(int paginaActual)
        {
            if (filtro==Filtro.off)
            {
                lista = servicio.GetLista(CantidadPorPaginas, paginaActual);
            }
            else if (filtro==Filtro.TipoPlanta)
            {
                lista = servicio.Find(p => p.TipoDePlantaId == filtroPlanta.TipoDePlantaId, CantidadPorPaginas, paginaActual);
            }
            else if (filtro==Filtro.TipoEnvase)
            {
                lista = servicio.Find(p => p.TipoDeEnvaseId == filtroEnvase.TipoDeEnvaseId, CantidadPorPaginas, paginaActual);

            }
            MostrarDatosEnGrilla();

        }
        private TipoDeEnvase filtroEnvase;
        private TipoDePlanta filtroPlanta;
        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            frmBuscarPlanta frm = new frmBuscarPlanta();
            frm.Text = "Buscar Planta";
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                BuscarBtn.Image = Properties.Resources.search_more_40px;
                BuscarBtn.BackColor = Color.Orange;
                if (frm.GetTipoDePlanta()!=null)
                {
                    try
                    {
                        filtroPlanta = frm.GetTipoDePlanta();
                        filtro = Filtro.TipoPlanta;
                        Cantidad = servicio.GetCantidad(p => p.TipoDePlantaId == filtroPlanta.TipoDePlantaId);
                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }
                }
                else if(frm.GetTipoDeEnvase() != null)
                {
                    try
                    {
                        filtroEnvase = frm.GetTipoDeEnvase();
                        filtro = Filtro.TipoEnvase;
                        Cantidad = servicio.GetCantidad(p => p.TipoDeEnvaseId == filtroEnvase.TipoDeEnvaseId);                        
                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }
                }
                paginaActual = 1;
                CantidadPaginas = CalcularCantidadPorPaginas(Cantidad, CantidadPorPaginas);
                CreateButtons(CantidadPaginas);
                MostrarPaginado(paginaActual);
            }
           
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            BuscarBtn.Image = Properties.Resources.search_40px;
            BuscarBtn.BackColor = Color.Transparent;
            try
            {
                filtro = Filtro.off;
                InicializarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicializarGrilla()
        {
            paginaActual = 1;
            Cantidad = servicio.GetCantidad();
            CantidadPaginas = CalcularCantidadPorPaginas(Cantidad, CantidadPorPaginas);
            CreateButtons(CantidadPaginas);
            MostrarPaginado(paginaActual);
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            frmPlantasAe frm = new frmPlantasAe()
            {
                Text = "Nuevo"
            };
            DialogResult dr = frm.ShowDialog(this);
            InicializarGrilla();
            if (dr == DialogResult.OK)
            {
                try
                {
                    Planta planta = frm.GetPlanta();
                    if (servicio.Existe(planta))
                    {
                        MessageBox.Show("Planta existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    servicio.Guardar(planta);
                    DataGridViewRow r = HelperGrid.CrearFila(DatosDgv);
                    HelperGrid.SetearFila(r, planta);
                    HelperGrid.AgregarFila(r,DatosDgv);
                    Cantidad = servicio.GetCantidad();
                    MessageBox.Show("Registro guardado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            if (DatosDgv.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosDgv.SelectedRows[0];
            Planta planta = (Planta)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el registro de {planta.Descripcion}?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                servicio.Borrar(planta.PlantaId);
                HelperGrid.BorrarFila(r,DatosDgv);

                Cantidad = servicio.GetCantidad();
                CantidadLbl.Text = Cantidad.ToString();
                CantidadPaginas = CalcularCantidadPorPaginas(Cantidad, CantidadPorPaginas);
                CreateButtons(CantidadPaginas);

                MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Registro relacionado... Baja denegada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            if (DatosDgv.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosDgv.SelectedRows[0];
            Planta planta = (Planta)r.Tag;
            Planta plantaCopia = (Planta)planta.Clone();
            frmPlantasAe frm = new frmPlantasAe() { Text = "Editar Planta" };
            frm.SetPlanta(planta);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            MostrarPaginado(paginaActual);
            try
            {
                planta = frm.GetPlanta();
                if (servicio.Existe(planta))
                {
                    HelperGrid.SetearFila(r, plantaCopia);
                    MessageBox.Show("Tipo de Planta existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                servicio.Guardar(planta);
                HelperGrid.SetearFila(r, planta);
                MessageBox.Show("Registro Editado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r, plantaCopia);
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
