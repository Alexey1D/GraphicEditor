using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GraphicEditor.Shapes;

namespace GraphicEditor.Renderers
{
    public class EllipseRenderer : IShapeRenderer
    {
        public void Draw(
            Graphics graphics,
            Shape shape)
        {
            EllipseShape ellipse =
                (EllipseShape)shape;

            graphics.DrawEllipse(
                Pens.Blue,
                ellipse.X,
                ellipse.Y,
                ellipse.Width,
                ellipse.Height);
        }
    }
}