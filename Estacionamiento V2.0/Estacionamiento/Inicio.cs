using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamiento.DataSet1TableAdapters;
using System.IO;
using BarcodeLib;


namespace Estacionamiento
{
    public partial class f_Inicio : Form
    {
        private int permiso;
        private string usuario;

        public f_Inicio(int Permiso, string Usuario)
        {
            permiso = Permiso;
            usuario = Usuario;
            InitializeComponent();
        }


        private static string nombreEmpresa, domicilio, RFC, leyenda;
        private static decimal tolerancia, costoHora, costoDia, costoMes, boletoPerdido, descuento;

        private void f_Inicio_Load(object sender, EventArgs e)
        {
            //carga los datos principales en parametros globales
            cargarDatos();

            if (permiso != 1)// no es administrador
            {
                menuStrip1.Visible = false;              

            }else if(permiso == 1) 
            {
                 tb_subTotal.Visible = true;
                l_subtotal.Visible = true;
                t_descuento.Visible = true;
                l_descuento.Visible = true;
            }
           
            //pone el foco en cobrar
            tb_codigo.Focus();

        }

        private void cargarDatos()
        {
            SP_tabla_parametroTableAdapter param = new SP_tabla_parametroTableAdapter();

            DataTable dt = param.GetData("S", null, null, null, null, null, null, null,null,null,null,null);
            nombreEmpresa = dt.Rows[0]["nombreEmpresa"].ToString();
            domicilio = dt.Rows[0]["domicilio"].ToString();
            RFC = dt.Rows[0]["rfc"].ToString();
            tolerancia = decimal.Parse(dt.Rows[0]["minTolerancia"].ToString());
            costoHora = decimal.Parse(dt.Rows[0]["costoHora"].ToString());
            costoDia = decimal.Parse(dt.Rows[0]["costoDia"].ToString());
            costoMes = decimal.Parse(dt.Rows[0]["costoMes"].ToString());
            boletoPerdido = decimal.Parse(dt.Rows[0]["boletoPerdido"].ToString());
            leyenda = dt.Rows[0]["leyenda"].ToString();
            descuento = decimal.Parse(dt.Rows[0]["descuento"].ToString());
        }
        /// <summary>
        /// Inserta un registro en la tabla renta.para iniciar la renta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_CrearRegistro_Click(object sender, EventArgs e)
        {
            Ticket tick = new Ticket();
            if (!(tick.PrinterExists("Generic")))
            {
                MessageBox.Show("La impresora no esta conectada", "Error");

            }

            SP_tabla_rentaTableAdapter renta = new SP_tabla_rentaTableAdapter();
            renta.GetData("I", 0, DateTime.Now, null, null, null, null);
            //metodo para imprimir en la impresora chiquita.

            QueriesTableAdapter qta = new QueriesTableAdapter();
            int ultimo = (int)qta.ultimoRegistro();

            Barcode codigo = new Barcode();
            codigo.IncludeLabel = true;

            Image imagen = codigo.Encode(TYPE.CODE128, ultimo.ToString(), Color.Black, Color.White, 160, 50);
            //  Byte[] imgByte = Convertir_Imagen_Bytes(imagen);


            tick.AddHeaderLine(nombreEmpresa);
            tick.AddHeaderLine(domicilio);
            if(RFC!="")
                 tick.AddHeaderLine("RFC: " + RFC);
            tick.AddHeaderLine("Atendió: " + usuario);

            tick.AddFooterLine("Fecha: " + DateTime.Now.ToShortDateString());
            tick.AddFooterLine("Hora: " + DateTime.Now.ToShortTimeString());
            tick.HeaderImage = imagen;

            try
            {
                tick.PrintTicket("Generic");
            }
            catch (Exception ex) { }


            p_barcode.BackgroundImage = imagen;


            string hora = Hora_Actual.Text;

            ////int cantidad = 2;
            ////double precio = 45.25;
            ////double total = 90.5;
            //CreaTicket Ticket1 = new CreaTicket();
            ////Ticket1.AbreCajon();  //abre el cajon
            //Ticket1.TextoCentro(nombreEmpresa); // imprime en el centro "Venta mostrador"
            //Ticket1.TextoCentro(domicilio); // imprime en el centro "Venta mostrador"
            //Ticket1.TextoCentro(RFC); // imprime en el centro "Venta mostrador"

            //Ticket1.LineasIgual();
            //Ticket1.TextoIzquierda("Fecha: " + DateTime.Now.ToShortDateString());
            //Ticket1.TextoIzquierda("Hora: " + DateTime.Now.ToShortTimeString());
            //Ticket1.LineasTotales();
            //Ticket1.CortaTicket();


            //  Ticket1.LineasGuion(); // imprime una linea de guiones
            //Ticket1.EncabezadoVenta(); // imprime encabezados
            //  Ticket1.AgregaArticulo(descripcion, cantidad, precio, total); //imprime una linea de descripcion
            // Ticket1.LineasTotales(); // imprime linea 
            //   Ticket1.AgregaTotales("Total", total); // imprime linea con total


            //  RawPrinterHelper raw = new RawPrinterHelper();

            //antes de cortar el ticket manda la imagen generada a bytes para poder imprimirla en el ticket


            //  Ticket1.CortaTicket(); // corta el ticket

        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            Hora_Actual.Text = DateTime.Now.ToShortTimeString();
        }
        /// <summary>
        /// Metodo para convertir una imagen en byte
        /// </summary>
        /// <param name="img">Imagen</param>
        /// <returns></returns>
        public static byte[] Convertir_Imagen_Bytes(Image img)
        {

            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        private void b_cobrar_Click(object sender, EventArgs e)
        {
            hacerCobro();
        }

        private void tb_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hacerCobro();

            }
        }

