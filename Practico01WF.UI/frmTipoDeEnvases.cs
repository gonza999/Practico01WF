using Practico01WF.Entities;
using Practico01WF.Services.Servicios;
using Practico01WF.Services.Servicios.Facades;
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
    public partial class frmTipoDeEnvases : Form
    {
        public frmTipoDeEnvases()
        {
            InitializeComponent();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IServicioTipoDeEnvase servicio;
        private List<TipoDeEnvase> listaDeEnvases;
        private int cantidad;

        private void frmTipoDeEnvases_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioTipoDeEnvase();
                listaDeEnvases = servicio.GetLista();
                cantidad = servicio.GetCantidad();
                MostrarDatosEnGrilla();
                ModificarCantidad();

            }
            catch (Exception ex)
            {

            }
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDgv.Rows.Clear();
            foreach (var tp in listaDeEnvases)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, tp);
                AgregarFila(r);
            }

        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDgv.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TipoDeEnvase tp)
        {
            r.Cells[cmnTipoDeEnvase.Index].Value= tp.Descripcion;
            r.Tag = tp;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDgv);
            return r;
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            frmTipoDeEnvasesAe frm = new frmTipoDeEnvasesAe();
            frm.Text = "Nuevo tipo de planta";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    TipoDeEnvase tipoDeEnvase = frm.GetTipo();
                    if (!servicio.Existe(tipoDeEnvase))
                    {
                        servicio.Guardar(tipoDeEnvase);
                        var r = ConstruirFila();
                        SetearFila(r, tipoDeEnvase);
                        AgregarFila(r);
                        ModificarCantidad();
                        MessageBox.Show("Registro guardado", "Guardado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un Tipo de Envase con la " +
                                        "misma Descripción", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ModificarCantidad()
        {
            cantidad = servicio.GetCantidad();
            CantidadLbl.Text = cantidad.ToString();
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            if (DatosDgv.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                DataGridViewRow r = DatosDgv.SelectedRows[0];
                TipoDeEnvase tipoDeEnvase = (TipoDeEnvase)r.Tag;

                frmTipoDeEnvasesAe frm = new frmTipoDeEnvasesAe() { Text = "Editar" };
                frm.SetTipoDeEnvase(tipoDeEnvase);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    tipoDeEnvase = frm.GetTipo();
                    if (!servicio.Existe(tipoDeEnvase))
                    {
                        servicio.Guardar(tipoDeEnvase);
                        SetearFila(r, tipoDeEnvase);
                        MessageBox.Show("Registro Editado", "Editado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un Tipo de Envase con la " +
                                        "misma Descripción", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
