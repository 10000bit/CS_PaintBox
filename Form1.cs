using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaintBox
{
    public partial class Form1 : Form
    {

        Bitmap Drawing { get; set; }

        private Pen pen = new Pen(Color.Black);
        private DrawType drawType;
        private int startX;
        private int startY;
        private int endX;
        private int endY;

        public Form1()
        {
            InitializeComponent();

            this.Drawing = new Bitmap(Size.Width, Size.Height);
            pictureBox.Image = this.Drawing;

            this.saveFileMenuItem.Click += this.SaveFileMenuItem_Click; // 저장 메뉴
            this.openFileMenuItem.Click += this.OpenFileMenuItem_Click; // 불러오기 메뉴
            this.fieldColorMenuItem.Click += this.FieldColorMenuItem_Click; // 배경색 변경
            this.entityColorMenuItem.Click += this.EntityColorMenuItem_Click; // 엔티티색 변경

            this.triangleMenuItem.Click += this.TriangleMenuItem_Click; // 삼각형 선택
            this.rectangleMenuItem.Click += this.RectangleMenuItem_Click; // 사각형 선택
            this.circleMenuItem.Click += this.CircleMenuItem_Click; // 원 선택
            this.lineMenuItem.Click += this.LineMenuItem_Click; // 직선 선택

            this.pictureBox.MouseDown += this.PictureBox_MouseDown;
            this.pictureBox.MouseUp += this.PictureBox_MouseUp;

            //this.pictureBox.MouseUp += (s, e) => 
            //{ 
                
            //};
        }

        private void LineMenuItem_Click(object sender, EventArgs e)
        {
            drawType = DrawType.Line;
        }

        private void CircleMenuItem_Click(object sender, EventArgs e)
        {
            drawType = DrawType.Circle;
        }

        private void RectangleMenuItem_Click(object sender, EventArgs e)
        {
            drawType = DrawType.Rect;
        }

        private void TriangleMenuItem_Click(object sender, EventArgs e)
        {
            drawType = DrawType.Triangle;
        }

        /// <summary>
        /// pictureBox 위에 마우스 Down 시(start 좌표)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                startX = e.X;
                startY = e.Y;
            }
        }

        /// <summary>
        /// pictureBox 위에 마우스 Up 시(end 좌표)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                endX = e.X;
                endY = e.Y;
                switch (drawType)
                {
                    case DrawType.Triangle:
                        DrawShape.Triangle(Drawing, pen, startX, startY, endX, endY);
                        break;
                    case DrawType.Rect:
                        DrawShape.Rectangle(Drawing, pen, startX, startY, endX, endY);
                        break;
                    case DrawType.Circle:
                        DrawShape.Circle(Drawing, pen, startX, startY, endX, endY);
                        break;
                    case DrawType.Line:
                        DrawShape.Line(Drawing, pen, startX, startY, endX, endY);
                        break;
                    case DrawType.None:
                        break;
                }

                this.pictureBox.Refresh();
            }
        }

        /// <summary>
        /// 엔티티색 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EntityColorMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pen.Color = dialog.Color;
                }
            }
        }

        /// <summary>
        /// 배경색 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FieldColorMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Graphics g = Graphics.FromImage(Drawing);
                    g.FillRectangle(new SolidBrush(dialog.Color), new Rectangle(0, 0, Drawing.Width, Drawing.Height));
                    pictureBox.Refresh();
                }
            }
        }

        /// <summary>
        /// 불러오기 메뉴 클릭 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Drawing = (Bitmap)Bitmap.FromFile(dialog.FileName);
                    pictureBox.Refresh();

                    drawType = DrawType.None;
                }
            }
        }

        /// <summary>
        /// 저장 메뉴 클릭 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Image | .png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(dialog.FileName);
                }
            }
        }
    }
}
