using Dapper;
using DevExpress.XtraReports.UI;
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
using WMS.PanelUC.ExtendedForm;
using WMS.PrintFile;
using WMS.Singletone;

namespace WMS.User_Control
{
    public partial class UC_GenerateQR : UserControl
    {
        public UC_GenerateQR()
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
        int StuffTypeId;
        private async void DDownMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var Type = DDownMaterialType.Text;
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = "SELECT * FROM stufftype WHERE Type = @Type";
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
        int MasterPartId;
        private async void TBxPartNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    var PartNo = TBxPartNo.Text;
                    using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                    {
                        var sql = "SELECT * FROM masterpart WHERE PartNo = @PartNo";
                        var result = await connection.QueryFirstOrDefaultAsync<MasterPart>(sql, new { PartNo });

                        if (result != null)
                        {
                            MasterPartId = result.id;
                            TBxPartName.Text = result.PartName;
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
        //Cek Apakah Lot Sudah digenerate
        //Cek apakah data sudah pernah diinput
        private async void BtnQuickPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(DDownMaterialType.Text))||(string.IsNullOrEmpty(TBxQty.Text))||(string.IsNullOrEmpty(TBxPartName.Text))||(string.IsNullOrEmpty(TBxLotNo.Text)))
                {
                    MessageBox.Show("Please insert all Data (Part No Optional)");
                }
                else
                {
                    var LotNo = TBxLotNo.Text;
                    using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                    {
                        var sql = "SELECT * FROM generate WHERE LotNo = @LotNo";
                        var result = await connection.QueryFirstOrDefaultAsync<Generate>(sql, new { LotNo });

                        if (result != null)
                        {
                            MessageBox.Show("Lot Already Generated!", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            var PartNo = TBxPartNo.Text;
                            var PartName = TBxPartName.Text;
                            int Qty = Convert.ToInt32(TBxQty.Text);
                            ReportPrintTool printTool = new ReportPrintTool(new QRFile(LotNo));
                            var _sql = @"INSERT INTO generate(InitialQuantity, RemainsQuantity, LotNo, StuffTypeId,MasterPartId,CreatedDate)values(@InitialQuantity, @RemainsQuantity, @LotNo, @StuffTypeId,@MasterPartId, @CreatedDate)";
                            var rowsAffected = await connection.ExecuteAsync(_sql, new
                            {
                                InitialQuantity = Qty,
                                RemainsQuantity = Qty,
                                LotNo = LotNo,
                                MasterPartId = MasterPartId,
                                StuffTypeId = StuffTypeId,
                                CreatedDate = DateTime.Now
                            });

                            if (CBxPreview.Checked)
                            {
                                if (rowsAffected > 0)
                                {
                                    printTool.ShowPreview();
                                    MessageBox.Show("Data inserted successfully.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Data not inserted.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                if (rowsAffected > 0)
                                {
                                    printTool.Print();
                                    MessageBox.Show("Data inserted successfully.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Data not inserted.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
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

        private void BtnSettingPrinter_Click(object sender, EventArgs e)
        {
            FormSetPrinter form = new FormSetPrinter();
            form.ShowDialog();
        }
        private void BtnGenerateLot_Click(object sender, EventArgs e)
        {
            try
            {
                // Format the date and the unique number to create the lot number
                TBxLotNo.Text = DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss"); // D3 ensures it's at least 3 digits
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
