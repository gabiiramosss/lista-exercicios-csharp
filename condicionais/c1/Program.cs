// Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

int anoAtual;
int anoNascimento;

Console.WriteLine($"Insira o ano atual: ");
anoAtual = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira seu ano de nascimento: ");
anoNascimento = int.Parse(Console.ReadLine());

if (anoAtual - anoNascimento >= 16)
{
    Console.WriteLine($"Pode votar!");
}
else
{
    Console.WriteLine($"Muito neném ainda!");
}
