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
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnEntrar = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.txtContrasena = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(183, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 25);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.Tooltip = "Cerrar el sistema";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // progressCircleLogin
            // 
            this.progressCircleLogin.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.progressCircleLogin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressCircleLogin.Location = new System.Drawing.Point(265, 171);
            this.progressCircleLogin.Name = "progressCircleLogin";
            this.progressCircleLogin.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.progressCircleLogin.ProgressColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressCircleLogin.ProgressTextColor = System.Drawing.Color.Transparent;
            this.progressCircleLogin.Size = new System.Drawing.Size(87, 66);
            this.progressCircleLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.progressCircleLogin.TabIndex = 2;
            this.progressCircleLogin.ValueChanged += new System.EventHandler(this.progressCircleLogin_ValueChanged);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Location = new System.Drawing.Point(41, 62);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(541, 25);
            this.line1.TabIndex = 5;
            this.line1.Text = "line1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.DimGray, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // btnEntrar
            // 
            this.btnEntrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEntrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(315, 190);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(124, 25);
            this.btnEntrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextColor = System.Drawing.Color.SteelBlue;
            this.btnEntrar.Tooltip = "Entrar al Sistema";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(41, 31);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(533, 25);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Bienvenido al Sistema";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnEntrar);
            this.panelEx1.Controls.Add(this.btnCancelar);
            this.panelEx1.Controls.Add(this.txtContrasena);
            this.panelEx1.Controls.Add(this.txtUsuario);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.progressCircleLogin);
            this.panelEx1.Controls.Add(this.line1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(638, 261);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.LightSteelBlue;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.RoyalBlue;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 8;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtContrasena.Border.BackColor = System.Drawing.SystemColors.Window;
            this.txtContrasena.Border.BackColor2 = System.Drawing.SystemColors.InactiveBorder;
            this.txtContrasena.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.txtContrasena.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtContrasena.Border.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtContrasena.Border.BorderBottomWidth = 1;
            this.txtContrasena.Border.BorderLeftWidth = 1;
            this.txtContrasena.Border.BorderRightWidth = 1;
            this.txtContrasena.Border.BorderTopWidth = 1;
            this.txtContrasena.Border.Class = "TextBoxBorder";
            this.txtContrasena.Border.CornerDiameter = 7;
            this.txtContrasena.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtContrasena.ButtonCustom.Tooltip = "";
            this.txtContrasena.ButtonCustom2.Tooltip = "";
            this.txtContrasena.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(183, 131);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '•';
            this.txtContrasena.PreventEnterBeep = true;
            this.txtContrasena.Size = new System.Drawing.Size(256, 32);
            this.txtContrasena.TabIndex = 9;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrasena.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtContrasena.WatermarkText = "Contraseña";
            this.txtContrasena.TextChanged += new System.EventHandler(this.textBoxX2_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtUsuario.Border.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Border.BackColor2 = System.Drawing.SystemColors.InactiveBorder;
            this.txtUsuario.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.txtUsuario.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtUsuario.Border.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUsuario.Border.BorderBottomWidth = 1;
            this.txtUsuario.Border.BorderLeftWidth = 1;
            this.txtUsuario.Border.BorderRightWidth = 1;
            this.txtUsuario.Border.BorderTopWidth = 1;
            this.txtUsuario.Border.Class = "TextBoxBorder";
            this.txtUsuario.Border.CornerDiameter = 7;
            this.txtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtUsuario.ButtonCustom.Tooltip = "";
            this.txtUsuario.ButtonCustom2.Tooltip = "";
            this.txtUsuario.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(183, 93);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PreventEnterBeep = true;
            this.txtUsuario.Size = new System.Drawing.Size(256, 32);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.WatermarkText = "Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // LoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginUsuario";
            this.Size = new System.Drawing.Size(638, 261);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        public DevComponents.DotNetBar.Controls.CircularProgress progressCircleLogin;
        public DevComponents.DotNetBar.ButtonX btnCancelar;
        public DevComponents.DotNetBar.ButtonX btnEntrar;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        public DevComponents.DotNetBar.Controls.TextBoxX txtContrasena;
        public DevComponents.DotNetBar.Controls.TextBoxX txtUsuario;
    }
}
