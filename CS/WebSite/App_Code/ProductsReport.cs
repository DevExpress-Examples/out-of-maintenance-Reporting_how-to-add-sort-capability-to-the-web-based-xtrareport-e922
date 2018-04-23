using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for ProductsReport
/// </summary>
public class ProductsReport : DevExpress.XtraReports.UI.XtraReport {
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private NWindDataSet nWindDataSet1;
    private NWindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
    private XRTable tbDataRow;
    private XRTableRow tdDataRow;
    private XRTableCell tcProductName;
    private XRTableCell tcCategoryName;
    private XRTableCell tcCompanyName;
    private XRTableCell tcContactName;
    private XRTableCell tcUnitPrice;
    private XRTableCell tcUnitInStock;
    private XRTableCell tcUnitsOnOrder;
    private XRTableCell tcDiscontinued;
    private XRCheckBox cbDiscontinued;
    private GroupHeaderBand GroupHeader;
    private XRTable tbHeader;
    private XRTableRow trHeader;
    private XRTableCell tcProductNameHeader;
    private XRTableCell tcCategoryNameHeader;
    private XRTableCell tcCompanyNameHeader;
    private XRTableCell tcContactNameHeader;
    private XRTableCell tcUnitPriceHeader;
    private XRTableCell tcUnitsInStockHeader;
    private XRTableCell tcUnitsOnOrderHeader;
    private XRTableCell tcDiscontinuedHeader;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    const string SortedColumnSuffix_Ascending = " ▼";
    const string SortedColumnSuffix_Descending = " ▲";
    const string SortedColumns_SessionKey = "ProductsReport_SortedColumns";

    private static List<GroupField> _sortedColumns = null;

    public static List<GroupField> SortedColumns {
        get {
            if (_sortedColumns == null) {
                _sortedColumns = (List<GroupField>) HttpContext.Current.Session[SortedColumns_SessionKey];
                if (_sortedColumns == null) {
                    _sortedColumns = new List<GroupField>();
                    HttpContext.Current.Session[SortedColumns_SessionKey] = _sortedColumns;
                }
            }
            return _sortedColumns;
        }
    }

