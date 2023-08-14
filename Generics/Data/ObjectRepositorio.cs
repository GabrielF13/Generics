namespace Generics.Data
{
    public class ObjectRepositorio
    {
        private List<object> _objetos;

        public ObjectRepositorio()
        {
            _objetos = new List<object>();
        }

        public void Adicionar(object obj)
        {
            _objetos.Add(obj);
        }

        public List<object> ObterTodos()
        {
            return _objetos;
        }
    }
}