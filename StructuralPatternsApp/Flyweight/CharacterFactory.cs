using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRenderer.Flyweight
{
    public class CharacterFactory
    {
        private Dictionary<string, ICharacter> _characters = new Dictionary<string, ICharacter>();

        public ICharacter GetCharacter(char symbol, string font)
        {
            string key = symbol + font;
            if (!_characters.ContainsKey(key))
            {
                _characters[key] = new ConcreteCharacter(symbol, font);
            }
            return _characters[key];
        }
    }
}
