using Licitacoes.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licitacoes.Core.Services
{
    public class LicitacoesService
    {
        public RepositoryLicitacoes RepositoryLicitacoes { get; set; }
        public LicitacoesService()
        {
            RepositoryLicitacoes = new RepositoryLicitacoes();
        }
    }
}
