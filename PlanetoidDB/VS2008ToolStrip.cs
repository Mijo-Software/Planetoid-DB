using System.Windows.Forms;

namespace VS2008StripRenderingLibrary {
    public class VS2008ToolStrip : ToolStrip {
        public VS2008ToolStrip() {
            this.Renderer = new VS2008ToolStripRenderer();
        }
    }
}
