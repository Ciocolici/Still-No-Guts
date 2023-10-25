using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Still_No_Guts.Characters;

internal class Friend : DefaultCharacter
{
    public Friend(bool friendship, string name, int age) : base(name, age)
    {
        Friendship = friendship;
    }

    public bool Friendship { get; set; }
}
