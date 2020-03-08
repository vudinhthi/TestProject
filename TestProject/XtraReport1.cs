using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;

namespace TestProject
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
            CreateReport();
        }
        public static XtraReport CreateReport()
        {

            // Create an XtraReport instance
            XtraReport report = new XtraReport()
            {
                Name = "SimpleStaticReport",
                DisplayName = "Simple Static Report",
                PaperKind = PaperKind.Letter,
                Margins = new Margins(100, 100, 100, 100)
            };

            // Create a Detail band for the report
            DetailBand detailBand = new DetailBand()
            {
                HeightF = 25
            };

            // Add the created Detail band to the report
            report.Bands.Add(detailBand);

            // Create an XRLabel control for the report
            XRLabel helloWordLabel = new XRLabel()
            {
                Text = "Hello, World abc!",
                Font = new Font("Tahoma", 20f, FontStyle.Bold),
                BoundsF = new RectangleF(0, 0, 250, 50),
            };

            // Add the created XRLabel to the Detail band
            detailBand.Controls.Add(helloWordLabel);

            // Return the report with a band and a label on it
            return report;
        }
    }
}
