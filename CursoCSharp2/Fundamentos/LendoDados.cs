using System;
using System.Globalization;


// O system.globalization faz com que o ponto seja separador das casas decimais. Além de incluir o system, tem que incluir
// o "CultureInfo.InvariantCulture".

namespace CursoCSharp.Fundamentos {
    internal class LendoDados 
        {
        public static void Executar () {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            // Ocorrerá a alteração disso: "1" para 1

            Console.Write("Qual é o seu salário?");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");

        }
    }
}
