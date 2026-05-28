using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRenderer.Flyweight
{
    public class ConcreteCharacter : ICharacter
    {
        private char _symbol;
        private string _font;

        public ConcreteCharacter(char symbol, string font)
        {
            _symbol = symbol;
            _font = font;
        }

        public void Display(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(_symbol);
        }
    }
}

