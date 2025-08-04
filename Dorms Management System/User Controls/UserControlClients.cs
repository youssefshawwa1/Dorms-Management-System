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
    public partial class UserControlClients : UserControl
    {

        private string[] searchOptions = { "Name", "Phone", "Email" , "University"};
        public UserControlClients()
        {
            InitializeComponent();
            this.tabControl.TabPages.Remove(this.tabPageShowClient);
            FormDashboard.getAllClients();
            this.comboBoxSearchOptions.DataSource = searchOptions;

        }
        private void clearShowAllClients()
        {
            //this.comboBoxSearchOptions.SelectedIndex = 0;
            this.textBoxSearchKeyWord.Clear();
            this.dataGridViewClients.Rows.Clear();
        }
        public void reset()
        {
            this.clearAddClient();
            this.clearShowAllClients();
            this.clearShowClient();
            this.tabControl.SelectedTab = this.tabPageAddClient;
        }

        private void clearShowClient()
        {
            this.textBoxUpdateFirstName.Clear();
            this.textBoxUpdateMiddleName.Clear();
            this.textBoxUpdateLastName.Clear();
            this.textBoxUpdatePhoneNumber.Clear();
            this.textBoxUpdateEmail.Clear();
            this.textBoxUpdatePassportID.Clear();
            this.dateTimePickerUpdateBirthDate.Value = DateTime.Now;
            this.textBoxUpdateUniversity.Clear();
            this.textBoxUpdateEmergencyFullName.Clear();
            this.textBoxUpdateEmergencyPhone.Clear();
            this.textBoxUpdateEmergencyEmail.Clear();
            this.textBoxUpdateEmergencyRelation.Clear();
        }
        private void clearAddClient() {
            this.textBoxNewFirstName.Clear();
            this.textBoxNewMiddleName.Clear();
            this.textBoxNewLastName.Clear();
            this.textBoxNewPhoneNumber.Clear();
            this.textBoxNewEmail.Clear();
            this.textBoxNewPassportID.Clear();
            this.dateTimePickerNewBirthDate.Value = DateTime.Now;
            this.textBoxNewUniversityName.Clear();
            this.textBoxNewEmergencyFullName.Clear();
            this.textBoxNewEmergencyPhone.Clear();
            this.textBoxNewEmergencyEmail.Clear();
            this.textBoxNewEmergencyRelation.Clear();
        }
        private bool isEmptyAddClient()
        {
            if (
                this.textBoxNewFirstName.Text.Length == 0 ||
                this.textBoxNewMiddleName.Text.Length == 0 ||
                this.textBoxNewLastName.Text.Length == 0 ||
                this.textBoxNewPhoneNumber.Text.Length == 0 ||
                this.textBoxNewEmail.Text.Length == 0 ||
                this.textBoxNewPassportID.Text.Length == 0 ||
                this.textBoxNewEmergencyFullName.Text.Length == 0 ||
                this.textBoxNewEmergencyPhone.Text.Length == 0 ||
                this.dateTimePickerNewBirthDate.Value == DateTime.Now ||
                this.textBoxNewEmergencyRelation.Text.Length == 0 ||
                this.textBoxNewUniversityName.Text.Length == 0


                )
                return true;
            

            return false;
        }
        private bool isEmptyUpdateClient()
        {
            if (
                this.textBoxUpdateFirstName.Text.Length == 0 ||
                this.textBoxUpdateMiddleName.Text.Length == 0 ||
                this.textBoxUpdateLastName.Text.Length == 0 ||
                this.textBoxUpdatePhoneNumber.Text.Length == 0 ||
                this.textBoxUpdateEmail.Text.Length == 0 ||
                this.textBoxUpdatePassportID.Text.Length == 0 ||
                this.textBoxUpdateEmergencyFullName.Text.Length == 0 ||
                this.textBoxUpdateEmergencyPhone.Text.Length == 0 ||
                this.dateTimePickerUpdateBirthDate.Value == DateTime.Now ||
                this.textBoxUpdateEmergencyRelation.Text.Length == 0 ||
                this.textBoxUpdateUniversity.Text.Length == 0


                )
                return true;


            return false;
        }

        private bool addNewClient(
            string passport,
            string phone,
            string fn,
            string mn,
            string ln,
            string uni,
            DateTime birth,
            string gender,
            DateTime insertionDate,
            string eName,
            string eRelation,
            string ePhone,
            string eEmail,
            string email)
        {
            MessageBox.Show(insertionDate.ToString());
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
            {
                connection.Open();
                string sqlQuery =
                    "INSERT INTO Tenant " +
                    "(PassportID, PhoneNumber, FirstName, MiddleName, LastName, " +
                    "BirthOfDate, Gender, InsertionDate, EmergencyContactName," +
                    " EmergencyContactRelation, EmergencyContactPhone, " +
                    "EmergencyContactEmail, Email, UniversityName) " +
                    "VALUES" +
                    "(@passport, @phone, @fn, @mn, @ln, @birth, @gender, @insertionDate, @eName, @eRelation, @ePhone, @eEmail, @email, @uni);";

                
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@passport", passport);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@fn", fn);
                command.Parameters.AddWithValue("@mn", mn);
                command.Parameters.AddWithValue("@ln", ln);
                command.Parameters.AddWithValue("@birth", birth);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@insertionDate", insertionDate);
                command.Parameters.AddWithValue("@eName", eName);
                command.Parameters.AddWithValue("@eRelation", eRelation);
                command.Parameters.AddWithValue("@ePhone", ePhone);
                command.Parameters.AddWithValue("@eEmail", eEmail);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@uni", uni);
                if (command.ExecuteNonQuery() > 0)
                {
                    
                        return true;
                 }



            }
            }
            catch
            {
                return false;
            }
            return false;
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {

            if (isEmptyAddClient())
            {
                FormDashboard.showEmptyMessage();
                return;
            }

            DateTime dateTime = DateTime.Today;

            if (addNewClient(
                this.textBoxNewPassportID.Text.Trim(),
                long.Parse(this.textBoxNewPhoneNumber.Text.Trim()).ToString("00 000 000"),
                this.textBoxNewFirstName.Text.Trim(),
                this.textBoxNewMiddleName.Text.Trim(),
                this.textBoxNewLastName.Text.Trim(),
                this.textBoxNewUniversityName.Text.Trim(),
                this.dateTimePickerNewBirthDate.Value,
                this.radioButtonIsMale.Checked ? "Male" : "Female",
                dateTime,
                this.textBoxNewEmergencyFullName.Text.Trim(),
                this.textBoxNewEmergencyRelation.Text.Trim(),
                this.textBoxNewEmergencyPhone.Text.Trim(),
                this.textBoxNewEmergencyEmail.Text.Trim(),
                this.textBoxNewEmail.Text.Trim()                
                
                ))
            {
                MessageBox.Show("Client is added Successfully!", "Added Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearAddClient();
                return;
            }
            MessageBox.Show("Error Occured when trying to add the new client data!", "Added Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            return;

        }

        private void tabPageAddClient_Enter(object sender, EventArgs e)
        {
            this.clearAddClient();
        }

        private void tabPageShowClient_Enter(object sender, EventArgs e)
        {
            this.clearShowClient();
        }

        private void tabPageShowAllClients_Enter(object sender, EventArgs e)
        {
            this.clearShowAllClients();
            FormDashboard.getAllClients();
            fillAllClients(FormDashboard.clients);
        }
        private void fillAllClients(List<Client> clients)
        {
            this.dataGridViewClients.Rows.Clear();
            foreach (Client c in clients)
            {

                this.dataGridViewClients.Rows.Add(
                    c.ClientID,
                    c.FirstName,
                    c.MiddleName,
                    c.LastName,
                    c.Phone,
                    c.Email,
                    c.UniversityName,
                    c.EmergencyContactName,
                    
                    c.EmergencyContactPhone,
                    c.Gender,

                    c.InsertionDate,
                    c.EmergencyContactEmail,
                    c.BirthDate,
                    c.PassportID,
                    c.EmergencyContactRelation
                    );
            }
        }




        private void dataGridViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.tabControl.TabPages.Add(this.tabPageShowClient);
                this.tabControl.SelectedTab = this.tabPageShowClient;
                DataGridViewRow row = this.dataGridViewClients.Rows[e.RowIndex];
                this.textBoxUpdateFirstName.Text = row.Cells["ColumnFirstName"].Value.ToString();
                this.textBoxUpdateMiddleName.Text = row.Cells["ColumnMiddleName"].Value.ToString();
                this.textBoxUpdateLastName.Text = row.Cells["ColumnLastName"].Value.ToString();
                this.textBoxUpdatePhoneNumber.Text = row.Cells["ColumnPhoneNumber"].Value.ToString();

                this.textBoxUpdateEmail.Text = row.Cells["ColumnEmail"].Value.ToString();
                this.textBoxUpdatePassportID.Text = row.Cells["ColumnPassportID"].Value.ToString();
                this.textBoxUpdateUniversity.Text = row.Cells["ColumnUniversityName"].Value.ToString();
                this.dateTimePickerUpdateBirthDate.Value = Convert.ToDateTime(row.Cells["ColumnBirthDate"].Value.ToString());
                this.radioButtonUpdateIsMale.Checked = row.Cells["ColumnGender"].Value.ToString() == "Male" ? true : false;
                this.radioButtonUpdateIsFemale.Checked = !this.radioButtonUpdateIsMale.Checked;
                this.textBoxUpdateEmergencyFullName.Text = row.Cells["ColumnEmergencyName"].Value.ToString();
                this.textBoxUpdateEmergencyPhone.Text = row.Cells["ColumnEmergencyContact"].Value.ToString();
                this.textBoxUpdateEmergencyEmail.Text = row.Cells["ColumnEmergencyContactEmail"].Value.ToString();
                this.textBoxUpdateEmergencyRelation.Text = row.Cells["ColumnEmergencyContactRelation"].Value.ToString();
                this.textBoxUpdateFirstName.Tag = row.Cells["ColumnClientID"].Value.ToString();
                this.labelDateAdded.Text = Convert.ToDateTime(row.Cells["ColumnInsertionDate"].Value).ToString("yyyy/MM/dd");
                
            }
        }

        private void tabPageShowClient_Leave(object sender, EventArgs e)
        {

            this.tabControl.TabPages.Remove(this.tabPageShowClient);
            
        }

        //handle search for a client.
        private void textBoxSearchKeyWord_TextChanged(object sender, EventArgs e)
        {
            string searchText = this.textBoxSearchKeyWord.Text;
            if(this.comboBoxSearchOptions.SelectedItem.ToString() == "Name")
            {
                FormDashboard.filteredClients = FormDashboard.clients.Where(x => (x.FirstName + " " + x.MiddleName +" " +  x.LastName).StartsWith(searchText, StringComparison.OrdinalIgnoreCase)).Select(x => x).ToList();
                fillAllClients(FormDashboard.filteredClients);
            }
            else if (this.comboBoxSearchOptions.SelectedItem.ToString() == "Phone")
            {
                FormDashboard.filteredClients = FormDashboard.clients.Where(x => x.Phone.StartsWith(searchText, StringComparison.OrdinalIgnoreCase)).Select(x => x).ToList();
                fillAllClients(FormDashboard.filteredClients);
            }
            else if (this.comboBoxSearchOptions.SelectedItem.ToString() == "Email")
            {
                FormDashboard.filteredClients = FormDashboard.clients.Where(x => x.Email.StartsWith(searchText, StringComparison.OrdinalIgnoreCase)).Select(x => x).ToList();
                fillAllClients(FormDashboard.filteredClients);
            }
            else if (this.comboBoxSearchOptions.SelectedItem.ToString() == "University")
            {
                FormDashboard.filteredClients = FormDashboard.clients.Where(x => x.UniversityName.StartsWith(searchText, StringComparison.OrdinalIgnoreCase)).Select(x => x).ToList();
                fillAllClients(FormDashboard.filteredClients);
            }
        }

        private void comboBoxSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillAllClients(FormDashboard.clients);
            this.textBoxSearchKeyWord.Clear();
        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to update this clien?",
                "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            if (isEmptyUpdateClient())
            {
                FormDashboard.showEmptyMessage();
                return;
            }

            if(updateClient(
            int.Parse(this.textBoxUpdateFirstName.Tag.ToString()),
            this.textBoxUpdatePassportID.Text,
            this.textBoxUpdatePhoneNumber.Text,
            this.textBoxUpdateFirstName.Text,
            this.textBoxUpdateMiddleName.Text,
            this.textBoxUpdateLastName.Text,
            this.textBoxUpdateUniversity.Text,
            this.dateTimePickerUpdateBirthDate.Value,
            this.radioButtonIsMale.Checked ? "Male" : "Female",
            this.textBoxUpdateEmergencyFullName.Text,
            this.textBoxUpdateEmergencyRelation.Text,
            this.textBoxUpdateEmergencyPhone.Text,
            this.textBoxUpdateEmergencyEmail.Text,
            this.textBoxUpdateEmail.Text


            ))
            {
                MessageBox.Show("Client is updated successfully!", "Update Client",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tabControl.SelectedTab = this.tabPageShowAllClients;
            }
            else
            {
                FormDashboard.showDatabaseError("When Trying to update the client information!");
            }



        }


        private bool updateClient(
            int id,
            string passport,
            string phone,
            string fn,
            string mn,
            string ln,
            string uni,
            DateTime birth,
            string gender,
            string eName,
            string eRelation,
            string ePhone,
            string eEmail,
            string email


            )

        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery =
                        "UPDATE Tenant SET " +
                            "PassportID = @passport, " +
                            "PhoneNumber = @phone," +
                            "FirstName = @fn," +
                            "MiddleName = @mn," +
                            "LastName = @ln," +
                            "BirthOfDate  = @birth," +
                            "Gender = @gender," +
                            "EmergencyContactName = @eName," +
                            "EmergencyContactRelation = @eRelation," +
                            "EmergencyContactPhone = @ePhone," +
                            "EmergencyContactEmail =  @eEmail," +
                            "Email =  @email," +
                            "UniversityName = @uni " +
                         "WHERE TenantID = @id;";


                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@passport", passport);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@fn", fn);
                    command.Parameters.AddWithValue("@mn", mn);
                    command.Parameters.AddWithValue("@ln", ln);
                    command.Parameters.AddWithValue("@birth", birth);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@eName", eName);
                    command.Parameters.AddWithValue("@eRelation", eRelation);
                    command.Parameters.AddWithValue("@ePhone", ePhone);
                    command.Parameters.AddWithValue("@eEmail", eEmail);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@uni", uni);
                    if (command.ExecuteNonQuery() > 0)
                    {

                        return true;
                    }



                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this clien?\nYour action can not be undone!", 
                "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            if (deleteClient(int.Parse(this.textBoxUpdateFirstName.Tag.ToString())))
            {
                MessageBox.Show("Client has been deleted successfully!", "Delte Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tabControl.SelectedTab = this.tabPageShowAllClients;
            }
            else
            {
                FormDashboard.showDatabaseError("When trying to delete a client!");
            }
        }
        private bool deleteClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "DELETE FROM Tenant WHERE TenantID = @id";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@id", id);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }

                }
            }
            catch
            {
                return false;
            }




            return false;
        }
    }



}
