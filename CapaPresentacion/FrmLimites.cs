using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLimites : Form
    {
        public string usuario;
        public string banca;
        public string acceso;
        public FrmLimites()
        {
            InitializeComponent();
        }

        private void btnActualizarLimite_Click(object sender, EventArgs e)
        {
            try
            {
                if (acceso == "Administrador")
                {
                    CapaDatos.Modelo.Limite _limite = new CapaDatos.Modelo.Limite();
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        var limite = context.Limite.FirstOrDefault();
                        if (limite == null)
                        {
                            _limite.Quiniela = Convert.ToInt32(txtQuiniela.Text);
                            _limite.Pale = Convert.ToInt32(txtPale.Text);
                            _limite.Tripleta = Convert.ToInt32(txtTripleta.Text);
                            _limite.Super_Pale = Convert.ToInt32(txtSuperPale.Text);
                            _limite.Monto_Quiniela = Convert.ToDecimal(this.txtMQuiniela.Text);
                            _limite.Monto_Pale = Convert.ToDecimal(this.txtMPale.Text);
                            _limite.Monto_Tripleta = Convert.ToDecimal(this.txtTripleta.Text);
                            _limite.Monto_SuperPale = Convert.ToDecimal(this.txtMSuperPale.Text);
                            _limite.Fecha = DateTime.Now;

                            context.Limite.Add(_limite);
                            context.SaveChanges();
                            mensajeOk("Limite agregado server");
                        }
                        else
                        {
                            limite.Quiniela = Convert.ToInt32(txtQuiniela.Text);
                            limite.Pale = Convert.ToInt32(txtPale.Text);
                            limite.Tripleta = Convert.ToInt32(txtTripleta.Text);
                            limite.Super_Pale = Convert.ToInt32(txtSuperPale.Text);
                            limite.Monto_Quiniela = Convert.ToDecimal(txtMQuiniela.Text);
                            limite.Monto_Pale = Convert.ToDecimal(txtMPale.Text);
                            limite.Monto_Tripleta = Convert.ToDecimal(txtMTripleta.Text);
                            limite.Monto_SuperPale = Convert.ToDecimal(txtMSuperPale.Text);
                            limite.Fecha = DateTime.Now;

                            context.SaveChanges();
                            mensajeOk("Limite actualizado server");
                            LlenarLimite();
                        }

                    }
                    ActualizarLimiteLocal();
                }
                else
                {
                    ActualizarLimiteLocal();
                }

            }
            catch (Exception)
            {

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

        private void ActualizarLimiteLocal()
        {
            try
            {
                CapaDatos.ModeloLocal.Limite _limite = new CapaDatos.ModeloLocal.Limite();
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    var limite = context.Limite.FirstOrDefault();
                    if (limite == null)
                    {
                        _limite.Quiniela = Convert.ToInt32(txtQuiniela.Text);
                        _limite.Pale = Convert.ToInt32(txtPale.Text);
                        _limite.Tripleta = Convert.ToInt32(txtTripleta.Text);
                        _limite.Super_Pale = Convert.ToInt32(txtSuperPale.Text);
                        _limite.Monto_Quiniela = Convert.ToDecimal(this.txtMQuiniela.Text);
                        _limite.Monto_Pale = Convert.ToDecimal(this.txtMPale.Text);
                        _limite.Monto_Tripleta = Convert.ToDecimal(this.txtTripleta.Text);
                        _limite.Monto_SuperPale = Convert.ToDecimal(this.txtMSuperPale.Text);
                        _limite.Fecha = DateTime.Now;

                        context.Limite.Add(_limite);
                        context.SaveChanges();
                        mensajeOk("Limite agregado local");
                    }
                    else
                    {
                        limite.Quiniela = Convert.ToInt32(txtQuiniela.Text);
                        limite.Pale = Convert.ToInt32(txtPale.Text);
                        limite.Tripleta = Convert.ToInt32(txtTripleta.Text);
                        limite.Super_Pale = Convert.ToInt32(txtSuperPale.Text);
                        limite.Monto_Quiniela = Convert.ToDecimal(txtMQuiniela.Text);
                        limite.Monto_Pale = Convert.ToDecimal(txtMPale.Text);
                        limite.Monto_Tripleta = Convert.ToDecimal(txtMTripleta.Text);
                        limite.Monto_SuperPale = Convert.ToDecimal(txtMSuperPale.Text);
                        limite.Fecha = DateTime.Now;

                        context.SaveChanges();
                        mensajeOk("Limite actualizado local");
                        LlenarLimite();
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void LlenarLimite()
        {
            try
            {
                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        var consulta = context.Limite.FirstOrDefault();
                        if (consulta != null)
                        {
                            txtQuiniela.Text = consulta.Quiniela.ToString();
                            txtPale.Text = consulta.Pale.ToString();
                            txtTripleta.Text = consulta.Tripleta.ToString();
                            txtSuperPale.Text = consulta.Super_Pale.ToString();

                            txtMQuiniela.Text = consulta.Monto_Quiniela.ToString();
                            txtMPale.Text = consulta.Monto_Pale.ToString();
                            txtMTripleta.Text = consulta.Monto_Tripleta.ToString();
                            txtMSuperPale.Text = consulta.Monto_SuperPale.ToString();
                        }

                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        var consulta = context.Limite.FirstOrDefault();
                        if (consulta != null)
                        {
                            txtQuiniela.Text = consulta.Quiniela.ToString();
                            txtPale.Text = consulta.Pale.ToString();
                            txtTripleta.Text = consulta.Tripleta.ToString();
                            txtSuperPale.Text = consulta.Super_Pale.ToString();

                            txtMQuiniela.Text = consulta.Monto_Quiniela.ToString();
                            txtMPale.Text = consulta.Monto_Pale.ToString();
                            txtMTripleta.Text = consulta.Monto_Tripleta.ToString();
                            txtMSuperPale.Text = consulta.Monto_SuperPale.ToString();
                        }

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void FrmLimites_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 10;
            LlenarLimite();
        }
    }
}
