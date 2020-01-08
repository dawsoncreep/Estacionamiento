namespace Estacionamiento
{
    partial class f_reportes
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
            this.gbReportes = new System.Windows.Forms.GroupBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.b_generarReporte = new System.Windows.Forms.Button();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.b_imprimir = new System.Windows.Forms.Button();
            this.gbReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReportes
            // 
            this.gbReportes.Controls.Add(this.b_imprimir);
            this.gbReportes.Controls.Add(this.b_generarReporte);
            this.gbReportes.Controls.Add(this.dtpFinal);
            this.gbReportes.Controls.Add(this.label2);
            this.gbReportes.Controls.Add(this.label1);
            this.gbReportes.Controls.Add(this.dtpInicio);
            this.gbReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbReportes.Location = new System.Drawing.Point(0, 0);
            this.gbReportes.Name = "gbReportes";
            this.gbReportes.Size = new System.Drawing.Size(599, 100);
            this.gbReportes.TabIndex = 0;
            this.gbReportes.TabStop = false;
            this.gbReportes.Text = "Reportes";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(151, 18);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 0;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generar Reporte desde:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "al:";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(388, 17);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFinal.TabIndex = 3;
            // 
            // b_generarReporte
            // 
            this.b_generarReporte.Location = new System.Drawing.Point(27, 44);
            this.b_generarReporte.Name = "b_generarReporte";
            this.b_generarReporte.Size = new System.Drawing.Size(233, 29);
            this.b_generarReporte.TabIndex = 4;
            this.b_generarReporte.Text = "GENERAR REPORTE";
            this.b_generarReporte.UseVisualStyleBackColor = true;
            this.b_generarReporte.Click += new System.EventHandler(this.b_generarReporte_Click);
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportes.Location = new System.Drawing.Point(0, 100);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.Size = new System.Drawing.Size(599, 74);
            this.dgvReportes.TabIndex = 1;
            // 
            // b_imprimir
            // 
            this.b_imprimir.Location = new System.Drawing.Point(310, 44);
            this.b_imprimir.Name = "b_imprimir";
            this.b_imprimir.Size = new System.Drawing.Size(267, 29);
            this.b_imprimir.TabIndex = 5;
            this.b_imprimir.Text = "IMPRIMIR";
            this.b_imprimir.UseVisualStyleBackColor = true;
            this.b_imprimir.Click += new System.EventHandler(this.b_imprimir_Click);
            // 
            // f_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 174);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.gbReportes);
            this.Name = "f_reportes";
            this.Text = "Reportes - Estacionamiento";
            this.gbReportes.ResumeLayout(false);
            this.gbReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReportes;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button b_generarReporte;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Button b_imprimir;
    }
}