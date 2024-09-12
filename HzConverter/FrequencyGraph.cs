using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HzConverter
{
    public partial class FrequencyGraph : UserControl
    {
        public float Frequency { get; set; } = 2f;
        public Color Color { get; set; } = Color.Red;
        public int PointsNum { get; set; } = 500;
        public float Time { get; set; } = 1f;

        public FrequencyGraph()
        {
            this.DoubleBuffered = true;
            this.Resize += (s, e) => this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            float width = this.ClientSize.Width;
            float height = this.ClientSize.Height;

            float leftMargin = 20;
            float rightMargin = 20;
            int pointsNum = PointsNum;

            float plotWidth = width - leftMargin - rightMargin;
            float plotHeight = height;

            using (Pen pen = new Pen(Color.Gray, 2))
            {
                g.DrawLine(pen, leftMargin, plotHeight / 2, width - rightMargin, plotHeight / 2);
                g.DrawLine(pen, leftMargin, 0, leftMargin, plotHeight);
            }

            if (Frequency > 0)
            {
                float ten = 1;
                if (Frequency > 1) ten = (float)Math.Pow(10, Math.Floor(Math.Log10((double)Frequency)));
                else ten = (float)Math.Pow(10, Math.Round(Math.Log10((double)Frequency)));
                PointF[] points = new PointF[pointsNum];
                for (int i = 0; i < pointsNum; i++)
                {
                    float t = i / (float)(pointsNum - 1) * Time;
                    float y = 50f * (float)Math.Sin(2 * Math.PI * Frequency * t / ten);
                    float xScreen = leftMargin + i / (float)(pointsNum - 1) * plotWidth;
                    float yScreen = plotHeight / 2 - y;
                    points[i] = new PointF(xScreen, yScreen);
                }

                using (Pen pen = new Pen(Color, 2))
                {
                    g.DrawLines(pen, points);
                }
                using (Font font = new Font("Arial", 8))
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    if (ten >= 1) g.DrawString(Convert.ToString(1 / (decimal)ten) + "s", font, brush, width - rightMargin - 20 - Math.Min(20, 5 * (int)Math.Log10((double)Frequency)), plotHeight / 2 + 5);
                    else g.DrawString(Convert.ToString(Math.Ceiling(1 / (decimal)ten)) + "s", font, brush, width - rightMargin - 20 - 8 * (int)Math.Log10((double)1f/Frequency), plotHeight / 2 + 5);
                }
            }
        }
    }
}
