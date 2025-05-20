// See https://aka.ms/new-console-template for more information

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