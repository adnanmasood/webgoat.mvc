using System.Collections.Generic;

namespace WebGoat.MVC.Models.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Insert(T model);
        void Update(T model);
        void Delete(T model);
    }
}
