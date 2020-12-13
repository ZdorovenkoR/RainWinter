using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool seathon;
            bool temp;
            Console.WriteLine("Введите номер месяца");
            int month = Convert.ToInt32(Console.ReadLine());
                if (month == 1|| month == 2|| month == 12)
                seathon = true;
                else
                    return;
            Console.WriteLine("Введите максимальную температуру");
            int maxT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минимальную температуру");
            int minT = Convert.ToInt32(Console.ReadLine());
            int aveT = (maxT + minT)/2;
            if (aveT > 0)
                temp = true;
            else
                return;
            if (seathon == true && temp == true)
                Console.WriteLine("Дождливая зима");
            else
                return;
        }
    }
}
