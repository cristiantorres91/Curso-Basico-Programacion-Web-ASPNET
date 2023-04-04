// See https://aka.ms/new-console-template for more information

//Estructuras de selección o decisiones
int age = 25;

if (age >= 18)
{
    Console.WriteLine("Eres mayor de edad");
}

int num = 5;

if (num % 2 == 0)
{
    Console.WriteLine("El número es par");
}
else
{
    Console.WriteLine("El número es impar");
}

char letter = 'a';

switch (letter)
{
    case 'a':
        Console.WriteLine("La letra es 'a'");
        break;
    case 'b':
        Console.WriteLine("La letra es 'b'");
        break;
    default:
        Console.WriteLine("La letra no es 'a' ni 'b'");
        break;
}

Console.WriteLine("\n");

//Estructuras de repetición o bucles
int i = 0;

while (i < 5)
{
    Console.WriteLine("El valor de i es: " + i);
    i++;
}

Console.WriteLine("\n");


int j = 7;

do
{
    Console.WriteLine("El valor de j es: " + j);
    j++;
} while (j < 5);


Console.WriteLine("\n");

for (int k = 0; k < 5; k++)
{
    Console.WriteLine("El valor de k es: " + k);
}

Console.WriteLine("\n");

int[] nums = { 1, 2, 3, 4, 5 };

foreach (int n in nums)
{
    Console.WriteLine("El número es: " + n);
}

Console.WriteLine("\n");


//Estructuras de salto
for (int m = 0; m < 5; m++)
{
    if (m == 3)
    {
        break;
    }
    Console.WriteLine("El valor de m es: " + m);
}

Console.WriteLine("\n");

for (int n = 0; n < 5; n++)
{
    if (n == 3)
    {
        continue;
    }
    Console.WriteLine("El valor de n es: " + n);
}

Console.WriteLine("\n");

int Sum(int num1, int num2)
{
    int result = num1 + num2;
    return result;
}

Console.WriteLine(Sum(1, 2));