using eventManagement.Model;
using eventManagement.Model.Requests;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagement.WinUI.Reports
{
    public partial class frmEventsReport : Form
    {
        private readonly APIService _apiEvents = new APIService("events");

        public frmEventsReport()
        {
            InitializeComponent();
        }

        private void frmEventsReport_Load(object sender, EventArgs e)
        {

        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

            var search = new EventSearchRequest()
            {
                DateFrom = dateFrom.Value,
                DateTo = dateTo.Value,
            };

            var result = await _apiEvents.Get<List<Event>>(search);

            ReportDataSource dataSource = new ReportDataSource("DataSet2", result);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DateFrom", dateFrom.Value.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DateTo", dateTo.Value.ToString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