    public ProductsReport() {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            string resourceFileName = "ProductsReport.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.tbDataRow = new DevExpress.XtraReports.UI.XRTable();
            this.tdDataRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.tcProductName = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcCategoryName = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcCompanyName = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcContactName = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitInStock = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitsOnOrder = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcDiscontinued = new DevExpress.XtraReports.UI.XRTableCell();
            this.cbDiscontinued = new DevExpress.XtraReports.UI.XRCheckBox();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.nWindDataSet1 = new NWindDataSet();
            this.productsTableAdapter1 = new NWindDataSetTableAdapters.ProductsTableAdapter();
            this.GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.tbHeader = new DevExpress.XtraReports.UI.XRTable();
            this.trHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.tcProductNameHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcCategoryNameHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcCompanyNameHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcContactNameHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitPriceHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitsInStockHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitsOnOrderHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcDiscontinuedHeader = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.tbDataRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbDataRow});
            this.Detail.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100F);
            this.Detail.StylePriority.UseBorders = false;
            this.Detail.StylePriority.UseFont = false;
            this.Detail.StylePriority.UsePadding = false;
            this.Detail.StylePriority.UseTextAlignment = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tbDataRow
            // 
            this.tbDataRow.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tbDataRow.Name = "tbDataRow";
            this.tbDataRow.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tdDataRow});
            this.tbDataRow.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tdDataRow
            // 
            this.tdDataRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcProductName,
            this.tcCategoryName,
            this.tcCompanyName,
            this.tcContactName,
            this.tcUnitPrice,
            this.tcUnitInStock,
            this.tcUnitsOnOrder,
            this.tcDiscontinued});
            this.tdDataRow.Name = "tdDataRow";
            this.tdDataRow.Weight = 1D;
            // 
            // tcProductName
            // 
            this.tcProductName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.ProductName")});
            this.tcProductName.Name = "tcProductName";
            this.tcProductName.Weight = 1.5D;
            // 
            // tcCategoryName
            // 
            this.tcCategoryName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.CategoryName")});
            this.tcCategoryName.Name = "tcCategoryName";
            this.tcCategoryName.Text = "tcCategoryName";
            this.tcCategoryName.Weight = 1D;
            // 
            // tcCompanyName
            // 
            this.tcCompanyName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.CompanyName")});
            this.tcCompanyName.Name = "tcCompanyName";
            this.tcCompanyName.Text = "tcCompanyName";
            this.tcCompanyName.Weight = 1D;
            // 
            // tcContactName
            // 
            this.tcContactName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.ContactName")});
            this.tcContactName.Name = "tcContactName";
            this.tcContactName.Text = "tcContactName";
            this.tcContactName.Weight = 1.5D;
            // 
            // tcUnitPrice
            // 
            this.tcUnitPrice.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.UnitPrice", "{0:c}")});
            this.tcUnitPrice.Name = "tcUnitPrice";
            this.tcUnitPrice.StylePriority.UseTextAlignment = false;
            this.tcUnitPrice.Text = "tcUnitPrice";
            this.tcUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.tcUnitPrice.Weight = 1D;
            // 
            // tcUnitInStock
            // 
            this.tcUnitInStock.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.UnitsInStock")});
            this.tcUnitInStock.Name = "tcUnitInStock";
            this.tcUnitInStock.StylePriority.UseTextAlignment = false;
            this.tcUnitInStock.Text = "tcUnitInStock";
            this.tcUnitInStock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.tcUnitInStock.Weight = 1D;
            // 
            // tcUnitsOnOrder
            // 
            this.tcUnitsOnOrder.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.UnitsOnOrder")});
            this.tcUnitsOnOrder.Name = "tcUnitsOnOrder";
            this.tcUnitsOnOrder.StylePriority.UseTextAlignment = false;
            this.tcUnitsOnOrder.Text = "tcUnitsOnOrder";
            this.tcUnitsOnOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.tcUnitsOnOrder.Weight = 0.99999999999999989D;
            // 
            // tcDiscontinued
            // 
            this.tcDiscontinued.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.cbDiscontinued});
            this.tcDiscontinued.Name = "tcDiscontinued";
            this.tcDiscontinued.Text = "tcDiscontinued";
            this.tcDiscontinued.Weight = 1D;
            // 
            // cbDiscontinued
            // 
            this.cbDiscontinued.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.cbDiscontinued.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.cbDiscontinued.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("CheckState", null, "Products.Discontinued")});
            this.cbDiscontinued.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbDiscontinued.LocationFloat = new DevExpress.Utils.PointFloat(2F, 1.999982F);
            this.cbDiscontinued.Name = "cbDiscontinued";
            this.cbDiscontinued.SizeF = new System.Drawing.SizeF(96F, 21F);
            this.cbDiscontinued.StylePriority.UseBorders = false;
            this.cbDiscontinued.Text = "cbDiscontinued";
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nWindDataSet1
            // 
            this.nWindDataSet1.DataSetName = "NWindDataSet";
            this.nWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // GroupHeader
            // 
            this.GroupHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbHeader});
            this.GroupHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.GroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader.HeightF = 25F;
            this.GroupHeader.Name = "GroupHeader";
            this.GroupHeader.RepeatEveryPage = true;
            this.GroupHeader.StylePriority.UseBorders = false;
            this.GroupHeader.StylePriority.UseFont = false;
            this.GroupHeader.StylePriority.UseTextAlignment = false;
            this.GroupHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // tbHeader
            // 
            this.tbHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tbHeader.Name = "tbHeader";
            this.tbHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.trHeader});
            this.tbHeader.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // trHeader
            // 
            this.trHeader.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcProductNameHeader,
            this.tcCategoryNameHeader,
            this.tcCompanyNameHeader,
            this.tcContactNameHeader,
            this.tcUnitPriceHeader,
            this.tcUnitsInStockHeader,
            this.tcUnitsOnOrderHeader,
            this.tcDiscontinuedHeader});
            this.trHeader.Name = "trHeader";
            this.trHeader.Weight = 1D;
            // 
            // tcProductNameHeader
            // 
            this.tcProductNameHeader.Name = "tcProductNameHeader";
            this.tcProductNameHeader.Tag = "ProductName";
            this.tcProductNameHeader.Text = "Product";
            this.tcProductNameHeader.Weight = 1.5D;
            this.tcProductNameHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.HeaderCell_BeforePrint);
            this.tcProductNameHeader.HtmlItemCreated += new DevExpress.XtraReports.UI.HtmlEventHandler(this.HeaderCell_HtmlItemCreated);
            // 
            // tcCategoryNameHeader
            // 
            this.tcCategoryNameHeader.Name = "tcCategoryNameHeader";
            this.tcCategoryNameHeader.Tag = "CategoryName";
            this.tcCategoryNameHeader.Text = "Category";
            this.tcCategoryNameHeader.Weight = 1D;
            this.tcCategoryNameHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.HeaderCell_BeforePrint);
            this.tcCategoryNameHeader.HtmlItemCreated += new DevExpress.XtraReports.UI.HtmlEventHandler(this.HeaderCell_HtmlItemCreated);
            // 
            // tcCompanyNameHeader
            // 
            this.tcCompanyNameHeader.Name = "tcCompanyNameHeader";
            this.tcCompanyNameHeader.Tag = "CompanyName";
            this.tcCompanyNameHeader.Text = "Company";
            this.tcCompanyNameHeader.Weight = 1D;
            this.tcCompanyNameHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.HeaderCell_BeforePrint);
            this.tcCompanyNameHeader.HtmlItemCreated += new DevExpress.XtraReports.UI.HtmlEventHandler(this.HeaderCell_HtmlItemCreated);
            // 
            // tcContactNameHeader
            // 
            this.tcContactNameHeader.Name = "tcContactNameHeader";
            this.tcContactNameHeader.Tag = "ContactName";
            this.tcContactNameHeader.Text = "Contact";
            this.tcContactNameHeader.Weight = 1.5D;
            this.tcContactNameHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.HeaderCell_BeforePrint);
            this.tcContactNameHeader.HtmlItemCreated += new DevExpress.XtraReports.UI.HtmlEventHandler(this.HeaderCell_HtmlItemCreated);
            // 
            // tcUnitPriceHeader
            // 
            this.tcUnitPriceHeader.Name = "tcUnitPriceHeader";
            this.tcUnitPriceHeader.StylePriority.UseTextAlignment = false;
            this.tcUnitPriceHeader.Tag = "UnitPrice";
            this.tcUnitPriceHeader.Text = "Price";
            this.tcUnitPriceHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.tcUnitPriceHeader.Weight = 1D;
            this.tcUnitPriceHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.HeaderCell_BeforePrint);
            this.tcUnitPriceHeader.HtmlItemCreated += new DevExpress.XtraReports.UI.HtmlEventHandler(this.HeaderCell_HtmlItemCreated);
            // 
            // tcUnitsInStockHeader
            // 
            this.tcUnitsInStockHeader.Name = "tcUnitsInStockHeader";
            this.tcUnitsInStockHeader.StylePriority.UseTextAlignment = false;
            this.tcUnitsInStockHeader.Tag = "UnitsInStock";
            this.tcUnitsInStockHeader.Text = "In Stock";
            this.tcUnitsInStockHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.tcUnitsInStockHeader.Weight = 1D;
            this.tcUnitsInStockHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.HeaderCell_BeforePrint);
            this.tcUnitsInStockHeader.HtmlItemCreated += new DevExpress.XtraReports.UI.HtmlEventHandler(this.HeaderCell_HtmlItemCreated);
            // 
            // tcUnitsOnOrderHeader
            // 
            this.tcUnitsOnOrderHeader.Name = "tcUnitsOnOrderHeader";
            this.tcUnitsOnOrderHeader.StylePriority.UseTextAlignment = false;
            this.tcUnitsOnOrderHeader.Tag = "UnitsOnOrder";
            this.tcUnitsOnOrderHeader.Text = "On Order";
            this.tcUnitsOnOrderHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.tcUnitsOnOrderHeader.Weight = 0.99999999999999989D;
            this.tcUnitsOnOrderHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.HeaderCell_BeforePrint);
            this.tcUnitsOnOrderHeader.HtmlItemCreated += new DevExpress.XtraReports.UI.HtmlEventHandler(this.HeaderCell_HtmlItemCreated);
            // 
            // tcDiscontinuedHeader
            // 
            this.tcDiscontinuedHeader.Name = "tcDiscontinuedHeader";
            this.tcDiscontinuedHeader.Tag = "Discontinued";
            this.tcDiscontinuedHeader.Text = "Discont.";
            this.tcDiscontinuedHeader.Weight = 1D;
            this.tcDiscontinuedHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.HeaderCell_BeforePrint);
            this.tcDiscontinuedHeader.HtmlItemCreated += new DevExpress.XtraReports.UI.HtmlEventHandler(this.HeaderCell_HtmlItemCreated);
            // 
            // ProductsReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader});
            this.DataAdapter = this.productsTableAdapter1;
            this.DataMember = "Products";
            this.DataSource = this.nWindDataSet1;
            this.Landscape = true;
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Version = "13.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ProductsReport_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.tbDataRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    public static void SortBy(string fieldName, bool isAdding) {        
        if (isAdding) {
            SortedColumns.ForEach(sortField => {
                if (sortField.FieldName == fieldName) {
                    sortField.SortOrder = (sortField.SortOrder == XRColumnSortOrder.Ascending) ? XRColumnSortOrder.Descending : XRColumnSortOrder.Ascending;
                    return;
                }
            });
        }
        else {
            if (SortedColumns.Count == 1 && SortedColumns[0].FieldName == fieldName) {
                SortedColumns[0].SortOrder = (SortedColumns[0].SortOrder == XRColumnSortOrder.Ascending) ? XRColumnSortOrder.Descending : XRColumnSortOrder.Ascending;
            }
            else {
                SortedColumns.Clear();
            }
        }
        SortedColumns.Add(new GroupField(fieldName, XRColumnSortOrder.Ascending));
    }

    private void ProductsReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
        Detail.SortFields.Clear();
        Detail.SortFields.AddRange(SortedColumns.ToArray());
    }

    private void HeaderCell_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
        XRLabel headerCell = sender as XRLabel;
        string fieldName = (string) headerCell.Tag;
        GroupField sort = SortedColumns.Find(sortField => sortField.FieldName == fieldName);

        headerCell.Text = headerCell.Text.Replace(SortedColumnSuffix_Ascending, "");
        headerCell.Text = headerCell.Text.Replace(SortedColumnSuffix_Descending, "");
        if (sort != null) {
            headerCell.Text += (sort.SortOrder == XRColumnSortOrder.Ascending) 
                ? SortedColumnSuffix_Ascending 
                : SortedColumnSuffix_Descending;
        }
    }

    private void HeaderCell_HtmlItemCreated(object sender, HtmlEventArgs e) {
        e.ContentCell.Attributes.Add("onclick", String.Format("parent.ProductsReport_HeaderClick(this, event, '{0}')", e.Brick.Value));
        e.ContentCell.Style.Add("cursor", "pointer");
    }    
}
