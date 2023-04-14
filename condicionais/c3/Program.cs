// Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:

// Se quantidade <= 5 o desconto será de 2%
// Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// Se quantidade > 10 o desconto será de 5%

// Dica: utilize if / else if / else

Console.WriteLine($"Digite o nome do produto: ");
Console.ReadLine();

Console.WriteLine($"Digite a quantidade: ");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o preço: ");
float preco = float.Parse(Console.ReadLine());

if (quantidade <= 5)
{
    Console.WriteLine($"Seu desconto será de 2%, saindo de R${quantidade * preco} para R${quantidade * (preco -(preco * 0.02))}");
}
else if (quantidade <= 10)
{
    Console.WriteLine($"Seu desconto será de 3%, saindo de R${quantidade * preco} para R${quantidade * (preco -(preco * 0.03))}");
}
else
{
    Console.WriteLine($"Seu desconto será de 5%, saindo de R${quantidade * preco} para R${quantidade * (preco -(preco * 0.05))}");
}