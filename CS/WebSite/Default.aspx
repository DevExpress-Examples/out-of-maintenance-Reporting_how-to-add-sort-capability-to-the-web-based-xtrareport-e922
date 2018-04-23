<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function ProductsReport_HeaderClick(s, e, fieldName) {
            сallbackPanel.PerformCallback(fieldName + '|' + e.shiftKey);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxCallbackPanel ID="сallbackPanel" runat="server" Width="100%" 
            ClientInstanceName="сallbackPanel" oncallback="сallbackPanel_Callback">
            <PanelCollection>
                <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                    <dx:ASPxDocumentViewer ID="documentViewer" runat="server" ReportTypeName="ProductsReport">
                        <StylesViewer>
                            <BookmarkSelectionBorder BorderColor="Gray" BorderStyle="Dashed" BorderWidth="3px" />
                        </StylesViewer>
                        <StylesSplitter>
                            <Pane>
                                <Paddings Padding="16px" />
                            </Pane>
                        </StylesSplitter>
                    </dx:ASPxDocumentViewer>
                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxCallbackPanel>
    </div>
    </form>
</body>
</html>
