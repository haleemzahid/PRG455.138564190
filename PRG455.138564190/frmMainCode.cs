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
        }

        private void FetchDataFromDB()
        {
            dataGridView1.DataSource = DBUtils.GetUserDataTable();
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
            if(IsUpdate)
            {
                GetDataFromUI();
                if(DBUtils.UpdateUser(user))
                {

              
                MessageBox.Show("User Updated...");
                }
                IsUpdate = false;
           
            }
            else
            {

            user = new User();
                GetDataFromUI();
            if (DBUtils.InsertUser(user))
                MessageBox.Show("User Added...");
            }
            NullData();
                FetchDataFromDB();

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            user.UserFlagged= false;
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
           
             Core.GetUserFromDataGridRow(dataGridView1.SelectedRows);
            user = Core.user;
        }

        private void PopulateDataToUI()
        {
            
                
            txtUserName.Text = user.UserName;
            cboUserType.SelectedItem = user.UserType;
          
            
        }
        private void GetDataFromUI()
        {


             user.UserName= txtUserName.Text;
            user.UserType = cboUserType.SelectedItem.ToString();
          

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                IsUpdate = true;
                PopulateDataToUI();
                FetchDataFromDB();
                return;
            }
            


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            

            if(user.UserId>0)
            DBUtils.RemoveUser(user);
            FetchDataFromDB();
        }

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
    }
}
