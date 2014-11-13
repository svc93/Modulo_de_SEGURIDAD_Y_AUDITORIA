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
        CatAreas formCatAras = null;
        Empleados formEmpleados = null;

        CatEstadosLogin formCatEstadosLogin = null;

        LoginUsuario loginForm = null;

        Datos.D_Seg_Usuario ClassUser = new Datos.D_Seg_Usuario();
        Boolean loginCorrecto = false;

        public PanelPrincipal()
        {
            InitializeComponent();
            _Comandos = new MetroComandos();
             
            _Comandos.UsuarioComandos.Nuevo = new Command(components);
            _Comandos.UsuarioComandos.Nuevo.Executed += EjecutarUsuario;

            _Comandos.UsuarioComandos.Cancelar = new Command(components);
            _Comandos.UsuarioComandos.Cancelar.Executed += CancelarUsuario;

            _Comandos.UsuarioComandos.Save = new Command(components);
            _Comandos.UsuarioComandos.Save.Executed += OkUsuario;

            _Comandos.LoginComandos.Login = new Command(components);
            _Comandos.LoginComandos.Login.Executed += VerificarLogin;

            _Comandos.CatAreas.CerrarArea = new Command(components);
            _Comandos.CatAreas.CerrarArea.Executed += CerrarCarAreas;

            _Comandos.CatEstadosLogin.CerrarEstadosLogin = new Command(components);
            _Comandos.CatEstadosLogin.CerrarEstadosLogin.Executed += CerrarCatEstadosLog;

            _Comandos.Empleados.CerrarEmpleados = new Command(components);
            _Comandos.Empleados.CerrarEmpleados.Executed += CerrarEmpleados;
             
        }

        private void CerrarEmpleados(object sender, EventArgs e)
        {
            this.CloseModalPanel(formEmpleados, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            formEmpleados.Commandos = null;
            formEmpleados.Dispose();
            formEmpleados = null;
        }

        private void CerrarCatEstadosLog(object sender, EventArgs e)
        {
            this.CloseModalPanel(formCatEstadosLogin, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            formCatEstadosLogin.Commandos = null;
            formCatEstadosLogin.Dispose();
            formCatEstadosLogin = null;
        } 
        
        private void CerrarCarAreas(object sender, EventArgs e)
        {
            this.CloseModalPanel(formCatAras, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            formCatAras.Commandos = null;
            formCatAras.Dispose();
            formCatAras = null;
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
                ToastNotification.Show(this, "<h3>Completar Datos</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
            }
            else if (loginForm.txtUsuario.Text.Length <= 4 || loginForm.txtContrasena.Text.Length <= 4)
            {
                ToastNotification.Show(this, "<h3>Datos muy cortos</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
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
            this.metroCatAreas = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.Módulos = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem11 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem12 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem13 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem14 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem15 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem16 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.Seguridad = new DevComponents.DotNetBar.ItemContainer();
            this.btnMetroUsuarios = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem4 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroEmpleados = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem10 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.Auditoria = new DevComponents.DotNetBar.ItemContainer();
            this.metroCatEstLogin = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem6 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem7 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.timerLogin = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.laNombre = new DevComponents.DotNetBar.LabelX();
            this.laApellido = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroCatAreas
            // 
            this.metroCatAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroCatAreas.Image = ((System.Drawing.Image)(resources.GetObject("metroCatAreas.Image")));
            this.metroCatAreas.Name = "metroCatAreas";
            this.metroCatAreas.SymbolColor = System.Drawing.Color.Empty;
            this.metroCatAreas.Text = "Catálogo de Areas";
            this.metroCatAreas.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.metroCatAreas.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroCatAreas.Click += new System.EventHandler(this.metroCatAreas_Click);
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
            this.metroTilePanel1.ForeColor = System.Drawing.Color.Black;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Módulos,
            this.Seguridad,
            this.Auditoria});
            this.metroTilePanel1.Location = new System.Drawing.Point(0, 0);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.Size = new System.Drawing.Size(877, 474);
            this.metroTilePanel1.TabIndex = 0;
            this.metroTilePanel1.Text = "metroTilePanel1";
            // 
            // Módulos
            // 
            // 
            // 
            // 
            this.Módulos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Módulos.ItemSpacing = 7;
            this.Módulos.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.Módulos.MultiLine = true;
            this.Módulos.Name = "Módulos";
            this.Módulos.ResizeItemsToFit = false;
            this.Módulos.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem11,
            this.metroTileItem12,
            this.metroTileItem13,
            this.metroTileItem14,
            this.metroTileItem15,
            this.metroTileItem16});
            // 
            // 
            // 
            this.Módulos.TitleStyle.Class = "MetroTileGroupTitle";
            this.Módulos.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Módulos.TitleText = "Módulos";
            // 
            // metroTileItem11
            // 
            this.metroTileItem11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem11.Image = ((System.Drawing.Image)(resources.GetObject("metroTileItem11.Image")));
            this.metroTileItem11.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTileItem11.Name = "metroTileItem11";
            this.metroTileItem11.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem11.Text = "Nómina";
            this.metroTileItem11.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
            // 
            // 
            // 
            this.metroTileItem11.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem12
            // 
            this.metroTileItem12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem12.Image = ((System.Drawing.Image)(resources.GetObject("metroTileItem12.Image")));
            this.metroTileItem12.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTileItem12.Name = "metroTileItem12";
            this.metroTileItem12.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem12.Text = "Evaluación al desempeño";
            this.metroTileItem12.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.metroTileItem12.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem13
            // 
            this.metroTileItem13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem13.Name = "metroTileItem13";
            this.metroTileItem13.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem13.Text = "Acciones de RRHH";
            this.metroTileItem13.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            // 
            // 
            // 
            this.metroTileItem13.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem14
            // 
            this.metroTileItem14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem14.Name = "metroTileItem14";
            this.metroTileItem14.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem14.Text = "Contratación y Expediente";
            this.metroTileItem14.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
            // 
            // 
            // 
            this.metroTileItem14.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem15
            // 
            this.metroTileItem15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem15.Image = ((System.Drawing.Image)(resources.GetObject("metroTileItem15.Image")));
            this.metroTileItem15.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTileItem15.Name = "metroTileItem15";
            this.metroTileItem15.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem15.Text = "Selección";
            this.metroTileItem15.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.metroTileItem15.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem16
            // 
            this.metroTileItem16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem16.Image = ((System.Drawing.Image)(resources.GetObject("metroTileItem16.Image")));
            this.metroTileItem16.Name = "metroTileItem16";
            this.metroTileItem16.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem16.Text = "Gestión de Capacitaciones";
            this.metroTileItem16.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem16.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // Seguridad
            // 
            // 
            // 
            // 
            this.Seguridad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Seguridad.ItemSpacing = 7;
            this.Seguridad.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.Seguridad.MultiLine = true;
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMetroUsuarios,
            this.metroCatAreas,
            this.metroTileItem3,
            this.metroTileItem4,
            this.metroTileItem1,
            this.metroEmpleados,
            this.metroTileItem10});
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
            this.metroTileItem3.Text = "Permisos Roles";
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
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
            this.metroTileItem4.Text = "Roles de Usuario";
            this.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
            // 
            // 
            // 
            this.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem1.Text = "Exportar Usuarios Bloqueados";
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroEmpleados
            // 
            this.metroEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("metroEmpleados.Image")));
            this.metroEmpleados.Name = "metroEmpleados";
            this.metroEmpleados.SymbolColor = System.Drawing.Color.Empty;
            this.metroEmpleados.Text = "Empleados";
            this.metroEmpleados.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            // 
            // 
            // 
            this.metroEmpleados.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroEmpleados.Click += new System.EventHandler(this.metroEmpleados_Click);
            // 
            // metroTileItem10
            // 
            this.metroTileItem10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem10.Image = ((System.Drawing.Image)(resources.GetObject("metroTileItem10.Image")));
            this.metroTileItem10.Name = "metroTileItem10";
            this.metroTileItem10.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem10.Text = "Respaldos";
            this.metroTileItem10.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
            // 
            // 
            // 
            this.metroTileItem10.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // Auditoria
            // 
            // 
            // 
            // 
            this.Auditoria.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Auditoria.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.Auditoria.MultiLine = true;
            this.Auditoria.Name = "Auditoria";
            this.Auditoria.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroCatEstLogin,
            this.metroTileItem6,
            this.metroTileItem7});
            // 
            // 
            // 
            this.Auditoria.TitleStyle.Class = "MetroTileGroupTitle";
            this.Auditoria.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Auditoria.TitleText = "Auditoria";
            // 
            // metroCatEstLogin
            // 
            this.metroCatEstLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroCatEstLogin.Image = ((System.Drawing.Image)(resources.GetObject("metroCatEstLogin.Image")));
            this.metroCatEstLogin.Name = "metroCatEstLogin";
            this.metroCatEstLogin.SymbolColor = System.Drawing.Color.Empty;
            this.metroCatEstLogin.Text = "Catálogo de Estados de Login";
            this.metroCatEstLogin.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
            // 
            // 
            // 
            this.metroCatEstLogin.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroCatEstLogin.Click += new System.EventHandler(this.metroCatEstLogin_Click);
            // 
            // metroTileItem6
            // 
            this.metroTileItem6.Name = "metroTileItem6";
            this.metroTileItem6.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem6.Text = "Auditar Usuario";
            this.metroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellowish;
            // 
            // 
            // 
            this.metroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem7
            // 
            this.metroTileItem7.Name = "metroTileItem7";
            this.metroTileItem7.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem7.Text = "ETC";
            this.metroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
            // 
            // 
            // 
            this.metroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
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
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(3, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(254, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Panel de Control:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Location = new System.Drawing.Point(1, 34);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.laApellido);
            this.splitContainer1.Panel1.Controls.Add(this.laNombre);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.labelX1);
            this.splitContainer1.Panel1.Controls.Add(this.line1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.splitContainer1.Panel2.Controls.Add(this.metroTilePanel1);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Size = new System.Drawing.Size(877, 534);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(777, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 59);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // line1
            // 
            this.line1.ForeColor = System.Drawing.Color.Black;
            this.line1.Location = new System.Drawing.Point(0, 50);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(877, 10);
            this.line1.TabIndex = 1;
            this.line1.Text = "line1";
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
            // laNombre
            // 
            // 
            // 
            // 
            this.laNombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.laNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNombre.Location = new System.Drawing.Point(594, 3);
            this.laNombre.Name = "laNombre";
            this.laNombre.Size = new System.Drawing.Size(177, 23);
            this.laNombre.TabIndex = 3;
            this.laNombre.Text = "Nombre";
            this.laNombre.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // laApellido
            // 
            // 
            // 
            // 
            this.laApellido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.laApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laApellido.Location = new System.Drawing.Point(594, 31);
            this.laApellido.Name = "laApellido";
            this.laApellido.Size = new System.Drawing.Size(177, 23);
            this.laApellido.TabIndex = 4;
            this.laApellido.Text = "Apellido";
            this.laApellido.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // PanelPrincipal
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 569);
            this.Controls.Add(this.metroShell1);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "PanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PanelPrincipal_Load_1);
            this.Resize += new System.EventHandler(this.PanelPrincipal_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
                laApellido.Text = ClassUser.apellidos;
                laNombre.Text = ClassUser.nombres;
            }
            else
            {
                loginForm.btnCancelar.Visible = true;
                loginForm.btnEntrar.Visible = true;

                loginForm.txtUsuario.Enabled = true;
                loginForm.txtContrasena.Enabled = true;

                loginForm.progressCircleLogin.Visible = false;
                ToastNotification.Show(this, "<h3>Datos Incorrectos, intente nuevamente</h3>", null, 2000, (eToastGlowColor)(eToastGlowColor.Red), (eToastPosition)(eToastPosition.BottomCenter));
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

        private void metroCatAreas_Click(object sender, EventArgs e)
        {
            Debug.Assert(formCatAras == null);
            formCatAras = new CatAreas();
            formCatAras.Commandos = _Comandos; 
            this.ShowModalPanel(formCatAras, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void metroCatEstLogin_Click(object sender, EventArgs e)
        {
            Debug.Assert(formCatEstadosLogin == null);
            formCatEstadosLogin = new CatEstadosLogin();
            formCatEstadosLogin.Commandos = _Comandos;
            this.ShowModalPanel(formCatEstadosLogin, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void metroEmpleados_Click(object sender, EventArgs e)
        {
            Debug.Assert(formEmpleados == null);
            formEmpleados = new Empleados();
            formEmpleados.Commandos = _Comandos;
            this.ShowModalPanel(formEmpleados, DevComponents.DotNetBar.Controls.eSlideSide.Left);
       
        }
    
    }
}