using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licitacoes.Core.Interfaces
{
    public interface IRepositoryModel<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAll(int offset, int limit);
        T GetOne(params object[] variable);
        T Insert(T obj);
        T Update(T obj);
        void Delete(T obj);

        void Delete(params object[] variable);
        void SaveChanges();
    }
}
