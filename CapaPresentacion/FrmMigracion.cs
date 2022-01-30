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
    public partial class FrmMigracion : Form
    {
        public string usuario;
        public string banca;
        public string acceso;

        public FrmMigracion()
        {
            InitializeComponent();
        }

        private void Migrar_Diario()
        {
            int cont = 0;

            using (CapaDatos.Modelo.ModelDB contextserver = new CapaDatos.Modelo.ModelDB())
            {

                CapaDatos.ModeloLocal.Modelo_Local contextlocal = new CapaDatos.ModeloLocal.Modelo_Local();

                CapaDatos.Modelo.Jugada _jugada = new CapaDatos.Modelo.Jugada();
                var consultalocal = contextlocal.Jugada.Where(x => x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day &&
                                                                   x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month &&
                                                                   x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();

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

        private void Migrar_Resultados_Serv()
        {
            int cont = 0;

            using (CapaDatos.Modelo.ModelDB contextserver = new CapaDatos.Modelo.ModelDB())
            {
                CapaDatos.ModeloLocal.Modelo_Local contextlocal = new CapaDatos.ModeloLocal.Modelo_Local();

                CapaDatos.Modelo.Ganadores _jugada = new CapaDatos.Modelo.Ganadores();
                var consultalocal = contextlocal.Ganadores.Where(x => x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day &&
                                                                   x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month &&
                                                                   x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();

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


        private void MigrarALocal()
        {
            int cont = 0;
            using (CapaDatos.ModeloLocal.Modelo_Local contextlocal = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                CapaDatos.Modelo.ModelDB contextserver = new CapaDatos.Modelo.ModelDB();
                CapaDatos.ModeloLocal.Jugada _jugada = new CapaDatos.ModeloLocal.Jugada();

                var consulaserver = contextserver.Jugada.Where(x => x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day &&
                                                                   x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month &&
                                                                   x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();

                if (consulaserver.Count != 0)
                {
                    foreach (var item in consulaserver)
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
                        _jugada.Tanda = item.Tanda;
                        _jugada.Quiniela = item.Quiniela;
                        _jugada.Pale = item.Pale;
                        _jugada.Tripleta = item.Tripleta;
                        _jugada.Banca = item.Banca;
                        _jugada.Usuario = item.Usuario;

                        contextlocal.Jugada.Add(_jugada);
                        contextlocal.SaveChanges();
                        cont = cont + 1;
                    }

                    mensajeOk("Migrado " + cont.ToString());
                }
            }
        }

        private void Migrar_Resultados_Loc()
        {
            int cont = 0;

            using (CapaDatos.ModeloLocal.Modelo_Local contextlocal = new CapaDatos.ModeloLocal.Modelo_Local())
            {
                CapaDatos.Modelo.ModelDB contextserver = new CapaDatos.Modelo.ModelDB();

                CapaDatos.ModeloLocal.Ganadores _jugada = new CapaDatos.ModeloLocal.Ganadores();
                var consultaserver = contextserver.Ganadores.Where(x => x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day &&
                                                                   x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month &&
                                                                   x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();

                foreach (var item in consultaserver)
                {

                    _jugada.Loteria = item.Loteria;
                    _jugada.Primera = item.Primera;
                    _jugada.Segunda = item.Segunda;
                    _jugada.Tercera = item.Tercera;
                    _jugada.Fecha = item.Fecha;

                    contextlocal.Ganadores.Add(_jugada);
                    contextlocal.SaveChanges();
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

        private void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ckbMigrarServer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMigrarServer.Checked)
            {
                ckbMigrarServer.Checked = true;
                ckbMigrarLocal.Checked = false;
            }
            else
            {
                ckbMigrarServer.Checked = false;
            }
        }

        private void ckbMigrarLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMigrarLocal.Checked)
            {
                ckbMigrarLocal.Checked = true;
                ckbMigrarServer.Checked = false;
            }
            else
            {
                ckbMigrarLocal.Checked = false;
            }
        }

        private void btnMigracion_Click(object sender, EventArgs e)
        {
            if (ckbMigrarServer.Checked)
            {
                Migrar_Diario();

                Migrar_Resultados_Serv();
            }
            if (ckbMigrarLocal.Checked)
            {
                MigrarALocal();

                Migrar_Resultados_Loc();
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (ckbMigrarServer.Checked)
            {
                try
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        var consultalocal = context.Jugada.Where(x => x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day &&
                                                                   x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month &&
                                                                   x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();
                        this.dtgListado.DataSource = consultalocal;
                        Ocultar_Columnas();

                    }
                }
                catch (Exception)
                {

                }
            }
            if (ckbMigrarLocal.Checked)
            {
                try
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        var consultalocal = context.Jugada.Where(x => x.Fecha.Value.Day >= dtpDesde.Value.Day && x.Fecha.Value.Day <= dtpHasta.Value.Day &&
                                                                   x.Fecha.Value.Month >= dtpDesde.Value.Month && x.Fecha.Value.Month <= dtpHasta.Value.Month &&
                                                                   x.Fecha.Value.Year >= dtpDesde.Value.Year && x.Fecha.Value.Year <= dtpHasta.Value.Year).ToList();
                        this.dtgListado.DataSource = consultalocal;
                        Ocultar_Columnas();

                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void FrmMigracion_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 10;
        }

        private void Ocultar_Columnas()
        {
            this.dtgListado.Columns[0].Visible = false;
        }
    }
}
