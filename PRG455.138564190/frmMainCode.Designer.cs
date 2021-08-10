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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Screening = new System.Windows.Forms.TabPage();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.radSymptomsNo = new System.Windows.Forms.RadioButton();
            this.radSymptomsYes = new System.Windows.Forms.RadioButton();
            this.radTravelledNo = new System.Windows.Forms.RadioButton();
            this.radTravelledYes = new System.Windows.Forms.RadioButton();
            this.radCloseContactNo = new System.Windows.Forms.RadioButton();
            this.radCloseContactYes = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.TabPage();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScreeningSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radFlagUser = new System.Windows.Forms.RadioButton();
            usernameLabel = new System.Windows.Forms.Label();
            userTypeLabel = new System.Windows.Forms.Label();
            this.tabApp.SuspendLayout();
            this.User.SuspendLayout();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Screening.SuspendLayout();
            this.gbScreen.SuspendLayout();
            this.Report.SuspendLayout();
            this.gbReport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(7, 102);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(128, 26);
            usernameLabel.TabIndex = 20;
            usernameLabel.Text = "Username:";
            // 
            // userTypeLabel
            // 
            userTypeLabel.AutoSize = true;
            userTypeLabel.Location = new System.Drawing.Point(8, 168);
            userTypeLabel.Name = "userTypeLabel";
            userTypeLabel.Size = new System.Drawing.Size(127, 26);
            userTypeLabel.TabIndex = 22;
            userTypeLabel.Text = "User Type:";
            // 
            // tabApp
            // 
            this.tabApp.Controls.Add(this.User);
            this.tabApp.Controls.Add(this.Screening);
            this.tabApp.Controls.Add(this.Report);
            this.tabApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabApp.Location = new System.Drawing.Point(-2, 58);
            this.tabApp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabApp.Name = "tabApp";
            this.tabApp.SelectedIndex = 0;
            this.tabApp.Size = new System.Drawing.Size(1438, 699);
            this.tabApp.TabIndex = 4;
            // 
            // User
            // 
            this.User.Controls.Add(this.gbUser);
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(4, 29);
            this.User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.User.Size = new System.Drawing.Size(1430, 666);
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
            this.gbUser.Location = new System.Drawing.Point(3, 4);
            this.gbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUser.Name = "gbUser";
            this.gbUser.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUser.Size = new System.Drawing.Size(1425, 648);
            this.gbUser.TabIndex = 2;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User";
            this.gbUser.Enter += new System.EventHandler(this.gbUser_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(560, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(859, 349);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Info;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(186, 102);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(291, 31);
            this.txtUserName.TabIndex = 21;
            // 
            // cboUserType
            // 
            this.cboUserType.BackColor = System.Drawing.SystemColors.Info;
            this.cboUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUserType.FormattingEnabled = true;
            this.cboUserType.Location = new System.Drawing.Point(186, 168);
            this.cboUserType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(291, 33);
            this.cboUserType.TabIndex = 23;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(710, 426);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 75);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit User";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1048, 424);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(184, 76);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset Flagged Status";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(870, 426);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 75);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove User";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(248, 254);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 75);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Screening
            // 
            this.Screening.Controls.Add(this.gbScreen);
            this.Screening.Location = new System.Drawing.Point(4, 29);
            this.Screening.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Screening.Name = "Screening";
            this.Screening.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Screening.Size = new System.Drawing.Size(1430, 666);
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
            this.gbScreen.Location = new System.Drawing.Point(0, 4);
            this.gbScreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbScreen.Size = new System.Drawing.Size(1438, 650);
            this.gbScreen.TabIndex = 3;
            this.gbScreen.TabStop = false;
            this.gbScreen.Text = "Screening";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(310, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(308, 40);
            this.label15.TabIndex = 27;
            this.label15.Text = "Assessment Tool";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(257, 90);
            this.label14.TabIndex = 26;
            this.label14.Text = "Do you have anyof these symptoms?:\r\n1. Fever\r\n 2. Cough \r\n3. Shortness of Breath\r" +
    "\n ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(382, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "In the last 14 days, have you travelled outside of Canada?\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(462, 36);
            this.label12.TabIndex = 24;
            this.label12.Text = "In the last 14 days, have you been in a close contact with anyone who\r\n has been " +
    "tested positive for COVID-19";
            // 
            // dtDate
            // 
            this.dtDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(641, 516);
            this.dtDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(199, 28);
            this.dtDate.TabIndex = 23;
            // 
            // radSymptomsNo
            // 
            this.radSymptomsNo.AutoSize = true;
            this.radSymptomsNo.Checked = true;
            this.radSymptomsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSymptomsNo.Location = new System.Drawing.Point(95, 24);
            this.radSymptomsNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radSymptomsNo.Name = "radSymptomsNo";
            this.radSymptomsNo.Size = new System.Drawing.Size(60, 26);
            this.radSymptomsNo.TabIndex = 22;
            this.radSymptomsNo.TabStop = true;
            this.radSymptomsNo.Text = "No";
            this.radSymptomsNo.UseVisualStyleBackColor = true;
            // 
            // radSymptomsYes
            // 
            this.radSymptomsYes.AutoSize = true;
            this.radSymptomsYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSymptomsYes.Location = new System.Drawing.Point(20, 24);
            this.radSymptomsYes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radSymptomsYes.Name = "radSymptomsYes";
            this.radSymptomsYes.Size = new System.Drawing.Size(69, 26);
            this.radSymptomsYes.TabIndex = 21;
            this.radSymptomsYes.Text = "Yes";
            this.radSymptomsYes.UseVisualStyleBackColor = true;
            // 
            // radTravelledNo
            // 
            this.radTravelledNo.AutoSize = true;
            this.radTravelledNo.Checked = true;
            this.radTravelledNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTravelledNo.Location = new System.Drawing.Point(97, 32);
            this.radTravelledNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radTravelledNo.Name = "radTravelledNo";
            this.radTravelledNo.Size = new System.Drawing.Size(60, 26);
            this.radTravelledNo.TabIndex = 20;
            this.radTravelledNo.TabStop = true;
            this.radTravelledNo.Text = "No";
            this.radTravelledNo.UseVisualStyleBackColor = true;
            // 
            // radTravelledYes
            // 
            this.radTravelledYes.AutoSize = true;
            this.radTravelledYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTravelledYes.Location = new System.Drawing.Point(22, 32);
            this.radTravelledYes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radTravelledYes.Name = "radTravelledYes";
            this.radTravelledYes.Size = new System.Drawing.Size(69, 26);
            this.radTravelledYes.TabIndex = 19;
            this.radTravelledYes.Text = "Yes";
            this.radTravelledYes.UseVisualStyleBackColor = true;
            // 
            // radCloseContactNo
            // 
            this.radCloseContactNo.AutoSize = true;
            this.radCloseContactNo.Checked = true;
            this.radCloseContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCloseContactNo.Location = new System.Drawing.Point(97, 24);
            this.radCloseContactNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radCloseContactNo.Name = "radCloseContactNo";
            this.radCloseContactNo.Size = new System.Drawing.Size(60, 26);
            this.radCloseContactNo.TabIndex = 18;
            this.radCloseContactNo.TabStop = true;
            this.radCloseContactNo.Text = "No";
            this.radCloseContactNo.UseVisualStyleBackColor = true;
            // 
            // radCloseContactYes
            // 
            this.radCloseContactYes.AutoSize = true;
            this.radCloseContactYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCloseContactYes.Location = new System.Drawing.Point(22, 24);
            this.radCloseContactYes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radCloseContactYes.Name = "radCloseContactYes";
            this.radCloseContactYes.Size = new System.Drawing.Size(69, 26);
            this.radCloseContactYes.TabIndex = 17;
            this.radCloseContactYes.Text = "Yes";
            this.radCloseContactYes.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 26);
            this.label11.TabIndex = 9;
            this.label11.Text = "Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "Symptoms:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 26);
            this.label9.TabIndex = 7;
            this.label9.Text = "Travelled:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Close Contact:";
            // 
            // Report
            // 
            this.Report.AutoScroll = true;
            this.Report.Controls.Add(this.gbReport);
            this.Report.Location = new System.Drawing.Point(4, 29);
            this.Report.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Report.Size = new System.Drawing.Size(1430, 666);
            this.Report.TabIndex = 2;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // gbReport
            // 
            this.gbReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbReport.Controls.Add(this.groupBox1);
            this.gbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReport.Location = new System.Drawing.Point(-12, 0);
            this.gbReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbReport.Name = "gbReport";
            this.gbReport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbReport.Size = new System.Drawing.Size(1441, 706);
            this.gbReport.TabIndex = 4;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Report";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(258, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(701, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(342, 107);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "Search by Date";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(342, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Search by Pass/Fail";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(342, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search by User ID";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Location = new System.Drawing.Point(145, 137);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(160, 25);
            this.dateTimePicker3.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(145, 104);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 25);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(145, 64);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 25);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(145, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 25);
            this.textBox1.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(21, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 22);
            this.label19.TabIndex = 3;
            this.label19.Text = "To";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(21, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 22);
            this.label18.TabIndex = 2;
            this.label18.Text = "From";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 22);
            this.label17.TabIndex = 1;
            this.label17.Text = "Pass/Fail";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 22);
            this.label16.TabIndex = 0;
            this.label16.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "COVID SCREENING APPLICATION";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(586, 426);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 75);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboUsers
            // 
            this.cboUsers.DisplayMember = "UserName";
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(344, 65);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(300, 34);
            this.cboUsers.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Select a user";
            // 
            // btnScreeningSave
            // 
            this.btnScreeningSave.Location = new System.Drawing.Point(378, 584);
            this.btnScreeningSave.Name = "btnScreeningSave";
            this.btnScreeningSave.Size = new System.Drawing.Size(201, 46);
            this.btnScreeningSave.TabIndex = 30;
            this.btnScreeningSave.Text = "Save";
            this.btnScreeningSave.UseVisualStyleBackColor = true;
            this.btnScreeningSave.Click += new System.EventHandler(this.btnScreeningSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radCloseContactNo);
            this.panel1.Controls.Add(this.radCloseContactYes);
            this.panel1.Location = new System.Drawing.Point(641, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 80);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radSymptomsYes);
            this.panel2.Controls.Add(this.radSymptomsNo);
            this.panel2.Location = new System.Drawing.Point(643, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 70);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radTravelledYes);
            this.panel3.Controls.Add(this.radTravelledNo);
            this.panel3.Location = new System.Drawing.Point(641, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 83);
            this.panel3.TabIndex = 31;
            // 
            // radFlagUser
            // 
            this.radFlagUser.AutoSize = true;
            this.radFlagUser.Location = new System.Drawing.Point(663, 563);
            this.radFlagUser.Name = "radFlagUser";
            this.radFlagUser.Size = new System.Drawing.Size(140, 30);
            this.radFlagUser.TabIndex = 32;
            this.radFlagUser.TabStop = true;
            this.radFlagUser.Text = "Flag User";
            this.radFlagUser.UseVisualStyleBackColor = true;
            // 
            // frmMainCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1436, 758);
            this.Controls.Add(this.tabApp);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.Report.ResumeLayout(false);
            this.gbReport.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

