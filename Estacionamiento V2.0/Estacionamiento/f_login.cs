using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Estacionamiento
{
    public partial class f_login : Form
    {
        public f_login()
        {
            InitializeComponent();
        }

        private int permiso;

        public int Permiso
        {
            get { return permiso; }
            set { permiso = value; }
        }

        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
       

        private int Ingresar(string usuario, string pass)
        {
            l_error.Visible = false;
            l_errorSql.Visible = false;
            try
            {
                Estacionamiento.DataSet1TableAdapters.SP_tabla_usuarioTableAdapter user = new DataSet1TableAdapters.SP_tabla_usuarioTableAdapter();

                DataTable dt = user.GetData("A", null, usuario, pass, null);

                if (dt.Rows.Count > 0)
                {
                    return int.Parse(dt.Rows[0]["rol"].ToString());
                }
                else return 0;
            }
            catch (System.Data.SqlClient.SqlException) { l_errorSql.Visible = true; return 0; }
            
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            int rol = Ingresar(t_user.Text, t_pass.Text);
            if (rol > 0)
            {

                this.permiso = rol;
                this.usuario = t_user.Text;
                this.DialogResult = DialogResult.OK;

                this.Close();
               
            }
            else
            {
                l_error.Visible = true;
                t_user.Focus();
                t_pass.Text = "";
            }
        }

        private void t_pass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rol = Ingresar(t_user.Text, t_pass.Text);
                if (rol > 0)
                {
                    this.permiso = rol;
                    this.usuario = t_user.Text;
                    this.DialogResult = DialogResult.OK;

                    this.Close();
                //   inicio.Show();                 
                   
                }
                else
                {
                    l_error.Visible = true;
                    t_user.Focus();
                    t_pass.Text = "";
                }
            }
        }

        private void f_login_Load(object sender, EventArgs e)
        {
            t_user.Focus();
        }
    }
}
