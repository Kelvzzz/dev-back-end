using System;

//Declaração de variaveis
int totalsegundos, horas, minutos, segundos;

//Entrada de dados
Console.WriteLine("Digite a duração em segundos: ");
totalsegundos = int.Parse(Console.ReadLine());

TimeSpan duracao = TimeSpan.FromSeconds(totalsegundos);

//Processamento de dados
horas = (int)duracao.TotalHours;
minutos = duracao.Minutes;
segundos = duracao.Seconds;

//Saída de dados
Console.WriteLine($"{horas}:{minutos}:{segundos}");

// Timespan serve para cálculo de tempo, como por exemplo, calcular a diferença entre duas datas, ou calcular a duração de um evento. Ele também pode ser usado para formatar a saída de tempo em diferentes formatos, como horas, minutos e segundos.