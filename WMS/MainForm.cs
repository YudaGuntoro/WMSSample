using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS.PanelUC;
using WMS.Singletone;
using WMS.User_Control;

namespace WMS
{
    public partial class MainForm : Form
    {
        static MainForm mainForm;
        public static MainForm instance
        {
            get
            {
                if (mainForm == null)
                {
                    mainForm = new MainForm();
                }
                return mainForm;
            }
        }

        public Panel mainPanel
        {
            get { return Main_Panel; }
            set { Main_Panel = value; }
        }
        public MainForm()
        {
            InitializeComponent();
            mainForm = this;
        }

        private void BtnSystemOverview_Click(object sender, EventArgs e)
        {
            if (!MainForm.instance.mainPanel.Controls.ContainsKey("UC_Main"));
            {
                UC_Main f = new UC_Main();
                f.Dock = DockStyle.Fill;
                MainForm.instance.mainPanel.Controls.Add(f);
            }
            MainForm.instance.mainPanel.Controls["UC_Main"].BringToFront();
            LblTittle.Text = "System Overview";
        }

       
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (!MainForm.instance.mainPanel.Controls.ContainsKey("UC_GenerateQR")) ;
            {
                UC_GenerateQR f = new UC_GenerateQR();
                f.Dock = DockStyle.Fill;
                MainForm.instance.mainPanel.Controls.Add(f);
            }
            MainForm.instance.mainPanel.Controls["UC_GenerateQR"].BringToFront();
            LblTittle.Text = "Generate QR";
        }

        private void BtnStockIn_Click(object sender, EventArgs e)
        {
            if (!MainForm.instance.mainPanel.Controls.ContainsKey("UC_StockIn")) ;
            {
                UC_StockIn f = new UC_StockIn();
                f.Dock = DockStyle.Fill;
                MainForm.instance.mainPanel.Controls.Add(f);
            }
            MainForm.instance.mainPanel.Controls["UC_StockIn"].BringToFront();
            LblTittle.Text = "Stock In";
        }

        private void BtnStockOut_Click(object sender, EventArgs e)
        {
            if (!MainForm.instance.mainPanel.Controls.ContainsKey("UC_StockOut")) ;
            {
                UC_StockOut f = new UC_StockOut();
                f.Dock = DockStyle.Fill;
                MainForm.instance.mainPanel.Controls.Add(f);
            }
            MainForm.instance.mainPanel.Controls["UC_StockOut"].BringToFront();
            LblTittle.Text = "Stock Out";
        }

        private void BtnBalance_Click(object sender, EventArgs e)
        {
            if (!MainForm.instance.mainPanel.Controls.ContainsKey("UC_Main")) ;
            {
                UC_Balance f = new UC_Balance();
                f.Dock = DockStyle.Fill;
                MainForm.instance.mainPanel.Controls.Add(f);
            }
            MainForm.instance.mainPanel.Controls["UC_Balance"].BringToFront();
            LblTittle.Text = "Balance";
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            if (!MainForm.instance.mainPanel.Controls.ContainsKey("UC_User")) ;
            {
                UC_User f = new UC_User();
                f.Dock = DockStyle.Fill;
                MainForm.instance.mainPanel.Controls.Add(f);
            }
            MainForm.instance.mainPanel.Controls["UC_User"].BringToFront();
            LblTittle.Text = "User";
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRackLocation_Click(object sender, EventArgs e)
        {
            if (!MainForm.instance.mainPanel.Controls.ContainsKey("UC_RackLocation")) ;
            {
                UC_RackLocation f = new UC_RackLocation();
                f.Dock = DockStyle.Fill;
                MainForm.instance.mainPanel.Controls.Add(f);
            }
            MainForm.instance.mainPanel.Controls["UC_RackLocation"].BringToFront();
            LblTittle.Text = "Rack Location";
        }

        private void BtnLogHistory_Click(object sender, EventArgs e)
        {
            if (!MainForm.instance.mainPanel.Controls.ContainsKey("UC_LogHistory")) ;
            {
                UC_LogHistory f = new UC_LogHistory();
                f.Dock = DockStyle.Fill;
                MainForm.instance.mainPanel.Controls.Add(f);
            }
            MainForm.instance.mainPanel.Controls["UC_LogHistory"].BringToFront();
            LblTittle.Text = "LogHistory";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            var configFile = new Config();
            string filepath = Application.StartupPath + "\\Settings.ini";
            string fileName = "Settings.ini";
            if (!File.Exists(filepath))
            {
                configFile = new Config(fileName);
                if (!configFile.KeyExists("Server", "Connections"))
                {
                    configFile.Write("Server", "127.0.0.1", "Connections");
                    configFile.Write("Port", "3306", "Connections");
                    configFile.Write("UserID", "root", "Connections");
                    configFile.Write("Password", "root", "Connections");
                    configFile.Write("Db", "stocksystem", "Connections");
                }
            }
            else
            {

            }
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {

        }

        private void BtnMasterPart_Click(object sender, EventArgs e)
        {
            if (!MainForm.instance.mainPanel.Controls.ContainsKey("UC_Product")) ;
            {
                UC_Product f = new UC_Product();
                f.Dock = DockStyle.Fill;
                MainForm.instance.mainPanel.Controls.Add(f);
            }
            MainForm.instance.mainPanel.Controls["UC_Product"].BringToFront();
            LblTittle.Text = "Product";
        }

        private void BtnMasterCustomer_Click(object sender, EventArgs e)
        {
            if (!MainForm.instance.mainPanel.Controls.ContainsKey("UC_MasterCustomer")) ;
            {
                UC_MasterCustomer f = new UC_MasterCustomer();
                f.Dock = DockStyle.Fill;
                MainForm.instance.mainPanel.Controls.Add(f);
            }
            MainForm.instance.mainPanel.Controls["UC_MasterCustomer"].BringToFront();
            LblTittle.Text = "Customer";
        }
    }
}
