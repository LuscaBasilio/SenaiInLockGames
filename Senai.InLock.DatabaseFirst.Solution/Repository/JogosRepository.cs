using Senai.InLock.DatabaseFirst.Solution.Domains;
using Senai.InLock.DatabaseFirst.Solution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.DatabaseFirst.Solution.Repository
{
    public class JogosRepository : IJogosRepository
    {
        public void Cadastrar(Jogos jogo)
        {
            using(InLockContext ctx = new InLockContext())
            {
                ctx.Jogos.Add(jogo);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using(InLockContext ctx = new InLockContext())
            {
               
            }
        }

        public List<Jogos> Listar()
        {
            using(InLockContext ctx = new InLockContext())
            {
               return ctx.Jogos.ToList();
            }
        }
    }
}
