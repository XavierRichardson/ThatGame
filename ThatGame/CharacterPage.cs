using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame
{
    class CharacterPage
    {

        private static TextAlignments _align = new TextAlignments();
        private static Commands commands = new Commands();
        private static GridSystem grid = new GridSystem();
        private static int activeBox = 0;
        private static ContentBox box = null;

        private static List<ContentBox> Options = getOptions();

        public static void createNewCharacter(bool firstRun = true)
        {
            Console.Clear();

            _align.centerText("Welcome to the character creation. Here you will pick whatever traits your character will have for the start of the game.", firstRun);
            _align.centerText("These all can be changed later in the game.", firstRun);
            //Start the grid system for character creation
            grid.buildBoxList(Options, activeBox);
        }

        private static void listen() {
            bool exit = false;
            while (exit == false) {
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.W) {

                }
            }

        }

        private static List<ContentBox> getOptions() {
            List<ContentBox> result = new List<ContentBox>();
            ContentBox Sex = new ContentBox();
            ContentBox Gender = new ContentBox();
            ContentBox Race = new ContentBox();
            ContentBox Skills = new ContentBox();
            ContentBox Past = new ContentBox();

            Sex.title = "Sex";
            Gender.title = "Gender";
            Race.title = "Race";
            Skills.title = "Skills";
            Past.title = "Past";

            Sex.content = commands.returnCommandList(new string[] { "Male", "Female", "Other" });
            Gender.content = commands.returnCommandList(new string[] { "Male", "Female", "Other" });
            Race.content = commands.returnCommandList(new string[] {"Alderan", "Brutaris","Levenite","Beholden" });
            Skills.content = commands.returnCommandList(new string[] { "Mechanical", "Magic", "Science", "Arcanology", "Combat", "Speech", "Chemistry", "Blacksmithing", "Engineering", "None"});
            Past.content = commands.returnCommandList(new string[] { "Trooper", "Engineer", "Wizard", "Scientist", "Arcanologist", "Politician", "Weapons Builder", "Farmhand", "Citizen"});

            result.Add(Sex);
            result.Add(Gender);
            result.Add(Race);
            result.Add(Skills);
            result.Add(Past);


            return result;
        }
    }
}
