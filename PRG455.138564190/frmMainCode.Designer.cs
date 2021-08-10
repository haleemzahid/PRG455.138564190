namespace PRG455._138564190
{
    partial class frmMainCode
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label userTypeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCode));
            this.tabApp = new System.Windows.Forms.TabControl();
            this.User = new System.Windows.Forms.TabPage();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cboUserType = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Screening = new System.Windows.Forms.TabPage();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.radFlagUser = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radTravelledYes = new System.Windows.Forms.RadioButton();
            this.radTravelledNo = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radSymptomsYes = new System.Windows.Forms.RadioButton();
            this.radSymptomsNo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radCloseContactNo = new System.Windows.Forms.RadioButton();
            this.radCloseContactYes = new System.Windows.Forms.RadioButton();
            this.btnScreeningSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.TabPage();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.btnSearchByPassFail = new System.Windows.Forms.Button();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.txtxSearchUserName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radPass = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.radFail = new System.Windows.Forms.RadioButton();
            this.btnresetfilter = new System.Windows.Forms.Button();
            usernameLabel = new System.Windows.Forms.Label();
            userTypeLabel = new System.Windows.Forms.Label();
            this.tabApp.SuspendLayout();
            this.User.SuspendLayout();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Screening.SuspendLayout();
            this.gbScreen.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Report.SuspendLayout();
            this.gbReport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(5, 66);
            usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(90, 18);
            usernameLabel.TabIndex = 20;
            usernameLabel.Text = "Username:";
            // 
            // userTypeLabel
            // 
            userTypeLabel.AutoSize = true;
            userTypeLabel.Location = new System.Drawing.Point(5, 109);
            userTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            userTypeLabel.Name = "userTypeLabel";
            userTypeLabel.Size = new System.Drawing.Size(90, 18);
            userTypeLabel.TabIndex = 22;
            userTypeLabel.Text = "User Type:";
            // 
            // tabApp
            // 
            this.tabApp.Controls.Add(this.User);
            this.tabApp.Controls.Add(this.Screening);
            this.tabApp.Controls.Add(this.Report);
            this.tabApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabApp.Location = new System.Drawing.Point(-1, 38);
            this.tabApp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabApp.Name = "tabApp";
            this.tabApp.SelectedIndex = 0;
            this.tabApp.Size = new System.Drawing.Size(959, 489);
            this.tabApp.TabIndex = 4;
            // 
            // User
            // 
            this.User.Controls.Add(this.gbUser);
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(4, 22);
            this.User.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.User.Size = new System.Drawing.Size(951, 463);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = true;
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbUser.Controls.Add(this.dataGridView1);
            this.gbUser.Controls.Add(usernameLabel);
            this.gbUser.Controls.Add(this.txtUserName);
            this.gbUser.Controls.Add(userTypeLabel);
            this.gbUser.Controls.Add(this.cboUserType);
            this.gbUser.Controls.Add(this.btnClear);
            this.gbUser.Controls.Add(this.btnEdit);
            this.gbUser.Controls.Add(this.btnReset);
            this.gbUser.Controls.Add(this.btnRemove);
            this.gbUser.Controls.Add(this.btnAdd);
            this.gbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUser.Location = new System.Drawing.Point(2, 3);
            this.gbUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbUser.Name = "gbUser";
            this.gbUser.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbUser.Size = new System.Drawing.Size(950, 421);
            this.gbUser.TabIndex = 2;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User";
            this.gbUser.Enter += new System.EventHandler(this.gbUser_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(573, 227);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Info;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(124, 66);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(195, 23);
            this.txtUserName.TabIndex = 0;
            // 
            // cboUserType
            // 
            this.cboUserType.BackColor = System.Drawing.SystemColors.Info;
            this.cboUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUserType.FormattingEnabled = true;
            this.cboUserType.Location = new System.Drawing.Point(124, 109);
            this.cboUserType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(195, 25);
            this.cboUserType.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(391, 277);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 49);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(473, 277);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 49);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit User";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(699, 276);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 49);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset Flagged Status";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(580, 277);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(74, 49);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove User";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(165, 165);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 49);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Screening
            // 
            this.Screening.Controls.Add(this.gbScreen);
            this.Screening.Location = new System.Drawing.Point(4, 22);
            this.Screening.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Screening.Name = "Screening";
            this.Screening.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Screening.Size = new System.Drawing.Size(951, 463);
            this.Screening.TabIndex = 1;
            this.Screening.Text = "Screening";
            this.Screening.UseVisualStyleBackColor = true;
            // 
            // gbScreen
            // 
            this.gbScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbScreen.Controls.Add(this.radFlagUser);
            this.gbScreen.Controls.Add(this.panel3);
            this.gbScreen.Controls.Add(this.panel2);
            this.gbScreen.Controls.Add(this.panel1);
            this.gbScreen.Controls.Add(this.btnScreeningSave);
            this.gbScreen.Controls.Add(this.label2);
            this.gbScreen.Controls.Add(this.cboUsers);
            this.gbScreen.Controls.Add(this.label15);
            this.gbScreen.Controls.Add(this.label14);
            this.gbScreen.Controls.Add(this.label13);
            this.gbScreen.Controls.Add(this.label12);
            this.gbScreen.Controls.Add(this.dtDate);
            this.gbScreen.Controls.Add(this.label11);
            this.gbScreen.Controls.Add(this.label10);
            this.gbScreen.Controls.Add(this.label9);
            this.gbScreen.Controls.Add(this.label8);
            this.gbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbScreen.Location = new System.Drawing.Point(0, 3);
            this.gbScreen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbScreen.Size = new System.Drawing.Size(959, 422);
            this.gbScreen.TabIndex = 3;
            this.gbScreen.TabStop = false;
            this.gbScreen.Text = "Screening";
            // 
            // radFlagUser
            // 
            this.radFlagUser.AutoSize = true;
            this.radFlagUser.Location = new System.Drawing.Point(429, 303);
            this.radFlagUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radFlagUser.Name = "radFlagUser";
            this.radFlagUser.Size = new System.Drawing.Size(99, 22);
            this.radFlagUser.TabIndex = 9;
            this.radFlagUser.TabStop = true;
            this.radFlagUser.Text = "Flag User";
            this.radFlagUser.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radTravelledYes);
            this.panel3.Controls.Add(this.radTravelledNo);
            this.panel3.Location = new System.Drawing.Point(427, 129);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 54);
            this.panel3.TabIndex = 31;
            // 
            // radTravelledYes
            // 
            this.radTravelledYes.AutoSize = true;
            this.radTravelledYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTravelledYes.Location = new System.Drawing.Point(15, 21);
            this.radTravelledYes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radTravelledYes.Name = "radTravelledYes";
            this.radTravelledYes.Size = new System.Drawing.Size(48, 19);
            this.radTravelledYes.TabIndex = 4;
            this.radTravelledYes.Text = "Yes";
            this.radTravelledYes.UseVisualStyleBackColor = true;
            // 
            // radTravelledNo
            // 
            this.radTravelledNo.AutoSize = true;
            this.radTravelledNo.Checked = true;
            this.radTravelledNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTravelledNo.Location = new System.Drawing.Point(65, 21);
            this.radTravelledNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radTravelledNo.Name = "radTravelledNo";
            this.radTravelledNo.Size = new System.Drawing.Size(43, 19);
            this.radTravelledNo.TabIndex = 5;
            this.radTravelledNo.TabStop = true;
            this.radTravelledNo.Text = "No";
            this.radTravelledNo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radSymptomsYes);
            this.panel2.Controls.Add(this.radSymptomsNo);
            this.panel2.Location = new System.Drawing.Point(429, 194);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 45);
            this.panel2.TabIndex = 31;
            // 
            // radSymptomsYes
            // 
            this.radSymptomsYes.AutoSize = true;
            this.radSymptomsYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSymptomsYes.Location = new System.Drawing.Point(13, 16);
            this.radSymptomsYes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radSymptomsYes.Name = "radSymptomsYes";
            this.radSymptomsYes.Size = new System.Drawing.Size(48, 19);
            this.radSymptomsYes.TabIndex = 6;
            this.radSymptomsYes.Text = "Yes";
            this.radSymptomsYes.UseVisualStyleBackColor = true;
            // 
            // radSymptomsNo
            // 
            this.radSymptomsNo.AutoSize = true;
            this.radSymptomsNo.Checked = true;
            this.radSymptomsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSymptomsNo.Location = new System.Drawing.Point(63, 16);
            this.radSymptomsNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radSymptomsNo.Name = "radSymptomsNo";
            this.radSymptomsNo.Size = new System.Drawing.Size(43, 19);
            this.radSymptomsNo.TabIndex = 7;
            this.radSymptomsNo.TabStop = true;
            this.radSymptomsNo.Text = "No";
            this.radSymptomsNo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radCloseContactNo);
            this.panel1.Controls.Add(this.radCloseContactYes);
            this.panel1.Location = new System.Drawing.Point(427, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 52);
            this.panel1.TabIndex = 31;
            // 
            // radCloseContactNo
            // 
            this.radCloseContactNo.AutoSize = true;
            this.radCloseContactNo.Checked = true;
            this.radCloseContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCloseContactNo.Location = new System.Drawing.Point(65, 16);
            this.radCloseContactNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radCloseContactNo.Name = "radCloseContactNo";
            this.radCloseContactNo.Size = new System.Drawing.Size(43, 19);
            this.radCloseContactNo.TabIndex = 3;
            this.radCloseContactNo.TabStop = true;
            this.radCloseContactNo.Text = "No";
            this.radCloseContactNo.UseVisualStyleBackColor = true;
            // 
            // radCloseContactYes
            // 
            this.radCloseContactYes.AutoSize = true;
            this.radCloseContactYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCloseContactYes.Location = new System.Drawing.Point(15, 16);
            this.radCloseContactYes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radCloseContactYes.Name = "radCloseContactYes";
            this.radCloseContactYes.Size = new System.Drawing.Size(48, 19);
            this.radCloseContactYes.TabIndex = 2;
            this.radCloseContactYes.Text = "Yes";
            this.radCloseContactYes.UseVisualStyleBackColor = true;
            // 
            // btnScreeningSave
            // 
            this.btnScreeningSave.Location = new System.Drawing.Point(253, 340);
            this.btnScreeningSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScreeningSave.Name = "btnScreeningSave";
            this.btnScreeningSave.Size = new System.Drawing.Size(134, 30);
            this.btnScreeningSave.TabIndex = 10;
            this.btnScreeningSave.Text = "Save";
            this.btnScreeningSave.UseVisualStyleBackColor = true;
            this.btnScreeningSave.Click += new System.EventHandler(this.btnScreeningSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Select a user";
            // 
            // cboUsers
            // 
            this.cboUsers.DisplayMember = "UserName";
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(229, 30);
            this.cboUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(201, 25);
            this.cboUsers.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(216, 57);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(214, 29);
            this.label15.TabIndex = 27;
            this.label15.Text = "Assessment Tool";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 209);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 65);
            this.label14.TabIndex = 26;
            this.label14.Text = "Do you have anyof these symptoms?:\r\n1. Fever\r\n 2. Cough \r\n3. Shortness of Breath\r" +
    "\n ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 155);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(281, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "In the last 14 days, have you travelled outside of Canada?\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 98);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(337, 26);
            this.label12.TabIndex = 24;
            this.label12.Text = "In the last 14 days, have you been in a close contact with anyone who\r\n has been " +
    "tested positive for COVID-19";
            // 
            // dtDate
            // 
            this.dtDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(426, 267);
            this.dtDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(134, 21);
            this.dtDate.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 269);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 190);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Symptoms:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Travelled:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Close Contact:";
            // 
            // Report
            // 
            this.Report.AutoScroll = true;
            this.Report.Controls.Add(this.gbReport);
            this.Report.Location = new System.Drawing.Point(4, 22);
            this.Report.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Report.Size = new System.Drawing.Size(951, 463);
            this.Report.TabIndex = 2;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // gbReport
            // 
            this.gbReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbReport.Controls.Add(this.dataGridView2);
            this.gbReport.Controls.Add(this.groupBox1);
            this.gbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReport.Location = new System.Drawing.Point(-8, 0);
            this.gbReport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbReport.Name = "gbReport";
            this.gbReport.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbReport.Size = new System.Drawing.Size(939, 409);
            this.gbReport.TabIndex = 4;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Report";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFail);
            this.groupBox1.Controls.Add(this.radPass);
            this.groupBox1.Controls.Add(this.btnresetfilter);
            this.groupBox1.Controls.Add(this.btnSearchByDate);
            this.groupBox1.Controls.Add(this.btnSearchByPassFail);
            this.groupBox1.Controls.Add(this.btnSearchByName);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.txtxSearchUserName);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(353, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByDate.Location = new System.Drawing.Point(215, 171);
            this.btnSearchByDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(113, 44);
            this.btnSearchByDate.TabIndex = 8;
            this.btnSearchByDate.Text = "Search by Date";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // btnSearchByPassFail
            // 
            this.btnSearchByPassFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByPassFail.Location = new System.Drawing.Point(215, 97);
            this.btnSearchByPassFail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchByPassFail.Name = "btnSearchByPassFail";
            this.btnSearchByPassFail.Size = new System.Drawing.Size(113, 20);
            this.btnSearchByPassFail.TabIndex = 5;
            this.btnSearchByPassFail.Text = "Search by Pass/Fail";
            this.btnSearchByPassFail.UseVisualStyleBackColor = true;
            this.btnSearchByPassFail.Click += new System.EventHandler(this.btnSearchByPassFail_Click);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByName.Location = new System.Drawing.Point(215, 23);
            this.btnSearchByName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(113, 22);
            this.btnSearchByName.TabIndex = 2;
            this.btnSearchByName.Text = "Search by User Name";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(88, 196);
            this.dtTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(108, 19);
            this.dtTo.TabIndex = 7;
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(88, 175);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(108, 19);
            this.dtFrom.TabIndex = 6;
            // 
            // txtxSearchUserName
            // 
            this.txtxSearchUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxSearchUserName.Location = new System.Drawing.Point(88, 26);
            this.txtxSearchUserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtxSearchUserName.Name = "txtxSearchUserName";
            this.txtxSearchUserName.Size = new System.Drawing.Size(108, 19);
            this.txtxSearchUserName.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 200);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 15);
            this.label19.TabIndex = 3;
            this.label19.Text = "To";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 175);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "From";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 98);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Pass/Fail";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 26);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "COVID SCREENING APPLICATION";
            // 
            // radPass
            // 
            this.radPass.AutoSize = true;
            this.radPass.Location = new System.Drawing.Point(88, 95);
            this.radPass.Name = "radPass";
            this.radPass.Size = new System.Drawing.Size(60, 22);
            this.radPass.TabIndex = 3;
            this.radPass.TabStop = true;
            this.radPass.Text = "Pass";
            this.radPass.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(390, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(459, 318);
            this.dataGridView2.TabIndex = 1;
            // 
            // radFail
            // 
            this.radFail.AutoSize = true;
            this.radFail.Location = new System.Drawing.Point(145, 95);
            this.radFail.Name = "radFail";
            this.radFail.Size = new System.Drawing.Size(49, 22);
            this.radFail.TabIndex = 4;
            this.radFail.TabStop = true;
            this.radFail.Text = "Fail";
            this.radFail.UseVisualStyleBackColor = true;
            // 
            // btnresetfilter
            // 
            this.btnresetfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetfilter.Location = new System.Drawing.Point(88, 241);
            this.btnresetfilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnresetfilter.Name = "btnresetfilter";
            this.btnresetfilter.Size = new System.Drawing.Size(113, 44);
            this.btnresetfilter.TabIndex = 8;
            this.btnresetfilter.Text = "Reset Filter";
            this.btnresetfilter.UseVisualStyleBackColor = true;
            this.btnresetfilter.Click += new System.EventHandler(this.btnresetfilter_Click);
            // 
            // frmMainCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.tabApp);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMainCode";
            this.Text = "SCREENING";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabApp.ResumeLayout(false);
            this.User.ResumeLayout(false);
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Screening.ResumeLayout(false);
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Report.ResumeLayout(false);
            this.gbReport.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabApp;
        private System.Windows.Forms.TabPage User;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage Screening;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.RadioButton radSymptomsNo;
        private System.Windows.Forms.RadioButton radSymptomsYes;
        private System.Windows.Forms.RadioButton radTravelledNo;
        private System.Windows.Forms.RadioButton radTravelledYes;
        private System.Windows.Forms.RadioButton radCloseContactNo;
        private System.Windows.Forms.RadioButton radCloseContactYes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage Report;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.Button btnSearchByPassFail;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.TextBox txtxSearchUserName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cboUserType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.Button btnScreeningSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radFlagUser;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton radPass;
        private System.Windows.Forms.RadioButton radFail;
        private System.Windows.Forms.Button btnresetfilter;
    }
}

