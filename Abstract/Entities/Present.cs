using Abstract.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Entities
{
    class Present:Toy
    {
        public SolidBrush RibbonColor { get; private set; }
        public SolidBrush BoxColor { get; private set; }
        public Present(Color color1, Color color2)
        {
            RibbonColor = new SolidBrush(color1);
            BoxColor = new SolidBrush(color2);
        }
        protected override void DrawImage(Graphics g)
        {
            int ribwidth = 6;
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, Width / 2 - ribwidth / 2, 0, ribwidth, Height);
            g.FillRectangle(RibbonColor, 0, Height / 2 - ribwidth / 2, Width, ribwidth);
        }
    }
}
