//Declaração de variáveis
double largura;
double comprimento;
double area;
double valor;
double preco;

// Entrada de dados
Console.Write("Digite a largura do terreno: ");
largura = double.Parse(Console.ReadLine());
Console.Write("Digite o comprimento do terreno: ");
comprimento = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do metro quadrado do terreno: ");
valor = double.Parse(Console.ReadLine());


//Processamento de dados
area = largura * comprimento;
preco = area * valor;

//Saida de dados
Console.WriteLine($"A área do terreno é: {area:n}/nPreço do terreno : R$ {preco:n}"); //:n é utilizado para formatação de numeros, exibindo-os com separadores de milhar e duas casas decimais.
                                                                                      // o /n é utilizado para pular uma linha e fazer a separação entre a área e o preço do terreno.