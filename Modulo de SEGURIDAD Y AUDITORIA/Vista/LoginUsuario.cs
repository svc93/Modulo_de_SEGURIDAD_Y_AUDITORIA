using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MetroBill;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista
{
    public partial class LoginUsuario : UserControl
    {
        public LoginUsuario()
        {
            InitializeComponent();
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
                btnEntrar.Command = nuevoValor.LoginComandos.Login;
            }
            else
            {
                btnCancelar.Command = null;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 

        private void progressCircleLogin_ValueChanged(object sender, EventArgs e)
        {
            progressCircleLogin.IsRunning =! progressCircleLogin.IsRunning;
            //progressCircleLogin.Update();
        }


    }
}
