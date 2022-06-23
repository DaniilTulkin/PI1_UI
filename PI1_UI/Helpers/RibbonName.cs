namespace PI1_UI
{
    /// <summary>
    /// Class for specified ribbon name type.
    /// </summary>
    public static class RibbonName
    {
        /// <summary>
        /// Names of specified ribbon name type.
        /// </summary>
        /// <param name="ribbonNameType">Type of the ribbon name.</param>
        /// <returns></returns>
        public static string Name(RibbonNameType ribbonNameType)
        {
            switch (ribbonNameType)
            {
                case RibbonNameType.AR:
                    return "АР";
                case RibbonNameType.KR:
                    return "КР";
                case RibbonNameType.MEP:
                    return "MEP";
                case RibbonNameType.Instruments:
                    return "Инструменты";
                default:
                    return string.Empty;
            }
        }
    }
}
