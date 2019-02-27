using Senai.InLock.DatabaseFirst.Solution.Domains;
using Senai.InLock.DatabaseFirst.Solution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.DatabaseFirst.Solution.Repository
{
    public class EstudiosRepository : IEstudiosRepository
    {
        public Estudios Alterar()
        {
            throw new NotImplementedException();
        }

        public Estudios Cadastrar()
        {
            throw new NotImplementedException();
        }

        public void Deletar()
        {
            throw new NotImplementedException();
        }

        public List<Estudios> Listar()
        {
            using(InLockContext ctx = new InLockContext())
            {
                return ctx.Estudios.ToList();
            }
        }
    }
}
