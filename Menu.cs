/*
 * SUNDER
 * by Donald Knechtel, 11/6/2020
 * 
 * This work is a derivative of
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 * 
 * Overloading Equals method based on https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/how-to-define-value-equality-for-a-type
 * 
 * ASCII Art title from word generator http://www.network-science.de/ascii/
 * 
 * ASCII Art from the ASCII Art Archive https://www.asciiart.eu/books/books by Donovan Bake(dwb), Argiris Kranidiotis, Veronica Karlsson, Joan Stark, 
 * Martin Brunzel, Jon McGorrill, Brian Green, Sarah Day, Riitta Rasimus, Robert Casey, Sherry Stowers, Marcin Glinski, Cygnus Mineah, Steven Maddison, spicer's public library entrance, 
 * Ojoshiro, IgBeard, hectoras  
 * 
 * Switch Statements, Lists, Do-while statements, inheritance/polymorphism discussed with tutors Benjie Valpey and Pete Orkweha
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Menu
    {

        private void Header()
        {
            //main menu
            Console.Title = "SUNDER by Donald Knechtel";
            Console.ForegroundColor = ConsoleColor.Red;
            string title = @"

                .......... . .........................   .......  .................     ..............
                  .............................    ...........................    ..........  .........
             ......................... . ............  ...... ..........     ......................
                                           ▬▬ι═══════-    -═══════ι▬▬
                                       _____ _   _ _   _______ ___________ 
                                      /  ___| | | | \ | |  _  \  ___| ___ \
                                      \ `--.| | | |  \| | | | | |__ | |_/ /
                                       `--. \ | | | . ` | | | |  __||    / 
                                      /\__/ / |_| | |\  | |/ /| |___| |\ \ 
                                      \____/ \___/\_| \_/___/ \____/\_| \_|

                                           ▬▬ι═══════-    -═══════ι▬▬
                   ...........    .......................    .................... .......... .. .
             .............. ...............    ... ...... .  ...........................
                     .............................    ...........................  .........  .....
                     ............. .... . ....................... ................ ..                                                 

                                                                                                            ";
            Console.WriteLine(title);
            Console.ResetColor();


        }

        private void Instructions()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<======================================================================================================================>");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to SUNDER! In this game you will play as a stranded explorer trying to find their way off a planet they crash \nlanded on. All hope is not lost however as you find an old colonial outpost, although mysteriously, it seems abandoned. \nMake your way through the facility by exploring rooms and collecting the necessary parts, tools and a new ride \noff the planet.\n");
            Console.ResetColor();
        }
        private void Credits()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<======================================================================================================================>");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("SUNDER by Donald Knechtel - 11/6/2020\n");
            Console.WriteLine("This work is a derivative of C# Adventure Game by http://programmingisfun.com, used under CC BY. \n https://creativecommons.org/licenses/by/4.0/ \n");
            Console.WriteLine("ASCII Art title from word generator http://www.network-science.de/ascii/ \n");
            Console.WriteLine("ASCII Art from the ASCII Art Archive https://www.asciiart.eu/books/books from artists including: Argiris Kranidiotis, \nVeronica Karlsson, Joan Stark, Martin Brunzel, Jon McGorrill, Brian Green, Sarah Day, Riitta Rasimus, Robert Casey, \nSherry Stowers, Marcin Glinski, Cygnus Mineah, Steven Maddison, spicer's public library entrance, Ojoshiro, IgBeard \nand hectoras.\n");
            Console.WriteLine("Overloading Equals method based on https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/how-to-define-value-equality-for-a-type.");
            Console.WriteLine("\n Switch Statements, Lists, Do-while statements, inheritance/polymorphism discussed with tutors Benjie Valpey and \nPete Orkweha.\n");
            Console.ResetColor();

        }
        private void Exit()
        {
            Environment.Exit(0);
        }

        private void mainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<======================================================================================================================>");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("                                  <<Please select an option from the list below>>");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n                             1.)");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Instructions ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("2.) ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Play Game ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("3.) ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Credits ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("4.) ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Exit Game ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n<======================================================================================================================>");
            Console.ResetColor();

            int menuSelection;

            do
            {
                try
                {
                    menuSelection = Int32.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    menuSelection = -1;
                }

            } while (menuSelection > 4 && menuSelection < 1);

            Console.Clear();

            switch (menuSelection)
            {
                case 1:
                    Instructions();
                    break;

                case 2:
                    Game startGame = new Game();
                    startGame.start();
                    break;

                case 3:
                    Credits();
                    break;

                case 4:
                    Exit();
                    break;

                default:
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("<======================================================================================================================>");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You did not follow instructions...\n");
                    Console.WriteLine("Please select an option from the list below (1, 2, 3, or 4.)\n");
                    Console.ResetColor();

                    break;
            }
        }
        public void run()
        {
            bool appRunning = true;
            Header();

            while (appRunning == true)
            {
                mainMenu();
            }
        }
    }
}
