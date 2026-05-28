using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRenderer.Proxy
{
    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            System.Threading.Thread.Sleep(1000); // Это имитация загрузки
            Console.WriteLine($"Загружаю {fileName}");
        }

        public void Display()
        {
            Console.WriteLine($"Отображаю {_fileName}");
        }
    }
}

