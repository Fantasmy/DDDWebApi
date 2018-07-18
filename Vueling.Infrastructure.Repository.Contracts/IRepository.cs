using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Infrastructure.Repository.Contracts
{
    public interface IRepository<T>
    {
        T Add(T model); // se puede devolver T o un int
        T Update(T model);
        List<T> GetAll();
        T GetById(int id);
        int Remove(int id);  // tambien podria devolver un objeto
    }
}
