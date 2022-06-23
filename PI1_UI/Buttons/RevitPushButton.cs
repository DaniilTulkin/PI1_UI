using Autodesk.Revit.UI;
using System;
using PI1_CORE;
using PI1_RES;

namespace PI1_UI
{

    /// <summary>
    /// Push button class.
    /// </summary>
    public class RevitPushButton
    {
        #region public methods

        public static PushButton Create(RevitPushButtonData data)
        {
            // The button name based on unique identifier.
            var btnDataName = Guid.NewGuid().ToString();

            // Sets the button data.
            var btnData = new PushButtonData(btnDataName, data.Label, AssemblyLocation.GetAssemblyLocation(), data.CommandNamespacePath)
            {
                ToolTip = data.ToolTip,
                Image = ResourceImage.GetIcon(data.ImageName),
                LargeImage = ResourceImage.GetIcon(data.LargeImageName),
                //ToolTipImage = ResourceImage.GetIcon(data.ToolTipImageName)
            };

            // Return created button and host it on panel
            return data.Panel.AddItem(btnData) as PushButton;
        }

        #endregion
    }
}
