using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset;
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset.SISTEMADataSetTableAdapters;
using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Drawing;
using System.Windows.Forms;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos
{
    public class D_Seg_Usuario
    {
        public string nombres = "", apellidos = "";
        BindingSource bs = new BindingSource();
        SISTEMADataSet.UsuarioDataTable dtUsuario = new SISTEMADataSet.UsuarioDataTable();
        UsuarioTableAdapter daUsuario = new UsuarioTableAdapter();

        public Boolean loguear(String username, String password)
        {
            loginUsuariosTableAdapter daUser = new loginUsuariosTableAdapter();
            SISTEMADataSet.loginUsuariosDataTable dtUser = new SISTEMADataSet.loginUsuariosDataTable(); 
            daUser.Fill(dtUser, username, password);
            if (dtUser.Rows.Count >= 1){
                nombres = dtUser.Rows[0][0].ToString();
                apellidos = dtUser.Rows[0][1].ToString(); 
               return true;
            }
            else{
                return false;
            } 
        } 

        public SISTEMADataSet.UsuarioDataTable tUsuarios()
        {
            UsuarioTableAdapter daUser = new UsuarioTableAdapter();
            SISTEMADataSet.UsuarioDataTable dtUser = new SISTEMADataSet.UsuarioDataTable();
            daUser.Fill(dtUser);
            return dtUser;
        }

        public SISTEMADataSet.EstadoLoginDataTable tEstadosLogin()
        {
            EstadoLoginTableAdapter daUser = new EstadoLoginTableAdapter();
            SISTEMADataSet.EstadoLoginDataTable dtUser = new SISTEMADataSet.EstadoLoginDataTable();
            daUser.Fill(dtUser);
            return dtUser; 
        }

        public bool usuarioUsaEstado(string idEstado) {
            buscarEstadoUSOTableAdapter daBusqueda = new buscarEstadoUSOTableAdapter();
            SISTEMADataSet.buscarEstadoUSODataTable dtBusqueda = new SISTEMADataSet.buscarEstadoUSODataTable();
            daBusqueda.Fill(dtBusqueda, idEstado);
            return (dtBusqueda.Rows.Count>=1)? true: false;
        }


        public BindingSource tUsuarioEstados()
        {
            usuarioEstadosTableAdapter daUser = new usuarioEstadosTableAdapter();
            SISTEMADataSet.usuarioEstadosDataTable dtUser = new SISTEMADataSet.usuarioEstadosDataTable();
            daUser.Fill(dtUser);
            bs.DataSource = dtUser;
            return bs; 
        }

        
        private Boolean busquedaUsuario(String idUsuario)
        {
            SISTEMADataSet.buscarUsuarioDataTable areaDT = new SISTEMADataSet.buscarUsuarioDataTable();
            buscarUsuarioTableAdapter areaTA = new buscarUsuarioTableAdapter();
            areaTA.Fill(areaDT, idUsuario);
            return (areaDT.Rows.Count >= 1) ? true : false;
        }


        public int Insertar(string usuario, string contra, string cedula, string estado)
        {
            int respuesta = 0;
            try
            {
                respuesta = 1;
                if (busquedaUsuario(usuario) == true)
                    daUsuario.Update(usuario,contra,estado,cedula);
                else
                    daUsuario.Insert(usuario, contra, cedula, estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("-----" + ex.ToString() + "-----");
                respuesta = 2;
            }
            return respuesta;
        }


    }
}
