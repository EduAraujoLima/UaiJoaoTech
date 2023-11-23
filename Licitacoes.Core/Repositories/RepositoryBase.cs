using Licitacoes.Core.Interfaces;
using Licitacoes.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licitacoes.Core.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected LicitacoesContext _Context;
        public bool _SaveChanges = true;

        public RepositoryBase(bool saveChanges = true) 
        { 
            _SaveChanges = saveChanges;
            _Context = new LicitacoesContext();
        }

        public List<T> GetAll()
        {
            return _Context.Set<T>().ToList();
        }

        public List<T> GetAll(int offset, int limit)
        {
            return _Context.Set<T>().Skip(offset).Take(limit).ToList();
        }

        public T GetOne(params object[] variable)
        {
            return _Context.Set<T>().Find(variable);
        }

        public T Insert(T obj)
        {
            _Context.Set<T>().Add(obj);
            if (_SaveChanges)
                _Context.SaveChanges();
            return obj;
        }

        public T Update(T obj)
        {
            _Context.Entry(obj).State = EntityState.Modified;
            if (_SaveChanges)
                _Context.SaveChanges();
            return obj;
        }
        public void Delete(T obj)
        {
            _Context.Set<T>().Remove(obj);
            if (_SaveChanges)
                _Context.SaveChanges();
        }
        public void Delete(params object[] variable)
        {
            var obj = GetOne(variable);
            Delete(obj);
        }

        public void SaveChanges()
        {
            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
