using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class FramedPhoto : Photo
    {
        private string material;
        private string style;
        public FramedPhoto(double length, double width,
            string material, string style)
            : base(length, width)
        {
            this.material = material;
            this.style = style;
        }

        public override void DisplayPhoto()
        {
            Console.WriteLine("FramedPhoto of size {0}cm x {1}cm" +
                " using {2}, and has a {3} style",
                Length, Width, material, style);
        }

        public override string ToString()
        {
            return $"Framed: {base.ToString()}, {material}, {style} style";
        }

        public override bool Equals(object? obj)
        {
            // Check if the two has the same type
            if (obj is not FramedPhoto) return false;
            FramedPhoto other = obj as FramedPhoto;
            return Length == other.Length && Width == other.Width
                && material == other.material && style == other.style;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Length, Width, material, style);
        }
    }
}
