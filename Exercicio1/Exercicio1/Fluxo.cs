using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Fluxo
    {
        public void Executar()
        {
            ExibirCabecalho();
            var notas = ColetarNotasProvas();
            CalcularExibirMediaNotas(notas);
  
            
        }
        private void ExibirCabecalho()
        {
            Console.WriteLine("#######################################");
            Console.WriteLine("Sistema para calcular médias de provas");
            Console.WriteLine("#######################################");
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }
        private List<decimal> ColetarNotasProvas()
        {

            var notas = new List<decimal>();

            while (true)
            {
                Console.WriteLine("Digite uma nota de prova, ou escreva PARE para finalizar o cadastro de notas.");
                var respostaUsuario = Console.ReadLine();
                Console.Clear();

                if (respostaUsuario?.Trim().ToUpper() == "PARE")
                    break;

                var seValorCorreto = ValidarSeNumeroDecimalBrasileiro(respostaUsuario);
                if (!seValorCorreto)
                {
                    if (respostaUsuario?.Trim().ToUpper() == "PARE")
                        break;

                    Console.WriteLine("O valor digitado não é valido. Tente novamente! ");
                    continue;
                }

                var nota = Convert.ToDecimal(respostaUsuario);

                if (nota < 0)
                {
                    Console.WriteLine("O valor da nota não pode ser menor do que zero. Tente novamente!");
                    continue;
                }
                    

                notas.Add(nota);
            }

            return notas;
        }
        private bool ValidarSeNumeroDecimalBrasileiro(string? texto)
        {
            if(string.IsNullOrEmpty(texto)) 
                return false;

            if (texto.Contains("."))
                return false;

            var isDecimal = decimal.TryParse(texto, out _);

            if (!isDecimal)
                return false;

            return true;
        }
        private void CalcularExibirMediaNotas(List<decimal> notas)
        {
            decimal somaNotas = 0;
            foreach (var nota in notas)
            {
                somaNotas += nota;
            }

            if (somaNotas > 0)
                Console.WriteLine("A média da turma foi: " + somaNotas / notas.Count);
            else 
                Console.WriteLine("A média da turma foi: " + somaNotas);
        }
    }
}
