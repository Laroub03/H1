using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
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
                SuitName clubs = new SuitName { _Name = "♣" };
                SuitName diamonds = new SuitName { _Name = "♦" };
                SuitName hearts = new SuitName { _Name = "♥" };
                SuitName spades = new SuitName { _Name = "♠" };


                _value = v;
                switch (s)
                {
                    case 1:
                        _suit = clubs._Name;
                        break;
                    case 2:
                        _suit = diamonds._Name;
                        break;
                    case 3:
                        _suit = hearts._Name;
                        break;
                    case 4:
                        _suit = spades._Name;
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

