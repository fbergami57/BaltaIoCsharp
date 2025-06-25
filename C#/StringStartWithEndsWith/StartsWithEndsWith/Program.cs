var text = "This text";
Console.WriteLine(text.StartsWith("This"));
Console.WriteLine(text.StartsWith("text"));
Console.WriteLine(text.StartsWith("Teste", StringComparison.OrdinalIgnoreCase));

Console.WriteLine(text.EndsWith("text"));
Console.WriteLine(text.EndsWith("Text"));
Console.WriteLine(text.EndsWith("text"));
