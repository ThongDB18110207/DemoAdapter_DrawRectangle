using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAdapter_DrawRectangle.Legacy
{
    internal class LegacyLine
    {
        internal void Draw(Panel area, Pen pen, int x1, int y1, int x2, int y2)
        {
            Graphics formGraphics;
            formGraphics = area.CreateGraphics();
            formGraphics.DrawLine(pen, x1, y1, x2, y2);
            pen.Dispose();
            formGraphics.Dispose();
        }
    }
}
