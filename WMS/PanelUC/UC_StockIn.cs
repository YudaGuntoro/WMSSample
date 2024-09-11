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
    public partial class UC_StockIn : UserControl
    {
        public UC_StockIn()
        {
            InitializeComponent();
        }

        private async void DDownUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {

                    var sql = "SELECT * FROM user";
                    var result = await connection.QueryAsync<User>(sql);

                    if (result != null)
                    {
                        DDownUser.Items.Clear();

                        foreach (var item in result)
                        {
                            DDownUser.Items.Add(item.UserName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int UserId;
        private async void DDownUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var UserName = DDownUser.Text;
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = "SELECT * FROM user WHERE UserName = @UserName";
                    var result = await connection.QueryFirstOrDefaultAsync<User>(sql, new { UserName });

                    if (result != null)
                    {
                        UserId = result.id;
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

        private async void DDownLocation_Click(object sender, EventArgs e)
        {

        }

        private async void DDownLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int GenerateId;
        //Check If Lot Already Generate, it can stock in
        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("OK");
                var LotNo = TBxScannedQR.Text;
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = "SELECT * FROM generate WHERE LotNo = @LotNo";
                    var result = await connection.QueryFirstOrDefaultAsync<Generate>(sql, new { LotNo });

                    if (result != null)
                    {
                        GenerateId = result.id;
                        var _sql = @"INSERT INTO stockin(StockInDate, StockInShift, StockInUserId, GenerateId)values(@StockInDate, @StockInShift, @StockInUserId, @GenerateId)";
                        var rowsAffected = await connection.ExecuteAsync(_sql, new
                        {
                            StockInDate = DateTime.Now,
                            StockInShift = 1,
                            StockInUserId = UserId,
                            GenerateId = GenerateId
                        });

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            TBxScannedQR.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Data not inserted.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data Not Found / QR Not Generate Yet", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show();
        }

        private async void TBxScannedQR_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    var LotNo = TBxScannedQR.Text;
                    try
                    {
                        using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                        {
                            await connection.OpenAsync();

                            var sql = "SELECT * FROM generate WHERE LotNo = @LotNo";
                            var result = await connection.QueryFirstOrDefaultAsync<Generate>(sql, new { LotNo });

                            if (result != null)
                            {
                                GenerateId = result.id;

                                var _sql = @"INSERT INTO stockin(StockInDate, StockInShift, StockInUserId, GenerateId)
                                     VALUES(@StockInDate, @StockInShift, @StockInUserId, @GenerateId)";
                                var rowsAffected = await connection.ExecuteAsync(_sql, new
                                {
                                    StockInDate = DateTime.Now,
                                    StockInShift = 1, // Adjust as needed
                                    StockInUserId = UserId,
                                    GenerateId = GenerateId
                                });

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    TBxScannedQR.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Data not inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Data Not Found / QR Not Generated Yet", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBxPartNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show($"Unexpected Error: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }
    }
}
