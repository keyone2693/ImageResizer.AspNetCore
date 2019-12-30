using System;
using System.Collections.Generic;
using System.Text;

namespace ImageResizer.AspNetCore.Helpers
{
    struct ResizeParams
    {
        public bool hasParams;
        public int w;
        public int h;
        public bool autorotate;
        public int quality; // 0 - 100
        public string format; // png, jpg, jpeg
        public string mode; // pad, max, crop, stretch
        public short wmtext;
        public short wmimage;

        public static string[] modes = new string[] { "pad", "max", "crop", "stretch" };

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"w: {w}, ");
            sb.Append($"h: {h}, ");
            sb.Append($"autorotate: {autorotate}, ");
            sb.Append($"quality: {quality}, ");
            sb.Append($"format: {format}, ");
            sb.Append($"mode: {mode}, ");
            sb.Append($"wmtext: {wmtext}, ");
            sb.Append($"wmimage: {wmimage}");

            return sb.ToString();
        }
    }
}
