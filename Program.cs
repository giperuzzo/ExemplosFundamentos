// See https://aka.ms/new-console-template for more information
// é nesse arquivo que vamos programar  cs significa c#
using System.Collections;
using System.Reflection.Metadata;
using ExemplosFundamentos.Models; 

// 13- ARRAY(matriz ou vetor) = é uma estrututa de dados que armazena varios valores do mesmo tipo, com um tamanho fixo. sintaxe: 
// int[] array = new int[4]; 4 indica qtde de posições total
// int[] array int[]{42,75,74,61}; valor das posições 
// string[] nomes= {"Jan, Fev"}; array de string
// indice do array, é a posição de um determinado valor de um array, sempre começando por 0. exemplo de como acessar um elemento no array .
// int elemento - array[0];
// array[0] = 42; conforme exemplo da lista

// trabalhando com listas: em uma lista nao precisamos passar uma capacidade ela trabalha internamente com o array
// sintaxe de uma lista : List<string> listaString = new List<string>();
// .count verifica o tamanho do array na classe list
// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");
// mostrando a vantagem de usar lista ao inves de array, segue exemplo se precisarmos aumentar o tamanho do array nao teremos que redimensionar o tamanho e sim usar os metodos add e remove(ele automaticamente redimensionou o tamanho do array (* multiplicando por 2) sempre que possivel trabalhe com lista.

// Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");
// Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");
// Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


// como percorrer uma lista podemos usar o for ou o foreach, segue exemplo:
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição nº {contador} - {listaString[contador]}");
// }

// porém é mais recomendado percorrer com o foreach
// int contadorForEach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição nº {contadorForEach} - {item}");
//     contadorForEach++;
// }
// Implementando um array de inteiro  o .length vai retornar a qtde de posições no array e percorrendo o array, mebrando que se informarmos uma numero de array maior que o declarado o codigo quebra e gera uma exceçao



// int[] arrayInteiros = new int[3];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
//  como copiar um array para outro array em teoria é fazer o que o resize faz
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// redimensionamento de array, ele nassce e morre com a capacidade declarada, porem podemos redimensionar usando a classe Array(Com letra maiuscila com o metodo Resize) por baixo dos panos, ele copia os dados do array antigo e redimensiona através da classe Array metodo resize sintaxe Array.Resize(ref arrayInteiros através do ref
// exemplo:
// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
// Como percorrer os valores do nosso array. Usaremos os laços de repetição
// percorrendo o array com o laço For ele lança tambem o contador
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//    Console.WriteLine($"Percorrendo o array com for {contador} = {arrayInteiros[contador]}");
// }
// Percorrendo um array com FOREACH sintaxe mais simples e usamos qdo nao precisamos de contador
// foreach(int valor in arrayInteiros)
// {
//    Console.WriteLine($"Percorrendo o array com FOREACH {valor}");
// }
// arrayInteiros[3] = 6; vai quebrar o código pois o array so tem 3 posições nesse caso temos que redimensionar o array



// ******ESTRUTURA DE REPETIÇÃO CONHECIDO COMO UM LAÇO DE REPETIÇÃO.( UM LACO DE REPETIÇÃO É UMA EXECUÇÃO REPETIDAS VEZES, SEMPRE QUE ELE TERMINA ELE VERIFICA NOVAMENTE A CONDIÇÃO ATE ELE SER FALSE) segue o exemplo de uma tabuada x=10 e criamos uma variavel inteira contador, aqui chamaremos de CONT = 0 , o laço de repetição vai ficar preso até qdo o contador passar a ser false e o programa encerra. exemplo de UMA TABUADA do 5

// Construindo um menu interativo usando o while "Cadastro"  Environment.Exit(0);ele encerra o programa
// REFATORAÇÃO, QUE UMA LINHA SE EXECUTE FORA DO {} AO INVES DE  Environment.Exit(0);
// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//    // Console.Clear(); para não ficar repitindo as opções
//    Console.WriteLine("Digite a sua opção");
//    Console.WriteLine("1 - Cadastrar Cliente");
//    Console.WriteLine("2 - Buscar cliente");
//    Console.WriteLine("3 - Apagar Cliente");
//    Console.WriteLine("4 -Encerrar");

//    opcao = Console.ReadLine();

//    switch(opcao)
//    {
//       case "1":
//       Console.WriteLine("Cadastro de Cliente");
//       break;

//       case "2":
//       Console.WriteLine("Busca de Cliente");
//       break;

//       case "3":
//       Console.WriteLine("Apagar Cliente");
//       break;

//       case "4":
//       Console.WriteLine("Encerrar");
//       // Environment.Exit(0); para sair do programa sair de vdd é interessante colocar uma variavel bool para exibir o encerrar programa
//       exibirMenu = false;
//       break;

//       default:
//       Console.WriteLine("Opção inválida");
//       break;
//    }

// }
// Console.WriteLine("O programa se encerrou");

// Do While, extensão do while porem sua verificação é executada no final do código ele vai executar independente da condição. sintaxe
// do{

