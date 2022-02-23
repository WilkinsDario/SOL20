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
    public partial class FrmConsulta : Form
    {
        public string usuario;
        public string banca;
        public string acceso;
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtConsulta.Text != string.Empty)
                {
                    if (acceso == "Administrador")
                    {
                        using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                        {
                            CapaDatos.Modelo.Ganadores_Diarios _ganadores_diarios = new CapaDatos.Modelo.Ganadores_Diarios();
                            var valor = context.Valor_Premios.FirstOrDefault();

                            int jugada = Convert.ToInt32(txtConsulta.Text);

                            var listajugada = context.Jugada.Where(x => x.Estatus != "Pagado" && x.Estatus != "Cancelado" && x.Numero_Jugada == jugada).ToList();


                            decimal premio = 0;
                            int cont = 0;
                            if (listajugada.Count != 0)
                            {
                                foreach (var item in listajugada)
                                {
                                    var loteria = context.Ganadores.Where(x => x.Loteria == item.Loteria && x.Fecha.Value.Day == item.Fecha.Value.Day && x.Fecha.Value.Month == item.Fecha.Value.Month && x.Fecha.Value.Year == item.Fecha.Value.Year).FirstOrDefault();

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
                                        if (item.Tipo_Jugada == "Super")
                                        {
                                            string l1 = item.Loteria.Substring(0, 2);
                                            string l2 = item.Loteria.Remove(0, 2);

                                            var lot1 = context.Ganadores.Where(x => x.Loteria == l1).FirstOrDefault();
                                            var lot2 = context.Ganadores.Where(x => x.Loteria == l2).FirstOrDefault();

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
                                            this.txtPremio.Text = premio.ToString();

                                            cont = cont + 1;
                                        }

                                    }
                                    else
                                    {
                                        mensajeError("No hay números publicados");
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                var consulta = context.Jugada.Where(x => x.Numero_Jugada == jugada).FirstOrDefault();
                                if (consulta.Estatus == "Pagado")
                                {
                                    mensajeOk("Este Ticket fue pagado");
                                }
                                else
                                {
                                    mensajeError("Verifique el Número");
                                }
                            }

                        }
                    }
                    else
                    {
                        using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                        {
                            CapaDatos.ModeloLocal.Ganadores_Diarios _ganadores_diarios = new CapaDatos.ModeloLocal.Ganadores_Diarios();
                            var valor = context.Valor_Premios.FirstOrDefault();

                            int jugada = Convert.ToInt32(txtConsulta.Text);

                            var listajugada = context.Jugada.Where(x => x.Estatus != "Pagado" && x.Estatus != "Cancelado" && x.Numero_Jugada == jugada).ToList();


                            decimal premio = 0;
                            int cont = 0;
                            if (listajugada.Count != 0)
                            {
                                foreach (var item in listajugada)
                                {
                                    var loteria = context.Ganadores.Where(x => x.Loteria == item.Loteria && x.Fecha.Value.Day == item.Fecha.Value.Day && x.Fecha.Value.Month == item.Fecha.Value.Month && x.Fecha.Value.Year == item.Fecha.Value.Year).FirstOrDefault();
                                    
                                    if (loteria != null)
                                    {
                                        if (item.Tipo_Jugada == "Quiniela")
                                        {
                                            if (item.Loteria == loteria.Loteria)
                                            {
                                                if (item.Quiniela == loteria.Primera)
                                                {
                                                    premio = premio + Convert.ToDecimal(item.Monto * valor.Primera);
                                                    cont = 1;
                                                }
                                                if (item.Quiniela == loteria.Segunda)
                                                {
                                                    premio = premio + Convert.ToDecimal(item.Monto * valor.Segunda);
                                                    cont = 1;
                                                }
                                                if (item.Quiniela == loteria.Tercera)
                                                {
                                                    premio = premio + Convert.ToDecimal(item.Monto * valor.Tercera);
                                                    cont = 1;
                                                }
                                            }
                                        }
                                        else if (item.Tipo_Jugada == "Pale")  // Pale1
                                        {
                                            bool pale1 = false;
                                            if (item.Loteria == loteria.Loteria)
                                            {
                                                if (item.Quiniela == loteria.Primera || item.Pale == loteria.Primera)
                                                {
                                                    if (item.Quiniela == loteria.Segunda || item.Pale == loteria.Segunda)
                                                    {
                                                        premio = premio + Convert.ToDecimal(item.Monto * valor.Pale_Uno);
                                                        cont = 1;
                                                    }
                                                }
                                                if (!pale1)
                                                {
                                                    if (item.Quiniela == loteria.Segunda || item.Quiniela == loteria.Tercera)
                                                    {
                                                        if (item.Pale == loteria.Segunda || item.Pale == loteria.Tercera)
                                                        {
                                                            premio = premio + Convert.ToDecimal(item.Monto * valor.Pale_Dos);
                                                            cont = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else if (item.Tipo_Jugada == "Tripleta") // Tripleta
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
                                                            cont = 1;
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
                                                        cont = 1;
                                                    }

                                                }
                                            }
                                        }                                       

                                    }
                                    else if (item.Tipo_Jugada == "Super")
                                    {
                                        string l1 = item.Loteria.Substring(0, 2);
                                        string l2 = item.Loteria.Remove(0, 2);

                                        var lot1 = context.Ganadores.Where(x => x.Loteria == l1).FirstOrDefault();
                                        var lot2 = context.Ganadores.Where(x => x.Loteria == l2).FirstOrDefault();

                                        if (lot1.Primera == item.Quiniela || lot1.Primera == item.Quiniela)
                                        {
                                            if (lot2.Primera == item.Pale || lot2.Primera == item.Pale)
                                            {
                                                premio = premio + Convert.ToDecimal(item.Monto * valor.Super_Pale);
                                                cont = 1;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        mensajeError("No hay números publicados");
                                        break;
                                    }
                                }
                                if (premio != 0)
                                {
                                    this.txtPremio.Text = premio.ToString();
                                }
                            }
                            else
                            {
                                var consulta = context.Jugada.Where(x => x.Numero_Jugada == jugada).FirstOrDefault();

                                if (consulta != null)
                                {
                                    if (consulta.Estatus == "Pagado")
                                    {
                                        mensajeOk("Este Ticket fue pagado");
                                    }
                                    else
                                    {
                                        mensajeError("Verifique el Número");
                                    }
                                }
                                
                            }

                        }
                    }
                    Mostrar();
                }
                else
                {
                    mensajeError("Debe digitar un número de jugada");
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
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

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (acceso == "Administrador")
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        if (txtPremio.Text != string.Empty)
                        {
                            int numero = Convert.ToInt32(txtConsulta.Text);


                            var consulta = context.Jugada.Where(x => x.Numero_Jugada == numero).ToList();

                            foreach (var item in consulta)
                            {
                                item.Estatus = "Pagado";
                                context.SaveChanges();
                            }

                            mensajeOk("Jugada Pagada");
                            txtConsulta.Text = string.Empty;
                            txtPremio.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        if (txtPremio.Text != string.Empty)
                        {
                            int numero = Convert.ToInt32(txtConsulta.Text);


                            var consulta = context.Jugada.Where(x => x.Numero_Jugada == numero).ToList();

                            foreach (var item in consulta)
                            {
                                item.Estatus = "Pagado";
                                context.SaveChanges();
                            }

                            mensajeOk("Jugada Pagada");
                            txtConsulta.Text = string.Empty;
                            txtPremio.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 10;
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
                    int jugada = Convert.ToInt32(this.txtConsulta.Text);
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        var consulta = context.Jugada.Where(x => x.Numero_Jugada == jugada).ToList();
                        this.dtgListado.DataSource = consulta;
                        Ocultar_Columnas();
                    }
                }
                else
                {
                    int jugada = Convert.ToInt32(this.txtConsulta.Text);
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        var consulta = context.Jugada.Where(x => x.Numero_Jugada == jugada).ToList();
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
    }
}
