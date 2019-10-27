using System.Windows.Forms;

namespace VS2008StripRenderingLibrary
{
	/// <summary>
	/// 
	/// </summary>
	public class VS2008ToolStrip : ToolStrip
	{
		/// <summary>
		/// 
		/// </summary>
		public VS2008ToolStrip() => Renderer = new VS2008ToolStripRenderer();
	}
}
