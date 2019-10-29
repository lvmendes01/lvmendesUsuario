using lvmendes.Entidades;
using lvmendes.Repositorios.Interfaces;
using lvmendes.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lvmendes.Servicos.Servicos
{
    public class PerfilServico : IPerfilServico
    {
        IPerfilRepositorio repositorio;

        public PerfilServico(IPerfilRepositorio _repositorio)
        {
            this.repositorio = _repositorio;
        }
        public string Atualizar(Perfil o)
        {
            return this.repositorio.Atualizar(o);
        }

        public Perfil Carregar(long i)
        {
            return this.repositorio.Carregar(i);
        }

        public string Delete(Perfil o)
        {
            return this.repositorio.Delete(o);
        }

        public IList<Perfil> Listar()
        {
            return this.repositorio.Listar();
        }

        public string Salvar(Perfil o)
        {
            return this.repositorio.Salvar(o);
        }
    }
}
