using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VS2008StripRenderingLibrary {
    public class VS2008ToolStripContainer : ToolStripContainer {
        public VS2008ToolStripContainer() {
            this.TopToolStripPanel.Paint += new PaintEventHandler(TopToolStripPanel_Paint);
            this.TopToolStripPanel.SizeChanged += new EventHandler(TopToolStripPanel_SizeChanged);
        }

        void TopToolStripPanel_SizeChanged(object sender, EventArgs e) {
            this.Invalidate();
        }

        void TopToolStripPanel_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            var rect = new Rectangle(0, 0, this.Width, this.FindForm().Height);
            using (LinearGradientBrush b = new LinearGradientBrush(
                rect, clsColor.clrHorBG_GrayBlue, clsColor.clrHorBG_White, LinearGradientMode.Horizontal)) {
                g.FillRectangle(b, rect);
            }
        }
    }
}
