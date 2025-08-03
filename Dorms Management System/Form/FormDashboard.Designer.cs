namespace Dorms_Management_System
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonBills = new System.Windows.Forms.Button();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxLogOut = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.userControlDashboard = new Dorms_Management_System.User_Controls.UserControlDashboard();
            this.userControlBills = new Dorms_Management_System.User_Controls.UserControlBills();
            this.userControlCheckInOut = new Dorms_Management_System.User_Controls.UserControlCheckInOut();
            this.userControlRooms = new Dorms_Management_System.User_Controls.UserControlRooms();
            this.userControlServices = new Dorms_Management_System.User_Controls.UserControlServices();
            this.userControlClients = new Dorms_Management_System.User_Controls.UserControlClients();
            this.userControlUsers = new Dorms_Management_System.User_Controls.UserControlUsers();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.panel3.Controls.Add(this.panelSlide);
            this.panel3.Controls.Add(this.buttonClients);
            this.panel3.Controls.Add(this.buttonServices);
            this.panel3.Controls.Add(this.buttonRooms);
            this.panel3.Controls.Add(this.buttonSettings);
            this.panel3.Controls.Add(this.buttonBills);
            this.panel3.Controls.Add(this.buttonCheckIn);
            this.panel3.Controls.Add(this.buttonDashboard);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 661);
            this.panel3.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.panelSlide.Location = new System.Drawing.Point(0, 171);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 50);
            this.panelSlide.TabIndex = 0;
            // 
            // buttonClients
            // 
            this.buttonClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClients.FlatAppearance.BorderSize = 0;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonClients.Image = global::Dorms_Management_System.Properties.Resources.users;
            this.buttonClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClients.Location = new System.Drawing.Point(17, 442);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(296, 50);
            this.buttonClients.TabIndex = 8;
            this.buttonClients.Text = "     Clients";
            this.buttonClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonServices
            // 
            this.buttonServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonServices.FlatAppearance.BorderSize = 0;
            this.buttonServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonServices.Image = global::Dorms_Management_System.Properties.Resources.services;
            this.buttonServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonServices.Location = new System.Drawing.Point(17, 389);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(296, 50);
            this.buttonServices.TabIndex = 7;
            this.buttonServices.Text = "     Services";
            this.buttonServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonServices.UseVisualStyleBackColor = true;
            this.buttonServices.Click += new System.EventHandler(this.buttonServices_Click);
            // 
            // buttonRooms
            // 
            this.buttonRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRooms.FlatAppearance.BorderSize = 0;
            this.buttonRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRooms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonRooms.Image = global::Dorms_Management_System.Properties.Resources.room;
            this.buttonRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRooms.Location = new System.Drawing.Point(17, 333);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Size = new System.Drawing.Size(296, 50);
            this.buttonRooms.TabIndex = 5;
            this.buttonRooms.Text = "     Rooms";
            this.buttonRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRooms.UseVisualStyleBackColor = true;
            this.buttonRooms.Click += new System.EventHandler(this.buttonRooms_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonSettings.Image = global::Dorms_Management_System.Properties.Resources.settings;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(17, 495);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(296, 50);
            this.buttonSettings.TabIndex = 9;
            this.buttonSettings.Text = "     Settings";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonBills
            // 
            this.buttonBills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBills.FlatAppearance.BorderSize = 0;
            this.buttonBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBills.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonBills.Image = global::Dorms_Management_System.Properties.Resources.bill;
            this.buttonBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBills.Location = new System.Drawing.Point(16, 277);
            this.buttonBills.Name = "buttonBills";
            this.buttonBills.Size = new System.Drawing.Size(296, 50);
            this.buttonBills.TabIndex = 3;
            this.buttonBills.Text = "     Bills";
            this.buttonBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBills.UseVisualStyleBackColor = true;
            this.buttonBills.Click += new System.EventHandler(this.buttonBills_Click);
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckIn.FlatAppearance.BorderSize = 0;
            this.buttonCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonCheckIn.Image = global::Dorms_Management_System.Properties.Resources.check_in;
            this.buttonCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheckIn.Location = new System.Drawing.Point(16, 224);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(296, 50);
            this.buttonCheckIn.TabIndex = 2;
            this.buttonCheckIn.Text = "     Check In/Out";
            this.buttonCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonDashboard.Image = global::Dorms_Management_System.Properties.Resources.dashboard;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(17, 168);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(296, 50);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "     Dashboard ";
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 171);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label4.Location = new System.Drawing.Point(104, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dorms Management";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.panel5.Controls.Add(this.labelDate);
            this.panel5.Controls.Add(this.labelUserName);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.pictureBoxLogOut);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(313, 59);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1053, 65);
            this.panel5.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDate.AutoSize = true;
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.labelDate.Location = new System.Drawing.Point(849, 26);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(40, 17);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUserName.AutoSize = true;
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.labelUserName.Location = new System.Drawing.Point(152, 26);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(33, 17);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label2.Location = new System.Drawing.Point(76, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome";
            // 
            // pictureBoxLogOut
            // 
            this.pictureBoxLogOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogOut.Image = global::Dorms_Management_System.Properties.Resources.user1;
            this.pictureBoxLogOut.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxLogOut.Name = "pictureBoxLogOut";
            this.pictureBoxLogOut.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogOut.TabIndex = 0;
            this.pictureBoxLogOut.TabStop = false;
            this.pictureBoxLogOut.Click += new System.EventHandler(this.pictureBoxLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(313, 668);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 52);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyright © 2025. All Rights Reserved. Youssef Shawwa";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(313, 59);
            this.panel6.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel6);
            this.panelTop.Controls.Add(this.pictureBoxClose);
            this.panelTop.Controls.Add(this.pictureBoxMinimize);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1366, 59);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDoubleClick);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::Dorms_Management_System.Properties.Resources.Close;
            this.pictureBoxClose.Location = new System.Drawing.Point(1310, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.pictureBoxClose_MouseHover);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Image = global::Dorms_Management_System.Properties.Resources.Minimize;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(1269, 12);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 3;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            this.pictureBoxMinimize.MouseHover += new System.EventHandler(this.pictureBoxMinimize_MouseHover);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.userControlDashboard);
            this.panelMain.Controls.Add(this.userControlBills);
            this.panelMain.Controls.Add(this.userControlCheckInOut);
            this.panelMain.Controls.Add(this.userControlRooms);
            this.panelMain.Controls.Add(this.userControlServices);
            this.panelMain.Controls.Add(this.userControlClients);
            this.panelMain.Controls.Add(this.userControlUsers);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(313, 124);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1053, 544);
            this.panelMain.TabIndex = 0;
            // 
            // userControlDashboard
            // 
            this.userControlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard.Location = new System.Drawing.Point(0, 0);
            this.userControlDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.userControlDashboard.Name = "userControlDashboard";
            this.userControlDashboard.Size = new System.Drawing.Size(1053, 544);
            this.userControlDashboard.TabIndex = 5;
            // 
            // userControlBills
            // 
            this.userControlBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBills.Location = new System.Drawing.Point(0, 0);
            this.userControlBills.Margin = new System.Windows.Forms.Padding(4);
            this.userControlBills.Name = "userControlBills";
            this.userControlBills.Size = new System.Drawing.Size(1053, 544);
            this.userControlBills.TabIndex = 4;
            this.userControlBills.Visible = false;
            // 
            // userControlCheckInOut
            // 
            this.userControlCheckInOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCheckInOut.Location = new System.Drawing.Point(0, 0);
            this.userControlCheckInOut.Margin = new System.Windows.Forms.Padding(4);
            this.userControlCheckInOut.Name = "userControlCheckInOut";
            this.userControlCheckInOut.Size = new System.Drawing.Size(1053, 544);
            this.userControlCheckInOut.TabIndex = 3;
            this.userControlCheckInOut.Visible = false;
            // 
            // userControlRooms
            // 
            this.userControlRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRooms.Location = new System.Drawing.Point(0, 0);
            this.userControlRooms.Margin = new System.Windows.Forms.Padding(4);
            this.userControlRooms.Name = "userControlRooms";
            this.userControlRooms.Size = new System.Drawing.Size(1053, 544);
            this.userControlRooms.TabIndex = 2;
            this.userControlRooms.Visible = false;
            // 
            // userControlServices
            // 
            this.userControlServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlServices.Location = new System.Drawing.Point(0, 0);
            this.userControlServices.Margin = new System.Windows.Forms.Padding(4);
            this.userControlServices.Name = "userControlServices";
            this.userControlServices.Size = new System.Drawing.Size(1053, 544);
            this.userControlServices.TabIndex = 1;
            this.userControlServices.Visible = false;
            // 
            // userControlClients
            // 
            this.userControlClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClients.Location = new System.Drawing.Point(0, 0);
            this.userControlClients.Margin = new System.Windows.Forms.Padding(4);
            this.userControlClients.Name = "userControlClients";
            this.userControlClients.Size = new System.Drawing.Size(1053, 544);
            this.userControlClients.TabIndex = 0;
            this.userControlClients.Visible = false;
            // 
            // userControlUsers
            // 
            this.userControlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlUsers.Location = new System.Drawing.Point(0, 0);
            this.userControlUsers.Margin = new System.Windows.Forms.Padding(4);
            this.userControlUsers.Name = "userControlUsers";
            this.userControlUsers.Size = new System.Drawing.Size(1053, 544);
            this.userControlUsers.TabIndex = 0;
            this.userControlUsers.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dorms Management System | Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button buttonBills;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.Button buttonRooms;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Timer timer1;
        private User_Controls.UserControlUsers userControlUsers;
        private User_Controls.UserControlClients userControlClients;
        private User_Controls.UserControlServices userControlServices;
        private User_Controls.UserControlRooms userControlRooms;
        private User_Controls.UserControlCheckInOut userControlCheckInOut;
        private User_Controls.UserControlBills userControlBills;
        private User_Controls.UserControlDashboard userControlDashboard;
    }
}