using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAdapter_DrawRectangle.Legacy
{
    internal class LegacyCircle
    {
        internal void Draw(Panel area, Pen pen, int x, int y, int r)
        {
            Graphics formGraphics;
            formGraphics = area.CreateGraphics();
            int left_x = x - r;
            int top_y = y - r;
            formGraphics.DrawEllipse(pen, left_x, top_y, 2*r, 2*r);
            pen.Dispose();
            formGraphics.Dispose();
        }
    }
}
