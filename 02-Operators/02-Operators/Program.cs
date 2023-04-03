// See https://aka.ms/new-console-template for more information

//Operadores Aritméticos
int x = 20;
int y = 10;
int addition = x + y;
int subtraction = x - y;
int multiplication = x * y;
int division = x / y;
int mod = x % y;

Console.WriteLine($"Suma {addition}\nResta{subtraction}\nMultiplicación {multiplication}\nDivision {division}\nModulo {mod}");


//Operadores Asignación
int a = 5; // Asignación básica, 'a' ahora tiene el valor 5

a += 2; // Operador de asignación de suma, es equivalente a 'a = a + 2'. 'a' ahora tiene el valor 7.

a -= 3; // Operador de asignación de resta, es equivalente a 'a = a - 3'. 'a' ahora tiene el valor 4.

a *= 2; // Operador de asignación de multiplicación, es equivalente a 'a = a * 2'. 'a' ahora tiene el valor 8.

a /= 4; // Operador de asignación de división, es equivalente a 'a = a / 4'. 'a' ahora tiene el valor 2.

a %= 2; // Operador de asignación de módulo, es equivalente a 'a = a % 2'. 'a' ahora tiene el valor 0.

//Operadores Comparación

// Operador de igualdad (==)
bool resultEquality = x == y; // El valor de 'resultadoIgualdad' será false, ya que x no es igual a y.

// Operador de desigualdad (!=)
bool resultInequality = x != y; // El valor de 'resultadoDesigualdad' será true, ya que x no es igual a y.

// Operador de mayor que (>)
bool resultGreaterThan = x > y; // El valor de 'resultadoMayorQue' será false, ya que x no es mayor que y.

// Operador de menor que (<)
bool resultLessThan = x < y; // El valor de 'resultadoMenorQue' será true, ya que x es menor que y.

// Operador de mayor o igual que (>=)
bool resultGreaterOrEqual = x >= y; // El valor de 'resultadoMayorOIgualQue' será false, ya que x no es mayor o igual que y.

// Operador de menor o igual que (<=)
bool resultLessOrEqualThan = x <= y; // El valor de 'resultadoMenorOIgualQue' será true, ya que x es menor o igual que y.

//Operadores Logicos
bool isStudent = true;
bool hasDiscount = false;
int age = 20;

// AND operador (&&)
bool isEligibleForDiscount = isStudent && age < 25; // El valor de 'esElegibleParaDescuento' será true, ya que se cumplen ambas condiciones.

// OR operador (||)
bool isEligibleForSpecialOffer = isStudent || hasDiscount; // El valor de 'esElegibleParaOfertaEspecial' será verdadero, ya que se cumple al menos una condición.

// NOT operador (!)
bool isNotEligibleForDiscount = !isEligibleForDiscount; // El valor de 'noEsElegibleParaDescuento' será false ya que el valor de 'esElegibleParaDescuento' es true.
