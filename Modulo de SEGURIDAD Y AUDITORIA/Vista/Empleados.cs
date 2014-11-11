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
        Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos.Empleado Emp = new Datos.Empleado();

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
            string idEmpleado, nomEmpleado, apeEmpleado;
            int estadoCivil,edadEmpleado;
            bool sexoEmpleado;

            idEmpleado = textBoxX8.Text;
            int selectedValue = Int32.Parse((string)comboBoxEx2.SelectedValue); 
            estadoCivil = selectedValue;
            sexoEmpleado =  (comboBoxEx1.Text == "Masculino") ? true : false; 
            nomEmpleado = textBoxX5.Text;
            apeEmpleado = textBoxX7.Text; 
            edadEmpleado = Int32.Parse(textBoxX4.Text);

            Emp.Insertar(idEmpleado, nomEmpleado, apeEmpleado, edadEmpleado, sexoEmpleado, estadoCivil);
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
            dgvEmpleados.DataSource = Emp.cargar();

            DataTable estadosCivil = Emp.tEstadoCivil();
            foreach (DataRow fila in estadosCivil.Rows) 
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = fila[1].ToString();
                item.Value = fila[0].ToString();
                comboBoxEx2.Items.Add(item);
            }              
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

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

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
