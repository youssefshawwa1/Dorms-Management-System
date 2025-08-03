namespace Dorms_Management_System.User_Controls
{
    partial class UserControlCheckInOut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPageAllCheckIn = new System.Windows.Forms.TabPage();
            this.dataGridViewAllChecks = new System.Windows.Forms.DataGridView();
            this.ColumnRentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBedLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBedFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckedOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMustCheckOutOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRentedFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRemainingMonths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.radioButtonCheckedOut = new System.Windows.Forms.RadioButton();
            this.radioButtonNotCheckedOut = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSearchKeyWord = new System.Windows.Forms.TextBox();
            this.tabPageNewCheckIn = new System.Windows.Forms.TabPage();
            this.textBoxTotallToBePayed = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.numericUpDownMonths = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonNewIsOneBed = new System.Windows.Forms.RadioButton();
            this.radioButtonNewIsFullRoom = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonNewIsPremium = new System.Windows.Forms.RadioButton();
            this.radioButtonNewIsNormal = new System.Windows.Forms.RadioButton();
            this.buttonPayLater = new System.Windows.Forms.Button();
            this.buttonPayNow = new System.Windows.Forms.Button();
            this.listBoxNewFeatures = new System.Windows.Forms.ListBox();
            this.listBoxNewServices = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMustCheckOutOn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMonthsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBedFeatures = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelRoomServices = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNewCheckInBed = new System.Windows.Forms.ComboBox();
            this.comboBoxNewCheckInRoom = new System.Windows.Forms.ComboBox();
            this.comboBoxNewCheckInClient = new System.Windows.Forms.ComboBox();
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPageAllCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllChecks)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPageNewCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonths)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageAllCheckIn
            // 
            this.tabPageAllCheckIn.Controls.Add(this.dataGridViewAllChecks);
            this.tabPageAllCheckIn.Controls.Add(this.panel3);
            this.tabPageAllCheckIn.Location = new System.Drawing.Point(4, 26);
            this.tabPageAllCheckIn.Name = "tabPageAllCheckIn";
            this.tabPageAllCheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllCheckIn.Size = new System.Drawing.Size(1045, 514);
            this.tabPageAllCheckIn.TabIndex = 1;
            this.tabPageAllCheckIn.Text = "All Check Ins";
            this.tabPageAllCheckIn.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAllChecks
            // 
            this.dataGridViewAllChecks.AllowUserToAddRows = false;
            this.dataGridViewAllChecks.AllowUserToDeleteRows = false;
            this.dataGridViewAllChecks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAllChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllChecks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRentID,
            this.ColumnClientID,
            this.ColumnFullName,
            this.ColumnPhoneNumber,
            this.ColumnRoomNumber,
            this.ColumnBedLabel,
            this.ColumnType,
            this.ColumnRoomType,
            this.ColumnRoomServices,
            this.ColumnBedFeatures,
            this.ColumnCheckInDate,
            this.ColumnCheckedOutDate,
            this.ColumnMustCheckOutOn,
            this.ColumnRentedFor,
            this.ColumnRemainingMonths,
            this.ColumnAddedBy,
            this.ColumnRoomID,
            this.ColumnBedID});
            this.dataGridViewAllChecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAllChecks.Location = new System.Drawing.Point(3, 176);
            this.dataGridViewAllChecks.Name = "dataGridViewAllChecks";
            this.dataGridViewAllChecks.ReadOnly = true;
            this.dataGridViewAllChecks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllChecks.Size = new System.Drawing.Size(1039, 335);
            this.dataGridViewAllChecks.TabIndex = 5;
            this.dataGridViewAllChecks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllChecks_CellClick);
            // 
            // ColumnRentID
            // 
            this.ColumnRentID.HeaderText = "RentID";
            this.ColumnRentID.Name = "ColumnRentID";
            this.ColumnRentID.ReadOnly = true;
            this.ColumnRentID.Visible = false;
            // 
            // ColumnClientID
            // 
            this.ColumnClientID.HeaderText = "ClientID";
            this.ColumnClientID.Name = "ColumnClientID";
            this.ColumnClientID.ReadOnly = true;
            this.ColumnClientID.Visible = false;
            // 
            // ColumnFullName
            // 
            this.ColumnFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFullName.HeaderText = "Full Name";
            this.ColumnFullName.MinimumWidth = 97;
            this.ColumnFullName.Name = "ColumnFullName";
            this.ColumnFullName.ReadOnly = true;
            // 
            // ColumnPhoneNumber
            // 
            this.ColumnPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPhoneNumber.HeaderText = "Phone";
            this.ColumnPhoneNumber.MinimumWidth = 74;
            this.ColumnPhoneNumber.Name = "ColumnPhoneNumber";
            this.ColumnPhoneNumber.ReadOnly = true;
            // 
            // ColumnRoomNumber
            // 
            this.ColumnRoomNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRoomNumber.HeaderText = "Room";
            this.ColumnRoomNumber.MinimumWidth = 70;
            this.ColumnRoomNumber.Name = "ColumnRoomNumber";
            this.ColumnRoomNumber.ReadOnly = true;
            // 
            // ColumnBedLabel
            // 
            this.ColumnBedLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBedLabel.HeaderText = "Bed";
            this.ColumnBedLabel.MinimumWidth = 57;
            this.ColumnBedLabel.Name = "ColumnBedLabel";
            this.ColumnBedLabel.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.MinimumWidth = 80;
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnRoomType
            // 
            this.ColumnRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRoomType.HeaderText = "Room Type";
            this.ColumnRoomType.MinimumWidth = 50;
            this.ColumnRoomType.Name = "ColumnRoomType";
            this.ColumnRoomType.ReadOnly = true;
            // 
            // ColumnRoomServices
            // 
            this.ColumnRoomServices.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRoomServices.HeaderText = "Services";
            this.ColumnRoomServices.MinimumWidth = 60;
            this.ColumnRoomServices.Name = "ColumnRoomServices";
            this.ColumnRoomServices.ReadOnly = true;
            // 
            // ColumnBedFeatures
            // 
            this.ColumnBedFeatures.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBedFeatures.HeaderText = "Features";
            this.ColumnBedFeatures.MinimumWidth = 60;
            this.ColumnBedFeatures.Name = "ColumnBedFeatures";
            this.ColumnBedFeatures.ReadOnly = true;
            // 
            // ColumnCheckInDate
            // 
            this.ColumnCheckInDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCheckInDate.HeaderText = "In";
            this.ColumnCheckInDate.MinimumWidth = 70;
            this.ColumnCheckInDate.Name = "ColumnCheckInDate";
            this.ColumnCheckInDate.ReadOnly = true;
            // 
            // ColumnCheckedOutDate
            // 
            this.ColumnCheckedOutDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCheckedOutDate.HeaderText = "Out";
            this.ColumnCheckedOutDate.MinimumWidth = 70;
            this.ColumnCheckedOutDate.Name = "ColumnCheckedOutDate";
            this.ColumnCheckedOutDate.ReadOnly = true;
            // 
            // ColumnMustCheckOutOn
            // 
            this.ColumnMustCheckOutOn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnMustCheckOutOn.HeaderText = "Must Check Out On";
            this.ColumnMustCheckOutOn.MinimumWidth = 100;
            this.ColumnMustCheckOutOn.Name = "ColumnMustCheckOutOn";
            this.ColumnMustCheckOutOn.ReadOnly = true;
            // 
            // ColumnRentedFor
            // 
            this.ColumnRentedFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRentedFor.HeaderText = "Duration (Months)";
            this.ColumnRentedFor.MinimumWidth = 70;
            this.ColumnRentedFor.Name = "ColumnRentedFor";
            this.ColumnRentedFor.ReadOnly = true;
            // 
            // ColumnRemainingMonths
            // 
            this.ColumnRemainingMonths.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRemainingMonths.HeaderText = "Remaining (Months)";
            this.ColumnRemainingMonths.MinimumWidth = 70;
            this.ColumnRemainingMonths.Name = "ColumnRemainingMonths";
            this.ColumnRemainingMonths.ReadOnly = true;
            // 
            // ColumnAddedBy
            // 
            this.ColumnAddedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAddedBy.HeaderText = "By";
            this.ColumnAddedBy.MinimumWidth = 50;
            this.ColumnAddedBy.Name = "ColumnAddedBy";
            this.ColumnAddedBy.ReadOnly = true;
            // 
            // ColumnRoomID
            // 
            this.ColumnRoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRoomID.HeaderText = "RoomID";
            this.ColumnRoomID.MinimumWidth = 70;
            this.ColumnRoomID.Name = "ColumnRoomID";
            this.ColumnRoomID.ReadOnly = true;
            this.ColumnRoomID.Visible = false;
            // 
            // ColumnBedID
            // 
            this.ColumnBedID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBedID.HeaderText = "BedID";
            this.ColumnBedID.MinimumWidth = 100;
            this.ColumnBedID.Name = "ColumnBedID";
            this.ColumnBedID.ReadOnly = true;
            this.ColumnBedID.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCheckOut);
            this.panel3.Controls.Add(this.radioButtonCheckedOut);
            this.panel3.Controls.Add(this.radioButtonNotCheckedOut);
            this.panel3.Controls.Add(this.radioButtonAll);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBoxSearchKeyWord);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1039, 173);
            this.panel3.TabIndex = 8;
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.buttonCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckOut.FlatAppearance.BorderSize = 0;
            this.buttonCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonCheckOut.Location = new System.Drawing.Point(897, 80);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(120, 45);
            this.buttonCheckOut.TabIndex = 6;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = false;
            this.buttonCheckOut.Visible = false;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // radioButtonCheckedOut
            // 
            this.radioButtonCheckedOut.AutoSize = true;
            this.radioButtonCheckedOut.Location = new System.Drawing.Point(352, 58);
            this.radioButtonCheckedOut.Name = "radioButtonCheckedOut";
            this.radioButtonCheckedOut.Size = new System.Drawing.Size(113, 21);
            this.radioButtonCheckedOut.TabIndex = 2;
            this.radioButtonCheckedOut.Text = "Checked Out";
            this.radioButtonCheckedOut.UseVisualStyleBackColor = true;
            this.radioButtonCheckedOut.CheckedChanged += new System.EventHandler(this.radioButtonCheckedOut_CheckedChanged);
            // 
            // radioButtonNotCheckedOut
            // 
            this.radioButtonNotCheckedOut.AutoSize = true;
            this.radioButtonNotCheckedOut.Checked = true;
            this.radioButtonNotCheckedOut.Location = new System.Drawing.Point(173, 58);
            this.radioButtonNotCheckedOut.Name = "radioButtonNotCheckedOut";
            this.radioButtonNotCheckedOut.Size = new System.Drawing.Size(141, 21);
            this.radioButtonNotCheckedOut.TabIndex = 1;
            this.radioButtonNotCheckedOut.TabStop = true;
            this.radioButtonNotCheckedOut.Text = "Not Checked Out";
            this.radioButtonNotCheckedOut.UseVisualStyleBackColor = true;
            this.radioButtonNotCheckedOut.CheckedChanged += new System.EventHandler(this.radioButtonNotCheckedOut_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(529, 58);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(41, 21);
            this.radioButtonAll.TabIndex = 3;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label21.Location = new System.Drawing.Point(29, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "Search:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label8.Location = new System.Drawing.Point(29, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Filter By: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label11.Location = new System.Drawing.Point(31, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "All Check IN/OUT";
            // 
            // textBoxSearchKeyWord
            // 
            this.textBoxSearchKeyWord.Location = new System.Drawing.Point(173, 91);
            this.textBoxSearchKeyWord.Name = "textBoxSearchKeyWord";
            this.textBoxSearchKeyWord.Size = new System.Drawing.Size(220, 23);
            this.textBoxSearchKeyWord.TabIndex = 4;
            this.textBoxSearchKeyWord.TextChanged += new System.EventHandler(this.textBoxSearchKeyWord_TextChanged);
            // 
            // tabPageNewCheckIn
            // 
            this.tabPageNewCheckIn.Controls.Add(this.textBoxTotallToBePayed);
            this.tabPageNewCheckIn.Controls.Add(this.textBoxTotal);
            this.tabPageNewCheckIn.Controls.Add(this.numericUpDownMonths);
            this.tabPageNewCheckIn.Controls.Add(this.panel2);
            this.tabPageNewCheckIn.Controls.Add(this.panel1);
            this.tabPageNewCheckIn.Controls.Add(this.buttonPayLater);
            this.tabPageNewCheckIn.Controls.Add(this.buttonPayNow);
            this.tabPageNewCheckIn.Controls.Add(this.listBoxNewFeatures);
            this.tabPageNewCheckIn.Controls.Add(this.listBoxNewServices);
            this.tabPageNewCheckIn.Controls.Add(this.label7);
            this.tabPageNewCheckIn.Controls.Add(this.labelMustCheckOutOn);
            this.tabPageNewCheckIn.Controls.Add(this.label5);
            this.tabPageNewCheckIn.Controls.Add(this.label6);
            this.tabPageNewCheckIn.Controls.Add(this.labelMonthsCount);
            this.tabPageNewCheckIn.Controls.Add(this.label4);
            this.tabPageNewCheckIn.Controls.Add(this.label3);
            this.tabPageNewCheckIn.Controls.Add(this.labelBedFeatures);
            this.tabPageNewCheckIn.Controls.Add(this.label10);
            this.tabPageNewCheckIn.Controls.Add(this.labelRoomServices);
            this.tabPageNewCheckIn.Controls.Add(this.label9);
            this.tabPageNewCheckIn.Controls.Add(this.label2);
            this.tabPageNewCheckIn.Controls.Add(this.label1);
            this.tabPageNewCheckIn.Controls.Add(this.comboBoxNewCheckInBed);
            this.tabPageNewCheckIn.Controls.Add(this.comboBoxNewCheckInRoom);
            this.tabPageNewCheckIn.Controls.Add(this.comboBoxNewCheckInClient);
            this.tabPageNewCheckIn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabPageNewCheckIn.Location = new System.Drawing.Point(4, 26);
            this.tabPageNewCheckIn.Name = "tabPageNewCheckIn";
            this.tabPageNewCheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewCheckIn.Size = new System.Drawing.Size(1045, 514);
            this.tabPageNewCheckIn.TabIndex = 0;
            this.tabPageNewCheckIn.Text = "Check In";
            this.tabPageNewCheckIn.UseVisualStyleBackColor = true;
            this.tabPageNewCheckIn.Click += new System.EventHandler(this.tabPageNewCheckIn_Click);
            // 
            // textBoxTotallToBePayed
            // 
            this.textBoxTotallToBePayed.Location = new System.Drawing.Point(175, 293);
            this.textBoxTotallToBePayed.Name = "textBoxTotallToBePayed";
            this.textBoxTotallToBePayed.Size = new System.Drawing.Size(228, 23);
            this.textBoxTotallToBePayed.TabIndex = 11;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(174, 254);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(228, 23);
            this.textBoxTotal.TabIndex = 13;
            // 
            // numericUpDownMonths
            // 
            this.numericUpDownMonths.Location = new System.Drawing.Point(174, 193);
            this.numericUpDownMonths.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonths.Name = "numericUpDownMonths";
            this.numericUpDownMonths.Size = new System.Drawing.Size(228, 23);
            this.numericUpDownMonths.TabIndex = 8;
            this.numericUpDownMonths.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonths.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonNewIsOneBed);
            this.panel2.Controls.Add(this.radioButtonNewIsFullRoom);
            this.panel2.Location = new System.Drawing.Point(174, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 28);
            this.panel2.TabIndex = 11;
            // 
            // radioButtonNewIsOneBed
            // 
            this.radioButtonNewIsOneBed.AutoSize = true;
            this.radioButtonNewIsOneBed.Checked = true;
            this.radioButtonNewIsOneBed.Location = new System.Drawing.Point(14, 4);
            this.radioButtonNewIsOneBed.Name = "radioButtonNewIsOneBed";
            this.radioButtonNewIsOneBed.Size = new System.Drawing.Size(81, 21);
            this.radioButtonNewIsOneBed.TabIndex = 2;
            this.radioButtonNewIsOneBed.TabStop = true;
            this.radioButtonNewIsOneBed.Text = "One Bed";
            this.radioButtonNewIsOneBed.UseVisualStyleBackColor = true;
            // 
            // radioButtonNewIsFullRoom
            // 
            this.radioButtonNewIsFullRoom.AutoSize = true;
            this.radioButtonNewIsFullRoom.Location = new System.Drawing.Point(132, 4);
            this.radioButtonNewIsFullRoom.Name = "radioButtonNewIsFullRoom";
            this.radioButtonNewIsFullRoom.Size = new System.Drawing.Size(89, 21);
            this.radioButtonNewIsFullRoom.TabIndex = 3;
            this.radioButtonNewIsFullRoom.Text = "Full Room";
            this.radioButtonNewIsFullRoom.UseVisualStyleBackColor = true;
            this.radioButtonNewIsFullRoom.CheckedChanged += new System.EventHandler(this.radioButtonNewIsFullRoom_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonNewIsPremium);
            this.panel1.Controls.Add(this.radioButtonNewIsNormal);
            this.panel1.Location = new System.Drawing.Point(174, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 28);
            this.panel1.TabIndex = 10;
            // 
            // radioButtonNewIsPremium
            // 
            this.radioButtonNewIsPremium.AutoSize = true;
            this.radioButtonNewIsPremium.Location = new System.Drawing.Point(132, 7);
            this.radioButtonNewIsPremium.Name = "radioButtonNewIsPremium";
            this.radioButtonNewIsPremium.Size = new System.Drawing.Size(83, 21);
            this.radioButtonNewIsPremium.TabIndex = 5;
            this.radioButtonNewIsPremium.Text = "Premium";
            this.radioButtonNewIsPremium.UseVisualStyleBackColor = true;
            this.radioButtonNewIsPremium.CheckedChanged += new System.EventHandler(this.radioButtonNewIsPremium_CheckedChanged);
            // 
            // radioButtonNewIsNormal
            // 
            this.radioButtonNewIsNormal.AutoSize = true;
            this.radioButtonNewIsNormal.Checked = true;
            this.radioButtonNewIsNormal.Location = new System.Drawing.Point(14, 7);
            this.radioButtonNewIsNormal.Name = "radioButtonNewIsNormal";
            this.radioButtonNewIsNormal.Size = new System.Drawing.Size(74, 21);
            this.radioButtonNewIsNormal.TabIndex = 4;
            this.radioButtonNewIsNormal.TabStop = true;
            this.radioButtonNewIsNormal.Text = "Normal";
            this.radioButtonNewIsNormal.UseVisualStyleBackColor = true;
            // 
            // buttonPayLater
            // 
            this.buttonPayLater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.buttonPayLater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPayLater.FlatAppearance.BorderSize = 0;
            this.buttonPayLater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayLater.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayLater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonPayLater.Location = new System.Drawing.Point(188, 336);
            this.buttonPayLater.Name = "buttonPayLater";
            this.buttonPayLater.Size = new System.Drawing.Size(120, 45);
            this.buttonPayLater.TabIndex = 13;
            this.buttonPayLater.Text = "Pay Later";
            this.buttonPayLater.UseVisualStyleBackColor = false;
            this.buttonPayLater.Click += new System.EventHandler(this.buttonPayLater_Click);
            // 
            // buttonPayNow
            // 
            this.buttonPayNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.buttonPayNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPayNow.FlatAppearance.BorderSize = 0;
            this.buttonPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayNow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonPayNow.Location = new System.Drawing.Point(31, 336);
            this.buttonPayNow.Name = "buttonPayNow";
            this.buttonPayNow.Size = new System.Drawing.Size(120, 45);
            this.buttonPayNow.TabIndex = 12;
            this.buttonPayNow.Text = "Pay Now";
            this.buttonPayNow.UseVisualStyleBackColor = false;
            this.buttonPayNow.Click += new System.EventHandler(this.buttonPayNow_Click);
            // 
            // listBoxNewFeatures
            // 
            this.listBoxNewFeatures.FormattingEnabled = true;
            this.listBoxNewFeatures.ItemHeight = 17;
            this.listBoxNewFeatures.Location = new System.Drawing.Point(440, 222);
            this.listBoxNewFeatures.Name = "listBoxNewFeatures";
            this.listBoxNewFeatures.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxNewFeatures.Size = new System.Drawing.Size(315, 123);
            this.listBoxNewFeatures.TabIndex = 10;
            this.listBoxNewFeatures.SelectedIndexChanged += new System.EventHandler(this.listBoxNewFeatures_SelectedIndexChanged);
            // 
            // listBoxNewServices
            // 
            this.listBoxNewServices.FormattingEnabled = true;
            this.listBoxNewServices.ItemHeight = 17;
            this.listBoxNewServices.Location = new System.Drawing.Point(440, 50);
            this.listBoxNewServices.Name = "listBoxNewServices";
            this.listBoxNewServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxNewServices.Size = new System.Drawing.Size(315, 123);
            this.listBoxNewServices.TabIndex = 9;
            this.listBoxNewServices.SelectedIndexChanged += new System.EventHandler(this.listBoxNewServices_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label7.Location = new System.Drawing.Point(29, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total to be Payed: ";
            // 
            // labelMustCheckOutOn
            // 
            this.labelMustCheckOutOn.AutoSize = true;
            this.labelMustCheckOutOn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustCheckOutOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.labelMustCheckOutOn.Location = new System.Drawing.Point(172, 226);
            this.labelMustCheckOutOn.Name = "labelMustCheckOutOn";
            this.labelMustCheckOutOn.Size = new System.Drawing.Size(14, 16);
            this.labelMustCheckOutOn.TabIndex = 4;
            this.labelMustCheckOutOn.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label5.Location = new System.Drawing.Point(28, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label6.Location = new System.Drawing.Point(28, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Must Check Out On: ";
            // 
            // labelMonthsCount
            // 
            this.labelMonthsCount.AutoSize = true;
            this.labelMonthsCount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.labelMonthsCount.Location = new System.Drawing.Point(28, 193);
            this.labelMonthsCount.Name = "labelMonthsCount";
            this.labelMonthsCount.Size = new System.Drawing.Size(57, 16);
            this.labelMonthsCount.TabIndex = 0;
            this.labelMonthsCount.Text = "Months:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label4.Location = new System.Drawing.Point(28, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bed: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room: ";
            // 
            // labelBedFeatures
            // 
            this.labelBedFeatures.AutoSize = true;
            this.labelBedFeatures.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBedFeatures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.labelBedFeatures.Location = new System.Drawing.Point(437, 199);
            this.labelBedFeatures.Name = "labelBedFeatures";
            this.labelBedFeatures.Size = new System.Drawing.Size(158, 16);
            this.labelBedFeatures.TabIndex = 4;
            this.labelBedFeatures.Text = "Bed Feature (Monthly): ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label10.Location = new System.Drawing.Point(28, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Type: ";
            // 
            // labelRoomServices
            // 
            this.labelRoomServices.AutoSize = true;
            this.labelRoomServices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.labelRoomServices.Location = new System.Drawing.Point(437, 31);
            this.labelRoomServices.Name = "labelRoomServices";
            this.labelRoomServices.Size = new System.Drawing.Size(174, 16);
            this.labelRoomServices.TabIndex = 4;
            this.labelRoomServices.Text = "Room Services (Monthly): ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label9.Location = new System.Drawing.Point(28, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Room Or Bed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label2.Location = new System.Drawing.Point(28, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Check In:";
            // 
            // comboBoxNewCheckInBed
            // 
            this.comboBoxNewCheckInBed.FormattingEnabled = true;
            this.comboBoxNewCheckInBed.Location = new System.Drawing.Point(175, 159);
            this.comboBoxNewCheckInBed.Name = "comboBoxNewCheckInBed";
            this.comboBoxNewCheckInBed.Size = new System.Drawing.Size(227, 25);
            this.comboBoxNewCheckInBed.TabIndex = 7;
            this.comboBoxNewCheckInBed.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNewCheckInBed_SelectionChangeCommitted);
            // 
            // comboBoxNewCheckInRoom
            // 
            this.comboBoxNewCheckInRoom.FormattingEnabled = true;
            this.comboBoxNewCheckInRoom.Location = new System.Drawing.Point(175, 126);
            this.comboBoxNewCheckInRoom.Name = "comboBoxNewCheckInRoom";
            this.comboBoxNewCheckInRoom.Size = new System.Drawing.Size(227, 25);
            this.comboBoxNewCheckInRoom.TabIndex = 6;
            this.comboBoxNewCheckInRoom.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNewCheckInRoom_SelectionChangeCommitted);
            // 
            // comboBoxNewCheckInClient
            // 
            this.comboBoxNewCheckInClient.FormattingEnabled = true;
            this.comboBoxNewCheckInClient.Location = new System.Drawing.Point(175, 31);
            this.comboBoxNewCheckInClient.Name = "comboBoxNewCheckInClient";
            this.comboBoxNewCheckInClient.Size = new System.Drawing.Size(227, 25);
            this.comboBoxNewCheckInClient.TabIndex = 1;
            this.comboBoxNewCheckInClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewCheckInClient_SelectedIndexChanged);
            this.comboBoxNewCheckInClient.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNewCheckInClient_SelectionChangeCommitted);
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Controls.Add(this.tabPageNewCheckIn);
            this.tabControlOptions.Controls.Add(this.tabPageAllCheckIn);
            this.tabControlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOptions.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabControlOptions.Location = new System.Drawing.Point(0, 0);
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Size = new System.Drawing.Size(1053, 544);
            this.tabControlOptions.TabIndex = 0;
            // 
            // UserControlCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlOptions);
            this.Name = "UserControlCheckInOut";
            this.Size = new System.Drawing.Size(1053, 544);
            this.Enter += new System.EventHandler(this.UserControlCheckInOut_Enter);
            this.tabPageAllCheckIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllChecks)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPageNewCheckIn.ResumeLayout(false);
            this.tabPageNewCheckIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonths)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageAllCheckIn;
        private System.Windows.Forms.TabPage tabPageNewCheckIn;
        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNewCheckInClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxNewCheckInRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNewCheckInBed;
        private System.Windows.Forms.ListBox listBoxNewFeatures;
        private System.Windows.Forms.ListBox listBoxNewServices;
        private System.Windows.Forms.Label labelRoomServices;
        private System.Windows.Forms.Label labelBedFeatures;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonPayNow;
        private System.Windows.Forms.Button buttonPayLater;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonNewIsOneBed;
        private System.Windows.Forms.RadioButton radioButtonNewIsFullRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonNewIsPremium;
        private System.Windows.Forms.RadioButton radioButtonNewIsNormal;
        private System.Windows.Forms.NumericUpDown numericUpDownMonths;
        private System.Windows.Forms.Label labelMonthsCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMustCheckOutOn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxTotallToBePayed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewAllChecks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonCheckedOut;
        private System.Windows.Forms.RadioButton radioButtonNotCheckedOut;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSearchKeyWord;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBedLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBedFeatures;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckedOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMustCheckOutOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRentedFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemainingMonths;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBedID;
    }
}
