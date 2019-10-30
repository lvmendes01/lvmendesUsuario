using lvmendes.Entidades;
using lvmendes.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lvmendes.Repositorios.Repositorios
{
    public class AutorizacoesRepositorio : IAutorizacaoRepositorio
    {
        public string Atualizar(Autorizacoes o)
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    context.Autorizacoes.Attach(o);
                    context.Entry(o).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                    return "Ok";

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Autorizacoes Carregar(long i)
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    return context.Autorizacoes.SingleOrDefault(s => s.Id == i);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string Delete(Autorizacoes o)
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    context.Autorizacoes.Remove(o);
                    context.SaveChanges();
                    return "Ok";

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<Autorizacoes> Listar()
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    return context.Autorizacoes
                        .ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public string Salvar(Autorizacoes o)
        {
            try
            {

                using (EFDataContext context = new EFDataContext())
                {
                    context.Autorizacoes.Add(o);
                    context.SaveChanges();
                    return "OK";
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
