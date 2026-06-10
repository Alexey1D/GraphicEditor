using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Shapes
{
    /// <summary>
    /// Represents a rectangle model with position and size.
    /// </summary>
    public class RectangleShape : Shape
    {
        public int X { get; }

        public int Y { get; }

        public int Width { get; }

        public int Height { get; }

        public RectangleShape(
            int x,
            int y,
            int width,
            int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
