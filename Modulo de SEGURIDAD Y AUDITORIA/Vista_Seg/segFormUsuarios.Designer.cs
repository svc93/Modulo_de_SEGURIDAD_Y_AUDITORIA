﻿namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.bindingNavigatorEx1 = new DevComponents.DotNetBar.Controls.BindingNavigatorEx(this.components);
            this.bindingNavigatorCountItem = new DevComponents.DotNetBar.LabelItem();
            this.bindingNavigatorMoveFirstItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMovePreviousItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorPositionItem = new DevComponents.DotNetBar.TextBoxItem();
            this.bindingNavigatorMoveNextItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveLastItem = new DevComponents.DotNetBar.ButtonItem();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonItem();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvUsuarios = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.txtContra = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtUsuario = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCedula = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbEstado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMADataSet = new Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset.SISTEMADataSet();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cédulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstadoLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cmbEstado);
            this.panelEx1.Controls.Add(this.cmbCedula);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.label7);
            this.panelEx1.Controls.Add(this.txtContra);
            this.panelEx1.Controls.Add(this.txtUsuario);
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.btnSalir);
            this.panelEx1.Controls.Add(this.bindingNavigatorEx1);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.dgvUsuarios);
            this.panelEx1.Controls.Add(this.pictureBox1);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.line1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(681, 456);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.LightSteelBlue;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.RoyalBlue;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.HoverImage")));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(555, 14);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 53);
            this.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalir.TabIndex = 142;
            // 
            // bindingNavigatorEx1
            // 
            this.bindingNavigatorEx1.AntiAlias = true;
            this.bindingNavigatorEx1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorEx1.BindingSource = this.usuarioBindingSource1;
            this.bindingNavigatorEx1.CountLabel = this.bindingNavigatorCountItem;
            this.bindingNavigatorEx1.CountLabelFormat = "of {0}";
            this.bindingNavigatorEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorEx1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bindingNavigatorEx1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorEx1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.btnNuevo,
            this.btnGuardar,
            this.btnLimpiar,
            this.btnEliminar});
            this.bindingNavigatorEx1.Location = new System.Drawing.Point(0, 431);
            this.bindingNavigatorEx1.MoveFirstButton = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorEx1.MoveLastButton = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorEx1.MoveNextButton = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorEx1.MovePreviousButton = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorEx1.Name = "bindingNavigatorEx1";
            this.bindingNavigatorEx1.PositionTextBox = this.bindingNavigatorPositionItem;
            this.bindingNavigatorEx1.Size = new System.Drawing.Size(681, 25);
            this.bindingNavigatorEx1.Stretch = true;
            this.bindingNavigatorEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bindingNavigatorEx1.TabIndex = 141;
            this.bindingNavigatorEx1.TabStop = false;
            this.bindingNavigatorEx1.Text = "bindingNavigatorEx1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Text = "of {0}";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.BeginGroup = true;
            this.bindingNavigatorPositionItem.ButtonCustom.Tooltip = "";
            this.bindingNavigatorPositionItem.ButtonCustom2.Tooltip = "";
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Text = "-1";
            this.bindingNavigatorPositionItem.TextBoxWidth = 54;
            this.bindingNavigatorPositionItem.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.BeginGroup = true;
            this.bindingNavigatorMoveNextItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.HotFontBold = true;
            this.btnNuevo.HotFontUnderline = true;
            this.btnNuevo.HotForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.HotFontBold = true;
            this.btnGuardar.HotFontUnderline = true;
            this.btnGuardar.HotForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.HotFontBold = true;
            this.btnLimpiar.HotFontUnderline = true;
            this.btnLimpiar.HotForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.HotFontBold = true;
            this.btnEliminar.HotFontUnderline = true;
            this.btnEliminar.HotForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "Eliminar";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(3, 161);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(155, 23);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "Todos los Usuarios:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.cédulaDataGridViewTextBoxColumn,
            this.idEstadoLoginDataGridViewTextBoxColumn});
            this.dgvUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvUsuarios.DataSource = this.usuarioBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 186);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsuarios.Size = new System.Drawing.Size(681, 245);
            this.dgvUsuarios.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 48);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Lucida Sans", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(81, 14);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(221, 29);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Panel de Usuarios";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Location = new System.Drawing.Point(5, 57);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(673, 25);
            this.line1.TabIndex = 5;
            this.line1.Text = "line1";
            // 
            // txtContra
            // 
            // 
            // 
            // 
            this.txtContra.BackgroundStyle.Class = "TextBoxBorder";
            this.txtContra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContra.ButtonClear.Tooltip = "";
            this.txtContra.ButtonClear.Visible = true;
            this.txtContra.ButtonCustom.Tooltip = "";
            this.txtContra.ButtonCustom2.Tooltip = "";
            this.txtContra.ButtonDropDown.Tooltip = "";
            this.txtContra.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtContra.Location = new System.Drawing.Point(143, 121);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(219, 30);
            this.txtContra.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtContra.TabIndex = 146;
            this.txtContra.Text = "";
            this.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContra.WatermarkText = "Contraseña...";
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.BackgroundStyle.Class = "TextBoxBorder";
            this.txtUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsuario.ButtonClear.Tooltip = "";
            this.txtUsuario.ButtonClear.Visible = true;
            this.txtUsuario.ButtonCustom.Tooltip = "";
            this.txtUsuario.ButtonCustom2.Tooltip = "";
            this.txtUsuario.ButtonDropDown.Tooltip = "";
            this.txtUsuario.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtUsuario.Location = new System.Drawing.Point(143, 78);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(219, 30);
            this.txtUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtUsuario.TabIndex = 145;
            this.txtUsuario.Text = "";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.WatermarkText = "Usuario...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 144;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 143;
            this.label2.Text = "Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(374, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 147;
            this.label7.Text = "Cédula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(374, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 149;
            this.label1.Text = "Estado:";
            // 
            // cmbCedula
            // 
            this.cmbCedula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCedula.DisplayMember = "Text";
            this.cmbCedula.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCedula.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCedula.FormattingEnabled = true;
            this.cmbCedula.ItemHeight = 24;
            this.cmbCedula.Location = new System.Drawing.Point(454, 80);
            this.cmbCedula.Name = "cmbCedula";
            this.cmbCedula.Size = new System.Drawing.Size(213, 30);
            this.cmbCedula.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbCedula.TabIndex = 151;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEstado.DisplayMember = "Text";
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstado.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.ItemHeight = 24;
            this.cmbEstado.Location = new System.Drawing.Point(454, 121);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(213, 30);
            this.cmbEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbEstado.TabIndex = 152;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.sISTEMADataSet;
            // 
            // sISTEMADataSet
            // 
            this.sISTEMADataSet.DataSetName = "SISTEMADataSet";
            this.sISTEMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cédulaDataGridViewTextBoxColumn
            // 
            this.cédulaDataGridViewTextBoxColumn.DataPropertyName = "Cédula";
            this.cédulaDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cédulaDataGridViewTextBoxColumn.Name = "cédulaDataGridViewTextBoxColumn";
            this.cédulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEstadoLoginDataGridViewTextBoxColumn
            // 
            this.idEstadoLoginDataGridViewTextBoxColumn.DataPropertyName = "IdEstadoLogin";
            this.idEstadoLoginDataGridViewTextBoxColumn.HeaderText = "IdEstadoLogin";
            this.idEstadoLoginDataGridViewTextBoxColumn.Name = "idEstadoLoginDataGridViewTextBoxColumn";
            this.idEstadoLoginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panelEx1);
            this.Name = "Usuarios";
            this.Size = new System.Drawing.Size(681, 456);
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUsuarios;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cédulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset.SISTEMADataSet sISTEMADataSet;
        private DevComponents.DotNetBar.Controls.BindingNavigatorEx bindingNavigatorEx1;
        private DevComponents.DotNetBar.LabelItem bindingNavigatorCountItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveFirstItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMovePreviousItem;
        private DevComponents.DotNetBar.TextBoxItem bindingNavigatorPositionItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveNextItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveLastItem;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.ButtonItem btnLimpiar;
        private DevComponents.DotNetBar.ButtonItem btnEliminar;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtContra;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbEstado;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCedula;

    }
}
