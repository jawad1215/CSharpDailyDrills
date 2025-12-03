namespace Day01_Exercise;

class Day01_Exercise
{
    private static void Main()
    {
        const string name = "Jawad";
        const int age = 30;
        const double currentSalary = 150;
        const string country = "Pakistan";
        const bool isLearning = true;
        
        Console.WriteLine($"{name} {age} {country} {isLearning}");
        
        const double futureSalary = 300;
        
        const bool isGoalAchievable = currentSalary < futureSalary;
        Console.WriteLine(isGoalAchievable);


        const int number1 = 150;
        const int number2 = 50;
        
        const int sum = number1 + number2;
        const int subtract = number1 - number2;
        const int multiply = number1 * number2;
        const int divide = number1 / number2;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Subtract: " + subtract);
        Console.WriteLine("Multiply: " + multiply);
        Console.WriteLine("Divide: " + divide);

    }
}