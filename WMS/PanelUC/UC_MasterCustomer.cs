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

namespace WMS.PanelUC
{
    public partial class UC_MasterCustomer : UserControl
    {
        public UC_MasterCustomer()
        {
            InitializeComponent();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(dbConfig.MysqlConnString))
                {
                    var sql = "SELECT * FROM mastercustomer";
                    var result = await connection.QueryAsync<MasterCustomer>(sql);
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
    }
}