﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewer.aspx.cs" Inherits="DevExpressWebGardenReporting.viewer" %>

<%@ Register Assembly="DevExpress.XtraReports.v17.1.Web, Version=17.1.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Document Viewer</title>
    <style type="text/css">
        body {
            margin: 0;
        }

        .fullscreen {
            position: absolute;
            top: 0;
            bottom: 0;
            right: 0;
            left: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="fullscreen">
            <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server" Width="100%" Height="100%">
            </dx:ASPxWebDocumentViewer>
        </div>
    </form>
</body>
</html>
