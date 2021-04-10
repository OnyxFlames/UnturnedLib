using System;
using System.Collections.Generic;
using System.Text;

namespace UnturnedLib.Weapon
{
    public enum FireMode
    {
        Safety =    1 << 0,
        Semi =      1 << 1,
        Burst =     1 << 2,
        Auto =      1 << 3,
    }
}
