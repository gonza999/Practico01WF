using Practico01WF.Entities;
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
using Practico01WF.Services.Servicios;
using Practico01WF.UI.Helpers;

namespace Practico01WF.UI
{
    public partial class frmTipoDePlantas : Form
    {
        public frmTipoDePlantas()
        {
            InitializeComponent();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IServicioTipoDePlanta servicio;
        private List<TipoDePlanta> listaDePlantas;
        private int cantidad;
        
        private void frmTipoDePlantas_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioTipoDePlanta();
                listaDePlantas = servicio.GetLista();
                cantidad = servicio.GetCantidad();
                MostrarDatosEnGrilla();
                ModificarCantidad();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosDgv);
            foreach (var tp in listaDePlantas)
            {
                DataGridViewRow r = HelperGrid.CrearFila(DatosDgv);
               
                SetearFila(r, tp);
                HelperGrid.AgregarFila(r,DatosDgv);
            }

        }

        private void SetearFila(DataGridViewRow r, TipoDePlanta tp)
        {
            r.Cells[cmnTipoDePlanta.Index].Value = tp.Descripcion;
            r.Tag = tp;
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            frmTipoDePlantasAe frm = new frmTipoDePlantasAe();
            frm.Text = "Nuevo tipo de planta";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    TipoDePlanta tipoDePlanta = frm.GetTipo();
                    if (!servicio.Existe(tipoDePlanta))
                    {
                        servicio.Guardar(tipoDePlanta);
                        var r = HelperGrid.CrearFila(DatosDgv);
                        SetearFila(r, tipoDePlanta);
                        HelperGrid.AgregarFila(r, DatosDgv);
                        ModificarCantidad();
                        MessageBox.Show("Registro guardado", "Guardado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un Tipo de Planta con la " +
                                        "misma Descripción", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            if (DatosDgv.SelectedRows.Count==0)
            {
                return;
            }

           
                DataGridViewRow r = DatosDgv.SelectedRows[0];
                TipoDePlanta tipoDePlanta = (TipoDePlanta)r.Tag;
                TipoDePlanta tipoDePlantaCopia = (TipoDePlanta)tipoDePlanta.Clone();
                frmTipoDePlantasAe frm = new frmTipoDePlantasAe() { Text = "Editar" };
                frm.SetTipoDePlanta(tipoDePlanta);
            try
            {
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    tipoDePlanta = frm.GetTipo();
                    if (!servicio.Existe(tipoDePlanta))
                    {
                        servicio.Guardar(tipoDePlanta);
                        SetearFila(r,tipoDePlanta);
                        MessageBox.Show("Registro Editado", "Editado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SetearFila(r, tipoDePlantaCopia);
                        MessageBox.Show("Ya existe un Tipo de Planta con la " +
                                        "misma Descripción", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                SetearFila(r, tipoDePlantaCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            if (DatosDgv.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = DatosDgv.SelectedRows[0];
            TipoDePlanta tipoDePlanta = (TipoDePlanta)r.Tag;
            DialogResult dr = MessageBox.Show($"Desea dar de baja el registro de {tipoDePlanta.Descripcion}?",
                "Borrar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.No)
            {
                return;
            }

            try
            {
                //if (!servicio.EstaRelacionado(tipoDePlanta))
                //{
                    servicio.Borrar(tipoDePlanta.TipoDePlantaId);
                    HelperGrid.BorrarFila(r, DatosDgv);
                    MessageBox.Show("Registro borrado con exito",
                    "Borrar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("El registro esta relacionado", "Error",
                //            MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
