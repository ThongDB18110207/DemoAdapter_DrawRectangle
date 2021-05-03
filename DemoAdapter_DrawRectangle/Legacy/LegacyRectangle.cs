using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAdapter_DrawRectangle.Legacy
{
    internal class LegacyRectangle
    {
        internal void Draw(Panel area, Pen pen, int x, int y, int width, int heigh)
        {
            Graphics formGraphics;
            formGraphics = area.CreateGraphics();
            formGraphics.DrawRectangle(pen, new Rectangle(x, y, width, heigh));
            pen.Dispose();
            formGraphics.Dispose();
        }
    }
}
