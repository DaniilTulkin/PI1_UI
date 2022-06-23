using Autodesk.Revit.UI;

namespace PI1_UI
{
    public class RevitPushButtonData
    {
        #region public members

        /// <summary>
        /// Gets or sets the label of the button.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the panel on wich the button is hosted.
        /// </summary>
        /// <value>
        /// The panel.
        /// </value>
        public RibbonPanel Panel { get; set; }

        /// <summary>
        /// Gets or sets the command namespace path.
        /// </summary>
        /// <value>
        /// The command namespace path.
        /// </value>
        public string CommandNamespacePath { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public string ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the name of the image.
        /// </summary>
        /// <value>
        /// The name of the image.
        /// </value>
        public string ImageName { get; set; }

        /// <summary>
        /// Gets or sets the name of the icon image.
        /// </summary>
        /// <value>
        /// The name of the icon image.
        /// </value>
        public string LargeImageName { get; set; }

        /// <summary>
        /// Gets or sets the name of the tool tip image.
        /// </summary>
        /// <value>
        /// The name of the tool tip image.
        /// </value>
        public string ToolTipImageName { get; set; }

        #endregion

        #region constructor

        /// <summary>
        /// Default constructor.
        /// Initializes a new instance of the <see cref="RevitPushButtonData"/> class.
        /// </summary>
        public RevitPushButtonData()
        {

        }

        #endregion
    }
}
