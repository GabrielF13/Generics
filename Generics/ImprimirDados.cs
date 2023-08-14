using Generics.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class ImprimirDados
    {
        public static void ImprimirObjetos<TEntity>(this List<TEntity> entidades)
            where TEntity : Entity
        {
            if (entidades.Count == 0)
            {
                Console.WriteLine($"Lista de {typeof(TEntity).Name} Vazia!");
            }
            foreach (var entity in entidades)
            {
                Console.WriteLine(entity);
            }

            Console.WriteLine();
        }

    }
}
