using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Player
    {

        public Value[] _Hand;
        public int _PickedCards;
        public int _Points;


        public Player()
        {
            _Hand = new Value[5];
            _PickedCards = 0;
            _Points = 0;
        }
    }
    internal struct Value
    {
        private string _suit;
        private int _value;
        private int _points;

        public int _Value
        { get => _value; }
        public int _Points
        {
            get { return _points; }
            set { _points = value; }
        }
        public string _Suit
        { get => _suit; }

        public Value(int s, int v)
        {

            _value = v;
            switch (s)
            {
                case 1:
                    _suit = "♣";
                    break;
                case 2:
                    _suit = "♦";
                    break;
                case 3:
                    _suit = "♥";
                    break;
                case 4:
                    _suit = "♠";
                    break;

            }

            if (_value > 10)
            {
                _points = 10;
            }
            else if (_value == 1)
            {
                _points = 11;
            }
            else
            {
                _points = _value;
            }
        }
    }
}

