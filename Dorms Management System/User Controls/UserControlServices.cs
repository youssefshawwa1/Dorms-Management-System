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
    public partial class UserControlServices : UserControl
    {
        public UserControlServices()
        {
            InitializeComponent();
            this.tabControlBedFeatures.TabPages.Remove(this.tabPageUpdateBedFeature);
            this.tabControlRoomServices.TabPages.Remove(this.tabPageUpdateRoomService);
        }
        private void clearAddService()
        {
            this.textBoxNewServiceName.Clear();
            this.textBoxNewServicePrice.Clear();
            this.textBoxNewServcieDescription.Clear();
        }
        private void clearShowAllServices()
        {
            this.textBoxSearchServices.Clear();
            this.dataGridViewServices.Rows.Clear();
        }
        private void clearUpdateService()
        {
            this.textBoxUpdateServiceName.Clear();
            this.textBoxUpdateServiceDescription.Clear();
            this.textBoxUpdateServicePrice.Clear();
        }
        
        private void resetServices()
        {
            this.tabControlRoomServices.SelectedTab = this.tabPageAddRoomService;
        }

        private void tabPageRoomServices_Enter(object sender, EventArgs e)
        {
            this.resetServices();
            
        }
        public void reset()
        {
            this.resetServices();
            this.resetFeatures();
            this.tabControlOptions.SelectedTab = this.tabPageRoomServices;
        }
        private void clearAddFeature()
        {
            this.textBoxNewFeatureName.Clear();
            this.textBoxNewFeaturePrice.Clear();
            this.textBoxNewFeatureDescription.Clear();
        }
        private void clearShowAllFeatures()
        {
            this.dataGridViewAllFeatures.Rows.Clear();
            this.textBoxSearchFeature.Clear();
        }
        private void clearUpdateFeature()
        {
            this.textBoxUpdateFeatureDescription.Clear();
            this.textBoxUpdateFeatureName.Clear();
            this.textBoxUpdateFeaturePrice.Clear();
        }
        private void resetFeatures()
        {
            this.tabControlBedFeatures.SelectedTab = this.tabPageAddBedFeature;
        }
        private void tabControlBedFeatures_Enter(object sender, EventArgs e)
        {
            this.resetFeatures();
        }

        private void tabPageAddRoomService_Enter(object sender, EventArgs e)
        {
            this.clearAddService();
        }

        private void tabPageShowAllRoomServices_Enter(object sender, EventArgs e)
        {
            this.clearShowAllServices();
            FormDashboard.getAllServices();
            this.fillAllServices(FormDashboard.services);
        }

        private void tabPageAddBedFeature_Enter(object sender, EventArgs e)
        {
            this.clearAddFeature();
        }

        private void tabPageShowAllBedFeatures_Enter(object sender, EventArgs e)
        {
            this.clearShowAllFeatures();
            FormDashboard.getAllFeatures();
            this.fillAllFeatures(FormDashboard.features);
        }

        private void tabPageUpdateBedFeature_Leave(object sender, EventArgs e)
        {
            this.clearUpdateFeature();
            this.tabControlBedFeatures.TabPages.Remove(this.tabPageUpdateBedFeature);
        }

        private void tabPageUpdateRoomService_Leave(object sender, EventArgs e)
        {
            this.clearUpdateService();
            this.tabControlRoomServices.TabPages.Remove(this.tabPageUpdateRoomService); 
        }
        private bool areEmpty(string name, double price, string description)
        {

            return name.Length == 0 || price == 0 || description.Length == 0;

        }
        private void buttonAddService_Click(object sender, EventArgs e)
        {
            string name = this.textBoxNewServiceName.Text;

            double price = 0;
            try {

                price = double.Parse(this.textBoxNewServicePrice.Text);
            }
            catch
            {
                MessageBox.Show("Price must be a number!", "Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string description = this.textBoxNewServcieDescription.Text;

            if(this.areEmpty(name, price, description))
            {
                FormDashboard.showEmptyMessage();
                return;
            }

            if(this.addService(name, price, description))
            {
                MessageBox.Show("Service added Successfully!", "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearAddService();
                return;
            }
            this.showDatabaseError("When tryingt to add a new service");

        }
        private void showDatabaseError(string reason)
        {
            MessageBox.Show("An error occured " + reason, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private bool addService(string name, double price, string description)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "INSERT INTO RoomService (ServiceName, Price, Description) VALUES (@name, @price, @description);";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@description", description);
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
        private bool addFeature(string name, double price, string description)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "INSERT INTO BedFeature (FeatureName, Price, Description) VALUES (@name, @price, @description);";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@description", description);
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

        private void buttonAddNewFeature_Click(object sender, EventArgs e)
        {
            string name = this.textBoxNewFeatureName.Text;
            double price = 0;
            try
            {
                price = double.Parse(this.textBoxNewFeaturePrice.Text);
            }
            catch
            {
                MessageBox.Show("Price must be a number!", "Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string description = this.textBoxNewFeatureDescription.Text;
            if (this.areEmpty(name, price, description))
            {
                FormDashboard.showEmptyMessage();
                return;
            }

            if (this.addFeature(name, price, description))
            {
                MessageBox.Show("Feature added Successfully!", "Add Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearAddFeature();
                return;
            }
            this.showDatabaseError("When tryingt to add a new Feature");

        }

      
        private void fillAllServices(List<RoomService> services)
        {

            this.dataGridViewServices.Rows.Clear();
            foreach (RoomService u in services)
            {
                this.dataGridViewServices.Rows.Add(
                    u.ServicID,
                    u.ServiceName,
                    u.Price,
                    u.Description
                    ) ;
            }
        }
        private void fillAllFeatures(List<BedFeature> features)
        {

            this.dataGridViewAllFeatures.Rows.Clear();
            foreach (BedFeature u in features)
            {
                this.dataGridViewAllFeatures.Rows.Add(
                    u.FeatureID,
                    u.FeatureName,
                    u.Price,
                    u.Description
                    );
            }
        }

        private void textBoxSearchServices_TextChanged(object sender, EventArgs e)
        {
            string keyword = this.textBoxSearchServices.Text;
            FormDashboard.filteredServices = FormDashboard.services.Where(x => x.ServiceName.StartsWith(keyword, StringComparison.OrdinalIgnoreCase)).Select(x=>x).ToList();
            this.fillAllServices(FormDashboard.filteredServices);
        }

        private void textBoxSearchFeature_TextChanged(object sender, EventArgs e)
        {
            string keyword = this.textBoxSearchFeature.Text;
            FormDashboard.filteredFeatures = FormDashboard.features.Where(x => x.FeatureName.StartsWith(keyword, StringComparison.OrdinalIgnoreCase)).Select(x => x).ToList();
            this.fillAllFeatures(FormDashboard.filteredFeatures);
        }

        private void dataGridViewServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tabControlRoomServices.TabPages.Add(this.tabPageUpdateRoomService);
            this.tabControlRoomServices.SelectedTab = this.tabPageUpdateRoomService;
            DataGridViewRow row = this.dataGridViewServices.Rows[e.RowIndex];
            this.textBoxUpdateServiceName.Text = row.Cells["ColumnServiceName"].Value.ToString();
            this.textBoxUpdateServicePrice.Text = row.Cells["ColumnServicePrice"].Value.ToString();
            this.textBoxUpdateServiceDescription.Text = row.Cells["ColumnServiceDescription"].Value.ToString();
            this.textBoxUpdateServiceName.Tag = int.Parse(row.Cells["ColumnServiceID"].Value.ToString());
        }

        private void dataGridViewAllFeatures_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tabControlBedFeatures.TabPages.Add(this.tabPageUpdateBedFeature);
            this.tabControlBedFeatures.SelectedTab = this.tabPageUpdateBedFeature;
            DataGridViewRow row = this.dataGridViewAllFeatures.Rows[e.RowIndex];
            this.textBoxUpdateFeatureName.Text = row.Cells["ColumnFeatureName"].Value.ToString();
            this.textBoxUpdateFeaturePrice.Text = row.Cells["ColumnFeaturePrice"].Value.ToString();
            this.textBoxUpdateFeatureDescription.Text = row.Cells["ColumnFeatureDescription"].Value.ToString();
            this.textBoxUpdateFeatureName.Tag = int.Parse(row.Cells["ColumnFeatureID"].Value.ToString());
        }

        private bool updateFeature(BedFeature f)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "UPDATE BedFeature SET FeatureName = @name, Price = @price, Description = @description WHERE FeatureID = @id;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@name", f.FeatureName);
                    command.Parameters.AddWithValue("@price", f.Price);
                    command.Parameters.AddWithValue("@description", f.Description);
                    command.Parameters.AddWithValue("@id", f.FeatureID);
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
        private bool updateService(RoomService f)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "UPDATE RoomService SET ServiceName = @name, Price = @price, Description = @description WHERE ServiceID = @id;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@name", f.ServiceName);
                    command.Parameters.AddWithValue("@price", f.Price);
                    command.Parameters.AddWithValue("@description", f.Description);
                    command.Parameters.AddWithValue("@id", f.ServicID);
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

        private void buttonUpdateService_Click(object sender, EventArgs e)
        {
            string name = this.textBoxUpdateServiceName.Text;
            double price = 0;
            int id = int.Parse(this.textBoxUpdateServiceName.Tag.ToString());
            try
            {
                price = double.Parse(this.textBoxUpdateServicePrice.Text);
            }
            catch
            {
                MessageBox.Show("Price must be a number!", "Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string description = this.textBoxUpdateServiceDescription.Text;
            if (areEmpty(name, price, description))
            {
                FormDashboard.showEmptyMessage();
                return;
            }

            if (updateService(new RoomService(id, name, price, description)))
            {
                MessageBox.Show("Service is Updateed Successfully!", "Update Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.clearUpdateService();
                this.tabControlRoomServices.SelectedTab = this.tabPageShowAllRoomServices;
                return;
            }
            this.showDatabaseError("When tryingt to Updating a service");
        }

        private bool deleteService(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "DELETE FROM RoomService WHERE ServiceID = @id";
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
        private bool deleteFeature(int id)
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "DELETE FROM BedFeature WHERE FeatureID = @id";
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

        private void buttonDeleteService_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxUpdateServiceName.Tag.ToString());

            DialogResult result = MessageBox.Show("Do you really want to Delete this Service?\nYour action can not be undone!","Delete Service",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            if (this.deleteService(id))
            {
                MessageBox.Show("The Service has been deleted successfully!", "Delete Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearUpdateService();
                this.tabControlRoomServices.SelectedTab = this.tabPageShowAllRoomServices;
                return;
            }
            this.showDatabaseError("When trying to delete a room service!");
        }

        private void buttonDeleteFeature_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxUpdateFeatureName.Tag.ToString());

            DialogResult result = MessageBox.Show("Do you really want to Delete this feature?\nYour action can not be undone!", "Delete Feature",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            if (this.deleteFeature(id))
            {
                MessageBox.Show("The Feature has been deleted successfully!", "Delete Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearUpdateFeature();
                this.tabControlBedFeatures.SelectedTab = this.tabPageShowAllBedFeatures;
                return;
            }
            this.showDatabaseError("When trying to delete a bed feature!");
        }

        private void buttonUpdateFeature_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to update this Feature?", "Update Feature",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;
            try { 
            
            }
            catch
            {
                MessageBox.Show("An error has occured!\nPlease Call Assistant!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BedFeature f = new BedFeature(
                (int)this.textBoxUpdateFeatureName.Tag,
                this.textBoxUpdateFeatureName.Text,
                double.Parse(this.textBoxUpdateFeaturePrice.Text),
                this.textBoxUpdateFeatureDescription.Text
                
                );
            if (updateFeature(f))
            {
                MessageBox.Show("The Feature has been updated successfully!", "Update Feature",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tabControlBedFeatures.SelectedTab = this.tabPageShowAllBedFeatures;
                return;

            }
            FormDashboard.showDatabaseError("When trying to update the Feature!");
            return;


        }
    }
}
