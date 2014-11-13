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

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista
{
    public partial class CatAreas : UserControl
    { 
        D_Seg_Areas datosAreas = new D_Seg_Areas();

        public CatAreas()
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
                btnSalir.Command = nuevoValor.CatAreas.CerrarArea;
            }
            else
            {
                btnSalir.Command = null;
            }
        }

        private void CatAreas_Load(object sender, EventArgs e)
        {
            catAreasBindingSource.DataSource = datosAreas.tCatAreas(); 
        }

        private void cargarDatosNuevo()
        { 
            txtIdArea.DataBindings.Clear();
            txtNombre.DataBindings.Clear();
            txtDescripcion.DataBindings.Clear();

            txtIdArea.DataBindings.Add("Text", datosAreas.cargar(), "IdArea");
            txtNombre.DataBindings.Add("Text", datosAreas.cargar(), "Nombre");
            txtDescripcion.DataBindings.Add("Text", datosAreas.cargar(), "Descripción");

            bindingNavigatorEx1.BindingSource = datosAreas.cargar();
            dgvAreas.DataSource = datosAreas.cargar();

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
                    respuesta = datosAreas.Insertar("0", nomArea, desArea);
                    switch (respuesta)
                    {
                        case 1:
                            ToastNotification.Show(this, "<h3>Area Agregada</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Blue), (eToastPosition)(eToastPosition.BottomCenter));
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
            if (txtIdArea.Text == "" && actualizar == true)
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
                    idArea = txtIdArea.Text;
                    nomArea = txtNombre.Text;
                    desArea = txtDescripcion.Text;
                    int respuesta = 0;
                    respuesta = datosAreas.Insertar(idArea, nomArea, desArea);
                    switch (respuesta)
                    {
                        case 1:
                            ToastNotification.Show(this, "<h3>Area Actualizada</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Blue), (eToastPosition)(eToastPosition.BottomCenter));
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
            txtIdArea.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdArea.Text != "")
                {
                    string idArea = txtIdArea.Text;
                    int respuesta = datosAreas.eliminar(idArea);
                    switch (respuesta)
                    {
                        case 1:
                            ToastNotification.Show(this, "<h3>Area Eliminada</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Blue), (eToastPosition)(eToastPosition.BottomCenter));
                            cargarDatosNuevo();
                            break;
                        case 2:
                            ToastNotification.Show(this, "<h3>ID no encontrado</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                            break;
                        case 3:
                            ToastNotification.Show(this, "<h3>Problemas al Eliminar</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
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
