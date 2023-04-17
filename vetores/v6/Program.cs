﻿// Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

string[] nomes = new string [10];
string nomePesquisa;
bool encontrou = false;

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Insira um nome: ");
    nomes[i] = Console.ReadLine();
}

Console.WriteLine($"Pesquise um nome: ");
nomePesquisa = Console.ReadLine();

for (int i = 0; i < nomes.Length; i++)
{
    if (nomePesquisa == nomes[i])
    {
        encontrou = true; 
        break;
    }
}

if (encontrou == true)
{
    Console.WriteLine($"ACHEI");
}
else
{
    Console.WriteLine($"NÃO ACHEI");
}

//Poderia ser feito com contains: if (nome.Contains(nomePesquisa))