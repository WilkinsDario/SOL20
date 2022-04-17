using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CapaDatos;
using CapaPresentacion;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        string usuario;
        string contrasena;


        public FrmLogin()
        {
            InitializeComponent();
        }


        private void Login()
        {
            try
            {
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    DateTime fecha = DateTime.Now;
                    var consultusuario = context.Usuarios.Where(x => x.Usuario == this.txtUsuario.Text).FirstOrDefault();
                    if (consultusuario != null)
                    {
                        if (consultusuario.Acceso == "Administrador")
                        {
                            using (CapaDatos.Modelo.ModelDB contextS = new CapaDatos.Modelo.ModelDB())
                            {
                                usuario = txtUsuario.Text;
                                contrasena = txtContraseña.Text;

                                var consulta = contextS.Usuarios.Where(x => x.Usuario == usuario && x.Estatus == "Activo").SingleOrDefault();

                                if (consulta != null)
                                {
                                    if (consulta.Contrasena == contrasena)
                                    {

                                        MDIMenuPrincipal mDIMenuPrincipal = new MDIMenuPrincipal();
                                        mDIMenuPrincipal.usuario = usuario;
                                        mDIMenuPrincipal.banca = consulta.Banca;
                                        mDIMenuPrincipal.acceso = consulta.Acceso;
                                        mensajeOk("Acceso Concedido");
                                        mDIMenuPrincipal.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        mensajeError("Constraseña incorrecta");
                                        this.txtContraseña.Text = string.Empty;
                                    }
                                }
                                else
                                {
                                    mensajeError("Usuario incorrecto");
                                    this.txtUsuario.Text = string.Empty;
                                }
                            }
                        }
                        else
                        {
                            if (this.txtUsuario.Text == "admin" && this.txtContraseña.Text == "221219860831")
                            {
                                FrmActualizarUsuario frmActualizarUsuario = new FrmActualizarUsuario();
                                frmActualizarUsuario.Show();
                                this.Hide();
                            }
                            else
                            {
                                usuario = txtUsuario.Text;
                                contrasena = txtContraseña.Text;

                                var consulta = context.Usuarios.Where(x => x.Usuario == usuario && x.Estatus == "Activo").SingleOrDefault();

                                if (consulta != null)
                                {
                                    if (consulta.Contrasena == contrasena)
                                    {
                                        MDIMenuPrincipal mDIMenuPrincipal = new MDIMenuPrincipal();
                                        mDIMenuPrincipal.usuario = usuario;
                                        mDIMenuPrincipal.banca = consulta.Banca;
                                        mDIMenuPrincipal.acceso = consulta.Acceso;
                                        mensajeOk("Acceso Concedido");
                                        mDIMenuPrincipal.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        mensajeError("Constraseña incorrecta");
                                        this.txtContraseña.Text = string.Empty;
                                    }
                                }
                                else
                                {
                                    mensajeError("Usuario incorrecto");
                                    this.txtUsuario.Text = string.Empty;
                                }


                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Login();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = 50;
        }
    }
}
