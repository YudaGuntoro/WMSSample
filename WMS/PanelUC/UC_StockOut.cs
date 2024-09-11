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
    public partial class UC_StockOut : UserControl
    {
        public UC_StockOut()
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
        private async void DDownPICName_SelectedIndexChanged(object sender, EventArgs e)
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
        private int GenerateId;
        private async void TBx_ScanQR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    var LotNo = TBx_ScanQR.Text;
                    using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                    {
                        var sql = "SELECT * FROM generate WHERE LotNo = @LotNo";
                        var result = await connection.QueryFirstOrDefaultAsync<Generate>(sql, new { LotNo });

                       if (result != null)
                        {
                           GenerateId = result.id;
                           TBxScannedRemains.Text = result.RemainsQuantity.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Data Not Found", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TBxScannedRemains.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void TBxStockTaking_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
               if (string.IsNullOrEmpty(TBxStockTaking.Text))
               {
                   
               }
               else
               {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        var data1 = Convert.ToInt32(TBxScannedRemains.Text);
                        var data2 = Convert.ToInt32(TBxStockTaking.Text);
                        var result = data1 - data2;
                        TBxTakingRemains.Text = result.ToString();
                    }
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var LotNo = TBx_ScanQR.Text;
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = @"INSERT INTO stockout(StockOutDate,StockOutShift,StockOutUserId,StockTaking,GenerateId,CustomerId)values(@StockOutDate,@StockOutShift,@StockOutUserId,@StockTaking,@GenerateId,@CustomerId)";

                    var rowsAffected = await connection.ExecuteAsync(sql, new
                    {
                        StockOutDate = DatePicker.Value.ToString("dd-MM-yyyy HH:mm:ss"),
                        StockOutShift = Convert.ToInt32(DDownShift.Text),
                        StockOutUserId = UserId,
                        StockTaking = Convert.ToInt32(TBxStockTaking.Text),
                        GenerateId = GenerateId,
                        CustomerId = CustomerId 
                    });

                    if (rowsAffected > 0)
                    {
                        var _sql = @"UPDATE generate SET RemainsQuantity = @RemainsQuantity WHERE Id = @GeneratedId";

                        var rowsUpdated = await connection.ExecuteAsync(_sql, new
                        {
                            GeneratedId = GenerateId,
                            RemainsQuantity = Convert.ToInt32(TBxTakingRemains.Text)
                        });

                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("Stock Out Success.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DDownShift.Text = "";
                            DDownUser.Text = "";
                            TBx_ScanQR.Text = "";
                            TBxStockTaking.Text = "";
                            TBxScannedRemains.Text = "";
                            TBxTakingRemains.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Data not updated.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
        private async void DDown_Customer_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = "SELECT * FROM mastercustomer";
                    var result = await connection.QueryAsync<MasterCustomer>(sql);
                    if (result != null)
                    {
                        DDown_Customer.Items.Clear();
                        foreach (var item in result)
                        {
                            DDown_Customer.Items.Add(item.Customer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int CustomerId;
        private async void DDown_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var Customer = DDown_Customer.Text;
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = "SELECT * FROM mastercustomer WHERE customer = @Customer";
                    var result = await connection.QueryFirstOrDefaultAsync<MasterCustomer>(sql, new { Customer });

                    if (result != null)
                    {
                        CustomerId = result.Id;
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
    }
}
