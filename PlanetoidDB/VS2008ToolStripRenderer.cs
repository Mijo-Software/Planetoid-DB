using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VS2008StripRenderingLibrary
{

	/// <summary>
	/// 
	/// </summary>
	public class VS2008ToolStripRenderer : ToolStripProfessionalRenderer
	{

		/// <summary>
		/// Render custom background gradient
		/// </summary>
		/// <param name="e"></param>
		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
		{
			base.OnRenderToolStripBackground(e);
			using (LinearGradientBrush b = new LinearGradientBrush(rect: e.AffectedBounds, color1: ClsColor.clrVerBG_White, color2: ClsColor.clrVerBG_GrayBlue, linearGradientMode: LinearGradientMode.Vertical))
			{
				using (SolidBrush shadow = new SolidBrush(color: ClsColor.clrVerBG_Shadow))
				{
					Rectangle rect = new Rectangle(x: 0, y: e.ToolStrip.Height - 2, width: e.ToolStrip.Width, height: 1);
					e.Graphics.FillRectangle(brush: b, rect: e.AffectedBounds);
					e.Graphics.FillRectangle(brush: shadow, rect: rect);
				}
			}
		}

		/// <summary>
		/// Render button selected and pressed state
		/// </summary>
		/// <param name="e"></param>
		protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
		{
			base.OnRenderButtonBackground(e);
			Rectangle rectBorder = new Rectangle(x: 0, y: 0, width: e.Item.Width - 1, height: e.Item.Height - 1);
			Rectangle rect = new Rectangle(x: 1, y: 1, width: e.Item.Width - 2, height: e.Item.Height - 2);
			if (e.Item.Selected == true || (e.Item as ToolStripButton).Checked)
			{
				using (LinearGradientBrush b = new LinearGradientBrush(rect: rect, color1: ClsColor.clrToolstripBtnGrad_White, color2: ClsColor.clrToolstripBtnGrad_Blue, linearGradientMode: LinearGradientMode.Vertical))
				{
					using (SolidBrush b2 = new SolidBrush(color: ClsColor.clrToolstripBtn_Border))
					{
						e.Graphics.FillRectangle(brush: b2, rect: rectBorder);
						e.Graphics.FillRectangle(brush: b, rect: rect);
					}
				}
			}
			if (e.Item.Pressed)
			{
				using (LinearGradientBrush b = new LinearGradientBrush(rect: rect, color1: ClsColor.clrToolstripBtnGrad_White_Pressed, color2: ClsColor.clrToolstripBtnGrad_Blue_Pressed, linearGradientMode: LinearGradientMode.Vertical))
				{
					using (SolidBrush b2 = new SolidBrush(color: ClsColor.clrToolstripBtn_Border))
					{
						e.Graphics.FillRectangle(brush: b2, rect: rectBorder);
						e.Graphics.FillRectangle(brush: b, rect: rect);
					}
				}
			}
		}
	}
}