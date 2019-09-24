using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas.Controllers;
using ListandoPessoas.Model;



namespace ListandoPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui carregamos nossa caixa de ferramentas pessoa podemos listar agora as demais funcionalidades
            PessoaController pessoaController = new PessoaController(); //(depois do =)nessa parte ao iniciar em memoria Iniciamos o Construtor

            //usamos o FOrEach para percorreri a lista
            pessoaController.ListaDePessoasPublica.ForEach(i => MostraInformacoes(i)); //criamos a variavel i para rceber o item da nossa lista
            //imprimimos a informacao de cada item em nossa lista 

            MostraIdentificador("Lista ordenada por nome");

            pessoaController.GetPessoasOrdenadaAsc().ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Ordem Crescente nascimento");

            pessoaController.GetPessoasOrdenadasDescPelaDataNascimento().ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Ordem Decrescente");

            pessoaController.GetPessoasComMaisPilasNaCarteira().ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Ordem por pilas na carteira");

            pessoaController.GetPessoasComIdadeMaiorA(18).ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Ordem por Idade maiores de 18");

            pessoaController.GetPessoasComIdadeMenorQue(16).ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Ordem por Idade menores de 16");

                                                  
            Console.ReadKey();          
         
                     
        }
        
        private static void MostraIdentificador (string nomeAcao)
        {
            Console.WriteLine(string.Format("------{0,20}--------", nomeAcao));
        }

        /// <summary>
        /// Metodo que mostra no console formatado nosso objeto "Pessoa"       
        /// </summary>
        /// <param name="pessoa">Objeto Pessoa que vamos apresentar<param>
        private static void MostraInformacoes (Pessoa pessoa)
        {
            ///Nosso template que apresenta as informações bonitinhas
            string template = "id {0,-3} Nome {1,-10} Nascimento {2,10} Carteira {3,5}"; ///primeira casa referente a variavel e 2º formatacao
            ///Recebemos as informações bonitinhas com sttring format
            string textoFormatado = 
                ///String.Format e usado para formatar as string
                ///deixando o nosso texto padrão e apresentavel
                string.Format(
                    //nosso primeiro parametro é o template que usamos
                    template,
                    
                    ///apos informar o template, temos os parametros
                    ///esse metodo espera um array de parametros ou seja
                    ///podemos passar muitos parametros nele
                    pessoa.Id, pessoa.Nome, pessoa.DataNascimento.ToShortDateString(), pessoa.Carteira.ToString("C"));
           

            Console.WriteLine(textoFormatado);
                                                              
                
        }


       
    }
}
