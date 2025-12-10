class Day05
{
    private static void Main()
    {
        //task 1
        for (var i = 10; i>0;i--)
        {
            Console.WriteLine(i);
        }
        
        //task 2

        for (var i = 1; i <= 10; i++)
        {
            Console.Write(i * 7 + " ");
        }
        
        //task 3
        
        Console.WriteLine("\nEnter a number");
        var isValidNumber = int.TryParse(Console.ReadLine(), out var number);
        var sum = 0;
        if (isValidNumber)
        {
            for (var i = 1; i <= number; i++)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
        
        //task4

        while (true)
        {
            Console.WriteLine("Enter first number");
            var isFirstNumberValid = double.TryParse(Console.ReadLine(), out var firstNumber);
            Console.WriteLine("Enter second number");
            var isSecondNumberValid = double.TryParse(Console.ReadLine(), out var secondNumber);

            if (isFirstNumberValid && isSecondNumberValid)
            {
                Console.WriteLine("Enter operator (+ - * /): ");
                var operatorString = Console.ReadLine();
                var result = 0.0;
                switch (operatorString)
                {
                    case "+": result = firstNumber + secondNumber; 
                        break;
                    case "-": result = firstNumber - secondNumber;
                        break;
                    case "*": result = firstNumber * secondNumber;
                        break;
                    case "/": result = firstNumber / secondNumber;
                        break;
                    default:
                        Console.WriteLine($"Invalid operator {operatorString}");
                        break;
                }
                Console.WriteLine($"Result: {result}" );
            }
            else
            {
                break;
            }
            
            Console.WriteLine("Type exit to quit or press Enter to continue");
            var userInput = Console.ReadLine();
            if (userInput == "exit")
            {
                break;
            }

        }
        
        //task 5
        Console.WriteLine("Did you code today?");
        var codeToday = Console.ReadLine()?.Trim().ToLower();
        Console.WriteLine(codeToday == "yes" ? "You are unstoppable" : "Your future self needs 15 minutes. Start now!");
    }
}