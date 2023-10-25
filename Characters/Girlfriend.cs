using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Still_No_Guts.Characters;

internal class Girlfriend : DefaultCharacter
{
    public Girlfriend(bool smexy, string name, int age) : base(name, age)
    {
        Smexy = smexy;
    }

    public bool Smexy { get; set; }
}
