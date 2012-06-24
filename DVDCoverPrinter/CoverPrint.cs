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
        private Color[] outlineColors = {
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
        };
        private Color[] colors = {
            Color.Red,
            Color.Yellow,
            Color.Green,
            Color.Blue,
        };

        public String text1 = null;
        public String text2 = null;
        public String text3 = null;
        public String text4 = null;
        public String textnumber = null;

        public float size1 = 9.0f;
        public float size2 = 9.0f;
        public float size3 = 9.0f;
        public float size4 = 9.0f;
        public float sizenumber = 9.0f;

        public int numbercolor = 0;

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
            Font font; // = new Font(new FontFamily("Arial"), 7.0f, GraphicsUnit.Millimeter);

            Rectangle bodyRect = new Rectangle(3, 3, 184, 272);             // DVD Cover size 272x184
            Rectangle middleRect = new Rectangle(3, 129 + 3, 184, 14);      // DVD Covert side size, 14x184

            // Draw dotted rectable
            Pen borderPen = new Pen(System.Drawing.Color.Black, 0.3f);
            borderPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            borderPen.DashPattern = new float[] {0.3F, 45F};
            ev.Graphics.DrawRectangle(borderPen, bodyRect);

            // Draw dotted rectable in middle
            //ev.Graphics.DrawRectangle(borderPen, middleRect);

            // Draw small "L" markers on cut positions
            Pen linePen = new Pen(System.Drawing.Color.Black, 0.3f);
            ev.Graphics.DrawLine(linePen, 3, 3, 6, 3);
            ev.Graphics.DrawLine(linePen, 3, 3, 3, 6);

            ev.Graphics.DrawLine(linePen, 184+3, 3, 181+3, 3);
            ev.Graphics.DrawLine(linePen, 184+3, 3, 184+3, 6);

            ev.Graphics.DrawLine(linePen, 3, 272+3, 6, 272+3);
            ev.Graphics.DrawLine(linePen, 3, 272+3, 3, 269+3);

            ev.Graphics.DrawLine(linePen, 184 + 3, 272 + 3, 181+3, 272 + 3);
            ev.Graphics.DrawLine(linePen, 184 + 3, 272 + 3, 184+3, 269 + 3);

            float startpos = middleRect.X + 2.0f;
            if (text1 != null)
            {
                font = new Font(new FontFamily("Arial"), size1, GraphicsUnit.Millimeter);
                startpos += DrawSideText(ev, font, 0, text1, startpos, middleRect.Y + ((middleRect.Height-size1) / 2.0f));
            }
            if (text2 != null)
            {
                font = new Font(new FontFamily("Arial"), size2, GraphicsUnit.Millimeter);
                startpos += DrawSideText(ev, font, 1, text2, startpos, middleRect.Y + ((middleRect.Height - size2) / 2.0f));
            }
            if (text3 != null)
            {
                font = new Font(new FontFamily("Arial"), size3, GraphicsUnit.Millimeter);
                startpos += DrawSideText(ev, font, 2, text3, startpos, middleRect.Y + ((middleRect.Height - size3) / 2.0f));
            }
            if (text4 != null)
            {
                font = new Font(new FontFamily("Arial"), size4, GraphicsUnit.Millimeter);
                startpos += DrawSideText(ev, font, 3, text4, startpos, middleRect.Y + ((middleRect.Height - size4) / 2.0f));
            }
            if (textnumber != null)
            {
                font = new Font(new FontFamily("Arial"), sizenumber, GraphicsUnit.Millimeter);
                startpos += DrawNumberText(ev, font, numbercolor, textnumber, middleRect.X + middleRect.Width - 2.0f, middleRect.Y + ((middleRect.Height - sizenumber) / 2.0f));
            }
        }

        private float DrawSideText(PrintPageEventArgs ev, Font font, int color, String text, float x, float y)
        {
            SizeF textsize = ev.Graphics.MeasureString(text, font);
            DrawTextOutline(ev, font, color, text, x, y);
            return textsize.Width;
        }

        private float DrawNumberText(PrintPageEventArgs ev, Font font, int color, String text, float x, float y)
        {
            SizeF textsize = ev.Graphics.MeasureString(text, font);
            DrawTextOutline(ev, font, color, text, x - textsize.Width, y);
            return textsize.Width;
        }

        private void DrawTextOutline(PrintPageEventArgs ev, Font font, int color, String text, float x, float y, Boolean rotate = false)
        {
            ev.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            ev.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //Font font = new Font(new FontFamily("Arial"), 7.0f, GraphicsUnit.Millimeter);

            SizeF textsize = ev.Graphics.MeasureString(text, font);

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

            path.AddString(text, font.FontFamily, 0, font.Size,
                new RectangleF(x, y, textsize.Width, textsize.Height),
                sf);

            // fill in the outline
            ev.Graphics.FillPath(new SolidBrush(colors[color]), path);

            // draw the outline
            ev.Graphics.DrawPath(new Pen(outlineColors[color], 0.1f), path);

            if (rotate)
            {
                ev.Graphics.Transform = new Matrix();
            }
        }
    }
}
