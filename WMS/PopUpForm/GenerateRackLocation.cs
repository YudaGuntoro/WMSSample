using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS.PrintFile;

namespace WMS.PopUpForm
{
    public partial class GenerateRackLocation : MetroFramework.Forms.MetroForm
    {
        public string RackLocation;
        public GenerateRackLocation()
        {
            InitializeComponent();
        }
        private void GenerateRackLocation_Load(object sender, EventArgs e)
        {
            LblRackLocation.Text = RackLocation;
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ReportPrintTool printTool = new ReportPrintTool(new RackFile(RackLocation));
            printTool.Print();
        }
    }
}
