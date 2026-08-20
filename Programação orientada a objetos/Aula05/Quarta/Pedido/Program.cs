using Pedido.Classes.Entidades;
using Pedido.Classes.Enumeracoes;
using Pedido.Classes.Enumeracoes;


Funcionario dev = new Funcionario("Clodoaldo");
Funcionario gerente = new Funcionario("Elma");

Empresa SENAI = new Empresa("João Baptissta Salles");
Empresa Suzano = new Empresa("Suzano");

Suzano.AdicionarFuncionario(gerente);
Suzano.AdicionarFuncionario(dev);

Suzano = null;