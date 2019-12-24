using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame.Objects.Races
{
    class Brutaris:TraitBase
    {
        public Brutaris() {
            name = "Brutaris";
            desc = "Named after thier brutal nature these are a war cult. Born and bred to be the most dangerous warriors what they lack in human nature they make up for in combat prowless.";
            skillMods = new string[] { "4:5","5:-5","7:5","8:-5" };
            statMods = new string[] { "0:1","1:-1","2:-1","4:1" };
            misc = "Brutarians are fearless warrariors who for 3 turns in a crazed bloodlust can take up to 1/2 taken damage and do 2x more damage";
        }

        public void test() {
            //Nopes
        }
    }
}
