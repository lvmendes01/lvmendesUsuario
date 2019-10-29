using lvmendes.Entidades;
using lvmendes.Repositorios.Interfaces;
using lvmendes.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lvmendes.Servicos.Servicos
{
   public class UsuarioServico : IUsuarioServico
    {
        IUsuarioRepositorio repositorio;

        public UsuarioServico(IUsuarioRepositorio _repositorio)
        {
            this.repositorio = _repositorio;
        }
        public string Atualizar(Usuario o)
        {
            return this.repositorio.Atualizar(o);
        }

        public Usuario Carregar(long i)
        {
            return this.repositorio.Carregar(i);
        }

        public string Delete(Usuario o)
        {
            return this.repositorio.Delete(o);
        }

        public IList<Usuario> Listar()
        {
            return this.repositorio.Listar();
        }

        public string Salvar(Usuario o)
        {
            return this.repositorio.Salvar(o);
        }
    }
}
