namespace Estacionamiento
{
    partial class f_Inicio
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adiministracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.p_barcode = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hora_Actual = new System.Windows.Forms.Label();
            this.b_reimprimir = new System.Windows.Forms.Button();
            this.b_CrearRegistro = new System.Windows.Forms.Button();
            this.t_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_descuento = new System.Windows.Forms.TextBox();
            this.l_descuento = new System.Windows.Forms.Label();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.t_cambio = new System.Windows.Forms.TextBox();
            this.l_cambio = new System.Windows.Forms.Label();
            this.t_pago = new System.Windows.Forms.TextBox();
            this.l_cobro = new System.Windows.Forms.Label();
            this.tb_subTotal = new System.Windows.Forms.TextBox();
            this.cb_boletoPerdido = new System.Windows.Forms.CheckBox();
            this.l_subtotal = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.b_cobrar = new System.Windows.Forms.Button();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adiministracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adiministracionToolStripMenuItem
            // 
            this.adiministracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem,
            this.parametrosToolStripMenuItem});
            this.adiministracionToolStripMenuItem.Name = "adiministracionToolStripMenuItem";
            this.adiministracionToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.adiministracionToolStripMenuItem.Text = "Adiministracion";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            this.parametrosToolStripMenuItem.Click += new System.EventHandler(this.parametrosToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.p_barcode);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.b_reimprimir);
            this.splitContainer1.Panel1.Controls.Add(this.b_CrearRegistro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.t_total);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.t_descuento);
            this.splitContainer1.Panel2.Controls.Add(this.l_descuento);
            this.splitContainer1.Panel2.Controls.Add(this.b_aceptar);
            this.splitContainer1.Panel2.Controls.Add(this.t_cambio);
            this.splitContainer1.Panel2.Controls.Add(this.l_cambio);
            this.splitContainer1.Panel2.Controls.Add(this.t_pago);
            this.splitContainer1.Panel2.Controls.Add(this.l_cobro);
            this.splitContainer1.Panel2.Controls.Add(this.tb_subTotal);
            this.splitContainer1.Panel2.Controls.Add(this.cb_boletoPerdido);
            this.splitContainer1.Panel2.Controls.Add(this.l_subtotal);
            this.splitContainer1.Panel2.Controls.Add(this.tb_codigo);
            this.splitContainer1.Panel2.Controls.Add(this.b_cobrar);
            this.splitContainer1.Size = new System.Drawing.Size(784, 537);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 2;
            // 
            // p_barcode
            // 
            this.p_barcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_barcode.Location = new System.Drawing.Point(44, 277);
            this.p_barcode.Name = "p_barcode";
            this.p_barcode.Size = new System.Drawing.Size(314, 92);
            this.p_barcode.TabIndex = 3;
            this.p_barcode.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Hora_Actual);
            this.panel1.Location = new System.Drawing.Point(34, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 77);
            this.panel1.TabIndex = 2;
            // 
            // Hora_Actual
            // 
            this.Hora_Actual.AutoSize = true;
            this.Hora_Actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_Actual.Location = new System.Drawing.Point(12, 10);
            this.Hora_Actual.Name = "Hora_Actual";
            this.Hora_Actual.Size = new System.Drawing.Size(175, 55);
            this.Hora_Actual.TabIndex = 0;
            this.Hora_Actual.Text = "Hora...";
            // 
            // b_reimprimir
            // 
            this.b_reimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_reimprimir.Location = new System.Drawing.Point(37, 177);
            this.b_reimprimir.Name = "b_reimprimir";
            this.b_reimprimir.Size = new System.Drawing.Size(322, 59);
            this.b_reimprimir.TabIndex = 1;
            this.b_reimprimir.Text = "REIMPRIMIR";
            this.b_reimprimir.UseVisualStyleBackColor = true;
            this.b_reimprimir.Visible = false;
            // 
            // b_CrearRegistro
            // 
            this.b_CrearRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_CrearRegistro.Location = new System.Drawing.Point(37, 106);
            this.b_CrearRegistro.Name = "b_CrearRegistro";
            this.b_CrearRegistro.Size = new System.Drawing.Size(322, 59);
            this.b_CrearRegistro.TabIndex = 1;
            this.b_CrearRegistro.Text = "CREAR REGISTRO";
            this.b_CrearRegistro.UseVisualStyleBackColor = true;
            this.b_CrearRegistro.Click += new System.EventHandler(this.b_CrearRegistro_Click);
            // 
            // t_total
            // 
            this.t_total.Enabled = false;
            this.t_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_total.Location = new System.Drawing.Point(133, 274);
            this.t_total.Name = "t_total";
            this.t_total.Size = new System.Drawing.Size(220, 35);
            this.t_total.TabIndex = 30;
            this.t_total.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "TOTAL";
            // 
            // t_descuento
            // 
            this.t_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_descuento.Location = new System.Drawing.Point(132, 233);
            this.t_descuento.Name = "t_descuento";
            this.t_descuento.Size = new System.Drawing.Size(220, 35);
            this.t_descuento.TabIndex = 3;
            this.t_descuento.Visible = false;
            this.t_descuento.TextChanged += new System.EventHandler(this.t_descuento_TextChanged);
            this.t_descuento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.t_descuento_KeyUp);
            // 
            // l_descuento
            // 
            this.l_descuento.AutoSize = true;
            this.l_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_descuento.Location = new System.Drawing.Point(3, 240);
            this.l_descuento.Name = "l_descuento";
            this.l_descuento.Size = new System.Drawing.Size(128, 24);
            this.l_descuento.TabIndex = 15;
            this.l_descuento.Text = "DESCUENTO";
            this.l_descuento.Visible = false;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_aceptar.Location = new System.Drawing.Point(31, 406);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(322, 59);
            this.b_aceptar.TabIndex = 5;
            this.b_aceptar.Text = "ACEPTAR";
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // t_cambio
            // 
            this.t_cambio.Enabled = false;
            this.t_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_cambio.Location = new System.Drawing.Point(133, 356);
            this.t_cambio.Name = "t_cambio";
            this.t_cambio.Size = new System.Drawing.Size(220, 35);
            this.t_cambio.TabIndex = 13;
            this.t_cambio.Text = "0.00";
            // 
            // l_cambio
            // 
            this.l_cambio.AutoSize = true;
            this.l_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cambio.Location = new System.Drawing.Point(19, 359);
            this.l_cambio.Name = "l_cambio";
            this.l_cambio.Size = new System.Drawing.Size(106, 29);
            this.l_cambio.TabIndex = 12;
            this.l_cambio.Text = "CAMBIO";
            // 
            // t_pago
            // 
            this.t_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_pago.Location = new System.Drawing.Point(133, 315);
            this.t_pago.Name = "t_pago";
            this.t_pago.Size = new System.Drawing.Size(220, 35);
            this.t_pago.TabIndex = 4;
            this.t_pago.TextChanged += new System.EventHandler(this.t_pago_TextChanged);
            this.t_pago.KeyUp += new System.Windows.Forms.KeyEventHandler(this.t_pago_KeyUp);
            // 
            // l_cobro
            // 
            this.l_cobro.AutoSize = true;
            this.l_cobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cobro.Location = new System.Drawing.Point(25, 321);
            this.l_cobro.Name = "l_cobro";
            this.l_cobro.Size = new System.Drawing.Size(81, 29);
            this.l_cobro.TabIndex = 10;
            this.l_cobro.Text = "PAGO";
            // 
            // tb_subTotal
            // 
            this.tb_subTotal.Enabled = false;
            this.tb_subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subTotal.Location = new System.Drawing.Point(132, 191);
            this.tb_subTotal.Name = "tb_subTotal";
            this.tb_subTotal.Size = new System.Drawing.Size(220, 35);
            this.tb_subTotal.TabIndex = 9;
            this.tb_subTotal.Text = "0.00";
            this.tb_subTotal.Visible = false;
            // 
            // cb_boletoPerdido
            // 
            this.cb_boletoPerdido.AutoSize = true;
            this.cb_boletoPerdido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_boletoPerdido.Location = new System.Drawing.Point(158, 152);
            this.cb_boletoPerdido.Name = "cb_boletoPerdido";
            this.cb_boletoPerdido.Size = new System.Drawing.Size(194, 33);
            this.cb_boletoPerdido.TabIndex = 8;
            this.cb_boletoPerdido.Text = "Boleto Perdido";
            this.cb_boletoPerdido.UseVisualStyleBackColor = true;
            this.cb_boletoPerdido.CheckedChanged += new System.EventHandler(this.cb_boletoPerdido_CheckedChanged);
            // 
            // l_subtotal
            // 
            this.l_subtotal.AutoSize = true;
            this.l_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_subtotal.Location = new System.Drawing.Point(17, 202);
            this.l_subtotal.Name = "l_subtotal";
            this.l_subtotal.Size = new System.Drawing.Size(109, 24);
            this.l_subtotal.TabIndex = 4;
            this.l_subtotal.Text = "SUBTOTAL";
            this.l_subtotal.Visible = false;
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(29, 81);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(318, 29);
            this.tb_codigo.TabIndex = 2;
            this.tb_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_codigo_KeyDown);
            // 
            // b_cobrar
            // 
            this.b_cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cobrar.Location = new System.Drawing.Point(25, 16);
            this.b_cobrar.Name = "b_cobrar";
            this.b_cobrar.Size = new System.Drawing.Size(322, 59);
            this.b_cobrar.TabIndex = 9;
            this.b_cobrar.Text = "COBRAR";
            this.b_cobrar.UseVisualStyleBackColor = true;
            this.b_cobrar.Click += new System.EventHandler(this.b_cobrar_Click);
            // 
            // reloj
            // 
            this.reloj.Enabled = true;
            this.reloj.Interval = 1000;
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // f_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f_Inicio";
            this.Text = "Estacionamiento - Inicio";
            this.Load += new System.EventHandler(this.f_Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adiministracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button b_reimprimir;
        private System.Windows.Forms.Button b_CrearRegistro;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Button b_cobrar;
        private System.Windows.Forms.Label l_subtotal;
        private System.Windows.Forms.TextBox t_cambio;
        private System.Windows.Forms.Label l_cambio;
        private System.Windows.Forms.TextBox t_pago;
        private System.Windows.Forms.Label l_cobro;
        private System.Windows.Forms.TextBox tb_subTotal;
        private System.Windows.Forms.CheckBox cb_boletoPerdido;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Hora_Actual;
        private System.Windows.Forms.Timer reloj;
        private System.Windows.Forms.Panel p_barcode;
        private System.Windows.Forms.TextBox t_descuento;
        private System.Windows.Forms.Label l_descuento;
        private System.Windows.Forms.TextBox t_total;
        private System.Windows.Forms.Label label1;
    }
}

