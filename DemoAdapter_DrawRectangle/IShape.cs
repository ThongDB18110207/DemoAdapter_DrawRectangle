using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAdapter_DrawRectangle
{
    internal interface IShape
    {
        void Draw(Panel area, Pen pen, int x1, int y1, int x2, int y2);
    }
}
