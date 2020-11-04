using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek days = new DaysOfWeek();
            foreach(string day in days)
            {
                Console.Write(day + " ");
            }

            Console.ReadLine();
        }

        private class DaysOfWeek : IEnumerable
        {
            private string[] days =
                {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
            public IEnumerator GetEnumerator()
            {
                for(int index = 0; index < days.Length; index++)
                {
                    yield return days[index];
                }
            }
        }
    }
}
