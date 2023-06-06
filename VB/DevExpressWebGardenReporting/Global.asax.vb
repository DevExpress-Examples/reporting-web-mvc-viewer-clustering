Imports System
Imports System.Web
Imports DevExpress.XtraReports.Web.WebDocumentViewer

Namespace DevExpressWebGardenReporting

    Public Class [Global]
        Inherits HttpApplication

        Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
            Call DefaultWebDocumentViewerContainer.RegisterSingleton(Of WebDocumentViewerOperationLogger, CustomWebDocumentViewerOperationLogger)()
            Call DefaultWebDocumentViewerContainer.UseReportStorageExtensionReportResolver()
            DefaultWebDocumentViewerContainer.UseFileExportedDocumentStorage(Server.MapPath("~/App_Data/ExportedDocumentsCache"), StorageSynchronizationMode.InterProcess)
            DefaultWebDocumentViewerContainer.UseFileDocumentStorage(Server.MapPath("~/App_Data/DocumentsCache"), StorageSynchronizationMode.InterProcess)
            DefaultWebDocumentViewerContainer.UseFileReportStorage(Server.MapPath("~/App_Data/ReportsCache"), StorageSynchronizationMode.InterProcess)
            DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(New ReportStorageWebExtension1())
            Dim storageCleanerSettings = New StorageCleanerSettings(TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(2), TimeSpan.FromMinutes(20), TimeSpan.FromMinutes(20), TimeSpan.FromMinutes(20))
            DefaultWebDocumentViewerContainer.RegisterSingleton(storageCleanerSettings)
            Dim cacheCleanerSettings = New CacheCleanerSettings(TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(60), TimeSpan.FromSeconds(60))
            DefaultWebDocumentViewerContainer.RegisterSingleton(cacheCleanerSettings)
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
