using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using OsmoseProject.Models;

namespace DATA.Context
{
    public class OsmoseInverseContext: DbContext
    {
        public OsmoseInverseContext(DbContextOptions<OsmoseInverseContext> options) : base(options)

        {

        }
        public DbSet<Filiale> Filiale { get; set; }
        public DbSet<Station> Station { get; set; }
        public DbSet<Atelier> Atelier { get; set; }
        public DbSet<CategorieProduitChimique> CategorieProduitChimique { get; set; }
        public DbSet<Fournisseur> Fournisseur { get; set; }
        public DbSet<ProduitChimique> ProduitChimique { get; set; }
        public DbSet<SourceDeau> SourceDeau { get; set; }
        public DbSet<Puit> Puits { get; set; }  
        public DbSet<Bassin> Bassins { get; set; }
        public DbSet<TypeCartouche> TypeCartouche { get; set; }
        public DbSet<TypeMembrane> TypeMembrane { get; set; }
        public DbSet<Compte> Compte { get; set; }
        public DbSet<Role> Role { get; set; }
        //public DbSet<Login> Login { get; set; }
        public object UserModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atelier>()
                    .HasKey(c => c.IdAtelier);

            modelBuilder.Entity<Station>()
                     .HasKey(c => c.IdStation);

            modelBuilder.Entity<Filiale>()
                     .HasKey(c => c.IdFiliale);

            modelBuilder.Entity<Compte>()
                    .HasKey(c => c.IdCompte);

            modelBuilder.Entity<Role>()
                    .HasKey(c => c.IdRole);

            //modelBuilder.Entity<Login>()
            //        .HasBaseType<Compte>();

            modelBuilder.Entity<CategorieProduitChimique>()
                     .HasKey(c => c.IdCategorie);

            modelBuilder.Entity<Fournisseur>()
                     .HasKey(c => c.IdFournisseur);

            modelBuilder.Entity<ProduitChimique>()
                     .HasKey(c => c.IdProduitChimique);

            modelBuilder.Entity<SourceDeau>()
                     .HasKey(c => c.IdSourceDeau);

            modelBuilder.Entity<Puit>()
                    .HasBaseType<SourceDeau>(); 

            modelBuilder.Entity<Bassin>()
                    .HasBaseType<SourceDeau>();  

            modelBuilder.Entity<TypeCartouche>()
                     .HasKey(c => c.IdTypeCartouche);

            modelBuilder.Entity<TypeMembrane>()
                     .HasKey(c => c.IdTypeMembrane);



            modelBuilder.Entity<Atelier>()
                        .HasMany(c => c.Stations)
                        .WithOne(e => e.Atelier)
                        .HasForeignKey(c => c.FK_Atelier);

            modelBuilder.Entity<CategorieProduitChimique>()
                        .HasMany(c => c.produitsChimique)
                        .WithOne(e => e.CategorieproduitChimique)
                        .HasForeignKey(c => c.FK_CategorieProduitChimique);

            modelBuilder.Entity<Filiale>()
                        .HasMany(c => c.Ateliers)
                        .WithOne(e => e.Filiale)
                        .HasForeignKey(c => c.FK_Filiale);

            modelBuilder.Entity<Filiale>()
                        .HasMany(c => c.Comptes)
                        .WithOne(e => e.Filiale)
                        .HasForeignKey(c => c.FK_Filiale);

            modelBuilder.Entity<Role>()
                        .HasMany(c => c.Comptes)
                        .WithOne(e => e.Role)
                        .HasForeignKey(c => c.FK_Role);

            modelBuilder.Entity<SourceDeau>()
                        .HasOne(c => c.Filiale)
                        .WithMany()
                        .HasForeignKey(c => c.FK_Filiale); 
        }
    }

}
        
