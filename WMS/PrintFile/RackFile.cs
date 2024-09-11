using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace WMS.PrintFile
{
    public partial class RackFile : DevExpress.XtraReports.UI.XtraReport
    {
        public RackFile(string RackLocation)
        {
            InitializeComponent();
            LblRackLocation.Text = RackLocation;
            xrBarCode1.AutoModule = true;
            QRCodeGenerator symb = new QRCodeGenerator();
            xrBarCode1.Symbology = symb;

            // Adjust the QR barcode's specific properties.
            symb.CompactionMode = QRCodeCompactionMode.AlphaNumeric;
            symb.ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H;
            symb.Version = QRCodeVersion.AutoVersion;
            xrBarCode1.Text = RackLocation;
            xrBarCode1.ShowText = false;
      
        }
    }
}