// }while(true);

// exemplo, pediamos ao usuária para digitar alguns numeros consecutivos, porem qdo digitar 0 saia do pragrama e mostre a somatoria dos numeros informados pelo usuário. (Podemos declarar variaveis na mesma linha desde que sejam do mesmo tipo)  != significa diferente
// console.readline, pede pro usuario digitar e apertat o enter porém ele não funciona no terminal para o debug para isso teremos que abrir na pasta do vscode o arquivo launch.json e mudar o nome do console para integratedTerminal

// int soma = 0, numero = 0;


// do
// {
//    Console.WriteLine("Digite um numero(0 para parar)");
//    numero = Convert.ToInt32(Console.ReadLine());
//    soma += numero;
// }while(numero != 0);
// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// EXEMPLO WHILE enquanto a condição for verdadeira ele executa o código cuidado para não cair num looping infinito entao precisamos usar o incremento (importante usando (BREAK) no while ou no for podemos interromper a condição mesmo ela ainda sendo verdadeira
// int numero = 5;
// int contador = 1;

// while(contador <= 10)
// {
//    Console.WriteLine($"{contador} * Execução: {numero} x {contador} = {numero * contador}");
//    contador++;

//    if(contador == 5)
//    {
//       break;
//    }
// }




// exemplo FOR ele vai se repetir até que a condição se torne falsa
// int numero = 5;
// // implementando o laço de repetição  FOR tem a sintaxe "delcaração da variável, a condição e o incremento
 
//  for(int contador = 0; contador <=10; contador++ )
//  {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//  }

// aula sobre operadores em c# 

// usando potencia no C# usando a classe Math 

// FUNÇÕES TRIGONOMÉTRICAS SENO COSENO E TANGENTE USAREMOS A CLASSE MATH

// calculando raiz quadrada usando a classe Math usando Math.sqrt




// operadores aritmeticos e a class math, são os ooeradores da matematicas que usamos para fazer as operações no programa e a classe MATH que possibilita fazer operações mais complexas - sintase x=y, x-y operadores aritmeticos  +, - adição e subtração, semelhante a matemática,  *, multiplicação, / divisão x*y, x/y,  % Modulus que significa o resto da divisão  x%y ele retorna o resto da divisão, ++ incremento x++, -- decremento x--
// para calcular seno coseno e tangente usamos a classe math e temos que antes calcular o radiano que é angulo.pi/180

// incremento e decremento de uma variável numérica ++ -- sintaxe correta

// int numeroIncremento = 10;
// Console.Write(numeroIncremento);
// Console.WriteLine("Incrementando o 10");
// numero = numero + 1; ou com menos codigo da forma abaixo
// numeroIncremento ++;

// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20");
// numero = numero - 1; ou com menos linha de codigo da forma abaixo
// numeroDecremento --;

// Console.Write(numeroDecremento);


// Calculadora calc = new Calculadora();
// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);

// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);


// Operadores lógicos

// NOT = ! não ele tem o objetivo de negar o operador boleano, se for true e false e se or false é true, o exemplo de cenario é o seguinte, quero andar de bike, choveu?vou pedalar outro dia, não choveu(nao) está tarde(não)então vou pedalar segue código
// o if sempre espera que seja verdadeiro por isso usamos a negação ou seja o !

// bool choveu = false;
// bool estaTarde = false;

// if(!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else 
// {
//     Console.WriteLine("Vou pedalar em outro dia");
// }

// AND = e &&  todas a condições precisam ser verdadeira pra ele rodar. No exemplo aprovação de um aluno temos a seguinte situação pra ser aprovado ele tem que ter nota maior que 7 e presença mínima, se uma das condições for diferente ele não aceita. operador AND na prática:

// bool possuiPresencaMinima = true;
// double media = 7.2;

// if(possuiPresencaMinima && media >= 7){
//     Console.WriteLine("Aluno Aprovado");
// }
// else 
// {
//     Console.WriteLine("Aluno Reprovado");
// }




// OR = ou (Pipe||) usado para verificar mais que uma condição exemplo prático maioridade

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel )
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }

// OPERADORES CONDICIONAIS, IF,ELSE,SWITCH,CASE

// operadores condicionais SWITCH CASE: é um tipo de operador usado em situações que temos muitos caminhos possíveis, segue exemplo: vamos montar um programa onde quero descobrir se a letra que estou escrevendo é uma vogal ou não?
//  O switch é uma alternativa qdo se tem um in aninhando ele funciona com um if e o defaut seria o else, temos que usar a palavra break para parar o codigo caso não usarmos entraremos no looping
// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//     Console.WriteLine("Não é uma vogal");
//     break;

// }




