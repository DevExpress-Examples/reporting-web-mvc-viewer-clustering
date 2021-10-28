Imports System
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web.ClientControls
Imports DevExpress.XtraReports.Web.WebDocumentViewer

Namespace DevExpressWebGardenReporting

    Public Class CustomWebDocumentViewerOperationLogger
        Inherits WebDocumentViewerOperationLogger

        Public Overrides Function BuildStarting(ByVal reportId As String, ByVal reportUrl As String, ByVal report As XtraReport, ByVal buildProperties As ReportBuildProperties) As Action
            report.CreateDocument()
            Return MyBase.BuildStarting(reportId, reportUrl, report, buildProperties)
        End Function

        Public Overrides Function ExportDocumentStarting(ByVal documentId As String, ByVal asyncExportOperationId As String, ByVal format As String, ByVal options As ExportOptions, ByVal printingSystem As PrintingSystemBase, ByVal doExportSynchronously As Func(Of ExportedDocument)) As ExportedDocument
            Return doExportSynchronously()
        End Function
    End Class
End Namespace
