using lvmendes.Entidades;
using lvmendes.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Lvmendes.Repositorios.Repositorios
{
    public class SistemaRepositorio : ISistemaRepositorio
    {
        public string Atualizar(Sistema o)
        {
            throw new NotImplementedException();
        }

        public Sistema Carregar(long i)
        {
            throw new NotImplementedException();
        }

        public string Delete(Sistema o)
        {
            throw new NotImplementedException();
        }

        public IList<Sistema> Listar()
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    return context.Sistemas
                        .ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public string Salvar(Sistema o)
        {
            try
            {
             
                    using (EFDataContext context = new EFDataContext())
                    {
                        context.Sistemas.Add(o);
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
