using Generics.Domain;

namespace Generics.Data
{
    public class CategoriaRepositorio
    {
        private List<Categoria> _categoria;

        public CategoriaRepositorio()
        {
            _categoria = new List<Categoria>();
        }

        public void Adicionar(Categoria categoria)
        {
            _categoria.Add(categoria);
        }

        public List<Categoria> ObterTodos()
        {
            return _categoria;
        }
    }
}