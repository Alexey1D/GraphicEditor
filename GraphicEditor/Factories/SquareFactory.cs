using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicEditor.Shapes;

namespace GraphicEditor.Factories
{
    public class SquareFactory : IShapeFactory
    {
        public string Name
        {
            get { return "Square"; }
        }

        public Shape Create(
            int x,
            int y,
            int width,
            int height)
        {
            return new SquareShape(
                x,
                y,
                width);
        }
    }
}
