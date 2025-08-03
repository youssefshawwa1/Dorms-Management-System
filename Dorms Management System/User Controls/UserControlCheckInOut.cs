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
    public partial class UserControlCheckInOut : UserControl
    {
        private List<RoomService> selectedServices;
        private List<BedFeature> selectedFeatures;
        private List<Client> filteredClients;
        private double total = 0;
        private List<RentInfo> filteredRentInfos;
        public UserControlCheckInOut()
        {
            InitializeComponent();
            selectedServices = new List<RoomService>();
            selectedFeatures = new List<BedFeature>();
            filteredClients = new List<Client>();
            filteredRentInfos = new List<RentInfo>();
            this.dataGridViewAllChecks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAllChecks.MultiSelect = false; // Ensures only one row can be selected

        }

        private void UserControlCheckInOut_Enter(object sender, EventArgs e)
        {
            
        }

        private void fillComboBox<T>(ComboBox c, List<T> s, string display, string value) {

            c.DataSource = s;
            c.DisplayMember = display;
            c.ValueMember = value;
            c.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            c.AutoCompleteSource = AutoCompleteSource.ListItems;
            c.DroppedDown = false;
            c.FormattingEnabled = true;
            c.SelectedIndex = -1;

        }

        private void fillListBox<T>(ListBox s, List<T> o, string display, string value)
        {
            s.DataSource = o;
            s.DisplayMember = display;
            s.ValueMember = value;
            s.SelectedIndex = -1;
        }
        

        private void fillAllCheckInOut(List<RentInfo> s)
        {
            this.dataGridViewAllChecks.Rows.Clear();
            foreach(RentInfo r in s)
            {
                this.dataGridViewAllChecks.Rows.Add(
                        r.RentID,
                        r.ClientID,
                        r.Name,
                        r.PhoneNumber,
                        r.RoomNumber,
                        r.BedNamse,
                        r.Type,
                        r.RoomType,
                        r.RoomServices,
                        r.BedFeatures,
                        r.CheckInDate.ToString("yy/MM/dd"),
                        r.CheckOutDate == null ? "" : r.CheckInDate.ToString("yy/MM/dd"),
                        r.MustCheckOutOn.ToString("yy/MM/dd"),
                        //endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month
                        r.CheckOutDate == null ? (r.MustCheckOutOn.Year - r.CheckInDate.Year) * 12 + r.MustCheckOutOn.Month - r.CheckInDate.Month : (((DateTime)r.CheckOutDate).Year - r.CheckInDate.Year) * 12 + ((DateTime)r.CheckOutDate).Month - r.CheckInDate.Month,
                        r.CheckOutDate == null ? (DateTime.Today.Year - r.MustCheckOutOn.Year) * 12 + r.MustCheckOutOn.Month - DateTime.Today.Month : 0,
                        r.UserName,
                        r.RoomID,
                        r.BedID
                    );
            }




        }



        private void comboBoxNewCheckInClient_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBoxNewCheckInClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool areEmpty()
        {
            try
            {


                if (this.comboBoxNewCheckInClient.SelectedIndex == -1 ||
                   this.comboBoxNewCheckInRoom.SelectedIndex == -1 ||
                   double.Parse(this.textBoxTotallToBePayed.Text.ToString()) == 0)
            {
                return true;
            }
            }
            catch
            {
                return true;

            }

            if (this.radioButtonNewIsFullRoom.Checked)
            {
                return false;
            }
            if(this.comboBoxNewCheckInBed.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }



        private void fillSpecifiedRoom()
        {
            
            List<Room> d = new List<Room>();
            this.listBoxNewFeatures.SelectedIndex = -1;
            this.comboBoxNewCheckInBed.SelectedIndex = -1;
            this.comboBoxNewCheckInRoom.SelectedIndex = -1;
            if (this.radioButtonNewIsNormal.Checked && this.radioButtonNewIsFullRoom.Checked)
            {
                this.comboBoxNewCheckInBed.Enabled = false;
                d = FormDashboard.rooms
                .Where(room => FormDashboard.beds
                .Count(bed => bed.RoomID == room.RoomID && bed.Status == "Available") == 2 && room.RoomType == "Normal").ToList();

            }
            else if(this.radioButtonNewIsPremium.Checked && this.radioButtonNewIsOneBed.Checked)
            {
                this.comboBoxNewCheckInBed.Enabled = true;
                d = FormDashboard.rooms.Where(room => FormDashboard.beds
                .Count(bed => bed.RoomID == room.RoomID && bed.Status == "Available") >= 1 && room.RoomType == "Premium").ToList();
            }
            else if(this.radioButtonNewIsPremium.Checked && this.radioButtonNewIsFullRoom.Checked)
            {
                this.comboBoxNewCheckInBed.Enabled = false;
                d = FormDashboard.rooms
                .Where(room => FormDashboard.beds
                .Count(bed => bed.RoomID == room.RoomID && bed.Status == "Available") == 2 && room.RoomType == "Premium").ToList();
            }
            else
            {
                this.comboBoxNewCheckInBed.Enabled = true;
                d = FormDashboard.rooms.Where(room => FormDashboard.beds
                                   .Count(bed => bed.RoomID == room.RoomID && bed.Status == "Available") >= 1 && room.RoomType == "Normal").ToList();
            }

            fillComboBox(this.comboBoxNewCheckInRoom,
                d,
                "RoomNumber", "RoomID");
            this.comboBoxNewCheckInBed.DataSource = null;

        }


        private void radioButtonNewIsFullRoom_CheckedChanged(object sender, EventArgs e)
        {
            fillSpecifiedRoom();
        }
        private void radioButtonNewIsPremium_CheckedChanged(object sender, EventArgs e)
        {
            fillSpecifiedRoom();
        }

        private void comboBoxNewCheckInRoom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.selectedFeatures.Clear();
            this.selectedServices.Clear();
            this.listBoxNewFeatures.SelectedIndex = -1;
            this.listBoxNewServices.SelectedIndex = -1;
            int roomId;
            try
            {
                roomId = int.Parse(this.comboBoxNewCheckInRoom.SelectedValue.ToString());
            }
            catch
            {
                roomId = -1;
            }
            if (!this.radioButtonNewIsFullRoom.Checked)
            {
                List<Bed> beds = FormDashboard.beds.Where(x => x.RoomID == roomId && x.Status == "Available").Select(x => x).ToList();

                fillComboBox(this.comboBoxNewCheckInBed,
                    beds,
                    "BedInfo",
                    "BedID");
            }
            calculateTotal();
        }

        private void comboBoxNewCheckInBed_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.selectedFeatures.Clear();
            this.listBoxNewFeatures.SelectedIndex = -1;
            calculateTotal();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today.AddMonths(int.Parse(this.numericUpDownMonths.Value.ToString()));
            this.labelMustCheckOutOn.Text = dt.ToString("yyyy-MM-dd");
            calculateTotal();

        }

        private void dateTimePickerNewCheckIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPageNewCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void listBoxNewServices_SelectedIndexChanged(object sender, EventArgs e)
        {

             this.selectedServices = listBoxNewServices.SelectedItems
                         .Cast<RoomService>()
                         .ToList();
            calculateTotal();

        }


        private void getAllFilteredClients()
        {
            filteredClients.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = @"SELECT t.*
                                        FROM Tenant t
                                        WHERE 
                                            t.TenantID NOT IN (SELECT TenantID FROM Rent)
                                        UNION
                                        SELECT t.*
                                        FROM Tenant t
                                        WHERE t.TenantID IN(SELECT TenantID FROM Rent WHERE CheckOutDate IS NOT NULL) ;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        //int userID, string username, string password, string userType
                        Client c = new Client(
                            int.Parse(dr["TenantID"].ToString()),
                            dr["PassportID"].ToString(),
                            dr["PhoneNumber"].ToString(),
                            dr["FirstName"].ToString(),
                            dr["MiddleName"].ToString(),
                            dr["LastName"].ToString(),
                            dr["UniversityName"].ToString(),
                            Convert.ToDateTime(dr["BirthOfDate"]),
                            dr["Gender"].ToString(),
                            Convert.ToDateTime(dr["InsertionDate"]),
                            dr["EmergencyContactName"].ToString(),
                            dr["EmergencyContactRelation"].ToString(),
                            dr["EmergencyContactPhone"].ToString(),
                            dr["EmergencyContactEmail"].ToString(),
                            dr["Email"].ToString()
                            );
                        filteredClients.Add(c);
                    }
                }
            }
            catch
            {
                FormDashboard.showDatabaseError("When trying to get all clients from the Database!");
            }

        }
        public void reset()
        {
            clearCheckIn();
            this.tabControlOptions.SelectedTab = this.tabPageNewCheckIn;
        }

        private void clearCheckIn()
        {
            this.radioButtonNewIsNormal.Checked = true;
            this.radioButtonNewIsOneBed.Checked = true;
            this.buttonCheckOut.Visible = false;
            FormDashboard.getAllServices();
            FormDashboard.getAllFeatures();
            FormDashboard.getAllRooms();
            FormDashboard.getAllBeds();
            FormDashboard.getAllClients();
            FormDashboard.getAllRents();
            FormDashboard.getAllBills();
            getAllFilteredClients();
            FormDashboard.getAllAssignedServices();
            FormDashboard.getAllAssignedFeatures();
            FormDashboard.getAllRentInfos();
            this.comboBoxNewCheckInClient.DataSource = null;
            filteredRentInfos = FormDashboard.rentInfos.Where(x => x.CheckOutDate == null).Select(x => x).ToList();
            fillAllCheckInOut(filteredRentInfos);
            fillComboBox(
                this.comboBoxNewCheckInClient, 
                filteredClients,
                "FullNameWithNumber", "ClientID");
            fillListBox(
                this.listBoxNewFeatures,
                FormDashboard.features,
                "FeatureInfo", "FeatureID");
            fillListBox(
                this.listBoxNewServices,
                FormDashboard.services,
                "ServiceInfo", "ServicID");

            fillSpecifiedRoom();

            this.labelMustCheckOutOn.Text = DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd");


            this.selectedFeatures.Clear();
            this.selectedServices.Clear();
            this.numericUpDownMonths.Value = 1;
            calculateTotal();
            this.textBoxTotallToBePayed.Clear();
            this.comboBoxNewCheckInBed.SelectedIndex = -1;
            this.comboBoxNewCheckInRoom.SelectedIndex = -1;
            this.comboBoxNewCheckInClient.SelectedIndex = -1;

        }
        private void buttonPayNow_Click(object sender, EventArgs e)
        {
            if (areEmpty())
            {
                FormDashboard.showEmptyMessage();
                return;
            }
            int clientID = ((Client)this.comboBoxNewCheckInClient.SelectedItem).ClientID;
            int bedID = this.radioButtonNewIsFullRoom.Checked ? -1 : ((Bed)this.comboBoxNewCheckInBed.SelectedItem).BedID;
            int roomID = ((Room)this.comboBoxNewCheckInRoom.SelectedItem).RoomID;
            DateTime mustBeOutOn = DateTime.Today.AddMonths((int)this.numericUpDownMonths.Value);
            string type = this.radioButtonNewIsFullRoom.Checked ? "Full Room" : "One Bed";
            double toBePayed = double.Parse(this.textBoxTotallToBePayed.Text);
            bool result = 
                addCheckIn(
                clientID, 
                bedID, 
                roomID,
                DateTime.Today,
                mustBeOutOn, 
                type,
                this.total,
                true,
                DateTime.Today,
                DateTime.Today,
                toBePayed,
                toBePayed);

            if(result)
            {
                MessageBox.Show("The CheckIn has been added and payed successfully!",
                    "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearCheckIn();
                return;
            }
            FormDashboard.showDatabaseError("When trying to add new Rent!");






        }
        private bool addCheckIn(
            int TenantID,
            int BedID,
            int RoomID,
            DateTime CheckInDate,
            DateTime EstimateCheckOut,
            string Type,
            double Total,
            bool isPayed,
            DateTime BillDate,
            DateTime PayedDate,
            double ToBePayed,
            double Payed)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery;
                    SqlCommand command;
                    string bedChange;
                    if (BedID != -1)
                    {
                        sqlQuery = @"INSERT INTO Rent (TenantID, BedID, RoomID, CheckInDate, EstimateCheckOut, Type, UserID) 
                        OUTPUT INSERTED.RentID
                        VALUES (@client, @bed, @room, @checkInDate, @mustCheckOutOn, @type, @user);";
                        command = new SqlCommand(sqlQuery, connection);
                        command.Parameters.AddWithValue("@bed", BedID);
                        bedChange = @"UPDATE Bed SET Status = @status WHERE BedID = @id";
                    }
                    else
                    {
                        sqlQuery = @"INSERT INTO Rent (TenantID, RoomID, CheckInDate, EstimateCheckOut, Type, UserID) 
                        OUTPUT INSERTED.RentID
                        VALUES (@client, @room, @checkInDate, @mustCheckOutOn, @type, @User);";
                        command = new SqlCommand(sqlQuery, connection);
                        bedChange = @"UPDATE Bed SET Status = @status WHERE RoomID = @id";
                    }

                    command.Parameters.AddWithValue("@client", TenantID);
                    command.Parameters.AddWithValue("@room", RoomID);
                    command.Parameters.AddWithValue("@checkInDate", CheckInDate);
                    command.Parameters.AddWithValue("@mustCheckOutOn", EstimateCheckOut);
                    command.Parameters.AddWithValue("@type", Type);
                    command.Parameters.AddWithValue("@user", FormLogin.currentUserID);

                    int newRentID = (int)command.ExecuteScalar();

                    if (newRentID > 0)
                    {
                        if(selectedServices.Count() != 0) {
                            if (!assignNewService(this.selectedServices, newRentID))
                                FormDashboard.showDatabaseError("Services");
                        }
                        if (selectedFeatures.Count() != 0)
                        {
                            if(!assignNewFeatures(this.selectedFeatures, newRentID))
                                FormDashboard.showDatabaseError("Features");
                        }

                        SqlCommand c2 = new SqlCommand(bedChange, connection);
                        c2.Parameters.AddWithValue("@status", "Reserved");
                        if(BedID != -1)
                        {
                            c2.Parameters.AddWithValue("@id", BedID);
                        }
                        else {
                            c2.Parameters.AddWithValue("@id", RoomID);
                        }

                        c2.ExecuteNonQuery();
                        if (newBill(
                            newRentID,
                            Total,
                            isPayed,
                            BillDate,
                            PayedDate,
                            ToBePayed,
                            Payed
                            )){
                            return true;
                        }


                    }
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
        private bool newBill(
            int RentID,
            double Total,
            bool isPayed,
            DateTime BillDate,
            DateTime PayedDate,
            double ToBePayed,
            double Payed
            )
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    SqlCommand command;
                    string sqlQuery;
                    if (!isPayed)
                    {
                        sqlQuery = @"INSERT INTO Bill 
                                        (RentID, Total, isPayed, BillDate, ToBePayed , Payed, UserID)
                                    VALUES 
                                        (@rentId, @total, @isPayed, @billDate, @toBePayed, @payed, @user);";
                        command = new SqlCommand(sqlQuery, connection);
                        command.Parameters.AddWithValue("@user", FormLogin.currentUserID);
                    }
                    else 
                    {
                        sqlQuery = @"INSERT INTO Bill 
                                        (RentID, Total, isPayed, BillDate, PayedDate, ToBePayed , Payed, UserID)
                                    VALUES 
                                        (@rentId, @total, @isPayed, @billDate, @payedDate, @toBePayed, @payed, @user);";
                        command = new SqlCommand(sqlQuery, connection);

                        command.Parameters.AddWithValue("@payedDate", PayedDate);
                    }

                    command.Parameters.AddWithValue("@rentId", RentID);
                        command.Parameters.AddWithValue("@total", Total);
                        command.Parameters.AddWithValue("@isPayed", isPayed);
                        command.Parameters.AddWithValue("@billDate", BillDate);
                        command.Parameters.AddWithValue("@toBePayed", ToBePayed);
                        command.Parameters.AddWithValue("@payed", Payed);
                    
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
        private bool assignNewService(List<RoomService> s, int RentID)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = @"INSERT INTO RoomServices (ServiceID,RentID) VALUES (@sid, @rid);";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    command.Parameters.Add("@sid", SqlDbType.Int);
                    command.Parameters.Add("@rid", SqlDbType.Int);
                    command.Parameters["@rid"].Value = RentID;
                    foreach (RoomService service in s)
                    {
                        command.Parameters["@sid"].Value = service.ServicID;
                        if(command.ExecuteNonQuery() == 0) {
                            return false;
                        }
                    }
                   return true ;
                }
            }
            catch
            {
                return false;
            }
        }
        private bool assignNewFeatures(List<BedFeature> f, int RentID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = @"INSERT INTO BedFeatures (FeatureID,RentID) VALUES (@fid, @rid);";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    command.Parameters.Add("@fid", SqlDbType.Int);
                    command.Parameters.Add("@rid", SqlDbType.Int);
                    command.Parameters["@rid"].Value = RentID;
                    foreach (BedFeature feature in f)
                    {
                        command.Parameters["@fid"].Value = feature.FeatureID;
                        if (command.ExecuteNonQuery() == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void listBoxNewFeatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedFeatures = listBoxNewFeatures.SelectedItems
            .Cast<BedFeature>()
            .ToList();
            calculateTotal();
        }
        private void calculateTotal()
        {
            double total = 0;
            double bedPrice = 0;
            double servicesPrice = 0;
            double featuresprice = 0;
            int amount = int.Parse(this.numericUpDownMonths.Value.ToString());

            if (this.selectedServices.Count != 0)
            {
                servicesPrice += selectedServices.Sum(x => x.Price);
            }
            if (this.selectedFeatures.Count != 0)
            {
                featuresprice += selectedFeatures.Sum(x => x.Price);
            }
            if (this.radioButtonNewIsOneBed.Checked && this.comboBoxNewCheckInBed.SelectedIndex != -1)
            {
                bedPrice = ((Bed)this.comboBoxNewCheckInBed.SelectedItem).Price;
            }
            else if(this.radioButtonNewIsFullRoom.Checked && this.comboBoxNewCheckInRoom.SelectedIndex != -1)
            {
                Room r = (Room)this.comboBoxNewCheckInRoom.SelectedItem;
                List<Bed> bedss = FormDashboard.beds.Where(x => x.RoomID == r.RoomID).ToList();
                if (bedss.Count == 1)
                {
                    bedPrice += bedss[0].Price * 2;
                }
                else if (bedss.Count == 2)
                {
                    bedPrice += bedss.Sum(x => x.Price);
                }
            }

            total = (bedPrice + servicesPrice + featuresprice) * amount;
            this.textBoxTotal.Text = $"{total.ToString("C")}";
            this.textBoxTotallToBePayed.Text = $"{total}";
            this.total = total;
        }

        private void buttonPayLater_Click(object sender, EventArgs e)
        {
            if (areEmpty())
            {
                FormDashboard.showEmptyMessage();
                return;
            }
            int clientID = ((Client)this.comboBoxNewCheckInClient.SelectedItem).ClientID;
            int bedID = this.radioButtonNewIsFullRoom.Checked ? -1 : ((Bed)this.comboBoxNewCheckInBed.SelectedItem).BedID;
            int roomID = ((Room)this.comboBoxNewCheckInRoom.SelectedItem).RoomID;
            DateTime mustBeOutOn = DateTime.Today.AddMonths((int)this.numericUpDownMonths.Value);
            string type = this.radioButtonNewIsFullRoom.Checked ? "Full Room" : "One Bed";
            double toBePayed = double.Parse(this.textBoxTotallToBePayed.Text);
            bool result =

                addCheckIn(
                clientID,
                bedID,
                roomID,
                DateTime.Now,
                mustBeOutOn,
                type,
                this.total,
                false,
                DateTime.Now,
                new DateTime(),
                toBePayed,
                0);

            if (result)
            {
                MessageBox.Show("The CheckIn has been added and payed successfully!",
                    "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearCheckIn();
                return;
            }
            FormDashboard.showDatabaseError("When trying to add new Rent!");
        }

        private void textBoxSearchKeyWord_TextChanged(object sender, EventArgs e)
        {
            string searchWord = this.textBoxSearchKeyWord.Text;

            if(this.radioButtonAll.Checked)
                filteredRentInfos = FormDashboard.rentInfos.Where(x => x.Name.StartsWith(searchWord, StringComparison.OrdinalIgnoreCase)).Select(x => x).ToList();
            else if(this.radioButtonNotCheckedOut.Checked)
                filteredRentInfos = FormDashboard.rentInfos.Where(x => x.Name.StartsWith(searchWord, StringComparison.OrdinalIgnoreCase) && x.CheckOutDate == null).Select(x => x).ToList();
            else if(this.radioButtonCheckedOut.Checked)
                filteredRentInfos = FormDashboard.rentInfos.Where(x => x.Name.StartsWith(searchWord, StringComparison.OrdinalIgnoreCase) && x.CheckOutDate != null).Select(x => x).ToList();
            fillAllCheckInOut(filteredRentInfos);
            this.buttonCheckOut.Visible = false;
            this.buttonCheckOut.Tag = null;
        }

        private void radioButtonCheckedOut_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonCheckedOut.Checked) { 
            filteredRentInfos = FormDashboard.rentInfos.Where(x => x.CheckOutDate != null).Select(x => x).ToList();
            this.textBoxSearchKeyWord.Text = "";
            fillAllCheckInOut(filteredRentInfos);
                this.buttonCheckOut.Visible = false;
                this.buttonCheckOut.Tag = null;
            }
            
        }

        private void radioButtonNotCheckedOut_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonNotCheckedOut.Checked)
            {
                this.buttonCheckOut.Visible = false;
                this.buttonCheckOut.Tag = null;
                filteredRentInfos = FormDashboard.rentInfos.Where(x => x.CheckOutDate == null).Select(x => x).ToList();
                this.textBoxSearchKeyWord.Text = "";
                fillAllCheckInOut(filteredRentInfos);
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAll.Checked)
            {
                this.textBoxSearchKeyWord.Text = "";
                fillAllCheckInOut(FormDashboard.rentInfos);
                this.buttonCheckOut.Visible = false;
                this.buttonCheckOut.Tag = null;
            }
        }


        private void dataGridViewAllChecks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridViewRow row = this.dataGridViewAllChecks.Rows[e.RowIndex];
                if (string.IsNullOrEmpty(row.Cells["ColumnCheckedOutDate"].Value.ToString()))
                {
                    this.buttonCheckOut.Visible = true;
                    this.buttonCheckOut.Tag = new
                    {
                        RentID = int.Parse(row.Cells["ColumnRentID"].Value.ToString()),
                        BedID = row.Cells["ColumnBedID"].Value == null ? -1 : int.Parse(row.Cells["ColumnBedID"].Value.ToString()),
                        RoomID =  int.Parse(row.Cells["ColumnRoomID"].Value.ToString())
                    };
                }
                else
                {
                    this.buttonCheckOut.Visible = false;
                    this.buttonCheckOut.Tag = null;
                }
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (this.buttonCheckOut.Tag == null)
                return;
            DialogResult result = MessageBox.Show("Do you really want to check out this Rent?", "Check Out",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.No)
                return;
            dynamic tagData = this.buttonCheckOut.Tag;
            if (checkOut(tagData.RentID, tagData.BedID, tagData.RoomID))
            {
                MessageBox.Show("The rent status has been changed to Checked Out!\n\nIf this rent has an unpayed Bill, you can pay it from the bills page!",
                    "Successfull Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearCheckIn();
                return;
            }

            FormDashboard.showDatabaseError("When trying to Check Out!");
            return;
        }


        private bool checkOut(int rentID, int bedID, int roomID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "UPDATE Rent SET CheckOutDate = @date WHERE RentID = @rentID AND CheckOutDate IS NULL;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@date", DateTime.Now);
                    command.Parameters.AddWithValue("rentID", rentID);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        command.Parameters.Clear();
                        sqlQuery = "UPDATE Bed SET Status = @a WHERE";
                        
                        
                        if (bedID != -1)
                        {
                            sqlQuery += " BedID = @id";
                            command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@id", bedID);
                        }
                        else
                        {
                            sqlQuery += " RoomID = @id";
                            command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@id", roomID);
                        }
                        command.Parameters.AddWithValue("@a", "Available");

                        result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            return true;
                        }

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
