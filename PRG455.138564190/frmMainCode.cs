using PRG455._138564190.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG455._138564190
{
    public partial class frmMainCode : Form
    {
        User user = new User();
        public bool IsUpdate = false;
        public frmMainCode()
        {
            InitializeComponent();
            GetUserType();
            FetchDataFromDB();
            dataGridView2.DataSource = Core.FetchReports();
        }
        #region User
        /// <summary>
        /// refresh data from database
        /// </summary>
        private void FetchDataFromDB()
        {
            try
            {

            var userlist = DBUtils.GetUserList();
            dataGridView1.DataSource = userlist;
            cboUsers.DataSource = userlist.Where(x => x.UserFlagged == false).ToList();
            }
            catch(Exception ex) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'screeningDataSet1.Table' table. You can move, or remove it, as needed.

        }

        private void cbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try { 
            if (IsUpdate)
            {
                if (!GetDataFromUI())
                    return;
                if (DBUtils.UpdateUser(user))
                {


                    MessageBox.Show("User Updated...");
                }
                IsUpdate = false;

            }
            else
            {

                user = new User();
                if (!GetDataFromUI())
                    return;
                if (DBUtils.InsertUser(user))
                    MessageBox.Show("User Added...");
            }
            NullData();
            FetchDataFromDB();

            }
            catch (Exception ex) { }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try { 
            if (user.UserId > 0)
            {

                user.UserFlagged = false;
                DBUtils.UpdateUser(user);
                FetchDataFromDB();
            }
            }
            catch (Exception ex) { }
        }
        private void gbUser_Enter(object sender, EventArgs e)
        {


        }
        public void GetUserType()
        {
            cboUserType.Items.Add("Student");
            cboUserType.Items.Add("Employee");

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            
            Core.GetUserFromDataGridRow(dataGridView1.SelectedRows);
            user = Core.user;
            }
            catch (Exception ex) { }
        }
        /// <summary>
        /// when you will click on edit it will populate selected user data to ui
        /// </summary>
        private void PopulateDataToUI()
        {


            txtUserName.Text = user.UserName;
            cboUserType.SelectedItem = user.UserType;


        }
       /// <summary>
       /// This will get data from UI for adding and updating
       /// </summary>
       /// <returns></returns>
        private bool GetDataFromUI()
        {
            try { 
            if (cboUserType.SelectedItem == null || txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Please do not leave fields empty");
                return false;
            }


            user.UserName = txtUserName.Text;
            user.UserType = cboUserType.SelectedItem.ToString();
            }
            catch (Exception ex) { }
            return true;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (user != null)
                {
                    IsUpdate = true;
                    PopulateDataToUI();
                    FetchDataFromDB();
                    return;
                }
            }
            catch (Exception ex) { }
        }
        private void btnRemove_Click(object sender, EventArgs e)
    {

        try
        {


            if (user.UserId > 0)
                DBUtils.RemoveUser(user);
            FetchDataFromDB();
        }
        catch (Exception ex) { } }  
        public void NullData()
        {
            IsUpdate = false;
            txtUserName.Text = null;
            cboUserType.SelectedItem = null;
            user = null;
            Core.user = null;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            NullData();
        }
        #endregion





        




        #region Screening
        private void btnScreeningSave_Click(object sender, EventArgs e)
        {
            try { 
            if (cboUsers.SelectedItem == null)
            {
                MessageBox.Show("Please select a user first");
                return;

            }

            Screening screening = GetScreeningDataFromUI();
            if (DBUtils.AddScreening(screening))
                MessageBox.Show("User screening is completed...");
            FetchDataFromDB();
            dataGridView1.DataSource = Core.FetchReports();
            }
            catch (Exception ex) { }

        }
        private Screening GetScreeningDataFromUI()
        {
            Screening screening = new Screening();
            try { 
            if (radCloseContactYes.Checked)
            {
                screening.CloseContact = true;
            }
            else
            {
                screening.CloseContact = false;
            }
            if (radSymptomsYes.Checked)
            {
                screening.Symptoms = true;
            }
            else
            {
                screening.Symptoms = false;
            }
            if (radTravelledYes.Checked)
            {
                screening.Travelled = true;
            }
            else
            {
                screening.Travelled = false;
            }
            var userr = (cboUsers.SelectedItem as User);
            if (radFlagUser.Checked)
            {
                userr.UserFlagged = true;
                DBUtils.UpdateUser(userr);
            }
            screening.UserId = userr.UserId;
            screening.Date = dtDate.Value;
        }
            catch(Exception ex)
            { 
            }
            return screening;
            }
    #endregion

    #region report
    private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Core.FetchReports().Where(x => x.Date.Date >= dtFrom.Value.Date && x.Date.Date <= dtTo.Value.Date).ToList();
            dataGridView2.Columns["Date"].Visible = false;
        }

        private void btnSearchByPassFail_Click(object sender, EventArgs e)
        {

            dataGridView2.DataSource = Core.FetchReports().Where(x => x.UserFlagged == radPass.Checked).ToList();
            dataGridView2.Columns["Date"].Visible = false;
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Core.FetchReports().Where(x => x.UserName.ToLower().Contains(txtxSearchUserName.Text)).ToList();
            dataGridView2.Columns["Date"].Visible = false;
        }

        private void btnresetfilter_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Core.FetchReports();
        }
        #endregion
    }
}
