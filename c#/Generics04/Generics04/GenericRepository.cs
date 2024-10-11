using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Generics04
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private List<T> list = new List<T>(); 
        public void Add(T item)
        {
            list.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return list;
        }

        public T GetById(int id)
        {
            return list.FirstOrDefault(item => item.Id == id);
        }

        public void Remove(T item)
        {
            list.Remove(item);    
        }

        public void Save()
        {
            Console.WriteLine("saved");
        }
    }
}
