using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicEditor.Shapes;

namespace GraphicEditor.Collections
{
    /// <summary>
    /// Stores collection of shapes in memory.
    /// </summary>
    public class ShapeList
    {
        private List<Shape> shapes =
            new List<Shape>();

        public void Add(
            Shape shape)
        {
            shapes.Add(shape);
        }

        public IEnumerable<Shape>
            GetAll()
        {
            return shapes;
        }
    }
}
