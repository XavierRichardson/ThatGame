using System;
using System.Collections.Generic;
using System.Text;
using ThatGame.Objects;

namespace ThatGame.Pages.Partials.CharacterTraits
{
    class Race
    {
        private static TextAlignments _align = new TextAlignments();
        private static Commands command = new Commands();
        private static ContentBox races = getRaces();
        public static void loadPage(bool fastType = true) {
            _align.centerText("Races are what ethnic group you belong to at birth. All races have something thier naturally good or bad at",fastType);
            _align.centerText("Use WS or the up/down arrow keys to scroll throught the different races", fastType);
            Console.WriteLine(_align.divider(Console.WindowWidth));
            _align.boxContent(races, 5,10);
            listen();
        }

        private static loadRaceDetails() {

        }

        private static void listen() {
            bool exit = false;
            while (exit == false) {
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow) {
                    if ((races.currentChoice - 1) < 0)
                    {
                        races.currentChoice = 0;
                    }
                    else {
                        races.currentChoice = (races.currentChoice - 1);
                    }
                    Console.Clear();
                    loadPage(false);
                } else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow) {
                    if ((races.currentChoice + 1) >= races.content.Count)
                    {
                        races.currentChoice = (races.content.Count - 1);
                        
                    }
                    else {
                        races.currentChoice = (races.currentChoice + 1);
                    }
                    Console.Clear();
                    loadPage(false);
                }
            }
        }
        private static ContentBox getRaces() {
            ContentBox result = new ContentBox();
            List<string> races = new List<string>();

            result.title = "Races";
            result.content = command.returnCommandList(new string[] { "Alderan", "Brutaris", "Levenite", "Beholden" });
            result.desc = "This is what race you were born as. Each race has some natural additaves.";

            return result;
        }
    }
}
