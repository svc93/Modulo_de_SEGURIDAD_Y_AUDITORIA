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
using DevComponents.DotNetBar;
using System.Xml;
using System.Text.RegularExpressions;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista
{
    public partial class Empleados : UserControl
    {
        Datos.D_Seg_Empleado Emp = new Datos.D_Seg_Empleado(); 

        public Empleados()
        {
            InitializeComponent();
        }
          
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            String nuser;
            nuser = txtIdEmpleado.Text;
            Emp.eliminar(nuser);
        }
          
        private void Empleados_Load(object sender, EventArgs e)
        {
            cargarDatosNuevo(); 
        }
      
        private void cargarDatosNuevo()
        {
            cmbEstadoCivil.DataSource = null;
            cmbSexo.DataSource = null;
            cmbEstadoCivil.Items.Clear();
            cmbSexo.Items.Clear();
            cmbEstadoCivil.DisplayMember = null;
            cmbEstadoCivil.ValueMember = null;

            txtIdEmpleado.DataBindings.Clear();
            txtNombre.DataBindings.Clear();
            txtApellido.DataBindings.Clear();
            txtEdad.DataBindings.Clear();
             
            txtIdEmpleado.DataBindings.Add("Text", Emp.cargarProcedimiento(), "IDEmpleado");
            txtNombre.DataBindings.Add("Text", Emp.cargarProcedimiento(), "Nombres");
            txtApellido.DataBindings.Add("Text", Emp.cargarProcedimiento(), "Apellidos");
            txtEdad.DataBindings.Add("Text", Emp.cargarProcedimiento(), "Edad");

            cmbEstadoCivil.DataSource = Emp.cargarProcedimiento();
            cmbEstadoCivil.DisplayMember = "EstadoCivilNombre";
            cmbEstadoCivil.ValueMember = "EstadoCivil";

            cmbSexo.DataSource = Emp.cargarProcedimiento();
            cmbSexo.DisplayMember = "sexoNombre";
            cmbSexo.ValueMember = "Sexo";

            bindingNavigatorEx1.BindingSource = Emp.cargarProcedimiento();
            dgvEmpleados.DataSource = Emp.cargarProcedimiento();
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
                btnSalir.Command = nuevoValor.Empleados.CerrarEmpleados;
            }
            else
            {
                btnSalir.Command = null;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTxt();
        }

        private void limpiarTxt() {
            txtIdEmpleado.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNoDoc.Text = "";
            txtEdad.Text = "";

            cmbEstadoCivil.DataSource = null;
            cmbSexo.DataSource = null;
            cmbEstadoCivil.Items.Clear();
            cmbSexo.Items.Clear();
            cmbEstadoCivil.DisplayMember = null;
            cmbEstadoCivil.ValueMember = null;

            cmbEstadoCivil.DataSource = Emp.tEstadoCivilBinding();
            cmbEstadoCivil.DisplayMember = "Nombre";
            cmbEstadoCivil.ValueMember = "IdEstadoCivil";
             
            ComboboxItem mas = new ComboboxItem();
            ComboboxItem fem = new ComboboxItem();
            mas.Value = 1;
            fem.Value = 0;
            mas.Text = "Masculino";
            fem.Text = "Femenino";
            cmbSexo.Items.Add(mas);
            cmbSexo.Items.Add(fem);
             
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarCampos() == true)
                {
                    string idEmpleado, nomEmpleado, apeEmpleado;
                    int estadoCivil, edadEmpleado;
                    bool sexoEmpleado;

                    idEmpleado = txtIdEmpleado.Text;
                    estadoCivil = (int)cmbEstadoCivil.SelectedValue;
                    sexoEmpleado = (cmbSexo.Text == "Masculino") ? true : false;
                    nomEmpleado = txtNombre.Text;
                    apeEmpleado = txtApellido.Text;
                    edadEmpleado = Int32.Parse(txtEdad.Text);
                    int respuesta = 0;
                    respuesta = Emp.Insertar(idEmpleado, nomEmpleado, apeEmpleado, edadEmpleado, sexoEmpleado, estadoCivil);
                    switch (respuesta)
                    {
                        case 1:
                            ToastNotification.Show(this, "<h3>Empleado Agregado</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Blue), (eToastPosition)(eToastPosition.BottomCenter));
                            cargarDatosNuevo();
                            break;
                        case 2:
                            ToastNotification.Show(this, "<h3>Problemas al Insertar</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                            break;
                    }
                }
            }
            catch(Exception ex){
                ToastNotification.Show(this, "<h3>Problemas para Agregar</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                //MessageBox.Show("-----" + ex.ToString() + "-----");
            }
        }
 
        private bool verificarCampos()
        {
            bool respuesta = true;
            if (txtIdEmpleado.Text == "")
            {
                ToastNotification.Show(this, "<h3>Verificar Cédula</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                respuesta = false;
            }
            else if (txtNombre.Text == "")
            {
                ToastNotification.Show(this, "<h3>Verificar Nombre</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                respuesta = false;
            }
            else if (txtApellido.Text == "")
            {
                ToastNotification.Show(this, "<h3>Verificar Apellido</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                respuesta = false;
            }
            else if (txtNoDoc.Text == "")
            {
                ToastNotification.Show(this, "<h3>Verificar No. Doc</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                respuesta = false;
            }
            else if (txtEdad.Text == "")
            {
                ToastNotification.Show(this, "<h3>Verificar Edad</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
                respuesta = false;
            }
            return respuesta;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdEmpleado.Text != "")
                {
                    string idEmpleado = txtIdEmpleado.Text; 
                    int respuesta = Emp.eliminar(idEmpleado);
                    switch (respuesta)
                    {
                        case 1:
                            ToastNotification.Show(this, "<h3>Empleado Eliminado</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Blue), (eToastPosition)(eToastPosition.BottomCenter));
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarCampos() == true)
                {
                    string idEmpleado, nomEmpleado, apeEmpleado;
                    int estadoCivil, edadEmpleado;
                    bool sexoEmpleado;

                    idEmpleado = txtIdEmpleado.Text;
                    estadoCivil = (int)cmbEstadoCivil.SelectedValue;
                    sexoEmpleado = (cmbSexo.Text == "Masculino") ? true : false;
                    nomEmpleado = txtNombre.Text;
                    apeEmpleado = txtApellido.Text;
                    edadEmpleado = Int32.Parse(txtEdad.Text);
                    int respuesta = 0;
                    respuesta = Emp.Insertar(idEmpleado, nomEmpleado, apeEmpleado, edadEmpleado, sexoEmpleado, estadoCivil);
                    switch (respuesta)
                    {
                        case 1:
                            ToastNotification.Show(this, "<h3>Empleado Actualizado</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Blue), (eToastPosition)(eToastPosition.BottomCenter));
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
    }

    
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

}
