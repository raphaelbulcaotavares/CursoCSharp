using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum 
    {

        // 1º MÉTODO
        public int Somar(int a, int b) // Atenção! Uma vez que eu diga que o método retorna int, obrigatoriamente, dentro do método eu tenho que ter um return.
            // Método somar + o conjunto de parâmetros.
        {
             return a + b;
        }

        //2ª MÉTODO
        
        public int Subtrair (int a, int b) 
        {
            return a - b;
        }
        
        //3ª MÉTODO

        public int Multiplicar (int a, int b) {
            return a * b;
        }

        //4º MÉTODO

        public int Dividir (int a, int b) {
            return a / b;
        }
    }
    class CalculadoraCadeia {
        int memoria; // Nesse caso, eu vou armazenar o resultado das operações dentro de uma variável (atributo) chamado memória. A "memoria" é uma variável interna da Calculadora
        // cadeira, por isso que não se colocou o public.

        public CalculadoraCadeia Somar (int a) {
            memoria += a; // é a mesma coisa que memoria = memoria + a.
            return this;
            
        }
        public CalculadoraCadeia Multiplicar (int a) {
            memoria *= a;
            return this;

        }
        public CalculadoraCadeia Limpar () {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir () {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado () {
            return memoria;
        }

    }


    internal class MetodosComRetorno
    {
        public static void Executar ()
        {
            var calculadoraComum = new CalculadoraComum(); // Uma vez que eu criei uma instância de calculadora, agora sim eu consigo chamar essas funções.
            
            var resultado = calculadoraComum.Somar(5, 5);
            
            var resultado2 = calculadoraComum.Dividir(25, 5);
           
            Console.WriteLine(resultado);
            
            Console.WriteLine(resultado2);
            
            Console.WriteLine(calculadoraComum.Subtrair(2,7));
            
            Console.WriteLine(calculadoraComum.Multiplicar(4,4));
            
            Console.WriteLine(calculadoraComum.Dividir(25,5));


            Console.WriteLine("______________________");

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            //Outro exemplo:

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);


        }
    }
}
