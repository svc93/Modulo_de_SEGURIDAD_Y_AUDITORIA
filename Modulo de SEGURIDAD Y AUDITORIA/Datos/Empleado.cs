using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos
{
    class Empleado
    {
        Dataset.SISTEMADataSet.EmpleadosDataTable empleadosdt = new Dataset.SISTEMADataSet.EmpleadosDataTable();
        Dataset.SISTEMADataSetTableAdapters.EmpleadosTableAdapter empleadosta = new Dataset.SISTEMADataSetTableAdapters.EmpleadosTableAdapter();
        
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
             
            Datos.Dataset.SISTEMADataSet.EmpleadosDataTable empleadosdt = new Dataset.SISTEMADataSet.EmpleadosDataTable();
            Datos.Dataset.SISTEMADataSetTableAdapters.EmpleadosTableAdapter empleadosta = new Dataset.SISTEMADataSetTableAdapters.EmpleadosTableAdapter();

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


        public void Insertar(string idempleado, string nombre, string apellidos, int edad, bool sexo, int estadocivil)
        { 
            if (busqueda(idempleado) == true)
            {
                empleadosta.ActualizarEmpleado(nombre, apellidos, edad, estadocivil, sexo, idempleado);             
                MessageBox.Show("Se ha modificado el registro " + idempleado);
            }
            else
            { 
                empleadosta.InsertarEmpleado(idempleado, nombre, apellidos, edad, estadocivil, sexo);
                MessageBox.Show("Se ha Agregado el nuevo registro " + idempleado);
            }

        }

        public void eliminar(string idempleado)
        {            empleadosta.Delete(idempleado);
            empleadosta.Fill(empleadosdt);
            MessageBox.Show("Se ha eliminado el registro " + idempleado);
        }


        public Dataset.SISTEMADataSet.Cat_Estado_CivilDataTable tEstadoCivil()
        {
            Dataset.SISTEMADataSetTableAdapters.Cat_Estado_CivilTableAdapter daUser = new Dataset.SISTEMADataSetTableAdapters.Cat_Estado_CivilTableAdapter();
            Dataset.SISTEMADataSet.Cat_Estado_CivilDataTable dtUser = new Datos.Dataset.SISTEMADataSet.Cat_Estado_CivilDataTable();
            daUser.Fill(dtUser);
            return dtUser;
        }
    }
}
