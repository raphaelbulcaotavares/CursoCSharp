using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos 
{
    public class Produto {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1; // Se colocar "public static double Desconto = 0.1", este atributo passará a ser um atributo de class e não mais de instância.

        // Construtor:
        public Produto (string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        //Construtor padrão
        public Produto() {

        }

        //Método que calcula o valor com desconto.
        public double CalcularDesconto() {
            return Preco - Preco * Desconto;

        }
    }

    class AtributosEstaticos 
    {
        public static void Executar () 
        {
            var produto1 = new Produto("Caneta", 3.0, 0.1); // Ou seja, criei um produto caneta, o preco e o desconto de 10%.
            Console.WriteLine($"{produto1.Nome}");
            Console.WriteLine($"{produto1.Preco}");

            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 5.0,
            };

            Produto.Desconto = 0.5;

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
            
           
            Produto.Desconto = 0.05;

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
        }
    }
}
