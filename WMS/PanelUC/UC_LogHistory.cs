using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS.PanelUC
{
    public partial class UC_LogHistory : UserControl
    {
        public UC_LogHistory()
        {
            InitializeComponent();
        }

        private void BtnStockInLog_Click(object sender, EventArgs e)
        {
            if (!MainForm.instance.mainPanel.Controls.ContainsKey("UC_StockInLog")) ;
            {
                UC_StockInLog f = new UC_StockInLog();
                f.Dock = DockStyle.Fill;
                MainForm.instance.mainPanel.Controls.Add(f);
            }
            MainForm.instance.mainPanel.Controls["UC_StockInLog"].BringToFront();
        }

        private void BtnStockOutLog_Click(object sender, EventArgs e)
        {
            if (!MainForm.instance.mainPanel.Controls.ContainsKey("UC_StockOutLog")) ;
            {
                UC_StockOutLog f = new UC_StockOutLog();
                f.Dock = DockStyle.Fill;
                MainForm.instance.mainPanel.Controls.Add(f);
            }
            MainForm.instance.mainPanel.Controls["UC_StockOutLog"].BringToFront();
        }
    }
}
