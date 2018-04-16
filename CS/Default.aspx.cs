using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void сallbackPanel_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e) {
        string[] parameters = e.Parameter.Split('|');
        string fieldName = parameters[0];
        bool isShiftKeyPressed = Boolean.Parse(parameters[1]);
        ProductsReport.SortBy(fieldName, isShiftKeyPressed);
    }
}