using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GraphicEditor.Shapes;

namespace GraphicEditor.Renderers
{
    public class CircleRenderer : IShapeRenderer
    {
        public void Draw(
            Graphics graphics,
            Shape shape)
        {
            CircleShape circle =
                (CircleShape)shape;

            graphics.DrawEllipse(
                Pens.Red,
                circle.X,
                circle.Y,
                circle.Radius,
                circle.Radius);
        }
    }
}