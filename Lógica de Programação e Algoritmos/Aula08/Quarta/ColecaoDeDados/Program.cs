//Coleção de dados
 /* -- Array -- */     
 int[] numeros = { 0, 1, 2, 10, 4 }; // Declaração de um array de inteiros com tamanho 4
string[] names = { "Clodoaldo", "Kelvin", "César" };
Char[] caracteres;
Console.WriteLine(numeros.Length);

Console.WriteLine(numeros[3]);

numeros[3] = 56;
Console.WriteLine(numeros[3]);
caracteres = new char[10]; // Declaração de um array de caracteres com tamanho 10

// NÃO MUDA VALORES, TYPAGEM FIXA E HOMOGEANA E TAMANHO FIXO, NÃO PODE ADICIONAR ELEMENTOS NOVOS, NÃO PODE REMOVER ELEMENTOS EXISTENTES, NÃO PODE MUDAR O TIPO DE DADOS DOS ELEMENTOS EXISTENTES

/* -- Dicionário -- */
Dictionary<string, double>  salarios = new Dictionary<string, double>() // Declaração de um dicionário com chave do tipo string e valor do tipo double 
{
     { "Alice", 1.73 },
    { "Bob", 62.9 },
    { "Clodoaldo", 14 }
}; // O comando add guarda o valor na ultima posição do dicionário, e o valor é guardado na chave correspondente


Console.WriteLine(salarios["Bob"]);
salarios.Add("SENAI", 8.96);
Console.WriteLine(salarios["SENAI"]);
salarios.Remove("Alice");

foreach (var item in salarios)
{
    Console.WriteLine(item.Key + "tem" + item.Value);
}

if (salarios.ContainsKey("Bob")) ;
{
    Console.WriteLine("Bob está na coleção");
}

/* -- Lista -- (Valores tem que ser todos pelo tipo, ou seja int*/
// List é uma coleção de dados que pode crescer e diminuir dinamicamente, diferente do array que tem tamanho fixo
// 

List<int> lista1 = new List<int>();
lista1.Add(5600);
lista1.Add(600);
lista1.Add(0);
lista1.Add(50);
Console.WriteLine(lista1);
foreach ( var item in lista1)
{
    Console.WriteLine(item); // Só colocar a variável ITEM, que é o elemento da lista, e ele vai imprimir o valor do elemento
}

lista1.Insert(2, 900); // Insere o valor 900 no índice 2
lista1.Remove(600); // Só remove o valor 600, nao o indice, somente o valor do dado é removivel

foreach (var item in lista1)
{
    Console.WriteLine(item); 
}

/* -- Tuplas --*/
//  é tamanho fixo, mas permite mudar os valores dos elementos, diferente do array que não permite mudar os valores dos elementos

var pessoa = ("César", 34, 2,5, 'M'); // Declaração de uma tupla com 4 elementos, sendo o primeiro do tipo string, o segundo do tipo int, o terceiro do tipo double e o quarto do tipo char
Console.WriteLine(pessoa.Item1); //Nome
Console.WriteLine(pessoa.Item2); //Idade
Console.WriteLine(pessoa.Item3); //Salario
Console.WriteLine(pessoa.Item4); //Genero
pessoa.Item1 = "Kelvin"; // é possível mudar o valor de uma tupla, pois ela é imutável
var pessoa2 = (Nome: "César", Idade: 35);
