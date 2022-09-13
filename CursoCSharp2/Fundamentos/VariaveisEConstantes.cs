using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia 
            double raio = 4.5;
            const double PI = 3.14; // colocando o const na frente faz com que esse identificador não possa mais ser alterado durante todo seu algoritmo.

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + (area + 1000));

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);
            // o mesmo seria para o "false"

            byte idade = 45;
            Console.WriteLine("Idade " + idade);
            /*Os tipos numéricos são: byte, short, int e long. O byte é apenas um byte, ou seja, 8 bits; O short tem 2 bytes;
            o int tem 4 bytes e o long tem 8 bytes. O byte não admite valores negativos.
            
            */
            //Ou seja, a diferença básica é a capacidade de armazenamento;
            /*Usar quaisquer desses tipos numéricos não fará diferença no programa. A não ser que seja um programa específico que trabalhe
            com milhares de números. Mas um programa comum, o fato de você usar um byte para economizar memória não fará nenhum tipo de
            diferença.
            */
            /*ATENÇÃO!!! Vai se convencionar usar no curso o double para tipos com casas decimais e para os tipos inteiros vai se convencionar
            usar o int.
            */

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor Valor Inteiro " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // int sem sinal
            Console.WriteLine("Populacao Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor do Long " + menorValorLong);

            ulong populationMundial = 7_600_000_000; //long sem sinal
            Console.WriteLine("População mundial " + populationMundial);

            float precoComputador = 1299.99F; // o double tem o dobro da capacidade de armaz. do float. O float tem 4 bytes de armaz. e o double é o dobro do float.
            // Portanto, se você pegar um dado que está no double e colocar dentro do float pode ocasionar perda de informação. Prefirível, portanto, o double.
            Console.WriteLine ("Preço do Computador " + precoComputador);

            double ValorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais;
            Console.WriteLine("Valor de Mercado da Apple " + ValorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância das Estrelas " + distanciaEntreEstrelas);

            char letra = 'b'; // A função char só armazena uma letra.
            Console.WriteLine("Letra " + letra);

            char caractere = '&'; // Utiliza-se para caractere especial também.
            Console.WriteLine ("Caractere Especial " + caractere);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine (texto);
        }
    }
}
