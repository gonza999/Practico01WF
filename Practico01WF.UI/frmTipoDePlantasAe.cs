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
    public partial class frmTipoDePlantasAe : Form
    {
        public frmTipoDePlantasAe()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoDePlanta!=null)
            {
                TipoDePlantaTxt.Text = tipoDePlanta.Descripcion;
            }
        }

        private TipoDePlanta tipoDePlanta;
        internal TipoDePlanta GetTipo()
        {
            return tipoDePlanta;
        }

        private void CancelPbx_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkPbx_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDePlanta==null)
                {
                    tipoDePlanta = new TipoDePlanta();
                }

                tipoDePlanta.Descripcion = TipoDePlantaTxt.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TipoDePlantaTxt.Text))
            {
                valido = false;
                errorProvider1.SetError(TipoDePlantaTxt,"Debe ingresar un Tipo de Planta");
            }
            return true;
        }

        internal void SetTipoDePlanta(TipoDePlanta tipoDePlanta)
        {
            this.tipoDePlanta = tipoDePlanta;
        }
    }
}
