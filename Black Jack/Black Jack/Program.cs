using Black_Jack;

public class BlackJack
{
    static void Main(string[] args)
    {

        //1 deck card
        Card[] deck = new Card[52];

        //Array of suits
        string[] suit = { "Hearts", "Diamonds", "Spades", "Clubs" };

        byte deckCount = 0;

        //Creating deck
        for (int i = 0; i < suit.Length; i++)
        {
            for (byte j = 1; j <= 13; j++)
            {
                if (j == 1)
                {
                    deck[deckCount] = new Card(suit[i], j, 11);
                    deckCount++;
                }
                else if (j == 11 || j == 12 || j == 13)
                {
                    deck[deckCount] = new Card(suit[i], j, 10);
                    deckCount++;
                }
                else
                {
                    deck[deckCount] = new Card(suit[i], j, j);
                    deckCount++;
                }
            }
        }


        //Deck is created
        /*
        foreach (Card card in deck)
        {
            Console.WriteLine(card.Suit + ": " + card.Value + " | " + card.Point);
        }
        */

        //Shuffle card
        deck = Shuffle(deck);
        
        //Scores
        byte playerScore = 0;
        byte computerScore = 0;

        //Which turn
        byte turn = 0;

        //Point on the index
        byte indexpointer = 0;

        //Set's while to true
        bool play = true;

        //While loop
        while (play)
        {
            //Checks if someone have lost
            if (playerScore > 21)
            {
                Console.WriteLine("Player lost: " + playerScore);
                play = false;
            } else if (computerScore > 21)
            {
                Console.WriteLine("Computer lost: " + computerScore);
                play = false;
            }

            if (turn == 0)
            {
                //Players turn

                for (int i = 1; i <= 2; i++)
                {
                    Console.WriteLine(deck[indexpointer].ToString());

                    playerScore += deck[indexpointer].Point;

                    indexpointer++;
                }
                Console.WriteLine("Player score: " + playerScore);
                Console.ReadKey();

                //Set to computers turn
                turn = 1;
            }
            else
            {

                //Computers turn

                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine(deck[indexpointer].ToString());
                    computerScore += deck[indexpointer].Point;

                    indexpointer++;
                }
                
                Console.WriteLine("Computer score: " + computerScore);
                Console.ReadKey();

                Console.WriteLine("Hold your number or not: (Hold/H | Not/N");
                char choice = char.Parse(Console.ReadLine());

                if (choice == 'h')
                {
                    byte finalPlayerScore = playerScore;

                    //Set to computers turn
                    turn = 1;

                }
                else
                {
                    turn = 0;
                }
            }
        }

    }

    public static Card[] Shuffle(Card[] sorted)
    {
        Random random = new Random();
        for (int i = 0; i < 200; i++)
        {
            int index1 = random.Next(0, sorted.Length);
            int index2 = random.Next(0, sorted.Length);

            Card placeholder = sorted[index1];

            sorted[index1] = sorted[index2];
            sorted[index2] = placeholder;
        }
        return sorted;
    }
}