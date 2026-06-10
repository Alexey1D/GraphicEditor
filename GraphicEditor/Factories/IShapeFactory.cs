using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicEditor.Shapes;

namespace GraphicEditor.Factories
{
    /// <summary>
    /// Creates shape objects.
    /// </summary>
    public interface IShapeFactory
    {
        string Name { get; }

        Shape Create(
            int x,
            int y,
            int width,
            int height);
    }
}
