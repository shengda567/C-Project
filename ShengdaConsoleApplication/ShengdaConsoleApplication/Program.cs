using System;

namespace ShengdaConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enhance the application to prompt the user for their name and display it along with the date and time
            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //var date = DateTime.Now;
            //Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {date:d} at {date:t}!");
            //Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            //Console.ReadKey(true);

            Console.WriteLine("Here is executing the PersonInfo class");
            PersonInfo pi = new PersonInfo("Shengda", "Zhang");
            pi.PresentToScreen();
            pi.WriteToTextFile();
            pi.ReadTextToScreen();

            Console.WriteLine("Here the PersonInfo class is done ");
        }
    }
}
