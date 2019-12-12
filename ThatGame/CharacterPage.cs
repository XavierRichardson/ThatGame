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
        private static List<ContentBox> Options = getOptions();

        public static void createNewCharacter(bool firstRun = true)
        {
            Console.Clear();

            _align.centerText("Welcome to the character creation. Here you will pick whatever traits your character will have for the start of the game.", firstRun);
            _align.centerText("These all can be changed later in the game.", firstRun);
            _align.centerText("Use WASD or the arrow keys to select the character trait/trait box press enter when finished with your choices. Press ESC to return to the title page", firstRun);
            //Start the grid system for character creation
            grid.buildBoxList(Options, activeBox);
            listen();
        }

        private static void listen() {
            bool exit = false;
            int count = Options[activeBox].content.Count;
            while (exit == false) {
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow) {
                    if ((Options[activeBox].currentChoice - 1) < 0)
                    {
                        Options[activeBox].currentChoice = 0;
                        activeBox = 0;
                    }
                    else
                    {
                        Options[activeBox].currentChoice = (Options[activeBox].currentChoice - 1);
                    }
                    createNewCharacter(false);
                } else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow) {
                    if ((Options[activeBox].currentChoice + 1) > count)
                    {
                        Options[activeBox].currentChoice = count;
                    }
                    else {
                        Options[activeBox].currentChoice = (Options[activeBox].currentChoice + 1);
                    }
                    createNewCharacter(false);
                } else if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow) {
                    if ((activeBox - 1) < 0)
                    {
                        activeBox = 0;
                    }
                    else {
                        activeBox = (activeBox - 1);
                    }
                    createNewCharacter(false);
                } else if (key == ConsoleKey.D || key == ConsoleKey.RightArrow) {
                    if ((activeBox + 1) > (Options.Count - 1)) {
                        activeBox = Options.Count - 1;
                    }
                    else {
                        activeBox = (activeBox + 1);
                    }
                    createNewCharacter(false);
                } else if (key == ConsoleKey.Escape) {
                    Console.Clear();
                    Start.BeginGame(false);
                    exit = true;
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
            ContentBox Mentality = new ContentBox();
            ContentBox Vice = new ContentBox();
            ContentBox Virtue = new ContentBox();

            Sex.title = "Sex";
            Gender.title = "Gender";
            Race.title = "Race";
            Skills.title = "Skills";
            Past.title = "Past";
            Mentality.title = "Mentality";
            Vice.title = "Vice";
            Virtue.title = "Virtue";

            Sex.content = commands.returnCommandList(new string[] { "Male", "Female", "Other" });
            Gender.content = commands.returnCommandList(new string[] { "Male", "Female", "Other" });
            Race.content = commands.returnCommandList(new string[] {"Alderan", "Brutaris","Levenite","Beholden" });
            Skills.content = commands.returnCommandList(new string[] { "Mechanical", "Magic", "Science", "Arcanology", "Combat", "Speech", "Chemistry", "Blacksmithing", "Engineering", "None"});
            Past.content = commands.returnCommandList(new string[] { "Trooper", "Engineer", "Wizard", "Scientist", "Arcanologist", "Politician", "Weapons Builder", "Farmhand", "Citizen"});
            Mentality.content = commands.returnCommandList(new string[] { "Social", "Antisocial", "Leader", "Follower", "Learning","Agressive","Passive"});
            Vice.content = commands.returnCommandList(new string[] { "Liar", "Greedy", "Angry", "Narcisstic", "Weak Minded"});
            Virtue.content = commands.returnCommandList(new string[] {"Honorable", "Loving", "Childish", "Strong Minded", "Virtuous" });


            result.Add(Sex);
            result.Add(Gender);
            result.Add(Race);
            result.Add(Skills);
            result.Add(Past);
            result.Add(Mentality);
            result.Add(Vice);
            result.Add(Virtue);

            return result;
        }
    }
}
