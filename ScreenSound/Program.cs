using ScreenSound;

Album album = new Album();
album.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 200;
musica1.Artista = "Barões da Pisadinha";
Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rapsody"; 
musica2.Duracao = 200;
album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);

Banda queen = new Banda();
queen.Nome = "Queen";
queen.AdicionarAlbum(album);
queen.ExibirDiscografia();

Episodio episodio1 = new Episodio();
episodio1.Titulo = "Arrozzz";
episodio1.Resumo = "batata";
episodio1.Ordem = 12;
episodio1.Duracao = 200;


Episodio episodio2 = new Episodio();
episodio2.Titulo = "Parmegiana";
episodio2.Resumo = "fritas";
episodio2.Ordem = 12;
episodio2.Duracao = 200;

Podcast podcast = new Podcast();
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.ExibirDetalhes();

