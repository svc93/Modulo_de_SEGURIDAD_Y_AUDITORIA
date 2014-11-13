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
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg;
using DevComponents.DotNetBar;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista
{
    public partial class CatEstadosLogin : UserControl
    {
        D_Seg_EstadosLogin datosEstados = new D_Seg_EstadosLogin();

        public CatEstadosLogin()
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
                btnSalir.Command = nuevoValor.CatEstadosLogin.CerrarEstadosLogin;
            }
            else
            {
                btnSalir.Command = null;
            }
        }
         
        private void CatEstadosLogin_Load(object sender, EventArgs e)
        {
            estadoLoginBindingSource.DataSource = datosEstados.tEstados();
            cargarDatosNuevo();
        }

        private void cargarDatosNuevo()
        {
            txtIdEstado.DataBindings.Clear();
            txtNombre.DataBindings.Clear();
            txtDescripcion.DataBindings.Clear();

            txtIdEstado.DataBindings.Add("Text", datosEstados.cargarEstados(), "IdEstadoLogin");
            txtNombre.DataBindings.Add("Text", datosEstados.cargarEstados(), "Nombre");
            txtDescripcion.DataBindings.Add("Text", datosEstados.cargarEstados(), "Descripción");

            bindingNavigatorEx1.BindingSource = datosEstados.cargarEstados();
            dgvEstados.DataSource = datosEstados.cargarEstados();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarCampos(false) == true)
                {
                    string nomArea, desArea;
                    nomArea = txtNombre.Text;
                    desArea = txtDescripcion.Text;
                    int respuesta = 0;
                    respuesta = datosEstados.Insertar("0", nomArea, desArea);
                    switch (respuesta)
                    {
                        case 1:
                            ToastNotification.Show(this, "<h3>Estado Agregado</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Blue), (eToastPosition)(eToastPosition.BottomCenter));
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

        private bool verificarCampos(bool actualizar)
        {
            bool respuesta = true;
            if (txtIdEstado.Text == "" && actualizar == true)
            {
                ToastNotification.Show(this, "<h3>Verificar ID</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                respuesta = false;
            }
            else if (txtNombre.Text == "")
            {
                ToastNotification.Show(this, "<h3>Verificar Nombre</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                respuesta = false;
            }
            else if (txtDescripcion.Text == "")
            {
                ToastNotification.Show(this, "<h3>Verificar Descripción</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                respuesta = false;
            }
            return respuesta;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarCampos(true) == true)
                {
                    string idArea, nomArea, desArea;
                    idArea = txtIdEstado.Text;
                    nomArea = txtNombre.Text;
                    desArea = txtDescripcion.Text;
                    int respuesta = 0;
                    respuesta = datosEstados.Insertar(idArea, nomArea, desArea);
                    switch (respuesta)
                    {
                        case 1:
                            ToastNotification.Show(this, "<h3>Estado Actualizado</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Blue), (eToastPosition)(eToastPosition.BottomCenter));
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
            txtIdEstado.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdEstado.Text != "")
                {
                    string idArea = txtIdEstado.Text;
                    int respuesta = datosEstados.eliminar(idArea);
                    switch (respuesta)
                    {
                        case 1:
                            ToastNotification.Show(this, "<h3>Estado Eliminado</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Blue), (eToastPosition)(eToastPosition.BottomCenter));
                            cargarDatosNuevo();
                            break;
                        case 2:
                            ToastNotification.Show(this, "<h3>ID no encontrado</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                            break;
                        case 3:
                            ToastNotification.Show(this, "<h3>Problemas al Eliminar</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                            break;
                        case 4:
                            ToastNotification.Show(this, "<h3>No se puede eliminar, porque esta siendo usado por un Usuario</h3>", null, 3000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ToastNotification.Show(this, "<h3>Problemas para Eliminar</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                //MessageBox.Show("-----" + ex.ToString() + "-----");
            }
        }


    }
}
