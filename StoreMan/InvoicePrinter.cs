using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class InvoicePrinter : Form
    {
        ReportParameterCollection reportParameters;
        ReportDataSource dataSource;

        public InvoicePrinter(ReportParameterCollection reportParameters, ReportDataSource dataSource)
        {
            InitializeComponent();
            this.reportParameters = reportParameters;
            this.dataSource = dataSource;
        }

        private void InvoicePrinter_Load(object sender, EventArgs e)
        {
            invoiceViewer.LocalReport.SetParameters(reportParameters);
            invoiceViewer.LocalReport.DataSources.Clear();
            invoiceViewer.LocalReport.DataSources.Add(dataSource);

            invoiceViewer.RefreshReport();
        }
    }
}
