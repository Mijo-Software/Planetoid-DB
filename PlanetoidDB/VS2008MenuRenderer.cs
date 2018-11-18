using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VS2008StripRenderingLibrary
{
	/// <summary>
	/// 
	/// </summary>
	public class VS2008MenuRenderer : ToolStripRenderer
	{
		/// <summary>
		/// Make sure the textcolor is black
		/// </summary>
		/// <param name="item"></param>
		protected override void InitializeItem(ToolStripItem item)
		{
			base.InitializeItem(item: item);
			item.ForeColor = Color.Black;
    }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="toolStrip"></param>
		protected override void Initialize(ToolStrip toolStrip)
		{
			base.Initialize(toolStrip: toolStrip);
			toolStrip.ForeColor = Color.Black;
		}

		/// <summary>
		/// Render horizontal background gradient
		/// </summary>
		/// <param name="e"></param>
		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
		{
			base.OnRenderToolStripBackground(e);
			LinearGradientBrush b = new LinearGradientBrush(rect: e.AffectedBounds,
				color1: ClsColor.clrHorBG_GrayBlue, color2: ClsColor.clrHorBG_White,
				linearGradientMode: LinearGradientMode.Horizontal);
			e.Graphics.FillRectangle(brush: b, rect: e.AffectedBounds);
		}

		/// <summary>
		/// Render image margin and gray ItemBackground
		/// </summary>
		/// <param name="e"></param>
		protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
		{
			base.OnRenderImageMargin(e);

			// Draw ImageMargin background gradient
			LinearGradientBrush b = new LinearGradientBrush(rect: e.AffectedBounds, color1: ClsColor.clrImageMarginWhite, color2: ClsColor.clrImageMarginBlue, linearGradientMode: LinearGradientMode.Horizontal);

			// Shadow at the right of image margin
			SolidBrush DarkLine = new SolidBrush(color: ClsColor.clrImageMarginLine);
			SolidBrush WhiteLine = new SolidBrush(color: Color.White);
			Rectangle rect = new Rectangle(x: e.AffectedBounds.Width, y: 2, width: 1, height: e.AffectedBounds.Height);
			Rectangle rect2 = new Rectangle(x: e.AffectedBounds.Width + 1, y: 2, width: 1, height: e.AffectedBounds.Height);

			// Gray background
			SolidBrush SubmenuBGbrush = new SolidBrush(color: ClsColor.clrSubmenuBG);
			Rectangle rect3 = new Rectangle(x: 0, y: 0, width: e.ToolStrip.Width, height: e.ToolStrip.Height);

			// Border
			Pen borderPen = new Pen(color: ClsColor.clrMenuBorder);
			Rectangle rect4 = new Rectangle(x: 0, y: 1, width: e.ToolStrip.Width - 1, height: e.ToolStrip.Height - 2);
			e.Graphics.FillRectangle(brush: SubmenuBGbrush, rect: rect3);
			e.Graphics.FillRectangle(brush: b, rect: e.AffectedBounds);
			e.Graphics.FillRectangle(brush: DarkLine, rect: rect);
			e.Graphics.FillRectangle(brush: WhiteLine, rect: rect2);
			e.Graphics.DrawRectangle(pen: borderPen, rect: rect4);
		}

		/// <summary>
		/// Render checkmark
		/// </summary>
		/// <param name="e"></param>
		protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
		{
			base.OnRenderItemCheck(e);
			if (e.Item.Selected)
			{
				// todo: Code can be reduced
				Rectangle rect = new Rectangle(x: 3, y: 1, width: 20, height: 20);
				Rectangle rect2 = new Rectangle(x: 4, y: 2, width: 18, height: 18);
				SolidBrush b = new SolidBrush(color: ClsColor.clrToolstripBtn_Border);
				SolidBrush b2 = new SolidBrush(color: ClsColor.clrCheckBG);
				e.Graphics.FillRectangle(brush: b, rect: rect);
				e.Graphics.FillRectangle(brush: b2, rect: rect2);
				e.Graphics.DrawImage(image: e.Image, point: new Point(x: 5, y: 3));
			} else {
				Rectangle rect = new Rectangle(x: 3, y: 1, width: 20, height: 20);
				Rectangle rect2 = new Rectangle(x: 4, y: 2, width: 18, height: 18);
				SolidBrush b = new SolidBrush(color: ClsColor.clrSelectedBG_Drop_Border);
				SolidBrush b2 = new SolidBrush(color: ClsColor.clrCheckBG);
				e.Graphics.FillRectangle(brush: b, rect: rect);
				e.Graphics.FillRectangle(brush: b2, rect: rect2);
				e.Graphics.DrawImage(image: e.Image, point: new Point(x: 5, y: 3));
			}
		}

		/// <summary>
		/// Render separator
		/// </summary>
		/// <param name="e"></param>
		protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
		{
			base.OnRenderSeparator(e);
			SolidBrush DarkLine = new SolidBrush(color: ClsColor.clrImageMarginLine);
			SolidBrush WhiteLine = new SolidBrush(color: Color.White);
			Rectangle rect = new Rectangle(x: 32, y: 3, width: e.Item.Width - 32, height: 1);
			e.Graphics.FillRectangle(brush: DarkLine, rect: rect);
			e.Graphics.FillRectangle(brush: WhiteLine, rect: rect);
		}

		/// <summary>
		/// Render arrow
		/// </summary>
		/// <param name="e"></param>
		protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
		{
			e.ArrowColor = Color.Black;
			base.OnRenderArrow(e);
		}

		/// <summary>
		/// Render  MenuItem background: lightblue if selected, darkblue if dropped down
		/// </summary>
		/// <param name="e"></param>
		protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
		{
      base.OnRenderMenuItemBackground(e);
			if (e.Item.Enabled)
			{
				if (e.Item.IsOnDropDown == false && e.Item.Selected)
				{
					// If item is MenuHeader and selected: draw darkblue color
					Rectangle rect = new Rectangle(x: 3, y: 2, width: e.Item.Width - 6, height: e.Item.Height - 4);
					using (LinearGradientBrush b = new LinearGradientBrush(rect: rect, color1: ClsColor.clrSelectedBG_White, color2: ClsColor.clrSelectedBG_Header_Blue, linearGradientMode: LinearGradientMode.Vertical))
					{
						using (SolidBrush b2 = new SolidBrush(color: ClsColor.clrCheckBG))
						{
							e.Graphics.FillRectangle(brush: b, rect: rect);
							ClsColor.DrawRoundedRectangle(g: e.Graphics, x: rect.Left - 1, y: rect.Top - 1, width: rect.Width, height: rect.Height + 1, m_diameter: 4, color: ClsColor.clrToolstripBtn_Border);
							ClsColor.DrawRoundedRectangle(g: e.Graphics, x: rect.Left - 2, y: rect.Top - 2, width: rect.Width + 2, height: rect.Height + 3, m_diameter: 4, color: Color.White);
							e.Item.ForeColor = Color.Black;
						}
					}
				} else if (e.Item.IsOnDropDown && e.Item.Selected) {
					// If item is NOT menuheader (but subitem); and selected: draw lightblue border
					Rectangle rect = new Rectangle(x: 4, y: 2, width: e.Item.Width - 6, height: e.Item.Height - 4);
					using (LinearGradientBrush b = new LinearGradientBrush(rect: rect, color1: ClsColor.clrSelectedBG_White, color2: ClsColor.clrSelectedBG_Blue, linearGradientMode: LinearGradientMode.Vertical))
					{
						using (SolidBrush b2 = new SolidBrush(color: ClsColor.clrSelectedBG_Border))
						{
							e.Graphics.FillRectangle(brush: b, rect: rect);
							ClsColor.DrawRoundedRectangle(g: e.Graphics,
								x: rect.Left - 1, y: rect.Top - 1, width: rect.Width,
								height: rect.Height + 1, m_diameter: 6, color: ClsColor.clrSelectedBG_Border);
							e.Item.ForeColor = Color.Black;
						}
					}
				}
				// If item is MenuHeader and menu is dropped down; selection rectangle is now darker
				if ((e.Item as ToolStripMenuItem).DropDown.Visible && e.Item.IsOnDropDown == false)
				{
					// (e.Item as ToolStripMenuItem).OwnerItem == null
					Rectangle rect = new Rectangle(x: 3, y: 2, width: e.Item.Width - 6, height: e.Item.Height - 4);
					using (LinearGradientBrush b = new LinearGradientBrush(rect: rect, color1: Color.White, color2: ClsColor.clrSelectedBG_Drop_Blue, linearGradientMode: LinearGradientMode.Vertical))
					{
						using (SolidBrush b2 = new SolidBrush(color: ClsColor.clrSelectedBG_Drop_Border))
						{
							e.Graphics.FillRectangle(brush: b, rect: rect);
							ClsColor.DrawRoundedRectangle(
								g: e.Graphics, x: rect.Left - 1, y: rect.Top - 1, width: rect.Width, height: rect.Height + 1,
								m_diameter: 4, color: ClsColor.clrSelectedBG_Drop_Border);
							ClsColor.DrawRoundedRectangle(g: e.Graphics, x: rect.Left - 2, y: rect.Top - 2, width: rect.Width + 2, height: rect.Height + 3, m_diameter: 4, color: Color.White);
							e.Item.ForeColor = Color.Black;
						}
					}
				}
			}
		}
	}
}
    
