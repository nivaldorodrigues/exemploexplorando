# ExemploExplorando

Este repositório contém exemplos de código em C# para estudos de conceitos fundamentais da linguagem, incluindo:

## Estrutura do Projeto

- **Models/**  
  Contém classes de domínio como `Pessoa`, `Venda` e exemplos de tratamento de exceções.

- **Program.cs**  
  Arquivo principal com exemplos de uso das classes, manipulação de arquivos, serialização JSON, tipos anônimos, dicionários, tipos dinâmicos e controle de fluxo.

## Principais Exemplos

### 1. Classe Pessoa
Demonstra encapsulamento, propriedades, validação de dados e métodos de apresentação.

### 2. Serialização e Desserialização JSON
Exemplo de como salvar e ler listas de objetos (`Venda`) em arquivos JSON usando a biblioteca `Newtonsoft.Json`.

### 3. Tratamento de Exceções
Classe `ExemploExcecao` mostra como lançar e capturar exceções em métodos encadeados.

### 4. Tipos Dinâmicos e Anônimos
Exemplos de uso de `dynamic` e criação de tipos anônimos para manipulação flexível de dados.

### 5. Dicionários
Uso de `Dictionary<int, string>` para armazenar e manipular pares chave-valor.

### 6. Nullable Types
Exemplo de uso de tipos anuláveis (`bool?`) e checagem de valor.

## Como Executar

1. Clone este repositório:
   ```
   git clone https://github.com/seu-usuario/ExemploExplorando.git
   ```
2. Abra a solução no Visual Studio ou VS Code.
3. Restaure os pacotes NuGet (especialmente `Newtonsoft.Json`).
4. Compile e execute o projeto.

## Observações

- Certifique-se de que a pasta `Arquivos` existe antes de executar exemplos que leem ou escrevem arquivos.
- Os exemplos estão comentados em `Program.cs`. Descomente os blocos que deseja testar.
- O projeto é voltado para fins didáticos e explora diversos recursos da linguagem C#.

---

Bons estudos!
