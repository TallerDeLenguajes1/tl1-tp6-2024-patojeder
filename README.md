# Respuestas punto 4
**¿String es una tipo por valor o un tipo por referencia?**
En C#, string es un tipo por referencia.

**¿Qué secuencias de escape tiene el tipo string?**
Se pueden encontrar las siguientes:
- "\n": Salto de línea.
- "\r": Retorno de carro.
- "\t": Tabulación.
- "\'": Comilla simple.
- "\"": Comilla doble.
- "\\": Barra invertida

**¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?**
El carácter @ antes de una cadena de texto se utiliza para indicar una cadena de texto literal (literal string). Esto significa que la cadena de texto se interpreta tal como está escrita, sin interpretar secuencias de escape. Por ejemplo: 
 - string normalString = "C:\\Windows\\System32\\";
 - string literalString = @"C:\Windows\System32\";

En cambio el caracter $ antes de una cadena de texto, indica que se trata una cadena de texto interpolada. Este tipo de cadena permite incluir expresiones dentro de la cadena de texto mediante el uso de llaves {}. Por ejemplo:
string nombre = "Juan";
int edad = 30;

string mensaje = $"Hola, me llamo {nombre} y tengo {edad} años.";

**Los ejercicios del pto5 correspondientes a la calculadora, se resolveran en la rama calculadorav1**

