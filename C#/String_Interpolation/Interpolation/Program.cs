var price = 10.2 + 9;
//var text = "The price of the product is " + price;

//var text = string.Format("The price of the product is {0}", price);

var text = $@"The price 
of the product is {price}"; //Ao inserir o "@" depois do "$" pode pular a linha que entende que é a continuação

Console.WriteLine(text);
