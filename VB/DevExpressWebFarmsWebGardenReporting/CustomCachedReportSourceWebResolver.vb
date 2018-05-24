Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.XtraReports.Web
Imports DevExpress.XtraReports.Web.WebDocumentViewer

Namespace DevExpressWebFarmsWebGardenReporting
    Public Class CustomCachedReportSourceWebResolver
        Implements ICachedReportSourceWebResolver

        Private reportResolver As IWebDocumentViewerReportResolver
        Public Sub New(ByVal reportResolver As IWebDocumentViewerReportResolver)
            Me.reportResolver = reportResolver
        End Sub

        Private Function ICachedReportSourceWebResolver_TryGetCachedReportSourceWeb(reportName As String, ByRef CachedReportSourceWeb As CachedReportSourceWeb) As Boolean Implements ICachedReportSourceWebResolver.TryGetCachedReportSourceWeb
            Dim report = reportResolver.Resolve(reportName)
            If report IsNot Nothing Then
                CachedReportSourceWeb = New CachedReportSourceWeb(report)
                Return True
            End If
            CachedReportSourceWeb = Nothing
            Return False
        End Function
    End Class
End Namespace