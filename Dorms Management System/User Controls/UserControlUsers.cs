using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dorms_Management_System.User_Controls
{
    public partial class UserControlUsers : UserControl
    {
        public UserControlUsers()
        {
            
            InitializeComponent();
            if (FormLogin.currentUserType != "Admin")
            {
                this.tabControl.TabPages.Remove(this.tabPageShowAllUsers);
                this.tabControl.TabPages.Remove(this.tabPageAddUser);
                this.tabControl.TabPages.Remove(this.tabPageUpdateDeleteUser);
                
            }
            else
            {
                this.tabControl.TabPages.Remove(this.tabPageUpdateDeleteUser);
                FormDashboard.getAllUsers();
            }

            
        }


        //Method to check if the username is already exists in the database
        private bool checkExistingUsername(string username, bool isUpdatingSame = false)
        {
            if (isUpdatingSame)
                return false;
            try { 
            using (SqlConnection connection = new SqlConnection(Program.conString))
            {
                connection.Open();
                string sqlQuery = "SELECT 1 FROM Users WHERE Username = @username;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@username", username);

                object result = command.ExecuteScalar();
                if (result == null)
                {
                    return false;
                }
                return true;

            }
            }
            catch
            {
                showDatabaseError("When trying to Check if the user exists in the database!");
            }
            return false;
        }

        private void showDatabaseError(string reason)
        {
            MessageBox.Show("An Error occured: " + reason, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        //Fill All users in the Grid
        private void fillShowAllUsers(List<User> users)
        {

            this.dataGridViewUsers.Rows.Clear();
            foreach(User u in users)
            {
                if (u.UserID == FormLogin.currentUserID)
                    continue;
                this.dataGridViewUsers.Rows.Add(
                    u.UserID,
                    u.Password,
                    u.UserName,
                    u.UserType
                    );
            }

        }



        //clear and reset methods
        public void reset()
        {
            this.clearAdduser();
            this.clearShowAllUsers();
            this.clearUpdateCredentials();
            this.clearUpdateDeleteUser();
            this.tabControl.SelectedTab = this.tabPageUpdateCredentials;
        }
        private void clearUpdateCredentials()
        {
            this.textBoxUpdateUsername.Clear();
            this.textBoxUpdatePassword.Clear();
            this.textBoxOldPassword.Clear();
        }
        private void clearAdduser()
        {
            this.textBoxNewPassword.Clear();
            this.textBoxNewUsername.Clear();
            this.checkBoxIsNewAdmin.Checked = false;
        }
        private void clearUpdateDeleteUser()
        {
            this.textBoxUpdateUserUserame.Clear();
            this.textBoxUpdateUserPassword.Clear();
            this.checkBoxUpdateUserIsAdmin.Checked = false;
        }

        private void clearShowAllUsers()
        {
            this.textBoxSearchUserName.Clear();
            this.dataGridViewUsers.Rows.Clear();
        }

        //events
        private void tabPageUpdateDeleteUser_Leave(object sender, EventArgs e)
        {
            this.clearUpdateDeleteUser();
            this.tabControl.TabPages.Remove(this.tabPageUpdateDeleteUser);
        }
        private void tabPageShowAllUsers_Leave(object sender, EventArgs e)
        {
            
        }
        private void tabPageShowAllUsers_Enter(object sender, EventArgs e)
        {
            this.clearShowAllUsers();
            FormDashboard.getAllUsers();
            this.fillShowAllUsers(FormDashboard.users);
            this.dataGridViewUsers.ClearSelection();

        }
        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            this.clearAdduser();
        }
        private void tabPageUpdateCredentials_Leave(object sender, EventArgs e)
        {
            this.clearUpdateCredentials();
        }


        //Handle adding new user
        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            string username = this.textBoxNewUsername.Text.ToLower();
            string password = this.textBoxNewPassword.Text;
            bool isAdmin = this.checkBoxIsNewAdmin.Checked;
            string userType = isAdmin ? "Admin" : "User";

            Dictionary<string, object> valid = areValid(username, password);

            if (!(bool)valid["isValid"])
            {
                MessageBox.Show(valid["message"].ToString(), valid["reason"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
                return;
            }
            else
            {
                if(addNewUser(username, password, userType))
                {
                    MessageBox.Show("User is Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clearAdduser();
                    return;
                }
                MessageBox.Show("An Error Occured when adding the new user!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }

        //Method to add a new user
        public bool addNewUser(string username, string password, string userType)
        {
            try { 
            using (SqlConnection connection = new SqlConnection(Program.conString))
            {
                connection.Open();
                string sqlQuery = "INSERT INTO Users (Username, Password, UserType) VALUES (@username, @password, @userType);";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@userType", userType);
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }


                
                }
            }
            catch
            {
                showDatabaseError("When trying to add new user!");
            }
            return false;
        }

        //Handle Updating the current user credentials.
        private void buttonUpdateCredentials_Click(object sender, EventArgs e)
        {
            string newUsername = this.textBoxUpdateUsername.Text;
            string oldPassword = this.textBoxOldPassword.Text;
            string newPassword = this.textBoxUpdatePassword.Text;

            Dictionary<string, object> valid = areValid(newUsername, newPassword, true);

            if (!(bool)valid["isValid"])
            {
                MessageBox.Show(valid["message"].ToString(), valid["reason"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if(!isCurrectPassword(FormLogin.currentUserID, oldPassword))
            {
                MessageBox.Show("Your old password is wrong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!updateUser(FormLogin.currentUserID, newUsername, newPassword, FormLogin.currentUserType))
            {
                MessageBox.Show("An Error Occured when adding the new user!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("User is updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormLogin.currentUserName = newUsername;
            Program.dashboardForm.updateCurrentUsernameName();
            this.clearUpdateCredentials();

        }

        //checking if the password is currect
        private bool isCurrectPassword(int id, string password)
        {
            try { 
            using (SqlConnection connection = new SqlConnection(Program.conString))
            {
                connection.Open();
                string sqlQuery = "SELECT 1 FROM Users WHERE UserID = @userId AND Password = @password";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@userId", id);
                command.Parameters.AddWithValue("@password", password);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return true;
                }
            } 
            }
            catch
            {
                showDatabaseError("When trying to check if the admin password is currect!");
            }
            return false;
        }
        private bool updateUser(int id, string username, string password, string userType)
        {

            try { 

            using (SqlConnection connection = new SqlConnection(Program.conString))
            {
                connection.Open();
                string sqlQuery = "UPDATE Users SET Username = @username, Password = @password, UserType = @userType WHERE UserID = @userId;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@userType", userType);
                command.Parameters.AddWithValue("@userId", id);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
                    
            }}
            catch
            {
                showDatabaseError("When trying to update the user!");
            }

            return false;
        }


        //method to check if username and password are valid
        public Dictionary<string, object> areValid(string username, string password, bool isUpdatingSame = false)
        {
            Dictionary<string, object> isValidUser = isValidUsername(username);
            Dictionary<string, object> isValidPass = isValidPassowrd(password);
            Dictionary<string, object> result = new Dictionary<string, object>();
            string message = "";
            bool isValid = true;
            string reason = "";
            if (!(bool)isValidUser["isValid"])
            {
                message += isValidUser["message"].ToString();
                isValid = false;
            }
            if (!(bool)isValidPass["isValid"])
            {
                message += "\n" + isValidPass["message"].ToString();
                isValid = false;
            }
            if (!isValid)
            {
                reason += "Not Valid";
            }
           //if is are valid username and password, check if the username exists in the database
           else if(checkExistingUsername(username, isUpdatingSame))
             {
                message += "Username is already exists!";
                isValid = false;
                reason = "Existing Username";

             }


            result.Add("isValid", isValid);
            result.Add("message", message);
            result.Add("reason", reason);
            return result;

            


            //MessageBox.Show("Good", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        //Method to check if the password is valid.
        public Dictionary<string, object> isValidPassowrd(string password)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            string message = "";
            bool isValid = true;
            if (password.Length == 0)
            {
                message = "Password is Empty!";
                isValid = false;
                result.Add("isValid", isValid);
                result.Add("message", message);
                return result;
            }
            if (password.Length < 4 || password.Length > 16)
            {
                isValid = false;
                message += "Password must be between 4 and 16 characters!\n";

            }
            if (password.ToLower().Contains(" "))
            {
                isValid = false;
                message += "Password must not contain spaces!\n";
            }
            result.Add("isValid", isValid);
            result.Add("message", message);
            return result;
        }

        //Method to check if the username is valid.
        public Dictionary<string, object> isValidUsername(string username)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            bool isValid = true;
            string message = "";
            if(username.Length == 0)
            {
                message = "Username is Empty!";
                isValid = false;
                result.Add("isValid", isValid);
                result.Add("message", message);
                return result;
            }
            if (username.Length < 3 || username.Length > 16) 
            {
                isValid =  false;
                message += "Username must be between 3 and 16 characters!\n";
                
            }
             //|| username.ToLower().Contains(" ") || char.IsDigit(username[0]) || username.Length > 15)
            if (char.IsDigit(username[0]))
            {
                isValid = false;
                message += "Username must not 1 with a number!\n";

            }
            if(username.ToLower().Contains(" "))
            {
                isValid = false;
                message += "Username must not contain spaces!\n";
            }

            result.Add("isValid", isValid);
            result.Add("message", message);

            return result;


        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.tabControl.TabPages.Add(this.tabPageUpdateDeleteUser);
                this.tabControl.SelectedTab = this.tabPageUpdateDeleteUser;
                DataGridViewRow row = this.dataGridViewUsers.Rows[e.RowIndex];
                this.textBoxUpdateUserUserame.Text = row.Cells["ColumnUsername"].Value.ToString();
                this.textBoxUpdateUserPassword.Text = row.Cells["ColumnPassword"].Value.ToString();
                this.checkBoxUpdateUserIsAdmin.Checked = row.Cells["ColumnUserType"].Value.ToString() == "Admin" ? true : false;
                this.textBoxUpdateUserUserame.Tag = int.Parse(row.Cells["ColumnUserID"].Value.ToString());
            }
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to Update this user?", "Update User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            string username = this.textBoxUpdateUserUserame.Text;
            string password = this.textBoxUpdateUserPassword.Text;
            string userType = this.checkBoxUpdateUserIsAdmin.Checked ? "Admin" : "User";
            int id = (int)this.textBoxUpdateUserUserame.Tag;

            Dictionary<string, object> valid = areValid(username, password, true);
            if (!(bool)valid["isValid"])
            {
                MessageBox.Show(valid["message"].ToString(), valid["reason"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (updateUser(id, username, password, userType))
                {
                    MessageBox.Show("User is updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clearUpdateDeleteUser();
                    this.tabControl.SelectedTab = this.tabPageShowAllUsers;
                    this.tabControl.TabPages.Remove(this.tabPageUpdateDeleteUser);
                    return;
                }
                MessageBox.Show("An Error Occured when updating the user!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        //Handle filter and search for users
        private void textBoxSearchUserName_TextChanged(object sender, EventArgs e)
        {
            if (this.radioButtonShowAllUsers.Checked)
                FormDashboard.filteredUsers = FormDashboard.users.Where(x => x.UserName.StartsWith(this.textBoxSearchUserName.Text, StringComparison.OrdinalIgnoreCase)).Select(x => x).ToList();
            else if (this.radioButtonShowNormalUsers.Checked)
                FormDashboard.filteredUsers = FormDashboard.users.Where(x => x.UserName.StartsWith(this.textBoxSearchUserName.Text, StringComparison.OrdinalIgnoreCase) && x.UserType == "User").Select(x => x).ToList();
            else
                FormDashboard.filteredUsers = FormDashboard.users.Where(x => x.UserName.StartsWith(this.textBoxSearchUserName.Text, StringComparison.OrdinalIgnoreCase) && x.UserType == "Admin").Select(x => x).ToList();

            this.fillShowAllUsers(FormDashboard.filteredUsers);
        }

        private void radioButtonShowAllUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonShowAllUsers.Checked)
            {
                FormDashboard.filteredUsers = FormDashboard.users.Where(x => x.UserName.StartsWith(this.textBoxSearchUserName.Text, StringComparison.OrdinalIgnoreCase)).Select(x => x).ToList();
                this.fillShowAllUsers(FormDashboard.filteredUsers);
            }
        }

        private void radioButtonShowAdminUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonShowAdminUsers.Checked)
            {
                FormDashboard.filteredUsers = FormDashboard.users.Where(x => x.UserName.StartsWith(this.textBoxSearchUserName.Text, StringComparison.OrdinalIgnoreCase) && x.UserType == "Admin").Select(x => x).ToList();
                this.fillShowAllUsers(FormDashboard.filteredUsers);
            }

        }

        private void radioButtonShowNormalUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonShowNormalUsers.Checked)
            {
                FormDashboard.filteredUsers = FormDashboard.users.Where(x => x.UserName.StartsWith(this.textBoxSearchUserName.Text, StringComparison.OrdinalIgnoreCase) && x.UserType == "User").Select(x => x).ToList();
                this.fillShowAllUsers(FormDashboard.filteredUsers);
            }
        }

        //handle deleting a user.
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really Want to delte this user?\nYour action can not be undone!",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            int id = (int)this.textBoxUpdateUserUserame.Tag;
            if (deleteUser(id))
            {
                MessageBox.Show("User has been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearUpdateDeleteUser();
                this.tabControl.SelectedTab = this.tabPageShowAllUsers;
                this.tabControl.TabPages.Remove(this.tabPageUpdateDeleteUser);
            }

        }
        private bool deleteUser(int id)
        {
            try { 
            using (SqlConnection connection = new SqlConnection(Program.conString))
            {
                connection.Open();
                string sqlQuery = "DELETE FROM Users WHERE UserID = @userId";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@userId", id);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }

            }
            }
            catch
            {
                showDatabaseError("When trying to delete a user!");
            }
            return false;
        }
    }
}
