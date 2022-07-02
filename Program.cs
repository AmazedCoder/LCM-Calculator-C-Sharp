class Program {
    static void Main(string[] args) {
        // ! Default Settings for Program, Do Not Change!
        Console.Title = "L.C.M. Calculation";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WindowHeight = 40;
        
        // ? Variables
        int largestNum = 1000;
        int greater;
        int lcm;

        // ? Welcoming Message
        Console.WriteLine("L.C.M. Calculation! You can enter three numbers at most.");

        // ? Get all the interger numbers
        Console.WriteLine("Enter first integer number:");

        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 > largestNum) {
            while (num1 > largestNum) {
                Console.WriteLine("Sorry, number too large.");
                num1 = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter second integer number:");

        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num2 > largestNum) {
            while (num2 > largestNum) {
                Console.WriteLine("Sorry, number too large. Please enter again.");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter third integer number:");

        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num3 > largestNum) {
            while (num3 > largestNum) {
                Console.WriteLine("Sorry, number too large.");
                num3 = Convert.ToInt32(Console.ReadLine());
            }
        }

        // * Calculation for the L.C.M.

        List<int> numberList = new List<int>();

        numberList.Add(num1);
        numberList.Add(num2);
        numberList.Add(num3);

        greater = numberList.Max(z => z);
        lcm = greater;

        while (true) {
            if (lcm % num1 == 0 && lcm % num2 == 0 && lcm % num3 == 0) {
                break;
            } else {
                lcm += greater;
            }
        }

        Console.WriteLine("The L.C.M. is " + lcm);

        // Wait before closing
        Console.ReadKey();
    }
}