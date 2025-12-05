class Day02
{
    static void Main(string[] args)
    {
    
        
        Console.WriteLine("Enter your name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Enter your age: ");
        var age = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Enter your country: ");
        var country = Console.ReadLine();
        Console.WriteLine($"Hello {name}, you are {age} years old and you live in {country}.\n");        
        
      
      Console.WriteLine("Enter your salary");
      double salary = Convert.ToDouble(Console.ReadLine());
      double salaryAfter10PercentIncrease = salary + salary * 0.1;
      Console.WriteLine($"Your salary after 10% increase: {salaryAfter10PercentIncrease}\n");
        
      
       Console.WriteLine("Do you want to become a .NET expert? (yes/no)");
        var choice = Console.ReadLine();
        Console.WriteLine(choice?.Trim().ToLower() == "yes"
            ? "Great! You will succeed InshaAllah."
            : "No worries. Consistency will bring clarity. Keep learning.");


        Console.WriteLine("You will become expert in 2027 if you stay consistent.");
    }
    
}