using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DocumentRenderer.Decorator
{
    public class Rectangle : GraphicComponent
    {
        public override void Draw()
        {
            Console.WriteLine("Рисуем прямоугольник");
        }
    }
}
