using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using MetroBill;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista
{
    public partial class Seguridad_y_Auditoría : MetroAppForm
    {
        MetroComandos _Comandos = null;
        Usuarios formUsuarios = null;
        LoginUsuario loginForm = null;

        Datos.Usuario ClassUser = new Datos.Usuario();
        Boolean loginCorrecto = false;

        public Seguridad_y_Auditoría()
        {
            InitializeComponent();
            _Comandos = new MetroComandos();
             
            // Initialize Client related commands
            _Comandos.UsuarioComandos.Nuevo = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Comandos.UsuarioComandos.Nuevo.Executed += EjecutarUsuario;

            _Comandos.UsuarioComandos.Cancelar = new Command(components);
            _Comandos.UsuarioComandos.Cancelar.Executed += CancelarUsuario;

            _Comandos.UsuarioComandos.Save = new Command(components);
            _Comandos.UsuarioComandos.Save.Executed += OkUsuario;

            _Comandos.LoginComandos.Login = new Command(components);
            _Comandos.LoginComandos.Login.Executed += VerificarLogin; 
             
        }

        
        void EjecutarUsuario(object sender, EventArgs e)
        {
            Debug.Assert(formUsuarios == null);
            _Comandos.UsuarioComandos.Nuevo.Enabled = false; // Disable new client command to prevent re-entrancy
            formUsuarios = new Usuarios();
            formUsuarios.Commandos = _Comandos;
            this.ShowModalPanel(formUsuarios, DevComponents.DotNetBar.Controls.eSlideSide.Left); 
        }
        private void CancelarUsuario(object sender, EventArgs e)
        {
            // Simply close client entry form "dialog"
            Debug.Assert(formUsuarios != null);
            CerrarUsuario();
        }
        void VerificarLogin(object sender, EventArgs e)
        {
            if (loginForm.txtUsuario.Text == "" || loginForm.txtContrasena.Text == "") {
                ToastNotification.Show(this, "Completar Datos", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
            }
            else if (loginForm.txtUsuario.Text.Length <= 4 || loginForm.txtContrasena.Text.Length <= 4)
            {
                ToastNotification.Show(this, "Datos muy cortos", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
            }
            else {
                loginForm.btnCancelar.Visible = false;
                loginForm.btnEntrar.Visible = false;

                loginForm.progressCircleLogin.Visible = true;
                timerLogin.Start();
                timerLogin2.Start(); 
                
            }
        }


        private void CerrarUsuario()
        {
            _Comandos.UsuarioComandos.Nuevo.Enabled = true; // Enable new client command 
            this.CloseModalPanel(formUsuarios, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            formUsuarios.Commandos = null;
            formUsuarios.Dispose();
            formUsuarios = null;
        }

        void OkUsuario(object sender, EventArgs e)
        { 
            CerrarUsuario();
        }

        private void Seguridad_y_Auditoría_Load(object sender, EventArgs e)
        {
            Debug.Assert(loginForm == null); 
            loginForm = new LoginUsuario();
            loginForm.Commandos = _Comandos;
            this.ShowModalPanel(loginForm, DevComponents.DotNetBar.Controls.eSlideSide.Left); 
        }

        
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Debug.Assert(formUsuarios == null);
            _Comandos.UsuarioComandos.Nuevo.Enabled = false; // Disable new client command to prevent re-entrancy
            formUsuarios = new Usuarios();
            formUsuarios.Commandos = _Comandos;
            //manda abrir el form usuario deslizadooooooo
            this.ShowModalPanel(formUsuarios, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void timerLogin_Tick(object sender, EventArgs e)
        {
            loginForm.progressCircleLogin.Value += 20; 
        }
         
        private void timerLogin2_Tick(object sender, EventArgs e)
        {
            timerLogin.Stop();
            timerLogin2.Stop();

            loginCorrecto = ClassUser.loguear(loginForm.txtUsuario.Text, loginForm.txtContrasena.Text);
            if (loginCorrecto == true)
            {
                this.CloseModalPanel(loginForm, DevComponents.DotNetBar.Controls.eSlideSide.Left);
                loginForm.Commandos = null;
                loginForm.Dispose();
                loginForm = null;
            }
            else
            {
                loginForm.btnCancelar.Visible = true;
                loginForm.btnEntrar.Visible = true;

                loginForm.progressCircleLogin.Visible = false;
                ToastNotification.Show(this, "Datos Incorrectos, intente nuevamente", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
            }
        }
    }
}
