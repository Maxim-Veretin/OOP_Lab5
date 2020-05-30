using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Lab5
{
    class HoverButton : Button
    {
        private Color color = Color.LightGray;
        private string text = " ";
        
        //public Bitmap[] img = new Bitmap[] { Properties.Resources.smork, Properties.Resources.smork1, Properties.Resources.smork2 };
        public List<Bitmap> imgs = new List<Bitmap>();
        
        private int i = 0;
        private StringFormat stringFormat;

        public HoverButton() : base()
        {
            ForeColor = Color.Black;
            Font = new Font("Candara",
                20.25F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.DrawImage(imgs[i], 0, 0, Size.Width, Size.Height);

            Text = text;
            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            pevent.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            color = Color.DarkGray;
            text = "Ы";
            ForeColor = Color.DarkOrange;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            color = Color.LightGray;
            text = " ";
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (i == imgs.Count - 1)
                i = 0;
            else
                i++;
        }
    }
}