        int idCobro;
        DateTime dtInicio, dtFin;

        private void hacerCobro()
        {

            try
            {
                idCobro = int.Parse(tb_codigo.Text.Trim());
            }
            catch { MessageBox.Show("Codigo Incorrecto", "ERROR"); }
            t_pago.Text = "";
            SP_tabla_rentaTableAdapter tRenta = new SP_tabla_rentaTableAdapter();
            try
            {
                DataTable dtCobro = tRenta.GetData("F", idCobro, null, null, null, null, null);

                dtInicio = DateTime.Parse(dtCobro.Rows[0]["fechaHoraInicio"].ToString());
                try
                {
                    dtFin = DateTime.Parse(dtCobro.Rows[0]["fechaHoraTermino"].ToString());
                    MessageBox.Show("El boleto ha sido cobrado", "ERROR");
                    return;
                }
                catch { tb_codigo.Text = ""; }

                dtFin = DateTime.Now;
            }
            catch
            {
                tb_codigo.Text = "";
                return;
            }


            //si tiene marcado boleto perdido se marca la cantidad que este en la base de datos
            if (cb_boletoPerdido.Checked)
            {
                tb_subTotal.Text = boletoPerdido.ToString();
                t_total.Text = boletoPerdido.ToString();
                idCobro = 0;
                return;
            }


         
            //hace la validacion para calcular el monto 

            int mesCobrar, horaCobrar, minCobrar, diasCobrar;


            TimeSpan dif = new TimeSpan();

            dif = dtFin - dtInicio;

            decimal cobroTotal = 0;
            //mesCobrar = int.Parse((dif.Days / 30).ToString());
            //mesCobrar = dtFin.Month - dtInicio.Month;
            //if (mesCobrar > 0)
            //{
            //    //si se pasa de un mes se le cobra por mes completo
            //    cobroTotal += (mesCobrar * costoMes);
            //}
            
            diasCobrar = dif.Days;

            //diasCobrar = dtFin.Day - dtInicio.Day;
            if (diasCobrar > 0)
            {
                cobroTotal += (diasCobrar * costoDia);
            }

           
            double xh=  Math.Ceiling(dif.TotalHours);
            
            horaCobrar =   int.Parse(xh.ToString());
             // horaCobrar = dtFin.Hour - dtInicio.Hour;
            //  minCobrar = dtFin.Minute - dtInicio.Minute;
            minCobrar = dif.Minutes;
            if (minCobrar > 0 && minCobrar < tolerancia)
            {
                horaCobrar--;
            }
            //else
            //{
            //    horaCobrar++;
            //}

            if(horaCobrar <=0 ) horaCobrar =1;
            cobroTotal += horaCobrar * costoHora;

            
            tb_subTotal.Text = cobroTotal.ToString();
            t_total.Text = cobroTotal.ToString();

            tb_codigo.Text = "";
          // t_pago.Focus();

        }