// Definição de Operador Condicional: O operador condicional possibiluta mudar o fluxo de execução de ser código(tomada de decisão), indicando um caminho que ele deve percorrer tomar decisões. exemplo: se vou tomar cafe e a caneca esta vazia entao vou levantar e colocar mais café, senão nao levanto e tomo meu café. outro exrmplo: peça pra o usuario digitar o email se(if)o email for válido siga para o cadastro, senao(else) bloqueia o cadastro e informa ao usuário "email invalido" 
// exemplo: sistema de e-commerce onde vc precisa verificar se vc tem a quantidade solicitada em estoque, caso vc tenha vc pode realizar a venda, caso contrario vc informa que no momento não tem em estoque, (código)
// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// condição
// exemplo executado só o if com quantidade de estoque  10

// if(possivelVenda){
//     Console.WriteLine("Venda realizada");
// }

// imprimindo o else com quantidade de estoque 3
// else {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }

// if aninhado

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// // criando comparação para nao aceitar qtde de vendas 0
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// condição


// validando uma compra qtde 0 retornando menssagem usando if aninhado colocando mais uma condição
// if (quantidadeCompra == 0) {
//     Console.WriteLine("Venda Inválida");
// }
// // exemplo executado só o if com quantidade de estoque  10
// else if(possivelVenda){
//     Console.WriteLine("Venda realizada");
// }


// // imprimindo o else com quantidade de estoque 3
// else {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }





// ordem dos operadores
// em c# os operadores tambem segue a mesma regra das operações matematicas, ou seja / * primeiro e depois +- caso eu queria resolver primeiro as adicionais e subtrações usasmos (), pq assim como tb na matematica o que tem dentro dos parenteses é priorizado eresolvido primeiro
// no exemplo abaixo priorizando /
// double a = 4/2+2;
// exemplo de priorizando() independente do operador que estiver 
// double a = 4 / (2+2);
// Console.WriteLine(a);

// Ainda sobre cast/casting convertendo dados

// Convertendo de maneira segura

// No caso de conversão de string para inteiro considerando que possa haver algum erro e não parar o programa a forma segura de fazer a conversão é usar o TryParse (ele funciona como se ja tivesse a possibilidade de erro de informe e considera o valor atribuido a variavel que foi pedido a conversão, assim não encerrando o programa, veja exemplo:)
// string a = "15-";

// // int b = 0;

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");


// casting implicito = vc nao precisa fazer a conversão pq ele mesmo faz a conversão 
// esse é processo onde o double representa um numero decimal e um inteiro (suporta) cabe no double, ou seja se os tipos de variáveis se encaixam um no outro náo é necessário fazer a conversão (double suporta int), (long suport int) agora int nao suporta long e int tb não suporta double então vc precisa realizar a conversão de forma manual

// exemplo de casting implicito
// int a = 5;
// double b = a;
// Console.WriteLine(b);
// maxValue significa o numero maximo de long 

// exemplo de casting manual
// long a = 5;
// int b = Convert.ToInt32(a);
// Console.WriteLine(b);


// Conversão de String 
// Não tem Parse nesse caso e o Convert é retundante pq existe uma clase generica no C# cha,ada objet que tem o ToString e é muito comum o uso de ToString  portanto para converter inteiro em string usamos o toString
// int inteiro = 5;

// string a = inteiro.ToString ();

// Console.WriteLine(a);

// diferença entra Convert(é uma classe) e Parse quando usar 
// 
// 
// então é preferivel voce usar o Convert pq ele nao encerra o programa

//  int a = Convert.ToInt32(null);
//  O Convert vai tratar valores nulos e vai retornar o valor 0

// int a = int.Parse(null); O Int.Parse não trata valores nulos e vai gerar uma exceção e encerrar o programa 






// como converter no exemplo abaixo string para inteiro  (operação tem um certo risco)
// cast ou casting

// int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// int a = int.Parse("5c"); não vai compilar pois 5c não é um inteiro
// o Parse pode ser representado por todos os tipor de variavel pode ser decimal.parse int.decimal double.parse ou usar  Convert e nem sempre vc não vai conseguir pq vc nao sabe o que vc vai receber e vai dar um erro de exceção

// Console.WriteLine(a);



// exemplo abaixo mostrando o operador de atribuição "=" ele atribui e modifica uma variável

// int a = 10;
// int b = 20;

// int c = a + b;

// // c = c + 5;
// // posso escrever tb como o escrito abaixo, posso também subtrair (-) multiplicar (*) dividir(/)
// c -=5;

// Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/mm/yyyy"));





// string apresentacao = "Olá seja bem-vindo";

// int quantidade = 1;
// quantidade = 10;

// double altura = 1.80;

// decimal preco = 1.00m;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("valor da variável quantidade: "  + quantidade);
// Console.WriteLine("valor da variável altura : " + altura.ToString(".00"));
// Console.WriteLine("valor da variável preço : " + preco);
// Console.WriteLine("valor da variável condição : " + condicao);

// Pessoa pessoa1 = new Pessoa();
// // atributo
// pessoa1.Nome = "Buta";
// pessoa1.Idade = 26;
// // método(função,ação)
// pessoa1.Apresentar();

// padroes e convenções
// variavel com camelCase 
// não pode ter caracteres especiais nas variaveis o unico é o _ underline, não aceita traço- 