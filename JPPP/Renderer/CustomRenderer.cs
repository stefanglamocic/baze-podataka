using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPPP.Renderer
{
    class CustomRenderer : ToolStripProfessionalRenderer
    {
        private class CustomColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Colors.selectedPanel; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Colors.selectedPanel; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Colors.selectedPanel; }
            }

            public override Color MenuItemBorder
            {
                get { return Colors.selectedPanel; }
            }
        }

        public CustomRenderer() : base(new CustomColors()) { }
    }
}
