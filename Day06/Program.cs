class Day06
{
    private static void Main(string[] args)
    {
        
        //Task 1
        int[] numbers = [10,20,30,40,50];
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        //Task 2

        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Sum of all numbers is: {sum}");

        //Task 3
        var max =0;
        foreach (var number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"Max number is: {max}");
        
        //Task 4
        Console.WriteLine("Enter 5 names");
        var names =  Console.ReadLine()?.Split(' ');
        if (names == null) return;
        Console.WriteLine("You entered:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        
        //Task 5
        Console.WriteLine("Enter a name to search");
        var nameForSearch = Console.ReadLine();
        for (var i = 0; i < names.Length; i++)
        {

            if (names[i] == nameForSearch)
            {
                Console.WriteLine("Found");
                break;
            }
            else if (i == names.Length - 1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                continue;
            }
            
        }
        
        //Task 6
        Console.WriteLine("Did you code today:");
        var isDoneCode = Console.ReadLine()?.Trim().ToLower();
        Console.WriteLine(isDoneCode == "yes"
            ? "You are building a new life."
            : "15 minutes can change your future. Start now!");
    }
}