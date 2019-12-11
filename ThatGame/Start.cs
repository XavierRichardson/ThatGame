using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame
{
    class Start
    {
        private static Commands commands = new Commands();
        private static List<string> _commands = commands.returnCommandList(new string[] { "Start", "Load Save", "Options", "Exit" });
        private static ContentBox StartCommands = new ContentBox();
        private static TextAlignments _align = new TextAlignments();
        public static void BeginGame(bool firstStart = true) {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            _align.centerText("Welcome to This Game known as \"ThatGame\"", firstStart);
            _align.centerText(" Use the arrowkeys or WS to scroll up/down the list. Press Enter to select", firstStart);

            if (firstStart == true) {
                StartCommands = commands.SetCommandBox(_commands,"Commands");
            }
          
            StartCommands.currentChoice = commands.printCommands(StartCommands, firstStart);
            
            listen();
        }


        //Listens for the user to enter a key command. 
        private static void listen() {
            bool exit = false;
            while (exit == false) {
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow) {
                    StartCommands.currentChoice = (StartCommands.currentChoice - 1);
                    Console.Clear();
                    BeginGame(false);
                } else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow) {
                    StartCommands.currentChoice = (StartCommands.currentChoice + 1);
                    Console.Clear();
                    BeginGame(false);
                } else if (key == ConsoleKey.Enter) {
                    runCommand(StartCommands.currentChoice);
                }

            }
        }

        //Only exectues after pressing enter. Executes a command based on commandId
        private static void runCommand(int commandId) {
            switch (commandId) {
                case 0:
                    CharacterPage.createNewCharacter();
                    break;
                case 1:
                    Console.WriteLine(_commands[commandId]);
                    break;
                case 2:
                    Console.WriteLine(_commands[commandId]);
                    break;
                case 3:
                    Console.WriteLine("Thank you for playing");
                    Environment.Exit(0);
                    break;
            }
        }

        


    }                
}
