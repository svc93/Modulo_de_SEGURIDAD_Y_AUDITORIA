using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos;
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset;
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset.SISTEMADataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg
{
    class D_Seg_EstadosLogin
    {
        SISTEMADataSet.EstadoLoginDataTable estadoT = new SISTEMADataSet.EstadoLoginDataTable();
        EstadoLoginTableAdapter estadoTa = new EstadoLoginTableAdapter();
        BindingSource bsEstados = new BindingSource();

        public SISTEMADataSet.EstadoLoginDataTable tEstados()
        {
            EstadoLoginTableAdapter daEstado = new EstadoLoginTableAdapter();
            SISTEMADataSet.EstadoLoginDataTable dtEstado = new SISTEMADataSet.EstadoLoginDataTable();
            daEstado.Fill(dtEstado);
            return dtEstado;
        }

        public BindingSource cargarEstados()
        {
            estadoTa.Fill(estadoT);
            bsEstados.DataSource = estadoT;
            return bsEstados;
        }
         
        private Boolean busqueda(String idEstado)
        {
            SISTEMADataSet.buscarEstadoDataTable estadoDT = new SISTEMADataSet.buscarEstadoDataTable();
            buscarEstadoTableAdapter estadoTA = new buscarEstadoTableAdapter();
            estadoTA.Fill(estadoDT, idEstado);
            return (estadoDT.Rows.Count >= 1) ? true : false;
        }
        
        public int Insertar(string idEstado, string nombre, string descripcion)
        {
            int respuesta = 0;
            try
            {
                respuesta = 1;
                if (busqueda(idEstado) == true)
                    estadoTa.Update(nombre, descripcion, idEstado);
                else
                    estadoTa.Insert( nombre, descripcion);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("-----" + ex.ToString() + "-----");
                respuesta = 2;
            }
            return respuesta;
        }

        public int eliminar(string idArea)
        {
            int respuesta = 0;
            try
            {
                if (busqueda(idArea) == true)
                {
                    if (busquedaUSO(idArea)==false)
                    {
                        respuesta = 1;
                        estadoTa.Delete(idArea);
                    }
                    else{
                        respuesta = 4;
                    }
                }
                else
                {
                    respuesta = 2;
                }
            }
            catch (Exception ex)
            {
                respuesta = 3;
                //MessageBox.Show("-----" + ex.ToString() + "-----");
            }
            return respuesta;
        }
        
        private bool busquedaUSO(string idEstado){
            D_Seg_Usuario instancia = new D_Seg_Usuario();
            return instancia.usuarioUsaEstado(idEstado);
        }
         
    }
}
