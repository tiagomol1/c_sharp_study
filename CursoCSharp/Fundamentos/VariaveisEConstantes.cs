using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415

            double area = raio * raio * PI;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario: " + salario);

            int menorValorInteiro = int.MinValue; // Mais usados dos inteiros
            Console.WriteLine("Menor valor do inteiro: " + menorValorInteiro);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador: " + precoComputador);

            Double valorDoMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor do mercado da Apple: "+ valorDoMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as estrelas: " + distanciaEntreEstrelas);

            char letra = 'a';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao curso de C Sharp!";
            Console.WriteLine("Texto: " + texto);
        }
    }
}
