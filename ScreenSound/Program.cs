using ScreenSound;

Musica musica1 = new Musica();
musica1.Nome = "Come are you";
musica1.Artista = "Nirvana";
musica1.Duracao = 273; 
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);
musica1.ExibirFIchaTecnica();


Musica musica2 = new Musica();
musica2.Nome = "Hey, you";
musica2.Artista = "Pink Floyd";
musica2.Duracao = 274;
musica2.Disponivel = false;
musica2.ExibirFIchaTecnica();



