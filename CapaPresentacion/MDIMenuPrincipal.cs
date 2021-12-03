using Presentacion;
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
    public partial class MDIMenuPrincipal : Form
    {
        private int childFormNumber = 0;
        public string usuario;
        public string banca;
        public string acceso;

        public MDIMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void jugadaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmJuagada frmJuagada = new FrmJuagada();
            frmJuagada.MdiParent = this;
            frmJuagada.usuario = usuario;
            frmJuagada.banca = banca;
            frmJuagada.acceso = acceso;
            frmJuagada.Show();
        }

        private void cierreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCierre frmCierre = new FrmCierre();
            frmCierre.MdiParent = this;
            frmCierre.usuario = usuario;
            frmCierre.banca = banca;
            frmCierre.acceso = acceso;
            frmCierre.Show();            
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta frmConsulta = new FrmConsulta();
            frmConsulta.MdiParent = this;
            frmConsulta.usuario = usuario;
            frmConsulta.banca = banca;
            frmConsulta.acceso = acceso;
            frmConsulta.Show();
        }

        private void publicacióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGanadores frmGanadores = new FrmGanadores();
            frmGanadores.MdiParent = this;
            frmGanadores.usuario = usuario;
            frmGanadores.banca = banca;
            frmGanadores.acceso = acceso;
            frmGanadores.Show();
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes();
            frmReportes.MdiParent = this;
            frmReportes.usuario = usuario;
            frmReportes.banca = banca;
            frmReportes.acceso = acceso;
            frmReportes.Show();
        }

        private void migraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMigracion frmMigracion = new FrmMigracion();
            frmMigracion.MdiParent = this;
            frmMigracion.usuario = usuario;
            frmMigracion.banca = banca;
            frmMigracion.acceso = acceso;
            frmMigracion.Show();
        }

        private void generarGanadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenGanadores frmGenGanadores = new FrmGenGanadores();
            frmGenGanadores.MdiParent = this;
            frmGenGanadores.usuario = usuario;
            frmGenGanadores.banca = banca;
            frmGenGanadores.acceso = acceso;
            frmGenGanadores.Show();
        }

        private void valoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmValorPremios frmValorPremios = new FrmValorPremios();
            frmValorPremios.MdiParent = this;
            frmValorPremios.usuario = usuario;
            frmValorPremios.banca = banca;
            frmValorPremios.acceso = acceso;
            frmValorPremios.Show();
        }

        private void limitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLimites frmLimites = new FrmLimites();
            frmLimites.MdiParent = this;
            frmLimites.usuario = usuario;
            frmLimites.banca = banca;
            frmLimites.acceso = acceso;
            frmLimites.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.usuario = usuario;
            frmUsuarios.banca = banca;
            frmUsuarios.acceso = acceso;
            frmUsuarios.Show();
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHorarios frmHorarios = new FrmHorarios();
            frmHorarios.MdiParent = this;
            frmHorarios.usuario = usuario;
            frmHorarios.banca = banca;
            frmHorarios.acceso = acceso;
            frmHorarios.Show();
        }

        private void MDIMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (acceso == "Colaborador")
            {
                reportesToolStripMenuItem1.Enabled = false;
                mantenimientoToolStripMenuItem.Enabled = false;
            }
        }
    }
}
