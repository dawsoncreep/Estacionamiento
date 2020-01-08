namespace Estacionamiento
{
    partial class f_login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_errorSql = new System.Windows.Forms.Label();
            this.l_error = new System.Windows.Forms.Label();
            this.t_pass = new System.Windows.Forms.TextBox();
            this.t_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_login = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_errorSql);
            this.groupBox1.Controls.Add(this.l_error);
            this.groupBox1.Controls.Add(this.t_pass);
            this.groupBox1.Controls.Add(this.t_user);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.b_login);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso";
            // 
            // l_errorSql
            // 
            this.l_errorSql.AutoSize = true;
            this.l_errorSql.BackColor = System.Drawing.SystemColors.Control;
            this.l_errorSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_errorSql.ForeColor = System.Drawing.Color.Red;
            this.l_errorSql.Location = new System.Drawing.Point(55, 247);
            this.l_errorSql.Name = "l_errorSql";
            this.l_errorSql.Size = new System.Drawing.Size(152, 15);
            this.l_errorSql.TabIndex = 6;
            this.l_errorSql.Text = "No hay conexion a BD.";
            this.l_errorSql.Visible = false;
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.BackColor = System.Drawing.SystemColors.Control;
            this.l_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(55, 225);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(157, 15);
            this.l_error.TabIndex = 5;
            this.l_error.Text = "Usuario no encontrado.";
            this.l_error.Visible = false;
            // 
            // t_pass
            // 
            this.t_pass.Location = new System.Drawing.Point(30, 141);
            this.t_pass.Name = "t_pass";
            this.t_pass.Size = new System.Drawing.Size(215, 20);
            this.t_pass.TabIndex = 4;
            this.t_pass.UseSystemPasswordChar = true;
            this.t_pass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.t_pass_KeyUp);
            // 
            // t_user
            // 
            this.t_user.Location = new System.Drawing.Point(30, 72);
            this.t_user.Name = "t_user";
            this.t_user.Size = new System.Drawing.Size(215, 20);
            this.t_user.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO:";
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(30, 189);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(215, 23);
            this.b_login.TabIndex = 0;
            this.b_login.Text = "INGRESAR";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // f_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "f_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamiento";
           
            this.Shown += new System.EventHandler(this.f_login_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.TextBox t_pass;
        private System.Windows.Forms.TextBox t_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_errorSql;
        private System.Windows.Forms.Label l_error;
    }
}