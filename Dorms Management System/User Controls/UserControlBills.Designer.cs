namespace Dorms_Management_System.User_Controls
{
    partial class UserControlBills
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
            this.tabPageAllBills = new System.Windows.Forms.TabPage();
            this.dataGridViewBills = new System.Windows.Forms.DataGridView();
            this.ColumnBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBedLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsPayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPayedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnToBePayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonPayNow = new System.Windows.Forms.Button();
            this.radioButtonPayed = new System.Windows.Forms.RadioButton();
            this.radioButtonNotPayed = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSearchKeyWord = new System.Windows.Forms.TextBox();
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPagePay = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxUpdateCurrent = new System.Windows.Forms.GroupBox();
            this.checkBoxAsPayed = new System.Windows.Forms.CheckBox();
            this.textBoxPayedNow = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxWillRemain = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxRemaining = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxAlreadyPayed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxToBePayed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelBillDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRoomtType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.tabPageAllBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControlOptions.SuspendLayout();
            this.tabPagePay.SuspendLayout();
            this.groupBoxUpdateCurrent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageAllBills
            // 
            this.tabPageAllBills.Controls.Add(this.dataGridViewBills);
            this.tabPageAllBills.Controls.Add(this.panel3);
            this.tabPageAllBills.Location = new System.Drawing.Point(4, 26);
            this.tabPageAllBills.Name = "tabPageAllBills";
            this.tabPageAllBills.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllBills.Size = new System.Drawing.Size(1045, 514);
            this.tabPageAllBills.TabIndex = 1;
            this.tabPageAllBills.Text = "Bills";
            this.tabPageAllBills.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBills
            // 
            this.dataGridViewBills.AllowUserToAddRows = false;
            this.dataGridViewBills.AllowUserToDeleteRows = false;
            this.dataGridViewBills.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBillID,
            this.ColumnRentID,
            this.ColumnFullName,
            this.ColumnPhoneNumber,
            this.ColumnRoomNumber,
            this.ColumnBedLabel,
            this.ColumnType,
            this.ColumnRoomType,
            this.ColumnIsPayed,
            this.ColumnBillDate,
            this.ColumnPayedDate,
            this.ColumnTotal,
            this.ColumnToBePayed,
            this.ColumnPayed,
            this.ColumnRemaining,
            this.ColumnAddedBy});
            this.dataGridViewBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBills.Location = new System.Drawing.Point(3, 186);
            this.dataGridViewBills.Name = "dataGridViewBills";
            this.dataGridViewBills.ReadOnly = true;
            this.dataGridViewBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBills.Size = new System.Drawing.Size(1039, 325);
            this.dataGridViewBills.TabIndex = 5;
            this.dataGridViewBills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBills_CellClick);
            // 
            // ColumnBillID
            // 
            this.ColumnBillID.HeaderText = "BillID";
            this.ColumnBillID.Name = "ColumnBillID";
            this.ColumnBillID.ReadOnly = true;
            this.ColumnBillID.Visible = false;
            // 
            // ColumnRentID
            // 
            this.ColumnRentID.HeaderText = "RentID";
            this.ColumnRentID.Name = "ColumnRentID";
            this.ColumnRentID.ReadOnly = true;
            this.ColumnRentID.Visible = false;
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
            // ColumnIsPayed
            // 
            this.ColumnIsPayed.HeaderText = "Is Payed";
            this.ColumnIsPayed.Name = "ColumnIsPayed";
            this.ColumnIsPayed.ReadOnly = true;
            // 
            // ColumnBillDate
            // 
            this.ColumnBillDate.HeaderText = "Bill Date";
            this.ColumnBillDate.Name = "ColumnBillDate";
            this.ColumnBillDate.ReadOnly = true;
            // 
            // ColumnPayedDate
            // 
            this.ColumnPayedDate.HeaderText = "Payed Date";
            this.ColumnPayedDate.Name = "ColumnPayedDate";
            this.ColumnPayedDate.ReadOnly = true;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            // 
            // ColumnToBePayed
            // 
            this.ColumnToBePayed.HeaderText = "To Be Payed";
            this.ColumnToBePayed.Name = "ColumnToBePayed";
            this.ColumnToBePayed.ReadOnly = true;
            // 
            // ColumnPayed
            // 
            this.ColumnPayed.HeaderText = "Payed";
            this.ColumnPayed.Name = "ColumnPayed";
            this.ColumnPayed.ReadOnly = true;
            // 
            // ColumnRemaining
            // 
            this.ColumnRemaining.HeaderText = "Remain";
            this.ColumnRemaining.Name = "ColumnRemaining";
            this.ColumnRemaining.ReadOnly = true;
            // 
            // ColumnAddedBy
            // 
            this.ColumnAddedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAddedBy.HeaderText = "By";
            this.ColumnAddedBy.MinimumWidth = 50;
            this.ColumnAddedBy.Name = "ColumnAddedBy";
            this.ColumnAddedBy.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonPayNow);
            this.panel3.Controls.Add(this.radioButtonPayed);
            this.panel3.Controls.Add(this.radioButtonNotPayed);
            this.panel3.Controls.Add(this.radioButtonAll);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBoxSearchKeyWord);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1039, 183);
            this.panel3.TabIndex = 8;
            // 
            // buttonPayNow
            // 
            this.buttonPayNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPayNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.buttonPayNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPayNow.FlatAppearance.BorderSize = 0;
            this.buttonPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayNow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonPayNow.Location = new System.Drawing.Point(897, 80);
            this.buttonPayNow.Name = "buttonPayNow";
            this.buttonPayNow.Size = new System.Drawing.Size(120, 45);
            this.buttonPayNow.TabIndex = 6;
            this.buttonPayNow.Text = "Pay Now";
            this.buttonPayNow.UseVisualStyleBackColor = false;
            this.buttonPayNow.Visible = false;
            this.buttonPayNow.Click += new System.EventHandler(this.buttonPayNow_Click);
            // 
            // radioButtonPayed
            // 
            this.radioButtonPayed.AutoSize = true;
            this.radioButtonPayed.Location = new System.Drawing.Point(352, 58);
            this.radioButtonPayed.Name = "radioButtonPayed";
            this.radioButtonPayed.Size = new System.Drawing.Size(66, 21);
            this.radioButtonPayed.TabIndex = 2;
            this.radioButtonPayed.Text = "Payed";
            this.radioButtonPayed.UseVisualStyleBackColor = true;
            this.radioButtonPayed.CheckedChanged += new System.EventHandler(this.radioButtonPayed_CheckedChanged);
            // 
            // radioButtonNotPayed
            // 
            this.radioButtonNotPayed.AutoSize = true;
            this.radioButtonNotPayed.Checked = true;
            this.radioButtonNotPayed.Location = new System.Drawing.Point(173, 58);
            this.radioButtonNotPayed.Name = "radioButtonNotPayed";
            this.radioButtonNotPayed.Size = new System.Drawing.Size(94, 21);
            this.radioButtonNotPayed.TabIndex = 1;
            this.radioButtonNotPayed.TabStop = true;
            this.radioButtonNotPayed.Text = "Not Payed";
            this.radioButtonNotPayed.UseVisualStyleBackColor = true;
            this.radioButtonNotPayed.CheckedChanged += new System.EventHandler(this.radioButtonNotPayed_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(517, 58);
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
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "All Bills:";
            // 
            // textBoxSearchKeyWord
            // 
            this.textBoxSearchKeyWord.Location = new System.Drawing.Point(173, 91);
            this.textBoxSearchKeyWord.Name = "textBoxSearchKeyWord";
            this.textBoxSearchKeyWord.Size = new System.Drawing.Size(220, 23);
            this.textBoxSearchKeyWord.TabIndex = 4;
            this.textBoxSearchKeyWord.TextChanged += new System.EventHandler(this.textBoxSearchKeyWord_TextChanged);
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Controls.Add(this.tabPageAllBills);
            this.tabControlOptions.Controls.Add(this.tabPagePay);
            this.tabControlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOptions.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabControlOptions.Location = new System.Drawing.Point(0, 0);
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Size = new System.Drawing.Size(1053, 544);
            this.tabControlOptions.TabIndex = 1;
            // 
            // tabPagePay
            // 
            this.tabPagePay.Controls.Add(this.label9);
            this.tabPagePay.Controls.Add(this.groupBoxUpdateCurrent);
            this.tabPagePay.Location = new System.Drawing.Point(4, 26);
            this.tabPagePay.Name = "tabPagePay";
            this.tabPagePay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePay.Size = new System.Drawing.Size(1045, 514);
            this.tabPagePay.TabIndex = 2;
            this.tabPagePay.Text = "Pay Bill";
            this.tabPagePay.UseVisualStyleBackColor = true;
            this.tabPagePay.Leave += new System.EventHandler(this.tabPagePay_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label9.Location = new System.Drawing.Point(10, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Pay The Bill Now: ";
            // 
            // groupBoxUpdateCurrent
            // 
            this.groupBoxUpdateCurrent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxUpdateCurrent.Controls.Add(this.checkBoxAsPayed);
            this.groupBoxUpdateCurrent.Controls.Add(this.textBoxPayedNow);
            this.groupBoxUpdateCurrent.Controls.Add(this.label13);
            this.groupBoxUpdateCurrent.Controls.Add(this.textBoxWillRemain);
            this.groupBoxUpdateCurrent.Controls.Add(this.label14);
            this.groupBoxUpdateCurrent.Controls.Add(this.textBoxRemaining);
            this.groupBoxUpdateCurrent.Controls.Add(this.label19);
            this.groupBoxUpdateCurrent.Controls.Add(this.textBoxAlreadyPayed);
            this.groupBoxUpdateCurrent.Controls.Add(this.label10);
            this.groupBoxUpdateCurrent.Controls.Add(this.textBoxToBePayed);
            this.groupBoxUpdateCurrent.Controls.Add(this.label7);
            this.groupBoxUpdateCurrent.Controls.Add(this.textBoxTotal);
            this.groupBoxUpdateCurrent.Controls.Add(this.label6);
            this.groupBoxUpdateCurrent.Controls.Add(this.labelBillDate);
            this.groupBoxUpdateCurrent.Controls.Add(this.label5);
            this.groupBoxUpdateCurrent.Controls.Add(this.labelRoomtType);
            this.groupBoxUpdateCurrent.Controls.Add(this.label4);
            this.groupBoxUpdateCurrent.Controls.Add(this.labelType);
            this.groupBoxUpdateCurrent.Controls.Add(this.label3);
            this.groupBoxUpdateCurrent.Controls.Add(this.labelBed);
            this.groupBoxUpdateCurrent.Controls.Add(this.label2);
            this.groupBoxUpdateCurrent.Controls.Add(this.labelRoomNumber);
            this.groupBoxUpdateCurrent.Controls.Add(this.label12);
            this.groupBoxUpdateCurrent.Controls.Add(this.labelFullName);
            this.groupBoxUpdateCurrent.Controls.Add(this.label1);
            this.groupBoxUpdateCurrent.Controls.Add(this.buttonPay);
            this.groupBoxUpdateCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxUpdateCurrent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUpdateCurrent.Location = new System.Drawing.Point(13, 49);
            this.groupBoxUpdateCurrent.Name = "groupBoxUpdateCurrent";
            this.groupBoxUpdateCurrent.Size = new System.Drawing.Size(714, 329);
            this.groupBoxUpdateCurrent.TabIndex = 0;
            this.groupBoxUpdateCurrent.TabStop = false;
            this.groupBoxUpdateCurrent.Enter += new System.EventHandler(this.groupBoxUpdateCurrent_Enter);
            // 
            // checkBoxAsPayed
            // 
            this.checkBoxAsPayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAsPayed.AutoSize = true;
            this.checkBoxAsPayed.Location = new System.Drawing.Point(345, 203);
            this.checkBoxAsPayed.Name = "checkBoxAsPayed";
            this.checkBoxAsPayed.Size = new System.Drawing.Size(110, 21);
            this.checkBoxAsPayed.TabIndex = 2;
            this.checkBoxAsPayed.Text = "Put as Payed";
            this.checkBoxAsPayed.UseVisualStyleBackColor = true;
            // 
            // textBoxPayedNow
            // 
            this.textBoxPayedNow.Location = new System.Drawing.Point(475, 118);
            this.textBoxPayedNow.Name = "textBoxPayedNow";
            this.textBoxPayedNow.Size = new System.Drawing.Size(139, 23);
            this.textBoxPayedNow.TabIndex = 1;
            this.textBoxPayedNow.TextChanged += new System.EventHandler(this.textBoxPayedNow_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label13.Location = new System.Drawing.Point(342, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Pay Now: ";
            // 
            // textBoxWillRemain
            // 
            this.textBoxWillRemain.Enabled = false;
            this.textBoxWillRemain.Location = new System.Drawing.Point(475, 161);
            this.textBoxWillRemain.Name = "textBoxWillRemain";
            this.textBoxWillRemain.ReadOnly = true;
            this.textBoxWillRemain.Size = new System.Drawing.Size(139, 23);
            this.textBoxWillRemain.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label14.Location = new System.Drawing.Point(342, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Will Remain: ";
            // 
            // textBoxRemaining
            // 
            this.textBoxRemaining.Enabled = false;
            this.textBoxRemaining.Location = new System.Drawing.Point(141, 248);
            this.textBoxRemaining.Name = "textBoxRemaining";
            this.textBoxRemaining.ReadOnly = true;
            this.textBoxRemaining.Size = new System.Drawing.Size(139, 23);
            this.textBoxRemaining.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label19.Location = new System.Drawing.Point(13, 251);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Remaining: ";
            // 
            // textBoxAlreadyPayed
            // 
            this.textBoxAlreadyPayed.Enabled = false;
            this.textBoxAlreadyPayed.Location = new System.Drawing.Point(141, 205);
            this.textBoxAlreadyPayed.Name = "textBoxAlreadyPayed";
            this.textBoxAlreadyPayed.ReadOnly = true;
            this.textBoxAlreadyPayed.Size = new System.Drawing.Size(139, 23);
            this.textBoxAlreadyPayed.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label10.Location = new System.Drawing.Point(13, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Already Payed: ";
            // 
            // textBoxToBePayed
            // 
            this.textBoxToBePayed.Enabled = false;
            this.textBoxToBePayed.Location = new System.Drawing.Point(141, 158);
            this.textBoxToBePayed.Name = "textBoxToBePayed";
            this.textBoxToBePayed.ReadOnly = true;
            this.textBoxToBePayed.Size = new System.Drawing.Size(139, 23);
            this.textBoxToBePayed.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label7.Location = new System.Drawing.Point(13, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "To Be Payed: ";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(141, 115);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(139, 23);
            this.textBoxTotal.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label6.Location = new System.Drawing.Point(13, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total: ";
            // 
            // labelBillDate
            // 
            this.labelBillDate.AutoSize = true;
            this.labelBillDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.labelBillDate.Location = new System.Drawing.Point(568, 68);
            this.labelBillDate.Name = "labelBillDate";
            this.labelBillDate.Size = new System.Drawing.Size(14, 16);
            this.labelBillDate.TabIndex = 0;
            this.labelBillDate.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label5.Location = new System.Drawing.Point(472, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bill Date: ";
            // 
            // labelRoomtType
            // 
            this.labelRoomtType.AutoSize = true;
            this.labelRoomtType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.labelRoomtType.Location = new System.Drawing.Point(324, 68);
            this.labelRoomtType.Name = "labelRoomtType";
            this.labelRoomtType.Size = new System.Drawing.Size(14, 16);
            this.labelRoomtType.TabIndex = 0;
            this.labelRoomtType.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label4.Location = new System.Drawing.Point(228, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Room Type: ";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.labelType.Location = new System.Drawing.Point(568, 31);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(14, 16);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label3.Location = new System.Drawing.Point(472, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Type: ";
            // 
            // labelBed
            // 
            this.labelBed.AutoSize = true;
            this.labelBed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.labelBed.Location = new System.Drawing.Point(324, 29);
            this.labelBed.Name = "labelBed";
            this.labelBed.Size = new System.Drawing.Size(14, 16);
            this.labelBed.TabIndex = 0;
            this.labelBed.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label2.Location = new System.Drawing.Point(228, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bed/s: ";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.labelRoomNumber.Location = new System.Drawing.Point(114, 68);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(14, 16);
            this.labelRoomNumber.TabIndex = 0;
            this.labelRoomNumber.Text = "?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label12.Location = new System.Drawing.Point(18, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Room: ";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.labelFullName.Location = new System.Drawing.Point(114, 31);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(14, 16);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name: ";
            // 
            // buttonPay
            // 
            this.buttonPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.buttonPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPay.FlatAppearance.BorderSize = 0;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonPay.Location = new System.Drawing.Point(571, 251);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(111, 45);
            this.buttonPay.TabIndex = 3;
            this.buttonPay.Text = "Pay Now";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // UserControlBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlOptions);
            this.Name = "UserControlBills";
            this.Size = new System.Drawing.Size(1053, 544);
            this.Enter += new System.EventHandler(this.UserControlBills_Enter);
            this.tabPageAllBills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControlOptions.ResumeLayout(false);
            this.tabPagePay.ResumeLayout(false);
            this.tabPagePay.PerformLayout();
            this.groupBoxUpdateCurrent.ResumeLayout(false);
            this.groupBoxUpdateCurrent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageAllBills;
        private System.Windows.Forms.DataGridView dataGridViewBills;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonPayNow;
        private System.Windows.Forms.RadioButton radioButtonPayed;
        private System.Windows.Forms.RadioButton radioButtonNotPayed;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSearchKeyWord;
        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.TabPage tabPagePay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxUpdateCurrent;
        private System.Windows.Forms.TextBox textBoxRemaining;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxAlreadyPayed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxToBePayed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelBillDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRoomtType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.TextBox textBoxPayedNow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxWillRemain;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBoxAsPayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBedLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIsPayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPayedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnToBePayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddedBy;
    }
}
