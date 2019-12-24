using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame.Objects
{
    class TraitBase
    {
        public string name { get; set; }
        public string desc { get; set; }
        public string[] skillMods { get; set; }
        public string[] statMods { get; set; }

        public string misc { get; set; }
    }
}
