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



        // override = sobre escrita da tabela base
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // aki esta colocando a Coluna CODIGO como chave primaria
            modelBuilder.Entity<Sessao>().HasKey(x => x.Codigo);

            // aki esta mudando o nome da classe 
            modelBuilder.Entity<Sessao>().ToTable("TbSesao");
            modelBuilder.Entity<Sala>().ToTable("TbSala");

            //aki esta colocando essas propriedades estao colocando como NOT NULL (Obrigatorio)
            modelBuilder.Entity<Sala>().Property(x => x.Numero).IsRequired();
            modelBuilder.Entity<Sala>().Property(x => x.Descricao).IsRequired();
            modelBuilder.Entity<Sala>().Property(x => x.Capacidade).IsRequired();


        }
    }
}