using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame
{
    class Start
    {
        private static Commands commands = new Commands();
        private static List<string> _commands = commands.returnCommandList(new string[] { "Start", "Load Save", "Options", "Exit" });
        private static TextAlignments _align = new TextAlignments();
        private static int currCommand = 0;
        public static void BeginGame(bool firstStart = true) {
            

            _align.centerText("Welcome to This Game known as \"ThatGame\"", firstStart);
            _align.newLine();
            _align.centerText(" Use the arrowkeys or WS to scroll up/down the list. Press Enter to select", firstStart);

          
                currCommand = commands.printCommands(_commands, currCommand, firstStart);
            
            listen();
        }

        //Listens for the user to enter a key command. 
        private static void listen() {
            bool exit = false;
            while (exit == false) {
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow) {
                    currCommand = (currCommand - 1);
                    Console.Clear();
                    BeginGame(false);
                } else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow) {
                    currCommand = (currCommand + 1);
                    Console.Clear();
                    BeginGame(false);
                } else if (key == ConsoleKey.Enter) {
                    runCommand(currCommand);
                }

            }
        }

        //Only exectues after pressing enter. Executes a command based on commandId
        private static void runCommand(int commandId) {
            switch (commandId) {
                case 0:
                    createNewCharacter();
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

        private static void createNewCharacter() {
            Console.Clear();

        }


    }                
}
