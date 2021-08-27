<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598371/14.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E922)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[ProductsReport.cs](./CS/App_Code/ProductsReport.cs) (VB: [ProductsReport.vb](./VB/App_Code/ProductsReport.vb))**
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to add sort capability to the web based XtraReport
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e922/)**
<!-- run online end -->


<p>This example illustrates how to add, and force to work, sorting option buttons to the header area of the web based report. Some key points of this example:</p>
<p>- Sorting is accomplished during the callback, which prevents full page post back (AJAX-oriented behavior).<br /> - Callback raised from the client side by the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxCallbackPanelScriptsASPxClientCallbackPanel_PerformCallbacktopic"><u>ASPxClientCallbackPanel.PerformCallback</u></a> method.<br /> - FieldName of the column, on which the sorting action should take place and the Shift key pressed state is passed to the server as a callback parameter.<br /> - XtraReport.HtmlItemCreated event handled, in order to insert sorting option buttons to the report header via the HtmlEventArgs.ContentCell parameter.</p>

<br/>


