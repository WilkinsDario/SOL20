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
    public partial class FrmMostrar_Jugadas : Form
    {
        public FrmMostrar_Jugadas()
        {
            InitializeComponent();
        }

        private void FrmMostrar_Jugadas_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            try
            {
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    var consulta = context.Jugada.Where(x => x.Fecha.Value.Day == DateTime.Now.Day &&
                                                             x.Fecha.Value.Month == DateTime.Now.Month &&
                                                             x.Fecha.Value.Year == DateTime.Now.Year).ToList();

                    this.dtgListado.DataSource = consulta;
                    Ocultar_Columnas();
                }
            }
            catch (Exception)
            {

            }
        }

        private void Ocultar_Columnas()
        {
            this.dtgListado.Columns[0].Visible = false;
            this.dtgListado.Columns[4].Visible = false;
            this.dtgListado.Columns[5].Visible = false;
            this.dtgListado.Columns[10].Visible = false;
            this.dtgListado.Columns[11].Visible = false;
            this.dtgListado.Columns[12].Visible = false;
            this.dtgListado.Columns[13].Visible = false;
            this.dtgListado.Columns[14].Visible = false;
            this.dtgListado.Columns[15].Visible = false;
            this.dtgListado.Columns[16].Visible = false;
        }
    }
}
