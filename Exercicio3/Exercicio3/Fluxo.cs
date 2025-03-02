﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Fluxo
    {
        public void ExecutarFluxo(string idadePessoa)
        {

            var pessoas = new List<Pessoa>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Qual o nome da pessoa?");
                string nomePessoa = Console.ReadLine();

                Console.WriteLine("Qual a idade da pessoa?");
                short idadePessoa = Convert.ToInt16(Console.ReadLine());

                var pessoa = new Pessoa();
                pessoa.Nome = nomePessoa;
                pessoa.Idade = idadePessoa;

                pessoas.Add(pessoa);
            }

            var nomePessoaMaisVelha = "";
            var ultimaIdadeMaisVelho = -1;

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Nome: " + pessoa.Nome + " Idade: " + pessoa.Idade);

                if(ultimaIdadeMaisVelho < pessoa.Idade)
                {
                    ultimaIdadeMaisVelho = pessoa.Idade;
                    nomePessoaMaisVelha = pessoa.Nome;
                }
            }

            Console.WriteLine("O mais velho de todos é: " + nomePessoaMaisVelha + " Idade: " + ultimaIdadeMaisVelho);

        }
    }
}
