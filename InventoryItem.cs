using System;
using System.Collections.Generic;
using System.Text;

namespace UnturnedLib
{
    // Space
    public class InventoryItem : Identifiable
    {
        // chance of degradation each use, 0 means no durability
        public short Durability { get; set; }
        public byte SlotWidth { get; set; }
        public byte SlotHeight { get; set; }
        public byte Slots { get => (byte)(SlotWidth * SlotHeight); }
        public string Description { get; set; }
    }
}
