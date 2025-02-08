namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos tipo de produtos você deseja calcular o lucro:");
            int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

            string[] nomesProdutos = new string[quantidadeProdutos];
            decimal[] Lucros = new decimal[quantidadeProdutos];

            // Coletando as informações
            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.Clear();
                Console.WriteLine("Qual o nome do tipo de produto?");
                nomesProdutos[i] = Console.ReadLine();

                Console.WriteLine("Quantas unidades foram vendidas?");
                int quantidades = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual o preço da compra??");
                decimal precosCompra = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Qual o preço da venda??");
                decimal precosVenda = Convert.ToDecimal(Console.ReadLine());

                Lucros[i] = (precosVenda - precosCompra) * quantidades;

            }

            Console.Clear();

            Console.WriteLine("Cada tipo de produto obteve o lucro:" + Environment.NewLine);
            // Imprimindo os tipos de produto com o lucro
            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine("Produto: " + nomesProdutos[i] + " teve um lucro de: R$ " + Lucros[i]);
            }
        }
    }
}
