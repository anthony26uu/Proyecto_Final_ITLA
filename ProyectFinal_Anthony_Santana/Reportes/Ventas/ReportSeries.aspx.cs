using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectFinal_Anthony_Santana.Reportes.Ventas
{
    public partial class ReportSeries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            this.ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            this.ReportViewer1.Reset();


            this.ReportViewer1.LocalReport.ReportPath = @"C:\Proyectos ITLA\ProyectFinal_Anthony_Santana\ProyectFinal_Anthony_Santana\Reportes\SeriesReport.rdlc";
            this.ReportViewer1.LocalReport.DataSources.Clear();



            this.ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetSeries", BLL.SeriesBLL.Listar()));

            this.ReportViewer1.LocalReport.Refresh();

        }
    }
}