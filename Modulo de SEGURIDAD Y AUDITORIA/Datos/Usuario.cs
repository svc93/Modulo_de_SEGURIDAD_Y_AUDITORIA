using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos
{
    public class Usuario
    { 
        public Boolean loguear(String username, String password)
        {
            Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos.Dataset.SISTEMADataSet.UsuarioDataTable dtUser = tUsuarios();
            
            string usuario,contra;
            Boolean LoginCorrecto = false;             
            for (int i = 0; i < dtUser.Rows.Count; i++)
            {
                usuario = dtUser.Rows[i]["IdUsuario"].ToString();
                contra = dtUser.Rows[i]["Contraseña"].ToString();                
                if (username == usuario && password == contra)
                    LoginCorrecto = true;             
            }
            return LoginCorrecto;
        }

        public Dataset.SISTEMADataSet.UsuarioDataTable tUsuarios() {
            Dataset.SISTEMADataSetTableAdapters.UsuarioTableAdapter daUser = new Dataset.SISTEMADataSetTableAdapters.UsuarioTableAdapter();
            Dataset.SISTEMADataSet.UsuarioDataTable dtUser = new Datos.Dataset.SISTEMADataSet.UsuarioDataTable();
            daUser.Fill(dtUser);
            return dtUser;
        }



    }
}
