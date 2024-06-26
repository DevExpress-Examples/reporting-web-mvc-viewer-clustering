<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604151/20.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T528588)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Global.asax.cs](./CS/DevExpressWebFarmsWebGardenReporting/Global.asax.cs) (VB: [Global.asax.vb](./VB/DevExpressWebFarmsWebGardenReporting/Global.asax.vb))
* [CustomCachedReportSourceWebResolver.cs](./CS/DevExpressWebFarmsWebGardenReporting/CustomCachedReportSourceWebResolver.cs) (VB: [CustomCachedReportSourceWebResolver.vb](./VB/DevExpressWebFarmsWebGardenReporting/CustomCachedReportSourceWebResolver.vb))
<!-- default file list end -->

# How to Use Reporting Controls in a Clustered Web Environment (Web Farms or Web Garden).

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
 

Refer to the following help topics for more information:

* [Microsoft Azure Reporting](https://docs.devexpress.com/XtraReports/10769/)
* [Web Farms and Web Garden Support](https://docs.devexpress.com/XtraReports/5199/)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-mvc-viewer-clustering&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-mvc-viewer-clustering&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
