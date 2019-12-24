using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame.Objects.Races
{
    class Brutaris:TraitBase
    {
        Brutaris() {
            name = "Brutaris";
            desc = "Named after thier brutal nature these are a war cult. Born and bred to be the most dangerous warriors what they lack in human nature they make up for in combat prowless.";
            skillMods = new string[] { "4:5","5:-5","7:5","" };
        }
    }
}
