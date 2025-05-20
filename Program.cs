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

float suma(float num1, float num2)
{
    return num1 + num2;
}
float resta(float num1, float num2)
{
    return num1 - num2;
}
float multiplicacion(float num1, float num2)
{
    return num1 * num2;
}
float division(float num1, float num2)
{
    return num1 / num2;
}

string opcionString;
int opcionInt = 0;
float num1, num2;

while (opcionInt != 5)
{
    Console.WriteLine("\n================================\n");
    Console.WriteLine("Seleccione una opcion:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");

    opcionString = Console.ReadLine();

    bool opcionValida = int.TryParse(opcionString, out opcionInt);
    Console.WriteLine("\n------------------------\n");
    if (opcionValida && opcionInt > 0 && opcionInt < 5)
    {
        Console.WriteLine("Ingrese el primer numero:");
        num1 = solicitarNumero();
        Console.WriteLine("\nIngrese el segundo numero");
        num2 = solicitarNumero();
        Console.WriteLine("\n------------------------\n");
        switch (opcionInt)
        {
            case 1:
                Console.WriteLine(num1 + " + " + num2 + " = " + suma(num1, num2));
                break;
            case 2:
                Console.WriteLine(num1 + " - " + num2 + " = " + resta(num1, num2));
                break;
            case 3:
                Console.WriteLine(num1 + " * " + num2 + " = " + multiplicacion(num1, num2));
                break;
            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine(num1 + " / " + num2 + " = " + division(num1, num2));
                }
                else
                {
                    Console.WriteLine("Error, division en cero");
                }
                break;
        }   
    }
}

Console.WriteLine("Saliendo...");