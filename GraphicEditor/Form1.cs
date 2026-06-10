using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicEditor.Shapes;
using GraphicEditor.Factories;
using GraphicEditor.Collections;
using GraphicEditor.Renderers;

namespace GraphicEditor
{
    /// <summary>
    /// Main application window for graphical editor.
    /// </summary>
    public partial class Form1 : Form
    {

        private ShapeList shapeList =
    new ShapeList();

        private List<IShapeFactory> factories =
            new List<IShapeFactory>();

        private Dictionary<Type, IShapeRenderer> renderers =
    new Dictionary<Type, IShapeRenderer>();

        public Form1()
        {

            InitializeComponent();

            factories.Add(new RectangleFactory());
            factories.Add(new CircleFactory());
            factories.Add(new EllipseFactory());
            factories.Add(new SquareFactory());
            factories.Add(new LineFactory());
            factories.Add(new TriangleFactory());

            comboBoxShapes.DataSource = factories;
            comboBoxShapes.DisplayMember = "Name";

            renderers.Add(typeof(RectangleShape),new RectangleRenderer());
            renderers.Add(typeof(CircleShape),new CircleRenderer());
            renderers.Add(typeof(EllipseShape),new EllipseRenderer());
            renderers.Add(typeof(SquareShape),new SquareRenderer());
            renderers.Add(typeof(LineShape),new LineRenderer());
            renderers.Add(typeof(TriangleShape),new TriangleRenderer());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int x =
    int.Parse(txtX.Text);

            int y =
                int.Parse(txtY.Text);

            int width =
                int.Parse(txtWidth.Text);

            int height =
                int.Parse(txtHeight.Text);

            IShapeFactory factory =
                (IShapeFactory)
                comboBoxShapes.SelectedItem;

            Shape shape =
                factory.Create(
                    x,
                    y,
                    width,
                    height);

            shapeList.Add(shape);

            Invalidate();
        }

        protected override void OnPaint(
    PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (Shape shape
                     in shapeList.GetAll())
            {
                renderers[
                    shape.GetType()]
                    .Draw(
                        e.Graphics,
                        shape);
            }
        }
    }
}
