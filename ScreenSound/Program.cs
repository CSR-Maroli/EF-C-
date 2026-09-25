using ScreenSound.BD;
using ScreenSound.Menus;
using ScreenSound.Modelos;


#region Modelo antigo da chamada de função
//try
//{
//    using var context = new ScreenSoundContext();
//    var artistDAL = new ArtistDAL(context);

//    var novoArtista = new Artista("Jo soares", "legal");
//    artistDAL.Adicionar(novoArtista);

//    var artists = artistDAL.Listar();
//    foreach (var artista in artists)
//    {
//        Console.WriteLine(artista);
//    }
//}
////try
////{
////    var artistDAL = new ArtistDAL();
////    artistDAL.adicionar(new Artista("Legião Urbana", "Banda de rock brasileira formada em Brasília em 1982."));
////    var artistas = artistDAL.Listar();
////    foreach (var artista in artistas)
////    {
////        Console.WriteLine(artista);
////    }
////}
//catch (Exception ex)
//{
//    Console.WriteLine("Não foi possível conectar ao banco de dados.");
//    Console.WriteLine($"Erro: {ex.Message}");
//}
//return;


//Artista ira = new Artista("Ira!", "Banda Ira!");
//Artista beatles = new("The Beatles", "Banda The Beatles");

//Dictionary<string, Artista> artistasRegistrados = new();
//artistasRegistrados.Add(ira.Nome, ira);
//artistasRegistrados.Add(beatles.Nome, beatles);

#endregion

using var context = new ScreenSoundContext();
var artistaDAL = new DAL<Artista>(context) ;

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarArtista());
opcoes.Add(2, new MenuRegistrarMusica());
opcoes.Add(3, new MenuMostrarArtistas());
opcoes.Add(4, new MenuMostrarMusicas());
opcoes.Add(5, new MenuMostrarMusicaPorAno());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 3.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um artista");
    Console.WriteLine("Digite 2 para registrar a música de um artista");
    Console.WriteLine("Digite 3 para mostrar todos os artistas");
    Console.WriteLine("Digite 4 para exibir todas as músicas de um artista");
    Console.WriteLine("Digite 5 para exibir todas as músicas de um determinado ano");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(artistaDAL);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    } 
    else
    {
        Console.WriteLine("Opção inválida");
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();