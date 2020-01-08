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
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adiministracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.b_CrearRegistro = new System.Windows.Forms.Button();
            this.b_reimprimir = new System.Windows.Forms.Button();
            this.b_cobrar = new System.Windows.Forms.Button();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.l_total = new System.Windows.Forms.Label();
            this.cb_boletoPerdido = new System.Windows.Forms.CheckBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.tb_cobro = new System.Windows.Forms.TextBox();
            this.l_cobro = new System.Windows.Forms.Label();
            this.tb_cambio = new System.Windows.Forms.TextBox();
            this.l_cambio = new System.Windows.Forms.Label();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.inicioToolStripMenuItem,
            this.adiministracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.registroToolStripMenuItem.Text = "Registro";
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
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.b_reimprimir);
            this.splitContainer1.Panel1.Controls.Add(this.b_CrearRegistro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.b_aceptar);
            this.splitContainer1.Panel2.Controls.Add(this.tb_cambio);
            this.splitContainer1.Panel2.Controls.Add(this.l_cambio);
            this.splitContainer1.Panel2.Controls.Add(this.tb_cobro);
            this.splitContainer1.Panel2.Controls.Add(this.l_cobro);
            this.splitContainer1.Panel2.Controls.Add(this.tb_total);
            this.splitContainer1.Panel2.Controls.Add(this.cb_boletoPerdido);
            this.splitContainer1.Panel2.Controls.Add(this.l_total);
            this.splitContainer1.Panel2.Controls.Add(this.tb_codigo);
            this.splitContainer1.Panel2.Controls.Add(this.b_cobrar);
            this.splitContainer1.Size = new System.Drawing.Size(784, 537);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 2;
            // 
            // b_CrearRegistro
            // 
            this.b_CrearRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_CrearRegistro.Location = new System.Drawing.Point(37, 27);
            this.b_CrearRegistro.Name = "b_CrearRegistro";
            this.b_CrearRegistro.Size = new System.Drawing.Size(322, 59);
            this.b_CrearRegistro.TabIndex = 0;
            this.b_CrearRegistro.Text = "CREAR REGISTRO";
            this.b_CrearRegistro.UseVisualStyleBackColor = true;
            // 
            // b_reimprimir
            // 
            this.b_reimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_reimprimir.Location = new System.Drawing.Point(37, 106);
            this.b_reimprimir.Name = "b_reimprimir";
            this.b_reimprimir.Size = new System.Drawing.Size(322, 59);
            this.b_reimprimir.TabIndex = 1;
            this.b_reimprimir.Text = "REIMPRIMIR";
            this.b_reimprimir.UseVisualStyleBackColor = true;
            // 
            // b_cobrar
            // 
            this.b_cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cobrar.Location = new System.Drawing.Point(26, 61);
            this.b_cobrar.Name = "b_cobrar";
            this.b_cobrar.Size = new System.Drawing.Size(322, 59);
            this.b_cobrar.TabIndex = 2;
            this.b_cobrar.Text = "COBRAR";
            this.b_cobrar.UseVisualStyleBackColor = true;
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(30, 26);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(318, 29);
            this.tb_codigo.TabIndex = 3;
            
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_total.Location = new System.Drawing.Point(29, 177);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(92, 29);
            this.l_total.TabIndex = 4;
            this.l_total.Text = "TOTAL";
            
            // 
            // cb_boletoPerdido
            // 
            this.cb_boletoPerdido.AutoSize = true;
            this.cb_boletoPerdido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_boletoPerdido.Location = new System.Drawing.Point(154, 132);
            this.cb_boletoPerdido.Name = "cb_boletoPerdido";
            this.cb_boletoPerdido.Size = new System.Drawing.Size(194, 33);
            this.cb_boletoPerdido.TabIndex = 8;
            this.cb_boletoPerdido.Text = "Boleto Perdido";
            this.cb_boletoPerdido.UseVisualStyleBackColor = true;
            // 
            // tb_total
            // 
            this.tb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total.Location = new System.Drawing.Point(128, 171);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(220, 35);
            this.tb_total.TabIndex = 9;
            // 
            // tb_cobro
            // 
            this.tb_cobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cobro.Location = new System.Drawing.Point(128, 212);
            this.tb_cobro.Name = "tb_cobro";
            this.tb_cobro.Size = new System.Drawing.Size(220, 35);
            this.tb_cobro.TabIndex = 11;
            // 
            // l_cobro
            // 
            this.l_cobro.AutoSize = true;
            this.l_cobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cobro.Location = new System.Drawing.Point(20, 218);
            this.l_cobro.Name = "l_cobro";
            this.l_cobro.Size = new System.Drawing.Size(101, 29);
            this.l_cobro.TabIndex = 10;
            this.l_cobro.Text = "COBRO";
            // 
            // tb_cambio
            // 
            this.tb_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cambio.Location = new System.Drawing.Point(127, 251);
            this.tb_cambio.Name = "tb_cambio";
            this.tb_cambio.Size = new System.Drawing.Size(220, 35);
            this.tb_cambio.TabIndex = 13;
            // 
            // l_cambio
            // 
            this.l_cambio.AutoSize = true;
            this.l_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cambio.Location = new System.Drawing.Point(15, 257);
            this.l_cambio.Name = "l_cambio";
            this.l_cambio.Size = new System.Drawing.Size(106, 29);
            this.l_cambio.TabIndex = 12;
            this.l_cambio.Text = "CAMBIO";
            // 
            // b_aceptar
            // 
            this.b_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_aceptar.Location = new System.Drawing.Point(26, 311);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(322, 59);
            this.b_aceptar.TabIndex = 14;
            this.b_aceptar.Text = "ACEPTAR";
            this.b_aceptar.UseVisualStyleBackColor = true;
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
            this.Text = "Inicio - Estacionamiento";
            this.Load += new System.EventHandler(this.f_Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adiministracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button b_reimprimir;
        private System.Windows.Forms.Button b_CrearRegistro;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Button b_cobrar;
        private System.Windows.Forms.Label l_total;
        private System.Windows.Forms.TextBox tb_cambio;
        private System.Windows.Forms.Label l_cambio;
        private System.Windows.Forms.TextBox tb_cobro;
        private System.Windows.Forms.Label l_cobro;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.CheckBox cb_boletoPerdido;
        private System.Windows.Forms.Button b_aceptar;
    }
}

