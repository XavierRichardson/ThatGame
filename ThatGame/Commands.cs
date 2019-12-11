using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame
{
    class Commands
    {
        TextAlignments _align = new TextAlignments();

        public int printCommands(List<string> commands, int currCommand = 0, bool slowType = true) {
            Console.WriteLine("\n");

            if (currCommand < 0) {
                currCommand = 0;
            } else if (currCommand >= commands.Count) {
                currCommand = (commands.Count - 1);
            }
            _align.boxContent(commands,80, 10,false,currCommand);

            return currCommand;
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
