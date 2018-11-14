using System.Windows.Forms;

namespace VS2008StripRenderingLibrary {
    public class VS2008MenuStrip : MenuStrip {
        public VS2008MenuStrip() {
            this.Renderer = new VS2008MenuRenderer();
        }
    }

    public class VS2008ContextMenuStrip : ContextMenuStrip {
        public VS2008ContextMenuStrip() {
            this.Renderer = new VS2008MenuRenderer();
        }
    }
}
