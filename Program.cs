// 1

/* Console.WriteLine("Digite seu nome:");
string? nome = Console.ReadLine();

Console.WriteLine($"Olá, {nome}! Seja muito bem vindo!") */


// 2

/* using System.Text;

Console.WriteLine("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

StringBuilder sb = new StringBuilder();
sb.Append(nome);
sb.Append(" ");
sb.Append(sobrenome);

Console.WriteLine(sb.ToString()); */


// 3

/* using Exercicios;

Calculadora c = new Calculadora();
c.ExibirContas(4, 2); */


// 4

/* Console.WriteLine("Digite alguma(s) palavra(s)");
string? resultado = Console.ReadLine();

Console.WriteLine("Número de caracteres: " + resultado.Length); */


//5

/* using System.Text.RegularExpressions;

Console.WriteLine("Digite a sua placa: ");
string? Placa = Console.ReadLine();

string pattern = @"^[a-zA-Z]{3}-?\d{4}$";

Regex regex = new Regex(pattern);

if (regex.IsMatch(Placa))
{
    Console.WriteLine("Placa válida!");
} else
{
    Console.WriteLine("Placa inválida!");
} */


// 6

/* DateTime diaAtual =  DateTime.UtcNow;

Console.WriteLine(diaAtual.ToLongDateString() + " "  + diaAtual.ToLongTimeString());
Console.WriteLine(diaAtual.ToShortDateString());
Console.WriteLine(diaAtual.Hour + " horas");
Console.WriteLine(diaAtual.ToLongDateString()); */
