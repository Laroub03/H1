using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Game
    {


        Player[] players = new Player[5];
        private Value[] _deck;
        private Value _card;
        private int _pointer;
        
        public int _Pointer
        { get => _pointer; }
        public Value[] _Deck
        { get => _deck; }
        public Value _Card
            { get => _card; }


        public Value[] CreateDeck()
        {
            Value[] _deck = new Value[52];
            int counter = 0;

            for (int suit = 1; suit < 5; suit++)
            {
                for (int value = 1; value < 14; value++)
                {
                    _deck[counter] = new Value(suit, value);
                    counter++;
                }
            }

            return _deck;
        }

        public void DeckShuffler( Value[] _deck )
        {
            Random random = new Random();
            Value temp;
            int num;

            for (int i = 0; i < _deck.Length; i++)
            {
                num = random.Next(0, _deck.Length);
                temp = _deck[i];
                _deck[i] = _deck[num];
                _deck[num] = temp;
            }
        }

        public void Symbol(Value _card)
        {
            switch (_card._Value)
            {
                case 1:
                    Console.Write("A{0} ", _card._Suit);
                    break;

                case 11:
                    Console.Write("J{0} ", _card._Suit);
                    break;

                case 12:
                    Console.Write("Q{0} ", _card._Suit);
                    break;

                case 13:
                    Console.Write("K{0} ", _card._Suit);
                    break;
                default:
                    Console.Write("{0}{1} ", _card._Value, _card._Suit);
                    break;
            }
        }

        public void Hand(Player player)
        {

            Console.Write("Current Hand: ");

            for (int i = 0; i < player._PickedCards; i++)
            {
                Symbol(player._Hand[i]);
            }
            Console.WriteLine("Current points: {0}.", player._Points);
        }

        public void Draw(Value[] _deck, Player player)
        {
            Value nextCard = _deck[_pointer];

            if (player._PickedCards < 5)
            {
                player._Hand[player._PickedCards] = nextCard;

                player._PickedCards++;
                player._Points += nextCard._Points;

                _pointer++;
            }
        }

        public bool PointChecker(Player player)
        {
            
            if (player._Points > 21)
            {
                Console.WriteLine("Bust!");
                return false;
            }


            return true;
        }
        public void AceChecker( Player player)
        {
            bool changed = false;
            
            if (player._Points > 21)
            {
                for (int i = 0; i < player._PickedCards; i++)
                {
                    if (player._Hand[i]._Points == 11 && changed == false)
                    {
                        player._Hand[i]._Points = 1;
                        player._Points -= 10;
                        changed = true;
                        
                    }
                }
                
            }
            

        }

        public void calculateWinner(Player player, Player dealer)
        { 
            if (dealer._Points > 21)
            {
                Console.WriteLine("You Won!");
            }

            else if (dealer._Points == player._Points)
            {
                Console.WriteLine("Draw!");
            }

            else if (dealer._Points < 21 && dealer._Points > player._Points  )
            {
                Console.WriteLine("Computer Won!");
            }

        }
    }
}