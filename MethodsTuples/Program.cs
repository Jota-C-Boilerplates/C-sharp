// See https://aka.ms/new-console-template for more information
// Syntax tupla y podemos asignar valores despues o durante su creacion
(int a, int b) myTuple;
myTuple = (1, 4);
(int a, string b, bool c) myTuple2 = (43, "Jota", false);

myTuple2.a = 100;

// Show the values
Console.WriteLine($"{myTuple2.a} - {myTuple2.b} - {myTuple2.c}");

// ahora podemos iniciar una tupla de manera implicita
var myTuple3= (154, "Mensaje");
myTuple3.Item1 = 200; // Para llamar a los valores de la tupla usamos Item1, Item2 ... ItemX;

Console.WriteLine($"{myTuple3.Item1} - {myTuple3.Item2} ");

// Methods
(double, int, string) methodWithTuple(string nombreProducto, int stock, int precio)
{
	var precioFinal = precio * 1.2;
	return (precioFinal, stock, nombreProducto);
}

var tuple = methodWithTuple(stock:50, precio:10, nombreProducto: "JotaProd"); // Named arguments
// Follow the order of the typle to call Item1, Item2, ... ItemX
Console.WriteLine($"Result methodWithTuple: Product {tuple.Item3} Price {tuple.Item1} Stock {tuple.Item2}");