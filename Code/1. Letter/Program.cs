using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDate today = new MyDate(26, 4, 2023);
            Letter letter = new Letter("Dan", today);

            string dateStr = $"{today.Day}/{today.Month}/{today.Year}";
            Console.WriteLine("Sending a letter to" +
                " {0} on {1}", letter.Name, dateStr);

            CertifiedLetter certLetter = new CertifiedLetter("Dan", today, 260423);
            dateStr = $"{today.Day}/{today.Month}/{today.Year}";
            Console.WriteLine("Sending a letter to" +
                " {0} on {1} with tracking number {2}", 
                certLetter.Name, dateStr, certLetter.TrackingNumber);
        }
    }
}
