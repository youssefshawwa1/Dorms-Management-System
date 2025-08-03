using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorms_Management_System.User_Controls
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();

        }

        private void UserControlDashboard_Enter(object sender, EventArgs e)
        {
            FormDashboard.getAllUsers();
            FormDashboard.getAllRents();
            FormDashboard.getAllClients();
            FormDashboard.getAllRooms();
            FormDashboard.getAllBeds();
            FormDashboard.getAllFloors();
            
            this.labelBeds.Text = FormDashboard.beds.Count.ToString();
            this.labelRooms.Text = FormDashboard.rooms.Count.ToString();
            this.labelFloors.Text = FormDashboard.floors.Count.ToString();
            List<Bed> beds = FormDashboard.beds.Where(x => x.Status == "Available").Select(x => x).ToList();
            this.labelAvailableBeds.Text = beds.Count().ToString();
            List<Rent> rents = FormDashboard.rents.Where(x => x.CheckOutDate == null).Select(x => x).ToList();
            this.labelRents.Text = rents.Count().ToString();
            this.labelUsers.Text = FormDashboard.users.Count().ToString();
            this.labelClients.Text = FormDashboard.clients.Count().ToString();
        }
    }
}
