using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal struct Game
    {
        public Game()
        {
            _hand = new Value[5];
            _pickedCard = 0;
            _points = 0;
            _userPoints = 0;
            _computerPoints = 0;
            //_points += _computerPoints;
            //_points += _userPoints;

        }

        Player[] players = new Player[5];
        private Value[] _deck;
        private Value _card;
        private int _pointer;
        
        private Value[] _hand;
        private int _pickedCard;
        private int _points;
        private int _userPoints;
        private int _computerPoints;

        public Value[] _Hand
        { get => _hand; }
        public int _PickedCard
        {
            get { return _pickedCard; }
            set { _pickedCard = value; }
        }
        public int _Points
        {
            get { return _points; }
            set { _points = value; }
        }
        public int _Pointer
        { get => _pointer; }
        public Value[] _Deck
        { get => _deck; }
        public Value _Card
            { get => _card; }

        public int _UserPoints
        {
            get { return _userPoints; }
            set { _userPoints = value; }
        }
        public int _ComputerPoint
        {
            get { return _computerPoints; }
            set { _computerPoints = value; }
        }

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

        public void Hand()
        {

            Console.Write("Current Hand: ");

            for (int i = 0; i < _pickedCard; i++)
            {
                Symbol(_Hand[i]);
            }
            Console.WriteLine("Current points: {0}.", _points);
        }

        public void Draw(Value[] _deck)
        {
            Value nextCard = _deck[_pointer];

            if (_pickedCard < 5)
            {
                _hand[_pickedCard] = nextCard;

                _pickedCard++;
                _points += nextCard._Points;

                _pointer++;
            }
        }

        public bool PointChecker()
        {
            
            //_userPoints
            if (_points > 21)
            {
                Console.WriteLine("Bust!");
                return false;
            }

            return true;
        }
        public void AceChecker()
        {
            bool changed = false;
            
            if (_points > 21)
            {
                for (int i = 0; i < _pickedCard; i++)
                {
                    if (_hand[i]._Points == 11 && changed == false)
                    {
                        _hand[i]._Points = 1;
                        _points -= 10;
                        changed = true;
                    }
                }
            }

        }

        public void User()
        {
            Value[] _deck = CreateDeck();
            DeckShuffler(_deck);
            _points = 0;
            _pickedCard = 0;
            _points += _userPoints;

            Draw(_deck);
            Draw(_deck);


            AceChecker();
            Hand();
            PointChecker();
            bool alive = true;

            string choice = "";

            while (alive == true && choice != "STICK")
            {
                Console.Write("Hit or Stick? ");
                choice = Console.ReadLine().ToUpper();
                if (choice == "HIT")
                {
                    Draw(_deck);


                    AceChecker();
                    Hand();
                    alive = PointChecker();
                }
            }
        }

        public void Computer()
        {
            Value[] _deck = CreateDeck();
            DeckShuffler(_deck);
            
            _points = 0;
            _pickedCard = 0;
            _points += _computerPoints;

            bool alive = true;
            if (alive == true)
            {
                bool computerAlive = true;

                Console.WriteLine();
                Console.WriteLine("--- Computer's Turn ---");

                Draw(_deck);
                Draw(_deck);

                AceChecker();
                Hand();
                PointChecker();

                    if(_computerPoints > _userPoints)
                    {
                        Console.WriteLine("Computer Won!");
                        computerAlive = false;
                    }
                    else if(_userPoints > _computerPoints)
                    {
                        Console.WriteLine("You Won!");
                            computerAlive=false;
                    }
                while (computerAlive)
                {

                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();

                    Draw(_deck);

                    AceChecker();
                    Hand();
                    computerAlive = PointChecker();

                //else
                //{
                //    Console.WriteLine("You Won!");
                        
                //}
                }
            }
        }




        public void Start()
        {

            string playAgain = "";
            do
            {

                User();

                Computer();
                

                Console.Write("Do you want to play again? Y/N ");
                playAgain = Console.ReadLine().ToUpper();

            } while (playAgain == "Y");

        }
    }
}