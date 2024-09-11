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
using WMS.DTOs;
using WMS.Entity;
using WMS.Singletone;

namespace WMS.PanelUC
{
    public partial class UC_StockOutLog : UserControl
    {
        public UC_StockOutLog()
        {
            InitializeComponent();
        }
        private int GenerateId;
        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {

                    var LotNo = Convert.ToInt64(TBxLotNo.Text);
                    var sql = "SELECT * FROM generate WHERE LotNo = @LotNo";
                    var result = await connection.QueryFirstOrDefaultAsync<Generate>(sql, new { LotNo });
                    if (result != null)
                    {
                        GenerateId = result.id;
                        var _sql = @"SELECT stockout.Id,stockout.StockOutShift,user.UserName,stockout.StockTaking,mastercustomer.Customer ,stockout.StockOutDate FROM stockout 
                        LEFT JOIN mastercustomer ON stockout.CustomerId = mastercustomer.Id
                        LEFT JOIN user ON stockout.StockOutUserId = User.Id where stockout.GenerateId = @GenerateId";
                        var _result = await connection.QueryAsync<StockOutLog>(_sql, new { GenerateId });

                        if (_result != null)
                        {
                            GridStockOut.DataSource = _result;
                        }
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
