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
    public partial class UserControlBills : UserControl
    {
        private List<BillInfo> billInfos;
        private List<BillInfo> filteredInfos;
        dynamic tagData;
        public UserControlBills()
        {
            InitializeComponent();
            this.tabControlOptions.TabPages.Remove(this.tabPagePay);
            billInfos = new List<BillInfo>();
            filteredInfos = new List<BillInfo>();

            getAllBillInfos();
            this.textBoxSearchKeyWord.Clear();
            filteredInfos = billInfos.Where(x => x.IsPayed == false).Select(x => x).ToList();
            fillBills(filteredInfos);
        }

        private void fillBills(List<BillInfo> l)
        {
            this.dataGridViewBills.Rows.Clear();

            foreach (var item in l)
            {
                this.dataGridViewBills.Rows.Add(
                    item.BillID,
                    item.RentID,
                    item.FullName,
                    item.Phone,
                    item.Room,
                    item.Bed,
                    item.Type,
                    item.RoomType,
                    item.IsPayed,
                    item.BillDate.ToString("yyyy/MM/dd"),
                    item.PayedDate,
                    item.Total,
                    item.ToBePayed,
                    item.Payed,
                    ((double)item.ToBePayed - (double) item.Payed).ToString("C"),
                    item.UserName
                    );
            }

        }
        private void getAllBillInfos()
        {
            this.filteredInfos.Clear();
            this.billInfos.Clear();
            FormDashboard.getAllClients();
            FormDashboard.getAllUsers();
            FormDashboard.getAllBills();
            FormDashboard.getAllRents();
            FormDashboard.getAllRentInfos();

            var see = FormDashboard.rentInfos;
            var s = from bill in FormDashboard.bills
                    join info in FormDashboard.rentInfos
                    on bill.RentID equals info.RentID
                    select new
                    {
                        BillID = bill.BillID,
                        RentID = info.RentID,
                        FullName = info.Name,
                        Phone = info.PhoneNumber,
                        Room = info.RoomNumber,
                        Bed = info.BedNamse,
                        Type = info.Type,
                        RoomType = info.RoomType,
                        IsPayed = bill.IsPayed,
                        BillDate = bill.BillDate,
                        PayedDate = bill.PayedDate,
                        ToBePayed = bill.ToBePayed,
                        Payed = bill.Payed,
                        UserID = bill.UserID,
                        Total = bill.Total
                    };
            foreach (var r in s)
            {
             
                string userName = FormDashboard.users.Where(x => x.UserID == r.UserID).FirstOrDefault().UserName;
                billInfos.Add( 
                    new BillInfo(
                    r.BillID,
                    r.RentID,
                    r.FullName,
                    r.Phone,
                    r.Room,
                    r.Bed,
                    r.Type,
                    r.RoomType,
                    r.IsPayed,
                    r.BillDate,
                    r.PayedDate,
                    r.Total,
                    r.ToBePayed,
                    r.Payed,
                    userName
                )
                    );
            }

            
        }

        private void UserControlBills_Enter(object sender, EventArgs e)
        {
            this.tabControlOptions.SelectedIndex = 0;
            this.textBoxSearchKeyWord.Clear();
            this.radioButtonNotPayed.Checked = true;
            getAllBillInfos();
            filteredInfos = billInfos.Where(x => x.IsPayed == false).Select(x => x).ToList();
            fillBills(this.filteredInfos);
        }

        private void radioButtonNotPayed_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonNotPayed.Checked)
            {
                this.textBoxSearchKeyWord.Clear();
                filteredInfos = billInfos.Where(x => x.IsPayed == false).Select(x => x).ToList();
                fillBills(filteredInfos);
                this.buttonPay.Visible = false;


            }
        }

        private void radioButtonPayed_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonPayed.Checked)
            {
                this.textBoxSearchKeyWord.Clear();
                filteredInfos = billInfos.Where(x => x.IsPayed == true).Select(x => x).ToList();
                fillBills(filteredInfos);
                this.buttonPay.Visible = false;
                
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAll.Checked)
            {
                this.textBoxSearchKeyWord.Clear();
                fillBills(billInfos);
                this.buttonPay.Visible = false;

            }
        }

        private void textBoxSearchKeyWord_TextChanged(object sender, EventArgs e)
        {
            string keyWord = this.textBoxSearchKeyWord.Text;

            if (this.radioButtonPayed.Checked)
            {
                filteredInfos = billInfos.Where(x => x.FullName.StartsWith(keyWord, StringComparison.OrdinalIgnoreCase) && x.IsPayed == true).Select(x => x).ToList();
                fillBills(filteredInfos);

            }
            else if (this.radioButtonNotPayed.Checked)
            {
                filteredInfos = billInfos.Where(x => x.FullName.StartsWith(keyWord, StringComparison.OrdinalIgnoreCase) && x.IsPayed == false).Select(x => x).ToList();
                fillBills(filteredInfos);
            }
            else
            {
                filteredInfos = billInfos.Where(x => x.FullName.StartsWith(keyWord, StringComparison.OrdinalIgnoreCase)).Select(x => x).ToList();
                fillBills(filteredInfos);
            }
        }

        private void dataGridViewBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridViewRow row = this.dataGridViewBills.Rows[e.RowIndex];
                if (row.Cells["ColumnIsPayed"].Value.ToString() == "False")
                {
                    this.buttonPayNow.Visible = true;
                    this.buttonPayNow.Tag = new
                    {
                        BillID = int.Parse(row.Cells["ColumnBillID"].Value.ToString()),
                        RentID = int.Parse(row.Cells["ColumnRentID"].Value.ToString()),
                        Total = double.Parse(row.Cells["ColumnTotal"].Value.ToString()),
                        ToBePayed = double.Parse(row.Cells["ColumnToBePayed"].Value.ToString()),
                        Payed = double.Parse(row.Cells["ColumnPayed"].Value.ToString()),
                        FullName = row.Cells["ColumnFullName"].Value.ToString(),
                        RoomNumber = row.Cells["ColumnRoomNumber"].Value.ToString(),
                        BedLabels = row.Cells["ColumnBedLabel"].Value == null ? " " : row.Cells["ColumnBedLabel"].Value.ToString(),
                        Type = row.Cells["ColumnType"].Value.ToString(),
                        RoomType = row.Cells["ColumnRoomType"].Value.ToString(),
                        BillDate = Convert.ToDateTime(row.Cells["ColumnBillDate"].Value).ToString("yyyy/MM/dd")
                    };
                }
                else
                {
                    this.buttonPayNow.Visible = false;
                    this.buttonPayNow.Tag = null;
                }
            }
        }

        private void buttonPayNow_Click(object sender, EventArgs e)
        {
            if(this.buttonPayNow.Tag == null)
            {
                return;
            }
            this.tabControlOptions.TabPages.Add(this.tabPagePay);
            tagData = this.buttonPayNow.Tag;
            this.labelFullName.Text = tagData.FullName;
            this.labelBed.Text = tagData.BedLabels;
            this.labelRoomNumber.Text = tagData.RoomNumber;
            this.labelRoomtType.Text = tagData.RoomType;
            this.labelType.Text = tagData.Type;
            this.labelBillDate.Text = Convert.ToDateTime(tagData.BillDate).ToString("yyyy/MM/dd");
            this.textBoxTotal.Text = tagData.Total.ToString("C");
            this.textBoxToBePayed.Text = tagData.ToBePayed.ToString("C");
            this.textBoxAlreadyPayed.Text = tagData.Payed.ToString("C");
            this.textBoxRemaining.Text = ((double)tagData.ToBePayed - (double)tagData.Payed).ToString("C");
            this.tabControlOptions.SelectedTab = this.tabPagePay;
            this.textBoxPayedNow.Clear();
            this.checkBoxAsPayed.Checked = false;

        }

        private void groupBoxUpdateCurrent_Enter(object sender, EventArgs e)
        {

        }

        private void tabPagePay_Leave(object sender, EventArgs e)
        {
            this.tabControlOptions.TabPages.Remove(this.tabPagePay);
        }

        private void textBoxPayedNow_TextChanged(object sender, EventArgs e)
        {
            double newAmount = 0;
            try
            {
                newAmount = double.Parse(this.textBoxPayedNow.Text);
                this.textBoxWillRemain.Text = ((double)tagData.ToBePayed - (double)tagData.Payed -  newAmount).ToString("c");
                if(newAmount > (double)tagData.ToBePayed)
                {
                    this.textBoxPayedNow.Clear();
                    this.textBoxWillRemain.Clear();
                    return;
                }
                if (newAmount == ((double)tagData.ToBePayed - (double)tagData.Payed))
                {
                    this.checkBoxAsPayed.Checked = true;
                    this.checkBoxAsPayed.Enabled = false;
                }
                else
                {
                    this.checkBoxAsPayed.Checked = false;
                    this.checkBoxAsPayed.Enabled = true;
                }

            }
            catch
            {
                this.textBoxPayedNow.Clear();
                //MessageBox.Show("You only allowed insert numbers!", "Error",
                   // MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxPayedNow.Text))
            {
                FormDashboard.showEmptyMessage();
                return;
            }
                

            bool isPayed = this.checkBoxAsPayed.Checked;
            double newAmount = double.Parse(this.textBoxPayedNow.Text);
            int billID = (int)tagData.BillID;
            double totalNewPayed = newAmount + (double)tagData.Payed;
            
            if(!isPayed && newAmount == 0){
                FormDashboard.showEmptyMessage();
                return;
            }

            if (isPayed && newAmount < ((double)tagData.ToBePayed - (double)tagData.Payed))
            {
                DialogResult result= MessageBox.Show(
                    $"Do you really want to put this bill as payed with only" +
                    $" {newAmount.ToString("c")} out of {((double)tagData.ToBePayed).ToString("C")}?",
                    "Pay Bill",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.No)
                    return;

            }
            string payedMessage = isPayed ? "Payed" : "Unpayed";
            DialogResult r = MessageBox.Show(
                $"Do you really want to pay " +
                $"{newAmount.ToString("C")} and put the bill as {payedMessage}",
                "Pay Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Information
                );

            if (r == DialogResult.No)
                return;

            if (updateBill(billID, totalNewPayed, isPayed))
            {

                MessageBox.Show("The Bill was updated successfully!", "Pay Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getAllBillInfos();
                filteredInfos = billInfos.Where(x => x.IsPayed == false).Select(x => x).ToList();
                fillBills(this.filteredInfos);
                this.tabControlOptions.SelectedTab = this.tabPageAllBills;
                this.tabControlOptions.TabPages.Remove(this.tabPagePay);
                return;
            }

            FormDashboard.showDatabaseError("When trying to update the bill!");



        }
        private bool updateBill(int billID, double totalNewPayed, bool isPayed)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(Program.conString))
                {
                    connection.Open();
                    string sqlQuery = "UPDATE Bill SET isPayed = @is, Payed = @payed WHERE BillID = @id";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@is", isPayed);
                    command.Parameters.AddWithValue("@payed", totalNewPayed);
                    command.Parameters.AddWithValue("@id", billID);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }
    }
}
