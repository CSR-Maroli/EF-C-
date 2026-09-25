using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;

namespace ScreenSound.BD;

internal class ScreenSoundContext : DbContext
{
    public DbSet<Artista> Artistas { get; set; } // o nome precisa ter o mesmo nome da tabela.;
    public DbSet<Musica> Musicas { get; set; } // o nome precisa ter o mesmo nome da tabela.;


    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSoundV0;Integrated Security=True; Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
    }

    //public IEnumerable<Artista> Listar()
    //{
    //    var lista = new List<Artista>();
    //    using var connection = GetConnection();
    //    connection.Open();
    //    string sql = "SELECT * FROM Artistas";
    //    SqlCommand command = new SqlCommand(sql, connection);
    //    using SqlDataReader dataReader = command.ExecuteReader();
    //    while (dataReader.Read())
    //    {
    //        string nomeArtista = Convert.ToString(dataReader["Nome"]);
    //        string bio = Convert.ToString(dataReader["Bio"]);
    //        int idArtista = Convert.ToInt32(dataReader["Id"]);
    //        Artista artista = new Artista() { Nome = nomeArtista, Bio = bio, Id = idArtista };

    //        //{
    //        //    Nome = nomeArtista,
    //        //    Bio = bio,
    //        //    Id = idArtista
    //        //};
    //        lista.Add(artista);
    //    }
    //    return lista;
    //}
}


