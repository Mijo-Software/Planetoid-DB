using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VS2008StripRenderingLibrary
{
	/// <summary>
	/// 
	/// </summary>
	public class VS2008ToolStripContainer : ToolStripContainer
	{
		/// <summary>
		/// 
		/// </summary>
		public VS2008ToolStripContainer()
		{
			TopToolStripPanel.Paint += new PaintEventHandler(TopToolStripPanel_Paint);
			TopToolStripPanel.SizeChanged += new EventHandler(TopToolStripPanel_SizeChanged);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TopToolStripPanel_SizeChanged(object sender, EventArgs e) => Invalidate();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TopToolStripPanel_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			Rectangle rect = new Rectangle(x: 0, y: 0, width: Width, height: FindForm().Height);
			using (LinearGradientBrush b = new LinearGradientBrush(rect: rect, color1: ClsColor.clrHorBG_GrayBlue, color2: ClsColor.clrHorBG_White, linearGradientMode: LinearGradientMode.Horizontal))
			{
				g.FillRectangle(brush: b, rect: rect);
			}
		}
	}
}
