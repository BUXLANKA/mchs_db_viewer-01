namespace mchs_db_viewer_01
{
    partial class adminform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminform));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.emergenciesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCHSDataSet = new mchs_db_viewer_01.MCHSDataSet();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.emergenciesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.emergenciesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.emergenciesTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.EmergenciesTableAdapter();
            this.tableAdapterManager = new mchs_db_viewer_01.MCHSDataSetTableAdapters.TableAdapterManager();
            this.emergenciesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emergenciesComboBox = new System.Windows.Forms.ComboBox();
            this.regionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionsTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.RegionsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusListTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.StatusListTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.emergTypeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emergTypeListTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.EmergTypeListTableAdapter();
            emTypeIDLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            regIDLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            statusIDLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingNavigator)).BeginInit();
            this.emergenciesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergTypeListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emTypeIDLabel
            // 
            emTypeIDLabel.AutoSize = true;
            emTypeIDLabel.Location = new System.Drawing.Point(25, 67);
            emTypeIDLabel.Name = "emTypeIDLabel";
            emTypeIDLabel.Size = new System.Drawing.Size(66, 13);
            emTypeIDLabel.TabIndex = 2;
            emTypeIDLabel.Text = "Em Type ID:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(25, 93);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(25, 120);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 6;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(25, 146);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(55, 13);
            endDateLabel.TabIndex = 8;
            endDateLabel.Text = "End Date:";
            // 
            // regIDLabel
            // 
            regIDLabel.AutoSize = true;
            regIDLabel.Location = new System.Drawing.Point(25, 171);
            regIDLabel.Name = "regIDLabel";
            regIDLabel.Size = new System.Drawing.Size(44, 13);
            regIDLabel.TabIndex = 10;
            regIDLabel.Text = "Reg ID:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(25, 197);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 12;
            userIDLabel.Text = "User ID:";
            // 
            // statusIDLabel
            // 
            statusIDLabel.AutoSize = true;
            statusIDLabel.Location = new System.Drawing.Point(25, 223);
            statusIDLabel.Name = "statusIDLabel";
            statusIDLabel.Size = new System.Drawing.Size(54, 13);
            statusIDLabel.TabIndex = 14;
            statusIDLabel.Text = "Status ID:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 689);
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
            this.tabPage1.Controls.Add(this.emergenciesBindingNavigator);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(923, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ЧС";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.emergenciesDataGridView.Location = new System.Drawing.Point(28, 266);
            this.emergenciesDataGridView.Name = "emergenciesDataGridView";
            this.emergenciesDataGridView.Size = new System.Drawing.Size(889, 391);
            this.emergenciesDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmergencyID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmergencyID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmTypeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmTypeID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RegID";
            this.dataGridViewTextBoxColumn6.HeaderText = "RegID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn7.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StatusID";
            this.dataGridViewTextBoxColumn8.HeaderText = "StatusID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emergenciesBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(108, 90);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.emergenciesBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(108, 116);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateDateTimePicker.TabIndex = 7;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.emergenciesBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(108, 142);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateDateTimePicker.TabIndex = 9;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emergenciesBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(108, 194);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.userIDTextBox.TabIndex = 13;
            // 
            // emergenciesBindingNavigator
            // 
            this.emergenciesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.emergenciesBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emergenciesBindingNavigator.AutoSize = false;
            this.emergenciesBindingNavigator.BindingSource = this.emergenciesBindingSource;
            this.emergenciesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.emergenciesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.emergenciesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.emergenciesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.emergenciesBindingNavigatorSaveItem,
            this.bindingNavigatorSeparator});
            this.emergenciesBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.emergenciesBindingNavigator.MoveFirstItem = null;
            this.emergenciesBindingNavigator.MoveLastItem = null;
            this.emergenciesBindingNavigator.MoveNextItem = null;
            this.emergenciesBindingNavigator.MovePreviousItem = null;
            this.emergenciesBindingNavigator.Name = "emergenciesBindingNavigator";
            this.emergenciesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.emergenciesBindingNavigator.Size = new System.Drawing.Size(914, 40);
            this.emergenciesBindingNavigator.TabIndex = 1;
            this.emergenciesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(79, 37);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 37);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(71, 37);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // emergenciesBindingNavigatorSaveItem
            // 
            this.emergenciesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("emergenciesBindingNavigatorSaveItem.Image")));
            this.emergenciesBindingNavigatorSaveItem.Name = "emergenciesBindingNavigatorSaveItem";
            this.emergenciesBindingNavigatorSaveItem.Size = new System.Drawing.Size(129, 37);
            this.emergenciesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.emergenciesBindingNavigatorSaveItem.Click += new System.EventHandler(this.emergenciesBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 40);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(923, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // emergenciesTableAdapter
            // 
            this.emergenciesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmergenciesTableAdapter = this.emergenciesTableAdapter;
            this.tableAdapterManager.EmergTypeListTableAdapter = null;
            this.tableAdapterManager.PositionListTableAdapter = null;
            this.tableAdapterManager.RegionsTableAdapter = null;
            this.tableAdapterManager.StatusListTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = mchs_db_viewer_01.MCHSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDataTableAdapter = null;
            // 
            // emergenciesBindingSource1
            // 
            this.emergenciesBindingSource1.DataMember = "Emergencies";
            this.emergenciesBindingSource1.DataSource = this.mCHSDataSet;
            // 
            // emergenciesComboBox
            // 
            this.emergenciesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.emergenciesBindingSource, "RegID", true));
            this.emergenciesComboBox.DataSource = this.regionsBindingSource;
            this.emergenciesComboBox.DisplayMember = "RegName";
            this.emergenciesComboBox.FormattingEnabled = true;
            this.emergenciesComboBox.Location = new System.Drawing.Point(108, 167);
            this.emergenciesComboBox.Name = "emergenciesComboBox";
            this.emergenciesComboBox.Size = new System.Drawing.Size(200, 21);
            this.emergenciesComboBox.TabIndex = 16;
            this.emergenciesComboBox.ValueMember = "RegID";
            // 
            // regionsBindingSource
            // 
            this.regionsBindingSource.DataMember = "Regions";
            this.regionsBindingSource.DataSource = this.mCHSDataSet;
            // 
            // regionsTableAdapter
            // 
            this.regionsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.emergenciesBindingSource, "StatusID", true));
            this.comboBox1.DataSource = this.statusListBindingSource;
            this.comboBox1.DisplayMember = "Statusname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "StatusID";
            // 
            // statusListBindingSource
            // 
            this.statusListBindingSource.DataMember = "StatusList";
            this.statusListBindingSource.DataSource = this.mCHSDataSet;
            // 
            // statusListTableAdapter
            // 
            this.statusListTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.emergenciesBindingSource, "EmTypeID", true));
            this.comboBox2.DataSource = this.emergTypeListBindingSource;
            this.comboBox2.DisplayMember = "Typename";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(108, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.ValueMember = "EmTypeID";
            // 
            // emergTypeListBindingSource
            // 
            this.emergTypeListBindingSource.DataMember = "EmergTypeList";
            this.emergTypeListBindingSource.DataSource = this.mCHSDataSet;
            // 
            // emergTypeListTableAdapter
            // 
            this.emergTypeListTableAdapter.ClearBeforeFill = true;
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 751);
            this.Controls.Add(this.tabControl1);
            this.Name = "adminform";
            this.Text = "adminform";
            this.Load += new System.EventHandler(this.adminform_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingNavigator)).EndInit();
            this.emergenciesBindingNavigator.ResumeLayout(false);
            this.emergenciesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergTypeListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MCHSDataSet mCHSDataSet;
        private System.Windows.Forms.BindingSource emergenciesBindingSource;
        private MCHSDataSetTableAdapters.EmergenciesTableAdapter emergenciesTableAdapter;
        private MCHSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator emergenciesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton emergenciesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.DataGridView emergenciesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ComboBox emergenciesComboBox;
        private System.Windows.Forms.BindingSource emergenciesBindingSource1;
        private System.Windows.Forms.BindingSource regionsBindingSource;
        private MCHSDataSetTableAdapters.RegionsTableAdapter regionsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource statusListBindingSource;
        private MCHSDataSetTableAdapters.StatusListTableAdapter statusListTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource emergTypeListBindingSource;
        private MCHSDataSetTableAdapters.EmergTypeListTableAdapter emergTypeListTableAdapter;
    }
}