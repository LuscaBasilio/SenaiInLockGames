using Senai.InLock.DatabaseFirst.Solution.Domains;
using Senai.InLock.DatabaseFirst.Solution.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.DatabaseFirst.Solution.Interfaces
{
    interface IJogosRepository
    {
        void Cadastrar(Jogos jogo);

        List<Jogos> Listar();

        void Deletar(int id);  
    }
}
