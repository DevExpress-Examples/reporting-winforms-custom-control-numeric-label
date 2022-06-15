using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using System;
using System.Drawing.Design;
using System.Windows.Forms;

namespace WinFormsApp_CustomNumericLabel
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowDesignerWithCustomControl();
        }
        void ShowDesignerWithCustomControl()
        {
            // Creates a Design Tool instance with the specified report instance.
            ReportDesignTool designTool = new ReportDesignTool(new XtraReport1());
            IDesignForm designForm = designTool.DesignForm;
            designForm.DesignMdiController.DesignPanelLoaded += DesignMdiController_DesignPanelLoaded;
            designTool.ShowDesignerDialog();
        }

        void DesignMdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e) {
            IToolboxService toolboxService =
                (IToolboxService)e.DesignerHost.GetService(typeof(IToolboxService));
            // Removes the XRLabel toolbox item.
            toolboxService.RemoveToolboxItem(
                GetToolBoxControl(toolboxService, "DevExpress.XtraReports.UI.XRLabel"));
            // Creates a new toolbox item for the custom control.
            ToolboxItem numericLabelItem = new ToolboxItem(typeof(NumericLabel))
            {
                // Specifies the name in the toolbox.
                DisplayName = "Numeric Label"
            };
            // Adds the new control to the toolbox.
            toolboxService.AddToolboxItem(numericLabelItem);
        }

        ToolboxItem GetToolBoxControl(IToolboxService toolboxService, string name) {
            foreach (ToolboxItem item in toolboxService.GetToolboxItems()) {
                if (item.TypeName == name) { return item; };
            }
            return null;
        }
    }
}
