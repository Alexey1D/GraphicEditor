using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicEditor.Shapes;

namespace GraphicEditor.Factories
{
    /// <summary>
    /// Creates circles.
    /// </summary>
    public class CircleFactory : IShapeFactory
    {
        public string Name
        {
            get { return "Circle"; }
        }

        public Shape Create(
            int x,
            int y,
            int width,
            int height)
        {
            return new CircleShape(
                x,
                y,
                width);
        }
    }
}
