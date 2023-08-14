using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Domain;

namespace Generics.Data
{
    public interface IRepositorio<TEntity>
        where TEntity : Entity
    {
        void Adicionar (TEntity entity);

        List<TEntity> ObterTodos();
    }
}
