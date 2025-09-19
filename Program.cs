namespace Topic_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int person1, person2, person3;

            Console.Write("Please enter the age of the first person:");
            while (!Int32.TryParse(Console.ReadLine(), out person1))
            {
                Console.Write("That is an invalid option. Try Again:");
            }
            Console.Write("Please enter the age of the second person:");
            while (!Int32.TryParse(Console.ReadLine(), out person2))
            {
                Console.Write("That is an invalid option. Try Again:");
            }
            Console.Write("Please enter the age of the third person:");
            while (!Int32.TryParse(Console.ReadLine(), out person3))
            {
                Console.Write("That is an invalid option. Try Again:");
            }
            if (person1 > person2)
            {
                Console.WriteLine("Person 1 is older than person 2");
            }
            if (person3 < person1)
            {
                Console.WriteLine("Person 3 is younger than person 1");
            }
            if (person2 == person3)
            {
                Console.WriteLine("Person 2 and person 3 are the same age");
            }
            Console.WriteLine();



            if (person2 < person3 && person2 < person1)
            {
                Console.WriteLine("Person 2 is the youngest");
            }
            if (person1 > person3 && person1 > person2)
            {
                Console.WriteLine("Person 1 is the oldest");
            }
            Console.WriteLine();



            if (person2 == person3 || person2 == person1)
            {
                Console.WriteLine("Person 2 is the same age as another person");
            }
            if (person1 != person2 || person1 != person3)
            {
                Console.WriteLine("Person 1 is not the same age as anyone else");
            }

        }
    }
}
