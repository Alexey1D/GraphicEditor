using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GraphicEditor.Shapes;

namespace GraphicEditor.Renderers
{
    public class SquareRenderer : IShapeRenderer
    {
        public void Draw(
            Graphics graphics,
            Shape shape)
        {
            SquareShape square =
                (SquareShape)shape;

            graphics.DrawRectangle(
                Pens.Green,
                square.X,
                square.Y,
                square.Size,
                square.Size);
        }
    }
}
