using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThatGame
{
    class TextAlignments
    {
        public void newLine() {
            Console.WriteLine("\n");
        }

        //prints and centers whatever you pass in
        public void centerText(string input, bool slowType = true) {
            int stringLength = (int)Math.Floor((double)(input.Length/2));
            int windowLength = (int)Math.Floor((double)(Console.WindowWidth/2));
            char[] line = input.ToCharArray();

            Console.SetCursorPosition((windowLength - stringLength), Console.CursorTop);
            if (slowType == true)
            {
                foreach (char c in line)
                {
                    Console.Write(c);
                    Thread.Sleep(50);
                }
            }
            else {
                Console.WriteLine(input);
            }
            
        }

        //Overload for adding color to the text
        public void  centerText(string input, System.ConsoleColor color, bool slowType = true) {
            int stringLength = (input.Length / 2);
            int windowLength = (Console.WindowWidth / 2);
            char[] line = input.ToCharArray();

            Console.ForegroundColor = color;

            Console.SetCursorPosition((windowLength - stringLength), Console.CursorTop);

            if (slowType == true)
            {
                foreach (char c in line)
                {
                    Console.Write(c);
                    Thread.Sleep(50);
                }
            }
            else {
                Console.Write(input);
            }

            Console.ResetColor();
        }
    }
}
