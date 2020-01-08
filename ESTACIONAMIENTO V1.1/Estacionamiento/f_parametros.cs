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
    public partial class f_parametros : Form
    {
        public f_parametros()
        {
            InitializeComponent();
        }

        private void f_parametros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.parametro' table. You can move, or remove it, as needed.
            this.parametroTableAdapter.Fill(this.dataSet1.parametro);
            if (this.dataSet1.parametro.Rows.Count == 0)
            {
                try
                {
                    //si no tiene registro de parametros agrega uno nuevo 
                    //con datos en 0 
                    Estacionamiento.DataSet1TableAdapters.SP_tabla_parametroTableAdapter paramTA = new DataSet1TableAdapters.SP_tabla_parametroTableAdapter();
                    paramTA.GetData("I", decimal.Zero, decimal.Zero, "", "", "", 0, 0, decimal.Zero, decimal.Zero, decimal.Zero, "");
                }
                catch { }
            }
            this.parametroTableAdapter.Fill(this.dataSet1.parametro);
            cargarUsuarios();          

        }

        private void cargarUsuarios()
        {
            Estacionamiento.DataSet1TableAdapters.SP_tabla_usuarioTableAdapter user = new DataSet1TableAdapters.SP_tabla_usuarioTableAdapter();
            dgvUsuarios.DataSource = user.GetData("S", null, null, null, null);
        }



        private void dgvParametros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Estacionamiento.DataSet1TableAdapters.SP_tabla_parametroTableAdapter paramTA = new DataSet1TableAdapters.SP_tabla_parametroTableAdapter();
                paramTA.GetData("U", decimal.Parse(dgvParametros.Rows[0].Cells["costoHora"].Value.ToString()),
                    decimal.Parse(dgvParametros.Rows[0].Cells["descuento"].Value.ToString()),
                    dgvParametros.Rows[0].Cells["nombreEmpresa"].Value.ToString(),
                     dgvParametros.Rows[0].Cells["domicilio"].Value.ToString(),
                    dgvParametros.Rows[0].Cells["rfc"].Value.ToString(),
                   int.Parse(dgvParametros.Rows[0].Cells["minTolerancia"].Value.ToString()),
                    int.Parse(dgvParametros.Rows[0].Cells["idParametro"].Value.ToString())
                    ,decimal.Parse(dgvParametros.Rows[0].Cells["costoDia"].Value.ToString()),
                    decimal.Parse(dgvParametros.Rows[0].Cells["costoMes"].Value.ToString()),
                    decimal.Parse(dgvParametros.Rows[0].Cells["boletoPerdido"].Value.ToString()),
                     dgvParametros.Rows[0].Cells["leyenda"].Value.ToString() ); 
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible realizar el cambio, \n Verifique los datos", "Error");

            }
        }

        private void dgvParametros_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
            MessageBox.Show("No es posible realizar el cambio, \n Verifique los datos", "Error");
            e.Cancel = false;
        }

        private int idUsuario=0;
        private void bNuevoUsuario_Click(object sender, EventArgs e)
        {
            idUsuario = 0;
            t_usu.Text = "";
            t_contra.Text = "";
            t_usu.Focus();

        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Estacionamiento.DataSet1TableAdapters.SP_tabla_usuarioTableAdapter user = new DataSet1TableAdapters.SP_tabla_usuarioTableAdapter();
                int rol = 0;
                if (idUsuario > 0) //es para hacer un update
                {

                    if (cb_Admin.Checked) rol = 1;
                    user.GetData("U", idUsuario, t_usu.Text, t_contra.Text, rol);

                }
                else //si no es para hacer un insert
                {
                    if (cb_Admin.Checked) rol = 1;
                    user.GetData("I", 0, t_usu.Text, t_contra.Text, rol);
                }
                cargarUsuarios();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR"); }
        }

        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //si da doble clic saca los datos del usuario para modificarlo.

            t_usu.Text = dgvUsuarios.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            t_contra.Text = dgvUsuarios.Rows[e.RowIndex].Cells["contraseña"].Value.ToString();
            idUsuario = int.Parse( dgvUsuarios.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString());
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //si da doble clic saca los datos del usuario para modificarlo.

                t_usu.Text = dgvUsuarios.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
                t_contra.Text = dgvUsuarios.Rows[e.RowIndex].Cells["contraseña"].Value.ToString();
                idUsuario = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString());
            }
            catch { }
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            if (idUsuario > 0)
            {
                Estacionamiento.DataSet1TableAdapters.SP_tabla_usuarioTableAdapter user = new DataSet1TableAdapters.SP_tabla_usuarioTableAdapter();
                user.GetData("D", idUsuario, null, null, null);
                t_usu.Text = "";
                t_contra.Text = "";
                cargarUsuarios();
            }
        }



       
    }
}
