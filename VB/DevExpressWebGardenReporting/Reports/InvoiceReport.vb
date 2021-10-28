Imports System.ComponentModel
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI

Namespace DevExpressWebGardenReporting

    Public Partial Class InvoiceReport
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
            components = New System.ComponentModel.Container()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim selectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column19 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression19 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column20 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression20 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column21 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression21 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column22 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression22 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column23 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression23 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column24 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression24 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column25 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression25 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column26 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression26 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column27 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression27 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column28 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression28 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column29 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression29 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column30 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression30 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column31 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression31 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column32 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression32 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column33 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression33 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim selectQuery3 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column34 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression34 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column35 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression35 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column36 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression36 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim masterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvoiceReport))
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
            Dim dynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Me.Name = "Invoice"
            Me.DisplayName = "Invoice"
            sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(components)
            Detail = New DevExpress.XtraReports.UI.DetailBand()
            xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            xrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
            BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
            DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            xrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
            PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            barCode1 = New DevExpress.XtraReports.UI.XRBarCode()
            xrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
            PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
            xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            NetPrice = New DevExpress.XtraReports.UI.CalculatedField()
            SumUnitPrice = New DevExpress.XtraReports.UI.CalculatedField()
            DiscountTotal = New DevExpress.XtraReports.UI.CalculatedField()
            AmountPaid = New DevExpress.XtraReports.UI.CalculatedField()
            paramCompany = New DevExpress.XtraReports.Parameters.Parameter()
            OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            CType(xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlDataSource1
            ' 
            sqlDataSource1.ConnectionName = "NWindConnectionString"
            sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "OrderID"
            table1.Name = "OrderDetailsExtended"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductID"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "ProductName"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "UnitPrice"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Quantity"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "Discount"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "ExtendedPrice"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "Supplier"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Name = "OrderDetails"
            selectQuery1.Tables.Add(table1)
            columnExpression9.ColumnName = "OrderID"
            table2.Name = "Orders"
            columnExpression9.Table = table2
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "CustomerID"
            columnExpression10.Table = table2
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "EmployeeID"
            columnExpression11.Table = table2
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "OrderDate"
            columnExpression12.Table = table2
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "RequiredDate"
            columnExpression13.Table = table2
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "ShippedDate"
            columnExpression14.Table = table2
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "ShipVia"
            columnExpression15.Table = table2
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "Freight"
            columnExpression16.Table = table2
            column16.Expression = columnExpression16
            columnExpression17.ColumnName = "ShipName"
            columnExpression17.Table = table2
            column17.Expression = columnExpression17
            columnExpression18.ColumnName = "ShipAddress"
            columnExpression18.Table = table2
            column18.Expression = columnExpression18
            columnExpression19.ColumnName = "ShipCity"
            columnExpression19.Table = table2
            column19.Expression = columnExpression19
            columnExpression20.ColumnName = "ShipRegion"
            columnExpression20.Table = table2
            column20.Expression = columnExpression20
            columnExpression21.ColumnName = "ShipPostalCode"
            columnExpression21.Table = table2
            column21.Expression = columnExpression21
            columnExpression22.ColumnName = "ShipCountry"
            columnExpression22.Table = table2
            column22.Expression = columnExpression22
            column23.[Alias] = "Customers_CustomerID"
            columnExpression23.ColumnName = "CustomerID"
            table3.Name = "Customers"
            columnExpression23.Table = table3
            column23.Expression = columnExpression23
            columnExpression24.ColumnName = "CompanyName"
            columnExpression24.Table = table3
            column24.Expression = columnExpression24
            columnExpression25.ColumnName = "ContactName"
            columnExpression25.Table = table3
            column25.Expression = columnExpression25
            columnExpression26.ColumnName = "ContactTitle"
            columnExpression26.Table = table3
            column26.Expression = columnExpression26
            columnExpression27.ColumnName = "Address"
            columnExpression27.Table = table3
            column27.Expression = columnExpression27
            columnExpression28.ColumnName = "City"
            columnExpression28.Table = table3
            column28.Expression = columnExpression28
            columnExpression29.ColumnName = "Region"
            columnExpression29.Table = table3
            column29.Expression = columnExpression29
            columnExpression30.ColumnName = "PostalCode"
            columnExpression30.Table = table3
            column30.Expression = columnExpression30
            columnExpression31.ColumnName = "Country"
            columnExpression31.Table = table3
            column31.Expression = columnExpression31
            columnExpression32.ColumnName = "Phone"
            columnExpression32.Table = table3
            column32.Expression = columnExpression32
            columnExpression33.ColumnName = "Fax"
            columnExpression33.Table = table3
            column33.Expression = columnExpression33
            selectQuery2.Columns.Add(column9)
            selectQuery2.Columns.Add(column10)
            selectQuery2.Columns.Add(column11)
            selectQuery2.Columns.Add(column12)
            selectQuery2.Columns.Add(column13)
            selectQuery2.Columns.Add(column14)
            selectQuery2.Columns.Add(column15)
            selectQuery2.Columns.Add(column16)
            selectQuery2.Columns.Add(column17)
            selectQuery2.Columns.Add(column18)
            selectQuery2.Columns.Add(column19)
            selectQuery2.Columns.Add(column20)
            selectQuery2.Columns.Add(column21)
            selectQuery2.Columns.Add(column22)
            selectQuery2.Columns.Add(column23)
            selectQuery2.Columns.Add(column24)
            selectQuery2.Columns.Add(column25)
            selectQuery2.Columns.Add(column26)
            selectQuery2.Columns.Add(column27)
            selectQuery2.Columns.Add(column28)
            selectQuery2.Columns.Add(column29)
            selectQuery2.Columns.Add(column30)
            selectQuery2.Columns.Add(column31)
            selectQuery2.Columns.Add(column32)
            selectQuery2.Columns.Add(column33)
            selectQuery2.Name = "Orders"
            relationColumnInfo1.NestedKeyColumn = "CustomerID"
            relationColumnInfo1.ParentKeyColumn = "CustomerID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table2
            join1.Parent = table3
            selectQuery2.Relations.Add(join1)
            selectQuery2.Tables.Add(table3)
            selectQuery2.Tables.Add(table2)
            columnExpression34.ColumnName = "CustomerID"
            table4.Name = "Customers"
            columnExpression34.Table = table4
            column34.Expression = columnExpression34
            columnExpression35.ColumnName = "CompanyName"
            columnExpression35.Table = table4
            column35.Expression = columnExpression35
            columnExpression36.ColumnName = "ContactName"
            columnExpression36.Table = table4
            column36.Expression = columnExpression36
            selectQuery3.Columns.Add(column34)
            selectQuery3.Columns.Add(column35)
            selectQuery3.Columns.Add(column36)
            selectQuery3.Name = "Customers"
            selectQuery3.Tables.Add(table4)
            sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1, selectQuery2, selectQuery3})
            masterDetailInfo1.DetailQueryName = "OrderDetails"
            relationColumnInfo2.NestedKeyColumn = "OrderID"
            relationColumnInfo2.ParentKeyColumn = "OrderID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo2)
            masterDetailInfo1.MasterQueryName = "Orders"
            sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {masterDetailInfo1})
            sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' Detail
            ' 
            Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {xrLabel9, xrLabel8, xrLabel5, xrLabel4, xrLabel3, xrLabel2, xrLabel1})
            Detail.HeightF = 183.125F
            Detail.Name = "Detail"
            Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ContactName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel9
            ' 
            xrLabel9.Font = New System.Drawing.Font("Segoe UI", 10F)
            xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(425.4167F, 32.99999F)
            xrLabel9.Name = "xrLabel9"
            xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel9.SizeF = New System.Drawing.SizeF(216.2501F, 23F)
            xrLabel9.StylePriority.UseFont = False
            xrLabel9.StylePriority.UseTextAlignment = False
            xrLabel9.Text = "Order Date: [OrderDate!M/d/yyyy]"
            xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' xrLabel8
            ' 
            xrLabel8.Font = New System.Drawing.Font("Segoe UI", 10F)
            xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(425.4166F, 10.00001F)
            xrLabel8.Name = "xrLabel8"
            xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel8.SizeF = New System.Drawing.SizeF(216.2501F, 23F)
            xrLabel8.StylePriority.UseFont = False
            xrLabel8.StylePriority.UseTextAlignment = False
            xrLabel8.Text = "Order ID: [OrderId]"
            xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' xrLabel5
            ' 
            xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShipCountry")})
            xrLabel5.Font = New System.Drawing.Font("Segoe UI", 10F)
            xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 102F)
            xrLabel5.Name = "xrLabel5"
            xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel5.SizeF = New System.Drawing.SizeF(301.0417F, 23F)
            xrLabel5.StylePriority.UseFont = False
            xrLabel5.Text = "xrLabel5"
            ' 
            ' xrLabel4
            ' 
            xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShipCity")})
            xrLabel4.Font = New System.Drawing.Font("Segoe UI", 10F)
            xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 79.00003F)
            xrLabel4.Name = "xrLabel4"
            xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel4.SizeF = New System.Drawing.SizeF(301.0417F, 23F)
            xrLabel4.StylePriority.UseFont = False
            xrLabel4.Text = "xrLabel4"
            ' 
            ' xrLabel3
            ' 
            xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShipAddress")})
            xrLabel3.Font = New System.Drawing.Font("Segoe UI", 10F)
            xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 56.00001F)
            xrLabel3.Name = "xrLabel3"
            xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel3.SizeF = New System.Drawing.SizeF(301.0417F, 23F)
            xrLabel3.StylePriority.UseFont = False
            xrLabel3.Text = "xrLabel3"
            ' 
            ' xrLabel2
            ' 
            xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ContactName")})
            xrLabel2.Font = New System.Drawing.Font("Segoe UI", 10F)
            xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 32.99999F)
            xrLabel2.Name = "xrLabel2"
            xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel2.SizeF = New System.Drawing.SizeF(301.0417F, 23F)
            xrLabel2.StylePriority.UseFont = False
            xrLabel2.Text = "xrLabel2"
            ' 
            ' xrLabel1
            ' 
            xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.CompanyName")})
            xrLabel1.Font = New System.Drawing.Font("Segoe UI", 10F)
            xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            xrLabel1.Name = "xrLabel1"
            xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel1.SizeF = New System.Drawing.SizeF(301.0417F, 23F)
            xrLabel1.StylePriority.UseFont = False
            xrLabel1.Text = "xrLabel1"
            ' 
            ' TopMargin
            ' 
            TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {xrLabel20, xrLabel19})
            TopMargin.HeightF = 100F
            TopMargin.Name = "TopMargin"
            TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel20
            ' 
            xrLabel20.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline)
            xrLabel20.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte(0))))), (CInt(((CByte(64))))), (CInt(((CByte(128))))))
            xrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(9.99999F, 54.79167F)
            xrLabel20.Name = "xrLabel20"
            xrLabel20.NavigateUrl = "https://documentation.devexpress.com/#XtraReports/CustomDocument117229"
            xrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel20.SizeF = New System.Drawing.SizeF(630F, 23F)
            xrLabel20.StylePriority.UseFont = False
            xrLabel20.StylePriority.UseForeColor = False
            xrLabel20.StylePriority.UseTextAlignment = False
            xrLabel20.Text = "Read a step-by-step guide on creating invoices in our online documentation"
            xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' xrLabel19
            ' 
            xrLabel19.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline)
            xrLabel19.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte(0))))), (CInt(((CByte(64))))), (CInt(((CByte(128))))))
            xrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(9.99999F, 21.45834F)
            xrLabel19.Name = "xrLabel19"
            xrLabel19.NavigateUrl = "https://www.youtube.com/watch?v=oaXK-XhwF8g"
            xrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel19.SizeF = New System.Drawing.SizeF(630F, 23F)
            xrLabel19.StylePriority.UseFont = False
            xrLabel19.StylePriority.UseForeColor = False
            xrLabel19.StylePriority.UseTextAlignment = False
            xrLabel19.Target = "_blank"
            xrLabel19.Text = "Watch a video tutorial on creating invoices on the DevExpress YouTube channel"
            xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' BottomMargin
            ' 
            BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {xrPictureBox3})
            BottomMargin.HeightF = 100F
            BottomMargin.Name = "BottomMargin"
            BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox3
            ' 
            xrPictureBox3.Image = CType(resources.GetObject("xrPictureBox3.Image"), System.Drawing.Image)
            xrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(254F, 13F)
            xrPictureBox3.Name = "xrPictureBox3"
            xrPictureBox3.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            xrPictureBox3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            xrPictureBox3.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' DetailReport
            ' 
            DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Detail1, GroupHeader1, GroupFooter1})
            DetailReport.DataMember = "Orders.OrdersOrderDetails"
            DetailReport.DataSource = sqlDataSource1
            DetailReport.Level = 0
            DetailReport.Name = "DetailReport"
            DetailReport.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
            ' 
            ' Detail1
            ' 
            Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {xrTable1})
            Detail1.HeightF = 25F
            Detail1.Name = "Detail1"
            ' 
            ' xrTable1
            ' 
            xrTable1.EvenStyleName = "EvenStyle"
            xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
            xrTable1.Name = "xrTable1"
            xrTable1.OddStyleName = "OddStyle"
            xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {xrTableRow1})
            xrTable1.SizeF = New System.Drawing.SizeF(631.6667F, 25F)
            xrTable1.StylePriority.UsePadding = False
            ' 
            ' xrTableRow1
            ' 
            xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {xrTableCell11, xrTableCell1, xrTableCell2, xrTableCell3, xrTableCell4, xrTableCell5})
            xrTableRow1.Name = "xrTableRow1"
            xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell11
            ' 
            xrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.ProductName")})
            xrTableCell11.Name = "xrTableCell11"
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
            xrSummary1.IgnoreNullValues = True
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            xrTableCell11.Summary = xrSummary1
            xrTableCell11.Weight = 0.34866643084143989R
            ' 
            ' xrTableCell1
            ' 
            xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.Quantity")})
            xrTableCell1.Name = "xrTableCell1"
            xrTableCell1.Text = "xrTableCell1"
            xrTableCell1.Weight = 0.51362107961775716R
            ' 
            ' xrTableCell2
            ' 
            xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.ProductName")})
            xrTableCell2.Name = "xrTableCell2"
            xrTableCell2.Text = "xrTableCell2"
            xrTableCell2.Weight = 1.2717350033943944R
            ' 
            ' xrTableCell3
            ' 
            xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.UnitPrice", "{0:$0.00}")})
            xrTableCell3.Name = "xrTableCell3"
            xrTableCell3.StylePriority.UseTextAlignment = False
            xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            xrTableCell3.Weight = 0.55150349731894355R
            ' 
            ' xrTableCell4
            ' 
            xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.Discount", "{0:$0.00}")})
            xrTableCell4.Name = "xrTableCell4"
            xrTableCell4.StylePriority.UseTextAlignment = False
            xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            xrTableCell4.Weight = 0.48767140202171211R
            ' 
            ' xrTableCell5
            ' 
            xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.NetPrice", "{0:$0.00}")})
            xrTableCell5.Name = "xrTableCell5"
            xrTableCell5.StylePriority.UseTextAlignment = False
            xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            xrTableCell5.Weight = 0.5329990636687334R
            ' 
            ' GroupHeader1
            ' 
            GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {xrTable2})
            GroupHeader1.HeightF = 25F
            GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrTable2
            ' 
            xrTable2.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold)
            xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
            xrTable2.Name = "xrTable2"
            xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {xrTableRow2})
            xrTable2.SizeF = New System.Drawing.SizeF(631.6667F, 25F)
            xrTable2.StylePriority.UseFont = False
            xrTable2.StylePriority.UsePadding = False
            ' 
            ' xrTableRow2
            ' 
            xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {xrTableCell12, xrTableCell6, xrTableCell7, xrTableCell8, xrTableCell9, xrTableCell10})
            xrTableRow2.Name = "xrTableRow2"
            xrTableRow2.Weight = 11.5R
            ' 
            ' xrTableCell12
            ' 
            xrTableCell12.Name = "xrTableCell12"
            xrTableCell12.Text = "Pos."
            xrTableCell12.Weight = 0.34615376790364583R
            ' 
            ' xrTableCell6
            ' 
            xrTableCell6.Name = "xrTableCell6"
            xrTableCell6.Text = "Quantity"
            xrTableCell6.Weight = 0.50991943007312723R
            ' 
            ' xrTableCell7
            ' 
            xrTableCell7.Name = "xrTableCell7"
            xrTableCell7.Text = "Product Name"
            xrTableCell7.Weight = 1.2625702019729144R
            ' 
            ' xrTableCell8
            ' 
            xrTableCell8.Name = "xrTableCell8"
            xrTableCell8.StylePriority.UseTextAlignment = False
            xrTableCell8.Text = "Unit Price"
            xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            xrTableCell8.Weight = 0.54752939679513135R
            ' 
            ' xrTableCell9
            ' 
            xrTableCell9.Name = "xrTableCell9"
            xrTableCell9.StylePriority.UseTextAlignment = False
            xrTableCell9.Text = "Discount"
            xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            xrTableCell9.Weight = 0.48415660797933485R
            ' 
            ' xrTableCell10
            ' 
            xrTableCell10.Name = "xrTableCell10"
            xrTableCell10.StylePriority.UseTextAlignment = False
            xrTableCell10.Text = "Net Price"
            xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            xrTableCell10.Weight = 0.52915769651282552R
            ' 
            ' GroupFooter1
            ' 
            GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {xrLabel16, xrLabel15, xrLabel14, xrLabel13, xrLabel12, xrLabel11, xrLabel10})
            GroupFooter1.HeightF = 100F
            GroupFooter1.Name = "GroupFooter1"
            ' 
            ' xrLabel16
            ' 
            xrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.ProductName")})
            xrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 23.00002F)
            xrLabel16.Name = "xrLabel16"
            xrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel16.SizeF = New System.Drawing.SizeF(163.5417F, 23F)
            xrSummary2.FormatString = "Item count: {0}"
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
            xrSummary2.IgnoreNullValues = True
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            xrLabel16.Summary = xrSummary2
            ' 
            ' xrLabel15
            ' 
            xrLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold)
            xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(464.5834F, 69.00005F)
            xrLabel15.Name = "xrLabel15"
            xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel15.SizeF = New System.Drawing.SizeF(100F, 23F)
            xrLabel15.StylePriority.UseFont = False
            xrLabel15.Text = "Amount Paid:"
            ' 
            ' xrLabel14
            ' 
            xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(464.5834F, 46.00003F)
            xrLabel14.Name = "xrLabel14"
            xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel14.SizeF = New System.Drawing.SizeF(100F, 23F)
            xrLabel14.Text = "Discount Total:"
            ' 
            ' xrLabel13
            ' 
            xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(464.5834F, 23.00002F)
            xrLabel13.Name = "xrLabel13"
            xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel13.SizeF = New System.Drawing.SizeF(100F, 23F)
            xrLabel13.Text = "Grand Total:"
            ' 
            ' xrLabel12
            ' 
            xrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.AmountPaid", "{0:$0.00}")})
            xrLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold)
            xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(564.5834F, 69.00005F)
            xrLabel12.Name = "xrLabel12"
            xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel12.SizeF = New System.Drawing.SizeF(77.08337F, 23F)
            xrLabel12.StylePriority.UseFont = False
            xrLabel12.StylePriority.UseTextAlignment = False
            xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' xrLabel11
            ' 
            xrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.DiscountTotal", "{0:$0.00}")})
            xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(564.5834F, 46.00003F)
            xrLabel11.Name = "xrLabel11"
            xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel11.SizeF = New System.Drawing.SizeF(77.08337F, 23F)
            xrLabel11.StylePriority.UseTextAlignment = False
            xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' xrLabel10
            ' 
            xrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.SumUnitPrice", "{0:$0.00}")})
            xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(564.5834F, 23.00002F)
            xrLabel10.Name = "xrLabel10"
            xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel10.SizeF = New System.Drawing.SizeF(77.08337F, 23F)
            xrLabel10.StylePriority.UseTextAlignment = False
            xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' PageHeader
            ' 
            PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {barCode1, xrLabel17})
            PageHeader.HeightF = 84.375F
            PageHeader.Name = "PageHeader"
            ' 
            ' barCode1
            ' 
            barCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            barCode1.AutoModule = True
            barCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderID")})
            barCode1.LocationFloat = New DevExpress.Utils.PointFloat(425.4166F, 10.00001F)
            barCode1.Name = "barCode1"
            barCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 13, 13, 100F)
            barCode1.ShowText = False
            barCode1.SizeF = New System.Drawing.SizeF(211.46F, 62F)
            barCode1.StylePriority.UsePadding = False
            barCode1.Symbology = code128Generator1
            barCode1.Text = "10634"
            ' 
            ' xrLabel17
            ' 
            xrLabel17.Font = New System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            xrLabel17.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte(227))))), (CInt(((CByte(108))))), (CInt(((CByte(9))))))
            xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(9.999943F, 10.00001F)
            xrLabel17.Name = "xrLabel17"
            xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            xrLabel17.SizeF = New System.Drawing.SizeF(236.4583F, 53.20832F)
            xrLabel17.StylePriority.UseFont = False
            xrLabel17.StylePriority.UseForeColor = False
            xrLabel17.StylePriority.UsePadding = False
            xrLabel17.StylePriority.UseTextAlignment = False
            xrLabel17.Text = "INVOICE"
            xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' PageFooter
            ' 
            PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {xrPageInfo1, xrPageInfo2})
            PageFooter.HeightF = 67.08336F
            PageFooter.Name = "PageFooter"
            ' 
            ' xrPageInfo1
            ' 
            xrPageInfo1.Font = New System.Drawing.Font("Segoe UI", 10F)
            xrPageInfo1.Format = "{0:dddd, MMMM d, yyyy}"
            xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.874943F, 32.62501F)
            xrPageInfo1.Name = "xrPageInfo1"
            xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            xrPageInfo1.SizeF = New System.Drawing.SizeF(260.4166F, 23F)
            xrPageInfo1.StylePriority.UseFont = False
            ' 
            ' xrPageInfo2
            ' 
            xrPageInfo2.Font = New System.Drawing.Font("Segoe UI", 10F)
            xrPageInfo2.Format = "Page {0} of {1}"
            xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(373.7128F, 32.62501F)
            xrPageInfo2.Name = "xrPageInfo2"
            xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrPageInfo2.RunningBand = GroupHeader1
            xrPageInfo2.SizeF = New System.Drawing.SizeF(263.1621F, 23F)
            xrPageInfo2.StylePriority.UseFont = False
            xrPageInfo2.StylePriority.UseTextAlignment = False
            xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' EvenStyle
            ' 
            EvenStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte(245))))), (CInt(((CByte(245))))), (CInt(((CByte(245))))))
            EvenStyle.Name = "EvenStyle"
            EvenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' NetPrice
            ' 
            NetPrice.DataMember = "Orders.OrdersOrderDetails"
            NetPrice.Expression = "[UnitPrice] - [Discount]"
            NetPrice.Name = "NetPrice"
            ' 
            ' SumUnitPrice
            ' 
            SumUnitPrice.DataMember = "Orders.OrdersOrderDetails"
            SumUnitPrice.Expression = "[][[OrderID] == [^.OrderID]].Sum([UnitPrice]*[Quantity])"
            SumUnitPrice.Name = "SumUnitPrice"
            ' 
            ' DiscountTotal
            ' 
            DiscountTotal.DataMember = "Orders.OrdersOrderDetails"
            DiscountTotal.Expression = "[][[OrderID] == [^.OrderID]].Sum([Discount]*[Quantity])"
            DiscountTotal.Name = "DiscountTotal"
            ' 
            ' AmountPaid
            ' 
            AmountPaid.DataMember = "Orders.OrdersOrderDetails"
            AmountPaid.Expression = "[SumUnitPrice] - [DiscountTotal]"
            AmountPaid.Name = "AmountPaid"
            ' 
            ' paramCompany
            ' 
            paramCompany.Description = "Company: "
            dynamicListLookUpSettings1.DataAdapter = Nothing
            dynamicListLookUpSettings1.DataMember = "Customers"
            dynamicListLookUpSettings1.DataSource = sqlDataSource1
            dynamicListLookUpSettings1.DisplayMember = "CompanyName"
            dynamicListLookUpSettings1.ValueMember = "CustomerID"
            paramCompany.LookUpSettings = dynamicListLookUpSettings1
            paramCompany.MultiValue = True
            paramCompany.Name = "paramCompany"
            paramCompany.ValueInfo = "ALFKI"
            ' 
            ' OddStyle
            ' 
            OddStyle.BackColor = System.Drawing.Color.White
            OddStyle.Name = "OddStyle"
            OddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' InvoiceReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Detail, TopMargin, BottomMargin, DetailReport, PageHeader, PageFooter})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {NetPrice, SumUnitPrice, DiscountTotal, AmountPaid})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {sqlDataSource1})
            Me.DataMember = "Orders"
            Me.DataSource = sqlDataSource1
            Me.FilterString = "[CustomerID] In (?paramCompany)"
            Me.Font = New System.Drawing.Font("Segoe UI", 9.75F)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {paramCompany})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {EvenStyle, OddStyle})
            Me.Version = "17.1"
            CType(xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

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

        Private OddStyle As DevExpress.XtraReports.UI.XRControlStyle
    End Class
End Namespace
