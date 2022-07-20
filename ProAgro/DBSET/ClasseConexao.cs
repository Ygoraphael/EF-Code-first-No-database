using App_no_database.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace App_no_database.DBSET
{
    class ProAgroContext : DbContext
    {
        public ProAgroContext() : base("ProAgro") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*Colunas da Tabela COLETA EXPERIMENTO*/
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.PRESSA_COE).HasPrecision(5, 1);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.TEMMAX_COE).HasPrecision(3, 1);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.TEMMIN_COE).HasPrecision(3, 1);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.PLUVIO_COE).HasPrecision(3, 1);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.VELVEN_COE).HasPrecision(3, 1);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.TENSIO_COE).HasPrecision(5, 1);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.IRRQNT_COE).HasPrecision(5, 2);

            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.VALRE1_EXP).HasPrecision(9, 3);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.VALRE2_EXP).HasPrecision(9, 3);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.VALRE3_EXP).HasPrecision(9, 3);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.VALRE4_EXP).HasPrecision(9, 3);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.VALRE5_EXP).HasPrecision(9, 3);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.VALRE6_EXP).HasPrecision(9, 3);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.VALRE7_EXP).HasPrecision(9, 3);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.VALRE8_EXP).HasPrecision(9, 3);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.VALRE9_EXP).HasPrecision(9, 3);
            modelBuilder.Entity<COLETAEXPERIMENTO>().Property(prop => prop.VALREA_EXP).HasPrecision(9, 3);

            /*Colunas da Tabela COLETA GERMINAÇÃO*/
            modelBuilder.Entity<COLETAGERMINACAO>().Property(prop => prop.PORGER_COG).HasPrecision(4, 1);

            /*Colunas da Tabela CULTURA*/
            modelBuilder.Entity<CULTURA>().Property(prop => prop.GERMIN_CUL).HasPrecision(3, 1);
            modelBuilder.Entity<CULTURA>().Property(prop => prop.PUREZA_CUL).HasPrecision(3, 1);
            modelBuilder.Entity<CULTURA>().Property(prop => prop.M100SE_CUL).HasPrecision(6, 3);

            /*Colunas da Tabela EXPERIMENTO*/
            modelBuilder.Entity<EXPERIMENTO>().Property(prop => prop.DIAVAS_EXP).HasPrecision(5, 2);
            modelBuilder.Entity<EXPERIMENTO>().Property(prop => prop.PEIEA1_EXP).HasPrecision(3, 1);
            modelBuilder.Entity<EXPERIMENTO>().Property(prop => prop.PEIEA2_EXP).HasPrecision(3, 1);
            modelBuilder.Entity<EXPERIMENTO>().Property(prop => prop.PEIEA3_EXP).HasPrecision(3, 1);
            modelBuilder.Entity<EXPERIMENTO>().Property(prop => prop.PEQET1_EXP).HasPrecision(3, 1);
            modelBuilder.Entity<EXPERIMENTO>().Property(prop => prop.PEQET2_EXP).HasPrecision(3, 1);
            modelBuilder.Entity<EXPERIMENTO>().Property(prop => prop.PEQET3_EXP).HasPrecision(3, 1);

            /*Colunas da Tabela GERMINACAO*/
            modelBuilder.Entity<GERMINACAO>().Property(prop => prop.PEPAGE_GER).HasPrecision(7, 4);
            modelBuilder.Entity<GERMINACAO>().Property(prop => prop.TEMPET_GER).HasPrecision(3, 1);
            modelBuilder.Entity<GERMINACAO>().Property(prop => prop.QUAGUA_GER).HasPrecision(4, 1);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<COLETAEXPERIMENTO> COLETAEXPERIMENTOs { get; set; }
        public DbSet<COLETAGERMINACAO> COLETAGERMINACAOs { get; set; }
        public DbSet<COMPETICAO> COMPETICAOs { get; set; }
        public DbSet<CULTURA> CULTURAs { get; set; }
        public DbSet<EXPERIMENTO> EXPERIMENTOs { get; set; }
        public DbSet<GERMINACAO> GERMINACAOs { get; set; }
        public DbSet<NOMEPADRAOVARIAVEIS> NOMEPADRAOVARIAVEISs { get; set; }
        public DbSet<PROPRIEDADE> PROPRIEDADEs { get; set; }
        public DbSet<USUARIO> USUARIOs { get; set; }
    }
    
}
