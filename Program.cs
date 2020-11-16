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
    class Program
    {
        static void Main()
        {
            Menu SUNDER = new Menu();
            SUNDER.run();
        }
    }
}
