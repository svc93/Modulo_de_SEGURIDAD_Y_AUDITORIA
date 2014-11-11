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

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista
{
    public partial class Empleados : UserControl
    {
        Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos.Empleado Emp = new Datos.Empleados();

        public Empleados()
        {
            InitializeComponent();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            String nuser;
            nuser = textBoxX8.Text;
            Emp.eliminar(nuser);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            String estadoc;
            String nuser;
            String Sexo;
            String Nombre;
            String Apellidos;
            String Edad;


            nuser = textBoxX8.Text;
            estadoc = comboBoxEx2.Text;
            Sexo = comboBoxEx1.Text;

            Nombre = textBoxX5.Text;
            Apellidos = textBoxX7.Text;



            Edad = textBoxX4.Text;

            Emp.Insertar(nuser, Nombre, Apellidos, Edad, Sexo, estadoc);
        }

        private void Empleados_Load(object sender, EventArgs e)
        { 
            textBoxX8.DataBindings.Add("Text", Emp.cargar(), "IDEmpleado");
            textBoxX5.DataBindings.Add("Text", Emp.cargar(), "Nombres");
            textBoxX7.DataBindings.Add("Text", Emp.cargar(), "Apellidos");
            textBoxX4.DataBindings.Add("Text", Emp.cargar(), "Edad");
            comboBoxEx1.DataBindings.Add("Text", Emp.cargar(), "Sexo");
            comboBoxEx2.DataBindings.Add("Text", Emp.cargar(), "EstadoCIvil");

            bindingNavigatorEx1.BindingSource = Emp.cargar();
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

    }
}
