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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            this.Validate();
            this.tableBindingSource.EndEdit();
       
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            radUserFlagged.Checked = false;
        }

        private void gbUser_Enter(object sender, EventArgs e)
        {
            cboUserType.Items.Add("Student");
            cboUserType.Items.Add("Employee");
            if (radUserFlagged.Checked)
            {
                Screening.IsAccessible = false;
            }
        }
    }
}
