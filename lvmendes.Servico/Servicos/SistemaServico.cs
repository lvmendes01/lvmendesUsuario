using lvmendes.Entidades;
using lvmendes.Repositorios.Interfaces;
using lvmendes.Servicos.Interfaces;
using Lvmendes.Repositorios.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace lvmendes.Servicos.Servicos
{
    public class SistemaServico : ISistemaServico
    {
        ISistemaRepositorio repositorio;

        public SistemaServico(ISistemaRepositorio _repositorio)
        {
            this.repositorio = _repositorio;
        }
        public string Atualizar(Sistema o)
        {
            return this.Atualizar(o);
        }

        public Sistema Carregar(long i)
        {
            return this.Carregar(i);
        }

        public string Delete(Sistema o)
        {
            return this.Delete(o);
        }

        public IList<Sistema> Listar()
        {
            return this.Listar();
        }

        public string Salvar(Sistema o)
        {
            return this.Salvar(o);
        }
    }
}
