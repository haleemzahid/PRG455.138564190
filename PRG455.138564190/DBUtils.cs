using PRG455._138564190.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG455._138564190
{
  public static  class DBUtils
    {
        static string connectionString = Properties.Settings.Default.connectionString;
        #region User
        #region Isert a new user
        /// <summary>
        /// Insert a new user into database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool InsertUser(User user)
        {
            var con = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            con.Open();
            dataAdapter.InsertCommand = new SqlCommand("insert into [user] values ('" + user.UserName + "','" + user.UserType + "','" + user.UserFlagged + "')", con);
            dataAdapter.InsertCommand.ExecuteNonQuery();
            con.Close();
            return true;
        }
        #endregion
        #region Update User
        /// <summary>
        /// Update existing user in database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool UpdateUser(User user)
        {
            var con = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            con.Open();
            dataAdapter.UpdateCommand = new SqlCommand("update [user] set UserName='" + user.UserName + "',UserType='" + user.UserType + "',UserFlagged='" + user.UserFlagged + "' where UserId=" + user.UserId, con);
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            con.Close();
            return true;
        }
        #endregion
        #region Delete User
        /// <summary>
        /// Delete the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool RemoveUser(User user)
        {
            var con = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            con.Open();
            dataAdapter.DeleteCommand = new SqlCommand("delete from [user] where UserId=" + user.UserId, con);
            dataAdapter.DeleteCommand.ExecuteNonQuery();
            con.Close();
            return true;
        }
        #endregion

        #region GetUsers
        public static List<User> GetUserList()
        {

            List<User> userList = new List<User>();

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Select * from [User]", conn);
            conn.Open();


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow item in dataTable.Rows)
            {
                userList.Add(new User { UserId = Convert.ToInt16(item["UserId"]), UserName = item["UserName"].ToString(),UserFlagged=Convert.ToBoolean(item["UserFlagged"]),UserType=item["UserType"].ToString() }) ;
            }
            return userList;
        }

        #endregion
        #endregion


        #region insert a new screening
        /// <summary>
        /// Insert a screening of a user
        /// </summary>
        /// <param name="screening"></param>
        /// <returns></returns>
        public static bool AddScreening(Screening screening)
        {

            var con = new SqlConnection(connectionString);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();




            con.Open();
            dataAdapter.InsertCommand = new SqlCommand("insert into [Screening] values ('" + screening.UserId + "','" + screening.CloseContact + "','" + screening.Travelled + "','" + screening.Symptoms + "','" + screening.Date + "')", con);
            dataAdapter.InsertCommand.ExecuteNonQuery();



            con.Close();
            return true;
        }
        #endregion


































    }
}
