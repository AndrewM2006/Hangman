using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Word
    {
        private string _word;
        private Random _generator;
        private List<string> _easy = new List<string>() { "ACTED", "ADULT", "BRICK", "TRAIN", "EARTH", "APPLE", "BREAD", "CLOCK", "DANCE", "GRAPE", "MONEY", "HOUSE", "HAPPY", "PLANT", "SMILE", "WATER", "STORM", "PARTY", "HEART", "CLICK" };
        private List<string> _medium = new List<string>() { "ABSOLUTE", "COMPUTER", "CONFLICT", "ADJUSTED", "CHEMICAL", "EQUATION", "DIVISION", "DOCUMENT", "MAXIMIZE", "PAINTING", "PROVINCE", "REMEMBER", "QUANTITY", "POWERFUL", "SCENARIO", "SYNDROME", "TRIANGLE", "WHATEVER", "VIOLENCE"};
        private List<string> _hard = new List<string>() { "ADIEU", "RURAL", "OUIJA", "AZURE", "PHENOMENON", "ONOMATOPOEIA", "ATOLL", "SMITE", "FLOUT", "TRYST", "RUPEE", "TROVE", "FLABBERGAST", "OBDURATE", "QUINCUNX", "VELLEITY", "ACUMEN", "ALDWORTH", "BASTION", "CONUNDRUM", "CREDULITY", "EFFETE", "EGREGIOUS", "FRACTIOUS", "GALVANIZE"};

        public Word()
        {
            _generator=new Random();
        }
        public void Easy()
        {
            _word = _easy[_generator.Next(0, _easy.Count())];
        }
        public void Medium()
        {
            _word = _medium[_generator.Next(0, _medium.Count())];
        }
        public void Hard()
        {
            _word = _hard[_generator.Next(0, _hard.Count())];
        }
        public string TheWord
        {
            get { return _word; }
        }
    }
}
