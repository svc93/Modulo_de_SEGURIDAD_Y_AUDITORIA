using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos
{
    class Usuario
    {


        //String XMLlocation = Application.StartupPath + @"\XMLUser.xml";

        public Boolean loguear(String username, String password)
        {
            Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos.Dataset.SISTEMADataSetTableAdapters.UsuarioTableAdapter daUser = new Dataset.SISTEMADataSetTableAdapters.UsuarioTableAdapter();

            Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos.Dataset.SISTEMADataSet.UsuarioDataTable dtUser = new Datos.Dataset.SISTEMADataSet.UsuarioDataTable();

            daUser.Fill(dtUser);

            string usuario;
            string contra;
            Boolean LoginCorrecto = false;


            for (int i = 0; i < dtUser.Rows.Count; i++)
            {
                usuario = dtUser.Rows[i]["IdUsuario"].ToString();
                contra = dtUser.Rows[i]["Contraseña"].ToString();
                
                if (username == usuario && password == contra)
                {
                    LoginCorrecto = true;
                }

            }

            return LoginCorrecto;


        }



    }
}
