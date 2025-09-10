using ScreenSound;

Episodio ep1 = new(45, 1, "Técnicas de facilitação");
ep1.AdicionarConvidados("Maria");

Episodio ep2 = new(67, 2, "Técnicas de aprendizado");
ep2.AdicionarConvidados("Julia");

Podcast podcast = new("Podcast especial","Alura");
podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);
podcast.ExibirDetalhes();
