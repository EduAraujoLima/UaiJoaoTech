using Licitacoes.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licitacoes.Core.Repositories
{
    public class RepositoryLicitacoes : RepositoryBase<Models.Licitacoes>, IRepositoryLicitacoes
    {
        public RepositoryLicitacoes(bool SaveChanges = true) : base(SaveChanges) 
        {
            
        }
    }
}
