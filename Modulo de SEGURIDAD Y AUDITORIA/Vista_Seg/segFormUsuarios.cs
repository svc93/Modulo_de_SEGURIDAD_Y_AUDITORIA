using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroBill;
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos;
using DevComponents.DotNetBar;
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg; 

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista
{
    public partial class Usuarios : UserControl
    {
        D_Seg_Usuario dUsuario = new D_Seg_Usuario();
        D_Seg_EstadosLogin dEstados = new D_Seg_EstadosLogin();
        D_Seg_Empleado dEmpleados = new D_Seg_Empleado();

        public Usuarios()
        {
            InitializeComponent();
        }

        private MetroComandos _Comandos;
       
        public MetroComandos Commandos
        {
            get { return _Comandos; }
            set
            {
                if (value != _Comandos)
                {
                    MetroComandos viejoValor = _Comandos;
                    _Comandos = value;
                    OnCommandsChanged(viejoValor, value);
                }
            }
        }

        protected virtual void OnCommandsChanged(MetroComandos oldValue, MetroComandos nuevoValor)
        {
            if (nuevoValor != null)
            {
                btnSalir.Command = nuevoValor.UsuarioComandos.Cancelar; 
            }
            else
            {
                btnSalir.Command = null; 
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            D_Seg_Usuario datosUsuarios = new D_Seg_Usuario();
            usuarioBindingSource1.DataSource = datosUsuarios.tUsuarios();
            cargarDatosNuevo();
        }

        private void cargarDatosNuevo()
        { 
            cmbCedula.DataSource = null;
            cmbEstado.DataSource = null;

            cmbEstado.Items.Clear();
            cmbCedula.Items.Clear();

            cmbEstado.DisplayMember = null;
            cmbEstado.ValueMember = null;

            cmbCedula.DisplayMember = null;
            cmbCedula.ValueMember = null;

            txtUsuario.DataBindings.Clear();
            txtContra.DataBindings.Clear();

            txtUsuario.DataBindings.Add("Text", dUsuario.tUsuarioEstados(), "IdUsuario");
            txtContra.DataBindings.Add("Text", dUsuario.tUsuarioEstados(), "Contraseña");
            cmbEstado.DataBindings.Add("Text", dUsuario.tUsuarioEstados(), "EstadoCivilNombre");

            cmbEstado.DataSource = dEstados.cargarEstados();
            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "IdEstadoLogin";

            cmbCedula.DataSource = dUsuario.tUsuarioEstados();
            cmbCedula.DisplayMember = "Cédula";
            cmbCedula.ValueMember = "Cédula";

            bindingNavigatorEx1.BindingSource = dUsuario.tUsuarioEstados();
            dgvUsuarios.DataSource = dUsuario.tUsuarioEstados();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarCampos() == true)
                {
                    string usuario, contra, cedula,estado;
                    usuario = txtUsuario.Text;
                    contra = txtContra.Text;
                    cedula = (string)cmbCedula.SelectedValue;
                    estado = (string)cmbCedula.SelectedValue;
                    int respuesta = 0;
                    respuesta = dUsuario.Insertar(usuario,contra,cedula,estado);
                    switch (respuesta)
                    {
                        case 1:
                            ToastNotification.Show(this, "<h3>Usuario Agregado</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Blue), (eToastPosition)(eToastPosition.BottomCenter));
                            cargarDatosNuevo();
                            break;
                        case 2:
                            ToastNotification.Show(this, "<h3>Problemas al Insertar</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ToastNotification.Show(this, "<h3>Problemas para Agregar</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                //MessageBox.Show("-----" + ex.ToString() + "-----");
            }
        }

        private bool verificarCampos()
        {
            bool respuesta = true;
            if (txtUsuario.Text == "")
            {
                ToastNotification.Show(this, "<h3>Verificar Usuario</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                respuesta = false;
            }
            else if (txtContra.Text == "")
            {
                ToastNotification.Show(this, "<h3>Verificar Contra</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                respuesta = false;
            }
            else if (cmbEstado.Text == "")
            {
                ToastNotification.Show(this, "<h3>Verificar Estado</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                respuesta = false;
            }
            else if (cmbCedula.Text == "")
            {
                ToastNotification.Show(this, "<h3>Verificar Cédula</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                respuesta = false;
            } 
            return respuesta;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarCampos() == true)
                {
                    string usuario, contra, cedula,estado;
                    usuario = txtUsuario.Text;
                    contra = txtContra.Text;
                    cedula = (string)cmbCedula.SelectedValue;
                    estado = (string)(cmbEstado.SelectedValue);
                    int respuesta = 0;
                    respuesta = dUsuario.Insertar(usuario, contra, cedula, estado);
                    switch (respuesta)
                    {
                        case 1:
                            ToastNotification.Show(this, "<h3>Usuario Actualizado</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Blue), (eToastPosition)(eToastPosition.BottomCenter));
                            cargarDatosNuevo();
                            break;
                        case 2:
                            ToastNotification.Show(this, "<h3>Problemas al Actualizar</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ToastNotification.Show(this, "<h3>Problemas para Actualizar</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                //MessageBox.Show("-----" + ex.ToString() + "-----");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContra.Text = "";

            cmbCedula.DataSource = null;
            cmbEstado.DataSource = null;

            cmbCedula.Items.Clear();
            cmbEstado.Items.Clear();
            
            cmbCedula.DisplayMember = null;
            cmbCedula.ValueMember = null;

            cmbEstado.DisplayMember = null;
            cmbEstado.ValueMember = null;

            cmbEstado.DataSource = dEstados.cargarEstados();
            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "IdEstadoLogin";

            cmbCedula.DataSource = dEmpleados.cargarProcedimiento();
            cmbCedula.DisplayMember = "IDEmpleado";
            cmbCedula.ValueMember = "IDEmpleado";
              
        }

        

    }
}
