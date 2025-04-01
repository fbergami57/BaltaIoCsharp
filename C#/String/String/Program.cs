using System;

var id = Guid.NewGuid();
id.ToString();

id = new Guid("c9eb1672-d40b-4d7d-92aa-b0824c9dabd6");

Console.WriteLine(id.ToString().Substring(0, 8));