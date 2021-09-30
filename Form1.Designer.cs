
namespace TempProjet
{
    partial class Form1
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label enrollLabel;
            System.Windows.Forms.Label courseLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tempTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tempTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempDataSet = new TempProjet.TempDataSet();
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
            this.tempTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyberSecurityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataStructuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aIMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.enrollTextBox = new System.Windows.Forms.TextBox();
            this.insertbutton = new System.Windows.Forms.Button();
            this.tempTableTableAdapter = new TempProjet.TempDataSetTableAdapters.TempTableTableAdapter();
            this.tableAdapterManager = new TempProjet.TempDataSetTableAdapters.TableAdapterManager();
            this.tempDataSet1 = new TempProjet.TempDataSet();
            this.tempTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tempTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tempDBDataSet = new TempProjet.TempDBDataSet();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.tempTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.tempTableTableAdapter1 = new TempProjet.TempDBDataSetTableAdapters.TempTableTableAdapter();
            this.tableAdapterManager1 = new TempProjet.TempDBDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.courseTempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTempTableAdapter = new TempProjet.TempDBDataSetTableAdapters.courseTempTableAdapter();
            this.tempDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cEnrolltxt = new System.Windows.Forms.TextBox();
            this.sEnrolltxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempTableDataGridView = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            enrollLabel = new System.Windows.Forms.Label();
            courseLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tempTableBindingNavigator)).BeginInit();
            this.tempTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(82, 82);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // enrollLabel
            // 
            enrollLabel.AutoSize = true;
            enrollLabel.Location = new System.Drawing.Point(83, 123);
            enrollLabel.Name = "enrollLabel";
            enrollLabel.Size = new System.Drawing.Size(48, 17);
            enrollLabel.TabIndex = 4;
            enrollLabel.Text = "Enroll:";
            // 
            // courseLabel2
            // 
            courseLabel2.AutoSize = true;
            courseLabel2.Location = new System.Drawing.Point(82, 162);
            courseLabel2.Name = "courseLabel2";
            courseLabel2.Size = new System.Drawing.Size(57, 17);
            courseLabel2.TabIndex = 15;
            courseLabel2.Text = "Course:";
            courseLabel2.Click += new System.EventHandler(this.courseLabel2_Click);
            // 
            // tempTableBindingNavigator
            // 
            this.tempTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tempTableBindingNavigator.BindingSource = this.tempTableBindingSource;
            this.tempTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tempTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tempTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tempTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.tempTableBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.tempTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tempTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tempTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tempTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tempTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tempTableBindingNavigator.Name = "tempTableBindingNavigator";
            this.tempTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tempTableBindingNavigator.Size = new System.Drawing.Size(965, 27);
            this.tempTableBindingNavigator.TabIndex = 0;
            this.tempTableBindingNavigator.Text = "bindingNavigator1";
            this.tempTableBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tempTableBindingSource
            // 
            this.tempTableBindingSource.DataMember = "TempTable";
            this.tempTableBindingSource.DataSource = this.tempDataSet;
            // 
            // tempDataSet
            // 
            this.tempDataSet.DataSetName = "TempDataSet";
            this.tempDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tempTableBindingNavigatorSaveItem
            // 
            this.tempTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tempTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tempTableBindingNavigatorSaveItem.Image")));
            this.tempTableBindingNavigatorSaveItem.Name = "tempTableBindingNavigatorSaveItem";
            this.tempTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tempTableBindingNavigatorSaveItem.Text = "Save Data";
            this.tempTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tempTableBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDAToolStripMenuItem,
            this.aDCToolStripMenuItem,
            this.cyberSecurityToolStripMenuItem,
            this.dataStructuresToolStripMenuItem,
            this.aIMLToolStripMenuItem});
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // aDAToolStripMenuItem
            // 
            this.aDAToolStripMenuItem.Name = "aDAToolStripMenuItem";
            this.aDAToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.aDAToolStripMenuItem.Text = "ADA";
            // 
            // aDCToolStripMenuItem
            // 
            this.aDCToolStripMenuItem.Name = "aDCToolStripMenuItem";
            this.aDCToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.aDCToolStripMenuItem.Text = "ADC";
            // 
            // cyberSecurityToolStripMenuItem
            // 
            this.cyberSecurityToolStripMenuItem.Name = "cyberSecurityToolStripMenuItem";
            this.cyberSecurityToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.cyberSecurityToolStripMenuItem.Text = "Cyber security";
            // 
            // dataStructuresToolStripMenuItem
            // 
            this.dataStructuresToolStripMenuItem.Name = "dataStructuresToolStripMenuItem";
            this.dataStructuresToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.dataStructuresToolStripMenuItem.Text = "Data Structures";
            // 
            // aIMLToolStripMenuItem
            // 
            this.aIMLToolStripMenuItem.Name = "aIMLToolStripMenuItem";
            this.aIMLToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.aIMLToolStripMenuItem.Text = "AI ML";
            // 
            // nameTextBox
            // 
            this.nameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tempTableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(164, 79);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(196, 22);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.WordWrap = false;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // enrollTextBox
            // 
            this.enrollTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tempTableBindingSource, "Enroll", true));
            this.enrollTextBox.Location = new System.Drawing.Point(164, 120);
            this.enrollTextBox.Name = "enrollTextBox";
            this.enrollTextBox.Size = new System.Drawing.Size(196, 22);
            this.enrollTextBox.TabIndex = 5;
            this.enrollTextBox.WordWrap = false;
            this.enrollTextBox.TextChanged += new System.EventHandler(this.enrollTextBox_TextChanged);
            this.enrollTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.enrollTextBox_Validating);
            // 
            // insertbutton
            // 
            this.insertbutton.AutoEllipsis = true;
            this.insertbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.insertbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.insertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertbutton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.insertbutton.Location = new System.Drawing.Point(164, 201);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(92, 27);
            this.insertbutton.TabIndex = 6;
            this.insertbutton.Text = "Register";
            this.insertbutton.UseVisualStyleBackColor = false;
            this.insertbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tempTableTableAdapter
            // 
            this.tempTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TempTableTableAdapter = this.tempTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = TempProjet.TempDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tempDataSet1
            // 
            this.tempDataSet1.DataSetName = "TempDataSet";
            this.tempDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tempTableBindingSource1
            // 
            this.tempTableBindingSource1.DataMember = "TempTable";
            this.tempTableBindingSource1.DataSource = this.tempDataSet1;
            // 
            // tempTableBindingSource3
            // 
            this.tempTableBindingSource3.DataMember = "TempTable";
            this.tempTableBindingSource3.DataSource = this.tempDBDataSet;
            // 
            // tempDBDataSet
            // 
            this.tempDBDataSet.DataSetName = "TempDBDataSet";
            this.tempDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.DarkGray;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletebutton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.deletebutton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.deletebutton.Location = new System.Drawing.Point(271, 201);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(91, 27);
            this.deletebutton.TabIndex = 11;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.AutoEllipsis = true;
            this.updatebutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.updatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatebutton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.updatebutton.Location = new System.Drawing.Point(163, 468);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(199, 27);
            this.updatebutton.TabIndex = 12;
            this.updatebutton.Text = "CountCoursesEnrolled";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // courseComboBox
            // 
            this.courseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tempTableBindingSource2, "Course", true));
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Items.AddRange(new object[] {
            "DataStructures",
            "SQL",
            "Automation",
            "CyberSecurity"});
            this.courseComboBox.Location = new System.Drawing.Point(164, 162);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(198, 24);
            this.courseComboBox.TabIndex = 16;
            this.courseComboBox.SelectedIndexChanged += new System.EventHandler(this.courseComboBox_SelectedIndexChanged);
            // 
            // tempTableBindingSource2
            // 
            this.tempTableBindingSource2.DataMember = "TempTable";
            this.tempTableBindingSource2.DataSource = this.tempDBDataSet;
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // tempTableTableAdapter1
            // 
            this.tempTableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.courseTempTableAdapter = null;
            this.tableAdapterManager1.TempTableTableAdapter = this.tempTableTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = TempProjet.TempDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(162, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "CountStudentsEnrolled";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // courseTempBindingSource
            // 
            this.courseTempBindingSource.DataMember = "courseTemp";
            this.courseTempBindingSource.DataSource = this.tempDBDataSet;
            // 
            // courseTempTableAdapter
            // 
            this.courseTempTableAdapter.ClearBeforeFill = true;
            // 
            // tempDBDataSetBindingSource
            // 
            this.tempDBDataSetBindingSource.DataSource = this.tempDBDataSet;
            this.tempDBDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "CoursesEnrolled:";
            // 
            // cEnrolltxt
            // 
            this.cEnrolltxt.Location = new System.Drawing.Point(163, 423);
            this.cEnrolltxt.Name = "cEnrolltxt";
            this.cEnrolltxt.Size = new System.Drawing.Size(197, 22);
            this.cEnrolltxt.TabIndex = 19;
            this.cEnrolltxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sEnrolltxt
            // 
            this.sEnrolltxt.Location = new System.Drawing.Point(163, 319);
            this.sEnrolltxt.Name = "sEnrolltxt";
            this.sEnrolltxt.Size = new System.Drawing.Size(197, 22);
            this.sEnrolltxt.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "StudentsEnrolled:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "-------------------------New Registration-------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "---------------------Registration Status---------------------";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn4.HeaderText = "Course";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Enroll";
            this.dataGridViewTextBoxColumn3.HeaderText = "Enroll";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tempTableDataGridView
            // 
            this.tempTableDataGridView.AutoGenerateColumns = false;
            this.tempTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tempTableDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tempTableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tempTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tempTableDataGridView.DataSource = this.tempTableBindingSource3;
            this.tempTableDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.tempTableDataGridView.Location = new System.Drawing.Point(551, 0);
            this.tempTableDataGridView.Name = "tempTableDataGridView";
            this.tempTableDataGridView.RowHeadersWidth = 51;
            this.tempTableDataGridView.RowTemplate.Height = 24;
            this.tempTableDataGridView.Size = new System.Drawing.Size(431, 653);
            this.tempTableDataGridView.TabIndex = 8;
            this.tempTableDataGridView.AllowUserToOrderColumnsChanged += new System.EventHandler(this.Form1_Load);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Exit.Location = new System.Drawing.Point(191, 540);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(147, 39);
            this.Exit.TabIndex = 24;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.ControlBox = false;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sEnrolltxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cEnrolltxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(courseLabel2);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.tempTableDataGridView);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(enrollLabel);
            this.Controls.Add(this.enrollTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.tempTableBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(50, 50);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRATION FORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempTableBindingNavigator)).EndInit();
            this.tempTableBindingNavigator.ResumeLayout(false);
            this.tempTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TempDataSet tempDataSet;
        private System.Windows.Forms.BindingSource tempTableBindingSource;
        private TempDataSetTableAdapters.TempTableTableAdapter tempTableTableAdapter;
        private TempDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tempTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tempTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox enrollTextBox;
        private System.Windows.Forms.Button insertbutton;
        private TempDataSet tempDataSet1;
        private System.Windows.Forms.BindingSource tempTableBindingSource1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private TempDBDataSet tempDBDataSet;
        private System.Windows.Forms.BindingSource tempTableBindingSource2;
        private TempDBDataSetTableAdapters.TempTableTableAdapter tempTableTableAdapter1;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private TempDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource tempTableBindingSource3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyberSecurityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataStructuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aIMLToolStripMenuItem;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource courseTempBindingSource;
        private TempDBDataSetTableAdapters.courseTempTableAdapter courseTempTableAdapter;
        private System.Windows.Forms.BindingSource tempDBDataSetBindingSource;
        private System.Windows.Forms.TextBox cEnrolltxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sEnrolltxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tempTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button Exit;
    }
}

