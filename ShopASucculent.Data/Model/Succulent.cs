using System;
using System.Collections.Generic;
using System.Text;

namespace ShopASucculent.Data.Model
{
    public class Succulent : Product
    {
        public bool WithPot { get; set; }
        public string PlantType { get; set; }
        public string Color { get; set; }
        public int HeightInCms { get; set; }
        public int PotHeightInCms { get; set; }
        public int PotWidthInCms { get; set; }
    }
}
