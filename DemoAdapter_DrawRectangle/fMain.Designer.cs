namespace DemoAdapter_DrawRectangle
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbY2 = new System.Windows.Forms.TextBox();
            this.txbX2 = new System.Windows.Forms.TextBox();
            this.txbY1 = new System.Windows.Forms.TextBox();
            this.txbX1 = new System.Windows.Forms.TextBox();
            this.pnDrawArea = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.lb_Note = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lbCoordinates = new System.Windows.Forms.Label();
            this.lb_Client = new System.Windows.Forms.Label();
            this.lb_Target = new System.Windows.Forms.Label();
            this.lb_Adapter = new System.Windows.Forms.Label();
            this.lb_Adaptee = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbY2
            // 
            this.txbY2.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbY2.Location = new System.Drawing.Point(127, 344);
            this.txbY2.Name = "txbY2";
            this.txbY2.Size = new System.Drawing.Size(100, 27);
            this.txbY2.TabIndex = 1;
            // 
            // txbX2
            // 
            this.txbX2.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbX2.Location = new System.Drawing.Point(127, 314);
            this.txbX2.Name = "txbX2";
            this.txbX2.Size = new System.Drawing.Size(100, 27);
            this.txbX2.TabIndex = 1;
            // 
            // txbY1
            // 
            this.txbY1.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbY1.Location = new System.Drawing.Point(127, 284);
            this.txbY1.Name = "txbY1";
            this.txbY1.Size = new System.Drawing.Size(100, 27);
            this.txbY1.TabIndex = 1;
            // 
            // txbX1
            // 
            this.txbX1.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbX1.Location = new System.Drawing.Point(127, 254);
            this.txbX1.Name = "txbX1";
            this.txbX1.Size = new System.Drawing.Size(100, 27);
            this.txbX1.TabIndex = 1;
            // 
            // pnDrawArea
            // 
            this.pnDrawArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDrawArea.BackColor = System.Drawing.Color.Transparent;
            this.pnDrawArea.Location = new System.Drawing.Point(556, 170);
            this.pnDrawArea.Name = "pnDrawArea";
            this.pnDrawArea.Size = new System.Drawing.Size(951, 480);
            this.pnDrawArea.TabIndex = 0;
            this.pnDrawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnDrawArea_MouseMove);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.rbCircle);
            this.panel10.Controls.Add(this.rbRectangle);
            this.panel10.Controls.Add(this.rbLine);
            this.panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(82, 417);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(453, 94);
            this.panel10.TabIndex = 0;
            // 
            // rbCircle
            // 
            this.rbCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCircle.Location = new System.Drawing.Point(0, 36);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.rbCircle.Size = new System.Drawing.Size(318, 24);
            this.rbCircle.TabIndex = 2;
            this.rbCircle.UseVisualStyleBackColor = true;
            this.rbCircle.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // rbRectangle
            // 
            this.rbRectangle.Checked = true;
            this.rbRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRectangle.Location = new System.Drawing.Point(0, 7);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.rbRectangle.Size = new System.Drawing.Size(318, 24);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.rbRectangle_CheckedChanged);
            // 
            // rbLine
            // 
            this.rbLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLine.Location = new System.Drawing.Point(0, 66);
            this.rbLine.Name = "rbLine";
            this.rbLine.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.rbLine.Size = new System.Drawing.Size(318, 24);
            this.rbLine.TabIndex = 0;
            this.rbLine.UseVisualStyleBackColor = true;
            this.rbLine.CheckedChanged += new System.EventHandler(this.rbLine_CheckedChanged);
            // 
            // lb_Note
            // 
            this.lb_Note.BackColor = System.Drawing.Color.Transparent;
            this.lb_Note.Font = new System.Drawing.Font("Montserrat Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Note.Location = new System.Drawing.Point(132, 550);
            this.lb_Note.Name = "lb_Note";
            this.lb_Note.Padding = new System.Windows.Forms.Padding(3);
            this.lb_Note.Size = new System.Drawing.Size(362, 91);
            this.lb_Note.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(126, 664);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(323, 664);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Padding = new System.Windows.Forms.Padding(5);
            this.btnDraw.Size = new System.Drawing.Size(176, 40);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lbCoordinates
            // 
            this.lbCoordinates.AutoSize = true;
            this.lbCoordinates.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoordinates.Location = new System.Drawing.Point(623, 657);
            this.lbCoordinates.Name = "lbCoordinates";
            this.lbCoordinates.Size = new System.Drawing.Size(84, 19);
            this.lbCoordinates.TabIndex = 3;
            this.lbCoordinates.Text = "X=0   Y=0";
            // 
            // lb_Client
            // 
            this.lb_Client.BackColor = System.Drawing.Color.Transparent;
            this.lb_Client.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Client.Location = new System.Drawing.Point(98, 765);
            this.lb_Client.Name = "lb_Client";
            this.lb_Client.Padding = new System.Windows.Forms.Padding(3);
            this.lb_Client.Size = new System.Drawing.Size(320, 112);
            this.lb_Client.TabIndex = 4;
            this.lb_Client.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Target
            // 
            this.lb_Target.BackColor = System.Drawing.Color.Transparent;
            this.lb_Target.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Target.Location = new System.Drawing.Point(458, 765);
            this.lb_Target.Name = "lb_Target";
            this.lb_Target.Padding = new System.Windows.Forms.Padding(3);
            this.lb_Target.Size = new System.Drawing.Size(320, 112);
            this.lb_Target.TabIndex = 5;
            this.lb_Target.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Adapter
            // 
            this.lb_Adapter.BackColor = System.Drawing.Color.Transparent;
            this.lb_Adapter.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Adapter.Location = new System.Drawing.Point(820, 758);
            this.lb_Adapter.Name = "lb_Adapter";
            this.lb_Adapter.Padding = new System.Windows.Forms.Padding(3);
            this.lb_Adapter.Size = new System.Drawing.Size(320, 119);
            this.lb_Adapter.TabIndex = 6;
            this.lb_Adapter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Adaptee
            // 
            this.lb_Adaptee.BackColor = System.Drawing.Color.Transparent;
            this.lb_Adaptee.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Adaptee.Location = new System.Drawing.Point(1182, 765);
            this.lb_Adaptee.Name = "lb_Adaptee";
            this.lb_Adaptee.Padding = new System.Windows.Forms.Padding(3);
            this.lb_Adaptee.Size = new System.Drawing.Size(320, 112);
            this.lb_Adaptee.TabIndex = 7;
            this.lb_Adaptee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::DemoAdapter_DrawRectangle.Properties.Resources.iconfinder_UI_Basic_outline_116_4733225;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(1547, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DemoAdapter_DrawRectangle.Properties.Resources.Thiết_kế_phân_mềm_hướng_đối_tượng__1_;
            this.ClientSize = new System.Drawing.Size(1598, 898);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lb_Adaptee);
            this.Controls.Add(this.lb_Adapter);
            this.Controls.Add(this.lb_Target);
            this.Controls.Add(this.lb_Client);
            this.Controls.Add(this.txbY2);
            this.Controls.Add(this.txbX2);
            this.Controls.Add(this.txbY1);
            this.Controls.Add(this.txbX1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.lb_Note);
            this.Controls.Add(this.lbCoordinates);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnDrawArea);
            this.Controls.Add(this.btnDraw);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnDrawArea;
        private System.Windows.Forms.TextBox txbY2;
        private System.Windows.Forms.TextBox txbX2;
        private System.Windows.Forms.TextBox txbY1;
        private System.Windows.Forms.TextBox txbX1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lb_Note;
        private System.Windows.Forms.Label lbCoordinates;
        private System.Windows.Forms.Label lb_Client;
        private System.Windows.Forms.Label lb_Target;
        private System.Windows.Forms.Label lb_Adapter;
        private System.Windows.Forms.Label lb_Adaptee;
        private System.Windows.Forms.Button btn_Close;
    }
}

