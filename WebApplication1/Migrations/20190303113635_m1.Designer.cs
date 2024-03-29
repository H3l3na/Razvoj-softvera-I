﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.EF;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20190303113635_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Administracija", b =>
                {
                    b.Property<int>("AdministracijaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<DateTime>("Datum_Rodjenja");

                    b.Property<DateTime>("Datum_Zaposlenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Kancelarija");

                    b.Property<int>("KorisničkiNalog_ID_FK");

                    b.Property<string>("Mail");

                    b.Property<string>("Prezime");

                    b.Property<string>("Spol");

                    b.Property<string>("Stalan_Zapolsenik");

                    b.Property<int>("Staz");

                    b.Property<string>("Telefon");

                    b.HasKey("AdministracijaID");

                    b.HasIndex("KorisničkiNalog_ID_FK");

                    b.ToTable("Administracija");
                });

            modelBuilder.Entity("WebApplication1.Models.Akademija", b =>
                {
                    b.Property<int>("AkademijaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Broj_Polaznika");

                    b.Property<int>("Broj_Zaposlenih");

                    b.Property<int>("DrzavaID_FK");

                    b.Property<int>("GradID_FK");

                    b.Property<DateTime>("Izgradjeno");

                    b.Property<string>("Naziv");

                    b.HasKey("AkademijaID");

                    b.HasIndex("DrzavaID_FK");

                    b.HasIndex("GradID_FK");

                    b.ToTable("Akademija");
                });

            modelBuilder.Entity("WebApplication1.Models.Drzava", b =>
                {
                    b.Property<int>("DrzavaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kontinent");

                    b.Property<string>("Naziv");

                    b.Property<string>("Skracenica");

                    b.HasKey("DrzavaID");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("WebApplication1.Models.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Drzava_ID_FK");

                    b.Property<string>("Naziv");

                    b.Property<string>("Postanski_Broj");

                    b.Property<string>("Skracenica");

                    b.HasKey("GradID");

                    b.HasIndex("Drzava_ID_FK");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("WebApplication1.Models.KorisničkiNalog", b =>
                {
                    b.Property<int>("KorisnickiNalogID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnickoIme");

                    b.Property<string>("Sifra");

                    b.HasKey("KorisnickiNalogID");

                    b.ToTable("KorisničkiNalog");
                });

            modelBuilder.Entity("WebApplication1.Models.Kurs", b =>
                {
                    b.Property<int>("KursID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cijena");

                    b.Property<string>("Cilj");

                    b.Property<int>("ECTS");

                    b.Property<string>("Naziv");

                    b.Property<int>("Studijski_Program_ID_FK");

                    b.Property<int>("Trajanje");

                    b.Property<string>("Trazenost");

                    b.HasKey("KursID");

                    b.HasIndex("Studijski_Program_ID_FK");

                    b.ToTable("Kurs");
                });

            modelBuilder.Entity("WebApplication1.Models.Pohadja", b =>
                {
                    b.Property<int>("PohadjaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Broj_Obnavljanja");

                    b.Property<DateTime>("Kraj");

                    b.Property<int>("KursID_FK");

                    b.Property<string>("Obnavlja");

                    b.Property<DateTime>("Pocetak");

                    b.Property<int>("PolaznikID_FK");

                    b.HasKey("PohadjaID");

                    b.HasIndex("KursID_FK");

                    b.HasIndex("PolaznikID_FK");

                    b.ToTable("Pohadja");
                });

            modelBuilder.Entity("WebApplication1.Models.Polaznik", b =>
                {
                    b.Property<int>("PolaznikID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<string>("Broj_Dosijea");

                    b.Property<DateTime>("Datum_Rodjenja");

                    b.Property<int>("Godina_Studija");

                    b.Property<int>("Godina_Upisa");

                    b.Property<string>("Ime");

                    b.Property<int>("KorisničkiNalog_ID_FK");

                    b.Property<string>("Mail");

                    b.Property<string>("Nacin_Studiranja");

                    b.Property<string>("Obnavlja_Godinu");

                    b.Property<int>("Ovjeren_Semestar");

                    b.Property<string>("Prezime");

                    b.Property<float>("Prosjecna_Ocjena");

                    b.Property<string>("Spol");

                    b.Property<string>("Status");

                    b.Property<string>("Telefon");

                    b.Property<int>("Upisan_Semestar");

                    b.HasKey("PolaznikID");

                    b.HasIndex("KorisničkiNalog_ID_FK");

                    b.ToTable("Polaznik");
                });

            modelBuilder.Entity("WebApplication1.Models.Predaje", b =>
                {
                    b.Property<int>("PredajeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum_Predavanja");

                    b.Property<int>("KursId_FK");

                    b.Property<string>("Odrzano");

                    b.Property<string>("Opis");

                    b.Property<int>("ProfesorId_FK");

                    b.Property<string>("Vrsta");

                    b.HasKey("PredajeID");

                    b.HasIndex("KursId_FK");

                    b.HasIndex("ProfesorId_FK");

                    b.ToTable("Predaje");
                });

            modelBuilder.Entity("WebApplication1.Models.Profesor", b =>
                {
                    b.Property<int>("ProfesorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<DateTime>("Datum_Rodjenja");

                    b.Property<DateTime>("Datum_Zaposlenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Kancelarija");

                    b.Property<int>("KorisničkiNalog_ID_FK");

                    b.Property<string>("Mail");

                    b.Property<string>("Prezime");

                    b.Property<string>("Spol");

                    b.Property<string>("Stalan_Zaposlenik");

                    b.Property<int>("Staz");

                    b.Property<string>("Telefon");

                    b.Property<string>("Zvanje");

                    b.HasKey("ProfesorID");

                    b.HasIndex("KorisničkiNalog_ID_FK");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("WebApplication1.Models.Radi", b =>
                {
                    b.Property<int>("RadiID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Administracija_FK");

                    b.Property<int>("AkademijId_FK");

                    b.Property<int>("Broj_Sati_U_Sedmici");

                    b.Property<float>("Plata");

                    b.Property<int>("ProfesorId_FK");

                    b.Property<string>("Vrsta_Ugovora");

                    b.HasKey("RadiID");

                    b.HasIndex("Administracija_FK");

                    b.HasIndex("AkademijId_FK");

                    b.HasIndex("ProfesorId_FK");

                    b.ToTable("Radi");
                });

            modelBuilder.Entity("WebApplication1.Models.Studijski_Program", b =>
                {
                    b.Property<int>("Studijski_programID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Akademija_ID_FK");

                    b.Property<float>("Cijena");

                    b.Property<string>("Naziv");

                    b.Property<int>("Trajanje");

                    b.HasKey("Studijski_programID");

                    b.HasIndex("Akademija_ID_FK");

                    b.ToTable("Studijski_Program");
                });

            modelBuilder.Entity("WebApplication1.Models.Testovi", b =>
                {
                    b.Property<int>("TestID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Broj_Pitanja");

                    b.Property<int>("KursId_FK");

                    b.Property<int>("Maksimalan_Broj_Bodova");

                    b.Property<int>("Trajanje");

                    b.HasKey("TestID");

                    b.HasIndex("KursId_FK");

                    b.ToTable("Testovi");
                });

            modelBuilder.Entity("WebApplication1.Models.Uplata", b =>
                {
                    b.Property<int>("UplataID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Administracija_ID_FK");

                    b.Property<DateTime>("Datum_uplate");

                    b.Property<float>("Iznos");

                    b.Property<string>("Ovjereno");

                    b.Property<int>("Polaznik_ID_FK");

                    b.Property<string>("Svrha");

                    b.HasKey("UplataID");

                    b.HasIndex("Administracija_ID_FK");

                    b.HasIndex("Polaznik_ID_FK");

                    b.ToTable("Uplata");
                });

            modelBuilder.Entity("WebApplication1.Models.Administracija", b =>
                {
                    b.HasOne("WebApplication1.Models.KorisničkiNalog", "KorisničkiNalog_ID")
                        .WithMany()
                        .HasForeignKey("KorisničkiNalog_ID_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Akademija", b =>
                {
                    b.HasOne("WebApplication1.Models.Drzava", "Drzava_FK_ID")
                        .WithMany()
                        .HasForeignKey("DrzavaID_FK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.Grad", "Grad_FK_ID")
                        .WithMany()
                        .HasForeignKey("GradID_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Grad", b =>
                {
                    b.HasOne("WebApplication1.Models.Drzava", "Drzava_ID")
                        .WithMany()
                        .HasForeignKey("Drzava_ID_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Kurs", b =>
                {
                    b.HasOne("WebApplication1.Models.Studijski_Program", "Studijski_Program_ID")
                        .WithMany()
                        .HasForeignKey("Studijski_Program_ID_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Pohadja", b =>
                {
                    b.HasOne("WebApplication1.Models.Kurs", "Kurs_FK_ID")
                        .WithMany()
                        .HasForeignKey("KursID_FK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.Polaznik", "Polaznik_FK_ID")
                        .WithMany()
                        .HasForeignKey("PolaznikID_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Polaznik", b =>
                {
                    b.HasOne("WebApplication1.Models.KorisničkiNalog", "KorisničkiNalog_ID")
                        .WithMany()
                        .HasForeignKey("KorisničkiNalog_ID_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Predaje", b =>
                {
                    b.HasOne("WebApplication1.Models.Kurs", "KursId")
                        .WithMany()
                        .HasForeignKey("KursId_FK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.Profesor", "ProfesorId")
                        .WithMany()
                        .HasForeignKey("ProfesorId_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Profesor", b =>
                {
                    b.HasOne("WebApplication1.Models.KorisničkiNalog", "KorisničkiNalog_ID")
                        .WithMany()
                        .HasForeignKey("KorisničkiNalog_ID_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Radi", b =>
                {
                    b.HasOne("WebApplication1.Models.Administracija", "AdministracijaId")
                        .WithMany()
                        .HasForeignKey("Administracija_FK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.Akademija", "AkademijaId")
                        .WithMany()
                        .HasForeignKey("AkademijId_FK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.Profesor", "ProfesorId")
                        .WithMany()
                        .HasForeignKey("ProfesorId_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Studijski_Program", b =>
                {
                    b.HasOne("WebApplication1.Models.Akademija", "Akademija_ID")
                        .WithMany()
                        .HasForeignKey("Akademija_ID_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Testovi", b =>
                {
                    b.HasOne("WebApplication1.Models.Kurs", "KursId")
                        .WithMany()
                        .HasForeignKey("KursId_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Uplata", b =>
                {
                    b.HasOne("WebApplication1.Models.Administracija", "Administracija_ID")
                        .WithMany()
                        .HasForeignKey("Administracija_ID_FK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.Polaznik", "Polaznik_ID")
                        .WithMany()
                        .HasForeignKey("Polaznik_ID_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
