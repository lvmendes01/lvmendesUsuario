using lvmendes.Entidades;
using lvmendes.Repositorios.Interfaces;
using lvmendes.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lvmendes.Servicos.Servicos
{
    public class AutorizacoesServico : IAutorizacaoServico
    {
        IAutorizacaoRepositorio repositorio;

        public AutorizacoesServico(IAutorizacaoRepositorio _repositorio)
        {
            this.repositorio = _repositorio;
        }
        public string Atualizar(Autorizacoes o)
        {
            return this.repositorio.Atualizar(o);
        }

        public Autorizacoes Carregar(long i)
        {
            return this.repositorio.Carregar(i);
        }

        public string Delete(Autorizacoes o)
        {
            return this.repositorio.Delete(o);
        }

        public IList<Autorizacoes> Listar()
        {
            return this.repositorio.Listar();
        }

        public string Salvar(Autorizacoes o)
        {
            return this.repositorio.Salvar(o);
        }
    }
}
