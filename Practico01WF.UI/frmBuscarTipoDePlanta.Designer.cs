
namespace Practico01WF.UI
{
    partial class frmBuscarTipoDePlanta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DatosDgv = new System.Windows.Forms.DataGridView();
            this.cmnPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTipoPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTipoEnvase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListaTvw = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListaTvw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 475);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DatosDgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(243, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 475);
            this.panel2.TabIndex = 0;
            // 
            // DatosDgv
            // 
            this.DatosDgv.AllowUserToAddRows = false;
            this.DatosDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DatosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnPlanta,
            this.cmnTipoPlanta,
            this.cmnTipoEnvase});
            this.DatosDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDgv.Location = new System.Drawing.Point(0, 0);
            this.DatosDgv.MultiSelect = false;
            this.DatosDgv.Name = "DatosDgv";
            this.DatosDgv.ReadOnly = true;
            this.DatosDgv.RowHeadersVisible = false;
            this.DatosDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDgv.Size = new System.Drawing.Size(333, 475);
            this.DatosDgv.TabIndex = 0;
            this.DatosDgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosDgv_RowEnter);
            // 
            // cmnPlanta
            // 
            this.cmnPlanta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnPlanta.HeaderText = "Planta";
            this.cmnPlanta.Name = "cmnPlanta";
            this.cmnPlanta.ReadOnly = true;
            // 
            // cmnTipoPlanta
            // 
            this.cmnTipoPlanta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoPlanta.HeaderText = "Tipo de Planta";
            this.cmnTipoPlanta.Name = "cmnTipoPlanta";
            this.cmnTipoPlanta.ReadOnly = true;
            // 
            // cmnTipoEnvase
            // 
            this.cmnTipoEnvase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoEnvase.HeaderText = "Tipo de Envase";
            this.cmnTipoEnvase.Name = "cmnTipoEnvase";
            this.cmnTipoEnvase.ReadOnly = true;
            // 
            // ListaTvw
            // 
            this.ListaTvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaTvw.Location = new System.Drawing.Point(0, 0);
            this.ListaTvw.Name = "ListaTvw";
            this.ListaTvw.Size = new System.Drawing.Size(243, 475);
            this.ListaTvw.TabIndex = 0;
            this.ListaTvw.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ListaTvw_AfterSelect);
            // 
            // frmBuscarTipoDePlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(576, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBuscarTipoDePlanta";
            this.Text = "frmBuscarTipoDePlanta";
            this.Load += new System.EventHandler(this.frmBuscarTipoDePlanta_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DatosDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoEnvase;
        private System.Windows.Forms.TreeView ListaTvw;
    }
}