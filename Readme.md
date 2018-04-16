# How to add sort capability to the web based XtraReport


<p>This example illustrates how to add, and force to work, sorting option buttons to the header area of the web based report. Some key points of this example:</p>
<p>- Sorting is accomplished during the callback, which prevents full page post back (AJAX-oriented behavior).<br /> - Callback raised from the client side by the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxCallbackPanelScriptsASPxClientCallbackPanel_PerformCallbacktopic"><u>ASPxClientCallbackPanel.PerformCallback</u></a> method.<br /> - FieldName of the column, on which the sorting action should take place and the Shift key pressed state is passed to the server as a callback parameter.<br /> - XtraReport.HtmlItemCreated event handled, in order to insert sorting option buttons to the report header via the HtmlEventArgs.ContentCell parameter.</p>

<br/>


