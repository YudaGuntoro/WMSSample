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
    public partial class UC_Balance : UserControl
    {
        public UC_Balance()
        {
            InitializeComponent();
        }

        private async void DDownMaterialType_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {

                    var sql = "SELECT * FROM stufftype";
                    var result = await connection.QueryAsync<StuffType>(sql);

                    if (result != null)
                    {
                        DDownMaterialType.Items.Clear();

                        foreach (var item in result)
                        {
                            DDownMaterialType.Items.Add(item.Type);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int StuffTypeId;
        private async void DDownMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var Type = DDownMaterialType.Text;
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = "SELECT * FROM  stufftype WHERE Type = @Type";
                    var result = await connection.QueryFirstOrDefaultAsync<MasterPart>(sql, new { Type });

                    if (result != null)
                    {
                        StuffTypeId = result.id;
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

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var LotNo = TBxLotNo.Text;
                var PartNo = TBxPartNo.Text;
                if (CBxPartNo.Checked == true)
                {
                    if ((CBxFifo.Checked == true) && (CBxLifo.Checked == true))
                    {
                        MessageBox.Show("Please Select One or None");
                    }
                    else if ((CBxFifo.Checked == false) && (CBxLifo.Checked == false))
                    {
                        using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                        {
                            var sql = @"SELECT StockInDate,generate.InitialQuantity,generate.RemainsQuantity,generate.LotNo,masterpart.PartNo,masterPart.PartName,location.RackLocation FROM stockin 
                                LEFT JOIN generate ON stockin.GenerateId = generate.Id
                                LEFT JOIN masterpart ON generate.MasterPartId = masterpart.Id
                                LEFT JOIN location ON masterpart.LocationId = location.Id
                                WHERE generate.StuffTypeId = @StuffTypeId AND masterpart.PartNo = @PartNo";
                            var result = await connection.QueryAsync<Balance>(sql, new { StuffTypeId, PartNo });
                            if (result != null)
                            {
                                GridBalance.DataSource = result;
                            }
                            else
                            {
                                MessageBox.Show("Data Not Found", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else if (CBxFifo.Checked == true)
                    {
                        using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                        {
                            var sql = @"SELECT StockInDate,generate.InitialQuantity,generate.RemainsQuantity,generate.LotNo,masterpart.PartNo,masterPart.PartName,location.RackLocation FROM stockin 
                                LEFT JOIN generate ON stockin.GenerateId = generate.Id
                                LEFT JOIN masterpart ON generate.MasterPartId = masterpart.Id
                                LEFT JOIN location ON masterpart.LocationId = location.Id
                                WHERE generate.StuffTypeId = @StuffTypeId AND masterpart.PartNo = @PartNo
                                ORDER BY stockin.StockInDate ASC";
                            var result = await connection.QueryAsync<Balance>(sql, new { StuffTypeId, PartNo });
                            if (result != null)
                            {
                                GridBalance.DataSource = result;
                            }
                            else
                            {
                                MessageBox.Show("Data Not Found", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else if (CBxLifo.Checked == true)
                    {
                        using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                        {
                            var sql = @"SELECT StockInDate,generate.InitialQuantity,generate.RemainsQuantity,generate.LotNo,masterpart.PartNo,masterPart.PartName,location.RackLocation FROM stockin 
                                LEFT JOIN generate ON stockin.GenerateId = generate.Id
                                LEFT JOIN masterpart ON generate.MasterPartId = masterpart.Id
                                LEFT JOIN location ON masterpart.LocationId = location.Id
                                WHERE generate.StuffTypeId = @StuffTypeId AND masterpart.PartNo = @PartNo
                                ORDER BY stockin.StockInDate DESC";
                            var result = await connection.QueryAsync<Balance>(sql, new { StuffTypeId, PartNo });
                            if (result != null)
                            {
                                GridBalance.DataSource = result;
                            }
                            else
                            {
                                MessageBox.Show("Data Not Found", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }

                else if (CBxLotNo.Checked == true)
                {
                    if ((CBxFifo.Checked == true) && (CBxLifo.Checked == true))
                    {
                        MessageBox.Show("Please Select One or None");
                    }
                    else if ((CBxFifo.Checked == false) && (CBxLifo.Checked == false))
                    {
                        using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                        {
                            var sql = @"SELECT StockInDate,generate.InitialQuantity,generate.RemainsQuantity,generate.LotNo,masterpart.PartNo,masterPart.PartName,location.RackLocation FROM stockin 
                                LEFT JOIN generate ON stockin.GenerateId = generate.Id
                                LEFT JOIN masterpart ON generate.MasterPartId = masterpart.Id
                                LEFT JOIN location ON masterpart.LocationId = location.Id
                                WHERE generate.StuffTypeId = @StuffTypeId AND generate.LotNo = @LotNo";
                            var result = await connection.QueryAsync<Balance>(sql, new { StuffTypeId, LotNo });
                            if (result != null)
                            {
                                GridBalance.DataSource = result;
                            }
                            else
                            {
                                MessageBox.Show("Data Not Found", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else if (CBxFifo.Checked == true)
                    {
                        using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                        {
                            var sql = @"SELECT StockInDate,generate.InitialQuantity,generate.RemainsQuantity,generate.LotNo,masterpart.PartNo,masterPart.PartName,location.RackLocation FROM stockin 
                                LEFT JOIN generate ON stockin.GenerateId = generate.Id
                                LEFT JOIN masterpart ON generate.MasterPartId = masterpart.Id
                                LEFT JOIN location ON masterpart.LocationId = location.Id
                                WHERE generate.StuffTypeId = @StuffTypeId AND generate.LotNo = @LotNo
                                ORDER BY stockin.StockInDate ASC";
                            var result = await connection.QueryAsync<Balance>(sql, new { StuffTypeId, LotNo });
                            if (result != null)
                            {
                                GridBalance.DataSource = result;
                            }
                            else
                            {
                                MessageBox.Show("Data Not Found", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else if (CBxLifo.Checked == true)
                    {
                        using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                        {
                            var sql = @"SELECT StockInDate,generate.InitialQuantity,generate.RemainsQuantity,generate.LotNo,masterpart.PartNo,masterPart.PartName,location.RackLocation FROM stockin 
                                LEFT JOIN generate ON stockin.GenerateId = generate.Id
                                LEFT JOIN masterpart ON generate.MasterPartId = masterpart.Id
                                LEFT JOIN location ON masterpart.LocationId = location.Id
                                WHERE generate.StuffTypeId = @StuffTypeId AND generate.LotNo = @LotNo
                                ORDER BY stockin.StockInDate DESC";
                            var result = await connection.QueryAsync<Balance>(sql, new { StuffTypeId, LotNo });
                            if (result != null)
                            {
                                GridBalance.DataSource = result;
                            }
                            else
                            {
                                MessageBox.Show("Data Not Found", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
   
        }

        private void CBxPartNo_CheckedChanged(object sender, EventArgs e)
        {
            if (CBxPartNo.Checked == true)
            {
                TBxPartNo.Enabled = true;
                TBxLotNo.Enabled = false;
                CBxLotNo.Checked = false;
            }
        }

        private void CBxLotNo_CheckedChanged(object sender, EventArgs e)
        {
            if (CBxLotNo.Checked == true)
            {
                TBxPartNo.Enabled = false;
                TBxLotNo.Enabled = true;
                CBxPartNo.Checked = false;
            }
        }

        private void CBxLifo_CheckedChanged(object sender, EventArgs e)
        {
            if (CBxLifo.Checked == true)
            {
                CBxLifo.Checked = true;
                CBxFifo.Checked = false;
            }
        }

        private void CBxFifo_CheckedChanged(object sender, EventArgs e)
        {
            if (CBxFifo.Checked == true)
            {
                CBxLifo.Checked = false;
                CBxFifo.Checked = true;
            }
        }
    }
}
