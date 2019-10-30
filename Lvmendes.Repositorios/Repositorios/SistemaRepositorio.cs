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
            try
            {
                using (var context = new EFDataContext())
                {                    
                    context.Sistemas.Attach(o);
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

        public Sistema Carregar(long i)
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    return context.Sistemas.SingleOrDefault(s => s.Id == i);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string Delete(Sistema o)
        {
            try
            {
                using (var context = new EFDataContext())
                {
                     context.Sistemas.Remove(o);
                    context.SaveChanges();
                    return "Ok";
                      
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
