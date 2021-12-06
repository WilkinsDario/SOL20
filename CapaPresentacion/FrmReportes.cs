using CapaDatos;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReportes : Form
    {
        public string usuario;
        public string banca;
        public string acceso;
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string banca = this.cbBanca.Text;
            if (acceso == "Administrador")
            {
                using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                {
                    if (ckbTodo.Checked)
                    {
                        var consulta = context.Jugada.Where(x => x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day
                                                                                                                    && x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month
                                                                                                                    && x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();
                        datalistado.DataSource = consulta;
                    }
                    else if (ckbFacturado.Checked)
                    {
                        decimal suma = 0;
                        if (cbBanca.Text != "Todas")
                        {


                            var consulta = context.Jugada.Where(x => x.Estatus != "Cancelado" && x.Banca == banca && x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day
                                                                                                                        && x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month
                                                                                                                        && x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();
                            foreach (var item in consulta)
                            {
                                suma = suma + Convert.ToDecimal(item.Monto);
                            }

                            lblTotalFacturado.Text = "Total Facturado: " + suma.ToString();
                            lblTotalFacturado.Visible = true;
                            datalistado.DataSource = consulta;
                        }
                        else
                        {
                            var consulta = context.Jugada.Where(x => x.Estatus != "Cancelado" && x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day
                                                                                                                    && x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month
                                                                                                                    && x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();

                            foreach (var item in consulta)
                            {
                                suma = suma + Convert.ToDecimal(item.Monto);
                            }

                            lblTotalFacturado.Text = "Total Facturado: " + suma.ToString();
                            lblTotalFacturado.Visible = true;
                            datalistado.DataSource = consulta;
                        }

                        if (ckbImprimir.Checked)
                        {
                            printReporte = new PrintDocument();
                            PrinterSettings ps = new PrinterSettings();
                            printReporte.PrinterSettings = ps;
                            printReporte.PrintPage += Imprimir;
                            printReporte.Print();
                        }
                    }
                    else if (ckbPagado.Checked)
                    {
                        decimal suma = 0;
                        var consulta = context.Jugada.Where(x => x.Estatus == "Pagado" && x.Banca == banca && x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day
                                                                                                                    && x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month
                                                                                                                    && x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();
                        if (consulta.Count != 0)
                        {
                            foreach (var item in consulta)
                            {
                                suma = suma + Convert.ToDecimal(item.Monto);
                            }

                            lblTotalPagado.Text = "Total Pagado: " + suma.ToString();
                            lblTotalPagado.Visible = true;
                            datalistado.DataSource = consulta;
                            OcultarColumnas();

                            if (ckbImprimir.Checked)
                            {
                                printReporte = new PrintDocument();
                                PrinterSettings ps = new PrinterSettings();
                                printReporte.PrinterSettings = ps;
                                printReporte.PrintPage += Imprimir;
                                printReporte.Print();
                            }
                        }
                        else
                        {
                            mensajeOk("No hubo jugadas pagadas");
                        }
                    }
                }
            }
            else
            {
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    if (ckbTodo.Checked)
                    {
                        var consulta = context.Jugada.Where(x => x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day
                                                                                                                    && x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month
                                                                                                                    && x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();
                        datalistado.DataSource = consulta;
                    }
                    else if (ckbFacturado.Checked)
                    {
                        decimal suma = 0;
                        var consulta = context.Jugada.Where(x => x.Estatus != "Cancelado" && x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day
                                                                                                                   && x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month
                                                                                                                    && x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();

                        foreach (var item in consulta)
                        {
                            suma = suma + Convert.ToDecimal(item.Monto);
                        }

                        lblTotalFacturado.Text = "Total Facturado: " + suma.ToString();
                        lblTotalFacturado.Visible = true;
                        datalistado.DataSource = consulta;

                        if (ckbImprimir.Checked)
                        {
                            printReporte = new PrintDocument();
                            PrinterSettings ps = new PrinterSettings();
                            printReporte.PrinterSettings = ps;
                            printReporte.PrintPage += Imprimir;
                            printReporte.Print();
                        }
                    }
                    else if (ckbPagado.Checked)
                    {
                        decimal suma = 0;
                        var consulta = context.Jugada.Where(x => x.Estatus == "Pagado" && x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day
                                                                                                                    && x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month
                                                                                                                    && x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();
                        if (consulta.Count != 0)
                        {
                            foreach (var item in consulta)
                            {
                                suma = suma + Convert.ToDecimal(item.Monto);
                            }

                            lblTotalFacturado.Text = "Total Pagado: " + suma.ToString();
                            lblTotalPagado.Visible = true;
                            datalistado.DataSource = consulta;
                            OcultarColumnas();

                            if (ckbImprimir.Checked)
                            {
                                printReporte = new PrintDocument();
                                PrinterSettings ps = new PrinterSettings();
                                printReporte.PrinterSettings = ps;
                                printReporte.PrintPage += Imprimir;
                                printReporte.Print();
                            }
                        }
                        else
                        {
                            mensajeOk("No hubo jugadas pagadas");
                        }
                    }
                }
            }
        }

        private void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            if (acceso == "Administrador")
            {
                if (ckbFacturado.Checked)
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        DateTime fecha = DateTime.Now;
                        var consulta = context.Jugada.Where(x => x.Estatus != "Cancelado" && x.Estatus != "Pagado" && x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Year >= dtpDesde.Value.Year
                                                                  && x.Fecha.Value.Day <= dtpHasta.Value.Day && x.Fecha.Value.Month <= dtpHasta.Value.Month && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();

                        Font cabeza = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                        Font fuente = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                        Font eslogan1 = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);

                        int anchohasta = 250;
                        int anchodesde = 0;
                        int lineado = 20;
                        int largo = 50;
                        decimal suma = 0;

                        e.Graphics.DrawString("Consorcio de Bancas", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("             SOL20", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("Donde Garantizamos tu Dinero", eslogan1, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString(DateTime.Now.ToString(), fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                        foreach (var item in consulta)
                        {
                            e.Graphics.DrawString(item.Loteria, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                            suma = suma + Convert.ToDecimal(item.Monto);
                        }

                        e.Graphics.DrawString("----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("Total Facturado: " + "" + suma.ToString(), cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                    }
                }
                else if (ckbPagado.Checked)
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        DateTime fecha = DateTime.Now;
                        var consulta = context.Jugada.Where(x => x.Estatus == "Pagado" && x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Year >= dtpDesde.Value.Year
                                                                  && x.Fecha.Value.Day <= dtpHasta.Value.Day && x.Fecha.Value.Month <= dtpHasta.Value.Month && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();

                        Font cabeza = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                        Font fuente = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                        Font eslogan1 = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);

                        int anchohasta = 250;
                        int anchodesde = 0;
                        int lineado = 20;
                        int largo = 50;
                        decimal suma = 0;

                        e.Graphics.DrawString("Consorcio de Bancas", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("             SOL20", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("Donde Garantizamos tu Dinero", eslogan1, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString(DateTime.Now.ToString(), fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                        foreach (var item in consulta)
                        {
                            e.Graphics.DrawString(item.Loteria + " " + item.Jugada1 + "      " + item.Monto, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                            suma = suma + Convert.ToDecimal(item.Monto);
                        }

                        e.Graphics.DrawString("----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                    }
                }
            }
            else
            {
                if (ckbFacturado.Checked)
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        DateTime fecha = DateTime.Now;
                        var consulta = context.Jugada.Where(x => x.Estatus != "Cancelado" && x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Year >= dtpDesde.Value.Year
                                                                  && x.Fecha.Value.Day <= dtpHasta.Value.Day && x.Fecha.Value.Month <= dtpHasta.Value.Month && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();

                        Font cabeza = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                        Font fuente = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                        Font eslogan1 = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);

                        int anchohasta = 250;
                        int anchodesde = 0;
                        int lineado = 20;
                        int largo = 50;
                        decimal suma = 0;

                        e.Graphics.DrawString("Consorcio de Bancas", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("             SOL20", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("Donde Garantizamos tu Dinero", eslogan1, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString(DateTime.Now.ToString(), fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                        foreach (var item in consulta)
                        {
                            e.Graphics.DrawString(item.Loteria, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                            suma = suma + Convert.ToDecimal(item.Monto);
                        }

                        e.Graphics.DrawString("----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("Total Facturado: " + "" + suma.ToString(), cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                    }
                }
                else if (ckbPagado.Checked)
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        DateTime fecha = DateTime.Now;
                        var consulta = context.Jugada.Where(x => x.Estatus == "Pagado" && x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Year >= dtpDesde.Value.Year
                                                                  && x.Fecha.Value.Day <= dtpHasta.Value.Day && x.Fecha.Value.Month <= dtpHasta.Value.Month && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();

                        Font cabeza = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                        Font fuente = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                        Font eslogan1 = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);

                        int anchohasta = 250;
                        int anchodesde = 0;
                        int lineado = 20;
                        int largo = 50;
                        decimal suma = 0;

                        e.Graphics.DrawString("Consorcio de Bancas", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("             SOL20", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("Donde Garantizamos tu Dinero", eslogan1, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString(DateTime.Now.ToString(), fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                        foreach (var item in consulta)
                        {
                            e.Graphics.DrawString(item.Loteria + " " + item.Jugada1 + "      " + item.Monto, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                            suma = suma + Convert.ToDecimal(item.Monto);
                        }

                        e.Graphics.DrawString("----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                    }
                }
            }
        }


        private void FrmReportes_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 10;
            lblTotalFacturado.Visible = false;
            lblTotalPagado.Visible = false;
            Llenar_Banca();
        }

        private void Llenar_Banca()
        {
            try
            {
                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        var consulta = context.Usuarios.ToList();
                        foreach (var item in consulta)
                        {
                            cbBanca.Items.Add(item.Banca);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void OcultarColumnas()
        {
            this.datalistado.Columns[0].Visible = false;
        }

        private void ckbTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTodo.Checked)
            {
                ckbTodo.Checked = true;
                ckbFacturado.Checked = false;
                ckbPagado.Checked = false;
            }
            else
            {
                ckbTodo.Checked = false;
            }
        }

        private void ckbFacturado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFacturado.Checked)
            {
                ckbFacturado.Checked = true;
                ckbTodo.Checked = false;
                ckbPagado.Checked = false;
            }
            else
            {
                ckbFacturado.Checked = false;
            }
        }

        private void ckbImprimir_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbImprimir.Checked)
            {
                ckbImprimir.Checked = true;
                ckbImprimir.Enabled = true;
            }
            else
            {
                ckbImprimir.Checked = false;
                ckbImprimir.Enabled = false;
            }
        }

        private void ckbPagado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPagado.Checked)
            {
                ckbPagado.Checked = true;
                ckbTodo.Checked = false;
                ckbFacturado.Checked = false;
            }
            else
            {
                ckbPagado.Checked = false;
            }
        }
    }
}
