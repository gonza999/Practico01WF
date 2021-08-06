
namespace Practico01WF.UI
{
    partial class frmBuscarPlanta
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
            this.components = new System.ComponentModel.Container();
            this.TipoEnvaseCmb = new System.Windows.Forms.ComboBox();
            this.TipoPlantaCmb = new System.Windows.Forms.ComboBox();
            this.OkPbx = new System.Windows.Forms.PictureBox();
            this.CancelPbx = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoDePlantaRbn = new System.Windows.Forms.RadioButton();
            this.TipoDeEnvaseRbn = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OkPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoEnvaseCmb
            // 
            this.TipoEnvaseCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoEnvaseCmb.Enabled = false;
            this.TipoEnvaseCmb.FormattingEnabled = true;
            this.TipoEnvaseCmb.Location = new System.Drawing.Point(156, 67);
            this.TipoEnvaseCmb.Name = "TipoEnvaseCmb";
            this.TipoEnvaseCmb.Size = new System.Drawing.Size(121, 21);
            this.TipoEnvaseCmb.TabIndex = 18;
            this.TipoEnvaseCmb.SelectedIndexChanged += new System.EventHandler(this.TipoEnvaseCmb_SelectedIndexChanged);
            // 
            // TipoPlantaCmb
            // 
            this.TipoPlantaCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPlantaCmb.Enabled = false;
            this.TipoPlantaCmb.FormattingEnabled = true;
            this.TipoPlantaCmb.Location = new System.Drawing.Point(156, 31);
            this.TipoPlantaCmb.Name = "TipoPlantaCmb";
            this.TipoPlantaCmb.Size = new System.Drawing.Size(121, 21);
            this.TipoPlantaCmb.TabIndex = 19;
            this.TipoPlantaCmb.SelectedIndexChanged += new System.EventHandler(this.TipoPlantaCmb_SelectedIndexChanged);
            // 
            // OkPbx
            // 
            this.OkPbx.BackColor = System.Drawing.Color.Transparent;
            this.OkPbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkPbx.Image = global::Practico01WF.UI.Properties.Resources.ok_40px;
            this.OkPbx.Location = new System.Drawing.Point(33, 117);
            this.OkPbx.Name = "OkPbx";
            this.OkPbx.Size = new System.Drawing.Size(44, 43);
            this.OkPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OkPbx.TabIndex = 16;
            this.OkPbx.TabStop = false;
            this.OkPbx.Click += new System.EventHandler(this.OkPbx_Click);
            // 
            // CancelPbx
            // 
            this.CancelPbx.BackColor = System.Drawing.Color.Transparent;
            this.CancelPbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelPbx.Image = global::Practico01WF.UI.Properties.Resources.cancel_40px;
            this.CancelPbx.Location = new System.Drawing.Point(191, 117);
            this.CancelPbx.Name = "CancelPbx";
            this.CancelPbx.Size = new System.Drawing.Size(44, 43);
            this.CancelPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CancelPbx.TabIndex = 17;
            this.CancelPbx.TabStop = false;
            this.CancelPbx.Click += new System.EventHandler(this.CancelPbx_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo de Envase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tipo de Planta:";
            // 
            // TipoDePlantaRbn
            // 
            this.TipoDePlantaRbn.AutoSize = true;
            this.TipoDePlantaRbn.Location = new System.Drawing.Point(7, 34);
            this.TipoDePlantaRbn.Name = "TipoDePlantaRbn";
            this.TipoDePlantaRbn.Size = new System.Drawing.Size(14, 13);
            this.TipoDePlantaRbn.TabIndex = 20;
            this.TipoDePlantaRbn.TabStop = true;
            this.TipoDePlantaRbn.UseVisualStyleBackColor = true;
            this.TipoDePlantaRbn.CheckedChanged += new System.EventHandler(this.TipoDePlantaRbn_CheckedChanged);
            // 
            // TipoDeEnvaseRbn
            // 
            this.TipoDeEnvaseRbn.AutoSize = true;
            this.TipoDeEnvaseRbn.Location = new System.Drawing.Point(7, 71);
            this.TipoDeEnvaseRbn.Name = "TipoDeEnvaseRbn";
            this.TipoDeEnvaseRbn.Size = new System.Drawing.Size(14, 13);
            this.TipoDeEnvaseRbn.TabIndex = 20;
            this.TipoDeEnvaseRbn.TabStop = true;
            this.TipoDeEnvaseRbn.UseVisualStyleBackColor = true;
            this.TipoDeEnvaseRbn.CheckedChanged += new System.EventHandler(this.TipoDeEnvaseRbn_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmBuscarPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(305, 190);
            this.ControlBox = false;
            this.Controls.Add(this.TipoDeEnvaseRbn);
            this.Controls.Add(this.TipoDePlantaRbn);
            this.Controls.Add(this.TipoEnvaseCmb);
            this.Controls.Add(this.TipoPlantaCmb);
            this.Controls.Add(this.OkPbx);
            this.Controls.Add(this.CancelPbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmBuscarPlanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarPlanta";
            this.Load += new System.EventHandler(this.frmBuscarPlanta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OkPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TipoEnvaseCmb;
        private System.Windows.Forms.ComboBox TipoPlantaCmb;
        private System.Windows.Forms.PictureBox OkPbx;
        private System.Windows.Forms.PictureBox CancelPbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton TipoDePlantaRbn;
        private System.Windows.Forms.RadioButton TipoDeEnvaseRbn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}