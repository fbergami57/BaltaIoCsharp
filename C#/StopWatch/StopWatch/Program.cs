using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Seconds => 10s = 10 Seconds");
        Console.WriteLine("M = Minutes => 1m = 1 minute");
        Console.WriteLine("0 - Quit");
        Console.WriteLine("How much time?");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length-1,1));

        int time = int.Parse(data.Substring(0,data.Length - 1));
        int multiplier = 1;

        if(type == 'm')
            multiplier = 60;
        
        if(time == 0)
            System.Environment.Exit(0);

        PreStart(time * multiplier);

        //Console.WriteLine(time);
        //Console.WriteLine(type);
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...and...");
        Thread.Sleep(1000);
        Console.WriteLine("GO!!!");
        Thread.Sleep(1000);

        Start(time);
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while(currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("StopWatch finished...return to menu");
        Thread.Sleep(2500);
        Menu();

    }
}
