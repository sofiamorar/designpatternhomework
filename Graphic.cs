using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicComposite
{
    public class Graphic : Shape
    {
        List<Shape> shapelst = new List<Shape>();
        public Graphic(int id, string color) : base(id, color)
        {
               
        }
        public void AddShape(Shape shape)
        {
            shapelst.Add(shape);
        }

        public void Remove(Shape shape)
        {
            shapelst.Remove(shape);
        }

        public override string Draw()
        {
            StringBuilder sbshape = new StringBuilder();
            sbshape.Append("shape color: " + color + "\tid: " + id.ToString("N2") + "\n");
            foreach (Shape emp in shapelst)
            {
                sbshape.Append(emp.Draw() + "\n");
            }

            return sbshape.ToString();
        }
    }
}
