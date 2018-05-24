# How to use the Web Report Designer and Web Document Viewer in the Web Gardens environment


This example demonstrates how to use the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17103">End-User Report Designer</a> and <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17738">HTML5 Document Viewer</a> in the Web Gardens environment.<br><br>
<p>Take note of the following specifics related to version 17.1:</p>
<br>- Only synchronous methods of creating and exporting documents are supported (i.e., there is no instant preview and document building progress indicator).<br>- You need to use the file storage to synchronize reports, documents and exported documents.


<h3>Description</h3>

Call the following methods of the&nbsp;<strong>DefaultWebDocumentViewerContainer</strong>&nbsp;on the application start to use a file storage for reports, documents and exported documents:&nbsp;<br>-&nbsp;<strong>UseFileReportStorage</strong><br>-&nbsp;<strong>UseFileDocumentStorage</strong><br>-&nbsp;<strong>UseFileExportedDocumentStorage</strong><br><br>Pass the path to the required directory as the first method parameter and&nbsp;<strong>StorageSynchronizationMode.InterProcess</strong>&nbsp;enumeration value as the second parameter.

<br/>


