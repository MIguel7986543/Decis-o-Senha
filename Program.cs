Console.Clear();
string senhaDigitada;
string senhaEsperada = "123456";

Console.WriteLine("Digite sua senha:");
senhaDigitada = Console.ReadLine()!;

if (senhaDigitada == senhaEsperada)
{
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(" Senha correta");
}
else
{  
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Senha errada");
}
Console.ResetColor();