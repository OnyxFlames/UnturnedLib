using System;
using System.Collections.Generic;
using System.Text;

namespace UnturnedLib.Attachments
{
    public class BarrelAttachment : Attachment
    {
        public sbyte BulletRecoil { get; set; }
        public sbyte BulletSpread { get; set; }
        public sbyte BulletDrop { get; set; }
        public sbyte FiringNoise { get; set; }
        public sbyte XAxis { get; set; }
        public sbyte YAxis { get; set; }
        public bool HidesFlash { get; set; }
        public bool HidesTrails { get; set; }
    }
}
