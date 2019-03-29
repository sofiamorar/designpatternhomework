using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicComposite
{
    public abstract class Shape
    {
        protected int id;
        protected string color;

        public Shape(int id, string color)
        {
            this.id = id;
            this.color = color;
        }

        public abstract string Draw();
    }
}
