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

namespace Dorms_Management_System
{
    public partial class FormDashboard : Form
    {
        public static List<User> users = new List<User>();
        public static List<User> filteredUsers = new List<User>();
        public static List<BedFeature> features = new List<BedFeature>();
        public static List<RoomService> services = new List<RoomService>();
        public static List<BedFeature> filteredFeatures = new List<BedFeature>();
        public static List<RoomService> filteredServices = new List<RoomService>();
        public static List<Room> rooms = new List<Room>();
        public static List<Floor> floors = new List<Floor>();
        public static List<Room> filteredRooms = new List<Room>();
        public static List<Floor> filteredFloors = new List<Floor>();
        public static List<Bed> beds = new List<Bed>();
        public static List<Client> clients = new List<Client>();
        public static List<Client> filteredClients = new List<Client>();
        public static List<RentInfo> rentInfos = new List<RentInfo>();
        public static List<Rent> rents = new List<Rent>();
        public static List<Bill> bills = new List<Bill>();
        public static List<BedFeatures> bedFeatures = new List<BedFeatures>();
        public static List<RoomServices> roomServices = new List<RoomServices>();
        public FormDashboard()
        {


            InitializeComponent();
        }
        public static void getAllClients()
        {
            clients.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Tenant;";
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
                        FormDashboard.clients.Add(c);
                    }




                }
            }
            catch
            {
                showDatabaseError("When trying to get all clients from the Database!");
            }
        }
        public static void showDatabaseError(string reason)
        {
            MessageBox.Show("An error occured " + reason, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void showEmptyMessage()
        {

            MessageBox.Show("Make sure to fill all required fields!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void getAllBeds()
        {
            beds.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Bed;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Bed c = new Bed(
                            int.Parse(dr["BedID"].ToString()),
                            int.Parse(dr["RoomID"].ToString()),
                            dr["BedLabel"].ToString(),
                            dr["Status"].ToString(),
                            double.Parse(dr["Price"].ToString())
                            );
                        beds.Add(c);
                    }
                }
            }
            catch
            {
                showDatabaseError("When trying to get all Beds!");
            }
            return;

        }
        public static void getAllRooms()
        {
            rooms.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Room;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        //int userID, string username, string password, string userType
                        Room c = new Room(
                            int.Parse(dr["RoomID"].ToString()),
                            int.Parse(dr["FloorID"].ToString()),
                            dr["RoomNumber"].ToString(),
                            dr["Description"].ToString(),
                            dr["RoomType"].ToString()
                            );
                        rooms.Add(c);
                    }
                }
            }
            catch
            {
                showDatabaseError("When trying to get all Rooms!");
            }
            return;

        }
        public static void getAllFloors()
        {
            floors.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Floor;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        //int userID, string username, string password, string userType
                        Floor c = new Floor(
                            int.Parse(dr["FloorID"].ToString()),
                            int.Parse(dr["FloorLevel"].ToString()),
                            dr["Description"].ToString(),
                            dr["FloorName"].ToString()
                            );
                        floors.Add(c);
                    }
                }
            }
            catch
            {
                showDatabaseError("When trying to get all Floors!");
            }
            return;




        }
        public static void getAllFeatures()
        {
            features.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM BedFeature;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        BedFeature f = new BedFeature(
                            int.Parse(dr["FeatureID"].ToString()),
                            dr["FeatureName"].ToString(),
                            double.Parse(dr["Price"].ToString()),
                            dr["Description"].ToString()
                            );
                        features.Add(f);
                    }
                }
            }
            catch
            {
                showDatabaseError("When trying to get all Features!");
            }
            return;
        }

        public static void getAllServices()
        {
            services.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM RoomService;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        //int userID, string username, string password, string userType
                        RoomService c = new RoomService(
                            int.Parse(dr["ServiceID"].ToString()),
                            dr["ServiceName"].ToString(),
                            double.Parse(dr["Price"].ToString()),
                            dr["Description"].ToString()
                            );
                        services.Add(c);
                    }
                }
            }
            catch
            {
                showDatabaseError("When trying to get all Services!");
            }
            return;
        }
        public static void getAllUsers()
        {
            users.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Users;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        //int userID, string username, string password, string userType
                        User u = new User(
                            int.Parse(dr["UserID"].ToString()),
                            dr["Username"].ToString(),
                            dr["Password"].ToString(),
                            dr["UserType"].ToString()
                            );
                        users.Add(u);
                    }



                }
            }
            catch
            {
                showDatabaseError("When trying to get all users!");
            }
            return;
        }



        public void updateCurrentUsernameName()
        {
            this.labelUserName.Text = FormLogin.currentUserName;
        }


        //Handle clicking on options and moving the panel to the selected button
        private void movePanel(Control btn)
        {

            this.panelSlide.Top = btn.Top;
            this.panelSlide.Height = btn.Height;
        }

        //Handle the real time timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelDate.Text = DateTime.Now.ToString("dd-MMM-yyy hh:mm:ss tt");
        }



        //Handle Close minimize tooltips
        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.pictureBoxClose, "Close");
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.pictureBoxClose, "Minimize");
        }

        //Handle Closing
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }



        }

        //Handle Minimizing the window
        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Handlle double click to maximize the window
        private void panelTop_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        //Handle dragging the window and moving it.
        private bool isDragging = false;
        private Point offset;

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offset = e.Location;
            }
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.PointToScreen(e.Location);
                newLocation.Offset(-offset.X, -offset.Y);
                this.Location = newLocation;
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        //When the form loads
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.updateCurrentUsernameName();
        }



        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            this.userControlClients.Hide();
            this.userControlUsers.Hide();
            this.userControlServices.Hide();
            this.userControlClients.Hide();
            this.userControlRooms.Hide();
            this.userControlBills.Hide();
            this.userControlDashboard.Show();
            this.movePanel((Button) sender);
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            this.userControlDashboard.Hide();
            this.userControlUsers.Hide();
            this.userControlServices.Hide();
            this.userControlClients.Hide();
            this.userControlRooms.Hide();
            this.userControlBills.Hide();
            this.userControlCheckInOut.reset();
            this.userControlCheckInOut.Show();
            this.movePanel((Button)sender);
            
        }

        private void buttonBills_Click(object sender, EventArgs e)
        {
            this.userControlDashboard.Hide();
            this.userControlUsers.Hide();
            this.userControlServices.Hide();
            this.userControlClients.Hide();
            this.userControlRooms.Hide();
            this.userControlCheckInOut.Hide();
            this.userControlBills.Show();
            
            this.movePanel((Button)sender);
            this.userControlUsers.Hide();
        }

        private void buttonFloors_Click(object sender, EventArgs e)
        {
            this.movePanel((Button)sender);
            this.userControlUsers.Hide();
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            this.userControlDashboard.Hide();
            this.movePanel((Button)sender);
            this.userControlUsers.Hide();
            this.userControlCheckInOut.Hide();
            this.userControlServices.Hide();
            this.userControlClients.Hide();
            this.userControlBills.Hide();
            this.userControlRooms.reset();
            this.userControlRooms.Show();
        }

        private void buttonBeds_Click(object sender, EventArgs e)
        {
            this.movePanel((Button)sender);
            this.userControlUsers.Hide();
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            this.userControlDashboard.Hide();
            this.movePanel((Button)sender);
            this.userControlBills.Hide();
            this.userControlUsers.Hide();
            this.userControlClients.Hide();
            this.userControlRooms.Hide();
            this.userControlCheckInOut.Hide();
            this.userControlServices.reset();
            this.userControlServices.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            this.userControlDashboard.Hide();
            this.movePanel((Button)sender);
            this.userControlBills.Hide();
            this.userControlUsers.Hide();
            this.userControlRooms.Hide();
            this.userControlServices.Hide();
            this.userControlCheckInOut.Hide();
            this.userControlClients.reset();
            this.userControlClients.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            this.userControlDashboard.Hide();
            this.movePanel((Button)sender);
            this.userControlRooms.Hide();
            this.userControlBills.Hide();
            this.userControlCheckInOut.Hide();
            this.userControlClients.Hide();
            this.userControlServices.Hide();
            this.userControlUsers.reset();
            this.userControlUsers.Show();

        }

        //Handle Loging out
        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Are you sure you want to Log Out", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                timer1.Stop();
                this.Close();
                this.Dispose();
                Program.loginForm.Show();
            }



        }






        public static void getAllRentInfos()
        {
            rentInfos.Clear();
            var s =
               from r in rents
               join c in FormDashboard.clients
                   on r.ClientID equals c.ClientID
               join room in FormDashboard.rooms
                   on r.RoomID equals room.RoomID

               select new
               {
                   Name = c.FullName,
                   RentID = r.RentID,
                   CheckedInDate = r.CheckInDate,
                   CheckedOutDate = r.CheckOutDate,
                   MustCheckOutOn = r.EstimateCheckOUt,
                   Type = r.Type,
                   RoomNumber = room.RoomNumber,
                   ClientID = r.ClientID,
                   RoomID = r.RoomID,
                   BedID = r.BedID,
                   PhoneNumber = c.Phone,
                   UserID = r.UserID,
                   RoomType = room.RoomType
               };

            foreach (var r in s)
            {
                DateTime? d = null;
                string bedsNames = "";
                if (r.CheckedOutDate != null)
                {

                    d = r.CheckedOutDate;

                }
                if (r.BedID != null)
                {

                    bedsNames = (FormDashboard.beds.Where(x => x.BedID == r.BedID).FirstOrDefault()).BedLabel;
                }
                else
                {
                    List<string> b = FormDashboard.beds.Where(x => x.RoomID == r.RoomID).Select(x => x.BedLabel).ToList();

                    bedsNames = string.Join(", ", b);
                }
                string userName = FormDashboard.users.Where(x => x.UserID == r.UserID).FirstOrDefault().UserName;
                List<string> services = roomServices.Where(x => x.RentID == r.RentID).
                    Join(FormDashboard.services, relation => relation.ServiceID, service => service.ServicID, (relation, service) => service.ServiceName).ToList();
                List<string> features = bedFeatures.Where(x => x.RentID == r.RentID).
                    Join(FormDashboard.features, relation => relation.FeatureID, feature => feature.FeatureID, (relation, feature) => feature.FeatureName).ToList();
                string rs = string.Join(", ", services);
                string bf = string.Join(", ", features); ;

                rentInfos.Add(
                    new RentInfo(
                        r.RentID,
                        r.ClientID,
                        r.Name,
                        r.PhoneNumber,
                        r.RoomNumber,
                        bedsNames,
                        r.Type,
                        r.CheckedInDate,
                        d,
                        r.MustCheckOutOn,
                        bf,
                        rs,
                        r.RoomID,
                        r.BedID,
                        r.RoomType,
                        userName
                       )
                    );
            }
        }









        public static void getAllBills()
        {
            bills.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Bill;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        DateTime payedDate = new DateTime();
                        if (dr["PayedDate"] != DBNull.Value)
                        {
                            payedDate = Convert.ToDateTime(dr["PayedDate"].ToString());
                        }

                        Bill c = new Bill(
                        int.Parse(dr["BillID"].ToString()),
                            int.Parse(dr["RentID"].ToString()),
                            double.Parse(dr["Total"].ToString()),
                            (bool)dr["isPayed"],
                            Convert.ToDateTime(dr["BillDate"].ToString()),
                            payedDate,
                            double.Parse(dr["ToBePayed"].ToString()),
                            double.Parse(dr["Payed"].ToString()),
                            int.Parse(dr["UserID"].ToString())
                            );
                        bills.Add(c);
                    }
                }
            }
            catch
            {
                FormDashboard.showDatabaseError("When trying to get all bills from the Database!");
            }
        }




        public static void getAllRents()
        {
            rents.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {

                    connection.Open();
                    string sqlQuery = "SELECT * FROM Rent;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        DateTime? checkOutDate = null;
                        int? bedID = null;
                        if (dr["checkOutDate"] != DBNull.Value)
                        {
                            checkOutDate = Convert.ToDateTime(dr["checkOutDate"]);
                        }
                        if (dr["BedID"] != DBNull.Value)
                        {
                            bedID = int.Parse(dr["BedID"].ToString());
                        }
                        Rent c = new Rent(
                            int.Parse(dr["RentID"].ToString()),
                            int.Parse(dr["TenantID"].ToString()),
                            bedID,
                            int.Parse(dr["RoomID"].ToString()),
                            Convert.ToDateTime(dr["checkInDate"]),
                            checkOutDate,
                            Convert.ToDateTime(dr["estimateCheckOut"]),
                            dr["Type"].ToString(),
                            int.Parse(dr["UserID"].ToString())
                            );
                        rents.Add(c);
                    }




                }
            }
            catch
            {
                FormDashboard.showDatabaseError("When trying to get all rents from the Database!");
            }
        }










        public static void getAllAssignedServices()
        {
            roomServices.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM RoomServices;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        RoomServices c = new RoomServices(
                            int.Parse(dr["RoomServicesID"].ToString()),
                            int.Parse(dr["ServiceID"].ToString()),
                            int.Parse(dr["RentID"].ToString())
                            );
                        roomServices.Add(c);
                    }
                }
            }
            catch
            {
                FormDashboard.showDatabaseError("When trying to get all RoomServices!");
            }
            return;

        }
        public static void getAllAssignedFeatures()
        {
            bedFeatures.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM BedFeatures;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        BedFeatures c = new BedFeatures(
                            int.Parse(dr["BedFeaturesID"].ToString()),
                            int.Parse(dr["FeatureID"].ToString()),
                            int.Parse(dr["RentID"].ToString())
                            );
                        bedFeatures.Add(c);
                    }
                }
            }
            catch
            {
                FormDashboard.showDatabaseError("When trying to get all RoomServices!");
            }
            return;
        }





    }
}
