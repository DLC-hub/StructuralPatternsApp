using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRenderer.Bridge
{
    public class VectorRenderer : IRenderer
    {
        public void Render(string shapeType)
        {
            Console.WriteLine($"Векторное отображение {shapeType}");
        }
    }
}
    
