using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter
{
    internal class CertifiedLetter : Letter
    {
        public int TrackingNumber { get; }

        public CertifiedLetter(string name, MyDate date, int trackingNumber) 
            : base(name, date) // Call the parent constructor
        {
            Console.WriteLine("Adding a tracking number");
        }
    }
}
