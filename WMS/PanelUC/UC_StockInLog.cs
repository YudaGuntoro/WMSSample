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
    public partial class UC_StockInLog : UserControl
    {
        public UC_StockInLog()
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
                        var _sql = "SELECT stockin.Id,stockin.StockInShift,user.UserName,stockin.StockInDate FROM stockin LEFT JOIN user ON stockin.StockInUserId = User.Id where stockin.GenerateId = @GenerateId";
                        var _result = await connection.QueryAsync<StockInLog>(_sql, new { GenerateId });

                        if (_result != null)
                        {
                            GridStockIn.DataSource = _result;
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
