Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace DevExpressWebGardenReporting

    Public Partial Class designer
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxReportDesigner1.OpenReport("Invoice")
        End Sub
    End Class
End Namespace