        private void cb_boletoPerdido_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_boletoPerdido.Checked)
            {
                idCobro = 0;
                tb_subTotal.Text = boletoPerdido.ToString();
                t_total.Text = boletoPerdido.ToString();
                calcular();
            }
        }

        private void t_descuento_TextChanged(object sender, EventArgs e)
        {
            calcular();


        }

        private void calcular()
        {
            //cada que vaya poniendo algo de descuento cambia el total
            decimal descuento = 0;
            try
            {
                if (t_descuento.Text.Trim() == "") { descuento = 0; }
                else
                {
                    descuento = decimal.Parse(t_descuento.Text);
                }

                decimal total = decimal.Parse(tb_subTotal.Text) - descuento;
                if (total < 0) total = 0;
                t_total.Text = total.ToString();
            }
            catch
            {
                t_descuento.Text = "";
                t_total.Text = tb_subTotal.Text;
            }

            decimal pago = 0;
            try
            {
                if (t_pago.Text.Trim() == "") { pago = 0; t_pago.Text = ""; t_cambio.Text = "0.00"; }
                else
                {
                    pago = decimal.Parse(t_pago.Text);
                    t_cambio.Text = ((decimal.Parse(t_total.Text) - pago) * -1).ToString();
                }
            }
            catch
            {

            }
        }

        private void t_pago_TextChanged(object sender, EventArgs e)
        {

            calcular();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            procesarPago();
        }

        private void procesarPago()
        {
            if (decimal.Parse(t_cambio.Text) < 0 || tb_subTotal.Text.Trim()=="" || tb_subTotal.Text=="0.00")
            {
                MessageBox.Show("El pago no se puede procesar. \n Verifique cantidad.", "ERROR");
                return;
            }
            else
            {
                if (cb_boletoPerdido.Checked)
                {
                    //procesa el pago 
                    if (t_descuento.Text.Trim() == "") t_descuento.Text = "0";
                    if (t_pago.Text.Trim() == "") t_pago.Text = "0";
                    SP_tabla_rentaTableAdapter renta = new SP_tabla_rentaTableAdapter();
                    renta.GetData("I", 0, DateTime.Now, DateTime.Now, cb_boletoPerdido.Checked, decimal.Parse(t_total.Text), decimal.Parse(t_descuento.Text));
                    cb_boletoPerdido.Checked = false;
                }

                else
                {
                    try
                    {
                        //procesa el pago 
                        if (t_descuento.Text.Trim() == "") t_descuento.Text = "0";
                        if (t_pago.Text.Trim() == "") t_pago.Text = "0";
                        //guarda el registro en la base de datos 
                        SP_tabla_rentaTableAdapter renta = new SP_tabla_rentaTableAdapter();
                        renta.GetData("U", idCobro, dtInicio, dtFin, cb_boletoPerdido.Checked, decimal.Parse(t_total.Text), decimal.Parse(t_descuento.Text));
                    }
                    catch { }
                }
                //limpia los campos
                idCobro = 0;
                tb_codigo.Text = "";
                tb_subTotal.Text = "";
                t_cambio.Text = "";
                t_descuento.Text = "";
                t_pago.Text = "";
                t_total.Text = "";

                MessageBox.Show("Cobro realizado", "Estacionamiento");
            }
        }


        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_parametros param = new f_parametros();
            param.Visible = false;
            param.ShowDialog();
            cargarDatos();
        }

        private void t_descuento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcular();
            }
        }

        private void t_pago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                procesarPago();
            }
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_reportes reporte = new f_reportes();
            reporte.ShowDialog();
        }

       

       
    }
}
