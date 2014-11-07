using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using MetroBill;
using System.Diagnostics;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista
{
    public partial class PanelPrincipal : MetroAppForm
    {
        MetroComandos _Comandos = null;
        Usuarios formUsuarios = null;
        LoginUsuario loginForm = null;

        Datos.Usuario ClassUser = new Datos.Usuario();
        Boolean loginCorrecto = false;

        public PanelPrincipal()
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
            if (loginForm.txtUsuario.Text == "" || loginForm.txtContrasena.Text == "")
            {
                ToastNotification.Show(this, "Completar Datos", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
            }
            else if (loginForm.txtUsuario.Text.Length <= 4 || loginForm.txtContrasena.Text.Length <= 4)
            {
                ToastNotification.Show(this, "Datos muy cortos", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
            }
            else
            {
                loginForm.btnCancelar.Visible = false;
                loginForm.btnEntrar.Visible = false;
                loginForm.txtUsuario.Enabled = false;
                loginForm.txtContrasena.Enabled = false;


                loginForm.progressCircleLogin.Visible = true;
                timerLogin.Start();
                timer2.Start(); 

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
          
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            
        }
         
         

        private void InitializeComponent()
        { 
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipal));
            this.metroTileItem2 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.Seguridad = new DevComponents.DotNetBar.ItemContainer();
            this.btnMetroUsuarios = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem4 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.Auditoria = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem5 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem6 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem7 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem8 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.timerLogin = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTileItem2
            // 
            this.metroTileItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem2.Image = ((System.Drawing.Image)(resources.GetObject("metroTileItem2.Image")));
            this.metroTileItem2.Name = "metroTileItem2";
            this.metroTileItem2.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem2.Text = "Catálogo de Areas";
            this.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTilePanel1
            // 
            this.metroTilePanel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTilePanel1.DragDropSupport = true;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Seguridad,
            this.Auditoria});
            this.metroTilePanel1.Location = new System.Drawing.Point(0, 0);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.Size = new System.Drawing.Size(877, 473);
            this.metroTilePanel1.TabIndex = 0;
            this.metroTilePanel1.Text = "metroTilePanel1";
            // 
            // Seguridad
            // 
            // 
            // 
            // 
            this.Seguridad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Seguridad.MultiLine = true;
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMetroUsuarios,
            this.metroTileItem2,
            this.metroTileItem3,
            this.metroTileItem4});
            this.Seguridad.Text = "Seguridad";
            // 
            // 
            // 
            this.Seguridad.TitleStyle.Class = "MetroTileGroupTitle";
            this.Seguridad.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Seguridad.TitleText = "Seguridad";
            // 
            // btnMetroUsuarios
            // 
            this.btnMetroUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMetroUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnMetroUsuarios.Image")));
            this.btnMetroUsuarios.Name = "btnMetroUsuarios";
            this.btnMetroUsuarios.SymbolColor = System.Drawing.Color.Empty;
            this.btnMetroUsuarios.Text = "Usuarios";
            this.btnMetroUsuarios.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            // 
            // 
            // 
            this.btnMetroUsuarios.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnMetroUsuarios.Click += new System.EventHandler(this.btnMetroUsuarios_Click);
            // 
            // metroTileItem3
            // 
            this.metroTileItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem3.Name = "metroTileItem3";
            this.metroTileItem3.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem4
            // 
            this.metroTileItem4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem4.Name = "metroTileItem4";
            this.metroTileItem4.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // Auditoria
            // 
            // 
            // 
            // 
            this.Auditoria.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Auditoria.MultiLine = true;
            this.Auditoria.Name = "Auditoria";
            this.Auditoria.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem5,
            this.metroTileItem6,
            this.metroTileItem7,
            this.metroTileItem8});
            // 
            // 
            // 
            this.Auditoria.TitleStyle.Class = "MetroTileGroupTitle";
            this.Auditoria.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Auditoria.TitleText = "Auditoria";
            // 
            // metroTileItem5
            // 
            this.metroTileItem5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem5.Image = ((System.Drawing.Image)(resources.GetObject("metroTileItem5.Image")));
            this.metroTileItem5.Name = "metroTileItem5";
            this.metroTileItem5.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem5.Text = "Catálogo de Estados de Login";
            this.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
            // 
            // 
            // 
            this.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem6
            // 
            this.metroTileItem6.Name = "metroTileItem6";
            this.metroTileItem6.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem7
            // 
            this.metroTileItem7.Name = "metroTileItem7";
            this.metroTileItem7.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem8
            // 
            this.metroTileItem8.Name = "metroTileItem8";
            this.metroTileItem8.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem8.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem8.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = "Ayuda";
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(1, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.SettingsButtonText = "Ajustes";
            this.metroShell1.Size = new System.Drawing.Size(877, 35);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 8;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.Text = "metroShell1";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(3, 52);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(313, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Panel de Control:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.labelX1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.metroTilePanel1);
            this.splitContainer1.Size = new System.Drawing.Size(877, 567);
            this.splitContainer1.SplitterDistance = 93;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 9;
            // 
            // timerLogin
            // 
            this.timerLogin.Interval = 200;
            this.timerLogin.Tick += new System.EventHandler(this.timerLogin_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PanelPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(879, 569);
            this.Controls.Add(this.metroShell1);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PanelPrincipal_Load_1);
            this.Resize += new System.EventHandler(this.PanelPrincipal_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
          
        private void timer2_Tick(object sender, EventArgs e)
        {
            timerLogin.Stop();
            timer2.Stop();

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

                loginForm.txtUsuario.Enabled = true;
                loginForm.txtContrasena.Enabled = true;

                loginForm.progressCircleLogin.Visible = false;
                ToastNotification.Show(this, "Datos Incorrectos, intente nuevamente", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
            }
        }

        private void timerLogin_Tick_1(object sender, EventArgs e)
        {
            loginForm.progressCircleLogin.Value += 20;
        }

        private void PanelPrincipal_Load_1(object sender, EventArgs e)
        {
            Debug.Assert(loginForm == null);
            loginForm = new LoginUsuario();
            loginForm.Commandos = _Comandos;
            this.ShowModalPanel(loginForm, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void btnMetroUsuarios_Click(object sender, EventArgs e)
        {
            Debug.Assert(formUsuarios == null);
            _Comandos.UsuarioComandos.Nuevo.Enabled = false; // Disable new client command to prevent re-entrancy
            formUsuarios = new Usuarios();
            formUsuarios.Commandos = _Comandos;
            //manda abrir el form usuario deslizadooooooo
            this.ShowModalPanel(formUsuarios, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void PanelPrincipal_Resize(object sender, EventArgs e)
        {

        }
    }
}