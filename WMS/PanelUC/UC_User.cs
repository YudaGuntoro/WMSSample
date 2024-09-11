using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS.Entity;
using WMS.Singletone;

namespace WMS.User_Control
{
    public partial class UC_User : UserControl
    {
        public UC_User()
        {
            InitializeComponent();
        }
        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var UserId = TBxUserId.Text;
                var Name = TBxName.Text;
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = @"INSERT INTO user(UserId, UserName)values(@UserId, @UserName)";
                    var rowsAffected = await connection.ExecuteAsync(sql, new
                    {
                        UserId = Convert.ToInt32(TBxUserId.Text),
                        UserName = TBxName.Text
                    }) ;

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Succes Add.", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnRefresh_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Data not inserted.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {

                    var sql = "DELETE FROM User WHERE Id = @_CurrentId";
                    var result = await connection.ExecuteAsync(sql, new { _CurrentId });

                    if (result > 0)
                    {
                        MessageBox.Show("User deleted successfully.");
                        BtnRefresh_Click(sender,e);
                    }
                    else
                    {
                        MessageBox.Show("No user was deleted.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {

                    var sql = "SELECT * FROM User";
                    var result = await connection.QueryAsync<User>(sql);

                    if (result != null)
                    {
                        Grid_User.DataSource = result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int _CurrentId;
        private void Grid_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Grid_User.Rows[e.RowIndex];
                var Id = row.Cells["Id"].Value.ToString();
                _CurrentId = Convert.ToInt32(Id);
            }
        }
    }
}
