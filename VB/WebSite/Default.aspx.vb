Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub сallbackPanel_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase)
		Dim parameters() As String = e.Parameter.Split("|"c)
		Dim fieldName As String = parameters(0)
		Dim isShiftKeyPressed As Boolean = Boolean.Parse(parameters(1))
		ProductsReport.SortBy(fieldName, isShiftKeyPressed)
	End Sub
End Class