﻿namespace mchs_db_viewer_01
{
    partial class operatorform
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
            System.Windows.Forms.Label emTypeIDLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label regIDLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label statusIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(operatorform));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.emergenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCHSDataSet = new mchs_db_viewer_01.MCHSDataSet();
            this.regionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emergenciesComboBox = new System.Windows.Forms.ComboBox();
            this.emergTypeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emergenciesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.emergenciesTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.EmergenciesTableAdapter();
            this.tableAdapterManager = new mchs_db_viewer_01.MCHSDataSetTableAdapters.TableAdapterManager();
            this.emergTypeListTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.EmergTypeListTableAdapter();
            this.regionsTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.RegionsTableAdapter();
            this.statusListTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.StatusListTableAdapter();
            this.emergenciesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.emergenciesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.emergenciesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            emTypeIDLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            regIDLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            statusIDLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergTypeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingNavigator)).BeginInit();
            this.emergenciesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // emTypeIDLabel
            // 
            emTypeIDLabel.AutoSize = true;
            emTypeIDLabel.Location = new System.Drawing.Point(22, 35);
            emTypeIDLabel.Name = "emTypeIDLabel";
            emTypeIDLabel.Size = new System.Drawing.Size(47, 13);
            emTypeIDLabel.TabIndex = 2;
            emTypeIDLabel.Text = "Тип ЧС:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(22, 61);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(60, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Описание:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(22, 88);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(74, 13);
            startDateLabel.TabIndex = 6;
            startDateLabel.Text = "Дата начала:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(22, 114);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(92, 13);
            endDateLabel.TabIndex = 8;
            endDateLabel.Text = "Дата окончания:";
            // 
            // regIDLabel
            // 
            regIDLabel.AutoSize = true;
            regIDLabel.Location = new System.Drawing.Point(22, 139);
            regIDLabel.Name = "regIDLabel";
            regIDLabel.Size = new System.Drawing.Size(46, 13);
            regIDLabel.TabIndex = 10;
            regIDLabel.Text = "Регион:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(22, 165);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(117, 13);
            userIDLabel.TabIndex = 12;
            userIDLabel.Text = "№Уполн. сотрудника:";
            // 
            // statusIDLabel
            // 
            statusIDLabel.AutoSize = true;
            statusIDLabel.Location = new System.Drawing.Point(22, 191);
            statusIDLabel.Name = "statusIDLabel";
            statusIDLabel.Size = new System.Drawing.Size(44, 13);
            statusIDLabel.TabIndex = 14;
            statusIDLabel.Text = "Статус:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 652);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.emergenciesComboBox);
            this.tabPage1.Controls.Add(this.emergenciesDataGridView);
            this.tabPage1.Controls.Add(emTypeIDLabel);
            this.tabPage1.Controls.Add(descriptionLabel);
            this.tabPage1.Controls.Add(this.descriptionTextBox);
            this.tabPage1.Controls.Add(startDateLabel);
            this.tabPage1.Controls.Add(this.startDateDateTimePicker);
            this.tabPage1.Controls.Add(endDateLabel);
            this.tabPage1.Controls.Add(this.endDateDateTimePicker);
            this.tabPage1.Controls.Add(regIDLabel);
            this.tabPage1.Controls.Add(userIDLabel);
            this.tabPage1.Controls.Add(this.userIDTextBox);
            this.tabPage1.Controls.Add(statusIDLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица ЧС";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.emergenciesBindingSource, "RegID", true));
            this.comboBox2.DataSource = this.regionsBindingSource;
            this.comboBox2.DisplayMember = "RegName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(148, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(392, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "RegID";
            // 
            // emergenciesBindingSource
            // 
            this.emergenciesBindingSource.DataMember = "Emergencies";
            this.emergenciesBindingSource.DataSource = this.mCHSDataSet;
            // 
            // mCHSDataSet
            // 
            this.mCHSDataSet.DataSetName = "MCHSDataSet";
            this.mCHSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regionsBindingSource
            // 
            this.regionsBindingSource.DataMember = "Regions";
            this.regionsBindingSource.DataSource = this.mCHSDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.emergenciesBindingSource, "StatusID", true));
            this.comboBox1.DataSource = this.statusListBindingSource;
            this.comboBox1.DisplayMember = "Statusname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(392, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "StatusID";
            // 
            // statusListBindingSource
            // 
            this.statusListBindingSource.DataMember = "StatusList";
            this.statusListBindingSource.DataSource = this.mCHSDataSet;
            // 
            // emergenciesComboBox
            // 
            this.emergenciesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.emergenciesBindingSource, "EmTypeID", true));
            this.emergenciesComboBox.DataSource = this.emergTypeListBindingSource;
            this.emergenciesComboBox.DisplayMember = "Typename";
            this.emergenciesComboBox.FormattingEnabled = true;
            this.emergenciesComboBox.Location = new System.Drawing.Point(148, 31);
            this.emergenciesComboBox.Name = "emergenciesComboBox";
            this.emergenciesComboBox.Size = new System.Drawing.Size(392, 21);
            this.emergenciesComboBox.TabIndex = 15;
            this.emergenciesComboBox.ValueMember = "EmTypeID";
            // 
            // emergTypeListBindingSource
            // 
            this.emergTypeListBindingSource.DataMember = "EmergTypeList";
            this.emergTypeListBindingSource.DataSource = this.mCHSDataSet;
            // 
            // emergenciesDataGridView
            // 
            this.emergenciesDataGridView.AutoGenerateColumns = false;
            this.emergenciesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emergenciesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.emergenciesDataGridView.DataSource = this.emergenciesBindingSource;
            this.emergenciesDataGridView.Location = new System.Drawing.Point(6, 233);
            this.emergenciesDataGridView.Name = "emergenciesDataGridView";
            this.emergenciesDataGridView.ReadOnly = true;
            this.emergenciesDataGridView.Size = new System.Drawing.Size(1056, 387);
            this.emergenciesDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmergencyID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmTypeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код проишествия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "ДатаНачала";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "ДатаКонца";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RegID";
            this.dataGridViewTextBoxColumn6.HeaderText = "КодРегиона";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn7.HeaderText = "№Упол. сотрудника";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StatusID";
            this.dataGridViewTextBoxColumn8.HeaderText = "КодСтатуса";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emergenciesBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(148, 58);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(392, 20);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.emergenciesBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(148, 84);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(392, 20);
            this.startDateDateTimePicker.TabIndex = 7;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.emergenciesBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(148, 110);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(392, 20);
            this.endDateDateTimePicker.TabIndex = 9;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emergenciesBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(148, 162);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(392, 20);
            this.userIDTextBox.TabIndex = 13;
            // 
            // emergenciesTableAdapter
            // 
            this.emergenciesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmergenciesTableAdapter = this.emergenciesTableAdapter;
            this.tableAdapterManager.EmergTypeListTableAdapter = this.emergTypeListTableAdapter;
            this.tableAdapterManager.PositionListTableAdapter = null;
            this.tableAdapterManager.RegionsTableAdapter = this.regionsTableAdapter;
            this.tableAdapterManager.StatusListTableAdapter = this.statusListTableAdapter;
            this.tableAdapterManager.UpdateOrder = mchs_db_viewer_01.MCHSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDataTableAdapter = null;
            // 
            // emergTypeListTableAdapter
            // 
            this.emergTypeListTableAdapter.ClearBeforeFill = true;
            // 
            // regionsTableAdapter
            // 
            this.regionsTableAdapter.ClearBeforeFill = true;
            // 
            // statusListTableAdapter
            // 
            this.statusListTableAdapter.ClearBeforeFill = true;
            // 
            // emergenciesBindingNavigator
            // 
            this.emergenciesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.emergenciesBindingNavigator.BindingSource = this.emergenciesBindingSource;
            this.emergenciesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.emergenciesBindingNavigator.DeleteItem = null;
            this.emergenciesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.emergenciesBindingNavigatorSaveItem});
            this.emergenciesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.emergenciesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.emergenciesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.emergenciesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.emergenciesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.emergenciesBindingNavigator.Name = "emergenciesBindingNavigator";
            this.emergenciesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.emergenciesBindingNavigator.Size = new System.Drawing.Size(1100, 25);
            this.emergenciesBindingNavigator.TabIndex = 1;
            this.emergenciesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(158, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить новую запись";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // emergenciesBindingNavigatorSaveItem
            // 
            this.emergenciesBindingNavigatorSaveItem.CheckOnClick = true;
            this.emergenciesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("emergenciesBindingNavigatorSaveItem.Image")));
            this.emergenciesBindingNavigatorSaveItem.Name = "emergenciesBindingNavigatorSaveItem";
            this.emergenciesBindingNavigatorSaveItem.Size = new System.Drawing.Size(129, 22);
            this.emergenciesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.emergenciesBindingNavigatorSaveItem.Click += new System.EventHandler(this.emergenciesBindingNavigatorSaveItem_Click);
            // 
            // emergenciesBindingSource1
            // 
            this.emergenciesBindingSource1.DataMember = "Emergencies";
            this.emergenciesBindingSource1.DataSource = this.mCHSDataSet;
            // 
            // operatorform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 692);
            this.Controls.Add(this.emergenciesBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "operatorform";
            this.Text = "operator";
            this.Load += new System.EventHandler(this.operatorform_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergTypeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingNavigator)).EndInit();
            this.emergenciesBindingNavigator.ResumeLayout(false);
            this.emergenciesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MCHSDataSet mCHSDataSet;
        private System.Windows.Forms.BindingSource emergenciesBindingSource;
        private MCHSDataSetTableAdapters.EmergenciesTableAdapter emergenciesTableAdapter;
        private MCHSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator emergenciesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton emergenciesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView emergenciesDataGridView;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource emergenciesBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox emergenciesComboBox;
        private MCHSDataSetTableAdapters.EmergTypeListTableAdapter emergTypeListTableAdapter;
        private System.Windows.Forms.BindingSource emergTypeListBindingSource;
        private MCHSDataSetTableAdapters.RegionsTableAdapter regionsTableAdapter;
        private System.Windows.Forms.BindingSource regionsBindingSource;
        private MCHSDataSetTableAdapters.StatusListTableAdapter statusListTableAdapter;
        private System.Windows.Forms.BindingSource statusListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}