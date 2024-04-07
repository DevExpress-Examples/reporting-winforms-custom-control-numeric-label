using DevExpress.Utils.Serializing;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using DevExpress.XtraReports.Expressions;
using DevExpress.Utils.Design;

namespace WinFormsApp_CustomNumericLabel {
    [ToolboxItem(true)]
    [DefaultBindableProperty("Number")]
    [ToolboxSvgImage("WinFormsApp_CustomNumericLabel.NumericLabel.svg, WinFormsApp_CustomNumericLabel")]
    public class NumericLabel : XRLabel {
        [DefaultValue(0)]
        [XtraSerializableProperty]
        public int Number { get; set; }

        // Set the "Browsable" and "EditorBrowsable" attributes to "false" and "Never"
        // to hide the "Text" property from the "Properties" window and editor (IntelliSense).
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override string Text {
            get { return Number.ToString(); }
            set {
                int i;
                Number = (int.TryParse(value, out i)) ? i : 0;
            }
        }

        // Implement a static constructor as shown below to add
        // the "Number" property to the property grid's "Expressions" tab.
        static NumericLabel() {
            // Specify an array of events in which the property should be available.
            string[] eventNames = new string[] { "BeforePrint" };

            // Specify the property position in the property grid's "Expressions" tab.
            // 0 - first, 1000 - last.
            int position = 0;

            // Specify an array of the property's inner properties.
            string[] nestedBindableProperties = null;

            // Specify the property's category in the property grid's "Expressions" tab.
            // The empty string corresponds to the root category.
            string scopeName = "";

            // Create and set a description for the "Number" property.
            ExpressionBindingDescription description = new ExpressionBindingDescription(
                eventNames, position, nestedBindableProperties, scopeName
            );

            ExpressionBindingDescriptor.SetPropertyDescription(
                typeof(NumericLabel), nameof(Number), description
            );
        }
    }
}
