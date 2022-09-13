using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Introducao
    {
        public static void Executar() {

            //----- CLASSES vs OBJETO -----

            // class = tipo de variável (bool, int, string, double etc.)
            // int a = 3. Int (tipo da variável); a é o identificador da variável; e o 3 é o valor da variável.

            // Exemplo:
            // Você criou uma " class Pessoa "
            // Significa que seguindo a mesma lógica do int a = 3, eu posso
            // também criar uma variável do tipo da classe que eu criei, pq
            // a classe é um tipo
            // Então, por exemplo: você pode criar " Pessoa p = ... "
            // Ou seja, o tipo de uma variável é o tipo de uma classe. Isso é
            // possível você fazer. 
            // Exemplo:
            // class Pessoa { }   - o que eu teria dentro desse bloco de códigos?

            // Dentro de uma class existem duas coisas: os ATRIBUTOS (ou seja,
            // são os dados da classe) e os COMPORTAMENTOS.

            // Os comportamentos são os métodos.

            // Em suma: Os ATRIBUTOS são os dados e os COMPORTAMENTOS são os algoritmos.

            // Os algoritmos são os meus métodos, as funcionalidades. É um algoritmo que vai fazer um tratamento, manipular os dados
            // receber os dados como entrada, fazer processamentos, que tem mais a ver com verbo (ação).

            // E os Atributos tem mais a ver com os dados de um determinado tipo personalizado que eu criei. No caso aqui, 
            // o tipo " Pessoa ".

            // Então, da mesma forma que na vida real os objetos possuem atributos e comportamentos, uma classe que mapeia um tipo personalizado
            // seu, uma estrutura de dados que você criou, vai ter os comportamentos, que vão ser os métodos, e vão ter os atributos que vão ser
            // os dados. 

            //Então, qual é a relação que existe entre classe (que é um tipo) e um objeto? A classe define um molde, digamos assim.

            // Exemplo:
            // Imagine uma classe chamado " Data "
            // Data, a priori, vai ter 3 atributos, quais sejam, "dia", "mês" e "ano". Todos os três são do tipo " int ".

            // Quando você, a partir de um tipo que você definiu dentro de uma classe, você usa um operador chamado o " new " para criar um novo objeto
            // usando essa classe como modelo, o objeto criado vão ter os mesmos atributos e os mesmos comportamentos que foram definidos dentro da classe

            // Ou seja, a classe é como se fosse a planta de determinada casa. Imagine um cond. de casas no qual existam 30 casas para serem construídas
            // em cima de uma mesma planta. Você usa planta, constrói a primeira casa, usa a mesma planta, constrói a segunda e assim sucessivamente.

            // A classe é a planta. Define quais são os atributos e quais são os comportamentos.

            // O que varia entre um objeto e outro são os dados. Quando você cria um new e cria um novo objeto em cima disso.

            // ------ MÉTODOS ------

            // Normalmente, os métodos começam com letra maiúscula usando a notação PascalCase, ou seja, cada palavra tem a letra maiúscula começando com letra
            // maiúscula. Por exemplo:

            // " int Somar(int a,int b) {

            // return a + b;
            
            // Convenção: quando um atributo é utilizado dentro da classe se utiliza a primeira letra maiúscula, como o exemplo acima: "Idade", "Nome". 
            
            // Convenção: quando um atributo é utiliszado dentro de um método se utiliza todas as letras minúsculas como nos demais exemplos em fundamentos e estr. de controle. 
            
            // PAREI EM MEMBROS E ATRIBUTOS


        }
    }
}

