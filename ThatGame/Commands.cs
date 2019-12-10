using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame
{
    class Commands
    {
        TextAlignments _align = new TextAlignments();

        public int printCommands(List<string> commands, int position = 0, bool slowType = true) {
            Console.WriteLine("\n");

            if (position < 0) {
                position = 0;
            } else if (position >= commands.Count) {
                position = (commands.Count - 1);
            }

            for (int i = 0; i < commands.Count; i++) {
                _align.newLine();
                if (i == position)
                {
                    _align.centerText(commands[i], ConsoleColor.Green, slowType);
                }
                else {
                    _align.centerText(commands[i], slowType);
                }
                
            }

            return position;
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
