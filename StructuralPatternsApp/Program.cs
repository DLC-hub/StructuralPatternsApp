using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentRenderer.Flyweight;
using DocumentRenderer.Proxy;
using DocumentRenderer.Bridge;
using DocumentRenderer.Decorator;

namespace DocumentRenderer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Демонстрация паттернов проектирования ===\n");

           
            Console.WriteLine("1. Паттерн Flyweight (легковес):");
            var factory = new CharacterFactory();
            var char1 = factory.GetCharacter('A', "Arial");
            var char2 = factory.GetCharacter('B', "Arial");
            var char3 = factory.GetCharacter('A', "Arial"); 

            char1.Display(0, 0);
            char2.Display(1, 0);
            char3.Display(2, 0);
            Console.WriteLine();

           
            Console.WriteLine("\n2. Паттерн Proxy (заместитель):");
            IImage image1 = new ImageProxy("photo1.jpg");
            IImage image2 = new ImageProxy("photo2.jpg");

            Console.WriteLine("Первый вызов:");
            image1.Display(); 
            Console.WriteLine("Второй вызов:");
            image1.Display(); 

            
            Console.WriteLine("\n3. Паттерн Bridge (мост):");
            IRenderer vectorRenderer = new VectorRenderer();
            Shape circle = new Circle(vectorRenderer);
            circle.Draw();

            
            Console.WriteLine("\n4. Паттерн Decorator (декоратор):");
            GraphicComponent rectangle = new Rectangle();
            GraphicComponent decoratedRectangle = new ShadowDecorator(rectangle);

            Console.WriteLine("Базовый компонент:");
            rectangle.Draw();
            Console.WriteLine("\nДекоратор с тенью:");
            decoratedRectangle.Draw();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

