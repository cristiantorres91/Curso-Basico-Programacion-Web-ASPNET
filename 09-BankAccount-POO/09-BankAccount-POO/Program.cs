

using _09_BankAccount_POO;

// crar una cuenta con saldo de $1000
BankAccount account1 = new BankAccount("John Smith", "123456789", 1000);
// depositar en  account1 $500
account1.Deposit(500);
// retiro de $200 de account1
bool withdrawSuccess = account1.Withdraw(300);
if (withdrawSuccess)
{
    Console.WriteLine("Retiro Exitoso");
}
else
{
    Console.WriteLine("No se pudo realizar el retiro. Fondos insuficientes.");
}

// imprimir saldo de  account1 
Console.WriteLine($"Saldo actual de la cuenta {account1.AccountNumber}: ${account1.CurrentBalance()}");

Console.WriteLine("\n");

// crear cuenta corriente saldo $500, limite de sobregiro $200, y tasa de interes 0.02
CheckingAccount account2 = new CheckingAccount("Jane Doe", "987654321", 500, 200, 0.02m);
// deposito $1000 en account2
account2.Deposit(1000);
// calcular e imprimir intereses en el saldo de  account2
decimal interest = account2.CalculateInterest();
Console.WriteLine($"Interés obtenido: ${interest}");
// retiro de $800  account2
bool withdrawSuccess2 = account2.Withdraw(800);
if (withdrawSuccess2)
{
    Console.WriteLine("Retiro Exitoso");
}
else
{
    Console.WriteLine("No se pudo realizar el retiro. Fondos insuficientes");
}

// calcule e imprima el cargo por sobregiro por $600 en account2
decimal overdraftCharge = account2.CalculateOverdraftCharge(-500);
Console.WriteLine($"Cargo por sobregiro: ${overdraftCharge}");

// imprimir saldo de account2 
Console.WriteLine($"Saldo actual de la cuenta {account2.AccountNumber}: ${account2.CurrentBalance()}");
