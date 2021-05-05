using DemoAdapter_DrawRectangle.Adapter;
using DemoAdapter_DrawRectangle.Legacy;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DemoAdapter_DrawRectangle
{
    public partial class fMain : Form
    {
        int x1, x2, y1, y2;
        IShape shape;

        public fMain()
        {
            InitializeComponent();
            lb_Note.Text = getNote(2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearDrawingArea();
            clearCoordinatesInfo();
            clearCodeInfo();
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
            setCodeFlow();
        }

        private void pnDrawArea_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (sender as Panel).PointToClient(Cursor.Position).X;
            int y = (sender as Panel).PointToClient(Cursor.Position).Y;
            lbCoordinates.Text = string.Format("X = {0} , Y = {1}", x, y);
        }

        private void clearCoordinatesInfo()
        {
            txbX1.Text = txbY1.Text = txbX2.Text = txbY2.Text = "";
        }

        private void clearCodeInfo()
        {
            lb_Client.Text = lb_Target.Text = lb_Adapter.Text = lb_Adaptee.Text = "";
        }

        private void clearDrawingArea()
        {
            Graphics graphics = pnDrawArea.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.Dispose();
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void specifyShapeAndDraw()
        {
            if (rbRectangle.Checked)
            {
                shape = new RectangleAdapter(new LegacyRectangle());
                Pen pen = new Pen(Color.Red, 3);
                shape.draw(pnDrawArea, pen, x1, y1, x2, y2);
            }
            else if (rbCircle.Checked)
            {
                setCodeInfo(lb_Client, "shape = new CircleAdapter();\n");
                shape = new CircleAdapter(new LegacyCircle());
                Pen pen = new Pen(Color.Green, 3);
                shape.draw(pnDrawArea, pen, x1, y1, x2, y2);
            }
            else if (rbLine.Checked)
            {
                shape = new LineAdapter(new LegacyLine());
                Pen pen = new Pen(Color.Blue, 3);
                shape.draw(pnDrawArea, pen, x1, y1, x2, y2);
            }
        }

        private string getNote(int shape)
        {
            string note = "";
            if (shape == 1)
            {
                note = "X1, Y1, X2, Y2 lần lượt là tọa độ của 2 đầu mút";
            }
            else if (shape == 2)
            {
                note = "X1, Y1, X2, Y2 lần lượt là toạn độ 2 góc bất kỳ của hình chữ nhật"; 
            }
            else if (shape == 3)
            {
                note =
                    "X1, Y1 là tọa độ tâm đường tròn\n" +
                    "X2, Y2 là tọa độ 1 điểm bất kỳ nằm trên đường tròn";
            }    

            return note;
        }

        private void setCodeInfo(Label label, string code)
        {
            label.Text += code;
        }

        private void setCodeFlow()
        {
            setCodeInfo(lb_Client, "IShape shape;\n");
            setCodeInfo(lb_Target, "Interface: IShape\n");
            setCodeInfo(lb_Target, "Method:\n");
            setCodeInfo(lb_Target, "draw(Panel area, Pen pen, int x1, int y1, int x2, int y2))\n");

            if (rbRectangle.Checked)
            {
                setCodeInfo(lb_Client, "shape = new RectangleAdapter();\n");
                setCodeInfo(lb_Client, "shape.draw(pnDrawArea, pen, x1, y1, x2, y2);\n");

                setCodeInfo(lb_Adapter, "LegacyRectangle _legacyRectangle = new LegacyRectangle();\n");
                setCodeInfo(lb_Adapter, "draw(area, pen, x1, y1, x2, y2)\n");
                setCodeInfo(lb_Adapter, "//Xử lý dữ liệu\n");
                setCodeInfo(lb_Adapter, "_legacyRectangle.specificDraw(area, pen, x, y, width, height);\n");

                setCodeInfo(lb_Adaptee, "Class: LegacyRectangle\n");
                setCodeInfo(lb_Adaptee, "Method:\n");
                setCodeInfo(lb_Adaptee, "void specificDraw(Panel area, Pen pen, int x, int y, int width, int heigh)\n");
            }
            else if (rbCircle.Checked)
            {
                setCodeInfo(lb_Client, "shape = new CircleAdapter();\n");
                setCodeInfo(lb_Client, "shape.draw(pnDrawArea, pen, x1, y1, x2, y2);\n");

                setCodeInfo(lb_Adapter, "LegacyCircle _legacyCircle = new LegacyCircle();\n");
                setCodeInfo(lb_Adapter, "draw(area, pen, x1, y1, x2, y2)\n");
                setCodeInfo(lb_Adapter, "//Xử lý dữ liệu\n");
                setCodeInfo(lb_Adapter, "_legacyCircle.specificDraw(area, pen, left_x, top_y, r);\n");

                setCodeInfo(lb_Adaptee, "Class: LegacyCircle\n");
                setCodeInfo(lb_Adaptee, "Method:\n");
                setCodeInfo(lb_Adaptee, "void specificDraw(Panel area, Pen pen, int x, int y, int r)\n");
            }    
            else if (rbLine.Checked)
            {
                setCodeInfo(lb_Client, "shape = new LineAdapter();\n");
                setCodeInfo(lb_Client, "shape.draw(pnDrawArea, pen, x1, y1, x2, y2);\n");

                setCodeInfo(lb_Adapter, "LegacyLine _legacyLine = new LegacyLine();\n");
                setCodeInfo(lb_Adapter, "draw(area, pen, x1, y1, x2, y2)\n");
                setCodeInfo(lb_Adapter, "_legacyLine.specificDraw(area, pen, x1, y1, x2, y2);\n");

                setCodeInfo(lb_Adaptee, "Class: LegacyLine\n");
                setCodeInfo(lb_Adaptee, "Method:\n");
                setCodeInfo(lb_Adaptee, "void specificDraw(Panel area, Pen pen, int x1, int y1, int x2, int y2)\n");
            }    
        }
    }
}
