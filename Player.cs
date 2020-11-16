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
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player
    {
        public Player(string _name)
        {
            name = _name;

            inventory = new List<Item>();
            notes = new List<Note>();
            itemsNeeded = new List<Item>
            {
                new Item("Canister", "Fuel Station"),
                new Item("Tape", "Repair Depot"),
                new Item("PulseCharger", "Radar Room"),
                new Item("Motherboard", "Radar Room")
            };

            fuse = false;
            kitchen = false;
            canister = false;
            tape = false;
            pulseCharger = false;
            motherboard = false;
            report1 = false;
            report2 = false;
            report3 = false;
            report4 = false;
            report5 = false;
            report6 = false;

        }

        private string name;

        public string getName()
        {
            return name;
        }


        public List<Item> inventory;
        public List<Note> notes;
        public List<Item> itemsNeeded;

        public void shipParts()
        {
            foreach (Item itemsCollected in itemsNeeded)
            {
                Console.WriteLine(itemsCollected.getItemName());
            }
        }
      

        //Part One collectables
        private bool fuse;

        public bool hasFuse()
        {
            return fuse;
        }

        public void pickupFuse()
        {
            fuse = true;
            inventory.Add(new Item("Fuse", "Storage"));
        }


        //Part Two collectables
        public bool kitchen;
        private enum kitchenItem
        {
            Knife, Flare, None
        }

        private kitchenItem selectedKitchen = kitchenItem.None;

        public void takeKnife()
        {
           selectedKitchen = kitchenItem.Knife;
            inventory.Add(new Item("Knife", "Kitchen"));
        }
        public bool hasKnife()
        {
            return selectedKitchen == kitchenItem.Knife;
        }

        public void takeFlare()
        {
            selectedKitchen = kitchenItem.Flare;
            inventory.Add(new Item("Flare", "Kitchen"));
        }
        public bool hasFlare()
        {
            return selectedKitchen == kitchenItem.Flare;
        }
//<==============================================================================================================>
        //Ship Parts
        private bool canister;

        public bool hasCanister()
        {
            return canister;
        }

        public void pickupCanister()
        {
            canister = true;
            inventory.Add(new Item("Canister","Fuel Station"));
            itemsNeeded.Remove(new Item("Canister","Fuel Station"));
        }


        private bool tape;

        public bool hasTape()
        {
            return tape;
        }

        public void pickupTape()
        {
            tape = true;
            inventory.Add(new Item("Tape","Repair Depot"));
            itemsNeeded.Remove(new Item("Tape","Repair Depot"));
        }


        private bool pulseCharger;

        public bool hasPulseCharger()
        {
            return pulseCharger;
        }

        public void pickupPulseCharger()
        {
            pulseCharger = true;
            inventory.Add(new Item("PulseCharger","Radar Room"));
            itemsNeeded.Remove(new Item("PulseCharger", "Radar Room"));
        }

        private bool motherboard;

        public bool hasMotherboard()
        {
            return motherboard;
        }

        public void pickupMotherboard()
        {
            motherboard = true;
            inventory.Add(new Item("Motherboard", "Radar Room"));
            itemsNeeded.Remove(new Item("Motherboard", "Radar Room"));
        }
        //<==============================================================================================================>
        //Collectable Reports

        private static string[] TextFragments = {
            "Water running low, we know it, the residents know it too. It’s only a matter of time before an all out riot. \nThe Mayor has a plan that just might work. He has an expedition planned to---",
            "I don't know what he has planned. The meeting is in a few hours. Riots are already starting, people are trying \nto run and the thefts have started. Just what I needed, a full blown panic. After the meeting I'm heading \ndown to the hangar, my---",
            "He's calling it 'Operation SUNDER.' He always had a flare for the dramatic, but it's a solid plan. \nTheir gathering the mining equipment now. Hopefully they can crack this planet open and get some---",
            "We tried to send out an emergency call just in case the plan failed, but the Sat Comm array sank into the ground \nas we were sending the message. Looks like all that drilling for water we were doing screwed us, \nmaybe it doesn't matter. The plan will work, it---",
            "The plan failed... Operation SUNDER was a bust. Turns out the whole planet is simply tapped out. \nWe won't be able to get shipments to sustain the population. I just don't know, maybe---",
            "An emergency shuttle actually showed up. Looks like the message got out before the Sat Comm station sank. \nThis will be my last 'report,' to whomever is reading this if you find yourself stuck here, take my ship. \nIt's in hangar 02, it needs some repairs and some fuel, but everything you need should be close by. \nGood luck out there, and god speed.",
        };

        private bool report1;

        public bool hasReport1()
        {
            return report1;
        }

        public void pickupReport1()
        {
            Note textFrag = new Note("Report 1", TextFragments[0], "Residential Zone");
            report1 = true;
            notes.Add(textFrag);
        }


        private bool report2;

        public bool hasReport2()
        {
            return report2;
        }

        public void pickupReport2()
        {
            Note textFrag = new Note("Report 2", TextFragments[1], "Comfort Area");
            report2 = true;
            notes.Add(textFrag);
        }



        private bool report3;

        public bool hasReport3()
        {
            return report3;
        }

        public void pickupReport3()
        {
            Note textFrag = new Note("Report 3", TextFragments[2], "Fuel Station");
            report3 = true;
            notes.Add(textFrag);
        }



        private bool report4;

        public bool hasReport4()
        {
            return report4;
        }

        public void pickupReport4()
        {
            Note textFrag = new Note("Report 4", TextFragments[3], "Repair Depot");
            report4 = true;
            notes.Add(textFrag);
        }



        private bool report5;

        public bool hasReport5()
        {
            return report5;
        }

        public void pickupReport5()
        {
            Note textFrag = new Note("Report 5", TextFragments[4], "Repair Depot");
            report5 = true;
            notes.Add(textFrag);
        }



        private bool report6;

        public bool hasReport6()
        {
            return report6;
        }

        public void pickupReport6()
        {
            Note textFrag = new Note("Report 6", TextFragments[5], "Radar Room");
            report6 = true;
            notes.Add(textFrag);
        }


    }
}
