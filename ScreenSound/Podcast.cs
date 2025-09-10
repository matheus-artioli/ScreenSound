using System.Globalization;

namespace ScreenSound;

public class Podcast
{
    List<Episodio> episodios = new List<Episodio>();
    public string Host { get; set; }
    public string Nome { get; set; }
    public int TotalEpisodios { get; set; }


    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        foreach (var episodio in episodios)
        {
            Console.WriteLine("**************PODCAST****************");
            Console.WriteLine($"Nome: {episodio.Titulo}");
            Console.WriteLine($"Resumo: {episodio.Resumo}");
            Console.WriteLine($"Ordem: {episodio.Ordem}");
            Console.WriteLine($"Duração: {episodio.Duracao}");
            Console.WriteLine("*************************************");
        }
    }
}