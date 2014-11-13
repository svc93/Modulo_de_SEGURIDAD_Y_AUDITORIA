using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset;
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset.SISTEMADataSetTableAdapters;
using System;
using System.Collections.Generic; 
using System.Linq; 

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos
{
    public class D_Seg_Usuario
    {
        public string nombres="", apellidos="";

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


    }
}
