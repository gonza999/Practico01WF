
namespace Practico01WF.UI
{
    partial class frmPlantas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DetallesGrillaPnl = new System.Windows.Forms.Panel();
            this.CantidadLbl = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.ToolStripPnl = new System.Windows.Forms.Panel();
            this.HerramientasTsb = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GrillaPnl = new System.Windows.Forms.Panel();
            this.DatosDgv = new System.Windows.Forms.DataGridView();
            this.CmnPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnTipoPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTipoEnvase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.PaginaActualLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CantidadPaginasLbl = new System.Windows.Forms.Label();
            this.NuevoBtn = new System.Windows.Forms.ToolStripButton();
            this.BorrarBtn = new System.Windows.Forms.ToolStripButton();
            this.EditarBtn = new System.Windows.Forms.ToolStripButton();
            this.BuscarBtn = new System.Windows.Forms.ToolStripButton();
            this.ActualizarBtn = new System.Windows.Forms.ToolStripButton();
            this.ImprimirBtn = new System.Windows.Forms.ToolStripButton();
            this.UltimoBtn = new System.Windows.Forms.Button();
            this.SiguienteBtn = new System.Windows.Forms.Button();
            this.AnteriorBtn = new System.Windows.Forms.Button();
            this.PrimeroBtn = new System.Windows.Forms.Button();
            this.DetallesGrillaPnl.SuspendLayout();
            this.ToolStripPnl.SuspendLayout();
            this.HerramientasTsb.SuspendLayout();
            this.GrillaPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // DetallesGrillaPnl
            // 
            this.DetallesGrillaPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DetallesGrillaPnl.Controls.Add(this.UltimoBtn);
            this.DetallesGrillaPnl.Controls.Add(this.SiguienteBtn);
            this.DetallesGrillaPnl.Controls.Add(this.AnteriorBtn);
            this.DetallesGrillaPnl.Controls.Add(this.PrimeroBtn);
            this.DetallesGrillaPnl.Controls.Add(this.CantidadPaginasLbl);
            this.DetallesGrillaPnl.Controls.Add(this.PaginaActualLbl);
            this.DetallesGrillaPnl.Controls.Add(this.CantidadLbl);
            this.DetallesGrillaPnl.Controls.Add(this.label2);
            this.DetallesGrillaPnl.Controls.Add(this.label1);
            this.DetallesGrillaPnl.Controls.Add(this.label);
            this.DetallesGrillaPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DetallesGrillaPnl.Location = new System.Drawing.Point(0, 372);
            this.DetallesGrillaPnl.Name = "DetallesGrillaPnl";
            this.DetallesGrillaPnl.Size = new System.Drawing.Size(800, 78);
            this.DetallesGrillaPnl.TabIndex = 3;
            // 
            // CantidadLbl
            // 
            this.CantidadLbl.AutoSize = true;
            this.CantidadLbl.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLbl.Location = new System.Drawing.Point(89, 17);
            this.CantidadLbl.Name = "CantidadLbl";
            this.CantidadLbl.Size = new System.Drawing.Size(14, 14);
            this.CantidadLbl.TabIndex = 2;
            this.CantidadLbl.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(71, 14);
            this.label.TabIndex = 2;
            this.label.Text = "Cantidad :";
            // 
            // ToolStripPnl
            // 
            this.ToolStripPnl.BackColor = System.Drawing.Color.Gray;
            this.ToolStripPnl.Controls.Add(this.HerramientasTsb);
            this.ToolStripPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolStripPnl.Location = new System.Drawing.Point(0, 0);
            this.ToolStripPnl.Name = "ToolStripPnl";
            this.ToolStripPnl.Size = new System.Drawing.Size(800, 64);
            this.ToolStripPnl.TabIndex = 4;
            // 
            // HerramientasTsb
            // 
            this.HerramientasTsb.BackColor = System.Drawing.Color.Gray;
            this.HerramientasTsb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HerramientasTsb.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.HerramientasTsb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoBtn,
            this.BorrarBtn,
            this.EditarBtn,
            this.toolStripSeparator1,
            this.BuscarBtn,
            this.ActualizarBtn,
            this.toolStripSeparator2,
            this.ImprimirBtn,
            this.toolStripSeparator3});
            this.HerramientasTsb.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.HerramientasTsb.Location = new System.Drawing.Point(0, 0);
            this.HerramientasTsb.Name = "HerramientasTsb";
            this.HerramientasTsb.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.HerramientasTsb.Size = new System.Drawing.Size(800, 64);
            this.HerramientasTsb.TabIndex = 0;
            this.HerramientasTsb.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // GrillaPnl
            // 
            this.GrillaPnl.BackColor = System.Drawing.Color.Gray;
            this.GrillaPnl.Controls.Add(this.DatosDgv);
            this.GrillaPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaPnl.Location = new System.Drawing.Point(0, 64);
            this.GrillaPnl.Name = "GrillaPnl";
            this.GrillaPnl.Size = new System.Drawing.Size(800, 308);
            this.GrillaPnl.TabIndex = 5;
            // 
            // DatosDgv
            // 
            this.DatosDgv.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DatosDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatosDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DatosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CmnPlanta,
            this.CmnTipoPlanta,
            this.cmnTipoEnvase});
            this.DatosDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDgv.Location = new System.Drawing.Point(0, 0);
            this.DatosDgv.MultiSelect = false;
            this.DatosDgv.Name = "DatosDgv";
            this.DatosDgv.ReadOnly = true;
            this.DatosDgv.RowHeadersVisible = false;
            this.DatosDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDgv.Size = new System.Drawing.Size(800, 308);
            this.DatosDgv.TabIndex = 0;
            // 
            // CmnPlanta
            // 
            this.CmnPlanta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnPlanta.HeaderText = "Planta";
            this.CmnPlanta.Name = "CmnPlanta";
            this.CmnPlanta.ReadOnly = true;
            // 
            // CmnTipoPlanta
            // 
            this.CmnTipoPlanta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnTipoPlanta.HeaderText = "Tipo de Planta";
            this.CmnTipoPlanta.Name = "CmnTipoPlanta";
            this.CmnTipoPlanta.ReadOnly = true;
            // 
            // cmnTipoEnvase
            // 
            this.cmnTipoEnvase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoEnvase.HeaderText = "Tipo de Envase";
            this.cmnTipoEnvase.Name = "cmnTipoEnvase";
            this.cmnTipoEnvase.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pagina :";
            // 
            // PaginaActualLbl
            // 
            this.PaginaActualLbl.AutoSize = true;
            this.PaginaActualLbl.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaginaActualLbl.Location = new System.Drawing.Point(89, 44);
            this.PaginaActualLbl.Name = "PaginaActualLbl";
            this.PaginaActualLbl.Size = new System.Drawing.Size(14, 14);
            this.PaginaActualLbl.TabIndex = 2;
            this.PaginaActualLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "de";
            // 
            // CantidadPaginasLbl
            // 
            this.CantidadPaginasLbl.AutoSize = true;
            this.CantidadPaginasLbl.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadPaginasLbl.Location = new System.Drawing.Point(137, 44);
            this.CantidadPaginasLbl.Name = "CantidadPaginasLbl";
            this.CantidadPaginasLbl.Size = new System.Drawing.Size(14, 14);
            this.CantidadPaginasLbl.TabIndex = 2;
            this.CantidadPaginasLbl.Text = "0";
            // 
            // NuevoBtn
            // 
            this.NuevoBtn.BackColor = System.Drawing.Color.Transparent;
            this.NuevoBtn.Image = global::Practico01WF.UI.Properties.Resources.add_40px;
            this.NuevoBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoBtn.Name = "NuevoBtn";
            this.NuevoBtn.Size = new System.Drawing.Size(46, 59);
            this.NuevoBtn.Text = "Nuevo";
            this.NuevoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.BackColor = System.Drawing.Color.Transparent;
            this.BorrarBtn.Image = global::Practico01WF.UI.Properties.Resources.trash_40px;
            this.BorrarBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(44, 59);
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // EditarBtn
            // 
            this.EditarBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditarBtn.Image = global::Practico01WF.UI.Properties.Resources.edit_40px;
            this.EditarBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(44, 59);
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.BackColor = System.Drawing.Color.Transparent;
            this.BuscarBtn.Image = global::Practico01WF.UI.Properties.Resources.search_40px;
            this.BuscarBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BuscarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(46, 59);
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ActualizarBtn
            // 
            this.ActualizarBtn.BackColor = System.Drawing.Color.Transparent;
            this.ActualizarBtn.Image = global::Practico01WF.UI.Properties.Resources.update_left_rotation_40px;
            this.ActualizarBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarBtn.Name = "ActualizarBtn";
            this.ActualizarBtn.Size = new System.Drawing.Size(63, 59);
            this.ActualizarBtn.Text = "Actualizar";
            this.ActualizarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ImprimirBtn
            // 
            this.ImprimirBtn.BackColor = System.Drawing.Color.Transparent;
            this.ImprimirBtn.Image = global::Practico01WF.UI.Properties.Resources.printer_40px;
            this.ImprimirBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ImprimirBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImprimirBtn.Name = "ImprimirBtn";
            this.ImprimirBtn.Size = new System.Drawing.Size(57, 59);
            this.ImprimirBtn.Text = "Imprimir";
            this.ImprimirBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // UltimoBtn
            // 
            this.UltimoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UltimoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UltimoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UltimoBtn.Image = global::Practico01WF.UI.Properties.Resources.end_button_30px;
            this.UltimoBtn.Location = new System.Drawing.Point(267, 39);
            this.UltimoBtn.Name = "UltimoBtn";
            this.UltimoBtn.Size = new System.Drawing.Size(27, 23);
            this.UltimoBtn.TabIndex = 3;
            this.UltimoBtn.UseVisualStyleBackColor = false;
            this.UltimoBtn.Click += new System.EventHandler(this.UltimoBtn_Click);
            // 
            // SiguienteBtn
            // 
            this.SiguienteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SiguienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SiguienteBtn.Image = global::Practico01WF.UI.Properties.Resources.next_30px;
            this.SiguienteBtn.Location = new System.Drawing.Point(234, 39);
            this.SiguienteBtn.Name = "SiguienteBtn";
            this.SiguienteBtn.Size = new System.Drawing.Size(27, 23);
            this.SiguienteBtn.TabIndex = 3;
            this.SiguienteBtn.UseVisualStyleBackColor = false;
            this.SiguienteBtn.Click += new System.EventHandler(this.SiguienteBtn_Click);
            // 
            // AnteriorBtn
            // 
            this.AnteriorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AnteriorBtn.BackgroundImage = global::Practico01WF.UI.Properties.Resources.previous_30px;
            this.AnteriorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnteriorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnteriorBtn.Location = new System.Drawing.Point(201, 39);
            this.AnteriorBtn.Name = "AnteriorBtn";
            this.AnteriorBtn.Size = new System.Drawing.Size(27, 23);
            this.AnteriorBtn.TabIndex = 3;
            this.AnteriorBtn.UseVisualStyleBackColor = false;
            this.AnteriorBtn.Click += new System.EventHandler(this.AnteriorBtn_Click);
            // 
            // PrimeroBtn
            // 
            this.PrimeroBtn.BackColor = System.Drawing.Color.Black;
            this.PrimeroBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrimeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrimeroBtn.Image = global::Practico01WF.UI.Properties.Resources.first_30px;
            this.PrimeroBtn.Location = new System.Drawing.Point(168, 39);
            this.PrimeroBtn.Name = "PrimeroBtn";
            this.PrimeroBtn.Size = new System.Drawing.Size(27, 23);
            this.PrimeroBtn.TabIndex = 3;
            this.PrimeroBtn.UseVisualStyleBackColor = false;
            this.PrimeroBtn.Click += new System.EventHandler(this.PrimeroBtn_Click);
            // 
            // frmPlantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.GrillaPnl);
            this.Controls.Add(this.ToolStripPnl);
            this.Controls.Add(this.DetallesGrillaPnl);
            this.Name = "frmPlantas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlantas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPlantas_Load);
            this.DetallesGrillaPnl.ResumeLayout(false);
            this.DetallesGrillaPnl.PerformLayout();
            this.ToolStripPnl.ResumeLayout(false);
            this.ToolStripPnl.PerformLayout();
            this.HerramientasTsb.ResumeLayout(false);
            this.HerramientasTsb.PerformLayout();
            this.GrillaPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DetallesGrillaPnl;
        private System.Windows.Forms.Label CantidadLbl;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel ToolStripPnl;
        private System.Windows.Forms.ToolStrip HerramientasTsb;
        private System.Windows.Forms.ToolStripButton NuevoBtn;
        private System.Windows.Forms.ToolStripButton BorrarBtn;
        private System.Windows.Forms.ToolStripButton EditarBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BuscarBtn;
        private System.Windows.Forms.ToolStripButton ActualizarBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ImprimirBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel GrillaPnl;
        private System.Windows.Forms.DataGridView DatosDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmnPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmnTipoPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoEnvase;
        private System.Windows.Forms.Label CantidadPaginasLbl;
        private System.Windows.Forms.Label PaginaActualLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UltimoBtn;
        private System.Windows.Forms.Button SiguienteBtn;
        private System.Windows.Forms.Button AnteriorBtn;
        private System.Windows.Forms.Button PrimeroBtn;
    }
}