using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld16
{
    class Program
    {
        // Vetores(Vector):
        // Em programação 'vetor' é o nome dado à arranjos(array) unidimenssionais.
        // Array é uma estrutura de dados:
        // - Homogênea (do mesmo tipo de dado (tudo double ou string, etc))
        // - Ordenada (elementos acessados por meio de posições (0, 1, 2, 3))
        // - Alocada de uma vez só, em um bloco contíguo de memória

        // Vantagens: Acesso imediato aos elementos pela sua posição.
        // Desvantagens: Tamanho fixo e dificuldade para se realizar inserções e deleções.
        static void Main(string[] args)
        {
            // Vetor do tipo struct:
            Console.WriteLine("Digite o tamanho do array");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; //instancia um vetor apontando para o heap na memória (o '[]' indica que é um vetor).

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite uma altura");
                vect[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double average = sum / n;
            Console.WriteLine("Avarage Height: " + average.ToString("F2"));


            // Vetor do tipo class:

            Console.WriteLine("\nDigite o tamanho do vetor: ");
            int x = int.Parse(Console.ReadLine());

            Produto[] produtoVect = new Produto[x]; // Vetor do tipo classe é necessário instanciar cada objeto quando for cria-lo.

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o preço: ");
                double price = double.Parse(Console.ReadLine());
                produtoVect[i] = new Produto { Name = name, Price = price }; // Instanciando cada objeto do tipo class no vetor.
            }

            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += produtoVect[i].Price; // irá somar somente os preços dentro do vetor.
            }

            double avg = soma / x;
            Console.WriteLine("\nAverange price: " + avg.ToString("F2"));

            Console.ReadLine();
        }



    }


}

