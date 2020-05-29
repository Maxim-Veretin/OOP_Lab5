using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Lab5
{
    class EllipseHoverButton : HoverButton
    {
        public EllipseHoverButton() : base()
        {
            ForeColor = Color.Black;
            Font = new Font("Candara",
                20.25F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
            Region = new Region(graphicsPath);
        }

    }
}