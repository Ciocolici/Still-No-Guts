using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Still_No_Guts.Characters;

internal class Character : DefaultCharacter
{
    public Character(int selfEsteem, string name, int age) : base(name, age)
    {
        SelfEsteem = selfEsteem;
    }

    public int SelfEsteem { get; set; }
}
