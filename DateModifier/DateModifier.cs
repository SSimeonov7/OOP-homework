using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProblemDateModifier
{
    public class DateModifier
    {
        public static void DatesDifference(string date1, string date2)
        {
            int[] d1 = date1.Split().Select(int.Parse).ToArray();
            int[] d2 = date2.Split().Select(int.Parse).ToArray();

            DateTime firstDate = new DateTime(d1[0], d1[1], d1[2]);
            DateTime secondDate = new DateTime(d2[0], d2[1], d2[2]);

            Console.WriteLine((int)Math.Abs((firstDate - secondDate).TotalDays)); 
        }
    }
}
