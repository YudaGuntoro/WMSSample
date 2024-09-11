using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS.PanelUC.ExtendedForm
{
    public partial class FormSetPrinter : Form
    {
        private PrintDocument printDoc = new PrintDocument();
        public FormSetPrinter()
        {
            InitializeComponent();
        }

        private void PopulateInstalledPrintersCombo()
        {
            comboInstalledPrinters.Items.Clear();
            // Add list of installed printers found to the combo box.
            // The pkInstalledPrinters string will be used to provide the display string.
            int i;
            string pkInstalledPrinters;

            if (PrinterSettings.InstalledPrinters.Count <= 0)
            {
                MessageBox.Show("Printer not found!");
                return;
            }

            for (i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                comboInstalledPrinters.Items.Add(pkInstalledPrinters);
                if (printDoc.PrinterSettings.IsDefaultPrinter)
                {
                    comboInstalledPrinters.Text = printDoc.PrinterSettings.PrinterName;
                }
            }
        }

        public static class PrinterClass
        {
            [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool SetDefaultPrinter(string Printer);
        }
        private void BtnSetDefaultPrinter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboInstalledPrinters.Text))
            {
                PrinterClass.SetDefaultPrinter(comboInstalledPrinters.Text);
                MessageBox.Show("Default Printer : " + comboInstalledPrinters.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Please Select Printer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnRefreshPrinter_Click(object sender, EventArgs e)
        {
            PopulateInstalledPrintersCombo();
        }
    }
}
