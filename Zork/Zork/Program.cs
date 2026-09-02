
bool isGame = true;
bool isMenu = true;
bool isPlaying = false;
bool hasKey = false;
bool intro = false;
int guessesLeft = 10;
int randomNumber = new Random().Next(0, 100);

//Console.WriteLine("Use (help) for a list of commands");
string myLocation = "Starting Room";
int hallwaycounter = 0;


while (isGame)
{
    while (isMenu == true)
    {
        Console.WriteLine("_______________________");
        Console.WriteLine("Hello welcome to" +
            "\n ▒▒▒▒  ▒▒▒   ▒▒▒   ▒  ▒" +
            "\n   ▒  ▒   ▒  ▒  ▒  ▒ ▒" +
            "\n  ▒   ▒   ▒  ▒▒▒   ▒▒" +
            "\n ▒    ▒   ▒  ▒ ▒   ▒ ▒" +
            "\n▒▒▒▒   ▒▒▒   ▒  ▒  ▒  ▒" +
            "\n\n1.Start Game\n2.Info\n3.Quit");
        Console.WriteLine("");
        Console.Write("> ");

        string? myMenu = Console.ReadLine();
        if (myMenu == "1")
        {
            Console.WriteLine("Starting Game...");
            Console.WriteLine("");
            isPlaying = true;
            intro = true;
            isMenu = false;
            Console.Clear();

        }
        if (myMenu == "2")
        {
            Console.WriteLine("Game Info:\n" +
                " Zork is a text-based adventure game." +
                "\n Where you explore a world and interact with objects and characters through text commands." +
                "\n You can move around, inspect your surroundings, and solve puzzles to progress through the game." +
                "\nCommands:" +
                "\n- forward/f" +
                "\n- back/b" +
                "\n- right/r" +
                "\n- left/l" +
                "\n- inspect/look" +
                "\n- use, eat, talk, map" +
                "\n- save, menu, quit" +
                "\n\nHave fun exploring!");
        }
        if (myMenu == "3")
        {
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
    }

    while (isPlaying == true)
    {
        if (intro == true)
        {
            Console.WriteLine("\nYou are in a room with 3 doors");
            Console.WriteLine("There are doors to your Front, Left and Right");
            intro = false;
        }
        else
        {

        }

        Console.WriteLine("");
        Console.Write("> ");
        string? myCommand = Console.ReadLine();


        //Helping player
        if (myCommand == "help")
        {
            Console.WriteLine("Movement: (forward/f, back/b, right/r, left/l)");
            Console.WriteLine("information: (inspect/look), use, talk, eat, map");
            Console.WriteLine("save, menu, quit");
        }

        //inputs
        if (myCommand == "save")
        {
            Console.WriteLine("Can't save LOL");
        }
        if (myCommand == "menu")
        {
            Console.WriteLine("Returning to menu...");
            isMenu = true;
            isPlaying = false;
            Console.Clear();
        }
        if (myCommand == "quit")
        {
            Console.WriteLine("Why do you hate me?");
            Environment.Exit(0);
        }
        if (myCommand == "picture")
        {
            Console.WriteLine(
"\n                          █" +
"\n    ▄                   ▄█▓█" +
"\n   ▐██▄               ▄▓░░▓▓" +
"\n   ▐█░██▓            ▓▓░░░▓▌" +
"\n   ▐█▌░▓██          █▓░░░░▓" +
"\n   ▓█▌░░▓█▄███████▄███▓░▓█" +
"\n    ▓██▌░▓██░░░░░░░░░░▓█░▓▌" +
"\n     ▓█████░░░░░░░░░░░░▓██" +
"\n     ▓██▓░░░░░░░░░░░░░░░▓█" +
"\n     ▐█▓░░░░░░█▓░░▓█░░░░▓█▌" +
"\n     ▓█▌░▓█▓▓██▓░█▓▓▓▓▓░▓█▌" +
"\n     ▓▓░▓██████▓░▓███▓▓▌░█▓" +
"\n    ▐▓▓░█▄▐▓▌█▓░░▓█▐▓▌▄▓░██" +
"\n    ▓█▓░▓█▄▄▄█▓░░▓█▄▄▄█▓░██▌" +
"\n    ▓█▌░▓█████▓░░░▓███▓▀░▓█▓" +
"\n   ▐▓█░░░▀▓██▀░░░░░─▀▓▀░░▓█▓" +
"\n   ▓██░░░░░░░░▀▄▄▄▄▀░░░░░░▓▓" +
"\n   ▓█▌░░░░░░░░░░▐▌░░░░░░░░▓▓▌" +
"\n   ▓█░░░░░░░░░▄▀▀▀▀▄░░░░░░░█▓" +
"\n  ▐█▌░░░░░░░░▀░░░░░░▀░░░░░░█▓" +
"\n  ▓█░░░░░░░░░░░░░░░░░░░░░░░██▓" +
"\n  ▓█░░░░░░░░░░░░░░░░░░░░░░░▓█▓" +
"\n  ██░░░░░░░░░░░░░░░░░░░░░░░░█▓" +
"\n  █▌░░░░░░░░░░░░░░░░░░░░░░░░▐▓▌" +
"\n ▐▓░░░░░░░░░░░░░░░░░░░░░░░░░░█▓" +
"\n █▓░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓" +
"\n █▓░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓" +
"\n▐█▓░░░░░░░░░░░░░░░░░░░░░░░░░░░█" +
"\n█▓▌░░░░░░░░░░░░░░░░░░░░░░░░░░░▓");
        }
        if (myCommand == "map" || myCommand == "m")
        {
            Console.WriteLine(
            "Doors:█\n"+
            "\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓" +
            "\n▓▓▓▓▓▓▓▓▓        ▓▓▓▓▓▓▓▓▓▓" +
            "\n▓▓▓▓▓▓▓▓▓        ▓▓▓▓▓▓▓▓▓▓" +
            "\n▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓" +
            "\n▓    ▓▓▓▓       ▓         ▓" +
            "\n▓    ░  ░ Start ░ Kitchen ▓" +
            "\n▓    ▓▓▓▓       ▓         ▓" +
            "\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓"
            );
        }

        //Locations

        //Starting room
        // Inspecting the starting room
        if (myLocation == "Starting Room")
        {
            if (myCommand == "inspect" || myCommand == "look")
            {
                Console.WriteLine("There are doors to your Front, Left and Right");
            }
        }
        // Moving from the starting room
        if (myLocation == "Starting Room")
        {
            if (myCommand == "right" || myCommand == "r")
            {
                myLocation = "Kitchen";
                Console.WriteLine("You have entered the Kitchen");
            }
            if (myCommand == "forward" || myCommand == "f")
            {
                myLocation = "North Door";
                Console.WriteLine("you are looking at a locked door.");
                Console.WriteLine("It seems like you need a key to open it.");
            }
            if (myCommand == "left" || myCommand == "l")
            {
                myLocation = "West Hallway";
                Console.WriteLine("You have entered the Left Hallway");
            }
        }

        //North Door
        if (myLocation == "North Door")
        {
            if (myCommand == "back" || myCommand == "b")
            {
                myLocation = "Starting Room";
                Console.WriteLine("You move back from the door.");
            }
            if(myCommand == "left" || myCommand == "l")
            {
                myLocation = "West Hallway";
                Console.WriteLine("You move to the Left Hallway.");
            }
            if(myCommand == "right" || myCommand == "r")
            {
                myLocation = "Kitchen";
                Console.WriteLine("You move to the Kitchen.");
            }
            if (myCommand == "inspect" || myCommand == "look")
            {
                Console.WriteLine("The door is locked. You need a key to open it.");
            }
        }
        if (hasKey == true && myLocation == "North Door")
        {
            if (myCommand == "use")
            {
                Console.WriteLine("You use the key to unlock the door and enter the next room.");
                myLocation = "Next Room";
            }
        }
        else if (hasKey == false && myLocation == "North Door")
        {
            if (myCommand == "use")
            {
                Console.WriteLine("You don't have the key to unlock the door.");
            }
            if (myCommand == "eat")
            {
                Console.WriteLine("you ate the door and died");
                Environment.Exit(0);
            }
        }

        //Next Room
        if (myLocation == "Next Room")
        {
            Console.WriteLine("");
            Console.WriteLine("YOU WIN");
            Console.WriteLine("");
            Environment.Exit(0);
        }

        //  East Room
        //      Kitchen
        //        Inspecting the Kitchen
        if (myLocation == "Kitchen")
        {
            if (myCommand == "inspect" || myCommand == "look")
            {
                Console.WriteLine("There is a Fridge to the infront of you and a man to the left.");
            }
        }

        // Moving from the Kitchen
        if (myLocation == "Kitchen")
        {
            if (myCommand == "back" || myCommand == "b")
            {
                myLocation = "Starting Room";
                Console.WriteLine("You are back in the Starting Room");
            }
            if (myCommand == "forward" || myCommand == "f")
            {
                myLocation = "Fridge";
                Console.WriteLine("You are looking at the Fridge");
            }
            if (myCommand == "left" || myCommand == "l")
            {
                myLocation = "Man";
                Console.WriteLine("You see a man sitting on a chair.");
            }
        }
        //  Man
        if (myLocation == "Man")
        {
            if (myCommand == "inspect" || myCommand == "look")
            {
                Console.WriteLine("The man is sitting on a chair, looking at you.");
            }
            if (myCommand == "talk")
            {
                myLocation = "Guessing Game";
                Console.WriteLine("The man says:\n'Guess what number i'm thinking about between 0 and 100.'\n'But be careful!'");
            }
        }

        //Guessing Game
        if (myLocation == "Guessing Game")
        {
            if (myCommand == null)
            {
                Console.WriteLine("Please enter a number.");
            }
            else if (int.TryParse(myCommand, out int guess))
            {
                if (guess < randomNumber)
                {
                    Console.WriteLine("Higher ^");
                    guessesLeft--;
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Lower v");
                    guessesLeft--;
                }
                else if (guess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the number." +
                        "\n 'use the command 'picture''." +
                        "\nYou are back in the middle of the Kitchen");
                    myLocation = "Kitchen";
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number between 0 and 100.");
            }

            if (guessesLeft <= 0)
            {
                Console.WriteLine("I'm sorry, but you've run out of guesses." +
                    "\nThe man killed you" +
                    "\nTry again.");
                Environment.Exit(0);
            }
        }


        //  Fridge
        if (myLocation == "Fridge")
        {
            if (myCommand == "inspect" || myCommand == "look")
            {
                Console.WriteLine("The Fridge is closed. You can use it to open it.");
            }
            if (myCommand == "use")
            {
                myLocation = "inside Fridge";
                Console.WriteLine("You open the Fridge and see Jello with a Key inside.");
            }
            if (myCommand == "back" || myCommand == "b")
            {
                myLocation = "Kitchen";
                Console.WriteLine("You are back in the Kitchen");
            }
        }

        //  inside Fridge
        if (myLocation == "inside Fridge")
        {
            if (myCommand == "eat")
            {
                Console.WriteLine("You eat the Jello and get the Key.");
                hasKey = true;
            }

            if (myCommand == "back" || myCommand == "b")
            {
                myLocation = "Kitchen";
                Console.WriteLine("You are back in the Kitchen");
            }
            if (myCommand == "inspect" || myCommand == "look")
            {
                Console.WriteLine("There is a Key inside the Jello.");
            }
        }

        //  West Hallway
        //      Inspecting the West Hallway
        if (myLocation == "West Hallway")
        {
            if (myCommand == "inspect" || myCommand == "look")
            {
                Console.WriteLine("There is a door at the end of the hallway.");
            }
        }

        // Moving in hallway
        if (myLocation == "West Hallway")
        {
            if (myCommand == "back" || myCommand == "b")
            {
                myLocation = "Starting Room";
                Console.WriteLine("You are back in the Starting Room");
                hallwaycounter = 0;
            }
            if (myCommand == "forward" || myCommand == "f")
            {
                myLocation = "Hallway2";
                hallwaycounter = hallwaycounter + 1;
                Console.WriteLine("You walk down the hallway.");
            }
            if (hallwaycounter == 5)
            {
                myLocation = "Stuck";
            }
        }
        if (myLocation == "Hallway2")
        {
            if (myCommand == "back" || myCommand == "b")
            {
                myLocation = "Starting Room";
                Console.WriteLine("You walk back to the Starting Room.");
                hallwaycounter = 0;
            }
            if (myCommand == "forward" || myCommand == "f")
            {
                myLocation = "West Hallway";
            }
            if (myCommand == "inspect" || myCommand == "look")
            {
                Console.WriteLine("There is a door at the end of the hallway.");
            }
        }
        if (myLocation == "Stuck")
        {
            if (myCommand == "back" || myCommand == "b")
            {
                Console.WriteLine("The door is no where to be found.");
            }
            if (myCommand == "forward" || myCommand == "f")
            {
                Console.WriteLine("Something is feeling strange but you keep going.");
            }
            if (myCommand == "eat")
            {
                Console.WriteLine("You try to eat the walls but you fail.\n\nGG");
                Environment.Exit(0);
            }
            if (myCommand == "inspect" || myCommand == "look")
            {
                Console.WriteLine("there is a door at the end of the hallway.");
            }
        }
    }
}








