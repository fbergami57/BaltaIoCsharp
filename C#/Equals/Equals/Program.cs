var text = "This text is a text";
Console.WriteLine(text.Equals("This text is a text"));
Console.WriteLine(text.Equals("this text is a text"));
Console.WriteLine(text.Equals("this text is a text", StringComparison.OrdinalIgnoreCase));