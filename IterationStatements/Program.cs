namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNegToPosThousand()
        {
            // from -1000 to 1000 (increment)
            //for (int i = -1000; i < 1001; i++)

            Console.WriteLine("Print to the console all numbers 1000 through - 1000:");
            // from 1000 to -1000 (decrement)
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------------------");
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintDivisibleByThree()
        {
            Console.WriteLine("\nPrint to the console numbers 3 through 999 by 3 each time");
            for (int i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------------------");
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool CheckEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            return false;
        }

        //Write a method to check whether a given number is even or odd
        public static void CheckEvenOrOdd(int num)
        {

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an EVEN number.");
            }
            else
            {
                Console.WriteLine($"{num} is an ODD number.");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void CheckPosOrNeg(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is a POSITIVE number.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is a NEGATIVE number.");
            }
            else
            {
                Console.WriteLine("Zero is neither positive or negative.");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CanVote(int age)
        {
            if (age >= 18) 
            {
                Console.WriteLine("You can vote.");
            }
            else
            {
                Console.WriteLine($"{age} years old is too young to vote. You have to be at least 18.");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool CheckRange(int num)
        {
            if (num >= -10 && num <= 10)
                return true;
            return false;
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int x)
        {
            int[] multiTable = new int[12];
            Console.WriteLine($"\nMultiplication table (from 1 to 12) of {x}");
            for (int i = 1; i <= 12; i++)
            {
                multiTable[i - 1] = i * x;
                Console.WriteLine($"{i} * {x} = {multiTable[i - 1]}");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
;           PrintNegToPosThousand();
            //----------------------------------------------------

            PrintDivisibleByThree ();
            //----------------------------------------------------

            Console.WriteLine("\nEnter the first integer number:");
            int userNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer number:");
            int userNum2 = int.Parse(Console.ReadLine());

            bool isEqual = CheckEqual(userNum1, userNum2);
            Console.WriteLine("If equal, print \"True\"; if NOT, print \"False\":");
            Console.WriteLine(isEqual);
            //----------------------------------------------------         
            string userNum;
            int parsedNum;
            bool isInteger;
            
            do 
            {
                Console.WriteLine("\nEnter an integer number:");
                userNum = Console.ReadLine();
                isInteger = int.TryParse(userNum, out parsedNum);
                if (!isInteger) { Console.WriteLine($"{userNum} is not an integer number."); }
            } while (!isInteger);
            
            CheckEvenOrOdd(parsedNum);
            //----------------------------------------------------

            CheckPosOrNeg(parsedNum);

            //----------------------------------------------------
            //If the string can not be converted to an integer, then
            //int.Parse() will throw an exception
            //int.TryParse() will return false (but not throw an exception)

            bool isParsed;
            int parsedAge;
            string inputAge;

            do
            {
                Console.WriteLine("\nEnter your age in a whole number:");
                inputAge = Console.ReadLine();
                isParsed = int.TryParse(inputAge, out parsedAge);
                if (!isParsed) { Console.WriteLine($"{inputAge} is not a whole number."); }
            } while (!isParsed);

            CanVote(parsedAge);

            //----------------------------------------------------
            Console.WriteLine("\nEnter an integer number:");
            int inputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"If {inputNumber} is in the range of -10 and 10, print \"True\"; if NOT, print \"False\":");
            bool isInRange = CheckRange(inputNumber);
            Console.WriteLine(isInRange);

            //----------------------------------------------------
            Console.WriteLine("\nEnter an integer number:");
            int inputNum = int.Parse(Console.ReadLine());

            MultiplicationTable(inputNum);

        }
    }
}
