using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicEditor.Shapes;

namespace GraphicEditor.Factories
{
    public class EllipseFactory : IShapeFactory
    {
        public string Name
        {
            get { return "Ellipse"; }
        }

        public Shape Create(
            int x,
            int y,
            int width,
            int height)
        {
            return new EllipseShape(
                x,
                y,
                width,
                height);
        }
    }
}