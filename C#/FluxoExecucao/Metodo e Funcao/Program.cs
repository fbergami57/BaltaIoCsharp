
{
    //invocação do método
    MeuMetodo();

    string name = ReturnName("Fabio F", "Bergami");
    Console.WriteLine(name);

}

static void MeuMetodo()
{
    Console.WriteLine("C# é legal");
}

static string ReturnName(string name, string lastName, int age = 45)
{
    return name + " " + lastName + " is " + age.ToString() + " years old.";
}


