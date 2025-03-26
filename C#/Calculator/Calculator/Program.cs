using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Which operation do you want?");
        Console.WriteLine("1 - Sum");
        Console.WriteLine("2 - Subtration");
        Console.WriteLine("3 - Division");
        Console.WriteLine("4 - Multiplication");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("------------");
        Console.WriteLine("Select one operation: ");

        short operation = short.Parse(Console.ReadLine());

        switch(operation)
        {
            case 1: Sum();
            break;

            case 2: Subtration();
            break;

            case 3: Division();
            break;

            case 4: Multiplication();
            break;

            case 5: System.Environment.Exit(0);
            break;

            default: Menu();
            break;
        }

    }

    static void Sum()
        {

            Console.Clear();

            Console.WriteLine("First Value:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second Value:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 + v2;
            Console.WriteLine("The result of the sum is: " + result);
            Console.ReadKey();
            Menu();
        }
    
    static void Subtration()
    {
        Console.Clear();

        Console.WriteLine("First Value:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Second Value:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float result = v1 - v2;
        Console.WriteLine("The result of the subtration is: " + result);
        Console.ReadKey();
        Menu();
    }

    static void Division()
    {
        Console.Clear();

        Console.WriteLine("First Value:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Second Value:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float result = v1 / v2;
        Console.WriteLine("The result of division is: " + result);
        Console.ReadKey();
        Menu();
    }

    static void Multiplication()
    {
        Console.Clear();

        Console.WriteLine("First Value:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Second Value:");
        float v2 = float.Parse(Console.ReadLine());

        float result = v1 * v2;
        Console.WriteLine("The result of the multiplication is: " + result);
        Console.ReadKey();
        Menu();
    }

}