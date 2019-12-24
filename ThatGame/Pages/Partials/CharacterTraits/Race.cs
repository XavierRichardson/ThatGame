using System;
using System.Collections.Generic;
using System.Text;
using ThatGame.Objects;
using ThatGame.Objects.Races;

namespace ThatGame.Pages.Partials.CharacterTraits
{
    class Race
    {
        private static TextAlignments _align = new TextAlignments();
        private static Commands command = new Commands();
        private static ContentBox races = getRaces();
        private  Enums enums = new Enums();
        public static void loadPage(bool fastType = true) {
            _align.centerText("Races are what ethnic group you belong to at birth. All races have something thier naturally good or bad at",fastType);
            _align.centerText("Use WS or the up/down arrow keys to scroll throught the different races", fastType);
            Console.WriteLine(_align.divider(Console.WindowWidth));
            _align.boxContent(races, 5,10);
            loadRaceDetails();
            listen();
        }

        private static void loadRaceDetails() {
            string chosenRace = races.content[races.currentChoice].ToUpper();
            TraitBase race = null;
            switch (chosenRace) {
                case "ALDERAN":
                    race = new Alderan();
                    break;
            }
            if (race != null) {
                _align.textBox(race.desc, 25, 10, 40);
                _align.textBox(race.misc, 25,20,40);
                ContentBox[] boxes = loadRaceMods(race);
                _align.boxContent(boxes[0], 73, 10);
                _align.boxContent(boxes[1], 100,10);
            }
            

        }

        private static ContentBox[] loadRaceMods(TraitBase race) {
            ContentBox[] result = new ContentBox[2];
            
            result[1] = new ContentBox();
            result[0] = new ContentBox();

            result[0].title = "Stat Mods";
            result[0].content = new List<string>();
            result[0].currentChoice = -1;

            result[1].title = "Trait Mods";
            result[1].content = new List<string>();
            result[1].currentChoice = -1;

            foreach (string stat in race.skillMods) {
                string[] _stat = stat.Split(":");
                string[] stats = Enum.GetNames(typeof(Enums.Skills));
                for (int i = 0; i < stats.Length; i++) {
                    if (_stat[0] == i.ToString()) {
                        result[0].content.Add(stats[i] + " : " + _stat[1]);
                    }
                }
            }

            foreach (string trait in race.statMods) {
                string[] _trait = trait.Split(":");
                string[] traits = Enum.GetNames(typeof(Enums.Traits));
                for (int x = 0; x < traits.Length; x++ ) {
                    if (_trait[0] == x.ToString()) {
                        result[1].content.Add(traits[x] + " : " + _trait[1]);
                    }
                }
            }


            return result;
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
