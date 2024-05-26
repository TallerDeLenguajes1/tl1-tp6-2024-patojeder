// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
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
}*/

string? Num1= "";
float numValido=0;
string? Num2;
float numValido2=0;
string? Num3;
float numValido3=0;
bool esUnNumeroValido = false;
bool esUnNumeroValido2;
bool esUnNumeroValido3;
int bandera=0;
while (!esUnNumeroValido)
{
    Console.WriteLine("\ningresen numero valido\n");
    Num1=Console.ReadLine();
    esUnNumeroValido=float.TryParse(Num1, out numValido);
    if (!esUnNumeroValido)
    {
        Console.WriteLine(Num1+ " no es un numero valido");
    }
}
Console.WriteLine($"ingreso un numero valido: {Num1}");

Console.WriteLine("\n El valor absolutod el numero es: "+ Math.Abs(numValido));
Console.WriteLine("\n El el cuadrado del numero es: "+ numValido*numValido);
Console.WriteLine("\n La raiz cuadrada del numero es: "+ Math.Sqrt(numValido));
Console.WriteLine("\n El seno del numero es: "+ Math.Sin(numValido));
Console.WriteLine("\n El coseno del numero es: "+ Math.Cos(numValido));
Console.WriteLine("\n El parte entera del numero es: "+ Math.Floor(numValido));

while (bandera!=1)
{
    Console.WriteLine("\ningresen numero valido\n");
    Num2=Console.ReadLine();
    esUnNumeroValido2=float.TryParse(Num2, out numValido2);
    Num3=Console.ReadLine();
    esUnNumeroValido3=float.TryParse(Num3, out numValido3);    
    if (esUnNumeroValido2 && esUnNumeroValido3)
    {
       bandera=1;
    }else
    {
        Console.WriteLine("\n Uno del los numeros ingresados no es valido ");
    }


}

if (numValido2 >= numValido3)
{
    Console.WriteLine($"El numero {numValido2} es el mayor ingresado ");
}else
{
    Console.WriteLine($"El numero {numValido3} es el mayor ingresado ");   
}

if (numValido2 <= numValido3)
{
    Console.WriteLine($"El numero {numValido2} es el menor ingresado ");
}else
{
    Console.WriteLine($"El numero {numValido3} es el menor ingresado ");   
}