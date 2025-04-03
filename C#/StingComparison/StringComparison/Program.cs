var text = "Testing";
Console.WriteLine(text.CompareTo("Testing"));
Console.WriteLine(text.CompareTo("testing"));

var text1 = "This text is a test";
Console.WriteLine(text1.Contains("test"));
Console.WriteLine(text1.Contains("Test"));
Console.WriteLine(text1.Contains("Test", StringComparison.OrdinalIgnoreCase));
Console.WriteLine(text1.Contains(null));
