namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista
{
    partial class LoginUsuario
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.progressCircleLogin = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.txtUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtContrasena = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnEntrar = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(122, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 23);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.Tooltip = "Cerrar el sistema";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // progressCircleLogin
            // 
            // 
            // 
            // 
            this.progressCircleLogin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressCircleLogin.Location = new System.Drawing.Point(191, 121);
            this.progressCircleLogin.Name = "progressCircleLogin";
            this.progressCircleLogin.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.progressCircleLogin.ProgressColor = System.Drawing.Color.SteelBlue;
            this.progressCircleLogin.Size = new System.Drawing.Size(75, 61);
            this.progressCircleLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.progressCircleLogin.TabIndex = 2;
            this.progressCircleLogin.ValueChanged += new System.EventHandler(this.progressCircleLogin_ValueChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUsuario.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUsuario.Border.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtUsuario.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUsuario.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUsuario.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUsuario.Border.Class = "TextBoxBorder";
            this.txtUsuario.Border.CornerDiameter = 5;
            this.txtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtUsuario.ButtonCustom.Tooltip = "";
            this.txtUsuario.ButtonCustom2.Tooltip = "";
            this.txtUsuario.DisabledBackColor = System.Drawing.Color.White;
            this.txtUsuario.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(122, 51);
            this.txtUsuario.MaxLength = 17;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PreventEnterBeep = true;
            this.txtUsuario.Size = new System.Drawing.Size(219, 30);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtUsuario.WatermarkText = "Usuario";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContrasena.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtContrasena.Border.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtContrasena.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtContrasena.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtContrasena.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtContrasena.Border.Class = "TextBoxBorder";
            this.txtContrasena.Border.CornerDiameter = 5;
            this.txtContrasena.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtContrasena.ButtonCustom.Tooltip = "";
            this.txtContrasena.ButtonCustom2.Tooltip = "";
            this.txtContrasena.DisabledBackColor = System.Drawing.Color.White;
            this.txtContrasena.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.Black;
            this.txtContrasena.Location = new System.Drawing.Point(122, 88);
            this.txtContrasena.MaxLength = 17;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = 'o';
            this.txtContrasena.PreventEnterBeep = true;
            this.txtContrasena.Size = new System.Drawing.Size(219, 30);
            this.txtContrasena.TabIndex = 4;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrasena.WatermarkText = "Contraseña";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(3, 28);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(457, 23);
            this.line1.TabIndex = 5;
            this.line1.Text = "line1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // btnEntrar
            // 
            this.btnEntrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEntrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(235, 133);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(106, 23);
            this.btnEntrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextColor = System.Drawing.Color.SteelBlue;
            this.btnEntrar.Tooltip = "Entrar al Sistema";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(3, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(457, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Bienvenido al Sistema";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.progressCircleLogin);
            this.Name = "LoginUsuario";
            this.Size = new System.Drawing.Size(463, 185);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        public DevComponents.DotNetBar.Controls.TextBoxX txtUsuario;
        public DevComponents.DotNetBar.Controls.TextBoxX txtContrasena;
        public DevComponents.DotNetBar.Controls.CircularProgress progressCircleLogin;
        public DevComponents.DotNetBar.ButtonX btnCancelar;
        public DevComponents.DotNetBar.ButtonX btnEntrar;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}
