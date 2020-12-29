using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using System.Drawing.Design;

namespace WinFormsApp_CustomNumericLabel {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a Design Tool with an assigned report instance.
            ReportDesignTool designTool = new ReportDesignTool(new XtraReport1());

            // Access the standard form.
            IDesignForm designForm = designTool.DesignForm;

            // Handle the Design Panel's Loaded event.
            designForm.DesignMdiController.DesignPanelLoaded += DesignMdiController_DesignPanelLoaded;

            // Load a Report Designer in a dialog window.
            designTool.ShowDesignerDialog();
        }
        void DesignMdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e) {
            // Access the Toolbox service.
            IToolboxService toolboxService =
                (IToolboxService)e.DesignerHost.GetService(typeof(IToolboxService));

            // Create a new toolbox item for the custom control.
            ToolboxItem numericLabelItem = new ToolboxItem(typeof(NumericLabel));

            // Specify the control's name to be displayed in the toolbox.
            numericLabelItem.DisplayName = "Numeric Label";

            // Add the new control to the toolbox.
            toolboxService.AddToolboxItem(numericLabelItem);
        }
    }
}
