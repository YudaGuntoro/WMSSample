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
using WMS.PopUpForm;
using WMS.Singletone;

namespace WMS.User_Control
{
    public partial class UC_RackLocation : UserControl
    {
        public UC_RackLocation()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = @"INSERT INTO location(RackLocation, Description)values(@RackLocation, @Description)";
                    var rowsAffected = await connection.ExecuteAsync(sql, new
                    {
                       RackLocation = TBxRackLocation.Text,
                       Description = TBxDescription.Text
                    });

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Succes Add.", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnRefresh_Click(sender, e);
                        TBxRackLocation.Text = "";
                        TBxDescription.Text = "";
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

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = "UPDATE location SET RackLocation = @RackLocation, Description = @Description WHERE Id = @CurrentId";

                    var rowsUpdated = await connection.ExecuteAsync(sql, new
                    {
                        CurrentId = _CurrentId,
                        RackLocation = TBxRackLocation.Text,
                        Description = TBxDescription.Text,
                        
                    });

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnRefresh_Click(sender, e);
                        TBxRackLocation.Text = "";
                        TBxDescription.Text = "";
                                            }
                    else
                    {
                        MessageBox.Show("No rows updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var sql = "DELETE FROM location WHERE Id = @_CurrentId";
                    var result = await connection.ExecuteAsync(sql, new { _CurrentId });
                    if (result > 0)
                    {
                        MessageBox.Show("User deleted successfully.");
                        BtnRefresh_Click(sender, e);
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
        private int _CurrentId;
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = "SELECT * FROM location;";
                    var result = await connection.QueryAsync<Location>(sql);
                    if (result != null)
                    {
                        Grid_Location.DataSource = result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grid_Location_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Grid_Location.Rows[e.RowIndex];
                var Id = row.Cells["Id"].Value.ToString();
                _CurrentId = Convert.ToInt32(Id);
                TBxRackLocation.Text = row.Cells["RackLocation"].Value?.ToString();
                TBxDescription.Text = row.Cells["Description"].Value?.ToString();
               
            }
        }

        private void Grid_Location_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Grid_Location.Rows[e.RowIndex];
                var cellValue = row.Cells["RackLocation"].Value?.ToString();

                if (!string.IsNullOrEmpty(cellValue))
                {
                    var f = new GenerateRackLocation
                    {
                        RackLocation = cellValue
                    };
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Rack location is empty or null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
