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
    public partial class FrmValorPremios : Form
    {
        public string usuario;
        public string banca;
        public string acceso;

        public FrmValorPremios()
        {
            InitializeComponent();
        }

        private void btnActualizarValor_Click(object sender, EventArgs e)
        {
            try
            {
                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        CapaDatos.Modelo.Valor_Premios _valor = new CapaDatos.Modelo.Valor_Premios();
                        var valores = context.Valor_Premios.FirstOrDefault();
                        if (valores == null)
                        {
                            _valor.Primera = Convert.ToInt32(txtPrimera.Text);
                            _valor.Segunda = Convert.ToInt32(txtSegunda.Text);
                            _valor.Tercera = Convert.ToInt32(txtTercera.Text);
                            _valor.Super_Pale = Convert.ToInt32(txtSuperP.Text);
                            _valor.Pale_Uno = Convert.ToInt32(txtPale1.Text);
                            _valor.Pale_Dos = Convert.ToInt32(txtPale2.Text);
                            _valor.Tripleta = Convert.ToInt32(this.txtValorTripleta.Text);
                            _valor.Tripleta_2 = Convert.ToInt32(this.txtTripleta2.Text);

                            context.Valor_Premios.Add(_valor);
                            context.SaveChanges();
                            mensajeOk("Valores agregados servidor");
                            LlenarValor();
                        }
                        else
                        {
                            valores.Primera = Convert.ToInt32(txtPrimera.Text);
                            valores.Segunda = Convert.ToInt32(txtSegunda.Text);
                            valores.Tercera = Convert.ToInt32(txtTercera.Text);
                            valores.Super_Pale = Convert.ToInt32(txtSuperP.Text);
                            valores.Pale_Uno = Convert.ToInt32(txtPale1.Text);
                            valores.Pale_Dos = Convert.ToInt32(txtPale2.Text);
                            valores.Tripleta = Convert.ToInt32(txtValorTripleta.Text);
                            valores.Tripleta_2 = Convert.ToInt32(this.txtTripleta2.Text);

                            context.SaveChanges();
                            mensajeOk("Valores actualizados servidor");
                        }

                    }
                    try
                    {
                        using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                        {
                            CapaDatos.ModeloLocal.Valor_Premios _valor = new CapaDatos.ModeloLocal.Valor_Premios();
                            var valores = context.Valor_Premios.FirstOrDefault();
                            if (valores == null)
                            {
                                _valor.Primera = Convert.ToInt32(txtPrimera.Text);
                                _valor.Segunda = Convert.ToInt32(txtSegunda.Text);
                                _valor.Tercera = Convert.ToInt32(txtTercera.Text);
                                _valor.Super_Pale = Convert.ToInt32(txtSuperP.Text);
                                _valor.Pale_Uno = Convert.ToInt32(txtPale1.Text);
                                _valor.Pale_Dos = Convert.ToInt32(txtPale2.Text);
                                _valor.Tripleta = Convert.ToInt32(this.txtValorTripleta.Text);
                                _valor.Tripleta_2 = Convert.ToInt32(this.txtTripleta2.Text);

                                context.Valor_Premios.Add(_valor);
                                context.SaveChanges();
                                mensajeOk("Valores agregados local");
                                LlenarValor();
                            }
                            else
                            {
                                valores.Primera = Convert.ToInt32(txtPrimera.Text);
                                valores.Segunda = Convert.ToInt32(txtSegunda.Text);
                                valores.Tercera = Convert.ToInt32(txtTercera.Text);
                                valores.Super_Pale = Convert.ToInt32(txtSuperP.Text);
                                valores.Pale_Uno = Convert.ToInt32(txtPale1.Text);
                                valores.Pale_Dos = Convert.ToInt32(txtPale2.Text);
                                valores.Tripleta = Convert.ToInt32(txtValorTripleta.Text);
                                valores.Tripleta_2 = Convert.ToInt32(this.txtTripleta2.Text);

                                context.SaveChanges();
                                mensajeOk("Valores actualizados local");
                            }

                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        CapaDatos.ModeloLocal.Valor_Premios _valor = new CapaDatos.ModeloLocal.Valor_Premios();
                        var valores = context.Valor_Premios.FirstOrDefault();
                        if (valores == null)
                        {
                            _valor.Primera = Convert.ToInt32(txtPrimera.Text);
                            _valor.Segunda = Convert.ToInt32(txtSegunda.Text);
                            _valor.Tercera = Convert.ToInt32(txtTercera.Text);
                            _valor.Super_Pale = Convert.ToInt32(txtSuperP.Text);
                            _valor.Pale_Uno = Convert.ToInt32(txtPale1.Text);
                            _valor.Pale_Dos = Convert.ToInt32(txtPale2.Text);
                            _valor.Tripleta = Convert.ToInt32(this.txtValorTripleta.Text);
                            _valor.Tripleta_2 = Convert.ToInt32(this.txtTripleta2.Text);

                            context.Valor_Premios.Add(_valor);
                            context.SaveChanges();
                            mensajeOk("Valores agregados local");
                            LlenarValor();
                        }
                        else
                        {
                            valores.Primera = Convert.ToInt32(txtPrimera.Text);
                            valores.Segunda = Convert.ToInt32(txtSegunda.Text);
                            valores.Tercera = Convert.ToInt32(txtTercera.Text);
                            valores.Super_Pale = Convert.ToInt32(txtSuperP.Text);
                            valores.Pale_Uno = Convert.ToInt32(txtPale1.Text);
                            valores.Pale_Dos = Convert.ToInt32(txtPale2.Text);
                            valores.Tripleta = Convert.ToInt32(txtValorTripleta.Text);
                            valores.Tripleta_2 = Convert.ToInt32(this.txtTripleta2.Text);

                            context.SaveChanges();
                            mensajeOk("Valores actualizados local");
                        }

                    }
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

        private void LlenarValor()
        {
            try
            {
                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        var consulta = context.Valor_Premios.FirstOrDefault();
                        if (consulta != null)
                        {
                            txtPrimera.Text = consulta.Primera.ToString();
                            txtSegunda.Text = consulta.Segunda.ToString();
                            txtTercera.Text = consulta.Tercera.ToString();
                            txtSuperP.Text = consulta.Super_Pale.ToString();
                            txtPale1.Text = consulta.Pale_Uno.ToString();
                            txtPale2.Text = consulta.Pale_Dos.ToString();
                            txtValorTripleta.Text = consulta.Tripleta.ToString();
                            txtTripleta2.Text = consulta.Tripleta_2.ToString();
                        }
                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        var consulta = context.Valor_Premios.FirstOrDefault();
                        if (consulta != null)
                        {
                            txtPrimera.Text = consulta.Primera.ToString();
                            txtSegunda.Text = consulta.Segunda.ToString();
                            txtTercera.Text = consulta.Tercera.ToString();
                            txtSuperP.Text = consulta.Super_Pale.ToString();
                            txtPale1.Text = consulta.Pale_Uno.ToString();
                            txtPale2.Text = consulta.Pale_Dos.ToString();
                            txtValorTripleta.Text = consulta.Tripleta.ToString();
                            txtTripleta2.Text = consulta.Tripleta_2.ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void FrmValorPremios_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 10;
            LlenarValor();
        }
    }
}
