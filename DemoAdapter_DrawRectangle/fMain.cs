using DemoAdapter_DrawRectangle.Adapter;
using DemoAdapter_DrawRectangle.Legacy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAdapter_DrawRectangle
{
    public partial class fMain : Form
    {
        int x1, x2, y1, y2;
        public fMain()
        {
            InitializeComponent();
            lb_Note.Text = getNote(1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics graphics = pnDrawArea.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.Dispose();
        }

        private void rbLine_CheckedChanged(object sender, EventArgs e)
        {
            if(rbLine.Checked)
            {
                lb_Note.Text = getNote(1);
            }    
        }

        private void rbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if(rbRectangle.Checked)
            {
                lb_Note.Text = getNote(2);
            }    
        }

        private void rbCircle_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCircle.Checked)
            {
                lb_Note.Text = getNote(3);
            }    
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            getLocationValue();
            specifyShapeAndDraw();
        }

        private void pnDrawArea_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (sender as Panel).PointToClient(Cursor.Position).X;
            int y = (sender as Panel).PointToClient(Cursor.Position).Y;
            lbCoordinates.Text = string.Format("Tọa độ: X = {0} , Y = {1}", x, y);
        }

        private void getLocationValue()
        {
            try
            {
                x1 = Convert.ToInt32(txbX1.Text);
                y1 = Convert.ToInt32(txbY1.Text);
                x2 = Convert.ToInt32(txbX2.Text);
                y2 = Convert.ToInt32(txbY2.Text);
            }
            catch
            {
                MessageBox.Show("Tọa độ vừa nhập không hợp lệ!");
                return;
            }
        }

        private void specifyShapeAndDraw()
        {
            if (rbRectangle.Checked)
            {
                IShape shape = new RectangleAdapter(new LegacyRectangle());
                Pen pen = new Pen(Color.Red, 3);
                shape.Draw(pnDrawArea, pen, x1, y1, x2, y2);
            }
            else if (rbCircle.Checked)
            {
                IShape shape = new CircleAdapter(new LegacyCircle());
                Pen pen = new Pen(Color.Green, 3);
                shape.Draw(pnDrawArea, pen, x1, y1, x2, y2);
            }
            else if (rbLine.Checked)
            {
                IShape shape = new LineAdapter(new LegacyLine());
                Pen pen = new Pen(Color.Blue, 3);
                shape.Draw(pnDrawArea, pen, x1, y1, x2, y2);
            }
        }

        private string getNote(int shape)
        {
            string note = "";
            if (shape == 1)
            {
                note = 
                    "Ghi chú:\n" +
                    "X1, Y1, X2, Y2 lần lượt là tọa độ của 2 đầu mút";
            }
            else if (shape == 2)
            {
                note =
                    "Ghi chú:\n" +
                    "X1, Y1, X2, Y2 lần lượt là toạn độ 2 góc bất kỳ của hình chữ nhật"; 
            }
            else if (shape == 3)
            {
                note =
                    "Ghi chú:\n" +
                    "X1, Y1 là tọa độ tâm đường tròn\n" +
                    "X2, Y2 là tọa độ 1 điểm bất kỳ nằm trên đường tròn";
            }    

            return note;
        }
    }
}
