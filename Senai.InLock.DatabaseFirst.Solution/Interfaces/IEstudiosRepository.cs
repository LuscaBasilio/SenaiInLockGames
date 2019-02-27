using Senai.InLock.DatabaseFirst.Solution.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.DatabaseFirst.Solution.Interfaces
{
    interface IEstudiosRepository
    {
        Estudios Cadastrar();

        void Deletar();

        List<Estudios>Listar();

        Estudios Alterar();

    }
}
