using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRenderer.Decorator
{
    public class ShadowDecorator : GraphicDecorator
    {
        public ShadowDecorator(GraphicComponent component) : base(component) { }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Добавляем тень");
        }
    }
}

