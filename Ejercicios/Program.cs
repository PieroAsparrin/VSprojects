/* 
1.Lee una frase y una letra. Luego muestra cuantas palabras tiene y cuantas veces se repite la letra leida.
2.Solicita al usuario dos numeros enteros e indica cual es el mayor.
3.Lee un valor mayor que 0. Luego muestra los numero pares que hay en entre el 0 y el valor leido. Ademas cuenta cuantos numeros pares hay.
4.Solicita al usuario una frase y conviértela en camelCase (Elimina espacios y cada inicio de la siguiente palabra debe empezar con mayúsculas).
5.Solicita al usuario dos números enteros y un operador aritmético (+, -, *, /). Realize la operación y muestra el resultado. Ejemplo de resultado: 2 + 1 = 3
UDEMI
*/

using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("Selecciona el ejercicio que quieres ejercutar:");
            Console.WriteLine("1.Lee una frase y una letra. Luego muestra cuantas palabras tiene y cuantas veces se repite la letra leida.\n2.Solicita al usuario dos numeros enteros e indica cual es el mayor.\n3.Lee un valor mayor que 0. Luego muestra los numero pares que hay en entre el 0 y el valor leido. Ademas cuenta cuantos numeros pares hay.\n4.Solicita al usuario una frase y conviértela en camelCase (Elimina espacios y cada inicio de la siguiente palabra debe empezar con mayúsculas).\n5.Solicita al usuario dos números enteros y un operador aritmético (+, -, *, /). Realize la operación y muestra el resultado.\n6. Salir");
            string eleccion = Console.ReadLine();

            switch (eleccion)
            {
                case "1":
                    Console.Clear();
                    Ejercicio1();
                    break;
                case "2":
                    Console.Clear();
                    Ejercicio2();
                    break;
                case "3":
                    Console.Clear();
                    Ejercicio3();
                    break;
                case "4":
                    Console.Clear();
                    Ejercicio4();
                    break;
                case "5":
                    Console.Clear();
                    Ejercicio5();
                    break;
                case "6":
                    salir = true;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("- Escriba una opción válida -");
                    break;
            }

        }

    }

    /* 
    Este método solicita al usuario que ingrese una frase y una letra. Luego cuenta cuántas palabras 
    hay en la frase y cuántas veces se repite la letra ingresada.
    */
    public static void Ejercicio1()
    {
        Console.Clear();
        int palabrasC = 0;//Contador de palabras
        int letraR = 0;//Contador de letras
        bool enPalabra = false;//Booleano que indica si esta dentro de una palabra

        string frase;//Frase que ingresa el usuario
        Console.WriteLine("Escribe una frase:");
        frase = Console.ReadLine();

        char letra;//Letra que buscara el usuario
        Console.WriteLine("Escribe una letras:");
        letra = Console.ReadKey().KeyChar;//Recibe la pulsacion del teclado y toma el valor del caracter

        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] == letra)
            {
                letraR = letraR + 1;
            }

            if (EsVacio(frase[i]) == true)
            {
                enPalabra = false;
            }
            else if (!enPalabra)
            {
                enPalabra = true;
                palabrasC++;
            }
        }

        Console.WriteLine("\nLa letra " + letra + " se repite " + letraR + " veces..");
        Console.WriteLine("Hay " + palabrasC + " palabras en esta frase.");

        Console.ReadKey();
        Console.Clear();
    }

    /* 
    Este método solicita al usuario dos números enteros y determina cuál es mayor. 
    Si son iguales, lo indica también.
    */
    public static void Ejercicio2()
    {
        Console.Clear();

        int numero1 = 0;
        bool validoN1 = false;

        while (!validoN1) {
            Console.WriteLine("Introduce el primer numéro:");
            try {
                numero1 = int.Parse(Console.ReadLine());
                validoN1 = true;
            }
            catch (FormatException) {
                Console.Clear();
                Console.WriteLine("Indroduce un numero valido");
            }
        }

        int numero2 = 0;
        bool validoN2 = false;

        while (!validoN2)
        {
            Console.WriteLine("Introduce el segundo numéro");
            try
            {
                numero2 = int.Parse(Console.ReadLine());
                validoN2 = true;
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Indroduce un numero valido");
            }
        }

        if (numero1 > numero2)
        {
            Console.WriteLine("\nEl primer numéro es mayor: " + numero1 + " > " + numero2);
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("\nEl segundo numéro es mayor: " + numero2 + " > " + numero1);
        }
        else
        {
            Console.WriteLine("\nAmbos numéros son iguales: " + numero1 + " = " + numero2);
        }
        Console.ReadKey();
        Console.Clear();
    }

    /* 
   Este método solicita un número mayor que 0, y luego imprime todos los números pares 
   desde 0 hasta el número ingresado, además de contar cuántos números pares hay.
   */
    public static void Ejercicio3()
    {
        Console.Clear();

        int numero = 0;
        bool noCero = false;

        while (!noCero)
        {
            Console.WriteLine("Introduce un número mayor que cero:");
            try
            {
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    noCero = true;
                }
                else
                {
                    Console.WriteLine("El número debe ser mayor que cero.");
                    noCero = false;
                    Console.Clear();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, introduce un número válido.");
                Console.Clear();
            }
        }

        int cPares = 0;

        Console.Write("Entre el 0 y el " + numero + " los numeros pares son: ");
        for (int i = 0; i < numero; i++)
        {
            if (i != 0 && i % 2 == 0)
            {
                Console.Write(i + " ");
                cPares++;
            }
        }
        Console.Write(".");
        Console.WriteLine("\nY hay " + cPares + " numeros pares.");

        Console.ReadKey();
        Console.Clear();
    }

    /* 
    Este método solicita al usuario una frase y la convierte a camelCase. 
    Se eliminan los espacios y cada palabra comienza con mayúscula.
    */
    public static void Ejercicio4()
    {
        Console.Clear();

        string resultado;
        Console.WriteLine("Escribe una frase:");
        string frase;
        frase = Console.ReadLine();

        frase = frase.ToLower();//convierte todo en minuscula
        char[] caracteres = frase.ToCharArray();//Crea un array con caracteres de la frase, debido a que en C# los caracteres de un String son inmutables

        for (int i = 0; i < caracteres.Length; i++)
        {

            if (i != 0)
            {
                if (Capitalizainador(caracteres[i - 1], caracteres[1]))
                {
                    caracteres[i] = Char.ToUpper(caracteres[i]);
                }

            }

        }
        frase = new string(caracteres);
        frase = frase.Replace(" ", "").Replace("\t", "");

        Console.WriteLine("\nTransfomación a Camelcase: " + frase);

        Console.ReadKey();
        Console.Clear();
    }

    /* 
   Este método solicita dos números enteros y un operador aritmético, 
   realiza la operación correspondiente y muestra el resultado.
   */
    public static void Ejercicio5()
    {
        Console.Clear();

        int numero1 = 0;
        bool validoN1 = false;

        while (!validoN1)
        {
            Console.WriteLine("Introduce el primer número:");
            try
            {
                numero1 = int.Parse(Console.ReadLine());
                validoN1 = true;
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Indroduce un numero valido");
            }
        }

        int numero2 = 0;
        bool validoN2 = false;

        while (!validoN2)
        {
            Console.WriteLine("Introduce el segundo número:");
            try
            {
                numero2 = int.Parse(Console.ReadLine());
                validoN2 = true;
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Indroduce un numero valido");
            }
        }

        Console.WriteLine("Introduce un operador");
        string operador;
        operador = Console.ReadLine();
        switch (operador)
        {
            case "+":
                Console.WriteLine("\n" + numero1 + " + " + numero2 + " = " + Suma(numero1, numero2));

                break;
            case "-":
                Console.WriteLine("\n" + numero1 + " - " + numero2 + " = " + Resta(numero1, numero2));

                break;
            case "*":
                Console.WriteLine("\n" + numero1 + " * " + numero2 + " = " + Multipicacion(numero1, numero2));

                break;
            case "/":
                if (numero2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre 0");
                    break;
                }
                else
                {
                    Console.WriteLine("\n" + numero1 + " / " + numero2 + " = " + Division(numero1, numero2));
                    break;
                }
            default:
                Console.WriteLine("\n- El operador introducido es inválido -");

                break;
        }
        Console.ReadKey();
        Console.Clear();
    }

    //COMPROBAR LOS VACIOS
    /* 
 Verifica si el carácter es un espacio en blanco (espacio o tabulación).
 Este método toma un carácter como entrada y comprueba si es un espacio o un carácter de tabulación.
 Devuelve verdadero si el carácter es un espacio en blanco; de lo contrario, devuelve falso.
 */
    private static bool EsVacio(char palabra)
    {
        char espacio = ' ';
        char tabulador = '\t';

        if (palabra == espacio || palabra == tabulador)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    //CAPITALIZAR
    /* 
 Verifica si el último carácter es un espacio en blanco o tabulación para determinar si el siguiente carácter debe ser capitalizado.
 Este método comprueba si el último carácter (ultimoChar) es un espacio o un tabulador.
 Si es así, indica que el carácter actual (actual) debe ser capitalizado (por ejemplo, la primera letra de una nueva palabra).
 Devuelve verdadero si se necesita capitalización; de lo contrario, devuelve falso.
 */
    private static bool Capitalizainador(char ultimoChar, char actual)
    {
        char espacio = ' ';
        char tabulador = '\t';

        if (ultimoChar == espacio || ultimoChar == tabulador)
        {

            return true;
        }
        else
        {
            return false;
        }
    }

    //OPERACIONES DE LA CALCULADORA(EJERCICIO 05)
    private static int Suma(int n1, int n2)
    {
        int suma = n1 + n2;
        return suma;
    }
    private static int Resta(int n1, int n2)
    {
        int resta = n1 - n2;
        return resta;
    }
    private static int Multipicacion(int n1, int n2)
    {
        int producto = n1 * n2;
        return producto;
    }
    private static int Division(int n1, int n2)
    {
        int cociente = n1 / n2;
        return cociente;
    }

}
