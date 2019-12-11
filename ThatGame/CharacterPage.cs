using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame
{
    class CharacterPage
    {

        private static TextAlignments _align = new TextAlignments();
        public static void createNewCharacter()
        {
            Console.Clear();
            _align.centerText("Welcome to the character creation. Here you will pick whatever traits your character will have for the start of the game.");
            _align.centerText("These all can be changed later in the game.");
        }
    }
}
