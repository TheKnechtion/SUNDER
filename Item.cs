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
    class Item
    {
        protected string itemName;
        protected string location;

        public Item(string _itemName, string _location)
        {
            itemName = _itemName;
            location = _location;
        }
        public string getItemName()
        {
            return itemName;
        }
        public string getLocation()
        {
            return location;
        }

        //casting object to the type item. 
        //example based on https://docs.microsoft.com/en-us/dotnet/api/system.object.equals?view=netcore-3.1

        public override bool Equals(Object obj)
        {
            //returns type item
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            else
            {
                Item i = (Item) obj;
                return this.itemName == i.itemName;
            }
        }

        //virtual allows dirived classes to have diff implimentation of a method.

        public virtual void displayText()
        {
            Console.WriteLine($"{itemName}, which was located in {location}.\n");
        }
    }
}
