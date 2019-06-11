using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca
{
    class Tipo : IRegistro, IComparable<Tipo>
    {
        private int codigoTipo;
        private string descricaoTipo;

        const int inicioCod = 0;
        const int inicioDesc = 2;

        const int tamanhoCod = 2;
        const int tamanhoDesc = 20;

        public void LerRegistro(StreamReader arq)
        {
            if (!arq.EndOfStream)
            {
                String linha = arq.ReadLine();
                CodigoTipo = int.Parse(linha.Substring(inicioCod, tamanhoCod));
                DescricaoTipo = linha.Substring(inicioDesc, tamanhoDesc);
            }
        }

        public Tipo()
        {

        }

        public Tipo(int codigo, string descricao)
        {
            CodigoTipo = codigo;
            DescricaoTipo = descricao;
        }
        public String ParaArquivo()
        {
            return CodigoTipo.ToString().PadLeft(tamanhoCod, ' ') + DescricaoTipo.PadRight(tamanhoDesc, ' ');
        }

        public int CompareTo(Tipo outro)
        {
            return codigoTipo.CompareTo(outro.codigoTipo);
        }

        public int CodigoTipo { get => codigoTipo; set => codigoTipo = value; }
        public string DescricaoTipo { get => descricaoTipo; set => descricaoTipo = value; }
    }
}
