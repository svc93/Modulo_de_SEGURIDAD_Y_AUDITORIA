using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar;

namespace MetroBill
{
    /// <summary>
    /// Represents all application commands.
    /// </summary>
    public class MetroComandos
    {
        private DocumentCommands _UsuarioComandos = new DocumentCommands();
        private DocumentCommands _LoginComandos = new DocumentCommands();
        private DocumentCommands _CatAreas = new DocumentCommands();
        private DocumentCommands _CatEstadosLogin = new DocumentCommands();
        /// <summary>
        /// Gets the client related commands.
        /// </summary>
        public DocumentCommands UsuarioComandos
        {
            get { return _UsuarioComandos; }
            set { _UsuarioComandos = value; }
        }
        public DocumentCommands LoginComandos
        {
            get { return _LoginComandos; }
            set { _LoginComandos = value; }
        }
        public DocumentCommands CatAreas
        {
            get { return _CatAreas; }
            set { _CatAreas = value; }
        }
        public DocumentCommands CatEstadosLogin
        {
            get { return _CatEstadosLogin; }
            set { _CatEstadosLogin = value; }
        }
    }

    public class DocumentCommands
    {
        private Command _New;
        public Command Nuevo
        {
            get { return _New; }
            set { _New = value; }
        }

        private Command _Save;
        public Command Save
        {
            get { return _Save; }
            set { _Save = value; }
        }

        private Command _Cancelar;
        public Command Cancelar
        {
            get { return _Cancelar; }
            set { _Cancelar = value; }
        }

        private Command _Login;
        public Command Login
        {
            get { return _Login; }
            set { _Login = value; }
        }

        private Command _CerrarArea;
        public Command CerrarArea
        {
            get { return _CerrarArea; }
            set { _CerrarArea = value; }
        }
        private Command _CerrarEstadosLogin;
        public Command CerrarEstadosLogin
        {
            get { return _CerrarEstadosLogin; }
            set { _CerrarEstadosLogin = value; }
        }

    }
}
