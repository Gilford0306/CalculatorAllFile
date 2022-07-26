const string fileName = "calculatorlog.txt";
do
{
    Console.WriteLine("\nNew calculating -0\nSee full history - 1\nDelete history - 2");
    string k = Console.ReadLine();
    if (k == "1")
    {
        if (File.Exists(fileName))
            Console.WriteLine(File.ReadAllText(fileName));
        else
            Console.WriteLine("History is empty");
    }
    else if (k == "2")
    {
        Console.WriteLine("Do you want delete history ?\nInput - yes for deleting\nany other key - back to meny");
        string d = Console.ReadLine();
        if (d.ToLower() == "yes" && File.Exists(fileName))
        {
            File.Delete(fileName);
            Console.WriteLine("History is empty");
        }
        else if (d.ToLower() == "yes" && !File.Exists(fileName))
            Console.WriteLine("History is empty");
        else
            continue;
    }
    else if (k == "0")
    {
        Console.WriteLine("Input to\naddition - +\nsubtraction - -\nmultiplication- *\ndivision - / ");
        string z = Console.ReadLine();
        if (z != "+" && z != "-" && z != "*" && z != "/")
        {
            Console.WriteLine("Only + - * /");
            continue;
        }
        Console.WriteLine("input 1 number");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("input 2 number");
        double b = double.Parse(Console.ReadLine());
        switch (z)
        {
            case "+":
                double res = a + b;
                Console.WriteLine($"{a}+{b} = {res}\n");
                File.AppendAllText(fileName, $"{a}+{b} = {res}\n");
                break;
            case "-":
                res = a - b;
                Console.WriteLine($"{a}-{b} = {res}\n");
                File.AppendAllText(fileName, $"{a}-{b} = {res}\n");
                break;
            case "*":
                res = a * b;
                Console.WriteLine($"{a}*{b} = {res}\n");
                File.AppendAllText(fileName, $"{a}*{b} = {res}\n");
                break;
            case "/":
                if (b == 0)
                {
                    Console.WriteLine($"Can't divide by zero");
                    break;
                }
                res = a / b;
                Console.WriteLine($"{a}/{b} = {res}\n");
                File.AppendAllText(fileName, $"{a}/{b} = {res}\n");
                break; 
            default:
                break;
        }
    }
} while (true);
