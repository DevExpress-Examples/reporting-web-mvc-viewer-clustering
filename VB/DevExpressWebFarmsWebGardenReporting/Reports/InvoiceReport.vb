Imports System
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI

Namespace DevExpressWebFarmsWebGardenReporting
	Partial Public Class InvoiceReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(InvoiceReport))
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Dim xrSummary2 As New DevExpress.XtraReports.UI.XRSummary()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim selectQuery2 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column12 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim column13 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column14 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column15 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression15 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column16 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression16 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim selectQuery3 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column17 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression17 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim column18 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression18 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column19 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression19 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column20 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression20 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column21 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression21 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column22 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression22 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column23 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression23 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column24 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression24 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column25 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression25 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column26 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression26 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column27 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression27 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column28 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression28 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column29 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression29 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column30 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression30 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim selectQuery4 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim allColumns1 As New DevExpress.DataAccess.Sql.AllColumns()
			Dim table4 As New DevExpress.DataAccess.Sql.Table()
			Dim column31 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression31 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column32 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression32 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column33 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression33 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column34 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression34 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column35 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression35 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column36 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression36 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column37 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression37 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column38 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression38 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column39 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression39 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column40 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression40 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column41 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression41 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim masterDetailInfo2 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
			Dim relationColumnInfo2 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim code128Generator1 As New DevExpress.XtraPrinting.BarCode.Code128Generator()
			Dim dynamicListLookUpSettings1 As New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.xrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
			Me.sqlDataSource2 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.barCode1 = New DevExpress.XtraReports.UI.XRBarCode()
			Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.NetPrice = New DevExpress.XtraReports.UI.CalculatedField()
			Me.SumUnitPrice = New DevExpress.XtraReports.UI.CalculatedField()
			Me.DiscountTotal = New DevExpress.XtraReports.UI.CalculatedField()
			Me.AmountPaid = New DevExpress.XtraReports.UI.CalculatedField()
			Me.paramCompany = New DevExpress.XtraReports.Parameters.Parameter()
			Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel9, Me.xrLabel8, Me.xrLabel5, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
			Me.Detail.HeightF = 183.125F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("ContactName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel9
			' 
			Me.xrLabel9.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(425.4167F, 32.99999F)
			Me.xrLabel9.Name = "xrLabel9"
			Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel9.SizeF = New System.Drawing.SizeF(216.2501F, 23F)
			Me.xrLabel9.StylePriority.UseFont = False
			Me.xrLabel9.StylePriority.UseTextAlignment = False
			Me.xrLabel9.Text = "Order Date: [OrderDate!M/d/yyyy]"
			Me.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' xrLabel8
			' 
			Me.xrLabel8.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(425.4166F, 10.00001F)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel8.SizeF = New System.Drawing.SizeF(216.2501F, 23F)
			Me.xrLabel8.StylePriority.UseFont = False
			Me.xrLabel8.StylePriority.UseTextAlignment = False
			Me.xrLabel8.Text = "Order ID: [OrderId]"
			Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' xrLabel5
			' 
			Me.xrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShipCountry]")})
			Me.xrLabel5.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 102F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(301.0417F, 23F)
			Me.xrLabel5.StylePriority.UseFont = False
			Me.xrLabel5.Text = "xrLabel5"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShipCity]")})
			Me.xrLabel4.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 79.00003F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(301.0417F, 23F)
			Me.xrLabel4.StylePriority.UseFont = False
			Me.xrLabel4.Text = "xrLabel4"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShipAddress]")})
			Me.xrLabel3.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 56.00001F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(301.0417F, 23F)
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContactName]")})
			Me.xrLabel2.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 32.99999F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(301.0417F, 23F)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]")})
			Me.xrLabel1.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(301.0417F, 23F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' TopMargin
			' 
			Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel20, Me.xrLabel19})
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel20
			' 
			Me.xrLabel20.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline)
			Me.xrLabel20.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(64)))), (CInt((CByte(128)))))
			Me.xrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(9.99999F, 54.79167F)
			Me.xrLabel20.Name = "xrLabel20"
			Me.xrLabel20.NavigateUrl = "https://documentation.devexpress.com/#XtraReports/CustomDocument117229"
			Me.xrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel20.SizeF = New System.Drawing.SizeF(630F, 23F)
			Me.xrLabel20.StylePriority.UseFont = False
			Me.xrLabel20.StylePriority.UseForeColor = False
			Me.xrLabel20.StylePriority.UseTextAlignment = False
			Me.xrLabel20.Text = "Read a step-by-step guide on creating invoices in our online documentation"
			Me.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' xrLabel19
			' 
			Me.xrLabel19.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline)
			Me.xrLabel19.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(64)))), (CInt((CByte(128)))))
			Me.xrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(9.99999F, 21.45834F)
			Me.xrLabel19.Name = "xrLabel19"
			Me.xrLabel19.NavigateUrl = "https://www.youtube.com/watch?v=oaXK-XhwF8g"
			Me.xrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel19.SizeF = New System.Drawing.SizeF(630F, 23F)
			Me.xrLabel19.StylePriority.UseFont = False
			Me.xrLabel19.StylePriority.UseForeColor = False
			Me.xrLabel19.StylePriority.UseTextAlignment = False
			Me.xrLabel19.Target = "_blank"
			Me.xrLabel19.Text = "Watch a video tutorial on creating invoices on the DevExpress YouTube channel"
			Me.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox3})
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPictureBox3
			' 
			Me.xrPictureBox3.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox3.ImageSource"))
			Me.xrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(254F, 13F)
			Me.xrPictureBox3.Name = "xrPictureBox3"
			Me.xrPictureBox3.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
			Me.xrPictureBox3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrPictureBox3.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
			Me.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.GroupHeader1, Me.GroupFooter1})
			Me.DetailReport.DataMember = "Orders.OrdersOrderDetails"
			Me.DetailReport.DataSource = Me.sqlDataSource2
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			Me.DetailReport.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail1.HeightF = 25F
			Me.Detail1.Name = "Detail1"
			' 
			' xrTable1
			' 
			Me.xrTable1.EvenStyleName = "EvenStyle"
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.OddStyleName = "OddStyle"
			Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(631.6667F, 25F)
			Me.xrTable1.StylePriority.UsePadding = False
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell11, Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 11.5R
			' 
			' xrTableCell11
			' 
			Me.xrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber([ProductID])")})
			Me.xrTableCell11.Name = "xrTableCell11"
			xrSummary1.IgnoreNullValues = True
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
			Me.xrTableCell11.Summary = xrSummary1
			Me.xrTableCell11.Weight = 0.34866643084143989R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")})
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "xrTableCell1"
			Me.xrTableCell1.Weight = 0.51362107961775716R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderDetailsProducts].[Products_ProductName]")})
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.Weight = 1.2717350033943944R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.StylePriority.UseTextAlignment = False
			Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell3.TextFormatString = "{0:$0.00}"
			Me.xrTableCell3.Weight = 0.55150349731894355R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Discount]")})
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.StylePriority.UseTextAlignment = False
			Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell4.TextFormatString = "{0:$0.00}"
			Me.xrTableCell4.Weight = 0.48767140202171211R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NetPrice]")})
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.StylePriority.UseTextAlignment = False
			Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell5.TextFormatString = "{0:$0.00}"
			Me.xrTableCell5.Weight = 0.5329990636687334R
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.GroupHeader1.HeightF = 25F
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' xrTable2
			' 
			Me.xrTable2.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(631.6667F, 25F)
			Me.xrTable2.StylePriority.UseFont = False
			Me.xrTable2.StylePriority.UsePadding = False
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell12, Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 11.5R
			' 
			' xrTableCell12
			' 
			Me.xrTableCell12.Name = "xrTableCell12"
			Me.xrTableCell12.Text = "Pos."
			Me.xrTableCell12.Weight = 0.34615376790364583R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Text = "Quantity"
			Me.xrTableCell6.Weight = 0.50991943007312723R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Text = "Product Name"
			Me.xrTableCell7.Weight = 1.2625702019729144R
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.StylePriority.UseTextAlignment = False
			Me.xrTableCell8.Text = "Unit Price"
			Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell8.Weight = 0.54752939679513135R
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.StylePriority.UseTextAlignment = False
			Me.xrTableCell9.Text = "Discount"
			Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell9.Weight = 0.48415660797933485R
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.StylePriority.UseTextAlignment = False
			Me.xrTableCell10.Text = "Net Price"
			Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell10.Weight = 0.52915769651282552R
			' 
			' GroupFooter1
			' 
			Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel16, Me.xrLabel15, Me.xrLabel14, Me.xrLabel13, Me.xrLabel12, Me.xrLabel11, Me.xrLabel10})
			Me.GroupFooter1.Name = "GroupFooter1"
			' 
			' xrLabel16
			' 
			Me.xrLabel16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([ProductID])")})
			Me.xrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 23.00002F)
			Me.xrLabel16.Name = "xrLabel16"
			Me.xrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel16.SizeF = New System.Drawing.SizeF(163.5417F, 23F)
			xrSummary2.IgnoreNullValues = True
			xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
			Me.xrLabel16.Summary = xrSummary2
			Me.xrLabel16.TextFormatString = "Item count: {0}"
			' 
			' xrLabel15
			' 
			Me.xrLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(464.5834F, 69.00005F)
			Me.xrLabel15.Name = "xrLabel15"
			Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel15.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel15.StylePriority.UseFont = False
			Me.xrLabel15.Text = "Amount Paid:"
			' 
			' xrLabel14
			' 
			Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(464.5834F, 46.00003F)
			Me.xrLabel14.Name = "xrLabel14"
			Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel14.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel14.Text = "Discount Total:"
			' 
			' xrLabel13
			' 
			Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(464.5834F, 23.00002F)
			Me.xrLabel13.Name = "xrLabel13"
			Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel13.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel13.Text = "Grand Total:"
			' 
			' xrLabel12
			' 
			Me.xrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AmountPaid]")})
			Me.xrLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(564.5834F, 69.00005F)
			Me.xrLabel12.Name = "xrLabel12"
			Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel12.SizeF = New System.Drawing.SizeF(77.08337F, 23F)
			Me.xrLabel12.StylePriority.UseFont = False
			Me.xrLabel12.StylePriority.UseTextAlignment = False
			Me.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrLabel12.TextFormatString = "{0:$0.00}"
			' 
			' xrLabel11
			' 
			Me.xrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DiscountTotal]")})
			Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(564.5834F, 46.00003F)
			Me.xrLabel11.Name = "xrLabel11"
			Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel11.SizeF = New System.Drawing.SizeF(77.08337F, 23F)
			Me.xrLabel11.StylePriority.UseTextAlignment = False
			Me.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrLabel11.TextFormatString = "{0:$0.00}"
			' 
			' xrLabel10
			' 
			Me.xrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SumUnitPrice]")})
			Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(564.5834F, 23.00002F)
			Me.xrLabel10.Name = "xrLabel10"
			Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel10.SizeF = New System.Drawing.SizeF(77.08337F, 23F)
			Me.xrLabel10.StylePriority.UseTextAlignment = False
			Me.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrLabel10.TextFormatString = "{0:$0.00}"
			' 
			' sqlDataSource2
			' 
			Me.sqlDataSource2.ConnectionName = "NWind.mdf"
			Me.sqlDataSource2.Name = "sqlDataSource2"
			columnExpression1.ColumnName = "CustomerID"
			table1.Name = "Customers"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "CompanyName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "ContactName"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "ContactTitle"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "Address"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "City"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "Region"
			columnExpression7.Table = table1
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "PostalCode"
			columnExpression8.Table = table1
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "Country"
			columnExpression9.Table = table1
			column9.Expression = columnExpression9
			columnExpression10.ColumnName = "Phone"
			columnExpression10.Table = table1
			column10.Expression = columnExpression10
			columnExpression11.ColumnName = "Fax"
			columnExpression11.Table = table1
			column11.Expression = columnExpression11
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Columns.Add(column11)
			selectQuery1.MetaSerializable = "<Meta X=""20"" Y=""20"" Width=""108"" Height=""261"" />"
			selectQuery1.Name = "Customers"
			selectQuery1.Tables.Add(table1)
			columnExpression12.ColumnName = "OrderID"
			table2.Name = "Order Details"
			columnExpression12.Table = table2
			column12.Expression = columnExpression12
			columnExpression13.ColumnName = "ProductID"
			columnExpression13.Table = table2
			column13.Expression = columnExpression13
			columnExpression14.ColumnName = "UnitPrice"
			columnExpression14.Table = table2
			column14.Expression = columnExpression14
			columnExpression15.ColumnName = "Quantity"
			columnExpression15.Table = table2
			column15.Expression = columnExpression15
			columnExpression16.ColumnName = "Discount"
			columnExpression16.Table = table2
			column16.Expression = columnExpression16
			selectQuery2.Columns.Add(column12)
			selectQuery2.Columns.Add(column13)
			selectQuery2.Columns.Add(column14)
			selectQuery2.Columns.Add(column15)
			selectQuery2.Columns.Add(column16)
			selectQuery2.MetaSerializable = "<Meta X=""148"" Y=""20"" Width=""100"" Height=""141"" />"
			selectQuery2.Name = "OrderDetails"
			selectQuery2.Tables.Add(table2)
			columnExpression17.ColumnName = "OrderID"
			table3.Name = "Orders"
			columnExpression17.Table = table3
			column17.Expression = columnExpression17
			columnExpression18.ColumnName = "CustomerID"
			columnExpression18.Table = table3
			column18.Expression = columnExpression18
			columnExpression19.ColumnName = "EmployeeID"
			columnExpression19.Table = table3
			column19.Expression = columnExpression19
			columnExpression20.ColumnName = "OrderDate"
			columnExpression20.Table = table3
			column20.Expression = columnExpression20
			columnExpression21.ColumnName = "RequiredDate"
			columnExpression21.Table = table3
			column21.Expression = columnExpression21
			columnExpression22.ColumnName = "ShippedDate"
			columnExpression22.Table = table3
			column22.Expression = columnExpression22
			columnExpression23.ColumnName = "ShipVia"
			columnExpression23.Table = table3
			column23.Expression = columnExpression23
			columnExpression24.ColumnName = "Freight"
			columnExpression24.Table = table3
			column24.Expression = columnExpression24
			columnExpression25.ColumnName = "ShipName"
			columnExpression25.Table = table3
			column25.Expression = columnExpression25
			columnExpression26.ColumnName = "ShipAddress"
			columnExpression26.Table = table3
			column26.Expression = columnExpression26
			columnExpression27.ColumnName = "ShipCity"
			columnExpression27.Table = table3
			column27.Expression = columnExpression27
			columnExpression28.ColumnName = "ShipRegion"
			columnExpression28.Table = table3
			column28.Expression = columnExpression28
			columnExpression29.ColumnName = "ShipPostalCode"
			columnExpression29.Table = table3
			column29.Expression = columnExpression29
			columnExpression30.ColumnName = "ShipCountry"
			columnExpression30.Table = table3
			column30.Expression = columnExpression30
			selectQuery3.Columns.Add(column17)
			selectQuery3.Columns.Add(column18)
			selectQuery3.Columns.Add(column19)
			selectQuery3.Columns.Add(column20)
			selectQuery3.Columns.Add(column21)
			selectQuery3.Columns.Add(column22)
			selectQuery3.Columns.Add(column23)
			selectQuery3.Columns.Add(column24)
			selectQuery3.Columns.Add(column25)
			selectQuery3.Columns.Add(column26)
			selectQuery3.Columns.Add(column27)
			selectQuery3.Columns.Add(column28)
			selectQuery3.Columns.Add(column29)
			selectQuery3.Columns.Add(column30)
			selectQuery3.MetaSerializable = "<Meta X=""268"" Y=""20"" Width=""110"" Height=""321"" />"
			selectQuery3.Name = "Orders"
			selectQuery3.Tables.Add(table3)
			table4.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""283"" />"
			table4.Name = "Products"
			allColumns1.Table = table4
			columnExpression31.ColumnName = "ProductID"
			columnExpression31.Table = table4
			column31.Expression = columnExpression31
			columnExpression32.ColumnName = "ProductName"
			columnExpression32.Table = table4
			column32.Expression = columnExpression32
			columnExpression33.ColumnName = "SupplierID"
			columnExpression33.Table = table4
			column33.Expression = columnExpression33
			columnExpression34.ColumnName = "CategoryID"
			columnExpression34.Table = table4
			column34.Expression = columnExpression34
			columnExpression35.ColumnName = "QuantityPerUnit"
			columnExpression35.Table = table4
			column35.Expression = columnExpression35
			columnExpression36.ColumnName = "UnitPrice"
			columnExpression36.Table = table4
			column36.Expression = columnExpression36
			columnExpression37.ColumnName = "UnitsInStock"
			columnExpression37.Table = table4
			column37.Expression = columnExpression37
			columnExpression38.ColumnName = "UnitsOnOrder"
			columnExpression38.Table = table4
			column38.Expression = columnExpression38
			columnExpression39.ColumnName = "ReorderLevel"
			columnExpression39.Table = table4
			column39.Expression = columnExpression39
			columnExpression40.ColumnName = "Discontinued"
			columnExpression40.Table = table4
			column40.Expression = columnExpression40
			columnExpression41.ColumnName = "EAN13"
			columnExpression41.Table = table4
			column41.Expression = columnExpression41
			selectQuery4.Columns.Add(allColumns1)
			selectQuery4.Columns.Add(column31)
			selectQuery4.Columns.Add(column32)
			selectQuery4.Columns.Add(column33)
			selectQuery4.Columns.Add(column34)
			selectQuery4.Columns.Add(column35)
			selectQuery4.Columns.Add(column36)
			selectQuery4.Columns.Add(column37)
			selectQuery4.Columns.Add(column38)
			selectQuery4.Columns.Add(column39)
			selectQuery4.Columns.Add(column40)
			selectQuery4.Columns.Add(column41)
			selectQuery4.MetaSerializable = "<Meta X=""398"" Y=""20"" Width=""171"" Height=""481"" />"
			selectQuery4.Name = "Products"
			selectQuery4.Tables.Add(table4)
			Me.sqlDataSource2.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1, selectQuery2, selectQuery3, selectQuery4})
			masterDetailInfo1.DetailQueryName = "OrderDetails"
			relationColumnInfo1.NestedKeyColumn = "OrderID"
			relationColumnInfo1.ParentKeyColumn = "OrderID"
			masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
			masterDetailInfo1.MasterQueryName = "Orders"
			masterDetailInfo2.DetailQueryName = "Products"
			relationColumnInfo2.NestedKeyColumn = "Products_ProductID"
			relationColumnInfo2.ParentKeyColumn = "ProductID"
			masterDetailInfo2.KeyColumns.Add(relationColumnInfo2)
			masterDetailInfo2.MasterQueryName = "OrderDetails"
			Me.sqlDataSource2.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() { masterDetailInfo1, masterDetailInfo2})
			Me.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable")
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.barCode1, Me.xrLabel17})
			Me.PageHeader.HeightF = 84.375F
			Me.PageHeader.Name = "PageHeader"
			' 
			' barCode1
			' 
			Me.barCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.barCode1.AutoModule = True
			Me.barCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")})
			Me.barCode1.LocationFloat = New DevExpress.Utils.PointFloat(425.4166F, 10.00001F)
			Me.barCode1.Name = "barCode1"
			Me.barCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 13, 13, 100F)
			Me.barCode1.ShowText = False
			Me.barCode1.SizeF = New System.Drawing.SizeF(211.46F, 62F)
			Me.barCode1.StylePriority.UsePadding = False
			Me.barCode1.Symbology = code128Generator1
			Me.barCode1.Text = "10634"
			' 
			' xrLabel17
			' 
			Me.xrLabel17.Font = New System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xrLabel17.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(227)))), (CInt((CByte(108)))), (CInt((CByte(9)))))
			Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(9.999943F, 10.00001F)
			Me.xrLabel17.Name = "xrLabel17"
			Me.xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrLabel17.SizeF = New System.Drawing.SizeF(236.4583F, 53.20832F)
			Me.xrLabel17.StylePriority.UseFont = False
			Me.xrLabel17.StylePriority.UseForeColor = False
			Me.xrLabel17.StylePriority.UsePadding = False
			Me.xrLabel17.StylePriority.UseTextAlignment = False
			Me.xrLabel17.Text = "INVOICE"
			Me.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrPageInfo2})
			Me.PageFooter.HeightF = 67.08336F
			Me.PageFooter.Name = "PageFooter"
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.874943F, 32.62501F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(260.4166F, 23F)
			Me.xrPageInfo1.StylePriority.UseFont = False
			Me.xrPageInfo1.TextFormatString = "{0:dddd, MMMM d, yyyy}"
			' 
			' xrPageInfo2
			' 
			Me.xrPageInfo2.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(373.7128F, 32.62501F)
			Me.xrPageInfo2.Name = "xrPageInfo2"
			Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo2.RunningBand = Me.GroupHeader1
			Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(263.1621F, 23F)
			Me.xrPageInfo2.StylePriority.UseFont = False
			Me.xrPageInfo2.StylePriority.UseTextAlignment = False
			Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrPageInfo2.TextFormatString = "Page {0} of {1}"
			' 
			' EvenStyle
			' 
			Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(245)))), (CInt((CByte(245)))), (CInt((CByte(245)))))
			Me.EvenStyle.Name = "EvenStyle"
			Me.EvenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			' 
			' NetPrice
			' 
			Me.NetPrice.DataMember = "Orders.OrdersOrderDetails"
			Me.NetPrice.Expression = "[UnitPrice] - [Discount]"
			Me.NetPrice.Name = "NetPrice"
			' 
			' SumUnitPrice
			' 
			Me.SumUnitPrice.DataMember = "Orders.OrdersOrderDetails"
			Me.SumUnitPrice.Expression = "[][[OrderID] == [^.OrderID]].Sum([UnitPrice]*[Quantity])"
			Me.SumUnitPrice.Name = "SumUnitPrice"
			' 
			' DiscountTotal
			' 
			Me.DiscountTotal.DataMember = "Orders.OrdersOrderDetails"
			Me.DiscountTotal.Expression = "[][[OrderID] == [^.OrderID]].Sum([Discount]*[Quantity])"
			Me.DiscountTotal.Name = "DiscountTotal"
			' 
			' AmountPaid
			' 
			Me.AmountPaid.DataMember = "Orders.OrdersOrderDetails"
			Me.AmountPaid.Expression = "[SumUnitPrice] - [DiscountTotal]"
			Me.AmountPaid.Name = "AmountPaid"
			' 
			' paramCompany
			' 
			Me.paramCompany.Description = "Company: "
			Me.paramCompany.MultiValue = True
			Me.paramCompany.Name = "paramCompany"
			Me.paramCompany.ValueInfo = "ALFKI"
			dynamicListLookUpSettings1.DataMember = "Customers"
			dynamicListLookUpSettings1.DataSource = Me.sqlDataSource2
			dynamicListLookUpSettings1.DisplayMember = "CompanyName"
			dynamicListLookUpSettings1.ValueMember = "CustomerID"
			Me.paramCompany.ValueSourceSettings = dynamicListLookUpSettings1
			' 
			' OddStyle
			' 
			Me.OddStyle.BackColor = System.Drawing.Color.White
			Me.OddStyle.Name = "OddStyle"
			Me.OddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			' 
			' InvoiceReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport, Me.PageHeader, Me.PageFooter})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.NetPrice, Me.SumUnitPrice, Me.DiscountTotal, Me.AmountPaid})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource2})
			Me.DataMember = "Orders"
			Me.DataSource = Me.sqlDataSource2
			Me.DisplayName = "Invoice"
			Me.FilterString = "[CustomerID] In (?paramCompany)"
			Me.Font = New System.Drawing.Font("Segoe UI", 9.75F)
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.paramCompany})
			Me.RequestParameters = False
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.EvenStyle, Me.OddStyle})
			Me.Version = "20.1"
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
		#End Region

		Private components As System.ComponentModel.IContainer
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private xrLabel20 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel19 As DevExpress.XtraReports.UI.XRLabel
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
		Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
		Private xrLabel16 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel15 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel14 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel13 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel12 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private xrLabel17 As DevExpress.XtraReports.UI.XRLabel
		Private xrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private EvenStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private NetPrice As DevExpress.XtraReports.UI.CalculatedField
		Private SumUnitPrice As DevExpress.XtraReports.UI.CalculatedField
		Private DiscountTotal As DevExpress.XtraReports.UI.CalculatedField
		Private AmountPaid As DevExpress.XtraReports.UI.CalculatedField
		Private paramCompany As DevExpress.XtraReports.Parameters.Parameter
		Private barCode1 As DevExpress.XtraReports.UI.XRBarCode
		Private sqlDataSource2 As DevExpress.DataAccess.Sql.SqlDataSource
		Private OddStyle As DevExpress.XtraReports.UI.XRControlStyle
	End Class
End Namespace
