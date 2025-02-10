using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Fluxo
    {
        public void Executar()
        {
            var numeros = new List<int>();
            var totalNumeros = 15;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Escolha um número inteiro");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Clear();
                Console.WriteLine($"Foi  inserido o {i + 1} número de {totalNumeros} números.");
            }

            foreach(int numero in numeros)
            {
                if(numero > 0)
                    Console.WriteLine("O número " + numero + " se trata de um número positivo");
                
            }
            
        }
    }
}
