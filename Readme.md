# hopw to Use Reporting Controls in a Clustered Web Environment (Web Farms or Web Garden).


This example demonstrates how to use the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17103">End-User Report Designer</a> and <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17738">Web Document Viewer</a> in a clustered environment.



Call the following methods >DefaultWebDocumentViewerContainer</strong>&nbsp;on the application start to use a file storage for reports, documents and exported documents:
* [DefaultWebDocumentViewerContainer.UseFileReportStorage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.UseFileReportStorage.overloads)
* [DefaultWebDocumentViewerContainer.UseFileDocumentStorage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.UseFileDocumentStorage.overloads)

The first method parameter is the path to the shared folder. The second method parameter is the [StorageSynchronizationMode.InterProcess](xref:https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.StorageSynchronizationMode) enumeration value.

