using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Shapes
{
    public class EllipseShape : Shape
    {
        public int X { get; }
        public int Y { get; }
        public int Width { get; }
        public int Height { get; }

        public EllipseShape(
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
