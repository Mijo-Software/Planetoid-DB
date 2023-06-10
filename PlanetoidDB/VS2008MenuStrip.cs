using System.Windows.Forms;

namespace VS2008StripRenderingLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class VS2008MenuStrip : MenuStrip
    {
        /// <summary>
        /// 
        /// </summary>
        public VS2008MenuStrip() => Renderer = new VS2008MenuRenderer();
    }


    /// <summary>
    /// 
    /// </summary>
    public class VS2008ContextMenuStrip : ContextMenuStrip
    {
        /// <summary>
        /// 
        /// </summary>
        public VS2008ContextMenuStrip() => Renderer = new VS2008MenuRenderer();
    }
}
