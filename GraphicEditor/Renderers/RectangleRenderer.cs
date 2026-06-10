using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GraphicEditor.Shapes;

namespace GraphicEditor.Renderers
{
    /// <summary>
    /// Draws rectangle shape on graphics surface.
    /// </summary>
    public class RectangleRenderer : IShapeRenderer
    {
        /// <summary>
        /// Renders rectangle using graphics context.
        /// </summary>
        public void Draw(
            Graphics graphics,
            Shape shape)
        {
            RectangleShape rectangle =
                (RectangleShape)shape;

            graphics.DrawRectangle(
                Pens.Black,
                rectangle.X,
                rectangle.Y,
                rectangle.Width,
                rectangle.Height);
        }
    }
}