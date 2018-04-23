using System;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.ClientControls;
using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace DevExpressWebGardenReporting {
    public class CustomWebDocumentViewerOperationLogger : WebDocumentViewerOperationLogger {
        public override Action BuildStarting(string reportId, string reportUrl, XtraReport report, ReportBuildProperties buildProperties) {
            report.CreateDocument();
            return base.BuildStarting(reportId, reportUrl, report, buildProperties);
        }
        public override ExportedDocument ExportDocumentStarting(string documentId, string asyncExportOperationId, string format, ExportOptions options, PrintingSystemBase printingSystem, Func<ExportedDocument> doExportSynchronously) {
            return doExportSynchronously();
        }
    }
}