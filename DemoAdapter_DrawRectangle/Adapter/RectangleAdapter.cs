using DemoAdapter_DrawRectangle.Legacy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAdapter_DrawRectangle.Adapter
{
    internal class RectangleAdapter : IShape
    {
        private readonly LegacyRectangle _legacyRectangle;

        public RectangleAdapter(LegacyRectangle legacyRectangle)
        {
            _legacyRectangle = legacyRectangle;
        }

        public void Draw(Panel area, Pen pen, int x1, int y1, int x2, int y2)
        {
            int x = Math.Min(x1, x2);
            int y = Math.Min(y1, y2);
            int width = Math.Abs(x2 - x1);
            int height = Math.Abs(y2 - y1);
            _legacyRectangle.Draw(area, pen, x, y, width, height);
        }
    }
}
