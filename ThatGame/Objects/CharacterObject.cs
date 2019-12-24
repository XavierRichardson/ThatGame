using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame
{
    class CharacterObject
    {
        public string name;
        public int health;
        public int level;

        //Inventory of items

        string gender = "";
        int sex = 0;
        int race = 0;
        int vice = 0;
        int virtue = 0;
        int mentality = 0;
        int past = 0;
        

        //Character Stats

        //{ "Mechanical", "Magic", "Science", "Arcanology", "Combat", "Speech", "Chemistry", "Blacksmithing", "Engineering", "None"});
        public int Mechanical = 10;
        public int Magic = 10;
        public int Science = 10;
        public int Arcanology = 10;
        public int Combat = 10;
        public int Speech = 10;
        public int Chemisty = 10;
        public int Blacksmithing = 10;
        public int Engineering = 10;

        //Character traits
        public int Strengh = 5;
        public int Intelligence = 5;
        public int Charisma = 5;
        public int Initiative = 5;
        public int Agility = 5;
        public int Consititution = 5;
        
    }
}
