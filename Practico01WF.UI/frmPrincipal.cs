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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void CerrarPbx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CerrarPbx_MouseHover(object sender, EventArgs e)
        {
            CerrarPbx.BorderStyle = BorderStyle.Fixed3D;
        }

        private void CerrarPbx_MouseLeave(object sender, EventArgs e)
        {
            CerrarPbx.BorderStyle = BorderStyle.None;

        }

        private void AbrirFormularios<FormulariosAbrir>() where FormulariosAbrir:Form,new ()
        {
            Form formularios;
            formularios = FormsPnl.Controls.OfType<FormulariosAbrir>().FirstOrDefault();

            if (formularios==null)
            {
                formularios = new FormulariosAbrir()
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };

                FormsPnl.Controls.Add(formularios);

                FormsPnl.Tag = formularios;

                formularios.Show();

                formularios.BringToFront();
            }
            else
            {
                formularios.BringToFront();
            }
        }

        private void PlantasBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmPlantas>();
            TablasNameLbl.Text = "Plantas";
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            TablasNameLbl.Text = "";
        }

        private void TipoDePlantasBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmTipoDePlantas>();
            TablasNameLbl.Text = "Tipos De Plantas";
        }

        private void TipoDeEnvasesBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmTipoDeEnvases>();
            TablasNameLbl.Text = "Tipos De Envases";
        }
    }
}
