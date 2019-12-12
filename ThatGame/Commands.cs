using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame
{
    class Commands
    {
        TextAlignments _align = new TextAlignments();

        //For printing out any pages specific command list
        public int printCommands(ContentBox commands, bool slowType = true, int posX = 80, int posY = 10, ConsoleColor color = ConsoleColor.White) {
            Console.WriteLine("\n");

            if (commands.currentChoice < 0) {
                commands.currentChoice = 0;
            } else if (commands.currentChoice >= commands.content.Count) {
                commands.currentChoice = (commands.content.Count - 1);
            }
            _align.boxContent(commands,posX, posY, color);

            return commands.currentChoice;
        }

        //Used to make the content box object for the page commands subject to future removal
        public ContentBox SetCommandBox(List<string> commands, string title = null, int currentCmd = 0) {
            ContentBox box = new ContentBox();

            box.title = title;
            box.content = commands;
            box.currentChoice = currentCmd;

            return box;
        }

        //Used for automatically setting a list object. Similar to setting an array list 
        public List<string> returnCommandList(string[] commands) {
            List<string> returnValue = new List<string>();

            for (int i = 0; i < commands.Length; i++) {
                returnValue.Add(commands[i]);
            }

            return returnValue;
        }
    }
}
