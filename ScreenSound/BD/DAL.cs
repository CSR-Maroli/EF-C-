using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.BD;

internal class DAL<T> where T : class
{
    protected readonly ScreenSoundContext context;

    public DAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public IEnumerable<T> Listar()
    {
        return context.Set<T>().ToList();
    }

    public void Adicionar(T objeto)
    {
        context.Set<T>().Add(objeto);
        context.SaveChanges();
    }

    public void Atualizar(T objeto)
    {
        context.Set<T>().Update(objeto);
        context.SaveChanges();
    }


    public void Deletar(T objeto)
    {
        context.Set<T>().Remove(objeto);
        context.SaveChanges();
    }
    public T? RecuperarPor(Func<T, bool> condicao)
    {
        return context.Set<T>().FirstOrDefault(condicao);
    }
    public IEnumerable<T> LitarPor(Func<T, bool> condicao)
    {
        return context.Set<T>().Where(condicao);
    }
    //public void Listar()
    //{
    //    var artistas = context.Artistas.ToList();
    //    foreach (var artista in artistas)
    //    {
    //        Console.WriteLine($"Id: {artista.Id}");
    //        Console.WriteLine($"Nome: {artista.Nome}");
    //        Console.WriteLine($"Bio: {artista.Bio}");
    //        Console.WriteLine($"Foto de Perfil: {artista.FotoPerfil}");
    //        Console.WriteLine("---------------------------");
    //    }
    //}

}
