
namespace Practico01WF.UI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TablasPnl = new System.Windows.Forms.Panel();
            this.TituloPnl = new System.Windows.Forms.Panel();
            this.FormsPnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PlantasBtn = new System.Windows.Forms.Button();
            this.TipoDePlantasBtn = new System.Windows.Forms.Button();
            this.TipoDeEnvasesBtn = new System.Windows.Forms.Button();
            this.TablasNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CerrarPbx = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.TablasPnl.SuspendLayout();
            this.TituloPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.FormsPnl);
            this.panel1.Controls.Add(this.TituloPnl);
            this.panel1.Controls.Add(this.TablasPnl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 385);
            this.panel1.TabIndex = 0;
            // 
            // TablasPnl
            // 
            this.TablasPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TablasPnl.Controls.Add(this.TipoDeEnvasesBtn);
            this.TablasPnl.Controls.Add(this.TipoDePlantasBtn);
            this.TablasPnl.Controls.Add(this.PlantasBtn);
            this.TablasPnl.Controls.Add(this.label1);
            this.TablasPnl.Controls.Add(this.pictureBox2);
            this.TablasPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.TablasPnl.Location = new System.Drawing.Point(0, 0);
            this.TablasPnl.Name = "TablasPnl";
            this.TablasPnl.Size = new System.Drawing.Size(123, 385);
            this.TablasPnl.TabIndex = 0;
            // 
            // TituloPnl
            // 
            this.TituloPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TituloPnl.Controls.Add(this.TablasNameLbl);
            this.TituloPnl.Controls.Add(this.pictureBox1);
            this.TituloPnl.Controls.Add(this.CerrarPbx);
            this.TituloPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloPnl.Location = new System.Drawing.Point(123, 0);
            this.TituloPnl.Name = "TituloPnl";
            this.TituloPnl.Size = new System.Drawing.Size(512, 43);
            this.TituloPnl.TabIndex = 1;
            // 
            // FormsPnl
            // 
            this.FormsPnl.BackColor = System.Drawing.Color.DimGray;
            this.FormsPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormsPnl.Location = new System.Drawing.Point(123, 43);
            this.FormsPnl.Name = "FormsPnl";
            this.FormsPnl.Size = new System.Drawing.Size(512, 342);
            this.FormsPnl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario :";
            // 
            // PlantasBtn
            // 
            this.PlantasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlantasBtn.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlantasBtn.Location = new System.Drawing.Point(9, 133);
            this.PlantasBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PlantasBtn.Name = "PlantasBtn";
            this.PlantasBtn.Size = new System.Drawing.Size(97, 31);
            this.PlantasBtn.TabIndex = 2;
            this.PlantasBtn.Text = "Plantas";
            this.PlantasBtn.UseVisualStyleBackColor = true;
            this.PlantasBtn.Click += new System.EventHandler(this.PlantasBtn_Click);
            // 
            // TipoDePlantasBtn
            // 
            this.TipoDePlantasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipoDePlantasBtn.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoDePlantasBtn.Location = new System.Drawing.Point(9, 175);
            this.TipoDePlantasBtn.Margin = new System.Windows.Forms.Padding(0);
            this.TipoDePlantasBtn.Name = "TipoDePlantasBtn";
            this.TipoDePlantasBtn.Size = new System.Drawing.Size(97, 56);
            this.TipoDePlantasBtn.TabIndex = 2;
            this.TipoDePlantasBtn.Text = "Tipo De Plantas";
            this.TipoDePlantasBtn.UseVisualStyleBackColor = true;
            this.TipoDePlantasBtn.Click += new System.EventHandler(this.TipoDePlantasBtn_Click);
            // 
            // TipoDeEnvasesBtn
            // 
            this.TipoDeEnvasesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipoDeEnvasesBtn.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoDeEnvasesBtn.Location = new System.Drawing.Point(9, 241);
            this.TipoDeEnvasesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.TipoDeEnvasesBtn.Name = "TipoDeEnvasesBtn";
            this.TipoDeEnvasesBtn.Size = new System.Drawing.Size(97, 56);
            this.TipoDeEnvasesBtn.TabIndex = 2;
            this.TipoDeEnvasesBtn.Text = "Tipo De Envases";
            this.TipoDeEnvasesBtn.UseVisualStyleBackColor = true;
            this.TipoDeEnvasesBtn.Click += new System.EventHandler(this.TipoDeEnvasesBtn_Click);
            // 
            // TablasNameLbl
            // 
            this.TablasNameLbl.AutoSize = true;
            this.TablasNameLbl.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablasNameLbl.Location = new System.Drawing.Point(46, 6);
            this.TablasNameLbl.Name = "TablasNameLbl";
            this.TablasNameLbl.Size = new System.Drawing.Size(0, 31);
            this.TablasNameLbl.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practico01WF.UI.Properties.Resources.sprout_40px;
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CerrarPbx
            // 
            this.CerrarPbx.BackColor = System.Drawing.Color.Transparent;
            this.CerrarPbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarPbx.Dock = System.Windows.Forms.DockStyle.Right;
            this.CerrarPbx.Image = global::Practico01WF.UI.Properties.Resources.cancel_20px;
            this.CerrarPbx.Location = new System.Drawing.Point(468, 0);
            this.CerrarPbx.Name = "CerrarPbx";
            this.CerrarPbx.Size = new System.Drawing.Size(44, 43);
            this.CerrarPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CerrarPbx.TabIndex = 0;
            this.CerrarPbx.TabStop = false;
            this.CerrarPbx.Click += new System.EventHandler(this.CerrarPbx_Click);
            this.CerrarPbx.MouseLeave += new System.EventHandler(this.CerrarPbx_MouseLeave);
            this.CerrarPbx.MouseHover += new System.EventHandler(this.CerrarPbx_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Practico01WF.UI.Properties.Resources.man_with_beard_in_suit_100px;
            this.pictureBox2.Location = new System.Drawing.Point(12, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 385);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(635, 385);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.TablasPnl.ResumeLayout(false);
            this.TablasPnl.PerformLayout();
            this.TituloPnl.ResumeLayout(false);
            this.TituloPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel FormsPnl;
        private System.Windows.Forms.Panel TituloPnl;
        private System.Windows.Forms.Panel TablasPnl;
        private System.Windows.Forms.PictureBox CerrarPbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TipoDeEnvasesBtn;
        private System.Windows.Forms.Button TipoDePlantasBtn;
        private System.Windows.Forms.Button PlantasBtn;
        private System.Windows.Forms.Label TablasNameLbl;
    }
}

