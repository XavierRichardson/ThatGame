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
            _align.centerText("Press the H key for help or info about this page and I for possible information on the specific trait list", firstRun);
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
                } else if (key == ConsoleKey.H) {
                    //Show the help page
                    _align.textBox(Options[activeBox].desc, 35,35, 80);
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

            Sex.desc = "This is what your character was born as when it comees to biological sex. This can change what items will work for you. ie) Armors";
            Gender.desc = "This dictates what pronoun is used in the game and what gender you identify as.";
            Race.desc = "This is what race you were born as. Each race has some natural additaves.";
            Skills.desc = "This is what your good at and what your able to do. Higher skill levels means its easier to do specific actions.";
            Past.desc = "This is how you grew up and what you went through as a child and teen. This effects some of your skills and even your mentality.";
            Mentality.desc = "How you see others and the world around you. Different mentalities will effect the options available to you.";
            Vice.desc = "This is a singular problem or trouble you may have that holds you back. Mostly provided for interesting play";
            Virtue.desc = "This is a singular good thing about you that helps you only slighly in a few ways. Mostly provided for interesting play";


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
