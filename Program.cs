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


int opcion, seguir;
float resultado, n1, n2;
do{
   Console.WriteLine("Ingrese la operacion a ralizar: \n1)-Sumar\n2)-Restar\n3)-Multiplicar\n4)-Dividir\n0)-Salir ");
   string opc= Console.ReadLine();
   int.TryParse(opc, out opcion);
switch (opcion)
{
    case 1:
        Console.WriteLine("\ningrese el numero a\n");
        string N1= Console.ReadLine();
        float.TryParse(N1, out n1);
        Console.WriteLine("\ningrese el numero b\n");
        string N2= Console.ReadLine();
        float.TryParse(N2, out n2);
        resultado=n1+n2;
        Console.WriteLine("\nEl resultado de la suma entre a y b es: "+ resultado);

    break;

    case 2:
        Console.WriteLine("\ningrese el numero a\n");
        N1= Console.ReadLine();
        float.TryParse(N1, out n1);
        Console.WriteLine("\ningrese el numero b\n");
        N2= Console.ReadLine();
        float.TryParse(N2, out n2);
        resultado=n1-n2;
        Console.WriteLine("\nEl resultado de la resta entre a y b es: "+ resultado);

    break;

    case 3:
        Console.WriteLine("\ningrese el numero a\n");
        N1= Console.ReadLine();
        float.TryParse(N1, out n1);
        Console.WriteLine("\ningrese el numero b\n");
        N2= Console.ReadLine();
        float.TryParse(N2, out n2);
        resultado=n1*n2;
        Console.WriteLine("\nEl resultado del producto a y b es: "+ resultado);
    break;

    case 4: 
        Console.WriteLine("\ningrese el numero a\n");
        N1= Console.ReadLine();
        float.TryParse(N1, out n1);
        Console.WriteLine("\ningrese el numero b\n");
        N2= Console.ReadLine();
        float.TryParse(N2, out n2);
        resultado=n1/n2;
        Console.WriteLine("\nEl resultado de la division entre a y b es: "+ resultado);
    break;

    default:
    break;
}

        Console.WriteLine("\ndesea realizar otrocalculo?: 1-)SI\n0) NO\n ");
        string seg= Console.ReadLine();
        int.TryParse(seg, out seguir);
}while(seguir != 0);

