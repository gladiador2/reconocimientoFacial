namespace Reconocimiento_facial
{
    partial class UsuariosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label rolIdLabel;
            System.Windows.Forms.Label usernsmeLabel;
            System.Windows.Forms.Label contrasenhaLabel;
            System.Windows.Forms.Label personaIDLabel;
            System.Windows.Forms.Label cILabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reconocimientoDataSet = new Reconocimiento_facial.ReconocimientoDataSet();
            this.personasTableAdapter = new Reconocimiento_facial.ReconocimientoDataSetTableAdapters.PersonasTableAdapter();
            this.tableAdapterManager = new Reconocimiento_facial.ReconocimientoDataSetTableAdapters.TableAdapterManager();
            this.usuariosTableAdapter = new Reconocimiento_facial.ReconocimientoDataSetTableAdapters.UsuariosTableAdapter();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Reconocimiento_facial.ReconocimientoDataSetTableAdapters.RolesTableAdapter();
            this.rjPanel3 = new Reconocimiento_facial.RJControls.rjPanel();
            this.btnActualizarContraseña = new Reconocimiento_facial.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConRepetir = new Reconocimiento_facial.RJControls.RJTextBox();
            this.txtConNueva = new Reconocimiento_facial.RJControls.RJTextBox();
            this.txtConActual = new Reconocimiento_facial.RJControls.RJTextBox();
            this.rjPanel2 = new Reconocimiento_facial.RJControls.rjPanel();
            this.cboPersonas = new System.Windows.Forms.ComboBox();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new Reconocimiento_facial.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarPersona = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.rolIdTextBox = new System.Windows.Forms.TextBox();
            this.usernsmeTextBox = new System.Windows.Forms.TextBox();
            this.contrasenhaTextBox = new System.Windows.Forms.TextBox();
            this.personaIDTextBox = new System.Windows.Forms.TextBox();
            this.rjPanel1 = new Reconocimiento_facial.RJControls.rjPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.cITextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            rolIdLabel = new System.Windows.Forms.Label();
            usernsmeLabel = new System.Windows.Forms.Label();
            contrasenhaLabel = new System.Windows.Forms.Label();
            personaIDLabel = new System.Windows.Forms.Label();
            cILabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reconocimientoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.rjPanel3.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "Personas";
            this.personasBindingSource.DataSource = this.reconocimientoDataSet;
            // 
            // reconocimientoDataSet
            // 
            this.reconocimientoDataSet.DataSetName = "ReconocimientoDataSet";
            this.reconocimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AntecedentesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CiudadTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.FotosTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = null;
            this.tableAdapterManager.PermisosPorRolesTableAdapter = null;
            this.tableAdapterManager.PermisosTableAdapter = null;
            this.tableAdapterManager.PersonasTableAdapter = this.personasTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Reconocimiento_facial.ReconocimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.reconocimientoDataSet;
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AutoGenerateColumns = false;
            this.usuariosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.usuariosDataGridView.DataSource = this.usuariosBindingSource;
            this.usuariosDataGridView.Location = new System.Drawing.Point(59, 324);
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.RowHeadersVisible = false;
            this.usuariosDataGridView.Size = new System.Drawing.Size(508, 220);
            this.usuariosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Usernsme";
            this.dataGridViewTextBoxColumn3.HeaderText = "Username";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 400;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.usuariosBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1014, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.reconocimientoDataSet;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // rjPanel3
            // 
            this.rjPanel3.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rjPanel3.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rjPanel3.Controls.Add(this.btnActualizarContraseña);
            this.rjPanel3.Controls.Add(this.label3);
            this.rjPanel3.Controls.Add(this.txtConRepetir);
            this.rjPanel3.Controls.Add(this.txtConNueva);
            this.rjPanel3.Controls.Add(this.txtConActual);
            this.rjPanel3.Location = new System.Drawing.Point(773, 36);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(200, 228);
            this.rjPanel3.TabIndex = 3;
            // 
            // btnActualizarContraseña
            // 
            this.btnActualizarContraseña.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnActualizarContraseña.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnActualizarContraseña.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizarContraseña.BorderRadius = 0;
            this.btnActualizarContraseña.BorderSize = 0;
            this.btnActualizarContraseña.FlatAppearance.BorderSize = 0;
            this.btnActualizarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarContraseña.ForeColor = System.Drawing.Color.White;
            this.btnActualizarContraseña.Location = new System.Drawing.Point(23, 174);
            this.btnActualizarContraseña.Name = "btnActualizarContraseña";
            this.btnActualizarContraseña.Size = new System.Drawing.Size(150, 40);
            this.btnActualizarContraseña.TabIndex = 17;
            this.btnActualizarContraseña.Text = "Actualizar";
            this.btnActualizarContraseña.TextColor = System.Drawing.Color.White;
            this.btnActualizarContraseña.UseVisualStyleBackColor = false;
            this.btnActualizarContraseña.Click += new System.EventHandler(this.btnActualizarContraseña_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Contraseña";
            // 
            // txtConRepetir
            // 
            this.txtConRepetir.BackColor = System.Drawing.SystemColors.Window;
            this.txtConRepetir.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtConRepetir.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtConRepetir.BorderRadius = 0;
            this.txtConRepetir.BorderSize = 2;
            this.txtConRepetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConRepetir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConRepetir.Location = new System.Drawing.Point(14, 136);
            this.txtConRepetir.Margin = new System.Windows.Forms.Padding(4);
            this.txtConRepetir.Multiline = false;
            this.txtConRepetir.Name = "txtConRepetir";
            this.txtConRepetir.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConRepetir.PasswordChar = true;
            this.txtConRepetir.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConRepetir.PlaceholderText = "Repetir Contraseña";
            this.txtConRepetir.Size = new System.Drawing.Size(171, 31);
            this.txtConRepetir.TabIndex = 2;
            this.txtConRepetir.Texts = "";
            this.txtConRepetir.UnderlinedStyle = false;
            // 
            // txtConNueva
            // 
            this.txtConNueva.BackColor = System.Drawing.SystemColors.Window;
            this.txtConNueva.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtConNueva.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtConNueva.BorderRadius = 0;
            this.txtConNueva.BorderSize = 2;
            this.txtConNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConNueva.Location = new System.Drawing.Point(14, 97);
            this.txtConNueva.Margin = new System.Windows.Forms.Padding(4);
            this.txtConNueva.Multiline = false;
            this.txtConNueva.Name = "txtConNueva";
            this.txtConNueva.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConNueva.PasswordChar = true;
            this.txtConNueva.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConNueva.PlaceholderText = "Nueva Contraseña";
            this.txtConNueva.Size = new System.Drawing.Size(171, 31);
            this.txtConNueva.TabIndex = 1;
            this.txtConNueva.Texts = "";
            this.txtConNueva.UnderlinedStyle = false;
            // 
            // txtConActual
            // 
            this.txtConActual.BackColor = System.Drawing.SystemColors.Window;
            this.txtConActual.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtConActual.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtConActual.BorderRadius = 0;
            this.txtConActual.BorderSize = 2;
            this.txtConActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConActual.Location = new System.Drawing.Point(14, 57);
            this.txtConActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtConActual.Multiline = false;
            this.txtConActual.Name = "txtConActual";
            this.txtConActual.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConActual.PasswordChar = true;
            this.txtConActual.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConActual.PlaceholderText = "Contraseña Actual";
            this.txtConActual.Size = new System.Drawing.Size(171, 31);
            this.txtConActual.TabIndex = 0;
            this.txtConActual.Texts = "";
            this.txtConActual.UnderlinedStyle = false;
            // 
            // rjPanel2
            // 
            this.rjPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rjPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rjPanel2.Controls.Add(this.cboPersonas);
            this.rjPanel2.Controls.Add(this.rolComboBox);
            this.rjPanel2.Controls.Add(this.btnGuardar);
            this.rjPanel2.Controls.Add(this.label2);
            this.rjPanel2.Controls.Add(this.txtBuscarPersona);
            this.rjPanel2.Controls.Add(idLabel);
            this.rjPanel2.Controls.Add(this.idTextBox1);
            this.rjPanel2.Controls.Add(rolIdLabel);
            this.rjPanel2.Controls.Add(this.rolIdTextBox);
            this.rjPanel2.Controls.Add(usernsmeLabel);
            this.rjPanel2.Controls.Add(this.usernsmeTextBox);
            this.rjPanel2.Controls.Add(contrasenhaLabel);
            this.rjPanel2.Controls.Add(this.contrasenhaTextBox);
            this.rjPanel2.Controls.Add(personaIDLabel);
            this.rjPanel2.Controls.Add(this.personaIDTextBox);
            this.rjPanel2.Location = new System.Drawing.Point(441, 35);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(292, 229);
            this.rjPanel2.TabIndex = 2;
            // 
            // cboPersonas
            // 
            this.cboPersonas.DropDownHeight = 200;
            this.cboPersonas.FormattingEnabled = true;
            this.cboPersonas.IntegralHeight = false;
            this.cboPersonas.Location = new System.Drawing.Point(164, 109);
            this.cboPersonas.Name = "cboPersonas";
            this.cboPersonas.Size = new System.Drawing.Size(110, 21);
            this.cboPersonas.TabIndex = 18;
            this.cboPersonas.SelectedValueChanged += new System.EventHandler(this.cboPersonas_SelectedValueChanged);
            // 
            // rolComboBox
            // 
            this.rolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "Rol", true));
            this.rolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rolesBindingSource, "id", true));
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Location = new System.Drawing.Point(98, 85);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(176, 21);
            this.rolComboBox.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(98, 175);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Datos de usuario";
            // 
            // txtBuscarPersona
            // 
            this.txtBuscarPersona.Location = new System.Drawing.Point(98, 111);
            this.txtBuscarPersona.Name = "txtBuscarPersona";
            this.txtBuscarPersona.Size = new System.Drawing.Size(59, 20);
            this.txtBuscarPersona.TabIndex = 12;
            this.txtBuscarPersona.TextChanged += new System.EventHandler(this.txtBuscarPersona_TextChanged);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(386, 45);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "id:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "id", true));
            this.idTextBox1.Location = new System.Drawing.Point(462, 42);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idTextBox1.TabIndex = 1;
            this.idTextBox1.TextChanged += new System.EventHandler(this.idTextBox1_TextChanged);
            // 
            // rolIdLabel
            // 
            rolIdLabel.AutoSize = true;
            rolIdLabel.BackColor = System.Drawing.Color.Transparent;
            rolIdLabel.Location = new System.Drawing.Point(22, 88);
            rolIdLabel.Name = "rolIdLabel";
            rolIdLabel.Size = new System.Drawing.Size(26, 13);
            rolIdLabel.TabIndex = 2;
            rolIdLabel.Text = "Rol:";
            // 
            // rolIdTextBox
            // 
            this.rolIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "RolId", true));
            this.rolIdTextBox.Location = new System.Drawing.Point(462, 68);
            this.rolIdTextBox.Name = "rolIdTextBox";
            this.rolIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.rolIdTextBox.TabIndex = 3;
            // 
            // usernsmeLabel
            // 
            usernsmeLabel.AutoSize = true;
            usernsmeLabel.BackColor = System.Drawing.Color.Transparent;
            usernsmeLabel.Location = new System.Drawing.Point(22, 61);
            usernsmeLabel.Name = "usernsmeLabel";
            usernsmeLabel.Size = new System.Drawing.Size(58, 13);
            usernsmeLabel.TabIndex = 4;
            usernsmeLabel.Text = "Username:";
            // 
            // usernsmeTextBox
            // 
            this.usernsmeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Usernsme", true));
            this.usernsmeTextBox.Location = new System.Drawing.Point(98, 58);
            this.usernsmeTextBox.Name = "usernsmeTextBox";
            this.usernsmeTextBox.Size = new System.Drawing.Size(121, 20);
            this.usernsmeTextBox.TabIndex = 5;
            // 
            // contrasenhaLabel
            // 
            contrasenhaLabel.AutoSize = true;
            contrasenhaLabel.Location = new System.Drawing.Point(387, 110);
            contrasenhaLabel.Name = "contrasenhaLabel";
            contrasenhaLabel.Size = new System.Drawing.Size(70, 13);
            contrasenhaLabel.TabIndex = 6;
            contrasenhaLabel.Text = "Contrasenha:";
            // 
            // contrasenhaTextBox
            // 
            this.contrasenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Contrasenha", true));
            this.contrasenhaTextBox.Location = new System.Drawing.Point(463, 107);
            this.contrasenhaTextBox.Name = "contrasenhaTextBox";
            this.contrasenhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.contrasenhaTextBox.TabIndex = 7;
            // 
            // personaIDLabel
            // 
            personaIDLabel.AutoSize = true;
            personaIDLabel.BackColor = System.Drawing.Color.Transparent;
            personaIDLabel.Location = new System.Drawing.Point(22, 115);
            personaIDLabel.Name = "personaIDLabel";
            personaIDLabel.Size = new System.Drawing.Size(49, 13);
            personaIDLabel.TabIndex = 8;
            personaIDLabel.Text = "Persona:";
            // 
            // personaIDTextBox
            // 
            this.personaIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "personaID", true));
            this.personaIDTextBox.Location = new System.Drawing.Point(463, 146);
            this.personaIDTextBox.Name = "personaIDTextBox";
            this.personaIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.personaIDTextBox.TabIndex = 9;
            this.personaIDTextBox.TextChanged += new System.EventHandler(this.personaIDTextBox_TextChanged);
            // 
            // rjPanel1
            // 
            this.rjPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rjPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rjPanel1.Controls.Add(this.label1);
            this.rjPanel1.Controls.Add(this.idTextBox);
            this.rjPanel1.Controls.Add(cILabel);
            this.rjPanel1.Controls.Add(this.cITextBox);
            this.rjPanel1.Controls.Add(nombreLabel);
            this.rjPanel1.Controls.Add(this.nombreTextBox);
            this.rjPanel1.Controls.Add(apellidoLabel);
            this.rjPanel1.Controls.Add(this.apellidoTextBox);
            this.rjPanel1.Controls.Add(telefonoLabel);
            this.rjPanel1.Controls.Add(this.telefonoTextBox);
            this.rjPanel1.Controls.Add(emailLabel);
            this.rjPanel1.Controls.Add(this.emailTextBox);
            this.rjPanel1.Enabled = false;
            this.rjPanel1.Location = new System.Drawing.Point(26, 35);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(375, 229);
            this.rjPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Datos de persona";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(390, 46);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // cILabel
            // 
            cILabel.AutoSize = true;
            cILabel.BackColor = System.Drawing.Color.Transparent;
            cILabel.Location = new System.Drawing.Point(15, 61);
            cILabel.Name = "cILabel";
            cILabel.Size = new System.Drawing.Size(20, 13);
            cILabel.TabIndex = 2;
            cILabel.Text = "CI:";
            // 
            // cITextBox
            // 
            this.cITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "CI", true));
            this.cITextBox.Location = new System.Drawing.Point(117, 58);
            this.cITextBox.Name = "cITextBox";
            this.cITextBox.Size = new System.Drawing.Size(200, 20);
            this.cITextBox.TabIndex = 3;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(15, 87);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(117, 84);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.BackColor = System.Drawing.Color.Transparent;
            apellidoLabel.Location = new System.Drawing.Point(15, 113);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 6;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(117, 110);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidoTextBox.TabIndex = 7;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = System.Drawing.Color.Transparent;
            telefonoLabel.Location = new System.Drawing.Point(15, 139);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 8;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(117, 136);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 9;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Location = new System.Drawing.Point(15, 168);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(117, 165);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1014, 589);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.rjPanel3);
            this.Controls.Add(this.rjPanel2);
            this.Controls.Add(this.usuariosDataGridView);
            this.Controls.Add(this.rjPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reconocimientoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.rjPanel3.ResumeLayout(false);
            this.rjPanel3.PerformLayout();
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJControls.rjPanel rjPanel1;
        private ReconocimientoDataSet reconocimientoDataSet;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private ReconocimientoDataSetTableAdapters.PersonasTableAdapter personasTableAdapter;
        private ReconocimientoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox cITextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private ReconocimientoDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private RJControls.rjPanel rjPanel2;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox rolIdTextBox;
        private System.Windows.Forms.TextBox usernsmeTextBox;
        private System.Windows.Forms.TextBox contrasenhaTextBox;
        private System.Windows.Forms.TextBox personaIDTextBox;
        private System.Windows.Forms.TextBox txtBuscarPersona;
        private RJControls.rjPanel rjPanel3;
        private RJControls.RJTextBox txtConRepetir;
        private RJControls.RJTextBox txtConNueva;
        private RJControls.RJTextBox txtConActual;
        private RJControls.RJButton btnGuardar;
        private System.Windows.Forms.Label label2;
        private RJControls.RJButton btnActualizarContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private ReconocimientoDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.ComboBox cboPersonas;
    }
}