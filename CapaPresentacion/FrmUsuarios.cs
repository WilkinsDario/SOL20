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
    public partial class FrmUsuarios : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public string usuario;
        public string banca;
        public string acceso;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IsNuevo = true;
            IsEditar = false;
            cbUsuario.Visible = false;
            txtUsuario.Visible = true;
            Botones();
            LimpiarColaboradores();
            this.txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {            
                IsEditar = true;
                cbUsuario.Visible = true;
                txtUsuario.Visible = false;
                Habilitar_Colaborador(true);
                Botones();
                Llenar_Colaboradores();           
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (acceso == "Administrador")
            {
                using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                {
                    CapaDatos.Modelo.Usuarios param = new CapaDatos.Modelo.Usuarios();

                    using (CapaDatos.Modelo.ModelDB md = new CapaDatos.Modelo.ModelDB())
                    {
                        try
                        {
                            string rpta = "";
                            if (this.txtNombre.Text == string.Empty || cbEstatus.Text == string.Empty)
                            {
                                mensajeError("falta ingresar algunos datos, seran remarcados");
                                errorIcono.SetError(txtNombre, "ingrese el nombre");
                                errorIcono.SetError(cbEstatus, "Este campo es obligatorio");
                            }
                            else
                            {
                                if (this.IsNuevo)
                                {
                                    if (ValidarUsuario())
                                    {
                                        param.Banca = txtNombre.Text;
                                        param.Usuario = txtUsuario.Text;
                                        param.Contrasena = txtContrasena.Text;
                                        param.Fecha = DateTime.Now;
                                        param.Acceso = cbTipo.Text;
                                        param.Estatus = this.cbEstatus.Text;

                                        context.Usuarios.Add(param);
                                        context.SaveChanges();
                                        rpta = "Ok";
                                        this.mensajeOk("El registro se Inserto correctamente");
                                        
                                    }
                                    else
                                    {
                                        mensajeError("El usuario ya existe");
                                    }

                                }
                                else if (IsEditar)
                                {
                                    string usuario = this.cbUsuario.Text;
                                    var consulta = context.Usuarios.Where(x => x.Usuario == usuario).FirstOrDefault();

                                    if (consulta != null && cbUsuario.Text != "Seleccione" && cbTipo.Text != "Seleccione" && cbEstatus.Text != "Seleccione")
                                    {
                                        consulta.Banca = txtNombre.Text.ToUpper();
                                        consulta.Contrasena = txtContrasena.Text;
                                        if (txtContrasena.Text == txtConfirmar.Text)
                                        {
                                            consulta.Usuario = this.txtUsuario.Text;
                                            consulta.Contrasena = this.txtContrasena.Text;
                                            consulta.Fecha = DateTime.Now;
                                            consulta.Acceso = cbTipo.Text;
                                            consulta.Estatus = this.cbEstatus.Text;

                                            context.SaveChanges();
                                            rpta = "Ok";
                                            this.mensajeOk("El registro se Actualizo correctamente");

                                        }
                                        else
                                        {
                                            mensajeError("Las contraseñas no coinciden");
                                        }
                                    }
                                    else
                                    {
                                        mensajeError("Faltan campos por ingresar");
                                    }
                                }
                                if (rpta.Equals("Ok"))
                                {
                                    this.IsNuevo = false;
                                    this.IsEditar = false;
                                    LimpiarColaboradores();
                                    Botones();
                                    Habilitar_Colaborador(false);
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
            else
            {
                using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                {
                    CapaDatos.ModeloLocal.Usuarios param = new CapaDatos.ModeloLocal.Usuarios();

                    try
                    {
                        string rpta = "";
                        if (this.txtNombre.Text == string.Empty || cbEstatus.Text == string.Empty)
                        {
                            mensajeError("falta ingresar algunos datos, seran remarcados");
                            errorIcono.SetError(txtNombre, "ingrese el nombre");
                            errorIcono.SetError(cbEstatus, "Este campo es obligatorio");
                        }
                        else
                        {
                            if (this.IsNuevo)
                            {
                                if (ValidarUsuario())
                                {
                                    param.Banca = txtNombre.Text;
                                    param.Usuario = txtUsuario.Text;
                                    param.Contrasena = txtContrasena.Text;
                                    param.Fecha = DateTime.Now;
                                    param.Acceso = cbTipo.Text;
                                    param.Estatus = this.cbEstatus.Text;

                                    context.Usuarios.Add(param);
                                    context.SaveChanges();
                                    rpta = "Ok";
                                    this.mensajeOk("El registro se Inserto correctamente");
                                }
                                else
                                {
                                    mensajeError("El usuario ya existe");
                                }

                            }
                            else if (IsEditar)
                            {
                                string usuario = this.cbUsuario.Text;
                                var consulta = context.Usuarios.Where(x => x.Usuario == usuario).FirstOrDefault();

                                if (consulta != null && cbUsuario.Text != "Seleccione" && cbTipo.Text != "Seleccione" && cbEstatus.Text != "Seleccione")
                                {
                                    consulta.Banca = txtNombre.Text.ToUpper();
                                    consulta.Contrasena = txtContrasena.Text;
                                    if (txtContrasena.Text == txtConfirmar.Text)
                                    {
                                        consulta.Usuario = this.txtUsuario.Text;
                                        consulta.Contrasena = txtContrasena.Text;
                                        consulta.Acceso = cbTipo.Text;
                                        consulta.Estatus = this.cbEstatus.Text;
                                        consulta.Fecha = DateTime.Now;

                                        context.SaveChanges();
                                        rpta = "Ok";
                                        this.mensajeOk("El registro se Actualizo correctamente");

                                    }
                                    else
                                    {
                                        mensajeError("Las contraseñas no coinciden");
                                    }
                                }
                                else
                                {
                                    mensajeError("Faltan campos por ingresar");
                                }
                            }
                            if (rpta.Equals("Ok"))
                            {
                                this.IsNuevo = false;
                                this.IsEditar = false;

                                LimpiarColaboradores();
                                Mostrar();
                                Botones();                                                               
                                Habilitar_Colaborador(false);
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

        private void Llenar_Colaboradores()
        {
            try
            {
                if (acceso == "Administrador")
                {

                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        var consulta = context.Usuarios.ToList();
                        foreach (var item in consulta)
                        {
                            cbUsuario.Items.Add(item.Usuario);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Habilitar_Colaborador(bool valor)
        {
            btnNuevo.Enabled = !valor;
            btnEditar.Enabled = !valor;
            btnGuardar.Enabled = valor;

            txtNombre.ReadOnly = !valor;
            txtUsuario.ReadOnly = !valor;
            txtContrasena.ReadOnly = !valor;
            txtConfirmar.ReadOnly = !valor;
            cbUsuario.Enabled = valor;
            cbTipo.Enabled = valor;
            cbEstatus.Enabled = valor;
        }

        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                Habilitar_Colaborador(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            else
            {
                Habilitar_Colaborador(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void LimpiarColaboradores()
        {
            txtNombre.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            txtConfirmar.Text = string.Empty;
            cbEstatus.Text = "Seleccione";
            cbTipo.Text = "Seleccione";
            cbUsuario.Text = "Seleccione";
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

            if (acceso == "Administrador")
            {
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
            else
            {
                using (CapaDatos.ModeloLocal.Modelo_Local contex = new CapaDatos.ModeloLocal.Modelo_Local())
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
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 10;
            Mostrar();
            Botones();
            Habilitar_Colaborador(false);
        }

        private void Ocultar_Columnas()
        {
            this.dtgListado.Columns[0].Visible = false;
            this.dtgListado.Columns[1].Visible = false;
            this.dtgListado.Columns[3].Visible = false;
        }

        private void Mostrar()
        {
            try
            {
                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        var consulta = context.Usuarios.ToList();
                        dtgListado.DataSource = consulta;
                        Ocultar_Columnas();
                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        var consulta = context.Usuarios.ToList();
                        dtgListado.DataSource = consulta;
                        Ocultar_Columnas();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string usuario = this.cbUsuario.Text;
                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        var consulta = context.Usuarios.Where(x => x.Usuario == usuario).FirstOrDefault();
                        this.txtNombre.Text = consulta.Banca;
                        this.txtContrasena.Text = consulta.Contrasena;
                        this.cbEstatus.Text = consulta.Estatus;
                        this.cbTipo.Text = consulta.Acceso;
                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        var consulta = context.Usuarios.Where(x => x.Usuario == usuario).FirstOrDefault();
                        this.txtNombre.Text = consulta.Banca;
                        this.txtContrasena.Text = consulta.Contrasena;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void ckbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEliminar.Checked)
            {
                this.dtgListado.Columns[0].Visible = true;
            }
            else
            {
                this.dtgListado.Columns[0].Visible = false;
            }
        }

        private void dtgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dtgListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;

                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        opcion = MessageBox.Show("Desea eliminar los registros?", "SOL20", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (opcion == DialogResult.OK)
                        {
                            int codigo;
                            string rpt = "";

                            foreach (DataGridViewRow item in dtgListado.Rows)
                            {
                                if (Convert.ToBoolean(item.Cells[0].Value))
                                {
                                    codigo = Convert.ToInt32(item.Cells[1].Value);

                                    var consulta = context.Usuarios.Where(x => x.Id_Usuario == codigo).FirstOrDefault();

                                    context.Usuarios.Remove(consulta);
                                    rpt = "Ok";
                                }
                            }
                            if (rpt == "Ok")
                            {
                                mensajeOk("Registro eliminado");
                                Mostrar();
                            }
                            else
                            {
                                mensajeError("No se eliminaron registros");
                            }
                        }
                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {                        
                        opcion = MessageBox.Show("Desea eliminar los registros?", "SOL20", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (opcion == DialogResult.OK)
                        {
                            int codigo;
                            string rpt = "";

                            foreach (DataGridViewRow item in dtgListado.Rows)
                            {
                                if (Convert.ToBoolean(item.Cells[0].Value))
                                {
                                    codigo = Convert.ToInt32(item.Cells[1].Value);

                                    var consulta = context.Usuarios.Where(x => x.Id_Usuario == codigo).FirstOrDefault();

                                    context.Usuarios.Remove(consulta);
                                    context.SaveChanges();
                                    rpt = "Ok";
                                }
                            }
                            if (rpt == "Ok")
                            {
                                mensajeOk("Registro eliminado");
                                Mostrar();
                            }
                            else
                            {
                                mensajeError("No se eliminaron registros");
                            }
                        }
                    }
                }
                Mostrar();
            }
            catch (Exception)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IsNuevo = false;
            IsEditar = false;
            Botones();
            Habilitar_Colaborador(false);
        }
    }
}
