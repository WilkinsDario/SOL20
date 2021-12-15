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
    public partial class FrmGenGanadores : Form
    {
        public string usuario;
        public string banca;
        public string acceso;

        DateTime fecha = DateTime.Now;
        public FrmGenGanadores()
        {
            InitializeComponent();
        }

        private void btnGanadores_Click(object sender, EventArgs e)
        {
            try
            {
                bool contiene = false;
                string banca = cbBanca.Text;
                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB contextlocal = new CapaDatos.Modelo.ModelDB())
                    {
                        #region Limpiar tabla Esta tabla se limpia para evitar duplicidad cada vez que se revisan los ganadores diarios

                        var consulta = contextlocal.Ganadores_Diarios.Where(x => x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month && x.Fecha.Value.Year == dtpFiltro.Value.Year).ToList();

                        if (consulta.Count != 0)
                        {
                            foreach (var item in consulta)
                            {
                                contextlocal.Ganadores_Diarios.Remove(item);
                            }
                            contextlocal.SaveChanges();
                        }

                        #endregion

                        CapaDatos.Modelo.Ganadores_Diarios _ganadores_diarios = new CapaDatos.Modelo.Ganadores_Diarios();


                        var valor = contextlocal.Valor_Premios.FirstOrDefault();

                        var listajugada = contextlocal.Jugada.Where(x => x.Estatus != "Cancelado" && x.Banca == banca && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month && x.Fecha.Value.Year == dtpFiltro.Value.Year).ToList();

                        decimal premio = 0;
                        int cont = 0;

                        foreach (var item in listajugada)
                        {
                            var loteria = contextlocal.Ganadores.Where(x => x.Loteria == item.Loteria && x.Fecha.Value.Day == item.Fecha.Value.Day && x.Fecha.Value.Month == item.Fecha.Value.Month && x.Fecha.Value.Year == item.Fecha.Value.Year).FirstOrDefault();

                            if (loteria != null)
                            {
                                if (item.Tipo_Jugada == "Quiniela")
                                {
                                    if (item.Loteria == loteria.Loteria)
                                    {
                                        if (item.Quiniela == loteria.Primera)
                                        {
                                            premio = premio + Convert.ToDecimal(item.Monto * valor.Primera);
                                        }
                                        if (item.Quiniela == loteria.Segunda)
                                        {
                                            premio = premio + Convert.ToDecimal(item.Monto * valor.Segunda);
                                        }
                                        if (item.Quiniela == loteria.Tercera)
                                        {
                                            premio = premio + Convert.ToDecimal(item.Monto * valor.Tercera);
                                        }
                                    }
                                }
                                if (item.Tipo_Jugada == "Pale")  // Pale1
                                {
                                    bool pale1 = false;
                                    if (item.Loteria == loteria.Loteria)
                                    {
                                        if (item.Quiniela == loteria.Primera || item.Pale == loteria.Primera)
                                        {
                                            if (item.Quiniela == loteria.Segunda || item.Pale == loteria.Segunda)
                                            {
                                                premio = premio + Convert.ToDecimal(item.Monto * valor.Pale_Uno);
                                            }
                                        }
                                        if (!pale1)
                                        {
                                            if (item.Quiniela == loteria.Segunda || item.Quiniela == loteria.Tercera)
                                            {
                                                if (item.Pale == loteria.Segunda || item.Pale == loteria.Tercera)
                                                {
                                                    premio = premio + Convert.ToDecimal(item.Monto * valor.Pale_Dos);
                                                }
                                            }
                                        }
                                    }
                                }
                                if (item.Tipo_Jugada == "Tripleta") // Tripleta
                                {
                                    bool tripleta1 = false;
                                    if (item.Loteria == loteria.Loteria)
                                    {
                                        if (item.Quiniela == loteria.Primera || item.Quiniela == loteria.Segunda || item.Quiniela == loteria.Tercera)
                                        {
                                            if (item.Pale == loteria.Primera || item.Pale == loteria.Segunda || item.Pale == loteria.Tercera)
                                            {
                                                if (item.Tripleta == loteria.Primera || item.Tripleta == loteria.Segunda || item.Tripleta == loteria.Tercera)
                                                {
                                                    premio = premio + Convert.ToDecimal(item.Monto * valor.Tripleta);
                                                    tripleta1 = true;
                                                }
                                            }
                                        }
                                        if (!tripleta1)
                                        {
                                            int con = 0;
                                            if (item.Quiniela == loteria.Primera || item.Quiniela == loteria.Segunda || item.Quiniela == loteria.Tercera)
                                            {
                                                con = con + 1;
                                            }
                                            if (item.Pale == loteria.Primera && item.Pale == loteria.Segunda && item.Pale == loteria.Tercera)
                                            {
                                                con = con + 1;
                                            }
                                            if (item.Tripleta == loteria.Primera && item.Tripleta == loteria.Segunda && item.Tripleta == loteria.Tercera)
                                            {
                                                con = con + 1;
                                            }
                                            if (con == 2)
                                            {
                                                premio = premio + Convert.ToDecimal(item.Monto * valor.Tripleta);
                                            }

                                        }
                                    }
                                }

                                if (premio != 0)
                                {
                                    _ganadores_diarios.Tipo_Jugada = item.Tipo_Jugada;
                                    _ganadores_diarios.Monto = item.Monto;
                                    _ganadores_diarios.Numero_Jugada = item.Numero_Jugada;
                                    _ganadores_diarios.Loteria = item.Loteria;
                                    _ganadores_diarios.Jugada = item.Jugada1;
                                    _ganadores_diarios.Premio = premio;
                                    _ganadores_diarios.Estatus = item.Estatus;
                                    _ganadores_diarios.Fecha = dtpFiltro.Value;

                                    contextlocal.Ganadores_Diarios.Add(_ganadores_diarios);
                                    contextlocal.SaveChanges();

                                    contiene = true;
                                    cont = cont + 1;
                                }

                            }
                            else
                            {
                                if (item.Tipo_Jugada == "Super")
                                {
                                    string l1 = item.Loteria.Substring(0, 2);
                                    string l2 = item.Loteria.Remove(0, 2);

                                    var lot1 = contextlocal.Ganadores.Where(x => x.Loteria == l1).FirstOrDefault();
                                    var lot2 = contextlocal.Ganadores.Where(x => x.Loteria == l2).FirstOrDefault();

                                    if (lot1.Primera == item.Quiniela || lot1.Primera == item.Quiniela)
                                    {
                                        if (lot2.Primera == item.Pale || lot2.Primera == item.Pale)
                                        {
                                            premio = premio + Convert.ToDecimal(item.Monto * valor.Super_Pale);
                                        }
                                    }
                                }

                                if (premio != 0)
                                {
                                    _ganadores_diarios.Tipo_Jugada = item.Tipo_Jugada;
                                    _ganadores_diarios.Monto = item.Monto;
                                    _ganadores_diarios.Numero_Jugada = item.Numero_Jugada;
                                    _ganadores_diarios.Loteria = item.Loteria;
                                    _ganadores_diarios.Jugada = item.Jugada1;
                                    _ganadores_diarios.Premio = premio;
                                    _ganadores_diarios.Estatus = item.Estatus;
                                    _ganadores_diarios.Fecha = dtpFiltro.Value;

                                    contextlocal.Ganadores_Diarios.Add(_ganadores_diarios);
                                    contextlocal.SaveChanges();

                                    contiene = true;
                                    cont = cont + 1;
                                }
                            }
                            premio = 0;
                        }
                        if (contiene)
                        {
                            if (ckbImprimir.Checked)
                            {
                                mensajeOk("Hubo " + cont.ToString() + " ganadores");
                                printTicket = new PrintDocument();
                                PrinterSettings ps = new PrinterSettings();
                                printTicket.PrinterSettings = ps;
                                printTicket.PrintPage += Imprimir;
                                printTicket.Print();
                            }
                            Mostrar();
                        }
                        else
                        {
                            mensajeOk("No hubo Ganadores");
                        }
                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local contextlocal = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        #region Limpiar tabla Esta tabla se limpia para evitar duplicidad cada vez que se revisan los ganadores diarios

                        var consulta = contextlocal.Ganadores_Diarios.Where(x => x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month && x.Fecha.Value.Year == dtpFiltro.Value.Year).ToList();

                        if (consulta.Count != 0)
                        {
                            foreach (var item in consulta)
                            {
                                contextlocal.Ganadores_Diarios.Remove(item);
                            }
                            contextlocal.SaveChanges();
                        }

                        #endregion

                        CapaDatos.ModeloLocal.Ganadores_Diarios _ganadores_diarios = new CapaDatos.ModeloLocal.Ganadores_Diarios();


                        var valor = contextlocal.Valor_Premios.FirstOrDefault();

                        var listajugada = contextlocal.Jugada.Where(x => x.Estatus != "Cancelado" && x.Banca == banca && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month && x.Fecha.Value.Year == dtpFiltro.Value.Year).ToList();

                        decimal premio = 0;
                        int cont = 0;

                        foreach (var item in listajugada)
                        {
                            var loterias = contextlocal.Ganadores.Where(x => x.Loteria == item.Loteria && x.Fecha.Value.Day == item.Fecha.Value.Day && x.Fecha.Value.Month == item.Fecha.Value.Month && x.Fecha.Value.Year == item.Fecha.Value.Year).FirstOrDefault();

                            if (loterias != null)
                            {
                                if (item.Tipo_Jugada == "Quiniela")
                                {
                                    if (item.Loteria == loterias.Loteria)
                                    {
                                        if (item.Quiniela == loterias.Primera)
                                        {
                                            premio = premio + Convert.ToDecimal(item.Monto * valor.Primera);
                                        }
                                        if (item.Quiniela == loterias.Segunda)
                                        {
                                            premio = premio + Convert.ToDecimal(item.Monto * valor.Segunda);
                                        }
                                        if (item.Quiniela == loterias.Tercera)
                                        {
                                            premio = premio + Convert.ToDecimal(item.Monto * valor.Tercera);
                                        }
                                    }
                                }
                                if (item.Tipo_Jugada == "Pale")  // Pale1
                                {
                                    bool pale1 = false;
                                    if (item.Loteria == loterias.Loteria)
                                    {
                                        if (item.Quiniela == loterias.Primera || item.Pale == loterias.Primera)
                                        {
                                            if (item.Quiniela == loterias.Segunda || item.Pale == loterias.Segunda)
                                            {
                                                premio = premio + Convert.ToDecimal(item.Monto * valor.Pale_Uno);
                                            }
                                        }
                                        if (!pale1)
                                        {
                                            if (item.Quiniela == loterias.Segunda || item.Quiniela == loterias.Tercera)
                                            {
                                                if (item.Pale == loterias.Segunda || item.Pale == loterias.Tercera)
                                                {
                                                    premio = premio + Convert.ToDecimal(item.Monto * valor.Pale_Dos);
                                                }
                                            }
                                        }
                                    }
                                }
                                if (item.Tipo_Jugada == "Tripleta") // Tripleta
                                {
                                    bool tripleta1 = false;
                                    if (item.Loteria == loterias.Loteria)
                                    {
                                        if (item.Quiniela == loterias.Primera || item.Quiniela == loterias.Segunda || item.Quiniela == loterias.Tercera)
                                        {
                                            if (item.Pale == loterias.Primera || item.Pale == loterias.Segunda || item.Pale == loterias.Tercera)
                                            {
                                                if (item.Tripleta == loterias.Primera || item.Tripleta == loterias.Segunda || item.Tripleta == loterias.Tercera)
                                                {
                                                    premio = premio + Convert.ToDecimal(item.Monto * valor.Tripleta);
                                                    tripleta1 = true;
                                                }
                                            }
                                        }
                                        if (!tripleta1)
                                        {
                                            int con = 0;
                                            if (item.Quiniela == loterias.Primera || item.Quiniela == loterias.Segunda || item.Quiniela == loterias.Tercera)
                                            {
                                                con = con + 1;
                                            }
                                            if (item.Pale == loterias.Primera && item.Pale == loterias.Segunda && item.Pale == loterias.Tercera)
                                            {
                                                con = con + 1;
                                            }
                                            if (item.Tripleta == loterias.Primera && item.Tripleta == loterias.Segunda && item.Tripleta == loterias.Tercera)
                                            {
                                                con = con + 1;
                                            }
                                            if (con == 2)
                                            {
                                                premio = premio + Convert.ToDecimal(item.Monto * valor.Tripleta);
                                            }

                                        }
                                    }
                                }

                                if (premio != 0)
                                {
                                    _ganadores_diarios.Tipo_Jugada = item.Tipo_Jugada;
                                    _ganadores_diarios.Monto = item.Monto;
                                    _ganadores_diarios.Numero_Jugada = item.Numero_Jugada;
                                    _ganadores_diarios.Loteria = item.Loteria;
                                    _ganadores_diarios.Jugada = item.Jugada1;
                                    _ganadores_diarios.Premio = premio;
                                    _ganadores_diarios.Estatus = item.Estatus;
                                    _ganadores_diarios.Fecha = dtpFiltro.Value;

                                    contextlocal.Ganadores_Diarios.Add(_ganadores_diarios);
                                    contextlocal.SaveChanges();

                                    contiene = true;
                                    cont = cont + 1;
                                }

                            }
                            else
                            {
                                if (item.Tipo_Jugada == "Super")
                                {
                                    string l1 = item.Loteria.Substring(0, 2);
                                    string l2 = item.Loteria.Remove(0, 2);

                                    var lot1 = contextlocal.Ganadores.Where(x => x.Loteria == l1).FirstOrDefault();
                                    var lot2 = contextlocal.Ganadores.Where(x => x.Loteria == l2).FirstOrDefault();

                                    if (lot1.Primera == item.Quiniela || lot1.Primera == item.Quiniela)
                                    {
                                        if (lot2.Primera == item.Pale || lot2.Primera == item.Pale)
                                        {
                                            premio = premio + Convert.ToDecimal(item.Monto * valor.Super_Pale);
                                        }
                                    }
                                }

                                if (premio != 0)
                                {
                                    _ganadores_diarios.Tipo_Jugada = item.Tipo_Jugada;
                                    _ganadores_diarios.Monto = item.Monto;
                                    _ganadores_diarios.Numero_Jugada = item.Numero_Jugada;
                                    _ganadores_diarios.Loteria = item.Loteria;
                                    _ganadores_diarios.Jugada = item.Jugada1;
                                    _ganadores_diarios.Premio = premio;
                                    _ganadores_diarios.Estatus = item.Estatus;
                                    _ganadores_diarios.Fecha = dtpFiltro.Value;

                                    contextlocal.Ganadores_Diarios.Add(_ganadores_diarios);
                                    contextlocal.SaveChanges();

                                    contiene = true;
                                    cont = cont + 1;
                                }
                            }
                            premio = 0;
                        }
                        if (contiene)
                        {
                            if (ckbImprimir.Checked)
                            {
                                mensajeOk("Hubo " + cont.ToString() + " ganadores");
                                printTicket = new PrintDocument();
                                PrinterSettings ps = new PrinterSettings();
                                printTicket.PrinterSettings = ps;
                                printTicket.PrintPage += Imprimir;
                                printTicket.Print();
                            }
                            Mostrar();
                        }
                        else
                        {
                            mensajeOk("No hubo Ganadores");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            if (acceso == "Administrador")
            {
                using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                {
                    var consulta = context.Ganadores_Diarios.Where(x => x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month && x.Fecha.Value.Year == dtpFiltro.Value.Year).ToList();



                    Font cabeza = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                    Font fuente = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                    Font eslogan1 = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);

                    int anchohasta = 700;
                    int anchodesde = 0;
                    int lineado = 20;
                    int largo = 50;
                    decimal suma = 0;

                    e.Graphics.DrawString("                    Consorcio de Bancas", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                    e.Graphics.DrawString("                              SOL20", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                    e.Graphics.DrawString("                             Donde Garantizamos tu Dinero", eslogan1, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                    e.Graphics.DrawString("                               " + this.banca, fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                    e.Graphics.DrawString("                               " + this.usuario, fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                    e.Graphics.DrawString("                    " + fecha.ToString(), fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                    e.Graphics.DrawString("-------------------------------------------------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                    foreach (var item in consulta)
                    {
                        var hora = context.Jugada.Where(x => x.Numero_Jugada == item.Numero_Jugada).FirstOrDefault();
                        e.Graphics.DrawString(item.Numero_Jugada + "     " + item.Premio + "   " + item.Loteria + "     " + item.Tipo_Jugada + "     " + item.Jugada + "     " + hora.Monto + "     " + hora.Estatus + "     " + hora.Fecha.Value.Hour + ":" + hora.Fecha.Value.Minute + ":" + hora.Fecha.Value.Second, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        suma = suma + Convert.ToDecimal(item.Monto);
                    }

                    e.Graphics.DrawString("-------------------------------------------------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                }
            }
            else
            {
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    var consulta = context.Ganadores_Diarios.Where(x => x.Estatus != "Cancelado" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month && x.Fecha.Value.Year == dtpFiltro.Value.Year).ToList();

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
                    e.Graphics.DrawString(this.banca, fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                    e.Graphics.DrawString(this.usuario, fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                    e.Graphics.DrawString(fecha.ToString(), fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                    e.Graphics.DrawString("---------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                    foreach (var item in consulta)
                    {
                        e.Graphics.DrawString(item.Numero_Jugada + "     " + item.Premio, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        suma = suma + Convert.ToDecimal(item.Monto);
                    }

                    e.Graphics.DrawString("---------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
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

        private void ckbImprimir_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbImprimir.Checked)
            {
                ckbImprimir.Checked = true;
            }
            else
            {
                ckbImprimir.Checked = false;
            }
        }

        private void FrmGenGanadores_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 10;
            if (acceso == "Colaborador")
            {
                this.cbBanca.Enabled = false;
                this.cbBanca.Text = "EL BONITO";
            }
            else
            {
                cbBanca.Enabled = true;
                cbBanca.Text = "Seleccione";
            }
        }


        private void Ocultar_Columnas()
        {
            this.dtgListado.Columns[0].Visible = false;
        }

        private void Mostrar()
        {
            try
            {
                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        var consulta = context.Ganadores_Diarios.Where(x => x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month && x.Fecha.Value.Year == dtpFiltro.Value.Year).ToList();
                        this.dtgListado.DataSource = consulta;
                        Ocultar_Columnas();
                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        var consulta = context.Ganadores_Diarios.Where(x => x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month && x.Fecha.Value.Year == dtpFiltro.Value.Year).ToList();
                        this.dtgListado.DataSource = consulta;
                        Ocultar_Columnas();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cbBanca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
