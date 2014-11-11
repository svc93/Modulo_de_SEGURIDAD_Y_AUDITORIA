using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos
{
    class Empleado
    {


        Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos.Dataset.SISTEMADataSet.EmpleadosDataTable empleadosdt = new Dataset.SISTEMADataSet.EmpleadosDataTable();
        Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos.Dataset.SISTEMADataSetTableAdapters.EmpleadosTableAdapter empleadosta = new Dataset.SISTEMADataSetTableAdapters.EmpleadosTableAdapter();


        BindingSource bs = new BindingSource();


        public BindingSource cargar()
        {


            empleadosta.Fill(empleadosdt);

            bs.DataSource = empleadosdt;


            return bs;


        }

        private Boolean busqueda(String user)
        {

            Boolean encontrado = false;



            Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos.Dataset.SISTEMADataSet.EmpleadosDataTable empleadosdt = new Dataset.SISTEMADataSet.EmpleadosDataTable();
            Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos.Dataset.SISTEMADataSetTableAdapters.EmpleadosTableAdapter empleadosta = new Dataset.SISTEMADataSetTableAdapters.EmpleadosTableAdapter();

            empleadosta.Fill(empleadosdt);

            for (int i = 0; i < empleadosdt.Rows.Count; i++)
            {
                if (user == empleadosdt.Rows[i][0].ToString())
                {
                    encontrado = true;


                }
            }

            return encontrado;




        }


        public void Insertar(string idempleado, string nombre, String apellidos, int edad, String sexo, Boolean estadocivil)
        { 
            if (busqueda(idempleado) == true)
            {
                empleadosta.ActualizarEmpleado(nombre, apellidos, edad, estadocivil, sexo, idempleado);
                MessageBox.Show("Se ha modificado el registro " + idempleado);

            }
            else
            {

                empleadosta.InsertarEmpleado(idempleado, nombre, apellidos, edad, sexo, estadocivil);
                MessageBox.Show("Se ha Agregado el nuevo registro " + idempleado);

            }

        }

        public void eliminar(string idempleado)
        {

            empleadosta.Delete(idempleado);
            empleadosta.Fill(empleadosdt);
            MessageBox.Show("Se ha eliminado el registro " + idempleado);

        }        


    }
}
