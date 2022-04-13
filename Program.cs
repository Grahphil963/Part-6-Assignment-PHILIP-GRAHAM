using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_Assignment_PHILIP_GRAHAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Prompter();


            PercentPassing(); 

            OddSum();
            

            //Random Numbers
            Random generator = new Random();
            int numberMin;
            int  numberMax;
            Double randomNumber;
            Console.WriteLine("Please enter a Minimum number");
            while (!Int32.TryParse(Console.ReadLine(), out numberMin))
                Console.WriteLine("Enter a number");
            Console.WriteLine("Please enter a maximum number");
            while (!Int32.TryParse(Console.ReadLine(), out numberMax))
                Console.WriteLine("Enter a number");
            for (double i =1; i<= 25; i ++) 
            {
                Console.WriteLine($"{generator.Next(numberMin, numberMax+1)}");
            }

            Console.ReadLine();







            
            




         
        }
        public static void Prompter()
        {
            double minNumber;
            double maxNumber;
            double numberInput;
            Console.WriteLine("Please enter a minimum number");
            while (!Double.TryParse(Console.ReadLine(), out minNumber))
                Console.WriteLine("Just follow the instructions man enter a number ");
            Console.WriteLine("Please enter a maximum value");
            do
            {
                while (!Double.TryParse(Console.ReadLine(), out maxNumber))
                    Console.WriteLine("Do you not understand?? just enter a maximum number");
                if (maxNumber < minNumber)

                    Console.WriteLine("The maximum number needs to be more than the minimum");
            } while (maxNumber <= minNumber);




            do
            {
                Console.WriteLine($"Please Enter a number between {minNumber} and {maxNumber}  ");
                while (!Double.TryParse(Console.ReadLine(), out numberInput)) ;


            } while (numberInput <= minNumber || numberInput >= maxNumber);
            Console.WriteLine("Well done sir");
            Console.ReadLine();
        }
        public static void PercentPassing()
        {
            Double testScoreAbovePassing = 0;
            Double testScoreNumber = 0;
            Double testScores = 0;

            do
            {
                Console.WriteLine("Please enter a test score or a negative value when done:");
                while (!Double.TryParse(Console.ReadLine(), out testScoreNumber))
                    Console.WriteLine("Please enter a number");
                if (testScoreNumber >= 70)
                    testScoreAbovePassing = testScoreAbovePassing + 1;
                testScores++;
            } while (testScoreNumber >= 0);

            testScores--;
            Console.WriteLine($"You entered {testScores} Scores and you had {testScoreAbovePassing} scores above passing so {(testScoreAbovePassing / testScores) * 100}% of your tests were passing grades");
            Console.ReadLine();
        }
        public static void OddSum()
        {
            int numberInput;
            int sum = 0;
            int DifferentNum = 1;
            Console.WriteLine("Please enter a number");

            while (!int.TryParse(Console.ReadLine(), out numberInput))
                Console.WriteLine("Enter a whole number");

            do
            {
                sum = sum + DifferentNum;
                DifferentNum = DifferentNum + 2;

            } while (DifferentNum <= numberInput);
            Console.WriteLine($"The sum of all the odd numbers is {sum}");
            Console.ReadLine();
        }

    }
}
