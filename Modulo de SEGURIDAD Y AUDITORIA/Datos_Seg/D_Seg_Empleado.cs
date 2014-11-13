using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset;
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset.SISTEMADataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos
{
    class D_Seg_Empleado
    {
        SISTEMADataSet.EmpleadosDataTable empleadosdt =  new SISTEMADataSet.EmpleadosDataTable();
        EmpleadosTableAdapter empleadosta = new EmpleadosTableAdapter();
        BindingSource bs = new BindingSource();
        BindingSource bsEstados = new BindingSource(); 

        SISTEMADataSet.empleadosTablaDataTable empTabla = new SISTEMADataSet.empleadosTablaDataTable();
        empleadosTablaTableAdapter empAdapter = new empleadosTablaTableAdapter();
         
        public BindingSource cargarProcedimiento()
        {
            empAdapter.Fill(empTabla);
            bs.DataSource = empTabla;
            return bs;
        }
        public BindingSource cargar()
        { 
            empleadosta.FillBy(empleadosdt); 
            bs.DataSource = empleadosdt;
            return bs;
        }
         

        private Boolean busqueda(String idEmpleado)
        {  
            SISTEMADataSet.buscarEmpleadoDataTable empleadosdt = new SISTEMADataSet.buscarEmpleadoDataTable();
            buscarEmpleadoTableAdapter empleadosta = new buscarEmpleadoTableAdapter();
            empleadosta.Fill(empleadosdt, idEmpleado);
            return (empleadosdt.Rows.Count >= 1) ? true : false; 
        }
 
        public int Insertar(string idempleado, string nombre, string apellidos, int edad, bool sexo, int estadocivil)
        {
            int respuesta = 0;
            try
            {
                respuesta = 1;
                if (busqueda(idempleado) == true)
                    empleadosta.ActualizarEmpleado(nombre, apellidos, edad, estadocivil, sexo, idempleado);
                else
                    empleadosta.InsertarEmpleado(idempleado, nombre, apellidos, edad, estadocivil, sexo);
            }
            catch(Exception ex){
                //MessageBox.Show("-----" + ex.ToString() + "-----");
                respuesta  = 2; 
            }
            return respuesta;
        }

        public int eliminar(string idempleado)
        {
            int respuesta = 0;
            try
            {
                if (busqueda(idempleado) == true)
                {
                    respuesta = 1;
                    empleadosta.DeleteQuery(idempleado); 
                }
                else
                {
                    respuesta = 2;
                }
            }
            catch(Exception ex){
                respuesta = 3;
                //MessageBox.Show("-----" + ex.ToString() + "-----");
            }
            return respuesta;
        }
 
        public SISTEMADataSet.Cat_Estado_CivilDataTable tEstadoCivil()
        {
            Cat_Estado_CivilTableAdapter daUser = new Cat_Estado_CivilTableAdapter();
            SISTEMADataSet.Cat_Estado_CivilDataTable dtUser = new SISTEMADataSet.Cat_Estado_CivilDataTable();
            daUser.Fill(dtUser);
            return dtUser;
        }
        
        public BindingSource tEstadoCivilBinding()
        { 
            bsEstados.DataSource = tEstadoCivil();
            return bsEstados;
        }
    }
}
