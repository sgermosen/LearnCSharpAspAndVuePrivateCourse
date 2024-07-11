namespace ProgramsForLearning.Program9.Repositories
{ 
    public class GenericRepository<T> where T : class
    {
        private readonly List<T> _Items = new List<T>();

        public T GetById(int id)
        {

            return _Items.Where(c => ((dynamic)c).Id == id).FirstOrDefault();
        }

        public List<T> GetAll()
        {
            return _Items;
        }

        public void Add(T item)
        {
            //int newId = _Items.Count + 1;
            //contact.Id = newId;
            _Items.Add(item);
        }
        public void Update(T item)
        {
            //int newId = _Items.Count + 1;
            //contact.Id = newId;
            _Items.Remove(item);
            _Items.Add(item);
        }

        //public void Update(T item)
        //{
        //    T existingContact = GetById(item.Id);

        //    if (existingContact != null)
        //    {
        //        existingContact.Email = item.Email;
        //        existingContact.Address = item.Address;
        //        existingContact.Phone = item.Phone;
        //        existingContact.LastName = item.LastName;
        //        existingContact.Age = item.Age;
        //        existingContact.Name = item.Name;

        //        _Items.RemoveAt(item.Id - 1);
        //        _Items.Add(existingContact);
        //    }
        //}

        public void Delete(T item)
        {
            //T existingContact = GetById(id);

            //if (existingContact != null)
            //{
            //    _Items.RemoveAt(id - 1);
            //}
            _Items.Remove(item);
        }
    }
}
