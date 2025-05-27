// See https://aka.ms/new-console-template for more information

// EJERCICIO 1

/*
string texto = Console.ReadLine();
int numero;
bool esNum = int.TryParse(texto, out numero);

if (esNum)
{
    if (numero > 0)
    {
        int invertido = 0;
        while (numero > 0)
        {
            invertido = invertido * 10 + numero % 10;
            numero /= 10;
        }
        Console.WriteLine("El numero invertido es " + invertido);
    }
    else
    {
        Console.WriteLine("El numero ingresado no es mayor que cero");
    }
}
else
{
    Console.WriteLine("El texto ingresado no es un numero entero");
}
*/

// EJERCICIO 2 Y 3

using System.Runtime.CompilerServices;

float solicitarNumero()
{
    string numString = Console.ReadLine();
    float num;

    while (!float.TryParse(numString, out num))
    {
        Console.Write("Ingrese un numero valido");
        numString = Console.ReadLine();
    }
    return num;
}

Console.Write("Ingrese un numero: ");
float num = solicitarNumero();

Console.WriteLine("|" + num + "| = " + Math.Abs(num));
Console.WriteLine(num + "^2 = " + num * num);
if (num >= 0)
{
    Console.WriteLine("Raiz cuadrada de " + num + " = " + Math.Sqrt(num));
}
else
{
   Console.WriteLine("No podemos calcular raiz cuadrada de un numero negativo"); 
}
Console.WriteLine("sen(" + num + ") = " + Math.Sin(num));
Console.WriteLine("cos(" + num + ") = " + Math.Cos(num));
Console.WriteLine("Parte entera de " + num + " = " + Math.Truncate(num));

Console.WriteLine("=====================");

Console.Write("Ingrese el numero 1: ");
float num1 = solicitarNumero();
Console.Write("Ingrese el numero 2: ");
float num2 = solicitarNumero();

if (num1 > num2)
{
    Console.WriteLine("Maximo: " + num1);
    Console.WriteLine("Minimo: " + num2);
}
else if (num2 > num1)
{
    Console.WriteLine("Maximo: " + num2);
    Console.WriteLine("Minimo: " + num1);
}
else
{
    Console.WriteLine("Los dos numeros son iguales");
}