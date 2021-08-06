
namespace Practico01WF.UI
{
    partial class frmPlantasAe
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
            this.PlantaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoPlantaCmb = new System.Windows.Forms.ComboBox();
            this.TipoEnvaseCmb = new System.Windows.Forms.ComboBox();
            this.OkPbx = new System.Windows.Forms.PictureBox();
            this.CancelPbx = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OkPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlantaTxt
            // 
            this.PlantaTxt.Location = new System.Drawing.Point(95, 15);
            this.PlantaTxt.MaxLength = 50;
            this.PlantaTxt.Name = "PlantaTxt";
            this.PlantaTxt.Size = new System.Drawing.Size(159, 20);
            this.PlantaTxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Planta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo de Planta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de Envase:";
            // 
            // TipoPlantaCmb
            // 
            this.TipoPlantaCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPlantaCmb.FormattingEnabled = true;
            this.TipoPlantaCmb.Location = new System.Drawing.Point(158, 65);
            this.TipoPlantaCmb.Name = "TipoPlantaCmb";
            this.TipoPlantaCmb.Size = new System.Drawing.Size(121, 21);
            this.TipoPlantaCmb.TabIndex = 13;
            // 
            // TipoEnvaseCmb
            // 
            this.TipoEnvaseCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoEnvaseCmb.FormattingEnabled = true;
            this.TipoEnvaseCmb.Location = new System.Drawing.Point(158, 101);
            this.TipoEnvaseCmb.Name = "TipoEnvaseCmb";
            this.TipoEnvaseCmb.Size = new System.Drawing.Size(121, 21);
            this.TipoEnvaseCmb.TabIndex = 13;
            // 
            // OkPbx
            // 
            this.OkPbx.BackColor = System.Drawing.Color.Transparent;
            this.OkPbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkPbx.Image = global::Practico01WF.UI.Properties.Resources.ok_40px;
            this.OkPbx.Location = new System.Drawing.Point(35, 151);
            this.OkPbx.Name = "OkPbx";
            this.OkPbx.Size = new System.Drawing.Size(44, 43);
            this.OkPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OkPbx.TabIndex = 10;
            this.OkPbx.TabStop = false;
            this.OkPbx.Click += new System.EventHandler(this.OkPbx_Click);
            // 
            // CancelPbx
            // 
            this.CancelPbx.BackColor = System.Drawing.Color.Transparent;
            this.CancelPbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelPbx.Image = global::Practico01WF.UI.Properties.Resources.cancel_40px;
            this.CancelPbx.Location = new System.Drawing.Point(193, 151);
            this.CancelPbx.Name = "CancelPbx";
            this.CancelPbx.Size = new System.Drawing.Size(44, 43);
            this.CancelPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CancelPbx.TabIndex = 11;
            this.CancelPbx.TabStop = false;
            this.CancelPbx.Click += new System.EventHandler(this.CancelPbx_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPlantasAe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(309, 224);
            this.Controls.Add(this.TipoEnvaseCmb);
            this.Controls.Add(this.TipoPlantaCmb);
            this.Controls.Add(this.PlantaTxt);
            this.Controls.Add(this.OkPbx);
            this.Controls.Add(this.CancelPbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlantasAe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlantasAe";
            ((System.ComponentModel.ISupportInitialize)(this.OkPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlantaTxt;
        private System.Windows.Forms.PictureBox OkPbx;
        private System.Windows.Forms.PictureBox CancelPbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TipoPlantaCmb;
        private System.Windows.Forms.ComboBox TipoEnvaseCmb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}