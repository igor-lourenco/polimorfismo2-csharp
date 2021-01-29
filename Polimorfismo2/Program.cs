using Polimorfismo2.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Polimorfismo2 {
    class Program {
        static void Main(string[] args) {

            List<Produto> lista = new List<Produto>();

            Console.Write("Digite o numero de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write("Comum, Usado ou Importado (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'i') {
                    Console.Write("Taxa Alfandega: ");
                    double taxaAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoImportado(nome, preco, taxaAlfandega));
                }
                else if(ch == 'u') {
                    Console.Write("Dada de fabricacao (DD/MM/YYYY): ");
                    DateTime dataManufaturado = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome, preco, dataManufaturado));
                }
                else {
                    lista.Add(new Produto(nome, preco));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRECO DOS PRODUTOS: ");
            foreach (Produto prod in lista)
                Console.WriteLine(prod.PrecoEtiqueta());
        }
    }
}
