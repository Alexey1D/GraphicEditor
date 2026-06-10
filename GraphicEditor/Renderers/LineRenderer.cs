using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GraphicEditor.Shapes;

namespace GraphicEditor.Renderers
{
    public class LineRenderer : IShapeRenderer
    {
        public void Draw(
            Graphics graphics,
            Shape shape)
        {
            LineShape line =
                (LineShape)shape;

            graphics.DrawLine(
                Pens.Black,
                line.X,
                line.Y,
                line.X + line.Length,
                line.Y);
        }
    }
}
