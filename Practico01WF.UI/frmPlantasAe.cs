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
        }
    }
}
