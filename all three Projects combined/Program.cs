using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_three_Projects_combined
{
    enum Colors
    {
        White, Red, Green, Blue, Black, Yellow, Blank

    }

    class Program
    {
        static void Main()
        {
            string gameChoice;
            int gameMode = -1;
            Console.WriteLine("Hello This is your personal game manager.");
            Console.WriteLine("You have three games in your library ");
            Console.WriteLine("The games you can choose between are MasterMind, Jeopardy and Minesweeper");
            Console.WriteLine("Please choose your poison.");
            gameChoice = Console.ReadLine();

            if (gameChoice == "MasterMind")
            {
                gameMode = 0;
                Console.Clear();

                MasterMind(gameMode);
            }
            else if (gameChoice == "Jeopardy")
            {
                gameMode = 1;
                Console.Clear();

                Jeopardy(gameMode);

            }
            else if (gameChoice == "Minesweeper")
            {
                gameMode = 2;
                Console.Clear();

                MineSweeper(gameMode);

            }

            

            
            
        }

        static void MasterMind(int gameMode)
        {
            while (gameMode == 0)
            {
                string yesNo;
                Colors[] colorAnswer = new Colors[4];
                Colors[] colorGuess = new Colors[4];
                byte correctPlacement = 0;
                byte correctColor = 0;


                Console.WriteLine("Hello, and welcome to MasterMind!");
                Console.WriteLine("The rules are as follows Player 1 chooses four colors");
                Console.WriteLine("Then Player 2 has to guess what colors have been chosen and in what sequence they are placed");
                Console.WriteLine("Remember Player two has 10 turns to guess correct or they lose the game");
                Console.WriteLine($"You can choose between these colors: {Colors.Black}, {Colors.White}, {Colors.Blue}, {Colors.Green}, {Colors.Red}, {Colors.Yellow}");
                Console.WriteLine("Now we proceed to the game, press enter to proceed");

                Console.ReadKey();

                Console.WriteLine("Player one choose your first color");
                //herfår vi input om hvilken farve spiller 1 har valgt og kalder funktionen for at få lavet stringen om til enum'en.

                colorAnswer[0] = PlayerChoice(Console.ReadLine());
                while (colorAnswer[0] == Colors.Blank)
                {
                    Console.WriteLine("This is not one of the colors, please try again");
                    colorAnswer[0] = PlayerChoice(Console.ReadLine());

                }

                Console.WriteLine("Player one choose your second color");
                //herfår vi input om hvilken farve spiller 1 har valgt og kalder funktionen for at få lavet stringen om til enum'en.
                colorAnswer[1] = PlayerChoice(Console.ReadLine());
                while (colorAnswer[1] == Colors.Blank)
                {
                    Console.WriteLine("This is not one of the colors, please try again");
                    colorAnswer[1] = PlayerChoice(Console.ReadLine());

                }
                Console.WriteLine("Player one choose your third color");
                colorAnswer[2] = PlayerChoice(Console.ReadLine());

                while (colorAnswer[2] == Colors.Blank)
                {
                    Console.WriteLine("This is not one of the colors, please try again");
                    colorAnswer[2] = PlayerChoice(Console.ReadLine());

                }
                Console.WriteLine("Player one choose your final color");
                colorAnswer[3] = PlayerChoice(Console.ReadLine());
                while (colorAnswer[3] == Colors.Blank)
                {
                    Console.WriteLine("This is not one of the colors, please try again");
                    colorAnswer[3] = PlayerChoice(Console.ReadLine());

                }

                Console.Clear();
                Console.WriteLine("Player 2 now has to guess the four colors that player one has placed.");
                Console.WriteLine("Player 2 has 10 tries to do this");

                for (int i = 0; i < 10; i++)
                {
                    correctPlacement = 0;
                    correctColor = 0;
                    if (i > 0)
                    {
                        Console.WriteLine($"You have used {i} turns ");
                    }

                    Console.WriteLine($"You can choose between these colors: {Colors.Black}, {Colors.White}, {Colors.Blue}, {Colors.Green}, {Colors.Red}, {Colors.Yellow}");

                    colorGuess[0] = PlayerChoice(Console.ReadLine());
                    while (colorGuess[0] == Colors.Blank)
                    {
                        Console.WriteLine("This is not one of the colors, please try again");
                        colorGuess[0] = PlayerChoice(Console.ReadLine());

                    }

                    Console.WriteLine("What is your second guess?");
                    colorGuess[1] = PlayerChoice(Console.ReadLine());
                    while (colorGuess[1] == Colors.Blank)
                    {
                        Console.WriteLine("This is not one of the colors, please try again");
                        colorGuess[1] = PlayerChoice(Console.ReadLine());

                    }

                    Console.WriteLine("What is your second guess?");
                    colorGuess[2] = PlayerChoice(Console.ReadLine());
                    while (colorGuess[2] == Colors.Blank)
                    {
                        Console.WriteLine("This is not one of the colors, please try again");
                        colorGuess[2] = PlayerChoice(Console.ReadLine());

                    }

                    Console.WriteLine("What is your second guess?");
                    colorGuess[3] = PlayerChoice(Console.ReadLine());
                    while (colorGuess[3] == Colors.Blank)
                    {
                        Console.WriteLine("This is not one of the colors, please try again");
                        colorGuess[3] = PlayerChoice(Console.ReadLine());

                    }
                    //her bliver der tjekket om første placerede farve er rigtigt placeret eller ej.

                    if (colorGuess[0] == colorAnswer[0])
                    {
                        correctPlacement++;
                        correctColor++;
                    }
                    else if (colorGuess[1] == colorAnswer[0])
                    {
                        correctColor++;

                    }
                    else if (colorGuess[2] == colorAnswer[0])
                    {
                        correctColor++;


                    }
                    else if (colorGuess[3] == colorAnswer[0])
                    {
                        correctColor++;

                    }
                    //her bliver der tjekket om den anden placerede farve er rigtigt placeret eller ej.

                    if (colorGuess[1] == colorAnswer[1])
                    {
                        correctPlacement++;
                        correctColor++;

                    }
                    else if (colorGuess[0] == colorAnswer[1])
                    {

                        correctColor++;

                    }
                    else if (colorGuess[2] == colorAnswer[1])
                    {
                        correctColor++;


                    }
                    else if (colorGuess[3] == colorAnswer[1])
                    {
                        correctColor++;


                    }
                    //her bliver der tjekket om den tredje placerede farve er rigtigt placeret eller ej.

                    if (colorGuess[2] == colorAnswer[2])
                    {
                        correctPlacement++;
                        correctColor++;


                    }
                    else if (colorGuess[1] == colorAnswer[2])
                    {
                        correctColor++;



                    }
                    else if (colorGuess[0] == colorAnswer[2])
                    {

                        correctColor++;


                    }
                    else if (colorGuess[3] == colorAnswer[2])
                    {
                        correctColor++;


                    }
                    //her bliver der tjekket om den fjerde placerede farve er rigtigt placeret eller ej.

                    if (colorGuess[3] == colorAnswer[3])
                    {
                        correctPlacement++;
                        correctColor++;


                    }
                    else if (colorGuess[1] == colorAnswer[3])
                    {
                        correctColor++;


                    }
                    else if (colorGuess[2] == colorAnswer[3])
                    {
                        correctColor++;


                    }
                    else if (colorGuess[0] == colorAnswer[3])
                    {

                        correctColor++;


                    }
                    // her bliver der tjekket om spiller 2 har vundet spillet eller der skal bruges en omgang mere
                    if (correctPlacement == 4)
                    {


                        Console.WriteLine("Payer two has won this game of MASTERMIND!");
                        Console.WriteLine("Would you like to play another round Yes or No");
                        yesNo = Console.ReadLine();
                        if (yesNo == "Yes")
                        {
                            MasterMind(0);
                        }
                        else if (yesNo == "No")
                        {
                            Main();

                        }


                    }
                    else if (i == 9)
                    {

                        Console.WriteLine("The MASTERMIND has won this round");
                        Console.WriteLine("Would you like to play another round Yes or No");
                        yesNo = Console.ReadLine();
                        if (yesNo == "Yes")
                        {
                            MasterMind(0);
                        }
                        else if (yesNo == "No")
                        {
                            Main();

                        }
                        

                    }
                    else
                    {
                        Console.WriteLine($"Player two has placed {correctPlacement} correctly and is using {correctColor} of the rigt colors");
                        Console.ReadKey();
                        Console.Clear();

                    }



                }
            }
        }

        static Colors PlayerChoice(string text)
        {
            switch (text)
            {
                case "White":
                    return (Colors.White);
                case "white":
                    return (Colors.White);
                case "Blue":
                    return (Colors.Blue);
                case "blue":
                    return (Colors.Blue);
                case "Red":
                    return (Colors.Red);
                case "red":
                    return (Colors.Red);
                case "Green":
                    return (Colors.Green);
                case "green":
                    return (Colors.Green);
                case "Black":
                    return (Colors.Black);
                case "black":
                    return (Colors.Black);
                case "Yellow":
                    return (Colors.Yellow);
                case "yellow":
                    return (Colors.Yellow);
            }

            return (Colors.Blank);
        }

        static void Jeopardy(int gameMode)
        {
            while (gameMode == 1)
            {
                int teamTurn = 1;
                int teamOne = 0;
                int teamTwo = 0;
                int teamThree = 0;

                //Welcome
                Console.WriteLine("Welcome to Jeopardy");
                Console.WriteLine();
                //Ruleset
                Console.WriteLine("The rules are:");
                Console.ReadKey();
                Console.WriteLine("You will receive an answer, and to get points, you have to make a question.");
                Console.ReadKey();
                Console.WriteLine("For exampel: Copenhagen. The answer is: What is the capital in Denmark?");
                Console.ReadKey();
                Console.WriteLine("To goal is to get the most points. You will lose points equal to the number of points avaliable " +
                    "from the question.");
                Console.ReadKey();
                Console.WriteLine("You pick category. For Example: Capitols for 100 points.");
                Console.ReadKey();
                Console.WriteLine("Good Luck!!!");
                Console.ReadKey();
                //Teams
                Console.WriteLine();
                Console.WriteLine("Choose a name for team 1");
                string nameOne = Console.ReadLine();
                Console.WriteLine($"Team 1 is {nameOne}");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Choose a name for team 2");
                string nameTwo = Console.ReadLine();
                Console.WriteLine($"Team 2 is {nameTwo}");
                Console.WriteLine();
                Console.WriteLine("Choose a name for team 3");
                string nameThree = Console.ReadLine();
                Console.WriteLine($"Team 3 is {nameThree}");
                Console.ReadKey();
                Console.WriteLine();
                string[,] pointCat = new string[5, 5]
                    {
                {" 100  ", "  100  ", "   100   ", "    100    ", "    100    " },
                {" 200  ", "  200  ", "   200   ", "    200    ", "    200    " },
                {" 300  ", "  300  ", "   300   ", "    300    ", "    300    " },
                {" 400  ", "  400  ", "   400   ", "    400    ", "    400    " },
                {" 500  ", "  500  ", "   500   ", "    500    ", "    500    " }
                    };
                string[] categories = new string[] { " Math ", " Flags ", " Geography ", " Capitols ", " Chemistry " };
                int category = 0;

                while (true)
                {
                    //Jeopardy round 1

                    for (int g = 0; g < 1; g++)
                    {
                        for (int x = 0; x < categories.GetLength(0); x++)
                        {
                            Console.Write(categories[x]);
                        }
                        Console.Write(Environment.NewLine);

                    }
                    for (int x = 0; x < pointCat.GetLength(0); x++)
                    {
                        for (int y = 0; y < pointCat.GetLength(1); y++)
                        {
                            Console.Write(pointCat[x, y]);
                        }
                        Console.Write(Environment.NewLine + Environment.NewLine);
                    }
                    Console.WriteLine("Choose a category: Math, Flags, Geography, Capitols, Chemistry ");
                    string catChoice = Console.ReadLine();
                    category = CategoryChoice(catChoice);
                    Console.WriteLine($"You choose {catChoice} ");
                    Console.WriteLine("Choose the points you want to win");

                    //int[] myPoints = new int[5] { 100, 200, 300, 400, 500 };
                    /*
                    for (int i = 0; i < myPoints.Length; i++)
                    {
                        Console.WriteLine(myPoints[i]);
                    }
                    */
                    //Question choices
                    string questions = Console.ReadLine();
                    string myQuestion = " ";
                    switch (category)
                    {

                        case 0:
                            myQuestion = PointChoice(questions, 0);
                            Console.WriteLine(myQuestion);
                            break;
                        case 1:
                            myQuestion = PointChoice(questions, 1);
                            Console.WriteLine(myQuestion);
                            break;
                        case 2:
                            myQuestion = PointChoice(questions, 2);
                            Console.WriteLine(myQuestion);
                            break;
                        case 3:
                            myQuestion = PointChoice(questions, 3);
                            Console.WriteLine(myQuestion);
                            break;
                        case 4:
                            myQuestion = PointChoice(questions, 4);
                            Console.WriteLine(myQuestion);
                            break;

                    }
                    string answer = "";
                    if (myQuestion == "5+5?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is 10" && teamTurn == 1)
                        {
                            teamOne += 100;
                            pointCat[0, 0] = "      ";
                        }
                        else if (answer != "What is 10" && teamTurn == 1)
                        {
                            teamOne -= 100;
                            pointCat[0, 0] = "      ";
                        }
                        else if (answer == "What is 10" && teamTurn == 2)
                        {
                            teamTwo += 100;
                            pointCat[0, 0] = "      ";
                        }
                        else if (answer != "What is 10" && teamTurn == 2)
                        {
                            teamTwo -= 100;
                            pointCat[0, 0] = "      ";
                        }
                        else if (answer == "What is 10" && teamTurn == 3)
                        {
                            teamThree += 100;
                            pointCat[0, 0] = "      ";
                        }
                        else if (answer != "What is 10" && teamTurn == 3)
                        {
                            teamThree -= 100;
                            pointCat[0, 0] = "      ";
                        }

                    }

                    if (myQuestion == "10+10?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is 20" && teamTurn == 1)
                        {
                            teamOne += 200;
                            pointCat[1, 0] = "      ";
                        }
                        else if (answer != "What is 20" && teamTurn == 1)
                        {
                            teamOne -= 200;
                            pointCat[1, 0] = "      ";
                        }
                        else if (answer == "What is 20" && teamTurn == 2)
                        {
                            teamTwo += 200;
                            pointCat[1, 0] = "      ";
                        }
                        else if (answer != "What is 20" && teamTurn == 2)
                        {
                            teamTwo -= 200;
                            pointCat[1, 0] = "      ";
                        }
                        else if (answer == "What is 20" && teamTurn == 3)
                        {
                            teamThree += 200;
                            pointCat[1, 0] = "      ";
                        }
                        else if (answer != "What is 20" && teamTurn == 3)
                        {
                            teamThree -= 200;
                            pointCat[1, 0] = "      ";
                        }
                    }

                    if (myQuestion == "20+20?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is 40" && teamTurn == 1)
                        {
                            teamOne += 300;
                            pointCat[2, 0] = "      ";
                        }
                        else if (answer != "What is 40" && teamTurn == 1)
                        {
                            teamOne -= 300;
                            pointCat[2, 0] = "      ";
                        }
                        else if (answer == "What is 40" && teamTurn == 2)
                        {
                            teamTwo += 300;
                            pointCat[2, 0] = "      ";
                        }
                        else if (answer != "What is 40" && teamTurn == 2)
                        {
                            teamTwo -= 300;
                            pointCat[2, 0] = "      ";
                        }
                        else if (answer == "What is 40" && teamTurn == 3)
                        {
                            teamThree += 300;
                            pointCat[2, 0] = "      ";
                        }
                        else if (answer != "What is 40" && teamTurn == 3)
                        {
                            teamThree -= 300;
                            pointCat[2, 0] = "      ";
                        }
                    }

                    if (myQuestion == "40+40?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is 80" && teamTurn == 1)
                        {
                            teamOne += 400;
                            pointCat[3, 0] = "      ";
                        }
                        else if (answer != "What is 80" && teamTurn == 1)
                        {
                            teamOne -= 400;
                            pointCat[3, 0] = "      ";
                        }
                        else if (answer == "What is 80" && teamTurn == 2)
                        {
                            teamTwo += 400;
                            pointCat[3, 0] = "      ";
                        }
                        else if (answer != "What is 80" && teamTurn == 2)
                        {
                            teamTwo -= 400;
                            pointCat[3, 0] = "      ";
                        }
                        else if (answer == "What is 80" && teamTurn == 3)
                        {
                            teamThree += 400;
                            pointCat[3, 0] = "      ";
                        }
                        else if (answer != "What is 80" && teamTurn == 3)
                        {
                            teamThree -= 400;
                            pointCat[3, 0] = "      ";
                        }
                    }

                    if (myQuestion == "80+80?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is 160" && teamTurn == 1)
                        {
                            teamOne += 500;
                            pointCat[4, 0] = "      ";
                        }
                        else if (answer != "What is 160" && teamTurn == 1)
                        {
                            teamOne -= 500;
                            pointCat[4, 0] = "      ";
                        }
                        else if (answer == "What is 160" && teamTurn == 2)
                        {
                            teamTwo += 500;
                            pointCat[4, 0] = "      ";
                        }
                        else if (answer != "What is 160" && teamTurn == 2)
                        {
                            teamTwo -= 500;
                            pointCat[4, 0] = "      ";
                        }
                        else if (answer == "What is 160" && teamTurn == 3)
                        {
                            teamThree += 500;
                            pointCat[4, 0] = "      ";
                        }
                        else if (answer != "What is 160" && teamTurn == 3)
                        {
                            teamThree -= 500;
                            pointCat[4, 0] = "      ";
                        }
                    }

                    if (myQuestion == "Flag with a white cross?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Denmark" && teamTurn == 1)
                        {
                            teamOne += 100;
                            pointCat[0, 1] = "       ";
                        }
                        else if (answer != "What is Denmark" && teamTurn == 1)
                        {
                            teamOne -= 100;
                            pointCat[0, 1] = "       ";
                        }
                        else if (answer == "What is Denmark" && teamTurn == 2)
                        {
                            teamTwo += 100;
                            pointCat[0, 1] = "       ";
                        }
                        else if (answer != "What is Denmark" && teamTurn == 2)
                        {
                            teamTwo -= 100;
                            pointCat[0, 1] = "       ";
                        }
                        else if (answer == "What is Denmark" && teamTurn == 3)
                        {
                            teamThree += 100;
                            pointCat[0, 1] = "       ";
                        }
                        else if (answer != "What is Denmark" && teamTurn == 3)
                        {
                            teamThree -= 100;
                            pointCat[0, 1] = "       ";
                        }
                    }

                    if (myQuestion == "Flag with a yellow cross?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Sweden" && teamTurn == 1)
                        {
                            teamOne += 200;
                            pointCat[1, 1] = "       ";
                        }
                        else if (answer != "What is Sweden" && teamTurn == 1)
                        {
                            teamOne -= 200;
                            pointCat[1, 1] = "       ";
                        }
                        else if (answer == "What is Sweden" && teamTurn == 2)
                        {
                            teamTwo += 200;
                            pointCat[1, 1] = "       ";
                        }
                        else if (answer != "What is Sweden" && teamTurn == 2)
                        {
                            teamTwo -= 200;
                            pointCat[1, 1] = "       ";
                        }
                        else if (answer == "What is Sweden" && teamTurn == 3)
                        {
                            teamThree += 200;
                            pointCat[1, 1] = "       ";
                        }
                        else if (answer != "What is Sweden" && teamTurn == 3)
                        {
                            teamThree -= 200;
                            pointCat[1, 1] = "       ";
                        }
                    }

                    if (myQuestion == "Flag with a white and blue cross?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Norway" && teamTurn == 1)
                        {
                            teamOne += 300;
                            pointCat[2, 1] = "       ";
                        }
                        else if (answer != "What is Norway" && teamTurn == 1)
                        {
                            teamOne -= 300;
                            pointCat[2, 1] = "       ";
                        }
                        else if (answer == "What is Norway" && teamTurn == 2)
                        {
                            teamTwo += 300;
                            pointCat[2, 1] = "       ";
                        }
                        else if (answer != "What is Norway" && teamTurn == 2)
                        {
                            teamTwo -= 300;
                            pointCat[2, 1] = "       ";
                        }
                        else if (answer == "What is Norway" && teamTurn == 3)
                        {
                            teamThree += 300;
                            pointCat[2, 1] = "       ";
                        }
                        else if (answer != "What is Norway" && teamTurn == 3)
                        {
                            teamThree -= 300;
                            pointCat[2, 1] = "       ";
                        }
                    }

                    if (myQuestion == "Flag with a blue cross?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Finland" && teamTurn == 1)
                        {
                            teamOne += 400;
                            pointCat[3, 1] = "       ";
                        }
                        else if (answer != "What is Finland" && teamTurn == 1)
                        {
                            teamOne += 400;
                            pointCat[3, 1] = "       ";
                        }
                        else if (answer == "What is Finland" && teamTurn == 2)
                        {
                            teamOne += 400;
                            pointCat[3, 1] = "       ";
                        }
                        else if (answer != "What is Finland" && teamTurn == 2)
                        {
                            teamOne += 400;
                            pointCat[3, 1] = "       ";
                        }
                        else if (answer == "What is Finland" && teamTurn == 3)
                        {
                            teamOne += 400;
                            pointCat[3, 1] = "       ";
                        }
                        else if (answer != "What is Finland" && teamTurn == 3)
                        {
                            teamOne += 400;
                            pointCat[3, 1] = "       ";
                        }
                    }

                    if (myQuestion == "Flag made of triangles?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Nepal" && teamTurn == 1)
                        {
                            teamOne += 500;
                            pointCat[4, 1] = "       ";
                        }
                        else if (answer != "What is Nepal" && teamTurn == 1)
                        {
                            teamOne += 500;
                            pointCat[4, 1] = "       ";
                        }
                        else if (answer == "What is Nepal" && teamTurn == 2)
                        {
                            teamOne += 500;
                            pointCat[4, 1] = "       ";
                        }
                        else if (answer != "What is Nepal" && teamTurn == 2)
                        {
                            teamOne += 500;
                            pointCat[4, 1] = "       ";
                        }
                        else if (answer == "What is Nepal" && teamTurn == 3)
                        {
                            teamOne += 500;
                            pointCat[4, 1] = "       ";
                        }
                        else if (answer != "What is Nepal" && teamTurn == 3)
                        {
                            teamOne += 500;
                            pointCat[4, 1] = "       ";
                        }
                    }

                    if (myQuestion == "Eiffel tower is where?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Paris" && teamTurn == 1)
                        {
                            teamOne += 100;
                            pointCat[0, 2] = "         ";
                        }
                        else if (answer != "What is Paris" && teamTurn == 1)
                        {
                            teamOne -= 100;
                            pointCat[0, 2] = "         ";
                        }
                        else if (answer == "What is Paris" && teamTurn == 2)
                        {
                            teamTwo += 100;
                            pointCat[0, 2] = "         ";
                        }
                        else if (answer != "What is Paris" && teamTurn == 2)
                        {
                            teamTwo -= 100;
                            pointCat[0, 2] = "         ";
                        }
                        else if (answer == "What is Paris" && teamTurn == 3)
                        {
                            teamThree += 100;
                            pointCat[0, 2] = "         ";
                        }
                        else if (answer != "What is Paris" && teamTurn == 3)
                        {
                            teamThree -= 100;
                            pointCat[0, 2] = "         ";
                        }
                    }

                    if (myQuestion == "Leaning tower of pisa is where?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Italy" && teamTurn == 1)
                        {
                            teamOne += 200;
                            pointCat[1, 2] = "         ";
                        }
                        else if (answer != "What is Italy" && teamTurn == 1)
                        {
                            teamOne -= 200;
                            pointCat[1, 2] = "         ";
                        }
                        else if (answer == "What is Italy" && teamTurn == 2)
                        {
                            teamTwo += 200;
                            pointCat[1, 2] = "         ";
                        }
                        else if (answer != "What is Italy" && teamTurn == 2)
                        {
                            teamTwo -= 200;
                            pointCat[1, 2] = "         ";
                        }
                        else if (answer == "What is Italy" && teamTurn == 3)
                        {
                            teamThree += 200;
                            pointCat[1, 2] = "         ";
                        }
                        else if (answer != "What is Italy" && teamTurn == 3)
                        {
                            teamThree -= 200;
                            pointCat[1, 2] = "         ";
                        }
                    }

                    if (myQuestion == "Sydney opera house is where?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Australia" && teamTurn == 1)
                        {
                            teamOne += 300;
                            pointCat[2, 2] = "         ";
                        }
                        else if (answer != "What is Australia" && teamTurn == 1)
                        {
                            teamOne -= 300;
                            pointCat[2, 2] = "         ";
                        }
                        else if (answer == "What is Australia" && teamTurn == 2)
                        {
                            teamTwo += 300;
                            pointCat[2, 2] = "         ";
                        }
                        else if (answer != "What is Australia" && teamTurn == 2)
                        {
                            teamTwo -= 300;
                            pointCat[2, 2] = "         ";
                        }
                        else if (answer == "What is Australia" && teamTurn == 3)
                        {
                            teamThree += 300;
                            pointCat[2, 2] = "         ";
                        }
                        else if (answer != "What is Australia" && teamTurn == 3)
                        {
                            teamThree -= 300;
                            pointCat[2, 2] = "         ";
                        }
                    }

                    if (myQuestion == "Statue of Liberty is where?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is USA" && teamTurn == 1)
                        {
                            teamOne += 400;
                            pointCat[3, 2] = "         ";
                        }
                        else if (answer != "What is USA" && teamTurn == 1)
                        {
                            teamOne -= 400;
                            pointCat[3, 2] = "         ";
                        }
                        else if (answer == "What is USA" && teamTurn == 2)
                        {
                            teamTwo += 400;
                            pointCat[3, 2] = "         ";
                        }
                        else if (answer != "What is USA" && teamTurn == 2)
                        {
                            teamTwo -= 400;
                            pointCat[3, 2] = "         ";
                        }
                        else if (answer == "What is USA" && teamTurn == 3)
                        {
                            teamThree += 400;
                            pointCat[3, 2] = "         ";
                        }
                        else if (answer != "What is USA" && teamTurn == 3)
                        {
                            teamThree -= 400;
                            pointCat[3, 2] = "         ";
                        }
                    }

                    if (myQuestion == "Macchu Picchu is where?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Peru " && teamTurn == 1)
                        {
                            teamOne += 500;
                            pointCat[4, 2] = "         ";
                        }
                        else if (answer != "What is Peru" && teamTurn == 1)
                        {
                            teamOne -= 500;
                            pointCat[4, 2] = "         ";

                        }
                        else if (answer == "What is Peru" && teamTurn == 2)
                        {
                            teamTwo += 500;
                            pointCat[4, 2] = "         ";
                        }
                        else if (answer != "What is Peru" && teamTurn == 2)
                        {
                            teamTwo -= 500;
                            pointCat[4, 2] = "         ";
                        }
                        else if (answer == "What is Peru" && teamTurn == 3)
                        {
                            teamThree += 500;
                            pointCat[4, 2] = "         ";
                        }
                        else if (answer != "What is Peru" && teamTurn == 3)
                        {
                            teamThree -= 500;
                            pointCat[4, 2] = "         ";
                        }
                    }

                    if (myQuestion == "Capital of Denmark?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Copenhagen" && teamTurn == 1)
                        {
                            teamOne += 100;
                            pointCat[0, 3] = "           ";
                        }
                        else if (answer != "What is Copenhagen" && teamTurn == 1)
                        {
                            teamOne -= 100;
                            pointCat[0, 3] = "           ";
                        }
                        else if (answer == "What is Copenhagen" && teamTurn == 2)
                        {
                            teamTwo += 100;
                            pointCat[0, 3] = "           ";
                        }
                        else if (answer != "What is Copenhagen" && teamTurn == 2)
                        {
                            teamTwo -= 100;
                            pointCat[0, 3] = "           ";
                        }
                        else if (answer == "What is Copenhagen" && teamTurn == 3)
                        {
                            teamThree += 100;
                            pointCat[0, 3] = "           ";
                        }
                        else if (answer != "What is Copenhagen" && teamTurn == 3)
                        {
                            teamThree -= 100;
                            pointCat[0, 3] = "           ";
                        }
                    }

                    if (myQuestion == "Capital of Sweden?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Stockholm" && teamTurn == 1)
                        {
                            teamOne += 200;
                            pointCat[1, 3] = "           ";
                        }
                        else if (answer != "What is Stockholm" && teamTurn == 1)
                        {
                            teamOne -= 200;
                            pointCat[1, 3] = "           ";
                        }
                        else if (answer == "What is Stockholm" && teamTurn == 2)
                        {
                            teamTwo += 200;
                            pointCat[1, 3] = "           ";
                        }
                        else if (answer != "What is Stockholm" && teamTurn == 2)
                        {
                            teamTwo -= 200;
                            pointCat[1, 3] = "           ";
                        }
                        else if (answer == "What is Stockholm" && teamTurn == 3)
                        {
                            teamThree += 200;
                            pointCat[1, 3] = "           ";
                        }
                        else if (answer != "What is Stockholm" && teamTurn == 3)
                        {
                            teamThree -= 200;
                            pointCat[1, 3] = "           ";
                        }
                    }

                    if (myQuestion == "Capital of Norway?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Oslo" && teamTurn == 1)
                        {
                            teamOne += 300;
                            pointCat[2, 3] = "           ";
                        }
                        else if (answer != "What is Oslo" && teamTurn == 1)
                        {
                            teamOne -= 300;
                            pointCat[2, 3] = "           ";
                        }
                        else if (answer == "What is Oslo" && teamTurn == 2)
                        {
                            teamTwo += 300;
                            pointCat[2, 3] = "           ";
                        }
                        else if (answer != "What is Oslo" && teamTurn == 2)
                        {
                            teamTwo -= 300;
                            pointCat[2, 3] = "           ";
                        }
                        else if (answer == "What is Oslo" && teamTurn == 3)
                        {
                            teamThree += 300;
                            pointCat[2, 3] = "           ";
                        }
                        else if (answer != "What is Oslo" && teamTurn == 3)
                        {
                            teamThree -= 300;
                            pointCat[2, 3] = "           ";
                        }
                    }

                    if (myQuestion == "Capital of Italy?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Rome" && teamTurn == 1)
                        {
                            teamOne += 400;
                            pointCat[3, 3] = "           ";
                        }
                        else if (answer != "What is Rome" && teamTurn == 1)
                        {
                            teamOne -= 400;
                            pointCat[3, 3] = "           ";
                        }
                        else if (answer == "What is Rome" && teamTurn == 2)
                        {
                            teamTwo += 400;
                            pointCat[3, 3] = "           ";
                        }
                        else if (answer != "What is Rome" && teamTurn == 2)
                        {
                            teamTwo -= 400;
                            pointCat[3, 3] = "           ";
                        }
                        else if (answer == "What is Rome" && teamTurn == 3)
                        {
                            teamThree += 400;
                            pointCat[3, 3] = "           ";
                        }
                        else if (answer != "What is Rome" && teamTurn == 3)
                        {
                            teamThree -= 400;
                            pointCat[3, 3] = "           ";
                        }
                    }

                    if (myQuestion == "Capital of USA?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Washington" && teamTurn == 1)
                        {
                            teamOne += 500;
                            pointCat[4, 3] = "           ";
                        }
                        else if (answer != "What is Washington" && teamTurn == 1)
                        {
                            teamOne -= 500;
                            pointCat[4, 3] = "           ";
                        }
                        else if (answer == "What is Washington" && teamTurn == 2)
                        {
                            teamTwo += 500;
                            pointCat[4, 3] = "           ";
                        }
                        else if (answer != "What is Washington" && teamTurn == 2)
                        {
                            teamTwo -= 500;
                            pointCat[4, 3] = "           ";
                        }
                        else if (answer == "What is Washington" && teamTurn == 3)
                        {
                            teamThree += 500;
                            pointCat[4, 3] = "           ";
                        }
                        else if (answer != "What is Washington" && teamTurn == 3)
                        {
                            teamThree -= 500;
                            pointCat[4, 3] = "           ";
                        }
                    }

                    if (myQuestion == "Name of the formula H2?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Hydrogen" && teamTurn == 1)
                        {
                            teamOne += 100;
                            pointCat[0, 4] = "           ";
                        }
                        else if (answer != "What is Hydrogen" && teamTurn == 1)
                        {
                            teamOne -= 100;
                            pointCat[0, 4] = "           ";
                        }
                        else if (answer == "What is Hydrogen" && teamTurn == 2)
                        {
                            teamTwo += 100;
                            pointCat[0, 4] = "           ";
                        }
                        else if (answer != "What is Hydrogen" && teamTurn == 2)
                        {
                            teamTwo -= 100;
                            pointCat[0, 4] = "           ";
                        }
                        else if (answer == "What is Hydrogen" && teamTurn == 3)
                        {
                            teamThree += 100;
                            pointCat[0, 4] = "           ";
                        }
                        else if (answer != "What is Hydrogen" && teamTurn == 3)
                        {
                            teamThree -= 100;
                            pointCat[0, 4] = "           ";
                        }
                    }

                    if (myQuestion == "Name of the formula O2?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Oxygen" && teamTurn == 1)
                        {
                            teamOne += 200;
                            pointCat[1, 4] = "           ";
                        }
                        else if (answer != "What is Oxygen" && teamTurn == 1)
                        {
                            teamOne -= 200;
                            pointCat[1, 4] = "           ";
                        }
                        else if (answer == "What is Oxygen" && teamTurn == 2)
                        {
                            teamTwo += 200;
                            pointCat[1, 4] = "           ";
                        }
                        else if (answer != "What is Oxygen" && teamTurn == 2)
                        {
                            teamTwo -= 200;
                            pointCat[1, 4] = "           ";
                        }
                        else if (answer == "What is Oxygen" && teamTurn == 3)
                        {
                            teamThree += 200;
                            pointCat[1, 4] = "           ";
                        }
                        else if (answer != "What is Oxygen" && teamTurn == 3)
                        {
                            teamThree -= 200;
                            pointCat[1, 4] = "           ";
                        }
                    }

                    if (myQuestion == "Name of the formula Mg?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Magnesium" && teamTurn == 1)
                        {
                            teamOne += 300;
                            pointCat[2, 4] = "           ";
                        }
                        else if (answer != "What is Magnesium" && teamTurn == 1)
                        {
                            teamOne -= 300;
                            pointCat[2, 4] = "           ";
                        }
                        else if (answer == "What is Magnesium" && teamTurn == 2)
                        {
                            teamTwo += 300;
                            pointCat[2, 4] = "           ";
                        }
                        else if (answer != "What is Magnesium" && teamTurn == 2)
                        {
                            teamTwo -= 300;
                            pointCat[2, 4] = "           ";
                        }
                        else if (answer == "What is Magnesium" && teamTurn == 3)
                        {
                            teamThree += 300;
                            pointCat[2, 4] = "           ";
                        }
                        else if (answer != "What is Magnesium" && teamTurn == 3)
                        {
                            teamThree -= 300;
                            pointCat[2, 4] = "           ";
                        }
                    }

                    if (myQuestion == "Name of the formula Cu?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Copper" && teamTurn == 1)
                        {
                            teamOne += 400;
                            pointCat[3, 4] = "           ";
                        }
                        else if (answer != "What is Copper" && teamTurn == 1)
                        {
                            teamOne -= 400;
                            pointCat[3, 4] = "           ";
                        }
                        else if (answer == "What is Copper" && teamTurn == 2)
                        {
                            teamTwo += 400;
                            pointCat[3, 4] = "           ";
                        }
                        else if (answer != "What is Copper" && teamTurn == 2)
                        {
                            teamTwo -= 400;
                            pointCat[3, 4] = "           ";
                        }
                        else if (answer == "What is Copper" && teamTurn == 3)
                        {
                            teamThree += 400;
                            pointCat[3, 4] = "           ";
                        }
                        else if (answer != "What is Copper" && teamTurn == 3)
                        {
                            teamThree -= 400;
                            pointCat[3, 4] = "           ";
                        }
                    }

                    if (myQuestion == "Name of the formula NaCl?")
                    {
                        answer = Console.ReadLine();
                        if (answer == "What is Salt" && teamTurn == 1)
                        {
                            teamOne += 500;
                            pointCat[4, 4] = "           ";
                        }
                        else if (answer != "What is Salt" && teamTurn == 1)
                        {
                            teamOne -= 500;
                            pointCat[4, 4] = "           ";
                        }
                        else if (answer == "What is Salt" && teamTurn == 2)
                        {
                            teamTwo += 500;
                            pointCat[4, 4] = "           ";
                        }
                        else if (answer != "What is Salt" && teamTurn == 2)
                        {
                            teamTwo -= 500;
                            pointCat[4, 4] = "           ";
                        }
                        else if (answer == "What is Salt" && teamTurn == 3)
                        {
                            teamThree += 500;
                            pointCat[4, 4] = "           ";
                        }
                        else if (answer != "What is Salt" && teamTurn == 3)
                        {
                            teamThree -= 500;
                            pointCat[4, 4] = "           ";
                        }

                        switch (teamTurn)
                        {
                            case 1:
                                Console.WriteLine($"Team {nameOne} has {teamOne} points.");
                                return;
                            case 2:
                                Console.WriteLine($"Team {nameTwo} has {teamTwo} points.");
                                return;
                            case 3:
                                Console.WriteLine($"Team {nameThree} has {teamThree} points.");
                                return;

                        }

                        if (teamOne >= 2400)
                        {
                            Console.WriteLine($"Team {teamOne} has won. Congratulation!");
                            Console.WriteLine("Would you like to play again? Yes or No");
                            string yesNo = Console.ReadLine(); // Reads input before restarting
                            if (yesNo == "Yes")
                            {
                                
                                Console.Clear(); // Clears console
                                Jeopardy(1);

                            }
                            else if (yesNo == "No")
                            {
                                
                                Console.Clear(); // Clears console
                                Main();


                            }
                        }
                        else if (teamTwo >= 2400)
                        {
                            Console.WriteLine($"Team {teamTwo} has won. Congratulation");
                            Console.WriteLine("Would you like to play again? Yes or No");
                            string yesNo = Console.ReadLine(); // Reads input before restarting
                            if (yesNo == "Yes")
                            {
                                Console.Clear(); // Clears console
                                Jeopardy(1);

                            }
                            else if (yesNo == "No")
                            {
                                Console.Clear(); // Clears console
                                Main();


                            }
                        }
                        else if (teamThree >= 2400)
                        {
                            Console.WriteLine($"Team {teamThree} has won. Congratulation");
                            Console.WriteLine("Would you like to play again? Yes or No");
                            string yesNo = Console.ReadLine(); // Reads input before restarting
                            if (yesNo == "Yes")
                            {
                                Console.Clear(); // Clears console
                                Jeopardy(1);

                            }
                            else if (yesNo == "No")
                            {
                                Console.Clear(); // Clears console
                                Main();


                            }
                        }

                        if (teamTurn == 1)
                        {
                            teamTurn++;
                        }
                        else if (teamTurn == 2)
                        {
                            teamTurn++;
                        }
                        else if (teamTurn == 3)
                        {
                            teamTurn = 1;
                        }

                        Console.WriteLine();
                        Console.ReadLine();
                    }

                }
            }

        }

        static void MineSweeper(int gameMode)
        {
            while (gameMode == 2)
            {
                
                Random rnd = new Random(); // Random nummer
                int[,] multiArray = new int[6, 6]; //Makes an array
                int[,] realArray = new int[6, 6] // Random array that you can't see
                {
                { rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2
                ) }, // Makes random numbers in the rows from 0 to 3
                { rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2) },
                { rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2) },
                { rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2) },
                { rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2) },
                { rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2) }
                };
                //Change array for 0 row
                multiArray[0, 0] = 0;
                multiArray[0, 1] = 0;
                multiArray[0, 2] = 0;
                multiArray[0, 3] = 0;
                multiArray[0, 4] = 0;
                multiArray[0, 5] = 0;
                //change array for 1st row
                multiArray[1, 0] = 0;
                multiArray[2, 0] = 0;
                multiArray[3, 0] = 0;
                multiArray[4, 0] = 0;
                multiArray[5, 0] = 0;
                //Change array for 2nd row
                multiArray[1, 1] = 0;
                multiArray[1, 2] = 0;
                multiArray[1, 3] = 0;
                multiArray[1, 4] = 0;
                multiArray[1, 5] = 0;
                //Chagne array for 3rd row
                multiArray[2, 1] = 0;
                multiArray[2, 2] = 0;
                multiArray[2, 3] = 0;
                multiArray[2, 4] = 0;
                multiArray[2, 5] = 0;
                //Change array for 4th row
                multiArray[3, 1] = 0;
                multiArray[3, 2] = 0;
                multiArray[3, 3] = 0;
                multiArray[3, 4] = 0;
                multiArray[3, 5] = 0;
                //Change array for 5th row
                multiArray[4, 1] = 0;
                multiArray[4, 2] = 0;
                multiArray[4, 3] = 0;
                multiArray[4, 4] = 0;
                multiArray[4, 5] = 0;
                //Change array for 6th row
                multiArray[5, 1] = 0;
                multiArray[5, 2] = 0;
                multiArray[5, 3] = 0;
                multiArray[5, 4] = 0;
                multiArray[5, 5] = 0;

                for (int g = 0; g == 0;)
                { //If bomb triggered restart game
                    for (int x = 0; x < multiArray.GetLength(0); x++)
                    {
                        Console.WriteLine(" ");
                        {
                            for (int y = 0; y < multiArray.GetLength(1); y++)
                            {
                                Console.Write(multiArray[x, y] + " "); // Writes out array with given numbers and makes space between them
                            }
                        }
                    }
                    Console.WriteLine(" "); //  Adds new line in 
                    int xCoor = -1; // Subtracts 1 from inputed x coordinate
                    int yCoor = -1; // Subtracts 1 from inputed y coordinate

                    Console.WriteLine("Enter your x coordinates"); // Writes out simple text
                    xCoor = Convert.ToInt32(Console.ReadLine()) - 1; // Converts x coordinates into int from users input 
                    Console.WriteLine("Enter your y coordinates"); // ....
                    yCoor = Convert.ToInt32(Console.ReadLine()) - 1; // ..... just with y coordinates

                    if (multiArray[xCoor, yCoor] == realArray[xCoor, yCoor] && realArray[xCoor, yCoor] == 0) // Compares both arrays if it's equal to 0 do this:
                    {
                        multiArray[xCoor, yCoor] = 1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Blank");
                        Console.ResetColor(); // Resets the blue color
                    }
                    else if (multiArray[xCoor, yCoor] != realArray[xCoor, yCoor] && realArray[xCoor, yCoor] == 1) // Compares both arrays if it's equal to 2 do this:
                    {
                        multiArray[xCoor, yCoor] = 1; // Changes to 2 that makes user to die, because of bomb 
                        for (int x = 0; x < realArray.GetLength(0); x++) // Shows "realArray" to show player where bombs and flags was
                        {
                            Console.WriteLine(" ");
                            {
                                for (int y = 0; y < realArray.GetLength(1); y++)
                                {
                                    Console.Write(realArray[x, y] + " "); // Writes out array with given numbers and makes space between them
                                }
                            }
                        }
                        Console.WriteLine(" ");// Makes new line after printing out game
                        bomb();// Activates bomb and writes everything that is in "bomb"
                    }
                }
            }
        }

        static void bomb()
        {
            Console.ForegroundColor = ConsoleColor.Red; // Changes color to red
            Console.WriteLine("You shot the bomb!" + " " + "Enter any key to continue"); // Writes out text
            Console.WriteLine("Would you like to try again? Yes or No");
            string yesNo = Console.ReadLine(); // Reads input before restarting
            if (yesNo == "Yes")
            {
                Console.ResetColor(); // Resets color
                Console.Clear(); // Clears console
                MineSweeper(2);
                
            }
            else if (yesNo == "No")
            {
                Console.ResetColor(); // Resets color
                Console.Clear(); // Clears console
                Main();
                

            }
             
            Console.ResetColor(); // Resets color
            Console.Clear(); // Clears console
            MineSweeper(2);
        }

        static string PointChoice(string text, int cat)
        {
            if (cat == 0)
            {
                switch (text)
                {
                    case "100":
                        return ("5+5?");
                    case "200":
                        return ("10+10?");
                    case "300":
                        return ("20+20?");
                    case "400":
                        return ("40+40?");
                    case "500":
                        return ("80+80?");
                }
                return ("wrong input");
            }

            if (cat == 1)
            {
                switch (text)
                {
                    case "100":
                        return ("Flag with a white cross?");
                    case "200":
                        return ("Flag with a yellow cross?");
                    case "300":
                        return ("Flag with a white and blue cross?");
                    case "400":
                        return ("Flag with a blue cross?");
                    case "500":
                        return ("Flag made of triangles?");
                }
                return ("wrong input");
            }
            if (cat == 2)
            {
                switch (text)
                {
                    case "100":
                        return ("Capital of Denmark?");
                    case "200":
                        return ("Capital of Sweden?");
                    case "300":
                        return ("Capital of Norway?");
                    case "400":
                        return ("Capital of Italy?");
                    case "500":
                        return ("Capital of USA?");
                }
                return ("wrong input");
            }
            if (cat == 3)
            {
                switch (text)
                {
                    case "100":
                        return ("Eiffel tower is where?");
                    case "200":
                        return ("Leaning tower of pisa is where?");
                    case "300":
                        return ("Sydney opera house is where?");
                    case "400":
                        return ("Statue of Liberty is where?");
                    case "500":
                        return ("Macchu Picchu is where?");
                }
                return ("wrong input");
            }
            if (cat == 4)
            {
                switch (text)
                {
                    case "100":
                        return ("Name of the formula H2?");
                    case "200":
                        return ("Name of the formula O2?");
                    case "300":
                        return ("Name of the formula Mg?");
                    case "400":
                        return ("Name of the formula Cu?");
                    case "500":
                        return ("Name of the formula NaCl?");
                }
                return ("wrong input");
            }
            return ("Wrong category");
        }
        static int CategoryChoice(string text)
        {
            switch (text)
            {
                case "Math":
                    return (0);
                case "Flags":
                    return (1);
                case "Capitols":
                    return (2);
                case "Geography":
                    return (3);
                case "Chemistry":
                    return (4);

            }
            return (5);

        }
    }
}
