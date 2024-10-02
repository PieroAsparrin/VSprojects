// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.Green;//Cambia el color de la tipografia de la consola

Console.WriteLine("Hello, World!");

double myDouble = 9.78;
int myInt = (int)myDouble; //Manual casting: double to int
Console.WriteLine(myDouble);
Console.WriteLine(myInt); //No mostrara decimales porque lo integger son numeros enteros

string firstName = "Piero";
string lastName = "Asparrin";
string name = $"Mi nombre completo es: {firstName} {lastName}";//insterpolacion de string con $
Console.WriteLine(name);

Console.WriteLine("Pulsa cualquier tecla para finalizar");
Console.ReadKey();
