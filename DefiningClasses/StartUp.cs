using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.GetMemberBigerOf30(person);
            }

            foreach (var m in family.Members.OrderBy(x => x.Name))
            {
                Console.WriteLine("{0} - {1}",m.Name, m.Age);
            }
            //Person oldestPerson = family.GetOldestMember();
            //Console.WriteLine("{0} {1}",oldestPerson.Name, oldestPerson.Age);


            


        }
    }
}
