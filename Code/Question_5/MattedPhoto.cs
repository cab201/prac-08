using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class MattedPhoto : Photo
    {
        private string colour;

        public MattedPhoto(double length, double width, string colour)
            : base(length, width)
        {
            this.colour = colour;
        }

        public override void DisplayPhoto()
        {
            Console.WriteLine("Matted Photo of size {0}cm x {1}cm " +
                "and colour {2}", Length, Width, colour);
        }

        public override string ToString()
        {
            return $"Matted: {base.ToString()}, {colour}";
        }
    }
}
