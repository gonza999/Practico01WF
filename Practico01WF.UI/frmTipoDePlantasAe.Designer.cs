
namespace Practico01WF.UI
{
    partial class frmTipoDePlantasAe
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
            this.label1 = new System.Windows.Forms.Label();
            this.OkPbx = new System.Windows.Forms.PictureBox();
            this.CancelPbx = new System.Windows.Forms.PictureBox();
            this.TipoDePlantaTxt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OkPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Planta :";
            // 
            // OkPbx
            // 
            this.OkPbx.BackColor = System.Drawing.Color.Transparent;
            this.OkPbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkPbx.Image = global::Practico01WF.UI.Properties.Resources.ok_40px;
            this.OkPbx.Location = new System.Drawing.Point(63, 69);
            this.OkPbx.Name = "OkPbx";
            this.OkPbx.Size = new System.Drawing.Size(44, 43);
            this.OkPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OkPbx.TabIndex = 3;
            this.OkPbx.TabStop = false;
            this.OkPbx.Click += new System.EventHandler(this.OkPbx_Click);
            // 
            // CancelPbx
            // 
            this.CancelPbx.BackColor = System.Drawing.Color.Transparent;
            this.CancelPbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelPbx.Image = global::Practico01WF.UI.Properties.Resources.cancel_40px;
            this.CancelPbx.Location = new System.Drawing.Point(221, 69);
            this.CancelPbx.Name = "CancelPbx";
            this.CancelPbx.Size = new System.Drawing.Size(44, 43);
            this.CancelPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CancelPbx.TabIndex = 3;
            this.CancelPbx.TabStop = false;
            this.CancelPbx.Click += new System.EventHandler(this.CancelPbx_Click);
            // 
            // TipoDePlantaTxt
            // 
            this.TipoDePlantaTxt.Location = new System.Drawing.Point(139, 18);
            this.TipoDePlantaTxt.MaxLength = 50;
            this.TipoDePlantaTxt.Name = "TipoDePlantaTxt";
            this.TipoDePlantaTxt.Size = new System.Drawing.Size(159, 20);
            this.TipoDePlantaTxt.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTipoDePlantasAe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(315, 130);
            this.ControlBox = false;
            this.Controls.Add(this.TipoDePlantaTxt);
            this.Controls.Add(this.OkPbx);
            this.Controls.Add(this.CancelPbx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(315, 130);
            this.MinimumSize = new System.Drawing.Size(315, 130);
            this.Name = "frmTipoDePlantasAe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoDePlantasAe";
            ((System.ComponentModel.ISupportInitialize)(this.OkPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CancelPbx;
        private System.Windows.Forms.PictureBox OkPbx;
        private System.Windows.Forms.TextBox TipoDePlantaTxt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}