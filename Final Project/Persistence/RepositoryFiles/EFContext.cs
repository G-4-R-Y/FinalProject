using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.RepositoryFiles
{
    public class EFContext : DbContext
    {
        public DbSet<Adress>              Adresses             { get; set; }
        public DbSet<Product>             Products             { get; set; }
        public DbSet<Exam>                Exams                { get; set; }
        public DbSet<MedicalConsultation> MedicalConsultations { get; set; }
        public DbSet<Owner>               Owners               { get; set; }
        public DbSet<Pet>                 Pets                 { get; set; }
        public DbSet<Vet>                 Vets                 { get; set; }
        public DbSet<ConsultationProduct> ConsultationProducts { get; set; }
        public DbSet<ConsultationExam>    ConsultationExams    { get; set; }
        public DbSet<Earning>             Earnings             { get; set; }
        public DbSet<Payment>             Payments             { get; set; }
        public DbSet<Cashflow>            Cashflows            { get; set; }
        public DbSet<Sale>                Sales                { get; set; }
        public DbSet<Storage>             Storages             { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder )
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=FinalProjectDatabase;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().HasIndex(owner => owner.CPF).IsUnique();
            modelBuilder.Entity<Vet>().HasIndex(vet => vet.CPF).IsUnique();
            base.OnModelCreating(modelBuilder);


        }
    }
}
