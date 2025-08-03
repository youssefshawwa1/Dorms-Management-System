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
    public partial class UserControlRooms : UserControl
    {

        private Room selectedRoom;
        private int selecteRoomID = 0;
        public UserControlRooms()
        {
            InitializeComponent();
            this.tabControlRooms.TabPages.Remove(this.tabPageShowRoom);
            this.tabControlFloors.TabPages.Remove(this.tabPageShowAFloor);
            this.tabControlRooms.TabPages.Remove(this.tabPageAddABed);
            this.tabControlRooms.TabPages.Remove(this.tabPageUpdateBed);
            FormDashboard.getAllBeds();
            FormDashboard.getAllFloors();
            FormDashboard.getAllRooms();
        }

        private void clearAddRoom()
        {
            this.textBoxNewRoomDescripton.Clear();
            this.textBoxNewRoomNumber.Clear();
            this.comboBoxNewRoom.SelectedIndex = -1;
            this.radioButtonIsNormal.Checked = true;
            this.radioButtonIsPremium.Checked = false;

        }

        private bool addRoom(int floorId, string roomNumber, string description, string type)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "INSERT INTO Room (FloorID, RoomNumber, Description, RoomType) VALUES (@floor, @number, @desc, @type);";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@floor", floorId);
                    command.Parameters.AddWithValue("@number", roomNumber);
                    command.Parameters.AddWithValue("@desc", description);
                    command.Parameters.AddWithValue("@type", type);
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

        private void buttonAddNewRoom_Click(object sender, EventArgs e)
        {
            if(this.comboBoxNewRoom.SelectedIndex == -1)
            {
                FormDashboard.showEmptyMessage();
                return;

            }
            int floorId = int.Parse(this.comboBoxNewRoom.SelectedValue.ToString());
            string roomNumber = this.textBoxNewRoomNumber.Text;
            string roomDescriptoin = this.textBoxNewRoomDescripton.Text;
            string roomType = this.radioButtonIsNormal.Checked ? "Normal" : "Premiumn";

            if(areEmpty(floorId, roomNumber, roomDescriptoin))
            {
                FormDashboard.showEmptyMessage();
                return;
            }

            if(addRoom(floorId, roomNumber, roomDescriptoin, roomType))
            {
                MessageBox.Show("Room is added successfully!", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearAddRoom();
                return;
            }
            FormDashboard.showDatabaseError("When trying to add a new Room!");


        }
      

        private bool areEmpty (int floor, string number, string desc)
        {
            return floor == -1 || number.Length == 0 || desc.Length == 0;
        }


        private void tabPageAddRoom_Enter(object sender, EventArgs e)
        {
            FormDashboard.getAllFloors();
            List<Floor> f = new List<Floor>();
            fillFloorsComboBox(this.comboBoxNewRoom, f);
            fillFloorsComboBox(this.comboBoxNewRoom, FormDashboard.floors);
        }

        private void tabPageShowAllRooms_Enter(object sender, EventArgs e)
        {
            this.tabControlRooms.TabPages.Remove(this.tabPageShowRoom);
            FormDashboard.getAllRooms();
            FormDashboard.getAllBeds();
            fillRooms(FormDashboard.rooms);
            List<Floor> f = new List<Floor>();
            fillFloorsComboBox(this.comboBoxSearchRoom, f);
            fillFloorsComboBox(this.comboBoxSearchRoom, FormDashboard.floors);
        }
        private void fillRooms(List<Room> rooms) {


            this.dataGridViewAllRooms.Rows.Clear();
            foreach (Room r in rooms)
            {
                Floor  level = FormDashboard.floors.Where(x => x.FloorID == r.FloorID).First();
                int reservedBeds = FormDashboard.beds.Where(x => x.Status == "Reserved" && x.RoomID == r.RoomID).Count();
                int availableBeds = FormDashboard.beds.Where(x => x.RoomID == r.RoomID).Count()  - reservedBeds;
                this.dataGridViewAllRooms.Rows.Add(
                    r.RoomID,
                    r.FloorID,
                    r.RoomNumber,
                    r.Description,
                    r.RoomType,
                    reservedBeds,
                    availableBeds,
                    level.FloorLevel
                    );

            }

            this.labelRoomCount.Text = rooms.Count.ToString();

        }
      

        private void comboBoxSearchRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBoxSearchRoom.SelectedIndex == -1)
            {
                fillRooms(FormDashboard.rooms);
            }
            else
            {
                FormDashboard.filteredRooms = FormDashboard.rooms.Where(x => x.FloorID == int.Parse(this.comboBoxSearchRoom.SelectedValue.ToString())).Select(x => x).ToList();
                fillRooms(FormDashboard.filteredRooms);
                this.buttonShowAllRooms.Show();
            }

            
        }

        private void buttonShowAllRooms_Click(object sender, EventArgs e)
        {
            this.comboBoxSearchRoom.SelectedIndex = -1;
            fillRooms(FormDashboard.rooms);

        }

        private bool addFloor(int level, string name, string description)
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "INSERT INTO Floor (FloorLevel, Description, FloorName) VALUES (@floor, @desc, @name);";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@floor", level);
                    command.Parameters.AddWithValue("@desc", name);
                    command.Parameters.AddWithValue("@name", description);
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

        private void buttonAddNewFloor_Click(object sender, EventArgs e)
        {
            int level = int.Parse(this.numericUpDownNewFloorLevel.Value.ToString());
            string name = this.textBoxNewFloorname.Text;
            string description = this.textBoxNewFloorDescriptoin.Text;

            if(areEmpty(level, name, description))
            {
                FormDashboard.showEmptyMessage();
                return;
            }
            if(addFloor(level, name, description))
            {
                MessageBox.Show("Floor has been added successfully!", "Add Floor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearAddFloor();
                return;

            }
            FormDashboard.showDatabaseError("When trying to add new Floor!");
            

        }
        private void clearAddFloor()
        {
            this.textBoxNewFloorDescriptoin.Clear();
            this.textBoxNewFloorname.Clear();
            this.numericUpDownNewFloorLevel.Value = 1;

        }

       

        private void tabPageAddFloor_Enter(object sender, EventArgs e)
        {
            this.clearAddFloor();
        }
        private void fillFloors(List<Floor> floors)
        {
            this.dataGridViewAllFloors.Rows.Clear();
            foreach (Floor r in floors)
            {
                int roomCounts = FormDashboard.rooms.Where(x => x.FloorID == r.FloorID).Count();
                this.dataGridViewAllFloors.Rows.Add(
                    r.FloorID,
                    r.FloorDescription,
                    r.FloorName,
                    roomCounts,
                    r.FloorLevel
                    );
                this.labelCountFloors.Text = floors.Count.ToString();
            }
        }

        private void tabPageShowAllFloors_Enter(object sender, EventArgs e)
        {
            
            clearShowAllFloors();
            FormDashboard.getAllFloors();
            fillFloors(FormDashboard.floors);
        }
        private void clearShowAllFloors()
        {
            this.tabControlFloors.TabPages.Remove(this.tabPageShowAFloor);
            this.textBoxSearchFloor.Clear();
        }

        private void textBoxSearchFloor_TextChanged(object sender, EventArgs e)
        {
            string keyWord = this.textBoxSearchFloor.Text;
            FormDashboard.filteredFloors = FormDashboard.floors.Where(x => x.FloorName.StartsWith(keyWord, StringComparison.OrdinalIgnoreCase)).Select(x => x).ToList();
            fillFloors(FormDashboard.filteredFloors);
        }

        private void tabPageRooms_Enter(object sender, EventArgs e)
        {
            this.clearRooms();
        }
        private void clearRooms()
        {
            this.clearAddRoom();
            this.clearShowAllFloors();
            this.tabControlRooms.SelectedTab = this.tabPageAddRoom;
        }
        private void clearFloors()
        {
            this.clearAddFloor();
            this.clearShowAllFloors();
            this.tabControlFloors.SelectedTab = this.tabPageAddFloor;
        }

        private void tabPageFloors_Enter(object sender, EventArgs e)
        {
            clearFloors();
        }
        public void reset()
        {
            this.clearAddABed();
            clearFloors();
            clearRooms();
            this.tabControlRooms.TabPages.Remove(this.tabPageShowRoom);
            this.tabControlOptions.SelectedTab = this.tabPageRooms;
        }

        private void dataGridViewAllFloors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.tabControlFloors.TabPages.Add(this.tabPageShowAFloor);

            DataGridViewRow row = this.dataGridViewAllFloors.Rows[e.RowIndex];
            this.numericUpDownUpdateFloorLevel.Text = row.Cells["floorsFloorLevel"].Value.ToString();
            this.textBoxUpdateFloorName.Text = row.Cells["floorsFloorName"].Value.ToString();
            this.textBoxUpdateFloorDesc.Text = row.Cells["floorsDescription"].Value.ToString();
            this.numericUpDownUpdateFloorLevel.Tag = int.Parse(row.Cells["floorsFloorID"].Value.ToString());
            this.labelRoomCounts.Text = row.Cells["ColumnRoomsCount"].Value.ToString();
            this.tabControlFloors.SelectedTab = this.tabPageShowAFloor;
        }

        private void buttonUpdateFloor_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.numericUpDownUpdateFloorLevel.Tag.ToString());
            int level = int.Parse(this.numericUpDownUpdateFloorLevel.Value.ToString());
            string name = this.textBoxUpdateFloorName.Text;
            string desc = this.textBoxUpdateFloorDesc.Text;
            if (areEmpty(level, name, desc))
            {
                FormDashboard.showEmptyMessage();
                return;
            }
            if(updateFloor(new Floor(id, level, name, desc))){
                MessageBox.Show("Floor has been updated Successfully!", "Update Floor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearUpdateFloor();
                this.tabControlFloors.SelectedTab = this.tabPageShowAllFloors;
                return;
            }
            FormDashboard.showDatabaseError("When trying to update the floor information!");

        }
        private void clearUpdateFloor()
        {
            this.textBoxUpdateFloorDesc.Clear();
            this.textBoxUpdateFloorName.Clear();
            this.numericUpDownUpdateFloorLevel.Value = 1;
        }
        private bool updateFloor(Floor floor)
        {

            try
            {

                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "UPDATE Floor SET FloorName = @name, FloorLevel = @level, Description = @desc WHERE FloorID = @id;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@name", floor.FloorName);
                    command.Parameters.AddWithValue("@level", floor.FloorLevel);
                    command.Parameters.AddWithValue("@desc", floor.FloorDescription);
                    command.Parameters.AddWithValue("@id", floor.FloorID);
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

        private void buttonDeleteFloor_Click(object sender, EventArgs e)
        {
            if(int.Parse(this.labelRoomCounts.Text) > 0)
            {
                MessageBox.Show("You must remove all rooms belong to this floor in order to delete the floor!", "Rooms Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Do you really Want to Delete this floor?\nYour action can not be undone!", "Delete Floor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.No)
                return;

            if (deleteFloor(int.Parse(this.numericUpDownUpdateFloorLevel.Tag.ToString())))
            {
                MessageBox.Show("The floor has been deleted Successfully!", "Delete Floor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tabControlFloors.SelectedTab = this.tabPageShowAllFloors;
                return;
            }
            else
            {

            }
            FormDashboard.showDatabaseError("When trying to delete a floor!");
        }
        private void fillFloorsComboBox(ComboBox cb, List<Floor> floors)
        {
            cb.ValueMember = "FloorID";
            cb.DisplayMember = "FloorLevel";
            cb.DataSource = floors;
            cb.SelectedIndex = -1;
        }
        private bool deleteFloor(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "DELETE FROM Floor WHERE FloorID = @id";
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
        private bool deleteBed(int id)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "DELETE FROM Bed WHERE BedID = @id";
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

        private void dataGridViewAllRooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormDashboard.getAllBeds();
            this.tabControlRooms.TabPages.Add(this.tabPageShowRoom);

            DataGridViewRow row = this.dataGridViewAllRooms.Rows[e.RowIndex];
            this.selecteRoomID = int.Parse(row.Cells["ColumnRoomID"].Value.ToString());
            this.selectedRoom = new Room(
                int.Parse(row.Cells["ColumnRoomID"].Value.ToString()),
                int.Parse(row.Cells["ColumnFloorID"].Value.ToString()),
                row.Cells["ColumnRoomNumber"].Value.ToString(),
                row.Cells["ColumnRoomDescriptoin"].Value.ToString(),
                row.Cells["ColumnRoomType"].Value.ToString()

                );
            this.tabControlRooms.SelectedTab = this.tabPageShowRoom;
            this.textBoxUpdateRoomNumber.Text = selectedRoom.RoomNumber;
            this.textBoxUpdateRoomNumber.Tag = row.Cells["ColumnRoomID"].Value.ToString();
            this.textBoxUpdateRoomDescription.Text = selectedRoom.Description;
            this.radioButtonUpdateIsNormal.Checked = selectedRoom.RoomType == "Normal" ? true : false;
            this.radioButtonUpdateIsPremium.Checked = !this.radioButtonUpdateIsNormal.Checked;
            Floor s = FormDashboard.floors.Where(x => x.FloorID == selectedRoom.FloorID).FirstOrDefault();
            fillFloorsComboBox(this.comboBoxUpdateRoomFloorLevel, FormDashboard.floors);
            this.comboBoxUpdateRoomFloorLevel.SelectedItem = s;
            List<Bed> roomBed = FormDashboard.beds.Where(x => x.RoomID == selecteRoomID).Select(x => x).ToList();
            fillBeds(roomBed);

        }

        private void tabPageShowRoom_Enter(object sender, EventArgs e)
        {
        }
        private void fillBeds(List<Bed> beds)
        {

            this.dataGridViewRoomBeds.Rows.Clear();
            foreach (Bed b in beds)
            {
                this.dataGridViewRoomBeds.Rows.Add(
                    b.BedID,
                    b.RoomID,
                    b.BedLabel,
                    b.Status,
                    b.Price
                    );

            }
            int all = beds.Count;
            int available = beds.Where(x => x.Status == "Available").Count();
            this.labelAllBeds.Text = all.ToString();
            this.labelAvailableBeds.Text = available.ToString();
            this.labelReservedBeds.Text = (all - available).ToString();
        }

        private void buttonUpdateRoom_Click(object sender, EventArgs e)
        {
            int floorID = int.Parse(this.comboBoxUpdateRoomFloorLevel.SelectedValue.ToString());
            string roomNumber = this.textBoxUpdateRoomNumber.Text;
            string description = this.textBoxUpdateRoomDescription.Text;
            string roomType = this.radioButtonUpdateIsNormal.Checked ? "Normal" : "Premium";
            if (areEmpty(floorID, roomNumber, description))
            {
                FormDashboard.showEmptyMessage();
                return;
            }
            if (updateRoom(
                new Room(
                     int.Parse(this.textBoxUpdateRoomNumber.Tag.ToString()),
                    floorID,
                    roomNumber,
                    description,
                    roomType
                    )))
            {
                MessageBox.Show("The Room info has been updated Successfully!", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tabControlRooms.SelectedTab = this.tabPageShowAllRooms;
                this.tabControlRooms.TabPages.Remove(this.tabPageShowRoom);
                return;

            }

            FormDashboard.showDatabaseError("When trying to Update the room Information!");

        }
        

        private bool updateRoom(Room room)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "UPDATE Room SET FloorID = @fID, RoomNumber = @number, Description = @desc, RoomType = @type WHERE RoomID = @id;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@fID", room.FloorID);
                    command.Parameters.AddWithValue("@number", room.RoomNumber);
                    command.Parameters.AddWithValue("@desc", room.Description);
                    command.Parameters.AddWithValue("@type", room.RoomType);
                    command.Parameters.AddWithValue("@id", room.RoomID);
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

        private void buttonAddBed_Click(object sender, EventArgs e)
        {
            if(this.dataGridViewRoomBeds.Rows.Count >= 2)
            {
                MessageBox.Show("The room have the full capacity of beds!", "Room Is Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.labelRoomNumber.Text = selectedRoom.RoomNumber;
            this.tabControlRooms.TabPages.Add(this.tabPageAddABed);
            this.tabControlRooms.SelectedTab = this.tabPageAddABed;


        }
        private void clearAddABed()
        {
            this.numericUpDownNewBedPrice.Value = 0;
            this.radioButtonNewLabelLeft.Checked = true;
            this.radioButtonNewLabelRight.Checked = false;
        }

        private void tabPageAddABed_Enter(object sender, EventArgs e)
        {
            clearAddABed();

        }
        private bool addABed(int roomID, double price, char label)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "INSERT INTO Bed (RoomID, BedLabel, Status, Price) VALUES (@roomId, @label, @status, @price);";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@roomId", roomID);
                    command.Parameters.AddWithValue("@label", label);
                    command.Parameters.AddWithValue("@status", "Available");
                    command.Parameters.AddWithValue("@price", price);
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

        private void buttonRemoveARoom_Click(object sender, EventArgs e)
        {
            if(this.dataGridViewRoomBeds.Rows.Count > 0)
            {
                MessageBox.Show("You can't delete this Room!\nPlease make sure to delete all related beds first!",
                    "Can't Delet Room",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (deleteARoom(this.selecteRoomID))
            {
                MessageBox.Show("Room has been deleted successfully!",
                    "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tabControlRooms.SelectedTab = this.tabPageShowAllRooms;
                this.tabControlRooms.TabPages.Remove(this.tabPageShowRoom);
                return;
            }
            FormDashboard.showDatabaseError("When trying to delete a room!");
        }
        private bool deleteARoom(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "DELETE FROM Room WHERE RoomID = @id";
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

        private void buttonAddNewBed_Click(object sender, EventArgs e)
        {
            if(this.numericUpDownNewBedPrice.Value == 0)
            {
                FormDashboard.showEmptyMessage();
                return;
            }

            if (this.addABed(selecteRoomID,
                double.Parse(this.numericUpDownNewBedPrice.Value.ToString()),
                this.radioButtonNewLabelLeft.Checked ? 'L' : 'R'))
            {
                MessageBox.Show("Bed has been added successfully!", "Add Bed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tabControlRooms.SelectedTab = this.tabPageShowRoom;
                FormDashboard.getAllBeds();
                List<Bed> roomBed = FormDashboard.beds.Where(x => x.RoomID == selecteRoomID).Select(x => x).ToList();
                fillBeds(roomBed);
                return;
            }
            FormDashboard.showDatabaseError("When ttrying to add a new Bed!");

        }

        private void tabPageShowAllRooms_Leave(object sender, EventArgs e)
        {
            FormDashboard.getAllBeds();
        }

        private void tabPageAddABed_Leave(object sender, EventArgs e)
        {
            this.tabControlRooms.TabPages.Remove(this.tabPageAddABed);
        }

        private void dataGridViewRoomBeds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.tabControlRooms.TabPages.Add(this.tabPageUpdateBed);

            DataGridViewRow row = this.dataGridViewRoomBeds.Rows[e.RowIndex];
            this.numericUpDownUpdateBedPrice.Value = (decimal)double.Parse(row.Cells["ColumnPrice"].Value.ToString());
            this.radioButtonUpdateR.Checked = row.Cells["ColumnBedLabel"].Value.ToString() == "R" ? true : false;
            this.radioButtonUpdateL.Checked = !this.radioButtonUpdateR.Checked;
            this.labelUpdateRoomNumber.Text = row.Cells["cRoomID"].Value.ToString();
            this.labelUpdateRoomNumber.Tag = row.Cells["ColumnBedID"].Value.ToString();
            this.tabControlRooms.SelectedTab = this.tabPageUpdateBed;
        }

        private void tabPageUpdateBed_Leave(object sender, EventArgs e)
        {
            this.tabControlRooms.TabPages.Remove(this.tabPageUpdateBed);
        }

        private void buttonUpdateBed_Click(object sender, EventArgs e)
        {
            if(this.numericUpDownUpdateBedPrice.Value == 0)
            {
                FormDashboard.showEmptyMessage();
                return;
            }
            if(updateBed(
                int.Parse(this.labelUpdateRoomNumber.Tag.ToString()),
                double.Parse(this.numericUpDownUpdateBedPrice.Value.ToString()),
                this.radioButtonUpdateL.Checked ? 'L' : 'R'
            )){
                MessageBox.Show("Bed has been updated successfully!",
                    "Update Bed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tabControlRooms.SelectedTab = this.tabPageShowRoom;
                FormDashboard.getAllBeds();
                List<Bed> roomBed = FormDashboard.beds.Where(x => x.RoomID == selecteRoomID).Select(x => x).ToList();
                fillBeds(roomBed);
                return;
            }
            FormDashboard.showDatabaseError("When trying to update Bed information!");

        }

        private bool updateBed(int bedID, double price, char label)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "UPDATE Bed SET BedLabel = @label, Price = @price WHERE BedID = @id;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@id", bedID);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@label", label);
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

        private void buttonDeleteBed_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.labelUpdateRoomNumber.Tag.ToString());
            string status = FormDashboard.beds.Where(x => x.BedID == id).Select(x => x.Status).FirstOrDefault();
            if(status == "Reserved")
            {
                MessageBox.Show("Can not delete this Bed, since it is already reserved!",
                    "Reserved Bed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you really want to remove this Bed?\n Your Action can not be undone!",
                "Delete Bed",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            if (deleteBed(id))
            {
                MessageBox.Show("Bed has been deleted successfully!", "Delete Bed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tabControlRooms.SelectedTab = this.tabPageShowRoom;
                FormDashboard.getAllBeds();
                List<Bed> roomBed = FormDashboard.beds.Where(x => x.RoomID == selecteRoomID).Select(x => x).ToList();
                fillBeds(roomBed);
                return;
            }
            FormDashboard.showDatabaseError("When trying to delete a Bed!");
        }
    }
}
