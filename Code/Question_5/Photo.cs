using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class Photo
    {
        public double Length { get; }
        public double Width { get; }

        public Photo(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public virtual void DisplayPhoto()
        {
            Console.WriteLine("Photo of size {0}cm x {1}cm",
                Length, Width);
        }

        public override string ToString()
        {
            return $"{Length}cm x {Width}cm";
        }
    }
}
