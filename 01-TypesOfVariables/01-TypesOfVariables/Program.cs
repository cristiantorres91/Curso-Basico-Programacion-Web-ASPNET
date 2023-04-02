// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Declaración y tipos Variables
string name = "Juan Perez";
int age = 30;
bool isEmployee = true;
double salary = 1000.50;
// El tipo decimal tiene un intervalo más pequeño, pero mayor precisión que double. 
decimal discount = 100.50m;

Console.WriteLine("Nombre:" + name + " Edad:" + age + " Empleado:" + isEmployee + " Salario:" + salary + " Descuento:" + discount);
Console.WriteLine($"Nombre:{name} Edad:{age} Empleado:{isEmployee} Salario:{salary} Descuento:{discount}");

//Mas tipos de variables
DateTime date = DateTime.Now;
char character = 'A'; //almacena un único carácter Unicode.
byte myByte = 255; // almacena un valor entero sin signo de 8 bits.
short myShort = -32768; //almacena un valor entero con signo de 16 bits.
long mylong = 1234567890123456789; // almacena un valor entero con signo de 64 bits.
float myFloat = 3.14159f; // almacena un número de punto flotante de precisión simple.

