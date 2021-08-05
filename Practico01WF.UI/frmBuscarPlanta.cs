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
            if (TipoDeEnvaseRbn.Checked && !TipoDePlantaRbn.Checked)
            {

            }
            else if (TipoDePlantaRbn.Checked && !TipoDeEnvaseRbn.Checked)
            {

            }
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
            }
        }

        private void TipoDeEnvaseRbn_CheckedChanged(object sender, EventArgs e)
        {
            if (TipoDeEnvaseRbn.Checked)
            {
                TipoEnvaseCmb.Enabled = true;
            }
            else
            {
                TipoEnvaseCmb.Enabled = false;
            }
        }
    }
}
