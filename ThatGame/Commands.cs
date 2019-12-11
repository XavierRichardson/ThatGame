using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame
{
    class Commands
    {
        TextAlignments _align = new TextAlignments();

        public int printCommands(ContentBox commands, bool slowType = true) {
            Console.WriteLine("\n");

            if (commands.currentChoice < 0) {
                commands.currentChoice = 0;
            } else if (commands.currentChoice >= commands.content.Count) {
                commands.currentChoice = (commands.content.Count - 1);
            }
            _align.boxContent(commands,80, 10);

            return commands.currentChoice;
        }

        public ContentBox SetCommandBox(List<string> commands, string title = null, int currentCmd = 0) {
            ContentBox box = new ContentBox();

            box.title = title;
            box.content = commands;
            box.currentChoice = currentCmd;

            return box;
        }

        public List<string> returnCommandList(string[] commands) {
            List<string> returnValue = new List<string>();

            for (int i = 0; i < commands.Length; i++) {
                returnValue.Add(commands[i]);
            }

            return returnValue;
        }
    }
}
