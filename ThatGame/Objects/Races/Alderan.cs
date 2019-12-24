using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame.Objects.Races
{
    class Alderan:TraitBase
    {
        public Alderan() {
            name = "Alderan";
            desc = "The alderan people are often very caring people and opposed to violence. Very charismatic and versed in the magical arts they are often looked down apon for their non-agressive nature.";
            skillMods = new string[] { "5:5","1:5","4:-5","7:-5" };
            statMods = new string[] { "0:-1","2:1","1:1","0:-1" };
            misc = "The alderan once a day can use the kind nature to add a +1 to thier Charisma. This only last for the next 3 interactions that require a speech check or until the day ends";
        }
    }
}
