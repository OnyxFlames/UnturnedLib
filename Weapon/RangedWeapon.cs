using System;
using System.Collections.Generic;
using System.Text;

namespace UnturnedLib.Weapon
{
    public class RangedWeapon : Weapon
    {
        public FireMode FireModes { get; set; }
        // rounds per second
        public float FireRate { get; set; }
        // maybe multiple?
        public int DefaultAttachment { get; set; }
        // list of ID's
        public List<int> BarrelAttachments { get; set; }
        public List<int> GripAttachments { get; set; }
        public List<int> SightAttachments { get; set; }
        public List<int> TacticalAttachments { get; set; }
        // magazines this weapon can hold
        public List<int> MagazineAttachments { get; set; }
    }
}
