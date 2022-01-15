using CapaDatos;
using Presentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCierre : Form
    {
        public string usuario;
        public string banca;
        public string acceso;

        public FrmCierre()
        {
            InitializeComponent();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (txtUno.Text != string.Empty)
            {
                total = total + (Convert.ToInt32(txtUno.Text) * 1);
            }
            if (txtCinco.Text != string.Empty)
            {
                total = total + (Convert.ToInt32(txtCinco.Text) * 5);
            }
            if (txtDiez.Text != string.Empty)
            {
                total = total + (Convert.ToInt32(txtDiez.Text) * 10);
            }
            if (txtVeinticinco.Text != string.Empty)
            {
                total = total + (Convert.ToInt32(txtVeinticinco.Text) * 25);
            }
            if (txtCincuenta.Text != string.Empty)
            {
                total = total + (Convert.ToInt32(txtCincuenta.Text) * 50);
            }
            if (txtCien.Text != string.Empty)
            {
                total = total + (Convert.ToInt32(txtCien.Text) * 100);
            }
            if (txtDosientos.Text != string.Empty)
            {
                total = total + (Convert.ToInt32(txtDosientos.Text) * 200);
            }
            if (txtQuiniento.Text != string.Empty)
            {
                total = total + (Convert.ToInt32(txtQuiniento.Text) * 500);
            }
            if (txtMil.Text != string.Empty)
            {
                total = total + (Convert.ToInt32(txtMil.Text) * 1000);
            }
            if (txtDosmil.Text != string.Empty)
            {
                total = total + (Convert.ToInt32(txtDosmil.Text) * 2000);
            }

            txtTotal.Text = total.ToString();

            if (Convert.ToDouble(this.txtTotal.Text) - Convert.ToDouble(this.txtBalance.Text) >= 0)
            {
                txtFaltante.Text = 0.ToString();
                txtExedente.Text = (total - Convert.ToDouble(txtBalance.Text)).ToString();
            }
            else
            {
                txtExedente.Text = 0.ToString();
                txtFaltante.Text = (total - Convert.ToDouble(txtBalance.Text)).ToString();
            }


        }

        private void FrmCierre_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 10;
            lblBanca.Text = this.banca.ToUpper();
            dtpFiltroFecha.Enabled = false;

        }

        private void Faltante()
        {
            try
            {
                decimal suma = 0;
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    var faltante = context.Jugada.Where(x => x.Estatus != "Cancelado" && x.Fecha.Value.Day == dtpFiltroFecha.Value.Day && x.Fecha.Value.Month == dtpFiltroFecha.Value.Month && x.Fecha.Value.Year == dtpFiltroFecha.Value.Year && x.Banca == banca).ToList();

                    foreach (var item in faltante)
                    {
                        suma = Convert.ToDecimal(suma + item.Monto);
                    }
                }
                txtBalance.Text = suma.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void Limpiar()
        {
            txtUno.Text = string.Empty;
            txtCinco.Text = string.Empty;
            txtDiez.Text = string.Empty;
            txtVeinticinco.Text = string.Empty;
            txtCincuenta.Text = string.Empty;
            txtCien.Text = string.Empty;
            txtDosientos.Text = string.Empty;
            txtQuiniento.Text = string.Empty;
            txtMil.Text = string.Empty;
            txtDosmil.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtExedente.Text = string.Empty;
            txtFaltante.Text = string.Empty;
        }

        private void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar_Cierre()
        {
            try
            {
                CapaDatos.ModeloLocal.Cierres temporal_cierre = new CapaDatos.ModeloLocal.Cierres();
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    var consulta = context.Cierres.ToList();
                    if (consulta.Count != 0)
                    {

                        foreach (var item in consulta)
                        {
                            context.Cierres.Remove(item);
                        }
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Cerrar()
        {
            try
            {
                Limpiar_Cierre();

                List<string> unidad = new List<string>();
                List<string> cantidad = new List<string>();
                List<string> total = new List<string>();

                CapaDatos.ModeloLocal.Cierres _cierres = new CapaDatos.ModeloLocal.Cierres();

                using (CapaDatos.ModeloLocal.Modelo_Local contextlocal = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    _cierres.Faltante = Convert.ToDecimal(txtFaltante.Text);
                    _cierres.Exedente = Convert.ToDecimal(txtExedente.Text);
                    _cierres.Total = Convert.ToDecimal(txtBalance.Text);
                    _cierres.Fecha = dtpFiltroFecha.Value;
                    _cierres.Banca = this.banca;
                    _cierres.Usuario = this.usuario;
                    _cierres.Estatus = "Cerrado";

                    contextlocal.Cierres.Add(_cierres);
                    contextlocal.SaveChanges();


                    if (txtUno.Text != string.Empty)
                    {
                        _cierres.Unidad = "Uno";
                        _cierres.Cantidad = Convert.ToInt32(txtUno.Text);
                        _cierres.Total = Convert.ToInt32(txtUno.Text);

                        contextlocal.Cierres.Add(_cierres);
                        contextlocal.SaveChanges();
                    }
                    if (txtCinco.Text != string.Empty)
                    {
                        _cierres.Unidad = "Cinco";
                        _cierres.Cantidad = Convert.ToInt32(txtCinco.Text);
                        _cierres.Total = (Convert.ToInt32(txtCinco.Text) * 5);

                        contextlocal.Cierres.Add(_cierres);
                        contextlocal.SaveChanges();
                    }
                    if (txtDiez.Text != string.Empty)
                    {
                        _cierres.Unidad = "Diez";
                        _cierres.Cantidad = Convert.ToInt32(txtDiez.Text);
                        _cierres.Total = (Convert.ToInt32(txtDiez.Text) * 10);

                        contextlocal.Cierres.Add(_cierres);
                        contextlocal.SaveChanges();
                    }
                    if (txtVeinticinco.Text != string.Empty)
                    {
                        _cierres.Unidad = "Veinticinco";
                        _cierres.Cantidad = Convert.ToInt32(txtVeinticinco.Text);
                        _cierres.Total = (Convert.ToInt32(txtVeinticinco.Text) * 25);

                        contextlocal.Cierres.Add(_cierres);
                        contextlocal.SaveChanges();
                    }
                    if (txtCincuenta.Text != string.Empty)
                    {
                        _cierres.Unidad = "Cincuenta";
                        _cierres.Cantidad = Convert.ToInt32(txtCincuenta.Text);
                        _cierres.Total = (Convert.ToInt32(txtCincuenta.Text) * 50);

                        contextlocal.Cierres.Add(_cierres);
                        contextlocal.SaveChanges();
                    }
                    if (txtCien.Text != string.Empty)
                    {
                        _cierres.Unidad = "Cien";
                        _cierres.Cantidad = Convert.ToInt32(txtCien.Text);
                        _cierres.Total = (Convert.ToInt32(txtCien.Text) * 100);

                        contextlocal.Cierres.Add(_cierres);
                        contextlocal.SaveChanges();
                    }
                    if (txtDosientos.Text != string.Empty)
                    {
                        _cierres.Unidad = "Dociento";
                        _cierres.Cantidad = Convert.ToInt32(txtDosientos.Text);
                        _cierres.Total = (Convert.ToInt32(txtDosientos.Text) * 200);

                        contextlocal.Cierres.Add(_cierres);
                        contextlocal.SaveChanges();
                    }
                    if (txtQuiniento.Text != string.Empty)
                    {
                        _cierres.Unidad = "Quiniento";
                        _cierres.Cantidad = Convert.ToInt32(txtQuiniento.Text);
                        _cierres.Total = (Convert.ToInt32(txtQuiniento.Text) * 500);

                        contextlocal.Cierres.Add(_cierres);
                        contextlocal.SaveChanges();
                    }
                    if (txtMil.Text != string.Empty)
                    {
                        _cierres.Unidad = "Mil";
                        _cierres.Cantidad = Convert.ToInt32(txtMil.Text);
                        _cierres.Total = (Convert.ToInt32(txtMil.Text) * 1000);

                        contextlocal.Cierres.Add(_cierres);
                        contextlocal.SaveChanges();
                    }
                    if (txtDosmil.Text != string.Empty)
                    {
                        _cierres.Unidad = "Dosmil";
                        _cierres.Cantidad = Convert.ToInt32(txtDosmil.Text);
                        _cierres.Total = (Convert.ToInt32(txtDosmil.Text) * 2000);

                        contextlocal.Cierres.Add(_cierres);
                        contextlocal.SaveChanges();
                    }
                    mensajeOk("Cierre Inicial");
                }
            }
            catch (Exception)
            {

            }
        }

        //        private static DateTime Fecha_Actual()
        //        {


        //            var result = DateTime.MinValue;

        //            // Initialize the list of NIST time servers
        //            // http://tf.nist.gov/tf-cgi/servers.cgi
        //            string[] servers = new string[] {
        //        "nist1-ny.ustiming.org",
        //        "nist1-nj.ustiming.org",
        //        "nist1-pa.ustiming.org",
        //        "time-a.nist.gov",
        //        "time-b.nist.gov",
        //        "nist1.aol-va.symmetricom.com",
        //        "nist1.columbiacountyga.gov",
        //        "nist1-chi.ustiming.org",
        //        "nist.expertsmi.com",
        //        "nist.netservicesgroup.com"
        //};

        //            // Try 5 servers in random order to spread the load
        //            Random rnd = new Random();
        //            foreach (string server in servers.OrderBy(s => rnd.NextDouble()).Take(5))
        //            {
        //                try
        //                {
        //                    // Connect to the server (at port 13) and get the response
        //                    string serverResponse = string.Empty;
        //                    using (var reader = new StreamReader(new System.Net.Sockets.TcpClient(server, 13).GetStream()))
        //                    {
        //                        serverResponse = reader.ReadToEnd();
        //                    }

        //                    // If a response was received
        //                    if (!string.IsNullOrEmpty(serverResponse))
        //                    {
        //                        // Split the response string ("55596 11-02-14 13:54:11 00 0 0 478.1 UTC(NIST) *")
        //                        string[] tokens = serverResponse.Split(' ');

        //                        // Check the number of tokens
        //                        if (tokens.Length >= 6)
        //                        {
        //                            // Check the health status
        //                            string health = tokens[5];
        //                            if (health == "0")
        //                            {
        //                                // Get date and time parts from the server response
        //                                string[] dateParts = tokens[1].Split('-');
        //                                string[] timeParts = tokens[2].Split(':');

        //                                // Create a DateTime instance
        //                                DateTime utcDateTime = new DateTime(
        //                                    Convert.ToInt32(dateParts[0]) + 2000,
        //                                    Convert.ToInt32(dateParts[1]), Convert.ToInt32(dateParts[2]),
        //                                    Convert.ToInt32(timeParts[0]), Convert.ToInt32(timeParts[1]),
        //                                    Convert.ToInt32(timeParts[2]));

        //                                // Convert received (UTC) DateTime value to the local timezone
        //                                result = utcDateTime.ToLocalTime();

        //                                return result;
        //                                // Response successfully received; exit the loop

        //                            }
        //                        }

        //                    }

        //                }
        //                catch
        //                {
        //                    // Ignore exception and try the next server
        //                }
        //            }
        //            return result;
        //        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    var faltante = context.Jugada.Where(x => x.Estatus == "Activo" && x.Fecha.Value.Day == dtpFiltroFecha.Value.Day && x.Fecha.Value.Month == dtpFiltroFecha.Value.Month && x.Fecha.Value.Year == dtpFiltroFecha.Value.Year && x.Banca == banca
                    ).ToList();

                    if (faltante != null)
                    {
                        Cerrar();


                        printDocument = new PrintDocument();
                        PrinterSettings ps = new PrinterSettings();
                        printDocument.PrinterSettings = ps;
                        printDocument.PrintPage += Imprimir;
                        printDocument.Print();

                        if (acceso == "Colaborador")
                        {
                            printDocument = new PrintDocument();
                            PrinterSettings psc = new PrinterSettings();
                            printDocument.PrinterSettings = psc;
                            printDocument.PrintPage += ImprimirCopia;
                            printDocument.Print();
                        }


                        foreach (var item in faltante)
                        {
                            if (item.Estatus == "Activo")
                            {
                                item.Estatus = "Cerrado";
                                context.SaveChanges();
                            }
                        }
                        Limpiar();

                        mensajeOk("Espere un momento migrando....");
                    }
                    else
                    {
                        mensajeError("No se realizó cierre");
                    }
                    Faltante();
                }
            }
            catch (Exception)
            {

            }

            Migrar_Jugadas_Diarias();

            Migrar_Resultados_Serv();

            mensajeOk("Finalizado Puede Cerrar");
        }

        private void Migrar_Jugadas_Diarias()
        {
            try
            {
                int cont = 0;

                using (CapaDatos.Modelo.ModelDB contextserver = new CapaDatos.Modelo.ModelDB())
                {
                    CapaDatos.ModeloLocal.Modelo_Local contextlocal = new CapaDatos.ModeloLocal.Modelo_Local();

                    CapaDatos.Modelo.Jugada _jugada = new CapaDatos.Modelo.Jugada();
                    var consultalocal = contextlocal.Jugada.Where(x => x.Fecha.Value.Day == dtpFiltroFecha.Value.Day &&
                                                                       x.Fecha.Value.Month == dtpFiltroFecha.Value.Month &&
                                                                       x.Fecha.Value.Year == dtpFiltroFecha.Value.Year).ToList();

                    foreach (var item in consultalocal)
                    {
                        _jugada.Total = item.Total;
                        _jugada.Numero_Jugada = item.Numero_Jugada;
                        _jugada.Numero_Ticket = item.Numero_Ticket;
                        _jugada.Fecha = item.Fecha;
                        _jugada.Estatus = item.Estatus;
                        _jugada.Loteria = item.Loteria;
                        _jugada.Tipo_Jugada = item.Tipo_Jugada;
                        _jugada.Jugada1 = item.Jugada1;
                        _jugada.Monto = item.Monto;
                        _jugada.Quiniela = item.Quiniela;
                        _jugada.Pale = item.Pale;
                        _jugada.Tripleta = item.Tripleta;
                        _jugada.Banca = item.Banca;
                        _jugada.Usuario = item.Usuario;

                        contextserver.Jugada.Add(_jugada);
                        contextserver.SaveChanges();
                        cont = cont + 1;
                    }
                    if (cont != 0)
                    {
                        mensajeOk("Se migraron " + cont.ToString() + " Jugadas");
                        cont = 0;
                    }
                    else
                    {
                        mensajeOk("No se migraron jugadas");
                    }
                }
            }
            catch (Exception)
            {

            }            
        }

        private void Migrar_Resultados_Serv()
        {
            try
            {
                int cont = 0;

                using (CapaDatos.Modelo.ModelDB contextserver = new CapaDatos.Modelo.ModelDB())
                {
                    CapaDatos.ModeloLocal.Modelo_Local contextlocal = new CapaDatos.ModeloLocal.Modelo_Local();

                    CapaDatos.Modelo.Ganadores _jugada = new CapaDatos.Modelo.Ganadores();
                    var consultalocal = contextlocal.Ganadores.Where(x => x.Fecha.Value.Day == dtpFiltroFecha.Value.Day &&
                                                                       x.Fecha.Value.Month == dtpFiltroFecha.Value.Month &&
                                                                       x.Fecha.Value.Year == dtpFiltroFecha.Value.Year).ToList();

                    foreach (var item in consultalocal)
                    {
                        _jugada.Loteria = item.Loteria;
                        _jugada.Primera = item.Primera;
                        _jugada.Segunda = item.Segunda;
                        _jugada.Tercera = item.Tercera;
                        _jugada.Fecha = item.Fecha;

                        contextserver.Ganadores.Add(_jugada);
                        contextserver.SaveChanges();
                        cont = cont + 1;
                    }
                    if (cont != 0)
                    {
                        mensajeOk("Se migraron " + cont.ToString() + " Loterias");
                        cont = 0;
                    }
                    else
                    {
                        mensajeOk("No se migraron jugadas");
                    }
                }
            }
            catch (Exception)
            {

            }            
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {

            using (CapaDatos.ModeloLocal.Modelo_Local contextlocal = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                var consulta = contextlocal.Cierres.Where(x => x.Fecha.Value.Day == dtpFiltroFecha.Value.Day && x.Fecha.Value.Month == dtpFiltroFecha.Value.Month && x.Fecha.Value.Year == dtpFiltroFecha.Value.Year && x.Estatus == "Activo").ToList();

                Font cabeza = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                Font fuente = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                Font eslogan1 = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);

                int anchohasta = 250;
                int anchodesde = 0;
                int lineado = 20;
                int largo = 50;

                e.Graphics.DrawString("Consorcio de Bancas", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("             SOL20", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("Donde Garantizamos tu Dinero", eslogan1, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString(dtpFiltroFecha.Value.ToString(), fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                e.Graphics.DrawString("---------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                foreach (var item in consulta)
                {
                    e.Graphics.DrawString(item.Unidad + " " + item.Cantidad + "      " + item.Total, fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                }

                e.Graphics.DrawString("---------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                e.Graphics.DrawString("Total RD$: " + this.txtTotal.Text, fuente, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("Faltante RD$: " + this.txtFaltante.Text, fuente, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("Exedente RD$: " + this.txtExedente.Text, fuente, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
            }
        }

        private void ImprimirCopia(object sender, PrintPageEventArgs e)
        {
            DateTime fecha = dtpFiltroFecha.Value;
            using (CapaDatos.ModeloLocal.Modelo_Local contextlocal = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                var consulta = contextlocal.Cierres.Where(x => x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month && x.Fecha.Value.Year == fecha.Year && x.Estatus == "Activo").ToList();

                Font cabeza = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                Font fuente = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                Font eslogan1 = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);

                int anchohasta = 250;
                int anchodesde = 0;
                int lineado = 20;
                int largo = 50;

                e.Graphics.DrawString("Consorcio de Bancas", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("             SOL20", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("Donde Garantizamos tu Dinero", eslogan1, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString(fecha.ToString(), fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                e.Graphics.DrawString("---------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                foreach (var item in consulta)
                {
                    e.Graphics.DrawString(item.Unidad + " " + item.Cantidad + "      " + item.Total, fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                }

                e.Graphics.DrawString("---------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                e.Graphics.DrawString("Total RD$: " + this.txtTotal.Text, fuente, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("Faltante RD$: " + this.txtFaltante.Text, fuente, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("Exedente RD$: " + this.txtExedente.Text, fuente, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
            }
        }


        private void ckbFiltroFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFiltroFecha.Checked)
            {
                ckbFiltroFecha.Checked = true;
                dtpFiltroFecha.Enabled = true;
                Faltante();
            }
            else
            {
                ckbFiltroFecha.Checked = false;
                dtpFiltroFecha.Enabled = false;
            }
        }

        private void dtpFiltroFecha_ValueChanged(object sender, EventArgs e)
        {
            Faltante();
        }


    }
}
