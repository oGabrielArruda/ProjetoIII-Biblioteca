using System;
using System.IO;

namespace apBiblioteca
{
  class Leitor : IComparable<Leitor>, IRegistro
  {
    public const int tamanhoCodigoLeitor = 6;
    const int tamanhoNome = 35;
    const int tamanhoEndereco = 50;
    const int tamanhoQuantosLivros = 2;
    const int tamanhoCodigoLivro = Livro.tamanhoCodigoLivro;

    const int inicioCodigoLeitor = 0;
    const int inicioNome = inicioCodigoLeitor + tamanhoCodigoLeitor;
    const int inicioEndereco = inicioNome + tamanhoNome;
    const int inicioQuantosLivros = inicioEndereco + tamanhoEndereco;
    const int inicioCodigosLivros = inicioQuantosLivros + tamanhoQuantosLivros;
    const int maximoLivrosComLeitor = 5;

    string codigoLeitor;
    string nomeLeitor;
    string enderecoLeitor;
    int quantosLivrosComLeitor;
    string[] codigoLivroComLeitor;

    public Leitor()
    {
    }
    public Leitor(string cl)
    {
      CodigoLeitor = cl;
    }
    public Leitor(string leitor, string nome, string endereco, int quantos, string[] livros)
    {
      CodigoLeitor = leitor;
      NomeLeitor = nome;
      EnderecoLeitor = endereco;
      QuantosLivrosComLeitor = quantos;
      CodigoLivroComLeitor = livros;
    }

    public void LerRegistro(StreamReader arq)
    {
      if (!arq.EndOfStream)
      {
        String linha = arq.ReadLine();
        CodigoLeitor = linha.Substring(inicioCodigoLeitor, tamanhoCodigoLeitor);
        NomeLeitor = linha.Substring(inicioNome, tamanhoNome);
        EnderecoLeitor = linha.Substring(inicioEndereco, tamanhoEndereco);
        QuantosLivrosComLeitor = int.Parse(linha.Substring(inicioQuantosLivros,
                                           tamanhoQuantosLivros));
      
        CodigoLivroComLeitor = new string[maximoLivrosComLeitor];
        for (int indice = 0; indice < QuantosLivrosComLeitor; indice++)
          CodigoLivroComLeitor[indice] =
             linha.Substring(inicioCodigosLivros + tamanhoCodigoLivro * indice,
                             tamanhoCodigoLivro);
      }
    }

    public string CodigoLeitor
    {
      get => codigoLeitor;
      set
      {
        if (value.Length > tamanhoCodigoLeitor)
          value = value.Substring(0, tamanhoCodigoLeitor);
        codigoLeitor = value.PadLeft(tamanhoCodigoLeitor, '0');
      }
    }
    public string NomeLeitor
    {
      get => nomeLeitor;
      set
      {
        if (value.Length > tamanhoNome)
          value = value.Substring(0, tamanhoNome);
        nomeLeitor = value.PadRight(tamanhoNome, ' ');
      }
    }
    public string EnderecoLeitor
    {
      get => enderecoLeitor;
      set
      {
        if (value.Length > tamanhoEndereco)
          value = value.Substring(0, tamanhoEndereco);
        enderecoLeitor = value.PadRight(tamanhoEndereco, ' '); 
      }
    }
    public int QuantosLivrosComLeitor
    {
      get => quantosLivrosComLeitor;
      set
      {
        if (value >= 0 && value < maximoLivrosComLeitor)
          quantosLivrosComLeitor = value;
      }
    }
    public string[] CodigoLivroComLeitor
    {
      get => codigoLivroComLeitor;
      set => codigoLivroComLeitor = value;
    }

    public String ParaArquivo()
    {
      string saida = CodigoLeitor.ToString() + NomeLeitor + 
                     EnderecoLeitor + 
                     QuantosLivrosComLeitor.ToString().PadLeft(tamanhoQuantosLivros, ' ');

      for (int indice = 0; indice < QuantosLivrosComLeitor; indice++)
          saida += CodigoLivroComLeitor[indice];
      return saida;
    }
    public override String ToString()
    {
      string saida = CodigoLeitor + " " +NomeLeitor + " " +EnderecoLeitor + " "+
                     QuantosLivrosComLeitor.ToString().PadLeft(tamanhoQuantosLivros, ' ');
      for (int indice = 0; indice < QuantosLivrosComLeitor; indice++)
          saida += " "+
               CodigoLivroComLeitor[indice].PadRight(
                                    Livro.tamanhoCodigoLivro,' ');
      return saida;
    }

    public int CompareTo(Leitor outro)
    {
      return codigoLeitor.CompareTo(outro.codigoLeitor);
    }
  }
}
