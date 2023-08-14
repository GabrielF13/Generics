using Generics;
using Generics.Data;
using Generics.Domain;
using Microsoft.Extensions.DependencyInjection;

var provider = ConfigurarInjecaoDeDependencia();

var produtoRepositorio = provider.GetRequiredService<IRepositorio<Produto>>();
var categoriaRepositorio = provider.GetRequiredService<IRepositorio<Categoria>>();


produtoRepositorio.Adicionar(new Produto("Produto 01", 10));
produtoRepositorio.Adicionar(new Produto("Produto 02", 20));

categoriaRepositorio.Adicionar(new Categoria("Categoria 01"));
categoriaRepositorio.Adicionar(new Categoria("Categoria 02"));

produtoRepositorio.ObterTodos().ImprimirObjetos();
categoriaRepositorio.ObterTodos().ImprimirObjetos();

var primeiroProduto = produtoRepositorio.ObterTodos()[0];
var primeiraCategoria = categoriaRepositorio.ObterTodos()[0];

Console.WriteLine(primeiroProduto.Nome);
Console.WriteLine(primeiraCategoria.Nome);


ServiceProvider ConfigurarInjecaoDeDependencia()
{
    var serviceCollection = new ServiceCollection();

    serviceCollection.AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>));

    return serviceCollection.BuildServiceProvider();
}