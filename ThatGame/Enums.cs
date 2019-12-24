using System;
using System.Collections.Generic;
using System.Text;
using ThatGame.Objects.Races;

namespace ThatGame
{
    class Enums
    {
        enum Races {
            ALDERAN = 0,
            BRUTARIS = 1,
            LEVENITE = 2,
            BEHOLDEN = 3
        }

        enum Skills {
            MECHANICAL = 0, 
            MAGIC = 1, 
            SCIENCE = 2, 
            ARCANOLOGY = 3,
            COMBAT = 4, 
            SPEECH = 5, 
            CHEMISTY = 6, 
            BLACKSMITHING = 7, 
            ENGINEERING = 8
        }

        enum Traits {
            STRENGTH = 0, 
            INTELLIGENCE = 1, 
            CHARISMA = 2, 
            INITIATIVE = 3, 
            AGILITY = 4, 
            CONSTITUTION = 5
        }

        enum Past {
            TROOPER = 0, 
            ENGINEER = 1, 
            WIZARD = 2, 
            SCIENTIST = 3, 
            ARCANOLOGIST = 4, 
            POLITICIAN = 5, 
            WEAPONSMITH = 6, 
            FARMHAND = 7, 
            CITIZEN = 8
        }

        enum Vice {
            LIAR = 0, 
            GREEDY = 1, 
            ANGRY = 2, 
            NARCISSTIC = 3, 
            MALEVOLENT = 4
        }

        enum Virtue {
            HONORABLE = 0, 
            LOVING = 1, 
            BENEVOLENT = 2, 
            VIRTUOUS = 3, 
            COURAGOUS = 4
        }
    }
}
