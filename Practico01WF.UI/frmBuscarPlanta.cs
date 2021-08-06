using Practico01WF.Entities;
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
    public partial class frmBuscarPlanta : Form
    {
        public frmBuscarPlanta()
        {
            InitializeComponent();
        }

        private void frmBuscarPlanta_Load(object sender, EventArgs e)
        {
            HelperCombo.CargarComboTipoEnvase(ref TipoEnvaseCmb);
            HelperCombo.CargarComboTipoPlanta(ref TipoPlantaCmb);
        }

        private void CancelPbx_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkPbx_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            var valido = true;
            if (TipoEnvaseCmb.SelectedIndex==0 && TipoDeEnvaseRbn.Checked)
            {
                valido = false;
                errorProvider1.SetError(TipoEnvaseCmb,"Debe seleccionar un tipo de envase");
            }
            if (TipoPlantaCmb.SelectedIndex == 0 && TipoDePlantaRbn.Checked)
            {
                valido = false;
                errorProvider1.SetError(TipoPlantaCmb, "Debe seleccionar un tipo de planta");
            }
            return valido;
        }

        private void TipoDePlantaRbn_CheckedChanged(object sender, EventArgs e)
        {
            if (TipoDePlantaRbn.Checked)
            {
                TipoPlantaCmb.Enabled = true;
            }
            else
            {
                TipoPlantaCmb.Enabled = false;
                tipoDePlanta = null;
            }
        }
        private TipoDePlanta tipoDePlanta=null;
        private TipoDeEnvase tipoDeEnvase=null;
        private void TipoDeEnvaseRbn_CheckedChanged(object sender, EventArgs e)
        {
            if (TipoDeEnvaseRbn.Checked)
            {
                TipoEnvaseCmb.Enabled = true;
            }
            else
            {
                TipoEnvaseCmb.Enabled = false;
                tipoDeEnvase = null;
            }
        }

        public TipoDeEnvase GetTipoDeEnvase()
        {
            return tipoDeEnvase;
        }
        public TipoDePlanta GetTipoDePlanta()
        {
            return tipoDePlanta;
        }

        private void TipoPlantaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoPlantaCmb.SelectedIndex>0)
            {
                tipoDePlanta =(TipoDePlanta) TipoPlantaCmb.SelectedItem;
                tipoDeEnvase = null;
            }
        }

        private void TipoEnvaseCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoEnvaseCmb.SelectedIndex > 0)
            {
                tipoDeEnvase = (TipoDeEnvase)TipoEnvaseCmb.SelectedItem;
                tipoDePlanta = null;
            }
        }
    }
}
