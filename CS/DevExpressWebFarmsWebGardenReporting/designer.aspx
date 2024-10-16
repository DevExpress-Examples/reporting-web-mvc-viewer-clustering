﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="designer.aspx.cs" Inherits="DevExpressWebFarmsWebGardenReporting.designer" %>

<%@ Register Assembly="DevExpress.XtraReports.v22.2.Web.WebForms, Version=22.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report Designer</title>
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
            <dx:ASPxReportDesigner ID="ASPxReportDesigner1" runat="server" Width="100%" Height="100%">
            </dx:ASPxReportDesigner>
        </div>
    </form>
</body>
</html>
