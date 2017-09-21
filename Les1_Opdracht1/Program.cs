using System;

namespace Les1_Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 1");

            string timeOne = new Time(10, 05).ToString();
            Console.WriteLine(timeOne);

            string timeTwo = new Time(0, 45).ToString();
            Console.WriteLine(timeTwo);

            string timeThree = new Time(12, 15).ToString();
            Console.WriteLine(timeThree);

            Console.ReadLine(); //Prevents the console window from closing.
        }

        public struct Time
        {
            private readonly int minutes;
            public Time(int hours, int minutes)
            {
                this.minutes = hours * 60 + minutes;
            }

            public override string ToString()
            {
                return minutes.ToString();
            }


        }
    }
}
