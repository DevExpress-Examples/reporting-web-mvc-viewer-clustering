<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604151/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T528588)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# How to use the Web Report Designer and Web Document Viewer in the Web Gardens environment


This example demonstrates how to use the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17103">End-User Report Designer</a> and <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17738">HTML5 Document Viewer</a> in the Web Gardens environment.<br><br>
<p>Take note of the following specifics related to version 17.1:</p>
<br>- Only synchronous methods of creating and exporting documents are supported (i.e., there is no instant preview and document building progress indicator).<br>- You need to use the file storage to synchronize reports, documents and exported documents.


<h3>Description</h3>

Call the following methods of the&nbsp;<strong>DefaultWebDocumentViewerContainer</strong>&nbsp;on the application start to use a file storage for reports, documents and exported documents:&nbsp;<br>-&nbsp;<strong>UseFileReportStorage</strong><br>-&nbsp;<strong>UseFileDocumentStorage</strong><br>-&nbsp;<strong>UseFileExportedDocumentStorage</strong><br><br>Pass the path to the required directory as the first method parameter and&nbsp;<strong>StorageSynchronizationMode.InterProcess</strong>&nbsp;enumeration value as the second parameter.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-mvc-viewer-clustering&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-mvc-viewer-clustering&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
