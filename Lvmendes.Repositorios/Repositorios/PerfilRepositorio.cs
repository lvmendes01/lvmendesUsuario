﻿using lvmendes.Entidades;
using lvmendes.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lvmendes.Repositorios.Repositorios
{
    public class PerfilRepositorio : IPerfilRepositorio
    {
        public string Atualizar(Perfil o)
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    context.Perfils.Attach(o);
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

        public Perfil Carregar(long i)
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    return context.Perfils.SingleOrDefault(s => s.Id == i);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string Delete(Perfil o)
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    context.Perfils.Remove(o);
                    context.SaveChanges();
                    return "Ok";

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<Perfil> Listar()
        {
            try
            {
                using (var context = new EFDataContext())
                {
                    return context.Perfils
                        .ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public string Salvar(Perfil o)
        {
            try
            {

                using (EFDataContext context = new EFDataContext())
                {
                    context.Perfils.Add(o);
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
