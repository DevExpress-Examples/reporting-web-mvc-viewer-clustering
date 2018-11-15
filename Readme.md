<!-- default file list -->
*Files to look at*:

* **[CustomWebDocumentViewerOperationLogger.cs](./CS/DevExpressWebGardenReporting/CustomWebDocumentViewerOperationLogger.cs) (VB: [CustomWebDocumentViewerOperationLogger.vb](./VB/DevExpressWebGardenReporting/CustomWebDocumentViewerOperationLogger.vb))**
* [Global.asax.cs](./CS/DevExpressWebGardenReporting/Global.asax.cs) (VB: [Global.asax.vb](./VB/DevExpressWebGardenReporting/Global.asax.vb))
* [ReportStorageWebExtension1.cs](./CS/DevExpressWebGardenReporting/ReportStorageWebExtension1.cs) (VB: [ReportStorageWebExtension1.vb](./VB/DevExpressWebGardenReporting/ReportStorageWebExtension1.vb))
<!-- default file list end -->
# How to use the Web Report Designer and Web Document Viewer in the Web Gardens environment


This example demonstrates how to use the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17103">End-User Report Designer</a> and <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17738">HTML5 Document Viewer</a> in the Web Gardens environment.<br><br>
<p>Take note of the following specifics related to version 17.1:</p>
<br>- Only synchronous methods of creating and exporting documents are supported (i.e., there is no instant preview and document building progress indicator).<br>- You need to use the file storage to synchronize reports, documents and exported documents.


<h3>Description</h3>

Override the <strong>BuildStarting</strong> and <strong>ExportDocumentStarting</strong> methods of the <strong>WebDocumentViewerOperationLogger</strong> descendant to provide synchronous creating and exporting of documents. <br><br>Call the following methods of the <strong>DefaultWebDocumentViewerContainer</strong> on the application start to use a file storage for reports, documents and exported documents: <br>- <strong>UseFileReportStorage</strong><br>- <strong>UseFileDocumentStorage</strong><br>- <strong>UseFileExportedDocumentStorage</strong><br><br>Pass the path to the required directory as the first method parameter and <strong>StorageSynchronizationMode.InterProcess</strong> enumeration value as the second parameter.

<br/>


