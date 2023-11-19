namespace ConsoleApp3._7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:  ");
            string Name = Console.ReadLine();

            Console.Write("Enter your age:  ");
            var Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is {0}, and your age is {1}", Name, Age);

            Console.Write("Enter your birthdate: ");
            var Bd = Console.ReadLine();
            Console.WriteLine("Your birthdate is {0}", Bd);

            Console.WriteLine("What is your favorite day of week?");
            DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day of week is {0}", day);

            DayOfWeek day1 = (DayOfWeek) 1;
            Console.WriteLine( day1 );


            //Console.ReadKey();
        }
    }
}