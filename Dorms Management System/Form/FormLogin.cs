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
    public partial class FormLogin : Form
    {
        public static string currentUserName = "";
        public static string currentUserType = "";
        public static int currentUserID = -1;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.pictureBoxClose, "Close");
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.pictureBoxClose, "Minimize");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            this.pictureBoxShow.Hide();
            this.textBoxPassword.UseSystemPasswordChar = false;
            this.pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            this.pictureBoxHide.Hide();
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.pictureBoxShow.Show();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

            string username = this.textBoxUsername.Text.ToLower().Trim();
            string password = this.textBoxPassword.Text.Trim();

            if (username == string.Empty || password == string.Empty) {

                MessageBox.Show("Please Fill All Required Fields!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }





            using (SqlConnection connection = new SqlConnection(Program.conString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM Users WHERE Username = @username AND Password = @password;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                var reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("Invalid credentials", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                reader.Read();
                currentUserName = reader["Username"].ToString();
                currentUserType = reader["UserType"].ToString();
                currentUserID = int.Parse(reader["UserID"].ToString());
                Program.dashboardForm = new FormDashboard();
                this.textBoxPassword.Clear();
                this.textBoxUsername.Clear();

                if (this.WindowState == FormWindowState.Maximized)
                    Program.dashboardForm.WindowState = FormWindowState.Maximized;

                Program.dashboardForm.Show();
                this.Hide();
            }








            //SqlConnection con = new SqlConnection(connectionString);
            //try
            //{
                
            //    if(con.State == ConnectionState.Closed)
            //    {
            //        con.Open();
            //    }
                
            //    SqlCommand sc = new SqlCommand(sqlQuery, con);
            //    sc.Parameters.AddWithValue("@username", username);
            //    sc.Parameters.AddWithValue("@password", password);

            //    SqlDataReader dr = sc.ExecuteReader();


            //    if (dr.HasRows) 
            //    {

            //    }
            //    else
            //    {
                    
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Error occured please contact help!!", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    if(con.State == ConnectionState.Open)
            //    {
            //        con.Close();
            //    }

            //}
            
            
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
    }
}













//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Microsoft.Data.SqlClient;
//namespace WindowsFormsApp2

//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void btnSave_Click(object sender, EventArgs e)
//        {

//            string connectionString = "Data Source=JOE-S-PC;Initial Catalog=testing; Integrated Security=True; TrustServerCertificate=true;";

//            string sqlQuery = "INSERT SENSOR(SensorName, SensorType) VALUES (@sensorname, @sensortype)";

//            SqlConnection con = new SqlConnection(connectionString);
//            con.Open();
//            SqlCommand sc = new SqlCommand(sqlQuery, con);

//            var sensorNameParameter = new SqlParameter("sensorname", System.Data.SqlDbType.VarChar);
//            sensorNameParameter.Value = this.txtSnesorName.Text;
//            sc.Parameters.Add(sensorNameParameter);

//            var sensorTypeParameter = new SqlParameter("sensortype", System.Data.SqlDbType.VarChar);
//            sensorTypeParameter.Value = this.txtSensorType.Text;
//            sc.Parameters.Add(sensorTypeParameter);


//            sc.ExecuteNonQuery();
//            con.Close();
//        }
//    }
//}