using System;
using System.Collections.Generic;
using System.Text;

namespace ImageResizer.AspNetCore.Models
{
   public class WatermarkImageModel
    {
        public short Key { get; set; }
        public string Url { get; set; }
        public short SizeMeasureType { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public short PositionMeasureType { get; set; }
        public float Top { get; set; }
        public float Right { get; set; }
        public float Bottom { get; set; }
        public float Left { get; set; }
    }
}
