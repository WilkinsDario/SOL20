using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace Presentacion
{
    public partial class FrmGanadores : Form
    {
        public string usuario;
        public string banca;
        public string acceso;
        DateTime fecha = DateTime.Now;

        public FrmGanadores()
        {
            InitializeComponent();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        CapaDatos.Modelo.Ganadores _param = new CapaDatos.Modelo.Ganadores();
                        if (ckbGanaMas.Checked)
                        {
                            _param.Loteria = "GM";
                            _param.Primera = Convert.ToInt32(txtGMPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtGMSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtGMTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");

                        }
                        if (ckbLaSuerte.Checked)
                        {
                            _param.Loteria = "LS";
                            _param.Primera = Convert.ToInt32(txtLSPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtLSSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtLSTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");

                        }
                        if (ckbReal.Checked)
                        {
                            _param.Loteria = "RL";
                            _param.Primera = Convert.ToInt32(txtRLPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtRLSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtRLTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbQuinielaPale.Checked)
                        {
                            _param.Loteria = "QP";
                            _param.Primera = Convert.ToInt32(txtQPPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtQPSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtQPTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbLaPrimera.Checked)
                        {
                            _param.Loteria = "LP";
                            _param.Primera = Convert.ToInt32(txtLPPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtLPSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtLPTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbNewYork.Checked)
                        {
                            _param.Loteria = "NT";
                            _param.Primera = Convert.ToInt32(txtNYPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtNYSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtNYTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbNewYorkNoche.Checked)
                        {
                            _param.Loteria = "NN";
                            _param.Primera = Convert.ToInt32(txtNYNPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtNYNSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtNYNTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbFlorida.Checked)
                        {
                            _param.Loteria = "FT";
                            _param.Primera = Convert.ToInt32(txtFLPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtFLSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtFLTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbFloridaNoche.Checked)
                        {
                            _param.Loteria = "FN";
                            _param.Primera = Convert.ToInt32(txtFLNPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtFLNSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtFLNTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbNacional.Checked)
                        {
                            _param.Loteria = "NA";
                            _param.Primera = Convert.ToInt32(txtNAPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtNASegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtNATercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbLoteca.Checked)
                        {
                            _param.Loteria = "LK";
                            _param.Primera = Convert.ToInt32(txtLKPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtLKSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtLKTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbKingTarde.Checked)
                        {
                            _param.Loteria = "KT";
                            _param.Primera = Convert.ToInt32(txtKTPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtKTSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtKTTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbKingNoche.Checked)
                        {
                            _param.Loteria = "KN";
                            _param.Primera = Convert.ToInt32(txtKTPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtKTSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtKTTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbAng10.Checked)
                        {
                            _param.Loteria = "AD";
                            _param.Primera = Convert.ToInt32(txtADPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtADSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtADTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbAng1.Checked)
                        {
                            _param.Loteria = "AU";
                            _param.Primera = Convert.ToInt32(txtAUPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtAUSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtAUTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbAng5.Checked)
                        {
                            _param.Loteria = "AC";
                            _param.Primera = Convert.ToInt32(txtACPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtACSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtACTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                        if (ckbAng9.Checked)
                        {
                            _param.Loteria = "AN";
                            _param.Primera = Convert.ToInt32(txtANPrimera.Text);
                            _param.Segunda = Convert.ToInt32(txtANSegunda.Text);
                            _param.Tercera = Convert.ToInt32(txtANTercera.Text);
                            _param.Fecha = dtpFiltro.Value;

                            context.Ganadores.Add(_param);
                            context.SaveChanges();
                            mensajeOk("Números Agredagos");
                        }
                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        CapaDatos.ModeloLocal.Ganadores _param = new CapaDatos.ModeloLocal.Ganadores();
                        if (ckbGanaMas.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "GM" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "GM";
                                _param.Primera = Convert.ToInt32(txtGMPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtGMSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtGMTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }

                        }
                        if (ckbLaSuerte.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "LS" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "LS";
                                _param.Primera = Convert.ToInt32(txtLSPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtLSSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtLSTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbReal.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "RL" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "RL";
                                _param.Primera = Convert.ToInt32(txtRLPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtRLSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtRLTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbQuinielaPale.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "QP" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "QP";
                                _param.Primera = Convert.ToInt32(txtQPPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtQPSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtQPTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbLaPrimera.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "LP" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "LP";
                                _param.Primera = Convert.ToInt32(txtLPPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtLPSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtLPTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbNewYork.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "NT" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "NT";
                                _param.Primera = Convert.ToInt32(txtNYPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtNYSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtNYTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbNewYorkNoche.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "NN" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "NN";
                                _param.Primera = Convert.ToInt32(txtNYNPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtNYNSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtNYNTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbFlorida.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "FT" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "FT";
                                _param.Primera = Convert.ToInt32(txtFLPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtFLSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtFLTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbFloridaNoche.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "FN" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "FN";
                                _param.Primera = Convert.ToInt32(txtFLNPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtFLNSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtFLNTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbNacional.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "NA" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "NA";
                                _param.Primera = Convert.ToInt32(txtNAPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtNASegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtNATercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbLoteca.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "LK" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "LK";
                                _param.Primera = Convert.ToInt32(txtLKPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtLKSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtLKTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbKingTarde.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "KT" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "KT";
                                _param.Primera = Convert.ToInt32(txtKTPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtKTSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtKTTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbKingNoche.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "KN" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "KN";
                                _param.Primera = Convert.ToInt32(txtKTPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtKTSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtKTTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbAng10.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "AD" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "AD";
                                _param.Primera = Convert.ToInt32(txtADPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtADSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtADTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbAng1.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "AU" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "AU";
                                _param.Primera = Convert.ToInt32(txtAUPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtAUSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtAUTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbAng5.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "AC" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "AC";
                                _param.Primera = Convert.ToInt32(txtACPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtACSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtACTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                        if (ckbAng9.Checked)
                        {
                            var consulta = context.Ganadores.Where(x => x.Loteria == "AN" && x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).FirstOrDefault();
                            if (consulta == null)
                            {
                                _param.Loteria = "AN";
                                _param.Primera = Convert.ToInt32(txtANPrimera.Text);
                                _param.Segunda = Convert.ToInt32(txtANSegunda.Text);
                                _param.Tercera = Convert.ToInt32(txtANTercera.Text);
                                _param.Fecha = dtpFiltro.Value;

                                context.Ganadores.Add(_param);
                                context.SaveChanges();
                                mensajeOk("Números Agredagos");
                            }
                        }
                    }
                }


                ckbLaPrimera.Checked = false;
                ckbGanaMas.Checked = false;
                ckbFlorida.Checked = false;
                ckbReal.Checked = false;
                ckbNacional.Checked = false;
                ckbQuinielaPale.Checked = false;
                ckbLoteca.Checked = false;
                ckbFloridaNoche.Checked = false;
                ckbNewYorkNoche.Checked = false;
                ckbNewYork.Checked = false;
                ckbLaSuerte.Checked = false;
                ckbKingTarde.Checked = false;
                ckbKingNoche.Checked = false;
                ckbAng10.Checked = false;
                ckbAng1.Checked = false;
                ckbAng5.Checked = false;
                ckbAng9.Checked = false;
                Mostrar_Ganadores();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void ckbGanaMas_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGanaMas.Checked)
            {
                ckbGanaMas.Checked = true;
                txtGMPrimera.Enabled = true;
                txtGMSegunda.Enabled = true;
                txtGMTercera.Enabled = true;
                this.txtGMPrimera.Focus();
            }
            else
            {
                ckbGanaMas.Checked = false;
                txtGMPrimera.Enabled = false;
                txtGMSegunda.Enabled = false;
                txtGMTercera.Enabled = false;
            }
        }

        private void ckbReal_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbReal.Checked)
            {
                ckbReal.Checked = true;
                txtRLPrimera.Enabled = true;
                txtRLSegunda.Enabled = true;
                txtRLTercera.Enabled = true;
                txtRLPrimera.Focus();
            }
            else
            {
                ckbReal.Checked = false;
                txtRLPrimera.Enabled = false;
                txtRLSegunda.Enabled = false;
                txtRLTercera.Enabled = false;
            }
        }

        private void ckbQuinielaPale_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbQuinielaPale.Checked)
            {
                ckbQuinielaPale.Checked = true;
                txtQPPrimera.Enabled = true;
                txtQPSegunda.Enabled = true;
                txtQPTercera.Enabled = true;
                txtQPPrimera.Focus();
            }
            else
            {
                ckbQuinielaPale.Checked = false;
                txtQPPrimera.Enabled = false;
                txtQPSegunda.Enabled = false;
                txtQPTercera.Enabled = false;
            }
        }

        private void ckbLaPrimera_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLaPrimera.Checked)
            {
                ckbLaPrimera.Checked = true;
                txtLPPrimera.Enabled = true;
                txtLPSegunda.Enabled = true;
                txtLPTercera.Enabled = true;
                txtLPPrimera.Focus();
            }
            else
            {
                ckbLaPrimera.Checked = false;
                txtLPPrimera.Enabled = false;
                txtLPSegunda.Enabled = false;
                txtLPTercera.Enabled = false;
            }
        }

        private void ckbNewYork_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNewYork.Checked)
            {
                ckbNewYork.Checked = true;
                txtNYPrimera.Enabled = true;
                txtNYSegunda.Enabled = true;
                txtNYTercera.Enabled = true;
                txtNYPrimera.Focus();
            }
            else
            {
                ckbNewYork.Checked = false;
                txtNYPrimera.Enabled = false;
                txtNYSegunda.Enabled = false;
                txtNYTercera.Enabled = false;
            }
        }

        private void ckbFlorida_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFlorida.Checked)
            {
                ckbFlorida.Checked = true;
                txtFLPrimera.Enabled = true;
                txtFLSegunda.Enabled = true;
                txtFLTercera.Enabled = true;
                txtFLPrimera.Focus();
            }
            else
            {
                ckbFlorida.Checked = false;
                txtFLPrimera.Enabled = false;
                txtFLSegunda.Enabled = false;
                txtFLTercera.Enabled = false;
            }
        }

        private void ckbNacional_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNacional.Checked)
            {
                ckbNacional.Checked = true;
                txtNAPrimera.Enabled = true;
                txtNASegunda.Enabled = true;
                txtNATercera.Enabled = true;
                txtNAPrimera.Focus();
            }
            else
            {
                ckbNacional.Checked = false;
                txtNAPrimera.Enabled = false;
                txtNASegunda.Enabled = false;
                txtNATercera.Enabled = false;
            }
        }

        private void ckbLoteca_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLoteca.Checked)
            {
                ckbLoteca.Checked = true;
                txtLKPrimera.Enabled = true;
                txtLKSegunda.Enabled = true;
                txtLKTercera.Enabled = true;
                txtLKPrimera.Focus();
            }
            else
            {
                ckbLoteca.Checked = false;
                txtLKPrimera.Enabled = false;
                txtLKSegunda.Enabled = false;
                txtLKTercera.Enabled = false;
            }
        }

        private void Habilitar(bool valor)
        {
            txtGMPrimera.Enabled = valor;
            txtGMSegunda.Enabled = valor;
            txtGMTercera.Enabled = valor;

            txtRLPrimera.Enabled = valor;
            txtRLSegunda.Enabled = valor;
            txtRLTercera.Enabled = valor;

            txtQPPrimera.Enabled = valor;
            txtQPSegunda.Enabled = valor;
            txtQPTercera.Enabled = valor;

            txtLPPrimera.Enabled = valor;
            txtLPSegunda.Enabled = valor;
            txtLPTercera.Enabled = valor;

            txtNYPrimera.Enabled = valor;
            txtNYSegunda.Enabled = valor;
            txtNYTercera.Enabled = valor;

            txtFLPrimera.Enabled = valor;
            txtFLSegunda.Enabled = valor;
            txtFLTercera.Enabled = valor;

            txtNAPrimera.Enabled = valor;
            txtNASegunda.Enabled = valor;
            txtNATercera.Enabled = valor;

            txtNAPrimera.Enabled = valor;
            txtNASegunda.Enabled = valor;
            txtNATercera.Enabled = valor;

            txtLKPrimera.Enabled = valor;
            txtLKSegunda.Enabled = valor;
            txtLKTercera.Enabled = valor;

            txtNYNPrimera.Enabled = valor;
            txtNYNSegunda.Enabled = valor;
            txtNYNTercera.Enabled = valor;

            txtFLNPrimera.Enabled = valor;
            txtFLNSegunda.Enabled = valor;
            txtFLNTercera.Enabled = valor;

            txtLSPrimera.Enabled = valor;
            txtLSSegunda.Enabled = valor;
            txtLSTercera.Enabled = valor;

            txtKTPrimera.Enabled = valor;
            txtKTSegunda.Enabled = valor;
            txtKTTercera.Enabled = valor;

            txtKNPrimera.Enabled = valor;
            txtKNSegunda.Enabled = valor;
            txtKNTercera.Enabled = valor;

            txtADPrimera.Enabled = valor;
            txtADSegunda.Enabled = valor;
            txtADTercera.Enabled = valor;

            txtAUPrimera.Enabled = valor;
            txtAUSegunda.Enabled = valor;
            txtAUTercera.Enabled = valor;

            txtACPrimera.Enabled = valor;
            txtACSegunda.Enabled = valor;
            txtACTercera.Enabled = valor;

            txtANPrimera.Enabled = valor;
            txtANSegunda.Enabled = valor;
            txtANTercera.Enabled = valor;
        }

        private void FrmGanadores_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 10;
            Habilitar(false);
            Mostrar_Ganadores();
        }

        private void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Mostrar_Ganadores()
        {
            try
            {
                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        var consulta = context.Ganadores.Where(x => x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).ToList();
                        if (consulta != null)
                        {
                            foreach (var item in consulta)
                            {
                                if (item.Loteria == "GM")
                                {
                                    txtGMPrimera.Text = item.Primera.ToString();
                                    txtGMSegunda.Text = item.Segunda.ToString();
                                    txtGMTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "LS")
                                {
                                    txtLSPrimera.Text = item.Primera.ToString();
                                    txtLSSegunda.Text = item.Segunda.ToString();
                                    txtLSTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "RL")
                                {
                                    txtRLPrimera.Text = item.Primera.ToString();
                                    txtRLSegunda.Text = item.Segunda.ToString();
                                    txtRLTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "QP")
                                {
                                    txtQPPrimera.Text = item.Primera.ToString();
                                    txtQPSegunda.Text = item.Segunda.ToString();
                                    txtQPTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "LP")
                                {
                                    txtLPPrimera.Text = item.Primera.ToString();
                                    txtLPSegunda.Text = item.Segunda.ToString();
                                    txtLPTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "NT")
                                {
                                    txtNYPrimera.Text = item.Primera.ToString();
                                    txtNYSegunda.Text = item.Segunda.ToString();
                                    txtNYTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "NN")
                                {
                                    txtNYNPrimera.Text = item.Primera.ToString();
                                    txtNYNSegunda.Text = item.Segunda.ToString();
                                    txtNYNTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "FT")
                                {
                                    txtFLPrimera.Text = item.Primera.ToString();
                                    txtFLSegunda.Text = item.Segunda.ToString();
                                    txtFLTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "FN")
                                {
                                    txtFLNPrimera.Text = item.Primera.ToString();
                                    txtFLNSegunda.Text = item.Segunda.ToString();
                                    txtFLNTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "NA")
                                {
                                    txtNAPrimera.Text = item.Primera.ToString();
                                    txtNASegunda.Text = item.Segunda.ToString();
                                    txtNATercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "LK")
                                {
                                    txtLKPrimera.Text = item.Primera.ToString();
                                    txtLKSegunda.Text = item.Segunda.ToString();
                                    txtLKTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "KT")
                                {
                                    txtKTPrimera.Text = item.Primera.ToString();
                                    txtKTSegunda.Text = item.Segunda.ToString();
                                    txtKTTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "KN")
                                {
                                    txtKNPrimera.Text = item.Primera.ToString();
                                    txtKNSegunda.Text = item.Segunda.ToString();
                                    txtKNTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "AD")
                                {
                                    txtADPrimera.Text = item.Primera.ToString();
                                    txtADSegunda.Text = item.Segunda.ToString();
                                    txtADTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "AU")
                                {
                                    txtAUPrimera.Text = item.Primera.ToString();
                                    txtAUSegunda.Text = item.Segunda.ToString();
                                    txtAUTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "AC")
                                {
                                    txtACPrimera.Text = item.Primera.ToString();
                                    txtACSegunda.Text = item.Segunda.ToString();
                                    txtACTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "AN")
                                {
                                    txtANPrimera.Text = item.Primera.ToString();
                                    txtANSegunda.Text = item.Segunda.ToString();
                                    txtANTercera.Text = item.Tercera.ToString();
                                }
                            }
                        }
                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        var consulta = context.Ganadores.Where(x => x.Fecha.Value.Day == dtpFiltro.Value.Day && x.Fecha.Value.Month == dtpFiltro.Value.Month &&
                                                                    x.Fecha.Value.Year == dtpFiltro.Value.Year).ToList();
                        if (consulta.Count != 0)
                        {
                            foreach (var item in consulta)
                            {
                                if (item.Loteria == "GM")
                                {
                                    txtGMPrimera.Text = item.Primera.ToString();
                                    txtGMSegunda.Text = item.Segunda.ToString();
                                    txtGMTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "LS")
                                {
                                    txtLSPrimera.Text = item.Primera.ToString();
                                    txtLSSegunda.Text = item.Segunda.ToString();
                                    txtLSTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "RL")
                                {
                                    txtRLPrimera.Text = item.Primera.ToString();
                                    txtRLSegunda.Text = item.Segunda.ToString();
                                    txtRLTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "QP")
                                {
                                    txtQPPrimera.Text = item.Primera.ToString();
                                    txtQPSegunda.Text = item.Segunda.ToString();
                                    txtQPTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "LP")
                                {
                                    txtLPPrimera.Text = item.Primera.ToString();
                                    txtLPSegunda.Text = item.Segunda.ToString();
                                    txtLPTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "NT")
                                {
                                    txtNYPrimera.Text = item.Primera.ToString();
                                    txtNYSegunda.Text = item.Segunda.ToString();
                                    txtNYTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "NN")
                                {
                                    txtNYNPrimera.Text = item.Primera.ToString();
                                    txtNYNSegunda.Text = item.Segunda.ToString();
                                    txtNYNTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "FT")
                                {
                                    txtFLPrimera.Text = item.Primera.ToString();
                                    txtFLSegunda.Text = item.Segunda.ToString();
                                    txtFLTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "FN")
                                {
                                    txtFLNPrimera.Text = item.Primera.ToString();
                                    txtFLNSegunda.Text = item.Segunda.ToString();
                                    txtFLNTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "NA")
                                {
                                    txtNAPrimera.Text = item.Primera.ToString();
                                    txtNASegunda.Text = item.Segunda.ToString();
                                    txtNATercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "LK")
                                {
                                    txtLKPrimera.Text = item.Primera.ToString();
                                    txtLKSegunda.Text = item.Segunda.ToString();
                                    txtLKTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "KT")
                                {
                                    txtKTPrimera.Text = item.Primera.ToString();
                                    txtKTSegunda.Text = item.Segunda.ToString();
                                    txtKTTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "KN")
                                {
                                    txtKNPrimera.Text = item.Primera.ToString();
                                    txtKNSegunda.Text = item.Segunda.ToString();
                                    txtKNTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "AD")
                                {
                                    txtADPrimera.Text = item.Primera.ToString();
                                    txtADSegunda.Text = item.Segunda.ToString();
                                    txtADTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "AU")
                                {
                                    txtAUPrimera.Text = item.Primera.ToString();
                                    txtAUSegunda.Text = item.Segunda.ToString();
                                    txtAUTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "AC")
                                {
                                    txtACPrimera.Text = item.Primera.ToString();
                                    txtACSegunda.Text = item.Segunda.ToString();
                                    txtACTercera.Text = item.Tercera.ToString();
                                }
                                if (item.Loteria == "AN")
                                {
                                    txtANPrimera.Text = item.Primera.ToString();
                                    txtANSegunda.Text = item.Segunda.ToString();
                                    txtANTercera.Text = item.Tercera.ToString();
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

        private void Limpiar_Ganadores()
        {
            try
            {
                txtGMPrimera.Text = string.Empty;
                txtGMSegunda.Text = string.Empty;
                txtGMTercera.Text = string.Empty;

                txtLSPrimera.Text = string.Empty;
                txtLSSegunda.Text = string.Empty;
                txtLSTercera.Text = string.Empty;

                txtRLPrimera.Text = string.Empty;
                txtRLSegunda.Text = string.Empty;
                txtRLTercera.Text = string.Empty;

                txtQPPrimera.Text = string.Empty;
                txtQPSegunda.Text = string.Empty;
                txtQPTercera.Text = string.Empty;

                txtLPPrimera.Text = string.Empty;
                txtLPSegunda.Text = string.Empty;
                txtLPTercera.Text = string.Empty;

                txtNYPrimera.Text = string.Empty;
                txtNYSegunda.Text = string.Empty;
                txtNYTercera.Text = string.Empty;

                txtNYNPrimera.Text = string.Empty;
                txtNYNSegunda.Text = string.Empty;
                txtNYNTercera.Text = string.Empty;

                txtFLPrimera.Text = string.Empty;
                txtFLSegunda.Text = string.Empty;
                txtFLTercera.Text = string.Empty;

                txtFLNPrimera.Text = string.Empty;
                txtFLNSegunda.Text = string.Empty;
                txtFLNTercera.Text = string.Empty;

                txtNAPrimera.Text = string.Empty;
                txtNASegunda.Text = string.Empty;
                txtNATercera.Text = string.Empty;

                txtLKPrimera.Text = string.Empty;
                txtLKSegunda.Text = string.Empty;
                txtLKTercera.Text = string.Empty;

                txtKTPrimera.Text = string.Empty;
                txtKTSegunda.Text = string.Empty;
                txtKTTercera.Text = string.Empty;

                txtKNPrimera.Text = string.Empty;
                txtKNSegunda.Text = string.Empty;
                txtKNTercera.Text = string.Empty;

                txtADPrimera.Text = string.Empty;
                txtADSegunda.Text = string.Empty;
                txtADTercera.Text = string.Empty;

                txtAUPrimera.Text = string.Empty;
                txtAUSegunda.Text = string.Empty;
                txtAUTercera.Text = string.Empty;

                txtACPrimera.Text = string.Empty;
                txtACSegunda.Text = string.Empty;
                txtACTercera.Text = string.Empty;

                txtANPrimera.Text = string.Empty;
                txtANSegunda.Text = string.Empty;
                txtANTercera.Text = string.Empty;

            }
            catch (Exception)
            {

            }
        }



        private void ckbNewYorkNoche_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNewYorkNoche.Checked)
            {
                ckbNewYorkNoche.Checked = true;
                txtNYNPrimera.Enabled = true;
                txtNYNSegunda.Enabled = true;
                txtNYNTercera.Enabled = true;
                txtNYNPrimera.Focus();
            }
            else
            {
                ckbNewYorkNoche.Checked = false;
                txtNYNPrimera.Enabled = false;
                txtNYNSegunda.Enabled = false;
                txtNYNTercera.Enabled = false;
            }
        }

        private void ckbFloridaNoche_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFloridaNoche.Checked)
            {
                ckbFloridaNoche.Checked = true;
                txtFLNPrimera.Enabled = true;
                txtFLNSegunda.Enabled = true;
                txtFLNTercera.Enabled = true;
                txtFLNPrimera.Focus();
            }
            else
            {
                ckbFloridaNoche.Checked = false;
                txtFLNPrimera.Enabled = false;
                txtFLNSegunda.Enabled = false;
                txtFLNTercera.Enabled = false;
            }
        }

        private void ckbLaSuerte_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLaSuerte.Checked)
            {
                ckbLaSuerte.Checked = true;
                txtLSPrimera.Enabled = true;
                txtLSSegunda.Enabled = true;
                txtLSTercera.Enabled = true;
                txtLSPrimera.Focus();
            }
            else
            {
                ckbLaSuerte.Checked = false;
                txtLSPrimera.Enabled = false;
                txtLSSegunda.Enabled = false;
                txtLSTercera.Enabled = false;
            }
        }

        private void txtGMPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtGMPrimera.TextLength == 2)
            {
                txtGMSegunda.Focus();
            }
        }

        private void txtGMSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtGMSegunda.TextLength == 2)
            {
                txtGMTercera.Focus();
            }
        }

        private void txtRLPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtRLPrimera.TextLength == 2)
            {
                txtRLSegunda.Focus();
            }
        }

        private void txtRLSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtRLSegunda.TextLength == 2)
            {
                txtRLTercera.Focus();
            }
        }

        private void txtQPPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtQPPrimera.TextLength == 2)
            {
                txtQPSegunda.Focus();
            }
        }

        private void txtQPSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtQPSegunda.TextLength == 2)
            {
                txtQPTercera.Focus();
            }
        }

        private void txtLPPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtLPPrimera.TextLength == 2)
            {
                txtLPSegunda.Focus();
            }
        }

        private void txtLPSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtLPSegunda.TextLength == 2)
            {
                txtLPTercera.Focus();
            }
        }

        private void txtNYPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtNYPrimera.TextLength == 2)
            {
                txtNYSegunda.Focus();
            }
        }

        private void txtNYSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtNYSegunda.TextLength == 2)
            {
                txtNYTercera.Focus();
            }
        }

        private void txtFLPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtFLPrimera.TextLength == 2)
            {
                txtFLSegunda.Focus();
            }
        }

        private void txtFLSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtFLSegunda.TextLength == 2)
            {
                txtFLTercera.Focus();
            }
        }

        private void txtNAPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtNAPrimera.TextLength == 2)
            {
                txtNASegunda.Focus();
            }
        }

        private void txtNASegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtNASegunda.TextLength == 2)
            {
                txtNATercera.Focus();
            }
        }

        private void txtLKPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtLKPrimera.TextLength == 2)
            {
                txtLKSegunda.Focus();
            }
        }

        private void txtLKSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtLKSegunda.TextLength == 2)
            {
                txtLKTercera.Focus();
            }
        }

        private void txtNYNPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtNYNPrimera.TextLength == 2)
            {
                txtNYNSegunda.Focus();
            }
        }

        private void txtNYNSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtNYNSegunda.TextLength == 2)
            {
                txtNYNTercera.Focus();
            }
        }

        private void txtFLNPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtFLNPrimera.TextLength == 2)
            {
                txtFLNSegunda.Focus();
            }
        }

        private void txtFLNSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtFLNSegunda.TextLength == 2)
            {
                txtFLNTercera.Focus();
            }
        }

        private void txtLSPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtLSPrimera.TextLength == 2)
            {
                txtLSSegunda.Focus();
            }
        }

        private void txtLSSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtLSSegunda.TextLength == 2)
            {
                txtLSTercera.Focus();
            }
        }

        private void dtpFiltro_ValueChanged(object sender, EventArgs e)
        {
            Limpiar_Ganadores();
            Mostrar_Ganadores();
        }

        private void ckbKingTarde_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKingTarde.Checked)
            {
                ckbKingTarde.Checked = true;
                txtKTPrimera.Enabled = true;
                txtKTSegunda.Enabled = true;
                txtKTTercera.Enabled = true;
                txtKTPrimera.Focus();
            }
            else
            {
                ckbKingTarde.Checked = false;
                txtKTPrimera.Enabled = false;
                txtKTSegunda.Enabled = false;
                txtKTTercera.Enabled = false;
            }
        }

        private void txtKTPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtKTPrimera.TextLength == 2)
            {
                txtKTSegunda.Focus();
            }
        }

        private void txtKNPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtKNPrimera.TextLength == 2)
            {
                txtKNSegunda.Focus();
            }
        }

        private void txtADPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtADPrimera.TextLength == 2)
            {
                txtADSegunda.Focus();
            }
        }

        private void txtAUPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtAUPrimera.TextLength == 2)
            {
                txtAUSegunda.Focus();
            }
        }

        private void txtACPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtACPrimera.TextLength == 2)
            {
                txtACSegunda.Focus();
            }
        }

        private void txtANPrimera_TextChanged(object sender, EventArgs e)
        {
            if (txtANPrimera.TextLength == 2)
            {
                txtANSegunda.Focus();
            }
        }

        private void txtKTSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtKTSegunda.TextLength == 2)
            {
                txtKTTercera.Focus();
            }
        }

        private void txtKNSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtKNSegunda.TextLength == 2)
            {
                txtKNTercera.Focus();
            }
        }

        private void txtADSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtADSegunda.TextLength == 2)
            {
                txtADTercera.Focus();
            }
        }

        private void txtAUSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtAUSegunda.TextLength == 2)
            {
                txtAUTercera.Focus();
            }
        }

        private void txtACSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtACSegunda.TextLength == 2)
            {
                txtACTercera.Focus();
            }
        }

        private void txtANSegunda_TextChanged(object sender, EventArgs e)
        {
            if (txtANSegunda.TextLength == 2)
            {
                txtANTercera.Focus();
            }
        }

        private void txtGMTercera_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbKingNoche_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKingNoche.Checked)
            {
                ckbKingNoche.Checked = true;
                txtKNPrimera.Enabled = true;
                txtKNSegunda.Enabled = true;
                txtKNTercera.Enabled = true;
                this.txtKNPrimera.Focus();
            }
            else
            {
                ckbKingNoche.Checked = false;
                txtKNPrimera.Enabled = false;
                txtKNSegunda.Enabled = false;
                txtKNTercera.Enabled = false;
            }
        }

        private void ckbAng10_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAng10.Checked)
            {
                ckbAng10.Checked = true;
                txtADPrimera.Enabled = true;
                txtADSegunda.Enabled = true;
                txtADTercera.Enabled = true;
                this.txtADPrimera.Focus();
            }
            else
            {
                ckbAng10.Checked = false;
                txtADPrimera.Enabled = false;
                txtADSegunda.Enabled = false;
                txtADTercera.Enabled = false;
            }
        }

        private void ckbAng1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAng1.Checked)
            {
                ckbAng1.Checked = true;
                txtAUPrimera.Enabled = true;
                txtAUSegunda.Enabled = true;
                txtAUTercera.Enabled = true;
                this.txtAUPrimera.Focus();
            }
            else
            {
                ckbAng1.Checked = false;
                txtAUPrimera.Enabled = false;
                txtAUSegunda.Enabled = false;
                txtAUTercera.Enabled = false;
            }
        }

        private void ckbAng5_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAng5.Checked)
            {
                ckbAng5.Checked = true;
                txtACPrimera.Enabled = true;
                txtACSegunda.Enabled = true;
                txtACTercera.Enabled = true;
                this.txtACPrimera.Focus();
            }
            else
            {
                ckbAng5.Checked = false;
                txtACPrimera.Enabled = false;
                txtACSegunda.Enabled = false;
                txtACTercera.Enabled = false;
            }
        }

        private void ckbAng9_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAng9.Checked)
            {
                ckbAng9.Checked = true;
                txtANPrimera.Enabled = true;
                txtANSegunda.Enabled = true;
                txtANTercera.Enabled = true;
                this.txtANPrimera.Focus();
            }
            else
            {
                ckbAng9.Checked = false;
                txtANPrimera.Enabled = false;
                txtANSegunda.Enabled = false;
                txtANTercera.Enabled = false;
            }
        }
    }
}
