//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ScreenSound.Modelos;

//namespace ScreenSound.BD;

//internal class MusicaDAL: DAL<Musica>
//{

//    public MusicaDAL(ScreenSoundContext context) : base(context) { }
//    #region DALcs
//    //public override void Adicionar(Musica musica)
//    //{
//    //    context.Musicas.Add(musica);
//    //    context.SaveChanges();
//    //}
//    //public override void Deletar(Musica musica)
//    //{
//    //    context.Musicas.Remove(musica);
//    //    context.SaveChanges();
//    //}
//    //public override void Atualizar(Musica musica)
//    //{
//    //    context.Musicas.Update(musica);
//    //    context.SaveChanges();
//    //}
//    #endregion
//    public Musica? RecuperarPeloNome(string nome)
//    {
//        var musica = context.Musicas.FirstOrDefault(m => m.Nome.Equals(nome));
//        if (musica != null)
//        {
//            return musica;
//        }
//        else
//        {
//            return null;
//        }
//    }

//}
