using System;
using System.Drawing.Drawing2D;

namespace CheckIn_Event
{
   public class OvalPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(graphics);
            base.OnPaint(pe);

        }
    }
}
