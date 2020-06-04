Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.SessionState
Imports DevExpress.XtraReports.Web.WebDocumentViewer

Namespace DevExpressWebFarmsWebGardenReporting
	Public Class [Global]
		Inherits System.Web.HttpApplication

		Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
			DefaultWebDocumentViewerContainer.UseFileExportedDocumentStorage(Server.MapPath("~/CustomSharedViewerStorage/ExportedDocuments"), StorageSynchronizationMode.InterProcess)
			DefaultWebDocumentViewerContainer.UseFileDocumentStorage(Server.MapPath("~/CustomSharedViewerStorage/Documents"), StorageSynchronizationMode.InterProcess)
            DefaultWebDocumentViewerContainer.UseFileReportStorage(Server.MapPath("~/CustomSharedViewerStorage/Reports"), StorageSynchronizationMode.InterProcess)
            DefaultWebDocumentViewerContainer.UseCachedReportSourceBuilder()
            DefaultWebDocumentViewerContainer.Register(Of ICachedReportSourceWebResolver, CustomCachedReportSourceWebResolver)()
			DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(New ReportStorageWebExtension1(Server.MapPath("~/CustomSharedDesignerStorage")))
			Dim storageCleanerSettings = New StorageCleanerSettings(TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(2), TimeSpan.FromMinutes(20), TimeSpan.FromMinutes(20), TimeSpan.FromMinutes(20))
			DefaultWebDocumentViewerContainer.RegisterSingleton(Of StorageCleanerSettings)(storageCleanerSettings)
			Dim cacheCleanerSettings = New CacheCleanerSettings(TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(60), TimeSpan.FromSeconds(60))
			DefaultWebDocumentViewerContainer.RegisterSingleton(Of CacheCleanerSettings)(cacheCleanerSettings)
			DevExpress.XtraReports.Web.ASPxReportDesigner.StaticInitialize()
		End Sub

		Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
	End Class
End Namespace