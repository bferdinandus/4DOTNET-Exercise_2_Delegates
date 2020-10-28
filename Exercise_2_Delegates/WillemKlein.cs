using System;

namespace Exercise_2_Delegates
{
    public class WillemKlein
    {
        public void RekenUit(CalculateTask task, int a, int b)
        {
            Console.WriteLine("Willem Klein gaat nu rekenen....");

            int result = task(a, b);

            Console.WriteLine($"Willem Klein roept: Het antwoord is: {result}");
        }
    }
}