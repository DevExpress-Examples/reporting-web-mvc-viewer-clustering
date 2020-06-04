Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports DevExpress.XtraReports.UI

Namespace DevExpressWebFarmsWebGardenReporting
	Public Class ReportStorageWebExtension1
		Inherits DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension

		Private ReadOnly workingDirectory As String
		Public Sub New(ByVal workingDirectory As String)
			Me.workingDirectory = workingDirectory
		End Sub
		Public Overrides Function IsValidUrl(ByVal url As String) As Boolean
			Return True
		End Function

		Public Overrides Function SetNewData(ByVal report As XtraReport, ByVal defaultUrl As String) As String
			Me.SetData(report, defaultUrl)
			Return defaultUrl
		End Function

		Public Overrides Function GetData(ByVal url As String) As Byte()
			If url = "Invoice" Then
				Return SerializeReport(New InvoiceReport())
			End If

			url &= If(url.EndsWith(".repx"), "", ".repx")
			Using fileStream = File.OpenRead(Path.Combine(workingDirectory, url))
				Dim report = XtraReport.FromStream(fileStream, True)
				Return SerializeReport(report)
			End Using
		End Function

		Public Overrides Function GetUrls() As Dictionary(Of String, String)
			Dim dictionary = New Dictionary(Of String, String)()
			dictionary.Add("Invoice", "Invoice Report")
			Dim files = Directory.GetFiles(workingDirectory)
			For Each item In files.Where(Function(x) x.Contains(".repx")).Select(Function(x) x.Split("\"c).Last())
				dictionary.Add(item, item)
			Next item
			Return dictionary
		End Function

		Public Overrides Sub SetData(ByVal report As DevExpress.XtraReports.UI.XtraReport, ByVal url As String)
			url &= If(url.EndsWith(".repx"), "", ".repx")
			Using fileStream = File.OpenWrite(Path.Combine(workingDirectory, url))
				report.SaveLayoutToXml(fileStream)
			End Using
		End Sub

		Public Overrides Function CanSetData(ByVal url As String) As Boolean
			Return True
		End Function

		Private Function SerializeReport(ByVal report As XtraReport) As Byte()
			Using stream As New MemoryStream()
				report.SaveLayoutToXml(stream)
				stream.Position = 0
				Return stream.GetBuffer()
			End Using
		End Function
	End Class
End Namespace
