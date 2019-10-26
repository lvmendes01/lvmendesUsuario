using System;
using System.Collections.Generic;
using System.Text;

namespace lvmendes.Repositorios.Interfaces
{
    public interface ICrud<I,O>
    {
        O Carregar(I i);
        string Salvar(O o);
        string Atualizar(O o);
        string Delete(O o);
        IList<O> Listar();


    }
}
