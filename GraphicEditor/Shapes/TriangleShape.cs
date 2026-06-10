using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Shapes
{
    public class TriangleShape : Shape
    {
        public int X { get; }
        public int Y { get; }
        public int Size { get; }

        public TriangleShape(
            int x,
            int y,
            int size)
        {
            X = x;
            Y = y;
            Size = size;
        }
    }
}
