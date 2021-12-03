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
    public partial class FrmMostrar_Valores : Form
    {
        public string usuario;
        public string banca;
        public string acceso;

        public FrmMostrar_Valores()
        {
            InitializeComponent();
        }

        private void FrmMostrar_Valores_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 10;
            LlenarValor();
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
                else if (acceso == "Colaborador")
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
