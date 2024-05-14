// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

int aux, numero;
Console.Write("Ingrese un numero: ");
string num = Console.ReadLine();
int.TryParse(num, out numero);
aux = numero;
if (numero>0)
{
    while (aux != 0)
    {
        numero= aux % 10;
        Console.Write(+numero);
        aux=aux/10;
    }
}