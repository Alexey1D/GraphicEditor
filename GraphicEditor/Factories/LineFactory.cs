using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicEditor.Shapes;

namespace GraphicEditor.Factories
{
    public class LineFactory : IShapeFactory
    {
        public string Name
        {
            get { return "Line"; }
        }

        public Shape Create(
            int x,
            int y,
            int width,
            int height)
        {
            return new LineShape(
                x,
                y,
                width);
        }
    }
}
