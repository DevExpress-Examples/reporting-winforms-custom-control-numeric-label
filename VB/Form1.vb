#Region "usings"
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
Imports System
Imports System.Drawing.Design
Imports System.Windows.Forms
#End Region

Namespace WinFormsApp_CustomNumericLabel
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			ShowDesignerWithCustomControl()
		End Sub
		#Region "ShowDesignerWithCustomControl"
		Private Sub ShowDesignerWithCustomControl()
			' Creates a Design Tool instance with the specified report instance.
			Dim designTool As New ReportDesignTool(New XtraReport1())
			Dim designForm As IDesignForm = designTool.DesignForm
			AddHandler designForm.DesignMdiController.DesignPanelLoaded, AddressOf DesignMdiController_DesignPanelLoaded
			designTool.ShowDesigner()
		End Sub

		Private Sub DesignMdiController_DesignPanelLoaded(ByVal sender As Object, ByVal e As DesignerLoadedEventArgs)
			Dim toolboxService As IToolboxService = DirectCast(e.DesignerHost.GetService(GetType(IToolboxService)), IToolboxService)
			' Removes the XRLabel toolbox item.
			toolboxService.RemoveToolboxItem(GetToolBoxControl(toolboxService, "DevExpress.XtraReports.UI.XRLabel"))
			' Creates a new toolbox item for the custom control.
			Dim numericLabelItem As New ToolboxItem(GetType(NumericLabel)) With {.DisplayName = "Numeric Label"}
			' Adds the new control to the toolbox.
			toolboxService.AddToolboxItem(numericLabelItem)
		End Sub

		Private Function GetToolBoxControl(ByVal toolboxService As IToolboxService, ByVal name As String) As ToolboxItem
			For Each item As ToolboxItem In toolboxService.GetToolboxItems()
				If item.TypeName = name Then
					Return item
				End If
			Next item
			Return Nothing
		End Function
		#End Region
	End Class
End Namespace
