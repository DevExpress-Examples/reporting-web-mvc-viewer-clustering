using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace DevExpressWebGardenReporting {
    public class Global : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            DefaultWebDocumentViewerContainer.RegisterSingleton<WebDocumentViewerOperationLogger, CustomWebDocumentViewerOperationLogger>();
            DefaultWebDocumentViewerContainer.UseReportStorageExtensionReportResolver();
            DefaultWebDocumentViewerContainer.UseFileExportedDocumentStorage(Server.MapPath("~/App_Data/ExportedDocumentsCache"), StorageSynchronizationMode.InterProcess);
            DefaultWebDocumentViewerContainer.UseFileDocumentStorage(Server.MapPath("~/App_Data/DocumentsCache"), StorageSynchronizationMode.InterProcess);
            DefaultWebDocumentViewerContainer.UseFileReportStorage(Server.MapPath("~/App_Data/ReportsCache"), StorageSynchronizationMode.InterProcess);
            DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(new ReportStorageWebExtension1());
            var storageCleanerSettings = new StorageCleanerSettings(TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(2), TimeSpan.FromMinutes(20), TimeSpan.FromMinutes(20), TimeSpan.FromMinutes(20));
            DefaultWebDocumentViewerContainer.RegisterSingleton<StorageCleanerSettings>(storageCleanerSettings);
            var cacheCleanerSettings = new CacheCleanerSettings(TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(60), TimeSpan.FromSeconds(60));
            DefaultWebDocumentViewerContainer.RegisterSingleton<CacheCleanerSettings>(cacheCleanerSettings);
            DevExpress.XtraReports.Web.ASPxReportDesigner.StaticInitialize();
        }

        protected void Session_Start(object sender, EventArgs e) {

        }

        protected void Application_BeginRequest(object sender, EventArgs e) {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {

        }

        protected void Application_End(object sender, EventArgs e) {

        }
    }
}