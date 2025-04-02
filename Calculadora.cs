namespace Exercicios;
internal class Calculadora
{
    private void Soma(double n1, double n2)
    {
        Console.WriteLine("Soma: " + (n1 + n2));
    }

    private void Substracao(double n1, double n2)
    {
        Console.WriteLine("Substração: " + (n1 - n2));
    }

    private void Multiplicacao(double n1, double n2)
    {
        Console.WriteLine("Multiplicação: " + (n1 * n2));
    }

    private void Divisao(double n1, double n2)
    {
        if(n2 == 0)
        {
            Console.WriteLine("Não é possível dividir por 0");
        } else
        {
            Console.WriteLine("Divisão: " + (n1 / n2));
        }
    }

    private void Media(double n1, double n2)
    {
        Console.WriteLine("Média: " + ((n1 + n2) / 2));
    }

    public void ExibirContas(double n1, double n2)
    {
        Soma(n1, n2);
        Substracao(n1, n2);
        Multiplicacao(n1, n2);
        Divisao(n1, n2);
        Media(n1, n2);
    }
}
