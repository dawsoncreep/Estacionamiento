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
    public partial class f_reportes : Form
    {
        public f_reportes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_generarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtInicio = DateTime.Parse(dtpInicio.Text);
                DateTime dtFin = DateTime.Parse(dtpFinal.Text);

                Estacionamiento.DataSet1TableAdapters.reporteDiarioTableAdapter reporte = new DataSet1TableAdapters.reporteDiarioTableAdapter();
                dgvReportes.DataSource = reporte.GetData(dtInicio, dtFin);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void b_imprimir_Click(object sender, EventArgs e)
        {
            
            
            DateTime dtInicio = DateTime.Parse(dtpInicio.Text);
            DateTime dtFin = DateTime.Parse(dtpFinal.Text);
            //manda a imprimir un ticket con los datos
            Ticket tReporte = new Ticket();
            tReporte.AddHeaderLine("Reporte");

            tReporte.AddHeaderLine("Desde:" + dtInicio.ToShortDateString());
            tReporte.AddHeaderLine("Hasta:" + dtFin.ToShortDateString());
            
            Estacionamiento.DataSet1TableAdapters.reporteDiarioTableAdapter reporte = new DataSet1TableAdapters.reporteDiarioTableAdapter();
            DataTable dt = reporte.GetData(dtInicio, dtFin);
            string total = dt.Rows[0]["TotalVenta"].ToString();
            string descuentos = dt.Rows[0]["Descuentos"].ToString();
            string totalTickets = dt.Rows[0]["totalTickets"].ToString();
            string boletosPerdidos = dt.Rows[0]["BoletosPerdidos"].ToString();
            string boletosSinCobrar = dt.Rows[0]["BoletoSinCobrar"].ToString();
            tReporte.AddSubHeaderLine("Detalles");            
            tReporte.AddFooterLine("Total Venta $ " + total);
            tReporte.AddFooterLine("Descuentos  $ " + descuentos);
            tReporte.AddFooterLine("No. Tickets   " + totalTickets);
            tReporte.AddFooterLine("Bol Perdidos  " + boletosPerdidos);
            tReporte.AddFooterLine("Bol Sin Cobrar" + boletosSinCobrar);
            try
            {
                if (!tReporte.PrinterExists("Generic")) MessageBox.Show("Error con la impresora");
                tReporte.PrintTicket("Generic");
            }
            catch (Exception ex) { }
            
            
        }
    }
}
