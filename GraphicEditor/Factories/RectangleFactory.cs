using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicEditor.Shapes;

namespace GraphicEditor.Factories
{
    /// <summary>
    /// Creates rectangle shape objects.
    /// </summary>
    public class RectangleFactory : IShapeFactory
    {
        public string Name
        {
            get { return "Rectangle"; }
        }
        /// <summary>
        /// Creates a new rectangle instance.
        /// </summary>
        public Shape Create(
            int x,
            int y,
            int width,
            int height)
        {
            return new RectangleShape(
                x,
                y,
                width,
                height);
        }
    }
}
