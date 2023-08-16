Episodio ep1 = new(5, "Técnicas de facilitação", 45);
ep1.AdicionarConvidado("The weekend");
ep1.AdicionarConvidado("The strokes");


Episodio ep2 = new(2, "Técnicas de facilitação - parte 2 ", 90);
ep2.AdicionarConvidado("The beatles");
ep2.AdicionarConvidado("The funeral");


Podcast podcast = new("Podcast fera", "Leo");

podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
