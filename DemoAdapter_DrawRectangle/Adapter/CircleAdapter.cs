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
    internal class CircleAdapter : IShape
    {
        private readonly LegacyCircle _legacyCircle;

        public CircleAdapter(LegacyCircle legacyCircle)
        {
            _legacyCircle = legacyCircle;
        }

        public void draw(Panel area, Pen pen, int x1, int y1, int x2, int y2)
        {
            int r = Convert.ToInt32(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            int left_x = x1 - r;
            int top_y = y1 - r;
            _legacyCircle.specificDrawCircle(area, pen, left_x, top_y, r);
        }
    }
}
