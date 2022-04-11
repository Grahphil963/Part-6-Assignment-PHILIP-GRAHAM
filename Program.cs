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
            //Prompter();


            //Percent Passsing 

            Double testScoreAbovePassing=0;
            Double testScoreNumber=0;
            Double testScores=0;


            
            
                do
                {
                    Console.WriteLine("Please enter a test score or a negative value when done:");
                    while (!Double.TryParse(Console.ReadLine(), out testScoreNumber))
                        Console.WriteLine("Please enter a number");
                    if (testScoreNumber >= 70)
                    testScoreAbovePassing = testScoreAbovePassing + 1;

                    
                    testScores = testScores + 1;
                } while (testScoreNumber >= 0);
            Console.WriteLine($"You entered {testScores} and you had {testScoreAbovePassing} above passing so {(testScoreAbovePassing)*100}% of your tests were passing grades");
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
    }
}
