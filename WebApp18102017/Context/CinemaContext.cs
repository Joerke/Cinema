using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp18102017.Models;

namespace WebApp18102017.Context
{
    public class CinemaContext : DbContext
    {

        // pra saber oq é metodo construtor ; é so ver o nome do metodo esta igual o da classe e tbm ver que ele nao tem 
        // nenhum retorno(void,static .....)
        public CinemaContext() : base("name=strCinema")
        {

        }

        //Dbset siginifica configuraçao de banco , mapear as classes
        public DbSet<Sessao> Sessoes  { get; set; }
        public DbSet<Sala> Salas { get; set; }

    }
}