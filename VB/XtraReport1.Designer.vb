Namespace WinFormsApp_CustomNumericLabel
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

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
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.numericLabel1 = New WinFormsApp_CustomNumericLabel.NumericLabel()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.numericLabel1})
			Me.Detail.Name = "Detail"
			' 
			' numericLabel1
			' 
			Me.numericLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.numericLabel1.Multiline = True
			Me.numericLabel1.Name = "numericLabel1"
			Me.numericLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.numericLabel1.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.numericLabel1.Text = "0"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.Detail})
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.Version = "20.2"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private numericLabel1 As NumericLabel
	End Class
End Namespace
