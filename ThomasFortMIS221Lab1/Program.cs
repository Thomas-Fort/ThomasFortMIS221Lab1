using System;

namespace ThomasFortMIS221Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightInches = GetHeightInches();
            double stepsTaken = GetStepsTaken();
            const double STRIDE_LENGTH = .413;
            const double STRIDE_FEET = 12;
            const double MILE_LENGTH = 5280;
            MilesWalkedTotal(heightInches, STRIDE_LENGTH, STRIDE_FEET, stepsTaken, MILE_LENGTH);

        }


        static double GetHeightInches()
        {
            Console.WriteLine("What is your height in inches?");
            Double heightInches = Double.Parse(Console.ReadLine());
            return heightInches;
        }

        static double GetStepsTaken()
        {
            Console.WriteLine("How many steps have you taken today?");
            Double stepsTaken = Double.Parse(Console.ReadLine());
            return stepsTaken;
        }


        static void MilesWalkedTotal(double heightInches, double STRIDE_LENGTH, double STRIDE_FEET, double stepsTaken, double MILE_LENGTH)
        {
            double stride = heightInches * STRIDE_LENGTH;
            double strideFeet = stride / STRIDE_FEET;
            double totalFeetWalked = strideFeet * stepsTaken;
            double milesWalked = totalFeetWalked / MILE_LENGTH;
            Console.WriteLine("You Walked " + milesWalked + " miles");
        }
    }
}
