using System;
using System.Collections.Generic;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {

        private static int gamesPlayed = 0;
        static void Main(string[] args)
        {
            Adventurer ActiveAdventurer = CurrentAdventurer(50);
            Game(ActiveAdventurer);
        }

        static void Game(Adventurer theAdventurer)
        {

            int minAwesomeness = 0;
            int maxAwesomeness = 100;

            List<Challenge> challenges = ChallengeList();
            foreach (Challenge challenge in challenges)
            {
                challenge.RunChallenge(theAdventurer);
            }

            if (theAdventurer.Awesomeness >= maxAwesomeness)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
            }
            else if (theAdventurer.Awesomeness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
            }
            Prize adventurerPrize = new Prize("An Unusually Light Chicken");
            adventurerPrize.ShowPrize(theAdventurer);
            NewGame(theAdventurer);
        }

        static void NewGame(Adventurer theAdventurer)
        {

            Console.WriteLine(theAdventurer.Awesomeness);
            Console.WriteLine("Would you like to play again? (Y/N)");
            string response = Console.ReadLine();
            if (response == "Y" || response == "y")
            {
                gamesPlayed += 1;
                Console.WriteLine(gamesPlayed);
                theAdventurer.Awesomeness = gamesPlayed * 10 + 50;
                Console.WriteLine(theAdventurer.Awesomeness);
                Game(theAdventurer);
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }


        static List<Challenge> ChallengeList()
        {
            Challenge howOld = new Challenge("How old is the editor of this game?", 25, 25);
            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge(
                "What is the current second?", DateTime.Now.Second, 50);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
    1) John
    2) Paul
    3) George
    4) Ringo
",
                4, 20
            );
            Challenge favoriteColor = new Challenge(
                @"What's my favorite color?
    1) Goldenrod
    2) Rebecca Purple
    3) Yellow
    4) Orange
",
                2, 20
            );
            Challenge favoriteGame = new Challenge(
                @"What's my favorite game?
    1) Legend of Zelda: Tears of the Kingdom
    2) Fortnite
    3) Minecraft
    4) Counter-Strike: Global Offensive
",
                4, 20
            );
            Challenge ponder = new Challenge(
                @"Why?
    1) Because I said so.
    2) What?
    3) Yes.
    4) Why not?
",
                1, 60
            );
            Challenge magicConch = new Challenge(
                @"May I have something to eat?
    1) No.
    2) Try again.
    3) ~No~
    4) Of course!
",
                3, 15
            );


            List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle,
                howOld,
                favoriteColor,
                favoriteGame,
                ponder,
                magicConch
            };

            List<Challenge> UsedChallenges = new List<Challenge>();

            List<int> indexes = new List<int>();

            while (indexes.Count < 5)
            {
                Random r = new Random();
                int genRand = r.Next(0, challenges.Count - 1);
                if (!indexes.Contains(genRand))
                {
                    indexes.Add(genRand);
                }
            }

            for (int i = 0; i < indexes.Count; i++)
            {
                int index = indexes[i];
                UsedChallenges.Add(challenges[index]);
            }



            return UsedChallenges;


        }

        static Adventurer CurrentAdventurer(int awesomeness)
        {
            // Make a new "Adventurer" object using the "Adventurer" class
            Console.WriteLine("What is the adventurer's name?");
            string name = Console.ReadLine();
            Hat adventurerHat = new Hat(4);
            Robe adventurerRobe = new Robe()
            {
                Colors = new List<string> { "Red", "Orange", "Yellow" },
                Length = 55
            };
            Adventurer theAdventurer = new Adventurer(name, adventurerRobe, adventurerHat, awesomeness);
            Console.WriteLine(theAdventurer.GetDescription());
            return theAdventurer;
        }
    }
}
