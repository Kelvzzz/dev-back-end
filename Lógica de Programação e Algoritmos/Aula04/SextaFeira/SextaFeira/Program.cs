//Exercício Problema "idades"

//Declaração de variáveis
using System.Threading.Channels;

var nome1 = "SENAI";
var nome2 = "SENAI";
var idade1 = 1;                                             //var = typagem dinâmica, identifica o tipo de dado automaticamente
var idade2 = 2;
var media = 1.73;

// var variaveis = DateTime.Now; ----->     //var = typagem dinâmica que guarda um código dentro da varíavel para não necessitar refazer o código


//Entrada de dados
Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
nome1 = Console.ReadLine();
Console.Write("Idade: ");
idade1 = int.Parse(Console.ReadLine());
Console.WriteLine("Dados da segunda pessoa: ");
Console.Write("Nome: ");
nome2 = Console.ReadLine();
Console.Write("Idade: ");
idade2 = int.Parse(Console.ReadLine());

//Processamento de dados
media = (idade1 + idade2) / 2;

//Saída de dados
Console.WriteLine($"A média das idades de {nome1} e {nome2} é de {media:f1}");                     //f1 = formatação de casas decimais, nesse caso 1 casa decimal