using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario pedro = new Funcionario("123456", 2000);
pedro.Nome = "Pedro Malazartes";

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta =  new Diretor("123432", 5000);
roberta.Nome = "Roberta Silva";

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificacoes: " + gerenciador.TotalDeBonificacao);
Console.WriteLine("total de Funcionarios: " + Funcionario.TotalDeFuncionarios);

pedro.AumentarSalario();
roberta.AumentarSalario();
Console.WriteLine("Salario de Pedro: " + pedro.Salario);
Console.WriteLine("Salario de Roberta: " + roberta.Salario);