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
            newLine();
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
            newLine();
        }

        //Used to make content boxes on the screen
        public void boxContent(List<string>content, int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            int lineWidth = (getLargestItem(content) + 4);

            for (int i = 0; i < 5; i++) {
                if (i == 0 || i == 4) {
                    Console.WriteLine(borderLine(lineWidth));
                } else if (i == 1 || i == 3) {
                    Console.SetCursorPosition(posX, (Console.CursorTop));
                    Console.WriteLine(paddingLine(lineWidth));
                }
                else {
                    foreach (string temp in content) {
                        Console.SetCursorPosition(posX, (Console.CursorTop));
                        if (content[0] == temp)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(conentLine(lineWidth, temp));
                            Console.ResetColor();
                            Console.WriteLine(paddingLine(lineWidth));
                            
                            
                        }
                        else {
                            Console.WriteLine(conentLine(lineWidth, temp));
                        }
                        
                    }
                }
                
            }
        }

        private string conentLine(int width, string input) {
            string result = "";
            string padding = "";
            int paddingWidth = ((width - input.Length) - 2)/2;

            for (int i = 0; i < paddingWidth; i++) {
                padding = padding + " ";
            }

            result = "*" + padding + input + padding + "*";

            if (result.Length > width) {
                result = "*" + padding.Substring(0) + input + padding + "*";
            } else if (result.Length < width) {
                result = "* " + padding + input + padding + "*";
            }

            return result;
        }

        private string paddingLine(int lineWidth) {
            string result = "";

            for (int i = 0; i < lineWidth; i++) {
                if (i == 0 || i == (lineWidth - 1))
                {
                    result = result + "*";
                }
                else {
                    result = result + " ";
                }
            }

            return result;
        }

        private string borderLine(int width) {
            string returnString = "";

            for (int i = 0; i < width; i++) {
                returnString = returnString + "*";
            }

            return returnString;
        }

        

        private int getLargestItem(List<string> input) {
            int returnInt = 0;

            foreach (string item in input) {
                if (item.Length > returnInt) {
                    returnInt = item.Length;
                }
            }

            return returnInt;
        }
    }
}
