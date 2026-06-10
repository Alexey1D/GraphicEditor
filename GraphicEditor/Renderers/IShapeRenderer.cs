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
    /// Draws a shape.
    /// </summary>
    public interface IShapeRenderer
    {
        void Draw(Graphics graphics, Shape shape);
    }
}