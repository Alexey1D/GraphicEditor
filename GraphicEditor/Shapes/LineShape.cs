using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Shapes
{
    public class LineShape : Shape
    {
        public int X { get; }
        public int Y { get; }
        public int Length { get; }

        public LineShape(
            int x,
            int y,
            int length)
        {
            X = x;
            Y = y;
            Length = length;
        }
    }
}
