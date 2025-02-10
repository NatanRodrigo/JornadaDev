namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("#######################################");
            Console.WriteLine("Sistema para calcular médias de provas");
            Console.WriteLine("#######################################");
            Console.WriteLine(Environment.NewLine + Environment.NewLine);

            var notas = new List<decimal>();
            while (true)
            {
                Console.WriteLine("Digite uma nota de prova, ou escreva PARE para finalizar o cadastro de notas.");
                var respostaUsuario = Console.ReadLine();

                if(respostaUsuario.Trim().ToUpper() == "PARE")
                    break;

                notas.Add(Convert.ToDecimal(respostaUsuario));
            }

            decimal somaNotas = 0;
            foreach (var nota in notas)
            {
                somaNotas += nota;
            }

            Console.WriteLine("A média da turma foi: " + somaNotas / notas.Count());
        }
    }
}
