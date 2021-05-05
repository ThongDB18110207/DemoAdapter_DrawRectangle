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
    internal class LineAdapter : IShape
    {
        private readonly LegacyLine _legacyLine;

        public LineAdapter(LegacyLine legacyLine)
        {
            _legacyLine = legacyLine;
        }

        public void draw(Panel area, Pen pen, int x1, int y1, int x2, int y2)
        {
            _legacyLine.specificDraw(area, pen, x1, y1, x2, y2);
        }
    }
}
