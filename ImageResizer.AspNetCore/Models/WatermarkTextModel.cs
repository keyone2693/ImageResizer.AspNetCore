using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageResizer.AspNetCore.Models
{
    public class WatermarkTextModel
    {
        public short Key { get; set; }
        public string Value { get; set; }
        public short PositionMeasureType { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public bool IsVerticalText { get; set; }
        public string Color { get; set; }

        public short Type { get; set; }
        public float StrokeWidth { get; set; }

        public short Quality { get; set; }
        public float TextSize { get; set; }
        public short TextAlign { get; set; }
        public float TextSkewX { get; set; }
        public bool IsAntialias { get; set; }
    }

}
