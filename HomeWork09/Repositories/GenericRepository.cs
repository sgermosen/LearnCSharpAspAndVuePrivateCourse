namespace ProgramsForLearning.HomeWork9.Repositories
{
    public class GenericRepository<T> where T : class
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public T GetById(int id)
        {
            return _items.FirstOrDefault(item => ((dynamic)item).Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }
    }

}
