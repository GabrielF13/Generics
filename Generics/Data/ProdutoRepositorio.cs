using Generics.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Data
{
    public class ProdutoRepositorio
    {
        private List<Produto> _produtos;

        public ProdutoRepositorio()
        {
            _produtos = new List<Produto>();    
        }
        public void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
        }
        public List<Produto> ObterTodos()
        {
            return _produtos;
        }

    }
}
