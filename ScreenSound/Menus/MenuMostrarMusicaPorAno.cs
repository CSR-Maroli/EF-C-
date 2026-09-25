using ScreenSound.BD;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus;

internal class MenuMostrarMusicaPorAno : Menu
{
    public override void Executar(DAL<Artista> artistaDAL)
    {
       base.Executar(artistaDAL);
        ExibirTituloDaOpcao("Mostrar músicas por ano de lançamento");
        Console.WriteLine("Digite o ano da música que deseja buscar:");
        int ano = Convert.ToInt32(Console.ReadLine());
        var musicas = artistaDAL.Listar()
            .SelectMany(a => a.Musicas)
            .Where(m => m.AnoLancamento == ano);
        if (musicas.Any())
        {
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Nome: {musica.Nome}");
                Console.WriteLine($"Ano de Lançamento: {musica.AnoLancamento}");
                Console.WriteLine($"Duração: {musica.ArtistaId}");
                Console.WriteLine("---------------------------");
            }
        }
        else
        {
            Console.WriteLine($"Nenhuma música encontrada para o ano {ano}.");
        }
    }
}
