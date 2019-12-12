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
                    Thread.Sleep(25);
                }
            }
            else {
                Console.Write(input);
            }

            Console.ResetColor();
            newLine();
        }

        //Used to make content boxes on the screen
        public void boxContent(ContentBox content, int posX, int posY, ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            int largestItem = getLargestItem(content.content);
            int lineWidth = 0;
            if (content.title.Length > largestItem)
            {
                lineWidth = (content.title.Length + 4);
            }
            else {
                lineWidth = (largestItem + 4);
            }
            //int lineWidth = ( + 4);

            for (int i = 0; i < 3; i++) {
                if (i == 0)
                {
                    Console.WriteLine(borderLine(lineWidth));
                    Console.SetCursorPosition(posX, Console.CursorTop);
                    
                    if (content.title != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(contentLine(lineWidth, content.title));
                        Console.SetCursorPosition(posX, Console.CursorTop);
                        Console.ForegroundColor = color;
                        Console.WriteLine(divider(lineWidth));
                        Console.SetCursorPosition(posX, Console.CursorTop);
                    }
                    else {
                        Console.WriteLine(paddingLine(lineWidth));
                        Console.SetCursorPosition(posX, Console.CursorTop);
                    }
                }
                else if (i == 2)
                {
                    Console.WriteLine(paddingLine(lineWidth));
                    Console.SetCursorPosition(posX, Console.CursorTop);
                    Console.WriteLine(borderLine(lineWidth));
                }
                else {
                    foreach (string item in content.content) {
                        if (content.currentChoice == content.content.IndexOf(item))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(contentLine(lineWidth, item));
                            Console.ForegroundColor = color;
                            Console.SetCursorPosition(posX, Console.CursorTop);
                            ;
                        }
                        else {
                            Console.WriteLine(contentLine(lineWidth, item));
                            Console.SetCursorPosition(posX, Console.CursorTop);
                        }
                        
                    }
                }
            }
            Console.ResetColor();
        }

        private string contentLine(int width, string input) {
            string result = "";
            string padding = "";
            int paddingWidth = ((width - input.Length) - 2)/2;

            for (int i = 0; i < paddingWidth; i++) {
                padding = padding + " ";
            }

            result = "*" + padding + input + padding + "*";

            while (result.Length != width) {
                if (result.Length > width)
                {
                    
                    result = "*" + padding.Substring(0) + input + padding + "*";
                    if (result.Length > width) {
                        result = "*" + padding.Substring(0) + input + padding.Substring(0) + "*";
                    }
                }
                else if (result.Length < width)
                {
                    result = "* " + padding + input + padding + "*";
                    if (result.Length < width) {
                        result = "* " + padding + input + padding + " *";
                    }
                }
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

        private string divider(int lineWidth) {
            string result = "";

            for (int i = 0; i < lineWidth; i++) {
                if (i == 0 || i == (lineWidth - 1))
                {
                    result = result + "*";
                }
                else {
                    result = result + "-";
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
