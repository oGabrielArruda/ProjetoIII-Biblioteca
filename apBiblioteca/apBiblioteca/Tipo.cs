using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca
{
    class Tipo : IRegistro, IComparable<Tipo> // classe tipo que segue as especificações da interface IRegistro, e tem que ter um método de Comparação 
    {
        private int codigoTipo;
        private string descricaoTipo;

        const int inicioCod = 0; // tamanho das informações no arquivo texto de Tipos
        const int inicioDesc = 2;

        const int tamanhoCod = 2;
        const int tamanhoDesc = 20;

        public void LerRegistro(StreamReader arq) // função que lê o arquivo passado como parâmetro
        {
            if (!arq.EndOfStream) // se o arquivo não acabou
            {
                String linha = arq.ReadLine(); // string linha é definida como uma linha do arquivo texto
                CodigoTipo = int.Parse(linha.Substring(inicioCod, tamanhoCod)); // separamos os campos e atribuímos às variáveis CodigoTipo
                DescricaoTipo = linha.Substring(inicioDesc, tamanhoDesc);  //                                                   e DescricaoTipo
            }
        }

        public Tipo() // construtor vazio como solicitado na interface IRegistro
        {

        }

        public Tipo(int codigo, string descricao) // construtor da classe que recebe um inteiro como código e uma string como descricção do tipo
        {
            CodigoTipo = codigo;
            DescricaoTipo = descricao;
        }
        public String ParaArquivo() // retorna uma string que será utilizada para salvar o arquivo
        {
            return CodigoTipo.ToString().PadLeft(tamanhoCod, ' ') + DescricaoTipo.PadRight(tamanhoDesc, ' ');
        }

        public override string ToString() // retorna uma string para a visualização dos objetos pelo usuário
        {
            string saida = CodigoTipo.ToString().PadLeft(tamanhoCod, ' ') + "         " + DescricaoTipo.PadRight(tamanhoDesc, ' ');
            return saida;
        }

        public int CompareTo(Tipo outro) // método compareTo previsto na declaração da classe
        {
            return codigoTipo.CompareTo(outro.codigoTipo); // retorna a comparação já existente entre inteiros
             //                                             um número positivo se o passado como parâmetro for menor, um número negativos se o do parâmetro for maior
             //                                             e 0 caso sejam iguais
        }

        public int CodigoTipo { get => codigoTipo; set => codigoTipo = value; } // atributos para não acessar os valores diretamente na classe
        public string DescricaoTipo { get => descricaoTipo; set => descricaoTipo = value; }
    }
}
