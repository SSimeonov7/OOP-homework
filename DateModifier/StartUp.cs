using System;

namespace ProblemDateModifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
         
            string firstInputDate = Console.ReadLine();
            string secondInputDate = Console.ReadLine();

            DateModifier.DatesDifference(firstInputDate, secondInputDate);
        }
    }
}
