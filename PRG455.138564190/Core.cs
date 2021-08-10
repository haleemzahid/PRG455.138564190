using PRG455._138564190.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG455._138564190
{
    public static class Core
    {
        public static User user = new User();
        internal static void GetUserFromDataGridRow(DataGridViewSelectedRowCollection selectedRow)
        {
            User _user = new User();

            foreach (DataGridViewRow item in selectedRow)
            { 

            _user.UserId = Convert.ToInt32(item.Cells[0].Value);
            _user.UserName = item.Cells[1].Value.ToString();
            _user.UserType = item.Cells[2].Value.ToString();
            _user.UserFlagged = Convert.ToBoolean(item.Cells[3].Value);
             user=_user;
            }
           
            
        }
       
    }
}
