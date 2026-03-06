namespace ConsoleAppTraditional.Class
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }

        protected BaseEntity()
        {
            
        }
    }

    public interface IRepository<T, Tkey> where T: BaseEntity<Tkey>
    {
        void Create(T data);
        List<T> GetAll();

        void Delete(Tkey id);
        T GetById(Tkey id);

        T Update(T data);
    }
    public class Repository<T, TKey> : IRepository<T, TKey> where T : BaseEntity<TKey>
    {
        private List<T> data;
        public Repository()
        {
            data = new();
        }

        public void Create(T data)
        {
            this.data.Add(data);
        }

        public void Delete(TKey id)
        {
            var dataToDelete = data.FirstOrDefault(d => d.Id.Equals(id));
            if(dataToDelete == null)
            {
                throw new KeyNotFoundException($"Not found: {id}");
            }
            data.Remove(dataToDelete);
        }

        public List<T> GetAll()
        {
            return data;
        }

        public T GetById(TKey id)
        {
            var dataToReturn = data.FirstOrDefault(d => d.Id.Equals(id));
            if (dataToReturn == null)
            {
                throw new KeyNotFoundException($"Not found: {id}");
            }
            return dataToReturn;
        }

        public T Update(T data)
        {
            var dataToUpdate = this.data.FirstOrDefault(d => d.Id.Equals(data.Id));
            if (dataToUpdate == null)
            {
                throw new KeyNotFoundException($"Not found: {data.Id}");
            }
            dataToUpdate = data;
            return dataToUpdate;
        }
    }
}
