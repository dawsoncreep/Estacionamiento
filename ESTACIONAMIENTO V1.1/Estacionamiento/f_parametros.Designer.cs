namespace Estacionamiento
{
    partial class f_parametros
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
            this.dgvParametros = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.b_eliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.t_usu = new System.Windows.Forms.TextBox();
            this.t_contra = new System.Windows.Forms.TextBox();
            this.cb_Admin = new System.Windows.Forms.CheckBox();
            this.bNuevoUsuario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.parametroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Estacionamiento.DataSet1();
            this.parametroTableAdapter = new Estacionamiento.DataSet1TableAdapters.parametroTableAdapter();
            this.costoHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minTolerancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idParametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boletoPerdido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leyenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametros)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParametros
            // 
            this.dgvParametros.AllowUserToAddRows = false;
            this.dgvParametros.AllowUserToDeleteRows = false;
            this.dgvParametros.AutoGenerateColumns = false;
            this.dgvParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costoHora,
            this.descuento,
            this.nombreEmpresa,
            this.domicilio,
            this.rfc,
            this.minTolerancia,
            this.idParametro,
            this.costoDia,
            this.costoMes,
            this.boletoPerdido,
            this.leyenda});
            this.dgvParametros.DataSource = this.parametroBindingSource;
            this.dgvParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParametros.Location = new System.Drawing.Point(3, 3);
            this.dgvParametros.Name = "dgvParametros";
            this.dgvParametros.Size = new System.Drawing.Size(886, 321);
            this.dgvParametros.TabIndex = 0;
            this.dgvParametros.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParametros_CellEndEdit);
            this.dgvParametros.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvParametros_DataError);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 353);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvParametros);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PARAMETROS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.b_eliminar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.b_aceptar);
            this.tabPage2.Controls.Add(this.t_usu);
            this.tabPage2.Controls.Add(this.t_contra);
            this.tabPage2.Controls.Add(this.cb_Admin);
            this.tabPage2.Controls.Add(this.bNuevoUsuario);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "USUARIOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // b_eliminar
            // 
            this.b_eliminar.Location = new System.Drawing.Point(510, 89);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(75, 23);
            this.b_eliminar.TabIndex = 5;
            this.b_eliminar.Text = "Eliminar";
            this.b_eliminar.UseVisualStyleBackColor = true;
            this.b_eliminar.Click += new System.EventHandler(this.b_eliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de Usuario";
            // 
            // b_aceptar
            // 
            this.b_aceptar.Location = new System.Drawing.Point(429, 88);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(75, 23);
            this.b_aceptar.TabIndex = 4;
            this.b_aceptar.Text = "Aceptar";
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // t_usu
            // 
            this.t_usu.Location = new System.Drawing.Point(8, 91);
            this.t_usu.Name = "t_usu";
            this.t_usu.Size = new System.Drawing.Size(157, 20);
            this.t_usu.TabIndex = 1;
            // 
            // t_contra
            // 
            this.t_contra.Location = new System.Drawing.Point(171, 91);
            this.t_contra.Name = "t_contra";
            this.t_contra.Size = new System.Drawing.Size(157, 20);
            this.t_contra.TabIndex = 2;
            // 
            // cb_Admin
            // 
            this.cb_Admin.AutoSize = true;
            this.cb_Admin.Location = new System.Drawing.Point(334, 94);
            this.cb_Admin.Name = "cb_Admin";
            this.cb_Admin.Size = new System.Drawing.Size(89, 17);
            this.cb_Admin.TabIndex = 3;
            this.cb_Admin.Text = "Administrador";
            this.cb_Admin.UseVisualStyleBackColor = true;
            // 
            // bNuevoUsuario
            // 
            this.bNuevoUsuario.Location = new System.Drawing.Point(3, 15);
            this.bNuevoUsuario.Name = "bNuevoUsuario";
            this.bNuevoUsuario.Size = new System.Drawing.Size(139, 23);
            this.bNuevoUsuario.TabIndex = 0;
            this.bNuevoUsuario.Text = "Nuevo Usuario";
            this.bNuevoUsuario.UseVisualStyleBackColor = true;
            this.bNuevoUsuario.Click += new System.EventHandler(this.bNuevoUsuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUsuarios);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 16);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(880, 164);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentDoubleClick);
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // parametroBindingSource
            // 
            this.parametroBindingSource.DataMember = "parametro";
            this.parametroBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parametroTableAdapter
            // 
            this.parametroTableAdapter.ClearBeforeFill = true;
            // 
            // costoHora
            // 
            this.costoHora.DataPropertyName = "costoHora";
            this.costoHora.HeaderText = "Costo Hora";
            this.costoHora.Name = "costoHora";
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            // 
            // nombreEmpresa
            // 
            this.nombreEmpresa.DataPropertyName = "nombreEmpresa";
            this.nombreEmpresa.HeaderText = "Nombre Empresa";
            this.nombreEmpresa.Name = "nombreEmpresa";
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            // 
            // rfc
            // 
            this.rfc.DataPropertyName = "rfc";
            this.rfc.HeaderText = "RFC";
            this.rfc.Name = "rfc";
            // 
            // minTolerancia
            // 
            this.minTolerancia.DataPropertyName = "minTolerancia";
            this.minTolerancia.HeaderText = "Minutos Tolerancia";
            this.minTolerancia.Name = "minTolerancia";
            // 
            // idParametro
            // 
            this.idParametro.DataPropertyName = "idParametro";
            this.idParametro.HeaderText = "idParametro";
            this.idParametro.Name = "idParametro";
            this.idParametro.Visible = false;
            // 
            // costoDia
            // 
            this.costoDia.DataPropertyName = "costoDia";
            this.costoDia.HeaderText = "Costo Dia";
            this.costoDia.Name = "costoDia";
            // 
            // costoMes
            // 
            this.costoMes.DataPropertyName = "costoMes";
            this.costoMes.HeaderText = "Costo Mes";
            this.costoMes.Name = "costoMes";
            // 
            // boletoPerdido
            // 
            this.boletoPerdido.DataPropertyName = "boletoPerdido";
            this.boletoPerdido.HeaderText = "Boleto Perdido";
            this.boletoPerdido.Name = "boletoPerdido";
            // 
            // leyenda
            // 
            this.leyenda.DataPropertyName = "leyenda";
            this.leyenda.HeaderText = "leyenda";
            this.leyenda.MaxInputLength = 300;
            this.leyenda.Name = "leyenda";
            // 
            // f_parametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 353);
            this.Controls.Add(this.tabControl1);
            this.Name = "f_parametros";
            this.Text = "Estacionamiento - Parametros";
            this.Load += new System.EventHandler(this.f_parametros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametros)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParametros;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource parametroBindingSource;
        private DataSet1TableAdapters.parametroTableAdapter parametroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minToleranciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParametroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoMesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boletoPerdidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox t_usu;
        private System.Windows.Forms.TextBox t_contra;
        private System.Windows.Forms.CheckBox cb_Admin;
        private System.Windows.Forms.Button bNuevoUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn minTolerancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn boletoPerdido;
        private System.Windows.Forms.DataGridViewTextBoxColumn leyenda;
    }
}