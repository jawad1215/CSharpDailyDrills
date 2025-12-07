class Day04
{
    static void Main(string[] args)
    {
        //Task 1
        for (var i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        //Task 2
        for (var i = 2; i <= 20; i++)
        {
            if (i % 2 ==0)
            {
                Console.WriteLine(i);
            }
        }

        // Task 3
        var number = 1;
        var sum = 0;
        while (number<=100)
        {
            sum += number;
            number++;
        }
        Console.WriteLine(sum);
        
        
        // Task 4
        Console.WriteLine("Enter a number");
        var input = int.TryParse(Console.ReadLine(), out var numberForTable);
        if (input)
        {
            for (var i = 1; i <=10 ; i++)
            {
                Console.WriteLine($"{numberForTable} x {i} = {numberForTable * i}");
            }
        }
       
        // Task 5
        Console.WriteLine("Do you code today");
        var isCodeToday = Console.ReadLine()?.Trim().ToLower() == "yes";
        Console.WriteLine(isCodeToday ? "Great! Keep going." : "Just 15 minutes. Start now.");
    }
}