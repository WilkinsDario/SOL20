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
    public partial class FrmActualizarUsuario : Form
    {
        public string usuario;
        public string banca;
        public string acceso;
        public FrmActualizarUsuario()
        {
            InitializeComponent();
        }

        private void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidarUsuario()
        {
            bool valido = true;
            using (CapaDatos.Modelo.ModelDB contex = new CapaDatos.Modelo.ModelDB())
            {
                var consulta = contex.Usuarios.ToList();

                foreach (var item in consulta)
                {
                    if (item.Usuario == txtUsuario.Text)
                    {
                        valido = false;
                    }
                }
                return valido;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
            {
                CapaDatos.Modelo.Usuarios param = new CapaDatos.Modelo.Usuarios();

                using (CapaDatos.Modelo.ModelDB md = new CapaDatos.Modelo.ModelDB())
                {
                    try
                    {
                        if (this.txtNombre.Text == string.Empty || this.txtContrasena.Text == string.Empty || this.txtConfirmar.Text == string.Empty)
                        {
                            mensajeError("falta ingresar algunos datos, seran remarcados");
                            errorIcono.SetError(txtNombre, "ingrese el nombre");
                        }
                        else
                        {
                            if (ValidarUsuario())
                            {
                                param.Banca = txtNombre.Text;
                                param.Usuario = txtUsuario.Text;
                                param.Contrasena = txtContrasena.Text;
                                param.Acceso = "Administrador";
                                param.Estatus = "Activo";

                                context.Usuarios.Add(param);
                                context.SaveChanges();
                                this.mensajeOk("El registro se Inserto correctamente");

                                this.txtUsuario.Text = string.Empty;
                                this.txtContrasena.Text = string.Empty;
                                this.txtConfirmar.Text = string.Empty;
                            }
                            else
                            {
                                mensajeError("El usuario ya existe");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);

                    }
                }
            }
        }
    }
}
