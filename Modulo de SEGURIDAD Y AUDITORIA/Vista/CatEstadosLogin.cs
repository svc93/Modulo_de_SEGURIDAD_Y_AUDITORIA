﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroBill;
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista
{
    public partial class CatEstadosLogin : UserControl
    {
        public CatEstadosLogin()
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
                btnSalir.Command = nuevoValor.CatEstadosLogin.CerrarEstadosLogin;
            }
            else
            {
                btnSalir.Command = null;
            }
        }


        

        private void CatEstadosLogin_Load(object sender, EventArgs e)
        {
            Usuario datosUsuario = new Usuario();
            estadoLoginBindingSource.DataSource = datosUsuario.tEstadosLogin(); 
        }

    }
}
