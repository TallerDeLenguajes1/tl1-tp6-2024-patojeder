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


string? cadena1;
string? cadena2;
Console.WriteLine("\nIngrese una cadena: \n");
cadena1=Console.ReadLine();
int longitud= cadena1.Length;
Console.WriteLine($"la longitud de la cadena es : {longitud}");
Console.WriteLine("\nIngrese una cadena: \n");
cadena2= Console.ReadLine();

string concatenada1 = string.Concat(cadena1, ", ", cadena2, "!");
Console.WriteLine("concatenada con meto concat string: "+ concatenada1);

string concatenada2 = cadena1 + ", " + cadena2 + "!";
Console.WriteLine("concatenada con +: "+ concatenada2);

Console.WriteLine("Obtencion de sub cadena entre los puntos 3 y 7");
string subcadena = cadena1.Substring(3, 7);
Console.WriteLine(subcadena);



foreach (char caracter in cadena1)
{
    Console.WriteLine(caracter);
}

string minusculas = cadena1.ToLower();
Console.WriteLine(minusculas);
string mayusculas = cadena1.ToUpper(); 
Console.WriteLine(mayusculas);


string palabrabuscada;
Console.WriteLine("\n Ingrese una palabra a buscar en la cadena:");
palabrabuscada= Console.ReadLine();
if (cadena1.Contains(palabrabuscada))
{
    Console.WriteLine($"\nLa cadena contiene la palabra '{palabrabuscada}'.");
    int indice= cadena1.IndexOf(palabrabuscada);
    Console.WriteLine($"\nLa palabra se encuentra en el indice {indice} de la cadena");
}
else
{
    Console.WriteLine($"La cadena no contiene la palabra '{palabrabuscada}'.");
}

string separada;
Console.WriteLine("\n ingrese una cadena con palabras separadas por coma, puntos o guiones");
separada= Console.ReadLine();
string[] palabraseparada = separada.Split(new string[] {",", ".", "-"}, StringSplitOptions.None);

foreach (string elemento in palabraseparada)
{
    Console.WriteLine(elemento);
}



