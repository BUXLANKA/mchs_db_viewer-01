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
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label positionIDLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label statusIDLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label regIDLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label emTypeIDLabel;
            System.Windows.Forms.Label positionNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminform));
            System.Windows.Forms.Label regNameLabel;
            this.emergenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCHSDataSet = new mchs_db_viewer_01.MCHSDataSet();
            this.userDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emergenciesTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.EmergenciesTableAdapter();
            this.tableAdapterManager = new mchs_db_viewer_01.MCHSDataSetTableAdapters.TableAdapterManager();
            this.userDataTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.UserDataTableAdapter();
            this.regionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionsTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.RegionsTableAdapter();
            this.statusListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusListTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.StatusListTableAdapter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.positionIDTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.userDataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusIDTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.regIDTextBox = new System.Windows.Forms.TextBox();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.emTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.emergenciesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.positionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionListTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.PositionListTableAdapter();
            this.positionNameTextBox = new System.Windows.Forms.TextBox();
            this.positionListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergTypeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emergTypeListTableAdapter = new mchs_db_viewer_01.MCHSDataSetTableAdapters.EmergTypeListTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton21 = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.regionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNameTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton23 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton24 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton25 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton26 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton27 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton28 = new System.Windows.Forms.ToolStripButton();
            passwordLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            positionIDLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            statusIDLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            regIDLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            emTypeIDLabel = new System.Windows.Forms.Label();
            positionNameLabel = new System.Windows.Forms.Label();
            regNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusListBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergTypeListBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            this.SuspendLayout();
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
            // userDataBindingSource
            // 
            this.userDataBindingSource.DataMember = "UserData";
            this.userDataBindingSource.DataSource = this.mCHSDataSet;
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
            this.tableAdapterManager.UserDataTableAdapter = this.userDataTableAdapter;
            // 
            // userDataTableAdapter
            // 
            this.userDataTableAdapter.ClearBeforeFill = true;
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
            // statusListBindingSource
            // 
            this.statusListBindingSource.DataMember = "StatusList";
            this.statusListBindingSource.DataSource = this.mCHSDataSet;
            // 
            // statusListTableAdapter
            // 
            this.statusListTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1068, 626);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Зависимые таблицы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.bindingNavigator2);
            this.tabPage2.Controls.Add(this.userDataDataGridView);
            this.tabPage2.Controls.Add(firstnameLabel);
            this.tabPage2.Controls.Add(this.firstnameTextBox);
            this.tabPage2.Controls.Add(this.surnameTextBox);
            this.tabPage2.Controls.Add(this.lastnameTextBox);
            this.tabPage2.Controls.Add(this.positionIDTextBox);
            this.tabPage2.Controls.Add(this.phoneTextBox);
            this.tabPage2.Controls.Add(this.emailTextBox);
            this.tabPage2.Controls.Add(this.loginTextBox);
            this.tabPage2.Controls.Add(this.passwordTextBox);
            this.tabPage2.Controls.Add(surnameLabel);
            this.tabPage2.Controls.Add(lastnameLabel);
            this.tabPage2.Controls.Add(positionIDLabel);
            this.tabPage2.Controls.Add(phoneLabel);
            this.tabPage2.Controls.Add(emailLabel);
            this.tabPage2.Controls.Add(loginLabel);
            this.tabPage2.Controls.Add(passwordLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1068, 626);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Данные пользователей";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDataBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(73, 236);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(356, 20);
            this.passwordTextBox.TabIndex = 17;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(6, 239);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 16;
            passwordLabel.Text = "Password:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDataBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(73, 210);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(356, 20);
            this.loginTextBox.TabIndex = 15;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(6, 213);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(36, 13);
            loginLabel.TabIndex = 14;
            loginLabel.Text = "Login:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDataBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(73, 184);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(356, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(6, 187);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDataBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(73, 158);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(356, 20);
            this.phoneTextBox.TabIndex = 11;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(6, 161);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "Phone:";
            // 
            // positionIDTextBox
            // 
            this.positionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDataBindingSource, "PositionID", true));
            this.positionIDTextBox.Location = new System.Drawing.Point(73, 132);
            this.positionIDTextBox.Name = "positionIDTextBox";
            this.positionIDTextBox.Size = new System.Drawing.Size(356, 20);
            this.positionIDTextBox.TabIndex = 9;
            // 
            // positionIDLabel
            // 
            positionIDLabel.AutoSize = true;
            positionIDLabel.Location = new System.Drawing.Point(6, 135);
            positionIDLabel.Name = "positionIDLabel";
            positionIDLabel.Size = new System.Drawing.Size(61, 13);
            positionIDLabel.TabIndex = 8;
            positionIDLabel.Text = "Position ID:";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDataBindingSource, "Lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(73, 106);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(356, 20);
            this.lastnameTextBox.TabIndex = 7;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(6, 109);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(56, 13);
            lastnameLabel.TabIndex = 6;
            lastnameLabel.Text = "Lastname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDataBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(73, 80);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(356, 20);
            this.surnameTextBox.TabIndex = 5;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(6, 83);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 4;
            surnameLabel.Text = "Surname:";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDataBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(73, 54);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(356, 20);
            this.firstnameTextBox.TabIndex = 3;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(6, 57);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(55, 13);
            firstnameLabel.TabIndex = 2;
            firstnameLabel.Text = "Firstname:";
            // 
            // userDataDataGridView
            // 
            this.userDataDataGridView.AutoGenerateColumns = false;
            this.userDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.userDataDataGridView.DataSource = this.userDataBindingSource;
            this.userDataDataGridView.Location = new System.Drawing.Point(9, 274);
            this.userDataDataGridView.Name = "userDataDataGridView";
            this.userDataDataGridView.Size = new System.Drawing.Size(1053, 346);
            this.userDataDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn17.HeaderText = "Password";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn16.HeaderText = "Login";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn15.HeaderText = "Email";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn14.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PositionID";
            this.dataGridViewTextBoxColumn13.HeaderText = "PositionID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Lastname";
            this.dataGridViewTextBoxColumn12.HeaderText = "Lastname";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn11.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Firstname";
            this.dataGridViewTextBoxColumn10.HeaderText = "Firstname";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn9.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton8;
            this.bindingNavigator2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bindingNavigator2.AutoSize = false;
            this.bindingNavigator2.BindingSource = this.userDataBindingSource;
            this.bindingNavigator2.CanOverflow = false;
            this.bindingNavigator2.CountItem = this.toolStripLabel2;
            this.bindingNavigator2.DeleteItem = this.toolStripButton9;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton14});
            this.bindingNavigator2.Location = new System.Drawing.Point(1, 0);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton10;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton13;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton12;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton11;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator2.Size = new System.Drawing.Size(1068, 44);
            this.bindingNavigator2.TabIndex = 18;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton10.Text = "Переместить в начало";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton11.Text = "Переместить назад";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Положение";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Текущее положение";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(43, 41);
            this.toolStripLabel2.Text = "для {0}";
            this.toolStripLabel2.ToolTipText = "Общее число элементов";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton12.Text = "Переместить вперед";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton13.Text = "Переместить в конец";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(79, 41);
            this.toolStripButton8.Text = "Добавить";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(71, 41);
            this.toolStripButton9.Text = "Удалить";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(129, 41);
            this.toolStripButton14.Text = "Сохранить данные";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.bindingNavigator1);
            this.tabPage1.Controls.Add(this.emergenciesDataGridView);
            this.tabPage1.Controls.Add(emTypeIDLabel);
            this.tabPage1.Controls.Add(this.emTypeIDTextBox);
            this.tabPage1.Controls.Add(this.descriptionTextBox);
            this.tabPage1.Controls.Add(this.regIDTextBox);
            this.tabPage1.Controls.Add(this.userIDTextBox);
            this.tabPage1.Controls.Add(this.statusIDTextBox);
            this.tabPage1.Controls.Add(descriptionLabel);
            this.tabPage1.Controls.Add(startDateLabel);
            this.tabPage1.Controls.Add(this.startDateDateTimePicker);
            this.tabPage1.Controls.Add(endDateLabel);
            this.tabPage1.Controls.Add(this.endDateDateTimePicker);
            this.tabPage1.Controls.Add(regIDLabel);
            this.tabPage1.Controls.Add(userIDLabel);
            this.tabPage1.Controls.Add(statusIDLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица ЧС";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusIDTextBox
            // 
            this.statusIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emergenciesBindingSource, "StatusID", true));
            this.statusIDTextBox.Location = new System.Drawing.Point(89, 214);
            this.statusIDTextBox.Name = "statusIDTextBox";
            this.statusIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.statusIDTextBox.TabIndex = 15;
            // 
            // statusIDLabel
            // 
            statusIDLabel.AutoSize = true;
            statusIDLabel.Location = new System.Drawing.Point(6, 217);
            statusIDLabel.Name = "statusIDLabel";
            statusIDLabel.Size = new System.Drawing.Size(54, 13);
            statusIDLabel.TabIndex = 14;
            statusIDLabel.Text = "Status ID:";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emergenciesBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(89, 188);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.userIDTextBox.TabIndex = 13;
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(6, 191);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 12;
            userIDLabel.Text = "User ID:";
            // 
            // regIDTextBox
            // 
            this.regIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emergenciesBindingSource, "RegID", true));
            this.regIDTextBox.Location = new System.Drawing.Point(89, 162);
            this.regIDTextBox.Name = "regIDTextBox";
            this.regIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.regIDTextBox.TabIndex = 11;
            // 
            // regIDLabel
            // 
            regIDLabel.AutoSize = true;
            regIDLabel.Location = new System.Drawing.Point(6, 165);
            regIDLabel.Name = "regIDLabel";
            regIDLabel.Size = new System.Drawing.Size(44, 13);
            regIDLabel.TabIndex = 10;
            regIDLabel.Text = "Reg ID:";
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.emergenciesBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(89, 136);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateDateTimePicker.TabIndex = 9;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(6, 140);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(55, 13);
            endDateLabel.TabIndex = 8;
            endDateLabel.Text = "End Date:";
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.emergenciesBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(89, 110);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateDateTimePicker.TabIndex = 7;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(6, 114);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 6;
            startDateLabel.Text = "Start Date:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emergenciesBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(89, 84);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(6, 87);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // emTypeIDTextBox
            // 
            this.emTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emergenciesBindingSource, "EmTypeID", true));
            this.emTypeIDTextBox.Location = new System.Drawing.Point(89, 58);
            this.emTypeIDTextBox.Name = "emTypeIDTextBox";
            this.emTypeIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.emTypeIDTextBox.TabIndex = 3;
            // 
            // emTypeIDLabel
            // 
            emTypeIDLabel.AutoSize = true;
            emTypeIDLabel.Location = new System.Drawing.Point(6, 61);
            emTypeIDLabel.Name = "emTypeIDLabel";
            emTypeIDLabel.Size = new System.Drawing.Size(66, 13);
            emTypeIDLabel.TabIndex = 2;
            emTypeIDLabel.Text = "Em Type ID:";
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
            this.emergenciesDataGridView.Location = new System.Drawing.Point(9, 255);
            this.emergenciesDataGridView.Name = "emergenciesDataGridView";
            this.emergenciesDataGridView.Size = new System.Drawing.Size(1053, 368);
            this.emergenciesDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StatusID";
            this.dataGridViewTextBoxColumn8.HeaderText = "StatusID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn7.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RegID";
            this.dataGridViewTextBoxColumn6.HeaderText = "RegID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmTypeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmTypeID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmergencyID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmergencyID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BindingSource = this.emergenciesBindingSource;
            this.bindingNavigator1.CanOverflow = false;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1068, 44);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 41);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(79, 41);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(71, 41);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(129, 41);
            this.toolStripButton7.Text = "Сохранить данные";
            this.toolStripButton7.Click += new System.EventHandler(this.emergenciesBindingNavigatorSaveItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 652);
            this.tabControl1.TabIndex = 0;
            // 
            // positionListBindingSource
            // 
            this.positionListBindingSource.DataMember = "PositionList";
            this.positionListBindingSource.DataSource = this.mCHSDataSet;
            // 
            // positionListTableAdapter
            // 
            this.positionListTableAdapter.ClearBeforeFill = true;
            // 
            // positionNameLabel
            // 
            positionNameLabel.AutoSize = true;
            positionNameLabel.Location = new System.Drawing.Point(6, 80);
            positionNameLabel.Name = "positionNameLabel";
            positionNameLabel.Size = new System.Drawing.Size(78, 13);
            positionNameLabel.TabIndex = 2;
            positionNameLabel.Text = "Position Name:";
            // 
            // positionNameTextBox
            // 
            this.positionNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.positionListBindingSource, "PositionName", true));
            this.positionNameTextBox.Location = new System.Drawing.Point(90, 77);
            this.positionNameTextBox.Name = "positionNameTextBox";
            this.positionNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.positionNameTextBox.TabIndex = 3;
            // 
            // positionListDataGridView
            // 
            this.positionListDataGridView.AutoGenerateColumns = false;
            this.positionListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.positionListDataGridView.DataSource = this.positionListBindingSource;
            this.positionListDataGridView.Location = new System.Drawing.Point(9, 124);
            this.positionListDataGridView.Name = "positionListDataGridView";
            this.positionListDataGridView.Size = new System.Drawing.Size(1010, 260);
            this.positionListDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "PositionID";
            this.dataGridViewTextBoxColumn18.HeaderText = "PositionID";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "PositionName";
            this.dataGridViewTextBoxColumn19.HeaderText = "PositionName";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bindingNavigator3);
            this.groupBox1.Controls.Add(this.positionNameTextBox);
            this.groupBox1.Controls.Add(positionNameLabel);
            this.groupBox1.Controls.Add(this.positionListDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(20, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 390);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблица должностей";
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.toolStripButton15;
            this.bindingNavigator3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bindingNavigator3.AutoSize = false;
            this.bindingNavigator3.BindingSource = this.positionListBindingSource;
            this.bindingNavigator3.CanOverflow = false;
            this.bindingNavigator3.CountItem = this.toolStripLabel3;
            this.bindingNavigator3.DeleteItem = this.toolStripButton16;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripSeparator7,
            this.toolStripTextBox3,
            this.toolStripLabel3,
            this.toolStripSeparator8,
            this.toolStripButton19,
            this.toolStripButton20,
            this.toolStripSeparator9,
            this.toolStripButton15,
            this.toolStripButton16,
            this.toolStripButton21});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 16);
            this.bindingNavigator3.MoveFirstItem = this.toolStripButton17;
            this.bindingNavigator3.MoveLastItem = this.toolStripButton20;
            this.bindingNavigator3.MoveNextItem = this.toolStripButton19;
            this.bindingNavigator3.MovePreviousItem = this.toolStripButton18;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.toolStripTextBox3;
            this.bindingNavigator3.Size = new System.Drawing.Size(1025, 41);
            this.bindingNavigator3.TabIndex = 19;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(79, 38);
            this.toolStripButton15.Text = "Добавить";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(43, 38);
            this.toolStripLabel3.Text = "для {0}";
            this.toolStripLabel3.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(71, 38);
            this.toolStripButton16.Text = "Удалить";
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(23, 38);
            this.toolStripButton17.Text = "Переместить в начало";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.RightToLeftAutoMirrorImage = true;
            this.toolStripButton18.Size = new System.Drawing.Size(23, 38);
            this.toolStripButton18.Text = "Переместить назад";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AccessibleName = "Положение";
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.RightToLeftAutoMirrorImage = true;
            this.toolStripButton19.Size = new System.Drawing.Size(23, 38);
            this.toolStripButton19.Text = "Переместить вперед";
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton20.Image")));
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.RightToLeftAutoMirrorImage = true;
            this.toolStripButton20.Size = new System.Drawing.Size(23, 38);
            this.toolStripButton20.Text = "Переместить в конец";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton21
            // 
            this.toolStripButton21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton21.Image")));
            this.toolStripButton21.Name = "toolStripButton21";
            this.toolStripButton21.Size = new System.Drawing.Size(129, 38);
            this.toolStripButton21.Text = "Сохранить данные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bindingNavigator4);
            this.groupBox2.Controls.Add(regNameLabel);
            this.groupBox2.Controls.Add(this.regNameTextBox);
            this.groupBox2.Controls.Add(this.regionsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(20, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1025, 390);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Таблица Регионов";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(20, 817);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1025, 390);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(20, 1213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1025, 390);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // regionsDataGridView
            // 
            this.regionsDataGridView.AutoGenerateColumns = false;
            this.regionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.regionsDataGridView.DataSource = this.regionsBindingSource;
            this.regionsDataGridView.Location = new System.Drawing.Point(9, 164);
            this.regionsDataGridView.Name = "regionsDataGridView";
            this.regionsDataGridView.Size = new System.Drawing.Size(1010, 220);
            this.regionsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "RegID";
            this.dataGridViewTextBoxColumn20.HeaderText = "RegID";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "RegName";
            this.dataGridViewTextBoxColumn21.HeaderText = "RegName";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // regNameLabel
            // 
            regNameLabel.AutoSize = true;
            regNameLabel.Location = new System.Drawing.Point(23, 132);
            regNameLabel.Name = "regNameLabel";
            regNameLabel.Size = new System.Drawing.Size(61, 13);
            regNameLabel.TabIndex = 3;
            regNameLabel.Text = "Reg Name:";
            // 
            // regNameTextBox
            // 
            this.regNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regionsBindingSource, "RegName", true));
            this.regNameTextBox.Location = new System.Drawing.Point(90, 129);
            this.regNameTextBox.Name = "regNameTextBox";
            this.regNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.regNameTextBox.TabIndex = 4;
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = this.toolStripButton22;
            this.bindingNavigator4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bindingNavigator4.AutoSize = false;
            this.bindingNavigator4.BindingSource = this.regionsBindingSource;
            this.bindingNavigator4.CanOverflow = false;
            this.bindingNavigator4.CountItem = this.toolStripLabel4;
            this.bindingNavigator4.DeleteItem = this.toolStripButton23;
            this.bindingNavigator4.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton24,
            this.toolStripButton25,
            this.toolStripSeparator10,
            this.toolStripTextBox4,
            this.toolStripLabel4,
            this.toolStripSeparator11,
            this.toolStripButton26,
            this.toolStripButton27,
            this.toolStripSeparator12,
            this.toolStripButton22,
            this.toolStripButton23,
            this.toolStripButton28});
            this.bindingNavigator4.Location = new System.Drawing.Point(0, 16);
            this.bindingNavigator4.MoveFirstItem = this.toolStripButton24;
            this.bindingNavigator4.MoveLastItem = this.toolStripButton27;
            this.bindingNavigator4.MoveNextItem = this.toolStripButton26;
            this.bindingNavigator4.MovePreviousItem = this.toolStripButton25;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = this.toolStripTextBox4;
            this.bindingNavigator4.Size = new System.Drawing.Size(1025, 41);
            this.bindingNavigator4.TabIndex = 20;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // toolStripButton22
            // 
            this.toolStripButton22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton22.Image")));
            this.toolStripButton22.Name = "toolStripButton22";
            this.toolStripButton22.RightToLeftAutoMirrorImage = true;
            this.toolStripButton22.Size = new System.Drawing.Size(79, 38);
            this.toolStripButton22.Text = "Добавить";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(43, 38);
            this.toolStripLabel4.Text = "для {0}";
            this.toolStripLabel4.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton23
            // 
            this.toolStripButton23.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton23.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
            this.toolStripButton23.Name = "toolStripButton23";
            this.toolStripButton23.RightToLeftAutoMirrorImage = true;
            this.toolStripButton23.Size = new System.Drawing.Size(71, 38);
            this.toolStripButton23.Text = "Удалить";
            // 
            // toolStripButton24
            // 
            this.toolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton24.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton24.Image")));
            this.toolStripButton24.Name = "toolStripButton24";
            this.toolStripButton24.RightToLeftAutoMirrorImage = true;
            this.toolStripButton24.Size = new System.Drawing.Size(23, 38);
            this.toolStripButton24.Text = "Переместить в начало";
            // 
            // toolStripButton25
            // 
            this.toolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton25.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton25.Image")));
            this.toolStripButton25.Name = "toolStripButton25";
            this.toolStripButton25.RightToLeftAutoMirrorImage = true;
            this.toolStripButton25.Size = new System.Drawing.Size(23, 38);
            this.toolStripButton25.Text = "Переместить назад";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.AccessibleName = "Положение";
            this.toolStripTextBox4.AutoSize = false;
            this.toolStripTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox4.Text = "0";
            this.toolStripTextBox4.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton26
            // 
            this.toolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton26.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton26.Image")));
            this.toolStripButton26.Name = "toolStripButton26";
            this.toolStripButton26.RightToLeftAutoMirrorImage = true;
            this.toolStripButton26.Size = new System.Drawing.Size(23, 38);
            this.toolStripButton26.Text = "Переместить вперед";
            // 
            // toolStripButton27
            // 
            this.toolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton27.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton27.Image")));
            this.toolStripButton27.Name = "toolStripButton27";
            this.toolStripButton27.RightToLeftAutoMirrorImage = true;
            this.toolStripButton27.Size = new System.Drawing.Size(23, 38);
            this.toolStripButton27.Text = "Переместить в конец";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton28
            // 
            this.toolStripButton28.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton28.Image")));
            this.toolStripButton28.Name = "toolStripButton28";
            this.toolStripButton28.Size = new System.Drawing.Size(129, 38);
            this.toolStripButton28.Text = "Сохранить данные";
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 692);
            this.Controls.Add(this.tabControl1);
            this.Name = "adminform";
            this.Text = "adminform";
            this.Load += new System.EventHandler(this.adminform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusListBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.positionListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergTypeListBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MCHSDataSet mCHSDataSet;
        private System.Windows.Forms.BindingSource emergenciesBindingSource;
        private MCHSDataSetTableAdapters.EmergenciesTableAdapter emergenciesTableAdapter;
        private MCHSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MCHSDataSetTableAdapters.UserDataTableAdapter userDataTableAdapter;
        private System.Windows.Forms.BindingSource userDataBindingSource;
        private System.Windows.Forms.BindingSource regionsBindingSource;
        private MCHSDataSetTableAdapters.RegionsTableAdapter regionsTableAdapter;
        private System.Windows.Forms.BindingSource statusListBindingSource;
        private MCHSDataSetTableAdapters.StatusListTableAdapter statusListTableAdapter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.DataGridView userDataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox positionIDTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.DataGridView emergenciesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox emTypeIDTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox regIDTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox statusIDTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource positionListBindingSource;
        private MCHSDataSetTableAdapters.PositionListTableAdapter positionListTableAdapter;
        private System.Windows.Forms.DataGridView positionListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.TextBox positionNameTextBox;
        private System.Windows.Forms.BindingSource emergTypeListBindingSource;
        private MCHSDataSetTableAdapters.EmergTypeListTableAdapter emergTypeListTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView regionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripButton toolStripButton22;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton23;
        private System.Windows.Forms.ToolStripButton toolStripButton24;
        private System.Windows.Forms.ToolStripButton toolStripButton25;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButton26;
        private System.Windows.Forms.ToolStripButton toolStripButton27;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton toolStripButton28;
        private System.Windows.Forms.TextBox regNameTextBox;
    }
}