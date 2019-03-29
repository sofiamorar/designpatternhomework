using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicComposite
{
    public class Picture : Shape
    {
        public Picture(int id, string color) : base(id, color)
        {

        }

        public void AddShape(Shape shape)
        {

        }

        public void Remove(Shape shape)
        {

        }

        public override string Draw()
        {
            return "Id: " + id.ToString("N2") + "\tColor: " + color;
        }
    }
}
