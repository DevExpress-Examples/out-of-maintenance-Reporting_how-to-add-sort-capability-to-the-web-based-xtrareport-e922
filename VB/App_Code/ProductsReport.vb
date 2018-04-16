Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Collections.Generic
Imports System.Web

''' <summary>
''' Summary description for ProductsReport
''' </summary>
Public Class ProductsReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private Detail As DevExpress.XtraReports.UI.DetailBand
    Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Private nWindDataSet1 As NWindDataSet
    Private productsTableAdapter1 As NWindDataSetTableAdapters.ProductsTableAdapter
    Private tbDataRow As XRTable
    Private tdDataRow As XRTableRow
    Private tcProductName As XRTableCell
    Private tcCategoryName As XRTableCell
    Private tcCompanyName As XRTableCell
    Private tcContactName As XRTableCell
    Private tcUnitPrice As XRTableCell
    Private tcUnitInStock As XRTableCell
    Private tcUnitsOnOrder As XRTableCell
    Private tcDiscontinued As XRTableCell
    Private cbDiscontinued As XRCheckBox
    Private GroupHeader As GroupHeaderBand
    Private tbHeader As XRTable
    Private trHeader As XRTableRow
    Private WithEvents tcProductNameHeader As XRTableCell
    Private WithEvents tcCategoryNameHeader As XRTableCell
    Private WithEvents tcCompanyNameHeader As XRTableCell
    Private WithEvents tcContactNameHeader As XRTableCell
    Private WithEvents tcUnitPriceHeader As XRTableCell
    Private WithEvents tcUnitsInStockHeader As XRTableCell
    Private WithEvents tcUnitsOnOrderHeader As XRTableCell
    Private WithEvents tcDiscontinuedHeader As XRTableCell
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Private Const SortedColumnSuffix_Ascending As String = " ▼"
    Private Const SortedColumnSuffix_Descending As String = " ▲"
    Private Const SortedColumns_SessionKey As String = "ProductsReport_SortedColumns"

    Private Shared _sortedColumns As List(Of GroupField) = Nothing

    Public Shared ReadOnly Property SortedColumns() As List(Of GroupField)
        Get
            If _sortedColumns Is Nothing Then
                _sortedColumns = DirectCast(HttpContext.Current.Session(SortedColumns_SessionKey), List(Of GroupField))
                If _sortedColumns Is Nothing Then
                    _sortedColumns = New List(Of GroupField)()
                    HttpContext.Current.Session(SortedColumns_SessionKey) = _sortedColumns
                End If
            End If
            Return _sortedColumns
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
        '
        ' TODO: Add constructor logic here
        '
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    #Region "Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
            Dim resourceFileName As String = "ProductsReport.resx"
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.tbDataRow = New DevExpress.XtraReports.UI.XRTable()
            Me.tdDataRow = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tcProductName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcCategoryName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcCompanyName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcContactName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcUnitInStock = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcUnitsOnOrder = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcDiscontinued = New DevExpress.XtraReports.UI.XRTableCell()
            Me.cbDiscontinued = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.nWindDataSet1 = New NWindDataSet()
            Me.productsTableAdapter1 = New NWindDataSetTableAdapters.ProductsTableAdapter()
            Me.GroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.tbHeader = New DevExpress.XtraReports.UI.XRTable()
            Me.trHeader = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tcProductNameHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcCategoryNameHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcCompanyNameHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcContactNameHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcUnitPriceHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcUnitsInStockHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcUnitsOnOrderHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcDiscontinuedHeader = New DevExpress.XtraReports.UI.XRTableCell()
            DirectCast(Me.tbDataRow, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nWindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tbHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tbDataRow})
            Me.Detail.Font = New System.Drawing.Font("Times New Roman", 12F)
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100F)
            Me.Detail.StylePriority.UseBorders = False
            Me.Detail.StylePriority.UseFont = False
            Me.Detail.StylePriority.UsePadding = False
            Me.Detail.StylePriority.UseTextAlignment = False
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' tbDataRow
            ' 
            Me.tbDataRow.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tbDataRow.Name = "tbDataRow"
            Me.tbDataRow.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tdDataRow})
            Me.tbDataRow.SizeF = New System.Drawing.SizeF(900F, 25F)
            ' 
            ' tdDataRow
            ' 
            Me.tdDataRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tcProductName, Me.tcCategoryName, Me.tcCompanyName, Me.tcContactName, Me.tcUnitPrice, Me.tcUnitInStock, Me.tcUnitsOnOrder, Me.tcDiscontinued})
            Me.tdDataRow.Name = "tdDataRow"
            Me.tdDataRow.Weight = 1R
            ' 
            ' tcProductName
            ' 
            Me.tcProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
            Me.tcProductName.Name = "tcProductName"
            Me.tcProductName.Weight = 1.5R
            ' 
            ' tcCategoryName
            ' 
            Me.tcCategoryName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.CategoryName")})
            Me.tcCategoryName.Name = "tcCategoryName"
            Me.tcCategoryName.Text = "tcCategoryName"
            Me.tcCategoryName.Weight = 1R
            ' 
            ' tcCompanyName
            ' 
            Me.tcCompanyName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.CompanyName")})
            Me.tcCompanyName.Name = "tcCompanyName"
            Me.tcCompanyName.Text = "tcCompanyName"
            Me.tcCompanyName.Weight = 1R
            ' 
            ' tcContactName
            ' 
            Me.tcContactName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ContactName")})
            Me.tcContactName.Name = "tcContactName"
            Me.tcContactName.Text = "tcContactName"
            Me.tcContactName.Weight = 1.5R
            ' 
            ' tcUnitPrice
            ' 
            Me.tcUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:c}")})
            Me.tcUnitPrice.Name = "tcUnitPrice"
            Me.tcUnitPrice.StylePriority.UseTextAlignment = False
            Me.tcUnitPrice.Text = "tcUnitPrice"
            Me.tcUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.tcUnitPrice.Weight = 1R
            ' 
            ' tcUnitInStock
            ' 
            Me.tcUnitInStock.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsInStock")})
            Me.tcUnitInStock.Name = "tcUnitInStock"
            Me.tcUnitInStock.StylePriority.UseTextAlignment = False
            Me.tcUnitInStock.Text = "tcUnitInStock"
            Me.tcUnitInStock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.tcUnitInStock.Weight = 1R
            ' 
            ' tcUnitsOnOrder
            ' 
            Me.tcUnitsOnOrder.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsOnOrder")})
            Me.tcUnitsOnOrder.Name = "tcUnitsOnOrder"
            Me.tcUnitsOnOrder.StylePriority.UseTextAlignment = False
            Me.tcUnitsOnOrder.Text = "tcUnitsOnOrder"
            Me.tcUnitsOnOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.tcUnitsOnOrder.Weight = 0.99999999999999989R
            ' 
            ' tcDiscontinued
            ' 
            Me.tcDiscontinued.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.cbDiscontinued})
            Me.tcDiscontinued.Name = "tcDiscontinued"
            Me.tcDiscontinued.Text = "tcDiscontinued"
            Me.tcDiscontinued.Weight = 1R
            ' 
            ' cbDiscontinued
            ' 
            Me.cbDiscontinued.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
            Me.cbDiscontinued.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.cbDiscontinued.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "Products.Discontinued")})
            Me.cbDiscontinued.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.cbDiscontinued.LocationFloat = New DevExpress.Utils.PointFloat(2F, 1.999982F)
            Me.cbDiscontinued.Name = "cbDiscontinued"
            Me.cbDiscontinued.SizeF = New System.Drawing.SizeF(96F, 21F)
            Me.cbDiscontinued.StylePriority.UseBorders = False
            Me.cbDiscontinued.Text = "cbDiscontinued"
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' nWindDataSet1
            ' 
            Me.nWindDataSet1.DataSetName = "NWindDataSet"
            Me.nWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' productsTableAdapter1
            ' 
            Me.productsTableAdapter1.ClearBeforeFill = True
            ' 
            ' GroupHeader
            ' 
            Me.GroupHeader.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.GroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tbHeader})
            Me.GroupHeader.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.GroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader.HeightF = 25F
            Me.GroupHeader.Name = "GroupHeader"
            Me.GroupHeader.RepeatEveryPage = True
            Me.GroupHeader.StylePriority.UseBorders = False
            Me.GroupHeader.StylePriority.UseFont = False
            Me.GroupHeader.StylePriority.UseTextAlignment = False
            Me.GroupHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' tbHeader
            ' 
            Me.tbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tbHeader.Name = "tbHeader"
            Me.tbHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.trHeader})
            Me.tbHeader.SizeF = New System.Drawing.SizeF(900F, 25F)
            ' 
            ' trHeader
            ' 
            Me.trHeader.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tcProductNameHeader, Me.tcCategoryNameHeader, Me.tcCompanyNameHeader, Me.tcContactNameHeader, Me.tcUnitPriceHeader, Me.tcUnitsInStockHeader, Me.tcUnitsOnOrderHeader, Me.tcDiscontinuedHeader})
            Me.trHeader.Name = "trHeader"
            Me.trHeader.Weight = 1R
            ' 
            ' tcProductNameHeader
            ' 
            Me.tcProductNameHeader.Name = "tcProductNameHeader"
            Me.tcProductNameHeader.Tag = "ProductName"
            Me.tcProductNameHeader.Text = "Product"
            Me.tcProductNameHeader.Weight = 1.5R
            ' 
            ' tcCategoryNameHeader
            ' 
            Me.tcCategoryNameHeader.Name = "tcCategoryNameHeader"
            Me.tcCategoryNameHeader.Tag = "CategoryName"
            Me.tcCategoryNameHeader.Text = "Category"
            Me.tcCategoryNameHeader.Weight = 1R
            ' 
            ' tcCompanyNameHeader
            ' 
            Me.tcCompanyNameHeader.Name = "tcCompanyNameHeader"
            Me.tcCompanyNameHeader.Tag = "CompanyName"
            Me.tcCompanyNameHeader.Text = "Company"
            Me.tcCompanyNameHeader.Weight = 1R
            ' 
            ' tcContactNameHeader
            ' 
            Me.tcContactNameHeader.Name = "tcContactNameHeader"
            Me.tcContactNameHeader.Tag = "ContactName"
            Me.tcContactNameHeader.Text = "Contact"
            Me.tcContactNameHeader.Weight = 1.5R
            ' 
            ' tcUnitPriceHeader
            ' 
            Me.tcUnitPriceHeader.Name = "tcUnitPriceHeader"
            Me.tcUnitPriceHeader.StylePriority.UseTextAlignment = False
            Me.tcUnitPriceHeader.Tag = "UnitPrice"
            Me.tcUnitPriceHeader.Text = "Price"
            Me.tcUnitPriceHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            Me.tcUnitPriceHeader.Weight = 1R
            ' 
            ' tcUnitsInStockHeader
            ' 
            Me.tcUnitsInStockHeader.Name = "tcUnitsInStockHeader"
            Me.tcUnitsInStockHeader.StylePriority.UseTextAlignment = False
            Me.tcUnitsInStockHeader.Tag = "UnitsInStock"
            Me.tcUnitsInStockHeader.Text = "In Stock"
            Me.tcUnitsInStockHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            Me.tcUnitsInStockHeader.Weight = 1R
            ' 
            ' tcUnitsOnOrderHeader
            ' 
            Me.tcUnitsOnOrderHeader.Name = "tcUnitsOnOrderHeader"
            Me.tcUnitsOnOrderHeader.StylePriority.UseTextAlignment = False
            Me.tcUnitsOnOrderHeader.Tag = "UnitsOnOrder"
            Me.tcUnitsOnOrderHeader.Text = "On Order"
            Me.tcUnitsOnOrderHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            Me.tcUnitsOnOrderHeader.Weight = 0.99999999999999989R
            ' 
            ' tcDiscontinuedHeader
            ' 
            Me.tcDiscontinuedHeader.Name = "tcDiscontinuedHeader"
            Me.tcDiscontinuedHeader.Tag = "Discontinued"
            Me.tcDiscontinuedHeader.Text = "Discont."
            Me.tcDiscontinuedHeader.Weight = 1R
            ' 
            ' ProductsReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader})
            Me.DataAdapter = Me.productsTableAdapter1
            Me.DataMember = "Products"
            Me.DataSource = Me.nWindDataSet1
            Me.Landscape = True
            Me.PageHeight = 850
            Me.PageWidth = 1100
            Me.Version = "13.2"
            DirectCast(Me.tbDataRow, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nWindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tbHeader, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    #End Region

    Public Shared Sub SortBy(ByVal fieldName As String, ByVal isAdding As Boolean)
        If isAdding Then
            SortedColumns.ForEach(Sub(sortField)
                If sortField.FieldName = fieldName Then
                    sortField.SortOrder = If(sortField.SortOrder = XRColumnSortOrder.Ascending, XRColumnSortOrder.Descending, XRColumnSortOrder.Ascending)
                    Return
                End If
            End Sub)
        Else
            If SortedColumns.Count = 1 AndAlso SortedColumns(0).FieldName = fieldName Then
                SortedColumns(0).SortOrder = If(SortedColumns(0).SortOrder = XRColumnSortOrder.Ascending, XRColumnSortOrder.Descending, XRColumnSortOrder.Ascending)
            Else
                SortedColumns.Clear()
            End If
        End If
        SortedColumns.Add(New GroupField(fieldName, XRColumnSortOrder.Ascending))
    End Sub

    Private Sub ProductsReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Detail.SortFields.Clear()
        Detail.SortFields.AddRange(SortedColumns.ToArray())
    End Sub

    Private Sub HeaderCell_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles tcProductNameHeader.BeforePrint, tcCategoryNameHeader.BeforePrint, tcCompanyNameHeader.BeforePrint, tcContactNameHeader.BeforePrint, tcUnitPriceHeader.BeforePrint, tcUnitsInStockHeader.BeforePrint, tcUnitsOnOrderHeader.BeforePrint, tcDiscontinuedHeader.BeforePrint
        Dim headerCell As XRLabel = TryCast(sender, XRLabel)
        Dim fieldName As String = CStr(headerCell.Tag)
        Dim sort As GroupField = SortedColumns.Find(Function(sortField) sortField.FieldName = fieldName)

        headerCell.Text = headerCell.Text.Replace(SortedColumnSuffix_Ascending, "")
        headerCell.Text = headerCell.Text.Replace(SortedColumnSuffix_Descending, "")
        If sort IsNot Nothing Then
            headerCell.Text += If(sort.SortOrder = XRColumnSortOrder.Ascending, SortedColumnSuffix_Ascending, SortedColumnSuffix_Descending)
        End If
    End Sub

    Private Sub HeaderCell_HtmlItemCreated(ByVal sender As Object, ByVal e As HtmlEventArgs) Handles tcProductNameHeader.HtmlItemCreated, tcCategoryNameHeader.HtmlItemCreated, tcCompanyNameHeader.HtmlItemCreated, tcContactNameHeader.HtmlItemCreated, tcUnitPriceHeader.HtmlItemCreated, tcUnitsInStockHeader.HtmlItemCreated, tcUnitsOnOrderHeader.HtmlItemCreated, tcDiscontinuedHeader.HtmlItemCreated
        e.ContentCell.Attributes.Add("onclick", String.Format("parent.ProductsReport_HeaderClick(this, event, '{0}')", e.Brick.Value))
        e.ContentCell.Style.Add("cursor", "pointer")
    End Sub
End Class
