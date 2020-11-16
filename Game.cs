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
    class Game
    {
        Player newPlayer;

        static string[] PartOne = {
            "Reaching the southern entrance you come to a forked path. The path to the right looks like it heads to an old \nresidential district. The left just seems to be a long maintenance tunnel.",
            "As you enter the residential area you see that many of the doors have lost power. \nThe main door to the next part of the district is also unfortunately powered down or boarded up. Looking around \nyou see a large door leading to another section of the facility. You can open the door or serach the area.",
            "You head left down the old maintenance tunnel. The hallway is dimly lit and gets darker the further in. \nAfter a short walk down the wing you see a storage room off the side. ",
            "You continue searching around the area and stumble upon an old report. It’s faded and barely readable \nbut you can make out an excerpt. It reads:",
            "You head further down into the hallway, but the further you go the less you can see. Eventually there is only \ndarkness and you cant make out anything ahead of you. You’ll need something to light the way if you want to make \nit further down this path. You decide to head back to the port entrance.",
            "you enter what seems to be a storage wing. Shelves stocked with boxes of mechanical do-dads. \nIt’s a bit hard to see but you can still make out most things. Looking around you think you might be able to salvage something here.",
            "Searching through the boxes you only find one thing of notable use, what seemed to be an old power fuse. \nYou take it and head back into the hall. ",
            "You insert the fuse into the box and the door spark to life! You enter the new room.",
            "You light the flare and delve deeper into the maintenance tunnels. As you proceed you pass through the hall comes \nto an end and you find an old hatch. You Pop it open quickly climb down the ladder.",
            "You find nothing else of interest and head back.",
            "You are back at the main entrance of the port.",
            "The door is powered down but you see a fuesbox next to it.",
            "You are back in the residential area.",
            "Inspecting the fusebox you see a fuse is missing, you might be able to find something nearby \nto power it back up. Finding nothing, you head back to the main entrance.",
        };
        static string[] PartTwo = {
            "The door slides open revealing junction with a comfort area with doors on the left and right walls. \nTo the right you can see a cafeteria and to the left, a long winding hallway.",
            "What would you like to do? Search the area, go right or left?",
            "You enter the old cafe, trays are strewn about the room and broken pipes have flooded the floors. \nThere is nothing of interest in the dining portion of the room. Looking to the right side of the room you can \nsee a light inside the kitchen.",
            "You enter the kitchen. Looking around you are astonished at the mess around you. Every dish smashed on the floor, \nold boxes of food torn open and eaten by the rats scurrying around and oh god the smell!",
            "You enter the side hall. It’s long, winding but otherwise uneventful. You eventually come to a staircase \ngoing down. There's a door at the base of the stairs, but it has been roped shut with a constructor knot.",
            "You find it impossible to untie. You'll need something to cut it. You head back to the conjoining hallway.",
            "You look around for anything useful. After a quick search you find a flare from a nearly emptied out medkit, \nand a kitchen knife on the counter. Which would you like to take?",
            "You cut the knot with the knife, unlocking the door. You push it open and head through to the other side.",
            "You head back to the main entrance.",
            "In a pile of old papers scattered among the floor you find an old report.",
            "Theres nothing else of interest here.",
            "You take the knife from the counter and add it to your inventory.",
            "You take the flare from the med kit and add it to your inventory.",
            "You are back at the junction.",
            "Would you like to try to open the door or head back?",
            "You head back to the junction."

        };
        static string[] PartThree = {
            "You enter an old security zone. The lights are still on in this part of the facility so that's good at least. \nLooking around you see two doors that still have power and a ladder going up to the hatch directly to your left. \nUnfortunately the hatch is one way, and opens from the other side, that leaves the doors. One going straight, \nand one going to the right.",
            "You go straight...",
            "you head right...",
            "You try heading back...",
            "You hear the doors magneticly seal behind you. Looks like your stuck in here.",
            "The doors are still locked, looks like youll need to find another way out.",
            "You are back in the security zone.",
        };
        static string[] Hangar = {
            "You enter a hangar bay. In the hangar you can see a repair depot to the left and a fuel pump station to the right. \nSitting in the center of the hangar you a ship! Looks like you found a way out of here!",
            "Inspecting the ship you see that it is inoperable. Giving it a once over you create a list of things you'll need \nto repair the ship.",
            "Looks like you'll need: ",
            "You head towards the ship.",
            "You head back to security.",
            "You head into the fuel pump station.",
            "You head to the repair depot.",
            "You return to the Hangar.",
            "You did it! The ship comes alive. You enter the cockpit and head through the hangar door, \ntaking off into the stars!",
            "You did it! The ship comes alive. You enter the cockpit and realize you did not open the hangar doors. \nOh well! You blast through the ceiling and take off into the stars!",
            "You are back at the ship.",
            "You insert each part into the ship."

        };
        static string[] Fuel = {
            "You enter the fuel pump station. Looking around you see some old oil drums, a jumpsuit hanging on the wall \nand some shelving.",
            "You search the oil drums...",
            "You search the old jumpsuit...",
            "You search the shelves...",
            "In the pocket of the old jumpsuit you find a folded up report. It reads:",
            "You found a fuel canister! And its full to boot. You add it to your inventory.",
            "You find nothing of interst.",
            "Theres nothing else of interest.",
            "You head back to the hangar",
            "You are back in the fuel pump station."
        };
        static string[] Depot = {
            "You enter the repair depot. Looking around the room you see multiple do-it-yourself repair stations \nand workshops, a desk with a filing cabinet next to it and a large toolbox in the corner.",
            "You search around the room...",
            "You search the desk...",
            "You search the filing cabinet...",
            "You search the toolbox...",
            "You find a file underneath a box towards the center of the room. It looks like an old report. It Reads:",
            "There's nothing else of interest here.",
            "You find nothing of use.",
            "Searching the toolbox you found some Fiberballister Tape! You add it to your inventory.",
            "You are back in the repair depot.",
            "In one of the drawers you find an old report.",
            "You head back to the hangar."
        };
        static string[] Hall = {
            "You head left and enter a hallway. In the hall there are three doors. To the left is a recreational room. \nTo the right is the hangars radar control room. Finally, straight ahead is the air traffic control tower.",
            "You head left to the rec room...",
            "You head right to the radar room...",
            "You go straight to the air traffic control tower...",
            "You head back to the security zone",
            "You are back in the hallway."
        };
        static string[] RecRoom = {
            "You enter a recreational room. After a quick scan you find nothing but some dusty old magazines.",
            "There's nothing of interest here.",
        };
        static string[] Tower = {
            "After walking up a long sprial staircase you find yourself in the air traffic control tower. \nThe power is still on, so you got that going for you. Looking around the room you see a slew of consoles \nand control panels.",
            "After a quick scan you see three stations that seem of use. A tall mainframe in the corner, \na larger control station in the center of the room and a big red button on the wall.",
            "You head towards the control panel...",
            "You head towards the mainframe...",
            "You head towrds the big red button...",
            "The controls on this console are for short range communications, useless to you.",
            "Looking around the mainframe you find a group of switches labled 'door controls,' Yes! \nHitting the switch you see through the windows that the hangar doors have opened up.",
            "You hit the button and an error message pops up on a screen nearby. It reads 'ERROR: Misaligned satellite \narray, contact your nearest maint. specialist.' Looks like this is of no use, whatever it's for.",
            "Theres nothing else that can help you here.",
            "The control panel is useless.",
            "You are back in the air traffic control tower.",
            "You head back to the hall.",
            "The button is useless."
        };
        static string[] Radar = {
            "You enter the radar room. Looking around you see a bunch of moniotrs and control panels. \nHowever, you see an off branching computer in the back, as well as some shelves next to it.",
            "You search the room...",
            "You search the computer...",
            "You search the shelves...",
            "Searching the room you find an old file on one of the old control consoles. It reads:",
            "Theres nothing else of interest here.",
            "Theres nothing of value on the computer. However, using your quick witts you smash the computer open \nand salvage it's motherboard. Hopefully this will work for a ships navigation terminal.",
            "You see a gutted smashed computer. There is nothing else here.",
            "Searching the shelves you find a PulseCharger! You place it in your bag and move on.",
            "You are back in the radar room.",
            "You head back towards the hallway."
        };
        static string[] TextFragments = {
            "Water running low, we know it, the residents know it too. It’s only a matter of time before an all out riot. \nThe Mayor has a plan that just might work. He has an expedition planned to---",
            "I don't know what he has planned. The meeting is in a few hours. Riots are already starting, people are trying \nto run and the thefts have started. Just what I needed, a full blown panic. After the meeting I'm heading \ndown to the hangar, my---",
            "He's calling it 'Operation SUNDER.' He always had a flare for the dramatic, but it's a solid plan. \nTheir gathering the mining equipment now. Hopefully they can crack this planet open and get some---",
            "We tried to send out an emergency call just in case the plan failed, but the Sat Comm array sank into the ground \nas we were sending the message. Looks like all that drilling for water we were doing screwed us, \nmaybe it doesn't matter. The plan will work, it---",
            "The plan failed... Operation SUNDER was a bust. Turns out the whole planet is simply tapped out. \nWe won't be able to get shipments to sustain the population. I just don't know, maybe---",
            "An emergency shuttle actually showed up. Looks like the message got out before the Sat Comm station sank. \nThis will be my last 'report,' to whomever is reading this if you find yourself stuck here, take my ship. \nIt's in hangar 02, it needs some repairs and some fuel, but everything you need should be close by. \nGood luck out there, and god speed.",
            "The rest is unreadable. You put the report in your bag and head back.",
            "The message ends. You take the report and add it to your bag."
        };

        //start
        //main menu options
        //ask for player name
        //introduce game plot with character name
        //tell them their task
        //start game/ first scenario
        //put choices into arays
        //create list to keep track of collected items


        //Do this every time you ask them somthing

        /*             do
                           {
                               Console.WriteLine("Please enter right or left");
                               rightOrleft = Console.ReadLine();
                               rightOrleft = rightOrleft.ToLower();
                           } while (rightOrleft != "right" || rightOrleft != "left");
        */






        //start
        public void start()
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 115;

            Play();

            Inventory();

            End();
        }

        public void Play()
        {
            //ask for player name
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<=================================================================================================================>");
            Console.ResetColor();
            Console.WriteLine("\nWhat is your adventurers name?\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<=================================================================================================================>");
            Console.ResetColor();
            newPlayer = new Player(Console.ReadLine());

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<=================================================================================================================>");
            Console.ResetColor();

            Console.Write("\nWell ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"{newPlayer.getName()}");
            Console.ResetColor();
            Console.Write(", unfortunantly for you you've ended up stranded on an unfamiliar planet.\n");

            Console.ForegroundColor = ConsoleColor.Red;
            string landscape = @" 
                            .                                            .
                    *   .                  .              .        .   *          .
                .         .                     .       .           .      .        .
                    o                             .                   .
                        .              .                  .           .
                        0     .
                                .          .                 ,                ,    ,
                .          \          .                         .
                    .      \   ,
                .          o     .                 .                   .            .
                    .         \                 ,             .                .
                            #\##\#      .                              .        .
                            #  #O##\###                .                        .
                .        #*#  #\##\###                       .                     ,
                    .   ##*#  #\##\##               .                     .
                    .      ##*#  #o##\#         .                             ,       .
                        .     *#  #\#     .                    .             .          ,
                                    \          .                         .
            ____^/\___^--____/\____O______________/\/\---/\___________---______________
                /\^   ^  ^    ^                  ^^ ^  '\ ^          ^       ---
                        --           -            --  -      -         ---  __       ^
                --  __                      ___--  ^  ^                         --  __

                                                                                                            ";
            Console.WriteLine(landscape);
            Console.ResetColor();

            Console.WriteLine($"You wake up dazed in their ship. The last thing you can remember is heading through an astroid field \non your way back home. Looking out the cockpit window, you see the vista of an alien planet, rust red \nsandy dunes in every direction. In the distance you can faintly make out a colonial outpost, \nmaybe someone there can lend you a new ride.\n");
            Console.WriteLine("Grabbing a backpack and your personal effects from your ships wreckage \nyou head off towards the facility. ");
            Console.Write("\nPress ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ENTER ");
            Console.ResetColor();
            Console.Write("to continue");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n<=================================================================================================================>");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<=================================================================================================================>");
            Console.ResetColor();
            Console.WriteLine("As you approach the port you notice the southern gate wide open and a distinct lack of sound.\n After giving the perimeter a quick scan you come to the conclusion that the port has been abandoned for some time.\n");


            Console.ForegroundColor = ConsoleColor.Yellow;
            string outpost = @" 
                                          ~         ~~          __
                                               _T      .,,.    ~--~ ^^
                                         ^^   // \                    ~
                                              ][O]    ^^      ,-~ ~
                                           /''-I_I         _II____
                                        __/_  /   \ ______/ ''   /'\_,__
                                          | II--'''' \,--:--..,_/,.-{ },
                                        ; '/__\,.--';|   |[] .-.| O{ _ }
                                        :' |  | []  -|   ''--:.;[,.'\,/
                                        '  |[]|,.--'' '',   ''-,.    |
                                          ..    ..-''    ;       ''. '

                                                                                                            ";
            Console.WriteLine(outpost);
            Console.ResetColor();

            Console.WriteLine($"'Well, {newPlayer.getName()}, this aint good,' You say to yourself. ");
            Console.WriteLine("Looks like your on your own here, everyones gone. Although, maybe they left something behind. \nThis old port is my best chance of finding a new ride off this rock!'\n");

            Console.Write("Press ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ENTER ");
            Console.ResetColor();
            Console.Write("to continue");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n<=================================================================================================================>");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Choice();

            // Branching Narrative structure
            void Choice()
            {
                int currentScenario = 1;

                bool gameEnd = false;
                bool startedPartOne = false;
                bool startedPartTwo = false;
                bool startedPartThree = false;
                bool startedHangar = false;
                bool startedDepot = false;
                bool startedHall = false;
                bool startedRecRoom = false;
                bool startedTower = false;
                bool startedFuel = false;
                bool startedRadar = false;
                bool startedShip = false;

                bool startedDoor = false;
                bool startedConsole = false;
                bool startedMainframe = false;
                bool startedButton = false;

                while (!gameEnd)
                {
                    switch (currentScenario)
                    {
                        case 1:
                            //everything that happens in part 1
                            if (!startedPartOne)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"{PartOne[0]}\n");
                                startedPartOne = true;
                            }
                            else
                            {
                                Console.WriteLine($"\n{PartOne[10]}\n");
                            }

                            string rightOrleft;

                            do
                            {
                                Console.WriteLine("\nPlease enter right or left.");


                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                rightOrleft = Console.ReadLine();
                                rightOrleft = rightOrleft.ToLower();
                            } while (rightOrleft != "right" && rightOrleft != "left");

                            Console.Clear();

                            if (rightOrleft == "right")
                            {
                                if (!startedDoor)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    Console.WriteLine($"{PartOne[1]}");

                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    string residentialDoor = @" 

                            ____________________________________________
                            |____________________________________________|
                            |__||  ||___||  |_|___|___|__|  ||___||  ||__|
                            ||__|  |__|__|  |___|___|___||  |__|__|  |__||
                            |__||  ||___||  |_|___|___|__|  ||___||  ||__|
                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                            |__||  ||___||  |    || |    |  ||___||  ||__|
                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                            |__||  ||___||  | ScS|| |    |  ||___||  ||__|
                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                            |__||  ||___||  |   O|| |O   |  ||___||  ||__|
                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                            |__||  ||___||  |    || |    |  ||___||  ||__|
                            ||__|  |__|__|__|____||_|____|  |__|__|  |__||
                            |LLL|  |LLLLL|______________||  |LLLLL|  |LLL|
                            |LLL|  |LLL|______________|  |  |LLLLL|  |LLL|
                            |LLL|__|L|______________|____|__|LLLLL|__|LLL|

                                                                                                            ";
                                    Console.WriteLine(residentialDoor);
                                    Console.ResetColor();

                                    startedDoor = true;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    Console.WriteLine(PartOne[12]);

                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    string residentialDoor2 = @" 

                            ____________________________________________
                            |____________________________________________|
                            |__||  ||___||  |_|___|___|__|  ||___||  ||__|
                            ||__|  |__|__|  |___|___|___||  |__|__|  |__||
                            |__||  ||___||  |_|___|___|__|  ||___||  ||__|
                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                            |__||  ||___||  |    || |    |  ||___||  ||__|
                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                            |__||  ||___||  | ScS|| |    |  ||___||  ||__|
                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                            |__||  ||___||  |   O|| |O   |  ||___||  ||__|
                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                            |__||  ||___||  |    || |    |  ||___||  ||__|
                            ||__|  |__|__|__|____||_|____|  |__|__|  |__||
                            |LLL|  |LLLLL|______________||  |LLLLL|  |LLL|
                            |LLL|  |LLL|______________|  |  |LLLLL|  |LLL|
                            |LLL|__|L|______________|____|__|LLLLL|__|LLL|

                                                                                                            ";
                                    Console.WriteLine(residentialDoor2);
                                    Console.ResetColor();
                                }

                                //Console.WriteLine (you see fuse box)
                                //search fuse box or room
                                string fuseOrSearch;

                                do
                                {
                                    Console.WriteLine("\nPlease enter Door or Area.");

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    fuseOrSearch = Console.ReadLine();
                                    fuseOrSearch = fuseOrSearch.ToLower();
                                } while (fuseOrSearch != "door" && fuseOrSearch != "area");

                                Console.Clear();


                                if (fuseOrSearch == "door")
                                {
                                    if (newPlayer.hasFuse())
                                    {
                                        currentScenario = 2;
                                        break;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("<=================================================================================================================>");
                                        Console.ResetColor();

                                        Console.WriteLine($"{PartOne[11]}");

                                        Console.ForegroundColor = ConsoleColor.Red;
                                        string fusebox = @" 

                                                 _______________
                                                |,----------.  |\
                                                ||           |=| |
                                                ||          || | |
                                                ||       . _o| | | 
                                                |`-----------' |/ 
                                                 ~~~~~~~~~~~~~~~

                                                                                                            ";
                                        Console.WriteLine(fusebox);
                                        Console.ResetColor();

                                        Console.WriteLine($"{PartOne[13]}");

                                        break;
                                    }

                                }
                                else
                                {
                                    if (newPlayer.hasReport1())
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("<=================================================================================================================>");
                                        Console.ResetColor();

                                        Console.WriteLine($"\n{PartOne[9]}");
                                        break;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("<=================================================================================================================>");
                                        Console.ResetColor();
                                        Console.WriteLine($"\n{PartOne[3]}");

                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        string report1 = @" 
                                                _________   _________
                                           ____/      452\ /     453 \____
                                         /| ------------- |  ------------ |\
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        ||| ------- ----- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        |||  ------------ | ----------    |||
                                        ||| ------------- |  ------------ |||
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------ -----  |||
                                        ||| ------------  | ------------- |||
                                        |||_____________  |  _____________|||
                                        L/_____/--------\\_//W-------\_____\J


                                                                                                            ";
                                        Console.WriteLine(report1);
                                        Console.ResetColor();
                                        Console.WriteLine($"{TextFragments[0]}\n");
                                        Console.WriteLine($"{TextFragments[6]}");
                                        newPlayer.pickupReport1();
                                      
                                        break;
                                    }
                                }

                            }
                            else if (rightOrleft == "left")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{PartOne[2]}");

                                Console.ForegroundColor = ConsoleColor.Red;
                                string leftHallway = @" 
                                     _____________________________________________
                                    |.'',                                     ,''.|
                                    |.'.'',                                 ,''.'.|
                                    |.'.'.'',                             ,''.'.'.|
                                    |.'.'.'.'',                         ,''.'.'.'.|
                                    |.'.'.'.'.|                         |.'.'.'.'.|
                                    |.'.'.'.'.|===;                 ;===|.'.'.'.'.|
                                    |.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|
                                    |.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|
                                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                                    |,',',',',|---|',|'|???????|'|,'|---|,',',',',|
                                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                                    |.'.'.'.'.|---|','   /%%%\   ','|---|.'.'.'.'.|
                                    |.'.'.'.'.|===:'    /%%%%%\    ':===|.'.'.'.'.|
                                    |.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|
                                    |.'.'.'.','       /%%%%%%%%%\       ','.'.'.'.|
                                    |.'.'.','        /%%%%%%%%%%%\        ','.'.'.|
                                    |.'.','         /%%%%%%%%%%%%%\         ','.'.|
                                    |.','          /%%%%%%%%%%%%%%%\          ','.|
                                    |;____________/%%%%%Spicer%%%%%%\____________;|       ";

                                Console.WriteLine(leftHallway);
                                Console.ResetColor();

                                string hallOrstorage;

                                do
                                {
                                    Console.WriteLine("\nPlease enter Storage or Hallway.");

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    hallOrstorage = Console.ReadLine();
                                    hallOrstorage = hallOrstorage.ToLower();
                                } while (hallOrstorage != "storage" && hallOrstorage != "hallway");

                                Console.Clear();

                                if (hallOrstorage == "storage")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    if (newPlayer.hasFuse())
                                    {
                                        Console.WriteLine($"\n{PartOne[9]}");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\n{PartOne[6]}");

                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        string fuseArt = @" 
                                             ____________________________
                                            /                           /\
                                           /   Argiris A. Kranidiotis _/ /\
                                          /                          / \/
                                         /                           /\
                                        /___________________________/ /
                                        \___________________________\/
                                         \ \ \ \ \ \ \ \ \ \ \ \ \ \ \     ";

                                        Console.WriteLine(fuseArt);
                                        Console.ResetColor();

                                        newPlayer.pickupFuse();
                                        break;
                                    }

                                }
                                else if (hallOrstorage == "hallway")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    if (newPlayer.hasFlare())
                                    {
                                        Console.WriteLine($"\n{PartOne[8]}");

                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        string leftHallway2 = @" 
                                     _____________________________________________
                                    |.'',                                     ,''.|
                                    |.'.'',                                 ,''.'.|
                                    |.'.'.'',                             ,''.'.'.|
                                    |.'.'.'.'',                         ,''.'.'.'.|
                                    |.'.'.'.'.|                         |.'.'.'.'.|
                                    |.'.'.'.'.|===;                 ;===|.'.'.'.'.|
                                    |.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|
                                    |.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|
                                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                                    |,',',',',|---|',|'|???????|'|,'|---|,',',',',|
                                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                                    |.'.'.'.'.|---|','   /%%%\   ','|---|.'.'.'.'.|
                                    |.'.'.'.'.|===:'    /%%%%%\    ':===|.'.'.'.'.|
                                    |.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|
                                    |.'.'.'.','       /%%%%%%%%%\       ','.'.'.'.|
                                    |.'.'.','        /%%%%%%%%%%%\        ','.'.'.|
                                    |.'.','         /%%%%%%%%%%%%%\         ','.'.|
                                    |.','          /%%%%%%%%%%%%%%%\          ','.|
                                    |;____________/%%%%%Spicer%%%%%%\____________;|       ";

                                        Console.WriteLine(leftHallway2);
                                        Console.ResetColor();

                                        currentScenario = 3;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\n{PartOne[4]}");

                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        string leftHallway2 = @" 
                                     _____________________________________________
                                    |.'',                                     ,''.|
                                    |.'.'',                                  ''.'.|
                                    |.'.',                                   .'.'.|
                                    |.'.'.'.''                              ..'.'.|
                                    |.'.'.'                                  .'.'.|
                                    |.'.'.                                ....'.'.|
                                    |.'.'.'                                  .'.'.|
                                    |.'.'.'.'.                               .'.'.|
                                    |.'.'.                                  ....'.|
                                    |,',',                                    ',',|
                                    |.'.'                                      .'.|
                                    |.'.'.'.                               ... .'.|
                                    |.'.'.'.'                                  .'.|
                                    |.'..'                                   .'.'.|
                                    |.'.'.'.               %%%                '.'.|
                                    |.'',            /%%%  %%%%               '.'.|
                                    |.'.','         / %  %%%%%%%%%\         ','.'.|
                                    |.','          /%%%%%%%%%%%%%%%\          ','.|
                                    |;____________/%%%%%Spicer%%%%%%\____________;|       ";

                                        Console.WriteLine(leftHallway2);
                                        Console.ResetColor();

                                        break;
                                    }
                                }

                            }
                            break;
                        //whatever I want to happen you have for Part One
                        //if at any point you want to enter to come to this scenario
                        //break;
                        case 2:
                            if (!startedPartTwo)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{PartOne[7]}");

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                string junction = @" 
                                     _____________________________________________
                                    |.'',                                     ,''.|
                                    |.'.'',                                 ,''.'.|
                                    |.'.'.'',                             ,''.'.'.|
                                    |.'.'.'.'',                         ,''.'.'.'.|
                                    |.'.'.'.'.|                         |.'.'.'.'.|
                                    |.'.'.'.'.|===;                 ;===|.'.'.'.'.|
                                    |.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|
                                    |.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|
                                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                                    |,',',',',|---|',|'|???????|'|,'|---|,',',',',|
                                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                                    |.'.'.'.'.|---|','   /%%%\   ','|---|.'.'.'.'.|
                                    |.'.'.'.'.|===:'    /%%%%%\    ':===|.'.'.'.'.|
                                    |.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|
                                    |.'.'.'.','       /%%%%%%%%%\       ','.'.'.'.|
                                    |.'.'.','        /%%%%%%%%%%%\        ','.'.'.|
                                    |.'.','         /%%%%%%%%%%%%%\         ','.'.|
                                    |.','          /%%%%%%%%%%%%%%%\          ','.|
                                    |;____________/%%%%%Spicer%%%%%%\____________;|       ";

                                Console.WriteLine(junction);
                                Console.ResetColor();

                                Console.WriteLine($"\n{PartTwo[0]}\n");
                                startedPartTwo = true;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{PartTwo[13]}\n");

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                string junction = @" 
                                     _____________________________________________
                                    |.'',                                     ,''.|
                                    |.'.'',                                 ,''.'.|
                                    |.'.'.'',                             ,''.'.'.|
                                    |.'.'.'.'',                         ,''.'.'.'.|
                                    |.'.'.'.'.|                         |.'.'.'.'.|
                                    |.'.'.'.'.|===;                 ;===|.'.'.'.'.|
                                    |.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|
                                    |.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|
                                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                                    |,',',',',|---|',|'|???????|'|,'|---|,',',',',|
                                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                                    |.'.'.'.'.|---|','   /%%%\   ','|---|.'.'.'.'.|
                                    |.'.'.'.'.|===:'    /%%%%%\    ':===|.'.'.'.'.|
                                    |.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|
                                    |.'.'.'.','       /%%%%%%%%%\       ','.'.'.'.|
                                    |.'.'.','        /%%%%%%%%%%%\        ','.'.'.|
                                    |.'.','         /%%%%%%%%%%%%%\         ','.'.|
                                    |.','          /%%%%%%%%%%%%%%%\          ','.|
                                    |;____________/%%%%%Spicer%%%%%%\____________;|       ";

                                Console.WriteLine(junction);
                                Console.ResetColor();
                            }

                            string junctionOptions;

                            do
                            {
                                Console.WriteLine("\nPlease enter Right, Left, Area or Back.");

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();
                                junctionOptions = Console.ReadLine();
                                junctionOptions = junctionOptions.ToLower();
                            } while (junctionOptions != "back" && junctionOptions != "area" && junctionOptions != "right" && junctionOptions != "left");


                            Console.Clear();

                            if (junctionOptions == "area")
                            {
                                if (newPlayer.hasReport2())
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    Console.WriteLine($"\n{PartTwo[10]}");
                                    break;
                                }
                                else
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    Console.WriteLine($"\n{PartTwo[9]}\n");

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    string report2 = @" 
                                                _________   _________
                                           ____/      452\ /     453 \____
                                         /| ------------- |  ------------ |\
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        ||| ------- ----- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        |||  ------------ | ----------    |||
                                        ||| ------------- |  ------------ |||
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------ -----  |||
                                        ||| ------------  | ------------- |||
                                        |||_____________  |  _____________|||
                                        L/_____/--------\\_//W-------\_____\J


                                                                                                            ";
                                    Console.WriteLine(report2);
                                    Console.ResetColor();
                                    Console.WriteLine($"{TextFragments[1]}\n");
                                    Console.WriteLine($"{TextFragments[6]}");

                                    newPlayer.pickupReport2();
                                    break;
                                }

                            }
                            else if (junctionOptions == "right")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{PartTwo[2]}\n");
                                string kitchenOrBack;

                                do
                                {
                                    Console.WriteLine("Please enter Kitchen or Back.");

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    kitchenOrBack = Console.ReadLine();
                                    kitchenOrBack = kitchenOrBack.ToLower();
                                } while (kitchenOrBack != "kitchen" && kitchenOrBack != "back");

                                Console.Clear();

                                if (kitchenOrBack == "kitchen")
                                {
                                    if (newPlayer.hasKnife() || newPlayer.hasFlare())
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("<=================================================================================================================>");
                                        Console.ResetColor();

                                        Console.WriteLine($"\n{PartTwo[10]}");
                                        Console.WriteLine($"\n{PartTwo[15]}");
                                        break;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("<=================================================================================================================>");
                                        Console.ResetColor();

                                        Console.WriteLine($"\n{PartTwo[6]}");
                                    }
                                }
                                else
                                {
                                    break;
                                }

                                string knifeOrFlare;

                                do
                                {
                                    Console.WriteLine("\nPlease enter Knife or Flare.");

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    knifeOrFlare = Console.ReadLine();
                                    knifeOrFlare = knifeOrFlare.ToLower();
                                } while (knifeOrFlare != "knife" && knifeOrFlare != "flare");

                                Console.Clear();

                                if (knifeOrFlare == "knife")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    if (newPlayer.hasKnife())
                                    {
                                        Console.WriteLine($"\n{PartTwo[10]}");
                                        Console.WriteLine($"\n{PartTwo[15]}");
                                        break;
                                    }

                                    else
                                    {
                                        Console.WriteLine($"\n{PartTwo[11]}");

                                        Console.ForegroundColor = ConsoleColor.Red;
                                        string knifeArt = @" 
                                              ______________________________ ______________________
                                            .'                              | (_)     (_)    (_)   \
                                          .'                                |  __________________   }
                                        .'_.............................____|_(                  )_/

                                                                                                            ";
                                        Console.WriteLine(knifeArt);
                                        Console.ResetColor();

                                        newPlayer.takeKnife();
                                        Console.WriteLine($"\n{PartTwo[15]}");
                                        break;
                                    }
                                }

                                else if (knifeOrFlare == "flare")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    if (newPlayer.hasFlare())
                                    {
                                        Console.WriteLine($"\n{PartTwo[10]}");
                                        Console.WriteLine($"\n{PartTwo[15]}");
                                        break;
                                    }

                                    else
                                    {
                                        Console.WriteLine($"\n{PartTwo[12]}");

                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        string flareArt = @" 
                                           
                                                   (
                                                   )\
                                                   {_}
                                                  .-;-.
                                                 |'-=-'|
                                                 |     |
                                                 |     |
                                                 |     |
                                                 |     |
                                            jgs  '.___.'
                                                                                                            ";
                                        Console.WriteLine(flareArt);
                                        Console.ResetColor();

                                        newPlayer.takeFlare();
                                        Console.WriteLine($"\n{PartTwo[15]}");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    Console.WriteLine($"\n{PartTwo[13]}");
                                    break;
                                }

                            }
                            else if (junctionOptions == "left")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{PartTwo[4]}");

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                string hallDoorArt = @" 
                                           
                                            ____________________________________________
                                            |____________________________________________|
                                            |__||  ||___||  |_|___|___|__|  ||___||  ||__|
                                            ||__|  |__|__|  |___|___|___||  |__|__|  |__||
                                            |__||  ||___||  |_|___|___|__|  ||___||  ||__|
                                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                                            |__||  ||___||  |    || |    |  ||___||  ||__|
                                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                                            |__||  ||___||  | ScS|| |    |  ||___||  ||__|
                                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                                            |__||  ||___||  |   O|| |O   |  ||___||  ||__|
                                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                                            |__||  ||___||  |    || |    |  ||___||  ||__|
                                            ||__|  |__|__|__|____||_|____|  |__|__|  |__||
                                            |LLL|  |LLLLL|______________||  |LLLLL|  |LLL|
                                            |LLL|  |LLL|______________|  |  |LLLLL|  |LLL|
                                            |LLL|__|L|______________|____|__|LLLLL|__|LLL|

                                                                                                            ";
                                Console.WriteLine(hallDoorArt);
                                Console.ResetColor();

                                Console.WriteLine($"\n{PartTwo[14]}\n");
                                string doorOrBack;

                                do
                                {
                                    Console.WriteLine("Please enter Open or Back.");

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    doorOrBack = Console.ReadLine();
                                    doorOrBack = doorOrBack.ToLower();
                                } while (doorOrBack != "open" && doorOrBack != "back");

                                Console.Clear();

                                if (doorOrBack == "open")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("<=================================================================================================================>");
                                    Console.ResetColor();

                                    if (newPlayer.hasKnife())
                                    {
                                        Console.WriteLine($"\n{PartTwo[7]}");

                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        string hallDoorArt2 = @" 
                                           
                                            ____________________________________________
                                            |____________________________________________|
                                            |__||  ||___||  |_|___|___|__|  ||___||  ||__|
                                            ||__|  |__|__|  |___|___|___||  |__|__|  |__||
                                            |__||  ||___||  |_|___|___|__|  ||___||  ||__|
                                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                                            |__||  ||___||  |    || |    |  ||___||  ||__|
                                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                                            |__||  ||___||  | ScS|| |    |  ||___||  ||__|
                                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                                            |__||  ||___||  |    || |    |  ||___||  ||__|
                                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                                            |__||  ||___||  |    || |    |  ||___||  ||__|
                                            ||__|  |__|__|__|____||_|____|  |__|__|  |__||
                                            |LLL|  |LLLLL|______________||  |LLLLL|  |LLL|
                                            |LLL|  |LLL|______________|  |  |LLLLL|  |LLL|
                                            |LLL|__|L|______________|____|__|LLLLL|__|LLL|

                                                                                                            ";
                                        Console.WriteLine(hallDoorArt2);
                                        Console.ResetColor();

                                        currentScenario = 3;
                                        break;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        string hallDoorArt3 = @" 
                                           
                                            ____________________________________________
                                            |____________________________________________|
                                            |__||  ||___||  |_|___|___|__|  ||___||  ||__|
                                            ||__|  |__|__|  |___|___|___||  |__|__|  |__||
                                            |__||  ||___||  |_|___|___|__|  ||___||  ||__|
                                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                                            |__||  ||___||  |    || |    |  ||___||  ||__|
                                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                                            |__||  ||___||  | ScS|| |    |  ||___||  ||__|
                                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                                            |__||  ||___||  |   O|| |O   |  ||___||  ||__|
                                            ||__|  |__|__|  |    || |    |  |__|__|  |__||
                                            |__||  ||___||  |    || |    |  ||___||  ||__|
                                            ||__|  |__|__|__|____||_|____|  |__|__|  |__||
                                            |LLL|  |LLLLL|______________||  |LLLLL|  |LLL|
                                            |LLL|  |LLL|______________|  |  |LLLLL|  |LLL|
                                            |LLL|__|L|______________|____|__|LLLLL|__|LLL|

                                                                                                            ";
                                        Console.WriteLine(hallDoorArt3);
                                        Console.ResetColor();

                                        Console.WriteLine($"\n{PartTwo[5]}");
                                        Console.WriteLine($"\n{PartTwo[15]}");
                                        break;
                                    }
                                }
                            }
                            else if (junctionOptions == "back")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{PartTwo[8]}");
                                currentScenario = 1;
                                break;
                            }
                            break;
                                
                        //everything that happens in part 2
                        case 3:
                            //everything that happens in part 
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("<=================================================================================================================>");
                            Console.ResetColor();

                            if (!startedPartThree)
                            {
                                Console.WriteLine($"\n{PartThree[0]}\n");
                                Console.WriteLine($"\n{PartThree[4]}\n");
                                startedPartThree = true;
                                
                            }
                            else
                            {
                                Console.WriteLine($"{PartThree[6]}\n");
                            }

                            string straightOrRight;

                                do
                                {
                                    Console.WriteLine("\nPlease enter Right, Straight or Back.");

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                straightOrRight = Console.ReadLine();
                                    straightOrRight = straightOrRight.ToLower();
                                } while (straightOrRight != "right" && straightOrRight != "straight" && straightOrRight != "back");

                            Console.Clear();

                            if (straightOrRight == "right")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{PartThree[2]}\n");
                                currentScenario = 7;
                                break;
                            }
                            else if (straightOrRight == "straight")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{PartThree[1]}\n");
                                currentScenario = 4;
                                break;
                            }
                            else if (straightOrRight == "back")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{PartThree[5]}\n");
                                break;
                            }
                            //everything that happens in part 3 -- just a fallback zone really
                            break;

                        case 4:
                            if (!startedHangar)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Hangar[0]}");
                                startedHangar = true;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine(Hangar[7]);
                            }

                            string hangarOptions;

                            do
                            {
                                Console.WriteLine("\nPlease enter Ship, Fuel Station, Repair Depot or Back.");

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                hangarOptions = Console.ReadLine();
                                hangarOptions = hangarOptions.ToLower();
                            } while (hangarOptions != "ship" && hangarOptions != "fuel station" && hangarOptions != "repair depot" && hangarOptions != "back");

                            Console.Clear();

                            if (hangarOptions == "ship")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Hangar[3]}");

                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string shipArt = @" 
                                                                                                                   __
                                                        .'..'.
                                                      .'. __ .'.
                                                     / `------` \
                             __________.---. _      /  \\.--.//  \      _ .---.__________
                __..........|.--------.`.---| |.   /  .'\\  //'.  \   .| |---.'.--------.|..........__
              /_         .--||\\\\\\\\\\ `.-| | ) |  /          \  | ( | |-.' //////////||--.         _\
                '''''''''''''.\\\\\\_..--. `|_|'  | /   .''''.   \ |  `|_|' .--.._//////.'''''''''''''
                              '._.-'      '. '.   | |  / .''. \  | |   .' .'      `-._.`
                                            '. '.  \|  | |  | |  |/  .' .'
                                              '. './\\ \ '..' / //\.' .'
                                                '.   \  `----'  /   .'
                                                  '.  '..____..'  .'
                                                    '-..______..-'    LGB

                                                                                                            ";
                                Console.WriteLine(shipArt);
                                Console.ResetColor();

                                if (!startedShip)
                                {

                                    Console.WriteLine($"\n{Hangar[1]}");
                                    startedShip = true;
                                }
                                else
                                {

                                    Console.WriteLine($"\n{Hangar[10]}");
                                }
                                //if (List of items is complete)
                                //{ }
                                //else
                                //{ }
                                if (newPlayer.itemsNeeded.Count > 0)
                                {
                                    Console.WriteLine($"\n{Hangar[2]}\n");
                                    newPlayer.shipParts();
                                    Console.WriteLine("\n");
                                }

                                else
                                {

                                    if (startedMainframe)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("<=================================================================================================================>");
                                        Console.ResetColor();

                                        Console.WriteLine($"\n{Hangar[11]}\n");
                                        Console.WriteLine($"{Hangar[8]}\n");
                                        return;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("<=================================================================================================================>");
                                        Console.ResetColor();

                                        Console.WriteLine($"\n{Hangar[11]}\n");
                                        Console.WriteLine($"{Hangar[9]}\n");
                                        return;
                                    }
                                }

                                break;
                            }

                            else if (hangarOptions == "fuel station")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Hangar[5]}\n");
                                currentScenario = 5;
                                break;
                            }

                            else if (hangarOptions == "repair depot")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Hangar[6]}\n");
                                currentScenario = 6;
                                break;
                            }

                            else if (hangarOptions == "back")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Hangar[4]}\n");
                                currentScenario = 3;
                                break;
                            }
                            break;

                        case 5:
                            if (!startedFuel)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Fuel[0]}");
                                startedFuel = true;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine(Fuel[9]);
                            }

                            string fuelOptions;

                            do
                            {
                                Console.WriteLine("\nPlease enter Jumpsuit, Oil Drums, Shelves or Back.");

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                fuelOptions = Console.ReadLine();
                                fuelOptions = fuelOptions.ToLower();
                            } while (fuelOptions != "jumpsuit" && fuelOptions != "oil drums" && fuelOptions != "shelves" && fuelOptions != "back");

                            Console.Clear();

                            if (fuelOptions == "jumpsuit")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                if (newPlayer.hasReport3())
                                {
                                    Console.WriteLine($"\n{Fuel[7]}\n");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Fuel[2]}\n");
                                    Console.WriteLine($"\n{Fuel[4]}\n");

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    string report3 = @" 
                                                _________   _________
                                           ____/      452\ /     453 \____
                                         /| ------------- |  ------------ |\
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        ||| ------- ----- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        |||  ------------ | ----------    |||
                                        ||| ------------- |  ------------ |||
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------ -----  |||
                                        ||| ------------  | ------------- |||
                                        |||_____________  |  _____________|||
                                        L/_____/--------\\_//W-------\_____\J


                                                                                                            ";
                                    Console.WriteLine(report3);
                                    Console.ResetColor();
                                    Console.WriteLine($"{TextFragments[2]}\n");
                                    Console.WriteLine($"{TextFragments[6]}");

                                    newPlayer.pickupReport3();
                                    break;
                                }
                            }

                            else if (fuelOptions == "oil drums")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Fuel[6]}\n");
                                break;
                            }

                            else if (fuelOptions == "shelves")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                if (newPlayer.hasCanister())
                                {
                                    Console.WriteLine($"\n{Fuel[3]}\n");
                                    Console.WriteLine($"\n{Fuel[7]}\n");
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    string canisterArt = @" 
                                                  ..
                                            __..-'||'-..__
                                    ..__..-'      ||      `-..__..
                                    ||`-..__              __..-'||
                                    ||      `-..__..__..-'      ||
                                    ||`-..__      ||'     __..-'||
                                    ||      `-..__||__..-'      ||
                                    ||`-..__      ||      __..-'||
                                    ||      `-..__||__..-'      ||
                                    ||`-..__      ||      __..-'||
                                    ||      `-..__||__..-'      ||
                                    ''`-..__      ||      __..-'''
                                       LGB  `-..__||__..-'
                                                  ''


                                                                                                            ";
                                    Console.WriteLine(canisterArt);
                                    Console.ResetColor();

                                    Console.WriteLine($"\n{Fuel[3]}\n");
                                    newPlayer.pickupCanister();
                                    Console.WriteLine($"\n{Fuel[5]}\n");
                                    break;
                                }
                            }

                            else if (fuelOptions == "back")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Hangar[7]}\n");
                                currentScenario = 4;
                                break;
                            }
                            break;

                        case 6:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("<=================================================================================================================>");
                            Console.ResetColor();

                            if (!startedDepot)
                            {

                                Console.WriteLine($"\n{Depot[0]}");
                                startedDepot = true;
                            }
                            else
                            {
                                Console.WriteLine(Depot[9]);
                            }

                            string DepotOptions;

                            do
                            {
                                Console.WriteLine("\nPlease enter Room, Desk, Filing Cabinet, Toolbox or Back.");

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                DepotOptions = Console.ReadLine();
                                DepotOptions = DepotOptions.ToLower();
                            } while (DepotOptions != "room" && DepotOptions != "desk" && DepotOptions != "filing cabinet" && DepotOptions != "toolbox" && DepotOptions != "back");

                            Console.Clear();

                            if (DepotOptions == "room")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                if (newPlayer.hasReport4())
                                {
                                    Console.WriteLine($"\n{Depot[6]}\n");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Depot[1]}\n");
                                    Console.WriteLine($"\n{Depot[5]}\n");

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    string report4 = @" 
                                                _________   _________
                                           ____/      452\ /     453 \____
                                         /| ------------- |  ------------ |\
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        ||| ------- ----- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        |||  ------------ | ----------    |||
                                        ||| ------------- |  ------------ |||
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------ -----  |||
                                        ||| ------------  | ------------- |||
                                        |||_____________  |  _____________|||
                                        L/_____/--------\\_//W-------\_____\J


                                                                                                            ";
                                    Console.WriteLine(report4);
                                    Console.ResetColor();
                                    Console.WriteLine($"{TextFragments[3]}\n");
                                    Console.WriteLine($"{TextFragments[6]}");

                                    newPlayer.pickupReport4();
                                    break;
                                }
                            }

                            else if (DepotOptions == "desk")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                if (newPlayer.hasReport5())
                                {
                                    Console.WriteLine($"\n{Depot[6]}\n");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Depot[2]}\n");
                                    Console.WriteLine($"\n{Depot[10]}\n");

                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    string report5 = @" 
                                                _________   _________
                                           ____/      452\ /     453 \____
                                         /| ------------- |  ------------ |\
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        ||| ------- ----- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        |||  ------------ | ----------    |||
                                        ||| ------------- |  ------------ |||
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------ -----  |||
                                        ||| ------------  | ------------- |||
                                        |||_____________  |  _____________|||
                                        L/_____/--------\\_//W-------\_____\J


                                                                                                            ";
                                    Console.WriteLine(report5);
                                    Console.ResetColor();
                                    Console.WriteLine($"{TextFragments[4]}\n");
                                    Console.WriteLine($"{TextFragments[6]}");

                                    newPlayer.pickupReport5();
                                    break;
                                }
                            }

                            else if (DepotOptions == "filing cabinet")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Depot[7]}\n");
                                break;
                            }

                            else if (DepotOptions == "toolbox")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Depot[4]}\n");

                                Console.ForegroundColor = ConsoleColor.Red;
                                string toolboxArt = @" 
                                                    ________________  _______________
                                                 .'               .'               .|
                                               .'               .'               .' |
                                             .'_______________.'______________ .'   |
                                             | ___ _____ ___ || ___ _____ ___ |     |
                                             ||_=_|__=__|_=_||||_=_|__=__|_=_||     |
                                      _______||_____===_____||||_____===_____||     |
                                    .'       ||_____===_____||||_____===_____||    .|
                                  .'         ||_____===_____||||_____===_____||  .' |
                                .'___________|_______________||_______________|.'   |
                                |.----------.|.-----___-----.||.-----___-----.|     |
                                |]          |||_____________||||_____________||     |
                                ||          ||.-----___-----.||.-----___-----.|     |
                                ||          |||_____________||||_____________||     |
                                ||          ||.-----___-----.||.-----___-----.|     |
                                |]         o|||_____________||||_____________||     |
                                ||          ||.-----___-----.||.-----___-----.|     |
                                ||          |||             ||||_____________||     |
                                ||          |||             |||.-----___-----.|    .'
                                |]          |||             ||||             ||  .'o)
                                ||__________|||_____________||||_____________||.'
                                ''----------'''------------------------------''
                                            (o)LGB                          (o)      ";

                                Console.WriteLine(toolboxArt);
                                Console.ResetColor();

                                if (newPlayer.hasTape())
                                {
                                    Console.WriteLine($"\n{Depot[6]}\n");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Depot[8]}\n");
                                    newPlayer.pickupTape();
                                    break;
                                }
                            }

                            else if (DepotOptions == "back")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Depot[11]}\n");
                                currentScenario = 4;
                                break;
                            }
                            break;

                        case 7:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("<=================================================================================================================>");
                            Console.ResetColor();

                            if (!startedHall)
                            {
                                Console.WriteLine($"\n{Hall[0]}");

                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string hangarHallArt = @" 
                                     _____________________________________________
                                    |.'',                                     ,''.|
                                    |.'.'',                                 ,''.'.|
                                    |.'.'.'',                             ,''.'.'.|
                                    |.'.'.'.'',                         ,''.'.'.'.|
                                    |.'.'.'.'.|                         |.'.'.'.'.|
                                    |.'.'.'.'.|===;                 ;===|.'.'.'.'.|
                                    |.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|
                                    |.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|
                                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                                    |,',',',',|---|',|'|???????|'|,'|---|,',',',',|
                                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                                    |.'.'.'.'.|---|','   /%%%\   ','|---|.'.'.'.'.|
                                    |.'.'.'.'.|===:'    /%%%%%\    ':===|.'.'.'.'.|
                                    |.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|
                                    |.'.'.'.','       /%%%%%%%%%\       ','.'.'.'.|
                                    |.'.'.','        /%%%%%%%%%%%\        ','.'.'.|
                                    |.'.','         /%%%%%%%%%%%%%\         ','.'.|
                                    |.','          /%%%%%%%%%%%%%%%\          ','.|
                                    |;____________/%%%%%Spicer%%%%%%\____________;|       ";

                                Console.WriteLine(hangarHallArt);
                                Console.ResetColor();

                                startedHall = true;
                            }
                            else
                            {
                                Console.WriteLine($"\n{Hall[5]}");

                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string hangarHallArt = @" 
                                     _____________________________________________
                                    |.'',                                     ,''.|
                                    |.'.'',                                 ,''.'.|
                                    |.'.'.'',                             ,''.'.'.|
                                    |.'.'.'.'',                         ,''.'.'.'.|
                                    |.'.'.'.'.|                         |.'.'.'.'.|
                                    |.'.'.'.'.|===;                 ;===|.'.'.'.'.|
                                    |.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|
                                    |.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|
                                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                                    |,',',',',|---|',|'|???????|'|,'|---|,',',',',|
                                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                                    |.'.'.'.'.|---|','   /%%%\   ','|---|.'.'.'.'.|
                                    |.'.'.'.'.|===:'    /%%%%%\    ':===|.'.'.'.'.|
                                    |.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|
                                    |.'.'.'.','       /%%%%%%%%%\       ','.'.'.'.|
                                    |.'.'.','        /%%%%%%%%%%%\        ','.'.'.|
                                    |.'.','         /%%%%%%%%%%%%%\         ','.'.|
                                    |.','          /%%%%%%%%%%%%%%%\          ','.|
                                    |;____________/%%%%%Spicer%%%%%%\____________;|       ";

                                Console.WriteLine(hangarHallArt);
                                Console.ResetColor();
                            }

                            string hallOptions;

                            do
                            {
                                Console.WriteLine("\nPlease enter Left, Right, Straight or Back.");

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                hallOptions = Console.ReadLine();
                                hallOptions = hallOptions.ToLower();
                            } while (hallOptions != "left" && hallOptions != "right" && hallOptions != "straight" && hallOptions != "back");

                            Console.Clear();

                            if (hallOptions == "left")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Hall[1]}\n");
                                currentScenario = 8;
                                break;
                            }

                            else if (hallOptions == "right")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Hall[2]}\n");
                                currentScenario = 10;
                                break;
                            }

                            else if (hallOptions == "straight")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Hall[3]}\n");
                                currentScenario = 9;
                                break;
                            }

                            else if (hallOptions == "back")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Hall[4]}\n");
                                currentScenario = 3;
                                break;
                            }
                            break;

                        case 8:

                            if (!startedRecRoom)
                            {
                                Console.WriteLine($"{RecRoom[0]}\n");
                                currentScenario = 7;
                                startedRecRoom = true;
                            }
                            else
                            {
                                Console.WriteLine($"{RecRoom[1]}\n");
                                currentScenario = 7;
                            }

                            break;

                        case 9:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("<=================================================================================================================>");
                            Console.ResetColor();

                            if (!startedTower)
                            {
                                Console.WriteLine($"\n{Tower[0]}");

                                Console.ForegroundColor = ConsoleColor.Blue;
                                string towerArt = @" 
                                   
                                                   *
                                                   :
                                                   |
                                                   |
                                                   |
                                                  :|:
                                                  |||
                                             _____|||_____
                                            /=============\
                                        ---<~~~~~~~~~~~~~~~>---
                                            \-------------/
                                             \___________/
                                               \||:::||/
                                                ||:::||
                                                ||:::||
                                                ||:::||
                                                ||ooo||
                                                ||___||
                                                ||:::||
                                                ||:::||
                                                ||:::||
                                                ||:::||
                                                ||:::||
                                               /||:::||\
                                              / ||:::|| \
                                             /  ||:::||  \
                                            /   ||:::||   \
                                        ___/____||:::||____\____
                                       /~~~~~~~~~~~~~~~~~~~~~~~~\
                                      /   |~~~~~~~~|  _____      \
                                      |   |________| |  |  |     | 
                                ______|______________|__|__|_____|_________      ";

                                Console.WriteLine(towerArt);
                                Console.ResetColor();

                                startedDepot = true;
                            }
                            else
                            {
                                Console.WriteLine(Tower[8]);

                                Console.ForegroundColor = ConsoleColor.Blue;
                                string towerArt = @" 
                                   
                                                   *
                                                   :
                                                   |
                                                   |
                                                   |
                                                  :|:
                                                  |||
                                             _____|||_____
                                            /=============\
                                        ---<~~~~~~~~~~~~~~~>---
                                            \-------------/
                                             \___________/
                                               \||:::||/
                                                ||:::||
                                                ||:::||
                                                ||:::||
                                                ||ooo||
                                                ||___||
                                                ||:::||
                                                ||:::||
                                                ||:::||
                                                ||:::||
                                                ||:::||
                                               /||:::||\
                                              / ||:::|| \
                                             /  ||:::||  \
                                            /   ||:::||   \
                                        ___/____||:::||____\____
                                       /~~~~~~~~~~~~~~~~~~~~~~~~\
                                      /   |~~~~~~~~|  _____      \
                                      |   |________| |  |  |     | 
                                ______|______________|__|__|_____|_________      ";

                                Console.WriteLine(towerArt);
                                Console.ResetColor();
                            }

                            string TowerOptions;

                            do
                            {
                                Console.WriteLine("\nPlease enter Mainframe, Console, Button, or Back.");

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                TowerOptions = Console.ReadLine();
                                TowerOptions = TowerOptions.ToLower();
                            } while (TowerOptions != "mainframe" && TowerOptions != "console" && TowerOptions != "button" && TowerOptions != "back");

                            Console.Clear();

                            if (TowerOptions == "mainframe")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                if (!startedMainframe)
                                {
                                    Console.WriteLine($"\n{Tower[3]}\n");
                                    Console.WriteLine($"\n{Tower[6]}\n");
                                    startedMainframe = true;
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine($"\n{Tower[8]}\n");
                                    break;
                                }
                            }

                            else if (TowerOptions == "console")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                if (!startedConsole)
                                {
                                    Console.WriteLine($"\n{Tower[2]}\n");
                                    Console.WriteLine($"\n{Tower[5]}\n");
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine($"\n{Tower[9]}\n");
                                    break;
                                }
                            }

                            else if (TowerOptions == "button")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                if (!startedButton)
                                {
                                    Console.WriteLine($"\n{Tower[4]}\n");
                                    Console.WriteLine($"\n{Tower[7]}\n");
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine($"\n{Tower[12]}\n");
                                    break;
                                }
                            }

                            else if (TowerOptions == "back")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Tower[11]}\n");
                                currentScenario = 7;
                                break;
                            }
                            break;

                        case 10:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("<=================================================================================================================>");
                            Console.ResetColor();

                            if (!startedRadar)
                            {
                                Console.WriteLine($"\n{Radar[0]}");
                                startedRadar = true;
                            }
                            else
                            {
                                Console.WriteLine(Radar[9]);
                            }

                            string RadarOptions;

                            do
                            {
                                Console.WriteLine("\nPlease enter Room, Computer, Shelves or Back.");

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                RadarOptions = Console.ReadLine();
                                RadarOptions = RadarOptions.ToLower();
                            } while (RadarOptions != "room" && RadarOptions != "computer" && RadarOptions != "shelves" && RadarOptions != "back");

                            Console.Clear();

                            if (RadarOptions == "room")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                if (newPlayer.hasReport6())
                                {
                                    Console.WriteLine($"\n{Radar[5]}\n");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Radar[1]}\n");
                                    Console.WriteLine($"\n{Radar[4]}\n");

                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    string report6 = @" 
                                                _________   _________
                                           ____/      452\ /     453 \____
                                         /| ------------- |  ------------ |\
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        ||| ------- ----- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------------- |||
                                        |||  ------------ | ----------    |||
                                        ||| ------------- |  ------------ |||
                                        ||| ------------- | ------------- |||
                                        ||| ------------- | ------ -----  |||
                                        ||| ------------  | ------------- |||
                                        |||_____________  |  _____________|||
                                        L/_____/--------\\_//W-------\_____\J


                                                                                                            ";
                                    Console.WriteLine(report6);
                                    Console.ResetColor();
                                    Console.WriteLine($"{TextFragments[5]}\n");
                                    Console.WriteLine($"{TextFragments[7]}");

                                    newPlayer.pickupReport6();
                                    break;
                                }
                            }

                            else if (RadarOptions == "computer")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                {
                                    if (newPlayer.hasMotherboard())
                                    {
                                        Console.WriteLine($"\n{Radar[7]}\n");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\n{Radar[2]}\n");

                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        string computerArt = @" 
                                            _________________
                                           /                /|
                                          /                / |
                                         /________________/ /|
                                      ###|      ____      |//|
                                     #   |     /   /|     |/.|
                                    #  __|___ /   /.|     |  |_______________
                                   #  /      /   //||     |  /              /|                  ___
                                  #  /      /___// ||     | /              / |                 / \ \
                                  # /______/!   || ||_____|/              /  |                /   \ \
                                  #| . . .  !   || ||                    /  _________________/     \ \
                                  #|  . .   !   || //      ________     /  /\________________  {   /  }
                                  /|   .    !   ||//~~~~~~/   0000/    /  / / ______________  {   /  /
                                 / |        !   |'/      /9  0000/    /  / / /             / {   /  /
                                / #\________!___|/      /9  0000/    /  / / /_____________/___  /  /
                               / #     /_____\/        /9  0000/    /  / / /_  /\_____________\/  /
                              / #                      ``^^^^^^    /   \ \ . ./ / ____________   /
                             +=#==================================/     \ \ ./ / /.  .  .  \ /  /
                             |#                                   |      \ \/ / /___________/  /
                             #                                    |_______\__/________________/
                             |                                    |               |  |  / /       
                             |                                    |               |  | / /       
                             |                                    |       ________|  |/ /________       
                             |                                    |      /_______/    \_________/\       
                             |                                    |     /        /  /           \ )       
                             |                                    |    /OO^^^^^^/  / /^^^^^^^^^OO\)       
                             |                                    |            /  / /        
                             |                                    |           /  / /
                             |                                    |          /___\/
                             |hectoras                            |           oo
                             |____________________________________|

                                                                                                            ";
                                        Console.WriteLine(computerArt);
                                        Console.ResetColor();

                                        Console.WriteLine($"\n{Radar[6]}\n");
                                        newPlayer.pickupMotherboard();
                                        break;
                                    }
                                }
                            }

                            else if (RadarOptions == "shelves")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                if (newPlayer.hasPulseCharger())
                                {
                                    Console.WriteLine($"\n{Radar[5]}\n");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Radar[3]}\n");

                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    string pulseChargerArt = @" 
                                      _______________________________________
                                     /                                       \
                                    |  {###################################}  |
                                    |  {###################################}  |
                                    |  {###################################}  |
                                    |  {###################################}  |
                                    |  {###################################}  |
                                    |  {###################################}  |
                                    |                                         |
                                    |               80  90  100               |
                                    |            70     ^      120            |       
                                    |        60 *      /|\       * 140        |
                                    |    55             |              160    |
                                    |                   |                     |
                                    |                   |                     |
                                    |   (O)            (+)              (O)   |
                                     \_______________________________________/
                                                                                                            ";
                                    Console.WriteLine(pulseChargerArt);
                                    Console.ResetColor();

                                    Console.WriteLine($"\n{Radar[8]}\n");
                                    newPlayer.pickupPulseCharger();
                                    break;
                                }
                            }

                            else if (RadarOptions == "back")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("<=================================================================================================================>");
                                Console.ResetColor();

                                Console.WriteLine($"\n{Radar[10]}\n");
                                currentScenario = 7;
                                break;
                            }
                            break;

                        default:
                            //they shouldnt end here
                            break;
                    }
                }
               
               
            }
        }

        public void Inventory()
        {
            Console.WriteLine($"Congradulations! Your adventurer, {newPlayer.getName()}, has succesfully escaped the planet and is headed back home!\n");
            Console.WriteLine($"Here are the items {newPlayer.getName()} collected during the game:\n");

            foreach (Item itemsCollected in newPlayer.inventory)
            {
                itemsCollected.displayText();
            }

            foreach (Note notesCollected in newPlayer.notes)
            {

                notesCollected.displayText();
            }
        }

        public void End()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n<=================================================================================================================>\n");
            Console.ResetColor();

            Console.WriteLine("GAME OVER!");

            Console.Write("\nPress ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ENTER ");
            Console.ResetColor();
            Console.Write("to return to the main menu. Thanks for playing!\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<=================================================================================================================>");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
