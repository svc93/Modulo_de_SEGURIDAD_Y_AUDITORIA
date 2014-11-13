using System;
using System.Collections.Generic;
using System.Linq;
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset;
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset.SISTEMADataSetTableAdapters;
using System.Windows.Forms;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos
{
    class D_Seg_Areas
    {
        SISTEMADataSet.Cat_AreasDataTable areaT = new SISTEMADataSet.Cat_AreasDataTable();
        Cat_AreasTableAdapter areaTa = new Cat_AreasTableAdapter();
        BindingSource bs = new BindingSource();
        
        public SISTEMADataSet.Cat_AreasDataTable tCatAreas()
        {
            Cat_AreasTableAdapter daCarAreas = new Cat_AreasTableAdapter();
            SISTEMADataSet.Cat_AreasDataTable dtCatAreas = new SISTEMADataSet.Cat_AreasDataTable();
            daCarAreas.Fill(dtCatAreas);
            return dtCatAreas;
        }

        public BindingSource cargar()
        {
            areaTa.Fill(areaT);
            bs.DataSource = areaT;
            return bs;
        }
         
        private Boolean busqueda(String idArea)
        {
            SISTEMADataSet.buscarAreaDataTable areaDT = new SISTEMADataSet.buscarAreaDataTable();
            buscarAreaTableAdapter areaTA = new buscarAreaTableAdapter();
            areaTA.Fill(areaDT, idArea);
            return (areaDT.Rows.Count >= 1) ? true : false;
        }
        
        public int Insertar(string idArea, string nombre, string descripcion)
        {
            int respuesta = 0;
            try
            {
                respuesta = 1;
                if (busqueda(idArea) == true)
                    areaTa.Update(nombre, descripcion, idArea);
                else
                    areaTa.Insert(idArea, nombre, descripcion);
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
                    respuesta = 1;
                    areaTa.Delete(idArea);
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
 

    }
}
