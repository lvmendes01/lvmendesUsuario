using lvmendes.Entidades;
using lvmendes.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lvmendes.Repositorios.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public string Atualizar(Usuario o)
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    context.Usuarios.Attach(o);
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

        public Usuario Carregar(long i)
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    return context.Usuarios.SingleOrDefault(s => s.Id == i);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string Delete(Usuario o)
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    context.Usuarios.Remove(o);
                    context.SaveChanges();
                    return "Ok";

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<Usuario> Listar()
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    return context.Usuarios
                        .ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public string Salvar(Usuario o)
        {
            try
            {

                using (EFDataContext context = new EFDataContext())
                {
                    context.Usuarios.Add(o);
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
