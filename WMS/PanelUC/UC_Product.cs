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
    public partial class UC_Product : UserControl
    {
        public UC_Product()
        {
            InitializeComponent();
        }

        private async void DDownLocation_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = "SELECT * FROM location";
                    var result = await connection.QueryAsync<Location>(sql);

                    if (result != null)
                    {
                        DDownLocation.Items.Clear();

                        foreach (var item in result)
                        {
                            DDownLocation.Items.Add(item.RackLocation);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int LocationId;
        private async void DDownLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var RackLocation = DDownLocation.Text;
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = "SELECT * FROM location WHERE RackLocation = @RackLocation";
                    var result = await connection.QueryFirstOrDefaultAsync<Location>(sql, new { RackLocation });

                    if (result != null)
                    {
                        LocationId = result.id;
                    }
                    else
                    {
                        MessageBox.Show("Data Not Found", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = @"INSERT INTO masterpart(PartNo, PartName,LocationId)values(@PartNo, @PartName,@LocationId)";
                    var rowsAffected = await connection.ExecuteAsync(sql, new
                    {
                        PartNo = Convert.ToInt32(TBxPartNo.Text),
                        PartName = TBxPartName.Text,
                        LocationId = LocationId
                    });

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Succes Add.", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnRefresh_Click(sender, e);
                        TBxPartNo.Text = "";
                        TBxPartName.Text = "";
                        DDownLocation.Text = "";
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

 

      
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {

                    var sql = "SELECT masterpart.Id,masterpart.PartNo,masterpart.PartName,location.RackLocation FROM masterpart LEFT JOIN location ON masterpart.LocationId = location.Id";
                    var result = await connection.QueryAsync<MasterPart>(sql);

                    if (result != null)
                    {
                        Grid_Product.DataSource = result;
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
                DDownLocation_SelectedIndexChanged(sender,e);
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = "UPDATE masterpart SET PartNo = @PartNo, PartName = @PartName, LocationId = @LocationId WHERE Id = @CurrentId";

                    var rowsUpdated = await connection.ExecuteAsync(sql, new
                    {
                        CurrentId = _CurrentId,
                        PartNo = Convert.ToInt32(TBxPartNo.Text),
                        PartName = TBxPartName.Text,
                        LocationId = LocationId
                    });

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnRefresh_Click(sender, e);
                        TBxPartNo.Text = "";
                        TBxPartName.Text = "";
                        DDownLocation.Text = "";
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

                    var sql = "DELETE FROM masterpart WHERE Id = @_CurrentId";
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
        private void Grid_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Grid_Product.Rows[e.RowIndex];
                var Id = row.Cells["Id"].Value.ToString();
                _CurrentId = Convert.ToInt32(Id);
                TBxPartNo.Text = row.Cells["PartNo"].Value.ToString();
                TBxPartName.Text = row.Cells["PartName"].Value.ToString();
                DDownLocation.Text = row.Cells["Location"].Value.ToString();
            }
        }
    }
}
