using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using CapaDatos;
using CapaPresentacion;

namespace Presentacion
{
    public partial class FrmJuagada : Form
    {
        string _TipoJuagada = "";
        List<string> Loterias = new List<string>();
        int sub_numero = 0;
        public string usuario;
        public string banca;
        public string acceso;
        DateTime fecha = DateTime.Now;
        public bool copiarjugada = false;

        public FrmJuagada()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }

        private void FrmJuagada_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 10;

            Borrar_Temporal();
            Habilitar(false);
            Habilitar_Loterias();
        }

        public void Limpiar()
        {
            txtQuiniela.Text = string.Empty;
            txtPale.Text = string.Empty;
            txtTripleta.Text = string.Empty;
            txtMonto.Text = string.Empty;
            txtPago.Text = string.Empty;
            txtDevuelta.Text = string.Empty;
            ckbImprimir.Checked = true;
            txtBuscar.Text = string.Empty;
            txtTotalJugada.Text = "0.00";
            txtNumeroJugada.Text = string.Empty;
            Habilitar(false);
            lbQJugada.Items.Clear();
            lbPJugada.Items.Clear();
            lbTJugada.Items.Clear();
            Loterias.Clear();

        }

        private void LimpiarColor(System.Drawing.Color color)
        {
            btnQuiniela.BackColor = color;
            btnPale.BackColor = color;
            btnTripleta.BackColor = color;
            btnGanamas.BackColor = color;
            btnQuinielaPale.BackColor = color;
            btnLaPrimera.BackColor = color;
            btnNewYork.BackColor = color;
            btnFlorida.BackColor = color;
            btnNacional.BackColor = color;
            btnLoteka.BackColor = color;
            btnNewYorkNoche.BackColor = color;
            btnFloridaNoche.BackColor = color;
            btnSuperPale.BackColor = color;
            btnLasuerte.BackColor = color;
            btnReal.BackColor = color;
            btnKingTarde.BackColor = color;
            btnKingNoche.BackColor = color;
            btnAng1.BackColor = color;
            btnAng10.BackColor = color;
            btnAng5.BackColor = color;
            btnAng9.BackColor = color;
        }

        private bool Validar_Monto(string jugada, string tipojugada)
        {
            bool valido = true;
            try
            {
                CapaDatos.ModeloLocal.Limite limite = new CapaDatos.ModeloLocal.Limite();
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    var jugadas = (from x in context.Jugada
                                   where x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month && x.Jugada1 == jugada && x.Tipo_Jugada == tipojugada
                                   select x).ToList();

                    var suma = jugadas.Sum(x => x.Monto);


                    if (tipojugada == "Quiniela")
                    {
                        if (suma > limite.Monto_Quiniela)
                        {
                            mensajeInfo("Jugada no disponible");
                            valido = false;
                        }
                    }
                    else if (tipojugada == "Pale")
                    {
                        if (suma > limite.Monto_Pale)
                        {
                            mensajeInfo("Jugada no disponible");
                            valido = false;
                        }
                    }
                    else if (tipojugada == "Tripleta")
                    {
                        if (suma > limite.Monto_Tripleta)
                        {
                            mensajeInfo("Jugada no disponible");
                            valido = false;
                        }
                    }
                    else if (tipojugada == "Super")
                    {
                        if (suma > limite.Monto_SuperPale)
                        {
                            mensajeInfo("Jugada no disponible");
                            valido = false;
                        }
                    }
                }
                return valido;
            }
            catch (Exception)
            {
                return valido;
            }
        }

        public void Habilitar(bool valor)
        {
            try
            {
                btnQuiniela.Enabled = valor;
                btnPale.Enabled = valor;
                btnTripleta.Enabled = valor;
                txtQuiniela.Enabled = valor;
                txtPale.Enabled = valor;
                txtTripleta.Enabled = valor;
                txtMonto.Enabled = valor;

                gbAutomaticas.Enabled = valor;
            }
            catch (Exception)
            {

            }
        }

        private void Jugar() // habilita los botones para jugar
        {
            Numero_Jugada();
            gbAutomaticas.Enabled = true;
            gbJugada.Enabled = true;
            btnQuiniela.Enabled = true;
            btnPale.Enabled = true;
            btnTripleta.Enabled = true;
            btnSuperPale.Enabled = true;
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(this.txtTotalJugada.Text) != 0)
                {
                    double pago = Convert.ToDouble(this.txtPago.Text);
                    double total = Convert.ToDouble(this.txtTotalJugada.Text);
                    this.txtDevuelta.Text = (pago - total).ToString();
                }
                else
                {
                    mensajeInfo("No hay cobros para realizar");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarColor(System.Drawing.Color.Orange);
            Habilitar(false);
        }

        private void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mensajeInfo(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int jugada = Convert.ToInt32(this.txtNumeroJugada.Text);
            using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                CapaDatos.ModeloLocal.Jugada_Temporal _temporal_Jugada = new CapaDatos.ModeloLocal.Jugada_Temporal();
                var limite = context.Limite.FirstOrDefault();
                string entrelineaQ = "                  ";
                string entrelineaP = "          ";
                string entrelineaT = "     ";
                try
                {
                    if (_TipoJuagada == "Quiniela")
                    {
                        if (Validar() == true && txtQuiniela.Text != string.Empty && txtMonto.Text != string.Empty && Convert.ToInt32(txtMonto.Text) <= limite.Quiniela)
                        {
                            foreach (var item in Loterias)
                            {
                                int quiniela = Convert.ToInt32(txtQuiniela.Text);
                                if (quiniela >= 0 && quiniela < 100)
                                {
                                    _temporal_Jugada.Numero_Jugada = jugada;
                                    _temporal_Jugada.Loteria = item;
                                    _temporal_Jugada.Tipo_Jugada = _TipoJuagada;
                                    _temporal_Jugada.Jugada = item + " " + txtQuiniela.Text + entrelineaQ + "RD$" + txtMonto.Text;

                                    _temporal_Jugada.Monto = Convert.ToDecimal(txtMonto.Text);
                                    _temporal_Jugada.Quiniela = Convert.ToInt32(txtQuiniela.Text);

                                    if (Validar_Monto(txtQuiniela.Text, _TipoJuagada))
                                    {
                                        lbQJugada.Items.Add(item + " " + txtQuiniela.Text + entrelineaQ + "RD$" + txtMonto.Text);


                                        double monto = Convert.ToDouble(txtMonto.Text);
                                        double total = Convert.ToDouble(txtTotalJugada.Text);

                                        txtTotalJugada.Text = (monto + total).ToString();


                                        context.Jugada_Temporal.Add(_temporal_Jugada);
                                        context.SaveChanges();

                                        int cantidad = this.lbQJugada.Items.Count;
                                        this.lbQJugada.SelectedIndex = cantidad - 1;

                                        this.lbQJugada.ClearSelected();

                                    }
                                }
                                else
                                {
                                    mensajeError("Revise la Jugada");
                                }
                            }
                            txtQuiniela.Text = string.Empty;
                            txtMonto.Text = string.Empty;
                        }
                    }
                    else if (_TipoJuagada == "Pale")
                    {
                        if (Validar() == true && txtQuiniela.Text != string.Empty && txtMonto.Text != string.Empty && txtPale.Text != string.Empty && Convert.ToInt32(txtMonto.Text) <= limite.Pale && btnSuperPale.BackColor == System.Drawing.Color.Orange)
                        {


                            int quiniela = Convert.ToInt32(txtQuiniela.Text);
                            int pale = Convert.ToInt32(txtPale.Text);

                            if (txtQuiniela.Text != txtPale.Text && quiniela >= 0 && quiniela < 100 && pale >= 0 && pale < 100)
                            {
                                foreach (var item in Loterias)
                                {
                                    _temporal_Jugada.Loteria = item;
                                    _temporal_Jugada.Tipo_Jugada = _TipoJuagada;
                                    _temporal_Jugada.Monto = Convert.ToDecimal(txtMonto.Text);
                                    _temporal_Jugada.Numero_Jugada = jugada;
                                    _temporal_Jugada.Jugada = item + " " + txtQuiniela.Text + " - " + txtPale.Text + entrelineaP + "RD$" + txtMonto.Text;
                                    _temporal_Jugada.Quiniela = Convert.ToInt32(txtQuiniela.Text);
                                    _temporal_Jugada.Pale = Convert.ToInt32(txtPale.Text);

                                    if (Validar_Monto(txtQuiniela.Text + " - " + txtPale.Text, _TipoJuagada))
                                    {


                                        context.Jugada_Temporal.Add(_temporal_Jugada);
                                        context.SaveChanges();

                                        lbPJugada.Items.Add(item + " " + txtQuiniela.Text + " - " + txtPale.Text + entrelineaP + "RD$" + txtMonto.Text);


                                        double monto = Convert.ToDouble(txtMonto.Text);
                                        double total = Convert.ToDouble(txtTotalJugada.Text);

                                        txtTotalJugada.Text = (monto + total).ToString();

                                        int cantidad = this.lbPJugada.Items.Count;
                                        this.lbPJugada.SelectedIndex = cantidad - 1;

                                        this.lbPJugada.ClearSelected();
                                    }

                                }
                            }
                            else
                            {
                                mensajeError("Revise la jugada");
                            }
                            txtQuiniela.Text = string.Empty;
                            txtPale.Text = string.Empty;
                            txtMonto.Text = string.Empty;
                        }
                    }
                    else if (_TipoJuagada == "Tripleta")
                    {
                        if (Validar() == true && _TipoJuagada == "Tripleta" && txtMonto.Text != string.Empty && txtQuiniela.Text != string.Empty && txtPale.Text != string.Empty && txtTripleta.Text != string.Empty && Convert.ToInt32(txtMonto.Text) <= limite.Tripleta)
                        {
                            if (txtQuiniela.Text != txtPale.Text && txtQuiniela.Text != txtTripleta.Text && txtPale.Text != txtTripleta.Text && txtTripleta.Text != string.Empty)
                            {
                                int quiniela = Convert.ToInt32(txtQuiniela.Text);
                                int pale = Convert.ToInt32(txtPale.Text);
                                int tripleta = Convert.ToInt32(txtTripleta.Text);
                                if (quiniela >= 0 && quiniela < 100 && pale >= 0 && pale < 100 && tripleta >= 0 && tripleta < 100)
                                {
                                    if (Loterias.Count > 0)
                                    {

                                        foreach (var item in Loterias)
                                        {
                                            _temporal_Jugada.Loteria = item;
                                            _temporal_Jugada.Tipo_Jugada = _TipoJuagada;
                                            _temporal_Jugada.Monto = Convert.ToDecimal(txtMonto.Text);
                                            _temporal_Jugada.Numero_Jugada = jugada;
                                            _temporal_Jugada.Jugada = item + " " + txtQuiniela.Text + " - " + txtPale.Text + " - " + txtTripleta.Text + entrelineaT + "RD$" + txtMonto.Text;
                                            _temporal_Jugada.Quiniela = Convert.ToInt32(txtQuiniela.Text);
                                            _temporal_Jugada.Pale = Convert.ToInt32(txtPale.Text);
                                            _temporal_Jugada.Tripleta = Convert.ToInt32(txtTripleta.Text);

                                            if (Validar_Monto(txtQuiniela.Text + " - " + txtPale.Text + " - " + txtTripleta.Text, _TipoJuagada))
                                            {
                                                context.Jugada_Temporal.Add(_temporal_Jugada);
                                                context.SaveChanges();

                                                lbTJugada.Items.Add(item + " " + txtQuiniela.Text + " - " + txtPale.Text + " - " + txtTripleta.Text + entrelineaT + "RD$" + txtMonto.Text);


                                                double monto = Convert.ToDouble(txtMonto.Text);
                                                double total = Convert.ToDouble(txtTotalJugada.Text);

                                                txtTotalJugada.Text = (monto + total).ToString();

                                                int cantidad = this.lbTJugada.Items.Count;
                                                this.lbTJugada.SelectedIndex = cantidad - 1;

                                                this.lbTJugada.ClearSelected();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        mensajeError("Debe seleccionar una Loteria");
                                    }
                                }
                                else
                                {
                                    mensajeError("Revise la Jugada");
                                }
                                txtQuiniela.Text = string.Empty;
                                txtPale.Text = string.Empty;
                                txtMonto.Text = string.Empty;
                                txtTripleta.Text = string.Empty;
                            }
                        }
                    }

                    else if (_TipoJuagada == "Super") //Super palé
                    {
                        if (Validar() == true && txtMonto.Text != string.Empty && txtQuiniela.Text != string.Empty && txtPale.Text != string.Empty && Convert.ToInt32(txtMonto.Text) <= limite.Super_Pale)
                        {
                            if (Loterias.Count == 2)
                            {
                                string l1 = Loterias[0];
                                string l2 = Loterias[1];
                                var t1 = context.Horarios.Where(x => x.Loteria == l1).FirstOrDefault();
                                var t2 = context.Horarios.Where(x => x.Loteria == l2).FirstOrDefault();

                                if (t1.Tanda == t2.Tanda)
                                {
                                    int quiniela = Convert.ToInt32(txtQuiniela.Text);
                                    int pale = Convert.ToInt32(txtPale.Text);

                                    if (txtQuiniela.Text != txtPale.Text && quiniela > 0 && quiniela < 100 && pale > 0 && pale < 100)
                                    {
                                        _temporal_Jugada.Loteria = l1 + "" + l2;
                                        _temporal_Jugada.Tipo_Jugada = _TipoJuagada;
                                        _temporal_Jugada.Monto = Convert.ToDecimal(txtMonto.Text);
                                        _temporal_Jugada.Numero_Jugada = jugada;
                                        _temporal_Jugada.Jugada = l1 + " " + l2 + "      " + txtQuiniela.Text + " - " + txtPale.Text + entrelineaP + "RD$" + txtMonto.Text;
                                        _temporal_Jugada.Quiniela = Convert.ToInt32(txtQuiniela.Text);
                                        _temporal_Jugada.Pale = Convert.ToInt32(txtPale.Text);

                                        if (Validar_Monto(txtQuiniela.Text + " - " + txtPale.Text, _TipoJuagada))
                                        {
                                            context.Jugada_Temporal.Add(_temporal_Jugada);
                                            context.SaveChanges();

                                            lbPJugada.Items.Add(l1 + " " + l2 + "      " + txtQuiniela.Text + " - " + txtPale.Text + entrelineaP + "RD$" + txtMonto.Text);

                                            double monto = Convert.ToDouble(txtMonto.Text);
                                            double total = Convert.ToDouble(txtTotalJugada.Text);

                                            txtTotalJugada.Text = (monto + total).ToString();
                                            txtQuiniela.Text = string.Empty;
                                            txtPale.Text = string.Empty;
                                            txtMonto.Text = string.Empty;

                                            int cantidad = this.lbPJugada.Items.Count;
                                            this.lbPJugada.SelectedIndex = cantidad - 1;

                                            this.lbPJugada.ClearSelected();
                                        }
                                    }
                                    else
                                    {
                                        mensajeError("Revise la jugada");
                                    }
                                }
                                else
                                {
                                    mensajeError("Horario incompatible");
                                }
                            }
                            else
                            {
                                mensajeError("Jugada no válida");
                            }
                        }
                    }
                    txtQuiniela.Text = string.Empty;
                    txtPale.Text = string.Empty;
                    txtTripleta.Text = string.Empty;
                }
                catch (Exception ex)
                {

                }
            }
        }


        private void btnQuinielaA_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loterias.Count > 0)
                {
                    txtQuiniela.Enabled = true;
                    txtPale.Enabled = false;
                    txtPale.Text = string.Empty;
                    txtTripleta.Enabled = false;
                    txtTripleta.Text = string.Empty;
                    txtMonto.Enabled = true;
                    this._TipoJuagada = "Quiniela";

                    txtQuiniela.Text = new Random().Next(1, 99).ToString();
                }
                else
                {
                    mensajeError("Seleccione una lotería");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnPaleA_Click(object sender, EventArgs e)
        {
            if (Loterias.Count > 0)
            {
                txtQuiniela.Enabled = true;
                txtPale.Enabled = true;
                txtTripleta.Enabled = false;
                txtMonto.Enabled = true;

                bool igual = true;
                txtQuiniela.Text = new Random().Next(1, 99).ToString();
                while (igual)
                {
                    txtPale.Text = new Random().Next(1, 99).ToString();
                    if (txtPale.Text != txtQuiniela.Text)
                    {
                        igual = false;
                    }
                }
                this._TipoJuagada = "Pale";
            }
            else
            {
                mensajeError("Seleccione una Lotería");
            }
        }

        private void btnTripletaA_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loterias.Count > 0)
                {
                    txtQuiniela.Enabled = true;
                    txtPale.Enabled = true;
                    txtTripleta.Enabled = true;
                    txtMonto.Enabled = true;

                    bool igual = true;
                    txtQuiniela.Text = new Random().Next(1, 99).ToString();
                    while (igual)
                    {
                        txtPale.Text = new Random().Next(1, 99).ToString();
                        if (txtPale.Text != txtQuiniela.Text)
                        {
                            while (igual)
                            {
                                txtTripleta.Text = new Random().Next(1, 99).ToString();
                                if (txtTripleta.Text != txtPale.Text && txtTripleta.Text != txtQuiniela.Text)
                                {
                                    igual = false;
                                }
                            }
                        }
                    }
                    this._TipoJuagada = "Tripleta";
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void Numero_Jugada()
        {
            if (this.txtNumeroJugada.Text == string.Empty)
            {
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    var numero = (from a in context.Jugada
                                  where a.Fecha.Value.Day == fecha.Day && a.Fecha.Value.Month == fecha.Month && a.Fecha.Value.Year == fecha.Year && a.Banca == this.banca
                                  select a).ToList();

                    string ano = fecha.Year.ToString();

                    ano = ano.Substring(0, ano.Length).Remove(0, 2);

                    if (numero.Count != 0)
                    {
                        var mayor = numero.Max(a => a.Sub_Numero + 1);
                        this.sub_numero = Convert.ToInt32(mayor);
                        this.txtNumeroJugada.Text = fecha.Day.ToString() + ano + mayor.ToString() + fecha.Month.ToString();
                    }
                    else
                    {
                        this.txtNumeroJugada.Text = fecha.Day.ToString() + ano + (1).ToString() + fecha.Month.ToString();
                        sub_numero = 1;
                    }
                }
            }
        }

        private int Copiar_Numero_Jugada()
        {
            string numerojugada;
            using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                var numero = (from a in context.Jugada
                              where a.Fecha.Value.Day == fecha.Day && a.Fecha.Value.Month == fecha.Month && a.Fecha.Value.Year == fecha.Year && a.Banca == this.banca
                              select a).ToList();

                string ano = fecha.Year.ToString();

                ano = ano.Substring(0, ano.Length).Remove(0, 2);

                if (numero.Count != 0)
                {
                    var mayor = numero.Max(a => a.Sub_Numero + 1);
                    this.sub_numero = Convert.ToInt32(mayor);
                    numerojugada = fecha.Day.ToString() + ano + mayor.ToString() + fecha.Month.ToString();
                }
                else
                {
                    numerojugada = fecha.Day.ToString() + ano + (1).ToString() + fecha.Month.ToString();
                    sub_numero = 1;
                }
            }
            return Convert.ToInt32(numerojugada);
        }

        private void btnGanamas_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnGanamas.BackColor == System.Drawing.Color.Orange)
            {
                Loterias.Add("GM");
                this.btnGanamas.BackColor = System.Drawing.Color.Green;

            }
            else if (btnGanamas.BackColor == System.Drawing.Color.Green)
            {
                this.btnGanamas.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("GM");
            }
        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
            {
                Jugar();

                if (btnReal.BackColor == System.Drawing.Color.Green)
                {
                    Loterias.Remove("RL");
                    this.btnReal.BackColor = System.Drawing.Color.Orange;
                }
                else if (btnReal.BackColor == System.Drawing.Color.Orange)
                {
                    Loterias.Add("RL");
                    this.btnReal.BackColor = System.Drawing.Color.Green;
                }
            }
        }

        private void btnQuinielaPale_Click(object sender, EventArgs e)
        {
            using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
            {
                Jugar();

                if (btnQuinielaPale.BackColor == System.Drawing.Color.Green)
                {
                    this.btnQuinielaPale.BackColor = System.Drawing.Color.Orange;
                    Loterias.Remove("QP");
                }
                else if (btnQuinielaPale.BackColor == System.Drawing.Color.Orange)
                {
                    this.btnQuinielaPale.BackColor = System.Drawing.Color.Green;
                    Loterias.Add("QP");
                }
            }
        }

        private void btnNacional_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnNacional.BackColor == System.Drawing.Color.Green)
            {
                this.btnNacional.BackColor = System.Drawing.Color.Orange;
                Loterias.Add("NA");
            }
            else if (btnNacional.BackColor == System.Drawing.Color.Orange)
            {
                this.btnNacional.BackColor = System.Drawing.Color.Green;
                Loterias.Add("NA");
            }
        }

        private void btnLoteka_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnLoteka.BackColor == System.Drawing.Color.Green)
            {
                this.btnLoteka.BackColor = System.Drawing.Color.Orange;
                Loterias.Add("LK");
            }
            else if (btnLoteka.BackColor == System.Drawing.Color.Orange)
            {
                this.btnLoteka.BackColor = System.Drawing.Color.Green;
                Loterias.Add("LK");
            }
        }

        private void btnLaPrimera_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnLaPrimera.BackColor == System.Drawing.Color.Green)
            {
                this.btnLaPrimera.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("LP");
            }
            else if (btnLaPrimera.BackColor == System.Drawing.Color.Orange)
            {
                this.btnLaPrimera.BackColor = System.Drawing.Color.Green;
                Loterias.Add("LP");
            }
        }

        private void btnNewYork_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnNewYork.BackColor == System.Drawing.Color.Green)
            {
                this.btnNewYork.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("NT");
            }
            else if (btnNewYork.BackColor == System.Drawing.Color.Orange)
            {
                this.btnNewYork.BackColor = System.Drawing.Color.Green;
                Loterias.Add("NT");

            }
        }

        private void btnFlorida_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnFlorida.BackColor == System.Drawing.Color.Green)
            {
                this.btnFlorida.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("FT");
            }
            else if (btnFlorida.BackColor == System.Drawing.Color.Orange)
            {
                this.btnFlorida.BackColor = System.Drawing.Color.Green;
                Loterias.Add("FT");
            }
        }

        private void btnSuperPale_Click(object sender, EventArgs e)
        {
            this.txtQuiniela.Focus();
            if (btnSuperPale.BackColor == System.Drawing.Color.Green)
            {
                _TipoJuagada = "";
                this.btnSuperPale.BackColor = System.Drawing.Color.Orange;

                this.txtQuiniela.Enabled = false;
                this.txtPale.Enabled = false;
                this.txtTripleta.Enabled = false;
                txtMonto.Enabled = false;
            }
            else if (btnSuperPale.BackColor == System.Drawing.Color.Orange)
            {
                this.btnSuperPale.BackColor = System.Drawing.Color.Green;
                _TipoJuagada = "Super";
                this.txtQuiniela.Enabled = true;
                this.txtPale.Enabled = true;
                this.txtTripleta.Enabled = false;
                txtMonto.Enabled = true;
                this.btnQuiniela.BackColor = System.Drawing.Color.Orange;
                this.btnPale.BackColor = System.Drawing.Color.Orange;
                this.btnTripleta.BackColor = System.Drawing.Color.Orange;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
            string fecha = Convert.ToString(DateTime.Now.Minute);
            if (fecha.Remove(0, 1) == "5" || fecha.Remove(0, 1) == "0")
            {
                Habilitar_Loterias();
            }
        }

        private void btnQuiniela_Click(object sender, EventArgs e)
        {
            this.txtQuiniela.Focus();
            txtMonto.Enabled = true;
            this._TipoJuagada = "Quiniela";

            if (btnQuiniela.BackColor == System.Drawing.Color.Orange)
            {
                btnQuiniela.BackColor = System.Drawing.Color.Green;
                btnPale.BackColor = System.Drawing.Color.Orange;
                btnTripleta.BackColor = System.Drawing.Color.Orange;

                this.txtQuiniela.Enabled = true;
                this.txtPale.Enabled = false;
                this.txtTripleta.Enabled = false;
                this.txtPale.Text = string.Empty;
                this.txtTripleta.Text = string.Empty;
                this.btnSuperPale.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                btnPale.BackColor = System.Drawing.Color.Orange;
                btnTripleta.BackColor = System.Drawing.Color.Orange;
                this.txtPale.Enabled = false;
                this.txtTripleta.Enabled = false;
            }
        }

        private void btnPale_Click(object sender, EventArgs e)
        {
            txtMonto.Enabled = true;
            this._TipoJuagada = "Pale";
            this.txtQuiniela.Focus();
            if (btnPale.BackColor == System.Drawing.Color.Orange)
            {
                btnQuiniela.BackColor = System.Drawing.Color.Orange;
                btnPale.BackColor = System.Drawing.Color.Green;
                btnTripleta.BackColor = System.Drawing.Color.Orange;

                this.txtQuiniela.Enabled = true;
                this.txtPale.Enabled = true;
                this.txtTripleta.Enabled = false;
                this.txtTripleta.Text = string.Empty;
                this.btnSuperPale.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                btnTripleta.BackColor = System.Drawing.Color.Orange;
                this.txtTripleta.Enabled = false;
            }
        }

        private void btnTripleta_Click(object sender, EventArgs e)
        {
            txtMonto.Enabled = true;
            this._TipoJuagada = "Tripleta";
            this.txtQuiniela.Focus();
            if (btnTripleta.BackColor == System.Drawing.Color.Orange)
            {
                btnQuiniela.BackColor = System.Drawing.Color.Orange;
                btnPale.BackColor = System.Drawing.Color.Orange;
                btnTripleta.BackColor = System.Drawing.Color.Green;

                this.txtQuiniela.Enabled = true;
                this.txtPale.Enabled = true;
                this.txtTripleta.Enabled = true;
                this.btnSuperPale.BackColor = System.Drawing.Color.Orange;
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaDatos.ModeloLocal.Jugada _jugada = new CapaDatos.ModeloLocal.Jugada();

                bool rpt = false;
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    var ticket = Crear_Ticket();
                    _jugada.Fecha = DateTime.Now;
                    _jugada.Sub_Numero = this.sub_numero;
                    _jugada.Total = Convert.ToDecimal(this.txtTotalJugada.Text);
                    _jugada.Numero_Jugada = Convert.ToInt32(this.txtNumeroJugada.Text);
                    _jugada.Numero_Ticket = ticket;
                    _jugada.Estatus = "Activo";
                    _jugada.Banca = this.banca;
                    _jugada.Usuario = this.usuario;


                    context.Jugada.Add(_jugada);

                    var temporal = context.Jugada_Temporal.ToList();

                    foreach (var item in temporal)
                    {
                        if (item.Numero_Jugada == Convert.ToInt32(this.txtNumeroJugada.Text))
                        {
                            _jugada.Loteria = item.Loteria;
                            _jugada.Tipo_Jugada = item.Tipo_Jugada;
                            _jugada.Jugada1 = item.Jugada;
                            _jugada.Monto = item.Monto;
                            _jugada.Quiniela = item.Quiniela;
                            _jugada.Pale = item.Pale;
                            _jugada.Tripleta = item.Tripleta;

                            context.Jugada.Add(_jugada);
                            context.SaveChanges();
                        }
                    }

                    rpt = true;

                    if (rpt)
                    {
                        printTicket = new PrintDocument();
                        PrinterSettings ps = new PrinterSettings();
                        printTicket.PrinterSettings = ps;
                        printTicket.PrintPage += Imprimir;
                        printTicket.Print();

                        Borrar_Temporal();
                        Limpiar();
                    }
                    else
                    {
                        mensajeError("Jugada Incompleta");
                    }
                    this.sub_numero = 0;
                }

            }
            catch (Exception)
            {

            }
            LimpiarColor(System.Drawing.Color.Orange);
            Habilitar_Loterias();
        }

        public bool Validar()
        {
            using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                CapaDatos.Modelo.Limite limite = new CapaDatos.Modelo.Limite();

                bool valido = true;
                decimal? suma = 0;
                if (_TipoJuagada == "Quiniela")
                {
                    string jugada = txtQuiniela.Text;
                    var consulta = context.Jugada.Where(x => x.Jugada1 == jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month).ToList();
                    foreach (var item in consulta)
                    {
                        suma = suma + item.Monto;
                    }
                    if (suma >= limite.Monto_Quiniela)
                    {
                        mensajeInfo("Jugada No disponible");
                        valido = false;
                    }
                }
                else if (_TipoJuagada == "Pale")
                {
                    string jugada = txtQuiniela.Text + "-" + txtPale.Text;
                    var consulta = context.Jugada.Where(x => x.Jugada1 == jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month).ToList();
                    foreach (var item in consulta)
                    {
                        suma = suma + item.Monto;
                    }
                    if (suma >= limite.Monto_Pale)
                    {
                        mensajeInfo("Jugada No disponible");
                        valido = false;
                    }
                }
                else if (_TipoJuagada == "Tripleta")
                {
                    string jugada = txtQuiniela.Text + "-" + txtPale.Text + "-" + txtTripleta.Text;
                    var consulta = context.Jugada.Where(x => x.Jugada1 == jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month).ToList();
                    foreach (var item in consulta)
                    {
                        suma = suma + item.Monto;
                    }
                    if (suma >= limite.Monto_Tripleta)
                    {
                        mensajeInfo("Jugada No disponible");
                        valido = false;
                    }
                }
                else if (_TipoJuagada == "Super")
                {
                    string jugada = txtQuiniela.Text + "-" + txtPale.Text;
                    var consulta = context.Jugada.Where(x => x.Jugada1 == jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month).ToList();
                    foreach (var item in consulta)
                    {
                        suma = suma + item.Monto;
                    }
                    if (suma >= limite.Monto_SuperPale)
                    {
                        mensajeInfo("Jugada No disponible");
                        valido = false;
                    }
                }

                return valido;
            }
        }

        private void txtQuiniela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && txtQuiniela.MaxLength == 3)
            {
                int numero = Convert.ToInt32(txtQuiniela.Text);
                if (numero > 0 && numero <= 100 && this.txtQuiniela.MaxLength == 3)
                {
                    e.Handled = true;
                }

            }
        }

        private void txtPale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                int numero = Convert.ToInt32(txtPale.Text);
                if (numero > 0 && numero <= 100 && this.txtPale.MaxLength == 3)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTripleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                int numero = Convert.ToInt32(txtTripleta.Text);
                if (numero > 0 && numero <= 100 && this.txtTripleta.MaxLength == 3)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Buscar_Jugada()
        {
            int max = 1;
            using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
            {

                var consulta = context.Jugada.Where(x => x.Fecha == DbFunctions.TruncateTime(fecha)).ToList();

                if (consulta != null)
                {
                    foreach (var item in consulta)
                    {
                        if (item.Numero_Jugada > max)
                        {
                            max = Convert.ToInt32(item.Numero_Jugada);
                        }
                    }
                    max = max + 1;
                }

                this.txtNumeroJugada.Text = max.ToString();
            }
        }

        public string Crear_Ticket()
        {
            bool valido = false;
            using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                char l1, l2;
                int n1, n2;
                Int64 paq1, paq2;
                string ticket = "";
                var consulta = context.Jugada.ToList();
                while (!valido)
                {
                    Random rdn = new Random();
                    n1 = rdn.Next(65, 91);
                    n2 = rdn.Next(65, 91);
                    if (n1 != n2)
                    {
                        l1 = Convert.ToChar(n1);
                        l2 = Convert.ToChar(n2);
                        paq1 = rdn.Next(0, 999999);
                        paq2 = rdn.Next(0, 999999);
                        if (paq1 != paq2)
                        {
                            ticket = l1 + paq1.ToString() + l2 + paq2.ToString();


                            if (!context.Jugada.Any(x => x.Numero_Ticket == ticket))
                            {
                                valido = true;
                            }
                        }
                    }
                }
                return ticket;
            }
        }

        private void Borrar_Temporal()
        {
            try
            {
                CapaDatos.ModeloLocal.Jugada_Temporal temporal_Jugada = new CapaDatos.ModeloLocal.Jugada_Temporal();
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    var consulta = context.Jugada_Temporal.ToList();
                    if (consulta != null)
                    {

                        foreach (var item in consulta)
                        {
                            context.Jugada_Temporal.Remove(item);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                try
                {
                    int numero = Convert.ToInt32(txtNumeroJugada.Text);


                    string sub;
                    decimal total = Convert.ToDecimal(txtTotalJugada.Text);

                    if (lbQJugada.SelectedIndex != -1)
                    {
                        sub = lbQJugada.SelectedItem.ToString();

                        var consulta = context.Jugada_Temporal.Where(x => x.Jugada == sub && x.Numero_Jugada == numero).FirstOrDefault();

                        txtTotalJugada.Text = (total - consulta.Monto).ToString();

                        context.Jugada_Temporal.Remove(consulta);
                        context.SaveChanges();

                        lbQJugada.Items.Remove(sub);
                    }
                    if (lbPJugada.SelectedIndex != -1)
                    {
                        sub = lbPJugada.SelectedItem.ToString();

                        var consulta = context.Jugada_Temporal.Where(x => x.Jugada == sub && x.Numero_Jugada == numero).FirstOrDefault();

                        txtTotalJugada.Text = (total - consulta.Monto).ToString();

                        context.Jugada_Temporal.Remove(consulta);
                        context.SaveChanges();
                        lbPJugada.Items.Remove(sub);
                    }
                    if (lbTJugada.SelectedIndex != -1)
                    {
                        sub = lbTJugada.SelectedItem.ToString();

                        var consulta = context.Jugada_Temporal.Where(x => x.Jugada == sub && x.Numero_Jugada == numero).FirstOrDefault();

                        txtTotalJugada.Text = (total - consulta.Monto).ToString();

                        context.Jugada_Temporal.Remove(consulta);
                        context.SaveChanges();
                        lbTJugada.Items.Remove(sub);
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }

        private void txtNumeroTicketCanc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                bool cancelado = false;
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    CapaDatos.ModeloLocal.Jugada jugada = new CapaDatos.ModeloLocal.Jugada();
                    if (txtBuscar.Text != string.Empty)
                    {
                        int numero = Convert.ToInt32(txtBuscar.Text);

                        var consulta = context.Jugada.Where(x => x.Numero_Jugada == numero && x.Estatus == "Activo").ToList();

                        foreach (var item in consulta)
                        {
                            item.Estatus = "Cancelado";
                            context.SaveChanges();
                            mensajeOk("Ticket Cancelado");
                            this.txtBuscar.Text = string.Empty;
                            Limpiar();
                            Habilitar(false);
                            LimpiarColor(System.Drawing.Color.Orange);
                            cancelado = true;
                        }
                        
                    }
                    else
                    {
                        mensajeError("Debe digitar un número de jugada");
                    }
                    if (!cancelado)
                    {
                        mensajeError("Revise el número de jugada");
                    }
                }
                this.txtNumeroJugada.Text = string.Empty;
            }
            catch (Exception)
            {

            }
            Habilitar_Loterias();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    #region
                    if (this.txtBuscar.Text != string.Empty)
                    {
                        int numero = Convert.ToInt32(txtBuscar.Text);

                        var consulta = context.Jugada.Where(x => x.Numero_Jugada == numero && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month).FirstOrDefault();
                        if (numero > 0 && consulta != null)
                        {
                            printTicket = new PrintDocument();
                            PrinterSettings ps = new PrinterSettings();
                            printTicket.PrinterSettings = ps;
                            printTicket.PrintPage += ReImprimir;
                            printTicket.Print();
                        }
                        else
                        {
                            mensajeError("Revise el número de Jugada");
                        }


                    }
                    #endregion
                }
                this.txtNumeroJugada.Text = string.Empty;
                this.txtBuscar.Text = string.Empty;
            }
            catch (Exception)
            {

            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                int numero_jugada = Convert.ToInt32(this.txtNumeroJugada.Text);

                var quiniela = context.Jugada.Where(x => x.Tipo_Jugada == "Quiniela" && x.Numero_Jugada == numero_jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month && x.Fecha.Value.Year == fecha.Year).ToList();
                var pale = context.Jugada.Where(x => x.Tipo_Jugada == "Pale" && x.Numero_Jugada == numero_jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month && x.Fecha.Value.Year == fecha.Year).ToList();
                var tripleta = context.Jugada.Where(x => x.Tipo_Jugada == "Tripleta" && x.Numero_Jugada == numero_jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month && x.Fecha.Value.Year == fecha.Year).ToList();
                var super = context.Jugada.Where(x => x.Tipo_Jugada == "Super" && x.Numero_Jugada == numero_jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month && x.Fecha.Value.Year == fecha.Year).ToList();

                var ticket = context.Jugada.Where(x => x.Numero_Jugada == numero_jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month && x.Fecha.Value.Year == fecha.Year).FirstOrDefault();

                Font cabeza = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                Font fuente = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                Font eslogan1 = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);

                int anchohasta = 250;
                int anchodesde = 0;
                int lineado = 20;
                int largo = 50;
                decimal suma = 0;

                e.Graphics.DrawString("Consorcio de Bancas", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("            SOL20", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("Donde Garantizamos tu Dinero", eslogan1, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString(DateTime.Now.ToString(), fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString(ticket.Numero_Ticket, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("NO. Jugada: " + this.txtNumeroJugada.Text, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                if (quiniela.Count != 0)
                {
                    e.Graphics.DrawString("----------Quiniela--------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                    foreach (var item in quiniela)
                    {
                        e.Graphics.DrawString(item.Jugada1, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        suma = suma + Convert.ToDecimal(item.Monto);
                    }
                }
                if (pale.Count != 0)
                {
                    e.Graphics.DrawString("----------Palé-------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                    foreach (var item in pale)
                    {
                        e.Graphics.DrawString(item.Jugada1, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        suma = suma + Convert.ToDecimal(item.Monto);
                    }
                }
                if (tripleta.Count != 0)
                {
                    e.Graphics.DrawString("----------Tripleta---------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                    foreach (var item in tripleta)
                    {
                        e.Graphics.DrawString(item.Jugada1, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        suma = suma + Convert.ToDecimal(item.Monto);
                    }
                }
                if (super.Count != 0)
                {
                    e.Graphics.DrawString("----------Super-----------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                    foreach (var item in super)
                    {
                        e.Graphics.DrawString(item.Jugada1, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        suma = suma + Convert.ToDecimal(item.Monto);
                    }
                }

                e.Graphics.DrawString("-----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("Total RD$: " + suma.ToString(), cabeza, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString(" REVISE SU JUGADA", cabeza, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
            }
        }

        private void ReImprimir(object sender, PrintPageEventArgs e)
        {
            using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                if (this.txtBuscar.Text != string.Empty)
                {
                    int numero_jugada = Convert.ToInt32(this.txtBuscar.Text);

                    var consulta = context.Jugada.Where(x => x.Numero_Jugada == numero_jugada).FirstOrDefault();

                    if (consulta != null)
                    {
                        var quiniela = context.Jugada.Where(x => x.Tipo_Jugada == "Quiniela" && x.Numero_Jugada == numero_jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month && x.Fecha.Value.Year == fecha.Year).ToList();
                        var pale = context.Jugada.Where(x => x.Tipo_Jugada == "Pale" && x.Numero_Jugada == numero_jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month && x.Fecha.Value.Year == fecha.Year).ToList();
                        var tripleta = context.Jugada.Where(x => x.Tipo_Jugada == "Tripleta" && x.Numero_Jugada == numero_jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month && x.Fecha.Value.Year == fecha.Year).ToList();
                        var super = context.Jugada.Where(x => x.Tipo_Jugada == "Super" && x.Numero_Jugada == numero_jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month && x.Fecha.Value.Year == fecha.Year).ToList();

                        var ticket = context.Jugada.Where(x => x.Numero_Jugada == numero_jugada && x.Fecha.Value.Day == fecha.Day && x.Fecha.Value.Month == fecha.Month && x.Fecha.Value.Year == fecha.Year).FirstOrDefault();

                        Font cabeza = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                        Font fuente = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                        Font eslogan1 = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);

                        int anchohasta = 250;
                        int anchodesde = 0;
                        int lineado = 20;
                        int largo = 50;
                        decimal suma = 0;

                        e.Graphics.DrawString("Consorcio de Bancas", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("            SOL20", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("Donde Garantizamos tu Dinero", eslogan1, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString(DateTime.Now.ToString(), fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString(ticket.Numero_Ticket, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("NO. Jugada: " + this.txtNumeroJugada.Text, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                        if (quiniela.Count != 0)
                        {
                            e.Graphics.DrawString("----------Quiniela--------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                            foreach (var item in quiniela)
                            {
                                e.Graphics.DrawString(item.Jugada1, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                                suma = suma + Convert.ToDecimal(item.Monto);
                            }
                        }
                        if (pale.Count != 0)
                        {
                            e.Graphics.DrawString("----------Palé-------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                            foreach (var item in pale)
                            {
                                e.Graphics.DrawString(item.Jugada1, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                                suma = suma + Convert.ToDecimal(item.Monto);
                            }
                        }
                        if (tripleta.Count != 0)
                        {
                            e.Graphics.DrawString("----------Tripleta---------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                            foreach (var item in tripleta)
                            {
                                e.Graphics.DrawString(item.Jugada1, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                                suma = suma + Convert.ToDecimal(item.Monto);
                            }
                        }
                        if (super.Count != 0)
                        {
                            e.Graphics.DrawString("----------Super-----------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                            foreach (var item in super)
                            {
                                e.Graphics.DrawString(item.Jugada1, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                                suma = suma + Convert.ToDecimal(item.Monto);
                            }
                        }

                        e.Graphics.DrawString("-----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("Total RD$: " + suma.ToString(), cabeza, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString(" REVISE SU JUGADA", cabeza, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
                        e.Graphics.DrawString("    *REIMPRESO*", cabeza, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
                    }
                    else
                    {
                        mensajeError("Revise el número de jugada");
                    }
                }
                else
                {
                    mensajeError("Debe digitar un número de jugada");
                }
            }
        }

        private void Habilitar_Loterias()
        {
            try
            {
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    var consulta = context.Horarios.ToList();

                    if (fecha.DayOfWeek != 0)
                    {
                        foreach (var item in consulta)
                        {
                            if (item.Loteria == "GM")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnGanamas.Enabled = false;
                                        btnGanamas.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnGanamas.Enabled = false;
                                            btnGanamas.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnGanamas.Enabled = false;
                                    btnGanamas.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "LS")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnLasuerte.Enabled = false;
                                        btnLasuerte.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnLasuerte.Enabled = false;
                                            btnLasuerte.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnLasuerte.Enabled = false;
                                    btnLasuerte.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "RL")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnReal.Enabled = false;
                                        btnReal.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnReal.Enabled = false;
                                            btnReal.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnReal.Enabled = false;
                                    btnReal.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "QP")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnQuinielaPale.Enabled = false;
                                        btnQuinielaPale.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnQuinielaPale.Enabled = false;
                                            btnQuinielaPale.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnQuinielaPale.Enabled = false;
                                    btnQuinielaPale.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "LP")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnLaPrimera.Enabled = false;
                                        btnLaPrimera.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnLaPrimera.Enabled = false;
                                            btnLaPrimera.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnLaPrimera.Enabled = false;
                                    btnLaPrimera.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "NT")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnNewYork.Enabled = false;
                                        btnNewYork.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnNewYork.Enabled = false;
                                            btnNewYork.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnNewYork.Enabled = false;
                                    btnNewYork.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "NN")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnNewYorkNoche.Enabled = false;
                                        btnNewYorkNoche.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnNewYorkNoche.Enabled = false;
                                            btnNewYorkNoche.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnNewYorkNoche.Enabled = false;
                                    btnNewYorkNoche.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "NA")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnNacional.Enabled = false;
                                        btnNacional.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnNacional.Enabled = false;
                                            btnNacional.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnNacional.Enabled = false;
                                    btnNacional.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "LK")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnLoteka.Enabled = false;
                                        btnLoteka.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnLoteka.Enabled = false;
                                            btnLoteka.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnLoteka.Enabled = false;
                                    btnLoteka.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "FT")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnFlorida.Enabled = false;
                                        btnFlorida.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnFlorida.Enabled = false;
                                            btnFlorida.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnFlorida.Enabled = false;
                                    btnFlorida.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "FN")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnFloridaNoche.Enabled = false;
                                        btnFloridaNoche.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnFloridaNoche.Enabled = false;
                                            btnFloridaNoche.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnFloridaNoche.Enabled = false;
                                    btnFloridaNoche.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "KT")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnKingTarde.Enabled = false;
                                        btnKingTarde.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnKingTarde.Enabled = false;
                                            btnKingTarde.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnKingTarde.Enabled = false;
                                    btnKingTarde.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "KN")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnKingNoche.Enabled = false;
                                        btnKingNoche.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnKingNoche.Enabled = false;
                                            btnKingNoche.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnKingNoche.Enabled = false;
                                    btnKingNoche.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "AD")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnAng10.Enabled = false;
                                        btnAng10.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnAng10.Enabled = false;
                                            btnAng10.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnAng10.Enabled = false;
                                    btnAng10.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "AU")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnAng1.Enabled = false;
                                        btnAng1.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnAng1.Enabled = false;
                                            btnAng1.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnAng1.Enabled = false;
                                    btnAng1.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "AC")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnAng5.Enabled = false;
                                        btnAng5.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnAng5.Enabled = false;
                                            btnAng5.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnAng5.Enabled = false;
                                    btnAng5.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "AN")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnAng9.Enabled = false;
                                        btnAng9.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnAng9.Enabled = false;
                                            btnAng9.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnAng9.Enabled = false;
                                    btnAng9.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in consulta)
                        {
                            if (item.Loteria == "GM")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnGanamas.Enabled = false;
                                        btnGanamas.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnGanamas.Enabled = false;
                                            btnGanamas.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnGanamas.Enabled = false;
                                    btnGanamas.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "LS")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnLasuerte.Enabled = false;
                                        btnLasuerte.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnLasuerte.Enabled = false;
                                            btnLasuerte.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnLasuerte.Enabled = false;
                                    btnLasuerte.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "RL")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnReal.Enabled = false;
                                        btnReal.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnReal.Enabled = false;
                                            btnReal.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnReal.Enabled = false;
                                    btnReal.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "QP")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (fecha.Hour > 15 || DateTime.Now.Hour > item.Hora || DateTime.Now.Hour > item.Hora)
                                    {
                                        btnQuinielaPale.Enabled = false;
                                        btnQuinielaPale.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (fecha.Hour == 17)
                                    {
                                        if (fecha.Minute >= 45)
                                        {
                                            btnQuinielaPale.Enabled = false;
                                            btnQuinielaPale.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnQuinielaPale.Enabled = false;
                                    btnQuinielaPale.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "LP")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnLaPrimera.Enabled = false;
                                        btnLaPrimera.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnLaPrimera.Enabled = false;
                                            btnLaPrimera.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnLaPrimera.Enabled = false;
                                    btnLaPrimera.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "NT")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnNewYork.Enabled = false;
                                        btnNewYork.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnNewYork.Enabled = false;
                                            btnNewYork.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnNewYork.Enabled = false;
                                    btnNewYork.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "NN")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (fecha.Hour > 17)
                                    {
                                        btnNewYorkNoche.Enabled = false;
                                        btnNewYorkNoche.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (fecha.Hour == 17)
                                    {
                                        if (fecha.Minute >= 45)
                                        {
                                            btnNewYorkNoche.Enabled = false;
                                            btnNewYorkNoche.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnNewYorkNoche.Enabled = false;
                                    btnNewYorkNoche.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "NA")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (fecha.Hour > 17)
                                    {
                                        btnNacional.Enabled = false;
                                        btnNacional.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (fecha.Hour == 17)
                                    {
                                        if (fecha.Minute >= 55)
                                        {
                                            btnNacional.Enabled = false;
                                            btnNacional.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnNacional.Enabled = false;
                                    btnNacional.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "LK")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (fecha.Hour > 17)
                                    {
                                        btnLoteka.Enabled = false;
                                        btnLoteka.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (fecha.Hour == 17)
                                    {
                                        if (fecha.Minute >= 45)
                                        {
                                            btnLoteka.Enabled = false;
                                            btnLoteka.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnLoteka.Enabled = false;
                                    btnLoteka.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "FT")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnFlorida.Enabled = false;
                                        btnFlorida.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnFlorida.Enabled = false;
                                            btnFlorida.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnFlorida.Enabled = false;
                                    btnFlorida.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "FN")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (fecha.Hour > 17 || DateTime.Now.Hour > item.Hora)
                                    {
                                        btnFloridaNoche.Enabled = false;
                                        btnFloridaNoche.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (fecha.Hour == 17)
                                    {
                                        if (fecha.Minute >= 45)
                                        {
                                            btnFloridaNoche.Enabled = false;
                                            btnFloridaNoche.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnFloridaNoche.Enabled = false;
                                    btnFloridaNoche.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "KT")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnKingTarde.Enabled = false;
                                        btnKingTarde.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnKingTarde.Enabled = false;
                                            btnKingTarde.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnKingTarde.Enabled = false;
                                    btnKingTarde.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "KN")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > 17)
                                    {
                                        btnKingNoche.Enabled = false;
                                        btnKingNoche.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == 17)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnKingNoche.Enabled = false;
                                            btnKingNoche.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnKingNoche.Enabled = false;
                                    btnKingNoche.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "AD")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnAng10.Enabled = false;
                                        btnAng10.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnAng10.Enabled = false;
                                            btnAng10.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnAng10.Enabled = false;
                                    btnAng10.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "AU")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnAng1.Enabled = false;
                                        btnAng1.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnAng1.Enabled = false;
                                            btnAng1.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnAng1.Enabled = false;
                                    btnAng1.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "AC")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (DateTime.Now.Hour > item.Hora)
                                    {
                                        btnAng5.Enabled = false;
                                        btnAng5.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (DateTime.Now.Hour == item.Hora)
                                    {
                                        if (DateTime.Now.Minute >= item.Minutos)
                                        {
                                            btnAng5.Enabled = false;
                                            btnAng5.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnAng5.Enabled = false;
                                    btnAng5.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                            if (item.Loteria == "AN")
                            {
                                if (item.Estatus == "Activo")
                                {
                                    if (fecha.Hour > 17)
                                    {
                                        btnAng9.Enabled = false;
                                        btnAng9.BackColor = System.Drawing.Color.Gray;
                                    }
                                    else if (fecha.Hour == 17)
                                    {
                                        if (fecha.Minute >= 45)
                                        {
                                            btnAng9.Enabled = false;
                                            btnAng9.BackColor = System.Drawing.Color.Gray;
                                        }
                                    }
                                }
                                else
                                {
                                    btnAng9.Enabled = false;
                                    btnAng9.BackColor = System.Drawing.Color.Gray;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnNacional_Click_1(object sender, EventArgs e)
        {
            Jugar();

            if (btnNacional.BackColor == System.Drawing.Color.Orange)
            {
                Loterias.Add("NA");
                this.btnNacional.BackColor = System.Drawing.Color.Green;
            }
            else if (btnNacional.BackColor == System.Drawing.Color.Green)
            {
                this.btnNacional.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("NA");
            }

        }

        private void btnLoteka_Click_1(object sender, EventArgs e)
        {
            Jugar();

            if (btnLoteka.BackColor == System.Drawing.Color.Orange)
            {
                Loterias.Add("LK");
                this.btnLoteka.BackColor = System.Drawing.Color.Green;
            }
            else if (btnLoteka.BackColor == System.Drawing.Color.Green)
            {
                this.btnLoteka.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("LK");
            }
        }

        private void btnNewYorkNoche_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnNewYorkNoche.BackColor == System.Drawing.Color.Green)
            {
                this.btnNewYorkNoche.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("NN");
            }
            else if (btnNewYorkNoche.BackColor == System.Drawing.Color.Orange)
            {
                this.btnNewYorkNoche.BackColor = System.Drawing.Color.Green;
                Loterias.Add("NN");
            }
        }

        private void btnFloridaNoche_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnFloridaNoche.BackColor == System.Drawing.Color.Green)
            {
                this.btnFloridaNoche.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("FN");
            }
            else if (btnFloridaNoche.BackColor == System.Drawing.Color.Orange)
            {
                this.btnFloridaNoche.BackColor = System.Drawing.Color.Green;
                Loterias.Add("FN");
            }
        }

        private void btnMostrarValores_Click(object sender, EventArgs e)
        {
            FrmMostrar_Valores frmMostrar_Valores = new FrmMostrar_Valores();
            frmMostrar_Valores.acceso = acceso;
            frmMostrar_Valores.banca = banca;
            frmMostrar_Valores.usuario = usuario;
            frmMostrar_Valores.ShowDialog();
        }

        private void btnLasuerte_Click(object sender, EventArgs e)
        {
            using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                Jugar();

                if (btnLasuerte.BackColor == System.Drawing.Color.Orange)
                {
                    Loterias.Add("LS");
                    this.btnLasuerte.BackColor = System.Drawing.Color.Green;

                }
                else if (btnLasuerte.BackColor == System.Drawing.Color.Green)
                {
                    this.btnLasuerte.BackColor = System.Drawing.Color.Orange;
                    Loterias.Remove("LS");
                }
            }
        }

        private void txtQuiniela_TextChanged(object sender, EventArgs e)
        {
            if (txtQuiniela.TextLength == 2 && txtPale.Enabled == true)
            {
                txtPale.Focus();
            }
            else if (txtQuiniela.TextLength == 2 && txtPale.Enabled == false)
            {
                txtMonto.Focus();
            }
        }

        private void txtPale_TextChanged(object sender, EventArgs e)
        {
            if (txtPale.TextLength == 2 && txtTripleta.Enabled == true)
            {
                txtTripleta.Focus();
            }
            else if (txtPale.TextLength == 2 && txtTripleta.Enabled == false)
            {
                txtMonto.Focus();
            }
        }

        private void txtTripleta_TextChanged(object sender, EventArgs e)
        {
            if (txtTripleta.TextLength == 2 && txtMonto.Enabled == true)
            {
                txtMonto.Focus();
            }
        }

        private void btnKingTarde_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnKingTarde.BackColor == System.Drawing.Color.Orange)
            {
                Loterias.Add("KT");
                this.btnKingTarde.BackColor = System.Drawing.Color.Green;

            }
            else if (btnKingTarde.BackColor == System.Drawing.Color.Green)
            {
                this.btnKingTarde.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("KT");
            }
        }

        private void btnKingNoche_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnKingNoche.BackColor == System.Drawing.Color.Orange)
            {
                Loterias.Add("KN");
                this.btnKingNoche.BackColor = System.Drawing.Color.Green;

            }
            else if (btnKingNoche.BackColor == System.Drawing.Color.Green)
            {
                this.btnKingNoche.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("KN");
            }
        }

        private void btnAng10_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnAng10.BackColor == System.Drawing.Color.Orange)
            {
                Loterias.Add("AD");
                this.btnAng10.BackColor = System.Drawing.Color.Green;

            }
            else if (btnAng10.BackColor == System.Drawing.Color.Green)
            {
                this.btnAng10.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("AD");
            }
        }

        private void btnAng1_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnKingNoche.BackColor == System.Drawing.Color.Orange)
            {
                Loterias.Add("AU");
                this.btnAng1.BackColor = System.Drawing.Color.Green;

            }
            else if (btnAng1.BackColor == System.Drawing.Color.Green)
            {
                this.btnAng1.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("AU");
            }
        }

        private void btnAng5_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnAng5.BackColor == System.Drawing.Color.Orange)
            {
                Loterias.Add("AC");
                this.btnAng5.BackColor = System.Drawing.Color.Green;

            }
            else if (btnAng5.BackColor == System.Drawing.Color.Green)
            {
                this.btnAng5.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("AC");
            }
        }

        private void btnAng9_Click(object sender, EventArgs e)
        {
            Jugar();

            if (btnAng9.BackColor == System.Drawing.Color.Orange)
            {
                Loterias.Add("AN");
                this.btnAng9.BackColor = System.Drawing.Color.Green;

            }
            else if (btnAng9.BackColor == System.Drawing.Color.Green)
            {
                this.btnAng9.BackColor = System.Drawing.Color.Orange;
                Loterias.Remove("AN");
            }
        }

        private void btnMostrarJugadas_Click(object sender, EventArgs e)
        {
            FrmMostrar_Jugadas frmMostrar_Jugadas = new FrmMostrar_Jugadas();
            frmMostrar_Jugadas.Show();
        }

        private void Copiar_Jugada(object sender, PrintPageEventArgs e)
        {
            using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                int numero_jugada = Convert.ToInt32(this.txtBuscar.Text);

                var quiniela = context.Jugada.Where(x => x.Tipo_Jugada == "Quiniela" && x.Numero_Jugada == numero_jugada).ToList();
                var pale = context.Jugada.Where(x => x.Tipo_Jugada == "Pale" && x.Numero_Jugada == numero_jugada).ToList();
                var tripleta = context.Jugada.Where(x => x.Tipo_Jugada == "Tripleta" && x.Numero_Jugada == numero_jugada).ToList();
                var super = context.Jugada.Where(x => x.Tipo_Jugada == "Super" && x.Numero_Jugada == numero_jugada).ToList();


                Font cabeza = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                Font fuente = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                Font eslogan1 = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);

                int anchohasta = 250;
                int anchodesde = 0;
                int lineado = 20;
                int largo = 50;
                decimal suma = 0;

                e.Graphics.DrawString("Consorcio de Bancas", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("            SOL20", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("Donde Garantizamos tu Dinero", eslogan1, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString(DateTime.Now.ToString(), fuente, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString(Crear_Ticket(), cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("NO. Jugada: " + Copiar_Numero_Jugada(), cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                if (quiniela.Count != 0)
                {
                    e.Graphics.DrawString("----------Quiniela--------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                    foreach (var item in quiniela)
                    {
                        e.Graphics.DrawString(item.Jugada1, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        suma = suma + Convert.ToDecimal(item.Monto);
                    }
                }
                if (pale.Count != 0)
                {
                    e.Graphics.DrawString("----------Palé-------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                    foreach (var item in pale)
                    {
                        e.Graphics.DrawString(item.Jugada1, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        suma = suma + Convert.ToDecimal(item.Monto);
                    }
                }
                if (tripleta.Count != 0)
                {
                    e.Graphics.DrawString("----------Tripleta---------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                    foreach (var item in tripleta)
                    {
                        e.Graphics.DrawString(item.Jugada1, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        suma = suma + Convert.ToDecimal(item.Monto);
                    }
                }
                if (super.Count != 0)
                {
                    e.Graphics.DrawString("----------Super-----------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));

                    foreach (var item in super)
                    {
                        e.Graphics.DrawString(item.Jugada1, cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                        suma = suma + Convert.ToDecimal(item.Monto);
                    }
                }

                e.Graphics.DrawString("-----------------------------------", cabeza, Brushes.Black, new RectangleF(anchodesde, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString("Total RD$: " + suma.ToString(), cabeza, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
                e.Graphics.DrawString(" REVISE SU JUGADA", cabeza, Brushes.Black, new RectangleF(0, lineado += 20, anchohasta, largo));
            }
            this.txtNumeroJugada.Text = string.Empty;
        }

        private void btnCopiarJugada_Click(object sender, EventArgs e)
        {
            try
            {
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    if (this.txtBuscar.Text != string.Empty)
                    {
                        int numero = Convert.ToInt32(txtBuscar.Text);

                        var consulta = context.Jugada.Where(x => x.Numero_Jugada == numero).ToList();

                        if (consulta.Count != 0)
                        {
                            this.copiarjugada = true;

                            Numero_Jugada();

                            decimal suma = 0;

                            foreach (var item in consulta)
                            {
                                if (item.Tipo_Jugada == "Quiniela")
                                {
                                    this.lbQJugada.Items.Add(item.Jugada1);
                                }
                                if (item.Tipo_Jugada == "Pale" || item.Tipo_Jugada == "Super")
                                {
                                    this.lbPJugada.Items.Add(item.Jugada1);
                                }
                                if (item.Tipo_Jugada == "Tripleta")
                                {
                                    this.lbTJugada.Items.Add(item.Jugada1);
                                }
                                suma = Convert.ToDecimal(suma + item.Monto);
                            }
                            txtTotalJugada.Text = suma.ToString();

                            #region Pasar a temporal

                            CapaDatos.ModeloLocal.Jugada_Temporal _temporal = new CapaDatos.ModeloLocal.Jugada_Temporal();

                            foreach (var item in consulta)
                            {
                                _temporal.Loteria = item.Loteria;
                                _temporal.Quiniela = item.Quiniela;
                                _temporal.Pale = item.Pale;
                                _temporal.Tripleta = item.Tripleta;
                                _temporal.Monto = item.Monto;
                                _temporal.Numero_Jugada = Convert.ToInt32(this.txtNumeroJugada.Text);
                                _temporal.Tipo_Jugada = item.Tipo_Jugada;
                                _temporal.Jugada = item.Jugada1;

                                context.Jugada_Temporal.Add(_temporal);
                                context.SaveChanges();
                            }

                            #endregion

                        }
                        else
                        {
                            mensajeError("Verifique el número de jugada");
                        }
                    }
                    else
                    {
                        mensajeError("Digite un número de jugada");
                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void lbQJugada_Click(object sender, EventArgs e)
        {
            using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                if (this.lbQJugada.SelectedIndex != -1)
                {
                    if (this.copiarjugada)
                    {
                        string jugada = this.lbQJugada.SelectedItem.ToString();
                        //var consulta = context.
                    }
                    else
                    {
                        if (this.txtBuscar.Text != string.Empty)
                        {
                            int numerojugada = Convert.ToInt32(this.txtBuscar.Text);

                            var consulta = context.Jugada.Where(x => x.Numero_Jugada == numerojugada);
                        }

                    }
                }
            }

        }
    }
}
