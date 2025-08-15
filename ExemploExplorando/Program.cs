using ExemploExplorando.Models;
using System.Globalization;
using Models;
using Newtonsoft.Json;
using System.Transactions;

MeuArray<int> meuArray = new MeuArray<int>();
meuArray.AdicionarElementoArray(30);
Console.WriteLine(meuArray[0]);

MeuArray<string> arrayString = new MeuArray<String>();
arrayString.AdicionarElementoArray("teste");

Console.WriteLine(arrayString[0]);



















// dynamic variavelDinamica = new

// Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}");













// string conteudoArquivo = File.ReadAllText("Arquivos/Vendas.json");

// List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo)!;

// var listaAnonimo = listaVendas.Select(venda => new
// {
//     venda.Id,
//     venda.Produto,
//     PrecoFormatado = venda.Preco.ToString("C", CultureInfo.CurrentCulture),
//     DataVenda = venda.DataVenda.ToString("dd/MM/yyyy HH:mm"),
//     Desconto = venda.Desconto.HasValue ? venda.Desconto.Value.ToString("C", CultureInfo.CurrentCulture) : "Sem desconto"
// });

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.PrecoFormatado}, Data da Venda: {venda.DataVenda}, Desconto: {venda.Desconto}");
// }
































// var tipAnonimo = new { Nome = "Nivaldo",sobreNome = "Rodrigues", altura = 1.67, Idade = 30 };

// Console.WriteLine($"Nome: " + tipAnonimo.Nome);
// Console.WriteLine($"Sobrenome: " + tipAnonimo.sobreNome);
// Console.WriteLine($"Altura: " + tipAnonimo.altura);
// Console.WriteLine($"Idade: " + tipAnonimo.Idade);





















// string conteudoArquivo = File.ReadAllText("Arquivos/Vendas.json");

// List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo)!;

// foreach (var venda in listaVendas)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data da Venda: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}"
//         + (venda.Desconto.HasValue ? $", Desconto: {venda.Desconto.Value.ToString("C", CultureInfo.CurrentCulture)}" : ""));
// }









// bool? desejaReceberEmail = null;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário deseja receber e-mails.");
// }
// else 
// {
//     Console.WriteLine("O usuário não deseja receber e-mails.");
// }




































// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00m, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00m, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// Directory.CreateDirectory("Arquivos");
// File.WriteAllText ("Arquivos/Vendas.json", serializado);

// Console.WriteLine(serializado);



























// Dictionary<int, string> estados = new Dictionary<int, string>();

// estados.Add(1, "Acre");
// estados.Add(2, "Alagoas");
// estados.Add(3, "Amapá");
// estados.Add(4, "Amazonas");

// Console.WriteLine(estados[3]);






















// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove(2);
// estados[3] = "Novo Amapá";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "3";
// Console.WriteLine($"Valor existente: {chave}: {estados[int.Parse(chave)]}");

// if (estados.TryGetValue(4, out string valor))
// {
//     Console.WriteLine($"Valor encontrado: {valor}");
// }
// else
// {
//     Console.WriteLine("Chave não encontrada.");
// }






















// Stack<int> pilha = new Stack<int>();
// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removento o elemento do topo: { pilha.Pop()}");

// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }





















//Queue<int> file = new Queue<int>();

//file.Enqueue(2);
//file.Enqueue(4);
//file.Enqueue(6);
//file.Enqueue(8);

//foreach (int item in file)
//{
//Console.WriteLine(item);
//}

//Console.WriteLine($Removendo o elemento: { file.Dequeue()};
//file.Enqueue(10);

//foreach (int item in file)
//{
//    Console.WriteLine(item);
//}



















//new ExemploExcessão().Metodo1();



















//try
//{
// string[] linhas = File.ReadAllLines("arquivos/arquivoLeitura.txt");

//foreach (string linha in linhas)
//{
// Console.WriteLine(linha);
// }

//} catch (Exception ex)
//{
//Console.WriteLine($"Ocorreu um erro: {ex.Message}");
//}
























//decimal valorMonetario = 82.40m;

//Console.WriteLine($"Valor monetário: {valorMonetario:C}");























//string numero1 = "10";
//string numero2 = "20";

//string resultado = numero1 + numero2;

//Console.WriteLine($"Resultado da concatenação: {resultado}");

















//Pessoa p1 = new Pessoa(nome:"Nivaldo",sobrenome: "Rodrigues");
//Pessoa p2 = new Pessoa(nome:"João",sobrenome: "Silva");

//Curso CursoDeInlglês = new Curso();
//CursoDeInlglês.Nome = "Curso de Inglês";
//CursoDeInlglês.Alunos = new List<Pessoa>();

//CursoDeInlglês.AdicionarAluno(p1);
//CursoDeInlglês.AdicionarAluno(p2);
//CursoDeInlglês.ListarAlunos();

Pessoa p1 = new Pessoa(nome: "Nivaldo", sobrenome: "Rodrigues", idade: 30);