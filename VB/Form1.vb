Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
Imports System.Drawing.Design

Namespace WinFormsApp_CustomNumericLabel
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' Create a Design Tool with an assigned report instance.
			Dim designTool As New ReportDesignTool(New XtraReport1())

			' Access the standard form.
			Dim designForm As IDesignForm = designTool.DesignForm

			' Handle the Design Panel's Loaded event.
			AddHandler designForm.DesignMdiController.DesignPanelLoaded, AddressOf DesignMdiController_DesignPanelLoaded

			' Load a Report Designer in a dialog window.
			designTool.ShowDesignerDialog()
		End Sub
		Private Sub DesignMdiController_DesignPanelLoaded(ByVal sender As Object, ByVal e As DesignerLoadedEventArgs)
			' Access the Toolbox service.
			Dim toolboxService As IToolboxService = DirectCast(e.DesignerHost.GetService(GetType(IToolboxService)), IToolboxService)

			' Create a new toolbox item for the custom control.
			Dim numericLabelItem As New ToolboxItem(GetType(NumericLabel))

			' Specify the control's name to be displayed in the toolbox.
			numericLabelItem.DisplayName = "Numeric Label"

			' Add the new control to the toolbox.
			toolboxService.AddToolboxItem(numericLabelItem)
		End Sub
	End Class
End Namespace
