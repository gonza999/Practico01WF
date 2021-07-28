using Practico01WF.Entities;
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
    public partial class frmTipoDeEnvasesAe : Form
    {
        public frmTipoDeEnvasesAe()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoDeEnvase != null)
            {
                TipoDeEnvaseTxt.Text = tipoDeEnvase.Descripcion;
            }
        }

        private TipoDeEnvase tipoDeEnvase;
        internal TipoDeEnvase GetTipo()
        {
            return tipoDeEnvase;
        }

        private void CancelPbx_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkPbx_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDeEnvase == null)
                {
                    tipoDeEnvase = new TipoDeEnvase();
                }

                tipoDeEnvase.Descripcion = TipoDeEnvaseTxt.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TipoDeEnvaseTxt.Text))
            {
                valido = false;
                errorProvider1.SetError(TipoDeEnvaseTxt, "Debe ingresar un Tipo de Envase");
            }
            return true;
        }

        internal void SetTipoDeEnvase(TipoDeEnvase tipoDeEnvase)
        {
            this.tipoDeEnvase = tipoDeEnvase;
        }
    }

}
