class Day03
{
    static void Main()
    {
     
        //Task 1
        Console.WriteLine("Enter Temperature");
        var temperature = double.Parse(Console.ReadLine() ?? "32");
        if (temperature < 15)
        {
            Console.WriteLine("Cold");
        }
        else if (temperature is >= 15 and < 30)
        {
            Console.WriteLine("Warm");
        }
        else
        {
            Console.WriteLine("Hot");
        }
        
        //Task 2
        Console.WriteLine("Enter Number");
        var number = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
        
        //Task3
        Console.WriteLine("Enter Username");
        var username = Console.ReadLine();
        Console.WriteLine("Enter Password");
        var password = Console.ReadLine();

        if (username =="jawad" && password == "1234")
        {
            Console.WriteLine("Login successful");
        }
        else
        {
            Console.WriteLine("Invalid Credentials");
        }
        
        //Task4
        Console.WriteLine("Enter Your Marks");
        var marks = double.Parse(Console.ReadLine() ?? "0");
        var grade = marks switch
        {
            >= 90 and <= 100 => "A",
            >= 80 and <= 89 => "B",
            >= 70 and <= 79 => "C",
            >= 60 and <= 69 => "D",
            _ => "F"
        };
        Console.WriteLine(grade);
        
        //Motivation
        Console.WriteLine("Did you code today");
        var answer =  Console.ReadLine()?.Trim().ToLower();
        Console.WriteLine(answer == "yes"
            ? "Excellent you are 1% better today"
            : "Start now you only needs 15 minutes");
    }
    
}