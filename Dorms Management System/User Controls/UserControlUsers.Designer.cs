namespace Dorms_Management_System.User_Controls
{
    partial class UserControlUsers
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageUpdateCredentials = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxUpdateCurrent = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonUpdateCredentials = new System.Windows.Forms.Button();
            this.textBoxUpdatePassword = new System.Windows.Forms.TextBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxUpdateUsername = new System.Windows.Forms.TextBox();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxNewUser = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.checkBoxIsNewAdmin = new System.Windows.Forms.CheckBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.tabPageShowAllUsers = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.ColumnUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonShowAdminUsers = new System.Windows.Forms.RadioButton();
            this.radioButtonShowNormalUsers = new System.Windows.Forms.RadioButton();
            this.radioButtonShowAllUsers = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearchUserName = new System.Windows.Forms.TextBox();
            this.tabPageUpdateDeleteUser = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.checkBoxUpdateUserIsAdmin = new System.Windows.Forms.CheckBox();
            this.textBoxUpdateUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxUpdateUserUserame = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPageUpdateCredentials.SuspendLayout();
            this.groupBoxUpdateCurrent.SuspendLayout();
            this.tabPageAddUser.SuspendLayout();
            this.groupBoxNewUser.SuspendLayout();
            this.tabPageShowAllUsers.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageUpdateDeleteUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageUpdateCredentials);
            this.tabControl.Controls.Add(this.tabPageAddUser);
            this.tabControl.Controls.Add(this.tabPageShowAllUsers);
            this.tabControl.Controls.Add(this.tabPageUpdateDeleteUser);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1053, 544);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageUpdateCredentials
            // 
            this.tabPageUpdateCredentials.Controls.Add(this.label9);
            this.tabPageUpdateCredentials.Controls.Add(this.groupBoxUpdateCurrent);
            this.tabPageUpdateCredentials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.tabPageUpdateCredentials.Location = new System.Drawing.Point(4, 26);
            this.tabPageUpdateCredentials.Name = "tabPageUpdateCredentials";
            this.tabPageUpdateCredentials.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateCredentials.Size = new System.Drawing.Size(1045, 514);
            this.tabPageUpdateCredentials.TabIndex = 0;
            this.tabPageUpdateCredentials.Text = "Update Current User";
            this.tabPageUpdateCredentials.UseVisualStyleBackColor = true;
            this.tabPageUpdateCredentials.Leave += new System.EventHandler(this.tabPageUpdateCredentials_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label9.Location = new System.Drawing.Point(31, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Update Your Credentials: ";
            // 
            // groupBoxUpdateCurrent
            // 
            this.groupBoxUpdateCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxUpdateCurrent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxUpdateCurrent.Controls.Add(this.label12);
            this.groupBoxUpdateCurrent.Controls.Add(this.label11);
            this.groupBoxUpdateCurrent.Controls.Add(this.label10);
            this.groupBoxUpdateCurrent.Controls.Add(this.buttonUpdateCredentials);
            this.groupBoxUpdateCurrent.Controls.Add(this.textBoxUpdatePassword);
            this.groupBoxUpdateCurrent.Controls.Add(this.textBoxOldPassword);
            this.groupBoxUpdateCurrent.Controls.Add(this.textBoxUpdateUsername);
            this.groupBoxUpdateCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxUpdateCurrent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUpdateCurrent.Location = new System.Drawing.Point(380, 102);
            this.groupBoxUpdateCurrent.Name = "groupBoxUpdateCurrent";
            this.groupBoxUpdateCurrent.Size = new System.Drawing.Size(288, 293);
            this.groupBoxUpdateCurrent.TabIndex = 0;
            this.groupBoxUpdateCurrent.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label12.Location = new System.Drawing.Point(33, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Update Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label11.Location = new System.Drawing.Point(31, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Old Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label10.Location = new System.Drawing.Point(32, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Update Username:";
            // 
            // buttonUpdateCredentials
            // 
            this.buttonUpdateCredentials.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.buttonUpdateCredentials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateCredentials.FlatAppearance.BorderSize = 0;
            this.buttonUpdateCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateCredentials.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCredentials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonUpdateCredentials.Location = new System.Drawing.Point(91, 231);
            this.buttonUpdateCredentials.Name = "buttonUpdateCredentials";
            this.buttonUpdateCredentials.Size = new System.Drawing.Size(111, 45);
            this.buttonUpdateCredentials.TabIndex = 4;
            this.buttonUpdateCredentials.Text = "Update";
            this.buttonUpdateCredentials.UseVisualStyleBackColor = false;
            this.buttonUpdateCredentials.Click += new System.EventHandler(this.buttonUpdateCredentials_Click);
            // 
            // textBoxUpdatePassword
            // 
            this.textBoxUpdatePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUpdatePassword.Location = new System.Drawing.Point(37, 190);
            this.textBoxUpdatePassword.Name = "textBoxUpdatePassword";
            this.textBoxUpdatePassword.Size = new System.Drawing.Size(220, 23);
            this.textBoxUpdatePassword.TabIndex = 3;
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOldPassword.Location = new System.Drawing.Point(35, 131);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(220, 23);
            this.textBoxOldPassword.TabIndex = 2;
            // 
            // textBoxUpdateUsername
            // 
            this.textBoxUpdateUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUpdateUsername.Location = new System.Drawing.Point(36, 72);
            this.textBoxUpdateUsername.Name = "textBoxUpdateUsername";
            this.textBoxUpdateUsername.Size = new System.Drawing.Size(220, 23);
            this.textBoxUpdateUsername.TabIndex = 1;
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.label6);
            this.tabPageAddUser.Controls.Add(this.groupBoxNewUser);
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 26);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUser.Size = new System.Drawing.Size(1045, 514);
            this.tabPageAddUser.TabIndex = 1;
            this.tabPageAddUser.Text = "Add User";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            this.tabPageAddUser.Leave += new System.EventHandler(this.tabPageAddUser_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label6.Location = new System.Drawing.Point(31, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Add New User: ";
            // 
            // groupBoxNewUser
            // 
            this.groupBoxNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxNewUser.Controls.Add(this.label8);
            this.groupBoxNewUser.Controls.Add(this.label7);
            this.groupBoxNewUser.Controls.Add(this.buttonAddNewUser);
            this.groupBoxNewUser.Controls.Add(this.checkBoxIsNewAdmin);
            this.groupBoxNewUser.Controls.Add(this.textBoxNewPassword);
            this.groupBoxNewUser.Controls.Add(this.textBoxNewUsername);
            this.groupBoxNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxNewUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNewUser.Location = new System.Drawing.Point(380, 102);
            this.groupBoxNewUser.Name = "groupBoxNewUser";
            this.groupBoxNewUser.Size = new System.Drawing.Size(288, 293);
            this.groupBoxNewUser.TabIndex = 0;
            this.groupBoxNewUser.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label8.Location = new System.Drawing.Point(34, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "New Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label7.Location = new System.Drawing.Point(34, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "New Username:";
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.buttonAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNewUser.FlatAppearance.BorderSize = 0;
            this.buttonAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonAddNewUser.Location = new System.Drawing.Point(92, 195);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(111, 45);
            this.buttonAddNewUser.TabIndex = 4;
            this.buttonAddNewUser.Text = "Add New User";
            this.buttonAddNewUser.UseVisualStyleBackColor = false;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // checkBoxIsNewAdmin
            // 
            this.checkBoxIsNewAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxIsNewAdmin.AutoSize = true;
            this.checkBoxIsNewAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxIsNewAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsNewAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.checkBoxIsNewAdmin.Location = new System.Drawing.Point(37, 165);
            this.checkBoxIsNewAdmin.Name = "checkBoxIsNewAdmin";
            this.checkBoxIsNewAdmin.Size = new System.Drawing.Size(83, 20);
            this.checkBoxIsNewAdmin.TabIndex = 3;
            this.checkBoxIsNewAdmin.Text = "Is Admin";
            this.checkBoxIsNewAdmin.UseVisualStyleBackColor = true;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNewPassword.Location = new System.Drawing.Point(37, 132);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(220, 23);
            this.textBoxNewPassword.TabIndex = 2;
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNewUsername.Location = new System.Drawing.Point(37, 73);
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(220, 23);
            this.textBoxNewUsername.TabIndex = 1;
            // 
            // tabPageShowAllUsers
            // 
            this.tabPageShowAllUsers.Controls.Add(this.panel2);
            this.tabPageShowAllUsers.Controls.Add(this.panel1);
            this.tabPageShowAllUsers.Location = new System.Drawing.Point(4, 26);
            this.tabPageShowAllUsers.Name = "tabPageShowAllUsers";
            this.tabPageShowAllUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShowAllUsers.Size = new System.Drawing.Size(1045, 514);
            this.tabPageShowAllUsers.TabIndex = 2;
            this.tabPageShowAllUsers.Text = "Show All Users";
            this.tabPageShowAllUsers.UseVisualStyleBackColor = true;
            this.tabPageShowAllUsers.Enter += new System.EventHandler(this.tabPageShowAllUsers_Enter);
            this.tabPageShowAllUsers.Leave += new System.EventHandler(this.tabPageShowAllUsers_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewUsers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 370);
            this.panel2.TabIndex = 7;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUserID,
            this.ColumnPassword,
            this.ColumnUsername,
            this.ColumnUserType});
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1039, 370);
            this.dataGridViewUsers.TabIndex = 6;
            this.dataGridViewUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellDoubleClick);
            // 
            // ColumnUserID
            // 
            this.ColumnUserID.HeaderText = "UserID";
            this.ColumnUserID.Name = "ColumnUserID";
            this.ColumnUserID.ReadOnly = true;
            this.ColumnUserID.Visible = false;
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.HeaderText = "Password";
            this.ColumnPassword.Name = "ColumnPassword";
            this.ColumnPassword.ReadOnly = true;
            this.ColumnPassword.Visible = false;
            // 
            // ColumnUsername
            // 
            this.ColumnUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUsername.HeaderText = "Username";
            this.ColumnUsername.Name = "ColumnUsername";
            this.ColumnUsername.ReadOnly = true;
            // 
            // ColumnUserType
            // 
            this.ColumnUserType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUserType.HeaderText = "User Type";
            this.ColumnUserType.Name = "ColumnUserType";
            this.ColumnUserType.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonShowAdminUsers);
            this.panel1.Controls.Add(this.radioButtonShowNormalUsers);
            this.panel1.Controls.Add(this.radioButtonShowAllUsers);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxSearchUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 138);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonShowAdminUsers
            // 
            this.radioButtonShowAdminUsers.AutoSize = true;
            this.radioButtonShowAdminUsers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonShowAdminUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.radioButtonShowAdminUsers.Location = new System.Drawing.Point(178, 100);
            this.radioButtonShowAdminUsers.Name = "radioButtonShowAdminUsers";
            this.radioButtonShowAdminUsers.Size = new System.Drawing.Size(79, 24);
            this.radioButtonShowAdminUsers.TabIndex = 3;
            this.radioButtonShowAdminUsers.Text = "Admins";
            this.radioButtonShowAdminUsers.UseVisualStyleBackColor = true;
            this.radioButtonShowAdminUsers.CheckedChanged += new System.EventHandler(this.radioButtonShowAdminUsers_CheckedChanged);
            // 
            // radioButtonShowNormalUsers
            // 
            this.radioButtonShowNormalUsers.AutoSize = true;
            this.radioButtonShowNormalUsers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonShowNormalUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.radioButtonShowNormalUsers.Location = new System.Drawing.Point(328, 100);
            this.radioButtonShowNormalUsers.Name = "radioButtonShowNormalUsers";
            this.radioButtonShowNormalUsers.Size = new System.Drawing.Size(65, 24);
            this.radioButtonShowNormalUsers.TabIndex = 4;
            this.radioButtonShowNormalUsers.Text = "Users";
            this.radioButtonShowNormalUsers.UseVisualStyleBackColor = true;
            this.radioButtonShowNormalUsers.CheckedChanged += new System.EventHandler(this.radioButtonShowNormalUsers_CheckedChanged);
            // 
            // radioButtonShowAllUsers
            // 
            this.radioButtonShowAllUsers.AutoSize = true;
            this.radioButtonShowAllUsers.Checked = true;
            this.radioButtonShowAllUsers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonShowAllUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.radioButtonShowAllUsers.Location = new System.Drawing.Point(38, 100);
            this.radioButtonShowAllUsers.Name = "radioButtonShowAllUsers";
            this.radioButtonShowAllUsers.Size = new System.Drawing.Size(86, 24);
            this.radioButtonShowAllUsers.TabIndex = 2;
            this.radioButtonShowAllUsers.TabStop = true;
            this.radioButtonShowAllUsers.Text = "All Users";
            this.radioButtonShowAllUsers.UseVisualStyleBackColor = true;
            this.radioButtonShowAllUsers.CheckedChanged += new System.EventHandler(this.radioButtonShowAllUsers_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label5.Location = new System.Drawing.Point(29, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search By Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label4.Location = new System.Drawing.Point(31, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "All Users:";
            // 
            // textBoxSearchUserName
            // 
            this.textBoxSearchUserName.Location = new System.Drawing.Point(202, 60);
            this.textBoxSearchUserName.Name = "textBoxSearchUserName";
            this.textBoxSearchUserName.Size = new System.Drawing.Size(220, 23);
            this.textBoxSearchUserName.TabIndex = 1;
            this.textBoxSearchUserName.TextChanged += new System.EventHandler(this.textBoxSearchUserName_TextChanged);
            // 
            // tabPageUpdateDeleteUser
            // 
            this.tabPageUpdateDeleteUser.Controls.Add(this.label1);
            this.tabPageUpdateDeleteUser.Controls.Add(this.groupBox1);
            this.tabPageUpdateDeleteUser.Location = new System.Drawing.Point(4, 26);
            this.tabPageUpdateDeleteUser.Name = "tabPageUpdateDeleteUser";
            this.tabPageUpdateDeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeleteUser.Size = new System.Drawing.Size(1045, 514);
            this.tabPageUpdateDeleteUser.TabIndex = 3;
            this.tabPageUpdateDeleteUser.Text = "Update Or Delete User";
            this.tabPageUpdateDeleteUser.UseVisualStyleBackColor = true;
            this.tabPageUpdateDeleteUser.Leave += new System.EventHandler(this.tabPageUpdateDeleteUser_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Or Delete a User: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonDeleteUser);
            this.groupBox1.Controls.Add(this.buttonUpdateUser);
            this.groupBox1.Controls.Add(this.checkBoxUpdateUserIsAdmin);
            this.groupBox1.Controls.Add(this.textBoxUpdateUserPassword);
            this.groupBox1.Controls.Add(this.textBoxUpdateUserUserame);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(380, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label3.Location = new System.Drawing.Point(34, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.label2.Location = new System.Drawing.Point(34, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteUser.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(154, 200);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(103, 45);
            this.buttonDeleteUser.TabIndex = 5;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.buttonUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateUser.FlatAppearance.BorderSize = 0;
            this.buttonUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.buttonUpdateUser.Location = new System.Drawing.Point(37, 200);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(104, 45);
            this.buttonUpdateUser.TabIndex = 4;
            this.buttonUpdateUser.Text = "Update";
            this.buttonUpdateUser.UseVisualStyleBackColor = false;
            this.buttonUpdateUser.Click += new System.EventHandler(this.buttonUpdateUser_Click);
            // 
            // checkBoxUpdateUserIsAdmin
            // 
            this.checkBoxUpdateUserIsAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxUpdateUserIsAdmin.AutoSize = true;
            this.checkBoxUpdateUserIsAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxUpdateUserIsAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUpdateUserIsAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.checkBoxUpdateUserIsAdmin.Location = new System.Drawing.Point(37, 165);
            this.checkBoxUpdateUserIsAdmin.Name = "checkBoxUpdateUserIsAdmin";
            this.checkBoxUpdateUserIsAdmin.Size = new System.Drawing.Size(83, 20);
            this.checkBoxUpdateUserIsAdmin.TabIndex = 3;
            this.checkBoxUpdateUserIsAdmin.Text = "Is Admin";
            this.checkBoxUpdateUserIsAdmin.UseVisualStyleBackColor = true;
            // 
            // textBoxUpdateUserPassword
            // 
            this.textBoxUpdateUserPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUpdateUserPassword.Location = new System.Drawing.Point(37, 132);
            this.textBoxUpdateUserPassword.Name = "textBoxUpdateUserPassword";
            this.textBoxUpdateUserPassword.Size = new System.Drawing.Size(220, 23);
            this.textBoxUpdateUserPassword.TabIndex = 2;
            // 
            // textBoxUpdateUserUserame
            // 
            this.textBoxUpdateUserUserame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUpdateUserUserame.Location = new System.Drawing.Point(37, 73);
            this.textBoxUpdateUserUserame.Name = "textBoxUpdateUserUserame";
            this.textBoxUpdateUserUserame.Size = new System.Drawing.Size(220, 23);
            this.textBoxUpdateUserUserame.TabIndex = 1;
            // 
            // UserControlUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "UserControlUsers";
            this.Size = new System.Drawing.Size(1053, 544);
            this.tabControl.ResumeLayout(false);
            this.tabPageUpdateCredentials.ResumeLayout(false);
            this.tabPageUpdateCredentials.PerformLayout();
            this.groupBoxUpdateCurrent.ResumeLayout(false);
            this.groupBoxUpdateCurrent.PerformLayout();
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.groupBoxNewUser.ResumeLayout(false);
            this.groupBoxNewUser.PerformLayout();
            this.tabPageShowAllUsers.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageUpdateDeleteUser.ResumeLayout(false);
            this.tabPageUpdateDeleteUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageUpdateCredentials;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.GroupBox groupBoxUpdateCurrent;
        private System.Windows.Forms.Button buttonUpdateCredentials;
        private System.Windows.Forms.TextBox textBoxUpdatePassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxUpdateUsername;
        private System.Windows.Forms.GroupBox groupBoxNewUser;
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.CheckBox checkBoxIsNewAdmin;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.TabPage tabPageShowAllUsers;
        private System.Windows.Forms.TabPage tabPageUpdateDeleteUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.CheckBox checkBoxUpdateUserIsAdmin;
        private System.Windows.Forms.TextBox textBoxUpdateUserPassword;
        private System.Windows.Forms.TextBox textBoxUpdateUserUserame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearchUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserType;
        private System.Windows.Forms.RadioButton radioButtonShowAdminUsers;
        private System.Windows.Forms.RadioButton radioButtonShowNormalUsers;
        private System.Windows.Forms.RadioButton radioButtonShowAllUsers;
    }
}
