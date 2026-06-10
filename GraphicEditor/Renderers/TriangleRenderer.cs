using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GraphicEditor.Shapes;

namespace GraphicEditor.Renderers
{
    public class TriangleRenderer : IShapeRenderer
    {
        public void Draw(
            Graphics graphics,
            Shape shape)
        {
            TriangleShape triangle =
                (TriangleShape)shape;

            Point[] points =
            {
                new Point(triangle.X, triangle.Y),
                new Point(triangle.X - triangle.Size / 2,
                          triangle.Y + triangle.Size),
                new Point(triangle.X + triangle.Size / 2,
                          triangle.Y + triangle.Size)
            };

            graphics.DrawPolygon(
                Pens.Purple,
                points);
        }
    }
}
