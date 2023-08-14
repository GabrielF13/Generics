using Generics.Domain;

namespace Generics.Data
{
    public class Repositorio<TEntity> :IRepositorio<TEntity> where TEntity : Entity
    {
        private List<TEntity> _lista;

        public Repositorio()
        {
            _lista = new List<TEntity>();
        }

        public void Adicionar(TEntity entidade)
        {
            _lista.Add(entidade);
        }

        public List<TEntity> ObterTodos()
        {
            return _lista;
        }
    }
}