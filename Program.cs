using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape line = new Picture(1, "this is a red line");
            Shape rectangular = new Picture(2, "this is a blue rectangular");
            Shape circle = new Picture(5, "this is a circle");

            Picture picture = new Picture(3, "this is a green picture");

            Graphic graphic = new Graphic(4, "whole graphic");

            graphic.AddShape(picture);
            graphic.AddShape(circle);

            Console.WriteLine(graphic.Draw());

            Console.Read();
        }
    }
}
