using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}
// sintaxe é o conjunto de regras que vc tem que escerver/usar no c# senão o codigo não compila
// convenção são as boas práticas(padrão),para que seu codigo fique legível para outros programadores (o compilador roda) as convenções podem mudar de linguagem pra linguagem
// padroes e convenções
// nome de classes usar o PascalCase primeira letra maiscula
// nome de propriedade tambem começa em maiuscula
// nome de método primeira letra em maiscula
// não abreviar variaveis, propriedades e classes - 
// nao pode usar caracteres especiais em variáveis
// o arquivo .cs pode ou nao ter  ter o mesmo nome da classe mais é recomendavel que o arquivo tenha o mesmo nome da classe