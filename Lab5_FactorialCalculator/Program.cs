bool runningProgram = true;
bool doingExercise = true;
long number;

Introduction();

while(runningProgram)
{
    while(doingExercise)
    {
        number = GetNumber();
        if (number >= 1 && number <= 10)
        {
            Console.WriteLine("");
            Console.WriteLine($"The factorial of {number} is {GetFactorial(number)}.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
            doingExercise = RunProgramAgain();
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("I'm sorry, that number appears to be outside of the range of 1 to 10. Please try again.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
    runningProgram = doingExercise;
}
Console.WriteLine("Thank you for using the Factorial Calculator application!");
Console.WriteLine("Goodbye...");

static void Introduction()
{
    Console.WriteLine("Welcome to the Factorial Calculator application!");
    Console.WriteLine("Press Enter to Continue.");
    Console.ReadLine();
    Console.Clear();
}
static bool RunProgramAgain()
{
    bool promptingUser = true;
    while (promptingUser)
    {
        Console.WriteLine("Would you like to run this program again?");
        Console.WriteLine("Enter 'y' or 'yes' to do another exercise, or enter 'n' or 'no' to exit the program.");
        Console.WriteLine("");
        Console.Write("Your response: ");
        string userInput = Console.ReadLine().ToLower();

        if (userInput == "y" || userInput == "yes")
        {
            Console.Clear();
            promptingUser = false;
            return true;
        }
        else if (userInput == "n" || userInput == "no")
        {
            Console.Clear();
            promptingUser = false;
            return false;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
    return false;
}
static long GetFactorial(long number)
{
    List<long> numbersList = new List<long>();
    for (int i = 1; i <= number; i++)
    {
        numbersList.Add(i);
    }
    long factorial = numbersList.Aggregate((a, x) => a * x);
    return factorial;
}
static long GetNumber()
{
    bool gettingNumber = true;
    while (gettingNumber)
    {
        Console.WriteLine("Enter a number between 1 and 10 inclusive, and I will calculate and display it's factorial value.");
        Console.Write("Enter your number now: ");
        string enteredNumber = Console.ReadLine();
        bool isANumber = long.TryParse(enteredNumber, out long number);
        if (isANumber)
        {
            return number;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("I'm sorry, that doesn't appear to be a whole number. Please try again.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
    return -1;
}