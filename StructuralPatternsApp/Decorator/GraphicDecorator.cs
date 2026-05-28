using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRenderer.Decorator
{
    public abstract class GraphicDecorator : GraphicComponent
    {
        protected GraphicComponent Component;

        public GraphicDecorator(GraphicComponent component)
        {
            Component = component;
        }

        public override void Draw()
        {
            Component.Draw();
        }
    }
}

