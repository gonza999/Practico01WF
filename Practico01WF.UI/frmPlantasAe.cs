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
    public partial class frmPlantasAe : Form
    {
        public frmPlantasAe()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombo.CargarComboTipoEnvase(ref TipoEnvaseCmb);
            HelperCombo.CargarComboTipoPlanta(ref TipoPlantaCmb);
            servicio = new ServicioPlanta();
            if (planta != null)
            {
                PlantaTxt.Text = planta.Descripcion;
                TipoEnvaseCmb.SelectedValue = planta.TipoDeEnvaseId;
                TipoPlantaCmb.SelectedValue = planta.TipoDePlantaId;
                operacion = OperacionBd.Editar;
            }
        }
        private Planta planta;
        private IServicioPlanta servicio=new ServicioPlanta();
        private OperacionBd operacion = OperacionBd.Alta;

        private void CancelPbx_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkPbx_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (planta==null)
                {
                    planta = new Planta();
                }
                planta.Descripcion = PlantaTxt.Text;
                planta.TipoDeEnvaseId = ((TipoDeEnvase)TipoEnvaseCmb.SelectedItem).TipoDeEnvaseId;
                planta.TipoDePlantaId = ((TipoDePlanta)TipoPlantaCmb.SelectedItem).TipoDePlantaId;


                try
                {
                    if (servicio.Existe(planta))
                    {
                        errorProvider1.SetError(OkPbx,"Planta existente");
                        return;
                    }
                    servicio.Guardar(planta);
                    MessageBox.Show("Registro guardado","Guardado",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);

                    if (operacion == OperacionBd.Editar)
                    {
                        DialogResult = DialogResult.OK;
                        return;

                    }
                    DialogResult dr = MessageBox.Show("¿Desea dar de alta otro registro?", "Confirmar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.No)
                    {
                        DialogResult = DialogResult.Cancel;
                    }

                    planta = null;
                    InicializarControles();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }
        private void InicializarControles()
        {
            PlantaTxt.Clear();
            TipoEnvaseCmb.SelectedIndex = 0;
            TipoPlantaCmb.SelectedIndex = 0;
            PlantaTxt.Focus();
        }
        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            var valido = true;
            if (string.IsNullOrEmpty(PlantaTxt.Text))
            {
                valido = false;
                errorProvider1.SetError(PlantaTxt, "Debe ingresar una planta");
            }
            if (TipoEnvaseCmb.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TipoEnvaseCmb, "Debe seleccionar un tipo de envase");
            }
            if (TipoPlantaCmb.SelectedIndex == 0 )
            {
                valido = false;
                errorProvider1.SetError(TipoPlantaCmb, "Debe seleccionar un tipo de planta");
            }
            return valido;
        }

        public Planta GetPlanta()
        {
            return planta;
        }

        public void SetPlanta(Planta planta)
        {
            this.planta = planta;
        }

    }
}
