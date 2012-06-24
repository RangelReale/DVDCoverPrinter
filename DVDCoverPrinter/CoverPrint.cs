using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DVDCoverPrinter
{
    class CoverPrint : PrintDocument
    {
        public CoverPrint()
        {
        }

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            base.OnBeginPrint(e);
        }

        protected override void OnPrintPage(PrintPageEventArgs ev)
        {
            base.OnPrintPage(ev);

            ev.Graphics.PageUnit = GraphicsUnit.Millimeter;

            string strHello = "Hello Printer!";
            Font oFont = new Font("Arial", 10);
            Rectangle marginRect = ev.MarginBounds;

            /*
            ev.Graphics.DrawRectangle(new Pen(System.Drawing.Color.Black), marginRect);
            ev.Graphics.DrawString(strHello, oFont, new SolidBrush(System.Drawing.Color.Blue),
              (ev.PageBounds.Right / 2), ev.PageBounds.Bottom / 2);
            */

            Rectangle bodyRect = new Rectangle(3, 3, 184, 272);
            Rectangle middleRect = new Rectangle(3, 129 + 3, 184, 14);

            Pen borderPen = new Pen(System.Drawing.Color.Black, 0.3f);
            borderPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            borderPen.DashPattern = new float[] {0.3F, 15F};
            ev.Graphics.DrawRectangle(borderPen, bodyRect);


            ev.Graphics.DrawRectangle(borderPen, middleRect);

            Pen linePen = new Pen(System.Drawing.Color.Black, 0.3f);
            ev.Graphics.DrawLine(linePen, 3, 3, 6, 3);
            ev.Graphics.DrawLine(linePen, 3, 3, 3, 6);

            ev.Graphics.DrawLine(linePen, 184+3, 3, 181+3, 3);
            ev.Graphics.DrawLine(linePen, 184+3, 3, 184+3, 6);

            ev.Graphics.DrawLine(linePen, 3, 272+3, 6, 272+3);
            ev.Graphics.DrawLine(linePen, 3, 272+3, 3, 269+3);

            ev.Graphics.DrawLine(linePen, 184 + 3, 272 + 3, 181+3, 272 + 3);
            ev.Graphics.DrawLine(linePen, 184 + 3, 272 + 3, 184+3, 269 + 3);

            DrawTextOutline(ev, "Nome da novela", 3.0f + 23.0f, 3.0f + 23.0f, false);
            DrawTextOutline(ev, "Nome da novela", 3.0f + 23.0f, 3.0f + 23.0f);

            /*
            ev.Graphics.DrawString(strHello, oFont, new SolidBrush(System.Drawing.Color.Blue),
              (ev.PageBounds.Right / 2), ev.PageBounds.Bottom / 2);
             */
        }

        private void DrawTextOutline(PrintPageEventArgs ev, String text, float x, float y, Boolean rotate = true)
        {
            ev.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            ev.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            Font font = new Font(new FontFamily("Arial"), 7.0f, GraphicsUnit.Millimeter);

            SizeF textsize = ev.Graphics.MeasureString(text, font);
            Console.WriteLine(textsize);

            if (rotate)
            {
                Matrix mx = new Matrix();
                //mx.RotateAt(90, new PointF(fillRect.X + (textsize.Width/2), fillRect.Y + (textsize.Height/2)));
                mx.RotateAt(270, new PointF(x + (textsize.Width / 2), y + (textsize.Height / 2)));
                //mx.Translate(x + (-1 * (textsize.Width / 2)), y + (-1 * (textsize.Height / 2)));
                //mx.Translate(-27.0f, -27.0f);
                /*
                mx.TransformPoints(new PointF[] {
                    new PointF(x, y),
                    new PointF(x + textsize.Width, y),
                    new PointF(x + textsize.Width, y + textsize.Height),
                    new PointF(x, y + textsize.Height)
                });
                 */
                ev.Graphics.Transform = mx;
            }

            StringFormat sf = new StringFormat();
            //sf.Alignment = StringAlignment.Center;
            //sf.LineAlignment = StringAlignment.Center;// draw the text to a path

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            if (true)
            {
                path.AddString(text, font.FontFamily, 0, font.Size,
                    new RectangleF(x, y, textsize.Width, textsize.Height),
                    sf);
            }
            else
            {
                path.AddString(text, font.FontFamily, 0, font.Size,
                    new RectangleF(x - (textsize.Width / 2), y - (textsize.Height / 2), textsize.Width, textsize.Height),
                    sf);
            }

            // fill in the outline
            ev.Graphics.FillPath(Brushes.Yellow, path);

            // draw the outline
            ev.Graphics.DrawPath(new Pen(Color.Green, 0.5f), path);

            if (rotate)
            {
                ev.Graphics.Transform = new Matrix();
            }
        }
    }
}
