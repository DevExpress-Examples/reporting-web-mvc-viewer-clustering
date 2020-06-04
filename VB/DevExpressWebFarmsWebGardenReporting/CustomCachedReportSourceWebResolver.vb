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
		Public Function TryGetCachedReportSourceWeb(ByVal reportName As String, <System.Runtime.InteropServices.Out()> ByRef cachedReportSourceWeb As CachedReportSourceWeb) As Boolean Implements ICachedReportSourceWebResolver.TryGetCachedReportSourceWeb
			Dim report = reportResolver.Resolve(reportName)
			If report IsNot Nothing Then
				cachedReportSourceWeb = New CachedReportSourceWeb(report)
				Return True
			End If
			cachedReportSourceWeb = Nothing
			Return False
		End Function
	End Class
End Namespace