namespace ScreenSound;

public class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set;}
    public string DescricaoResumida => $"A música {Nome} pertence á banda {Artista} e tem duração de {Duracao} minutos";
    public void ExibirFIchaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine($"Disponivel: {Disponivel}");
        }
        else
        {
            Console.WriteLine("Adiquira o plano Plus+");
        }
    }
}