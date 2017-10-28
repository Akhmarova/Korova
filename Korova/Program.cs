using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korova
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CowCounter(45));
            Console.ReadLine();
        }
            public static string CowCounter(int n)
            
        {
            string input = Console.ReadLine();
            Int32.TryParse(input, out n);
            int lastDigit = n % 10;
            int lastTwoDigits = n % 100;
            string result = string.Empty;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 19)
                result = "коров";

            else if (lastDigit == 1)
                result = "корова";
            else if (lastDigit >= 2 && lastDigit <= 4)
                result = "коровы";
            else if (lastDigit == 0 || lastDigit >= 5 && lastDigit <= 9)
                result = "коров";

            return string.Format("{0} {1}", n, result);

        }

    }


}
        
