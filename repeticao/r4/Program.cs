// Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido.

int valorMaior = 0;
int valorMenor = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Insira um valor: ");
    int valor = int.Parse(Console.ReadLine());
    
    if (i==1)
    {
        valorMaior = valor;
        valorMenor = valor;
    }
    else
    {
        if (valor > valorMaior)
        {
            valorMaior = valor;
        }
        else if (valor < valorMenor)
        {
            valorMenor = valor;
        }
    }
}

Console.WriteLine($"O maior valor corresponde a {valorMaior} e o menor valor corresponde a {valorMenor}");
