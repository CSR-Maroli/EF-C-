//using Microsoft.Data.SqlClient;
//using ScreenSound.Modelos;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ScreenSound.BD;

//internal class ArtistDAL : DAL<Artista>
//{

//    public ArtistDAL(ScreenSoundContext context) : base(context) { }


//    //    var lista = new List<Artista>();
//    //    connection.Open();
//    //    string sql = "SELECT * FROM Artistas";
//    //    SqlCommand command = new SqlCommand(sql, connection);
//    //    using SqlDataReader dataReader = command.ExecuteReader();
//    //    while (dataReader.Read())
//    //    {
//    //        string nomeArtista = Convert.ToString(dataReader["Nome"]);
//    //        string bio = Convert.ToString(dataReader["Bio"]);
//    //        int idArtista = Convert.ToInt32(dataReader["Id"]);
//    //        Artista artista = new Artista() { Nome = nomeArtista, Bio = bio, Id = idArtista };

//    //        //{
//    //        //    Nome = nomeArtista,
//    //        //    Bio = bio,
//    //        //    Id = idArtista
//    //        //};
//    //        lista.Add(artista);
//    //    }
//    //    return lista;
//    //}
//    public void ListarArtistas()
//    {
//        var artistas = context.Artistas.ToList();
//        foreach (var artista in artistas)
//        {
//            Console.WriteLine($"Id: {artista.Id}");
//            Console.WriteLine($"Nome: {artista.Nome}");
//            Console.WriteLine($"Bio: {artista.Bio}");
//            Console.WriteLine($"Foto de Perfil: {artista.FotoPerfil}");
//            Console.WriteLine("---------------------------");
//        }
//    }
//}
//    //public Artista? RecuperarPeloNome(string nome)
//    //{
//    //    var artista = context.Artistas.FirstOrDefault(a => a.Nome.Equals(nome));
//    //    if (artista != null)
//    //    {
//    //        Console.WriteLine($"Id: {artista.Id}");
//    //        Console.WriteLine($"Nome: {artista.Nome}");
//    //        Console.WriteLine($"Bio: {artista.Bio}");
//    //        Console.WriteLine($"Foto de Perfil: {artista.FotoPerfil}");
//    //    }
//    //    else
//    //    {
//    //        Console.WriteLine("Artista não encontrado.");
//    //    }
//    //    return artista;
//    //}
//    #region DAL.cs
////    public override void Adicionar(Artista artista)
////    {
////        context.Artistas.Add(artista);

////        int retorno = context.SaveChanges();

////        //using var connection = new ScreenSoundContext().GetConnection();
////        //connection.Open();
////        //string sql = "INSERT INTO Artistas (Nome, Bio) VALUES (@Nome, @Bio)";
////        //SqlCommand command = new SqlCommand(sql, connection);
////        //command.Parameters.AddWithValue("@Nome", artista.Nome);
////        //command.Parameters.AddWithValue("@Bio", artista.Bio);

////        Console.WriteLine($"Retorno: {retorno}");
////    }

////    public override void Atualizar(Artista artista)
////    {

////        context.Artistas.Update(artista);
////        int retorno = context.SaveChanges();
////        //context.Artistas.Update(artista);
////        //context.SaveChanges();
////        //using var connection = new ScreenSoundContext().GetConnection();
////        //connection.Open();
////        //string sql = "UPDATE Artistas SET Nome = @Nome, Bio = @Bio WHERE Id = @Id";
////        //SqlCommand command = new SqlCommand(sql, connection);
////        //command.Parameters.AddWithValue("@Nome", artista.Nome);
////        //command.Parameters.AddWithValue("@Bio", artista.Bio);
////        //command.Parameters.AddWithValue("@Id", artista.Id);

////        Console.WriteLine($"Retorno de atualização: {retorno}");
////    }

////    public override void Deletar(Artista id)
////    {
////        context.Artistas.Remove(id);


////        //using var connection = new ScreenSoundContext().GetConnection();
////        //connection.Open();
////        //string sql = "DELETE FROM Artistas WHERE Id = @Id";
////        //SqlCommand command = new SqlCommand(sql, connection);
////        //command.Parameters.AddWithValue("@Id", id);
////        int retorno = context.SaveChanges();
////        if (retorno == 1)
////        {
////            Console.WriteLine($"{retorno} Deletado com sucesso");
////        }
////    }
////}
//#endregion