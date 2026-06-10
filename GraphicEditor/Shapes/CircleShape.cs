using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Shapes
{
    /// <summary>
    /// Circle data model.
    /// </summary>
    public class CircleShape : Shape
    {
        public int X { get; }

        public int Y { get; }

        public int Radius { get; }

        public CircleShape(
            int x,
            int y,
            int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
    }
}
