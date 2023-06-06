# Reporting for Web (ASP.NET MVC) - Reporting Controls in a Clustered Web Environment (Web Farms or Web Garden).

This example demonstrates how to use the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17103">End-User Report Designer</a> and <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17738">Web Document Viewer</a> in a clustered environment.

The following methods are called on application start:
* [DefaultWebDocumentViewerContainer.UseFileReportStorage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.UseFileReportStorage.overloads)
* [DefaultWebDocumentViewerContainer.UseFileDocumentStorage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.UseFileDocumentStorage.overloads)
* [DefaultWebDocumentViewerContainer.UseFileExportedDocumentStorage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.UseFileExportedDocumentStorage.overloads)

The first method parameter is the path to the shared folder. The second method parameter is the [StorageSynchronizationMode.InterProcess](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.StorageSynchronizationMode) enumeration value.

The methods instructs reporting components to use a file storage for reports, documents and exported documents.

The [DefaultWebDocumentViewerContainer.UseCachedReportSourceBuilder](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.UseCachedReportSourceBuilder) method forces the Document Viewer and Report Designer's Preview to use the [CachedReportSourceWeb](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.CachedReportSourceWeb) instance as the report source. 

> The application uses the following folders to store reports, documents and exported documents: 
>
> * CustomSharedViewerStorage
> * CustomSharedDesignerStorage
> 
> These folders should be shared between application instances in a clustered environment and accessible to all web farm's nodes.
 
## Files to Review

* [Global.asax.cs](./CS/DevExpressWebFarmsWebGardenReporting/Global.asax.cs) (VB: [Global.asax.vb](./VB/DevExpressWebFarmsWebGardenReporting/Global.asax.vb))
* [CustomCachedReportSourceWebResolver.cs](./CS/DevExpressWebFarmsWebGardenReporting/CustomCachedReportSourceWebResolver.cs) (VB: [CustomCachedReportSourceWebResolver.vb](./VB/DevExpressWebFarmsWebGardenReporting/CustomCachedReportSourceWebResolver.vb))

## Documentation

* [Microsoft Azure Reporting](https://docs.devexpress.com/XtraReports/10769/)
* [Web Farms and Web Garden Support](https://docs.devexpress.com/XtraReports/5199/)

## More Examples

- [ASP.NET Core Reporting - Best Practices](https://github.com/DevExpress-Examples/AspNetCore.Reporting.BestPractices)
