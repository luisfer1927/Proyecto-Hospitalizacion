﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211015163427_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Veterinaria.App.Dominio.EstadodeSalud", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Estado_Animo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Frecu_Cardia")
                        .HasColumnType("float");

                    b.Property<double>("Frecu_Respi")
                        .HasColumnType("float");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<int?>("masco_estadosaludid")
                        .HasColumnType("int");

                    b.Property<string>("recomendacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("temperatura")
                        .HasColumnType("float");

                    b.Property<int?>("visitid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("masco_estadosaludid");

                    b.HasIndex("visitid");

                    b.ToTable("estadosalud");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Mascota", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Edad")
                        .HasColumnType("nvarchar(max)");

<<<<<<< HEAD:Veterinaria.App.Persistencia/Migrations/20211015163427_initial.Designer.cs
                    b.Property<string>("Estado_Salud")
=======
                    b.Property<bool>("Estado_Salud")
>>>>>>> 7c69d86d6ebf0e1604ac4a155e900b1c28648e32:Veterinaria.App.Persistencia/Migrations/20210925132930_Initial.Designer.cs
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_Mascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("dueñoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("dueñoId");

                    b.ToTable("mascota");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Visita", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Motivo_Visita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("mascotaid")
                        .HasColumnType("int");

                    b.Property<int?>("veterinario_visitaId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("mascotaid");

                    b.HasIndex("veterinario_visitaId");

                    b.ToTable("visita");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Propietario", b =>
                {
                    b.HasBaseType("Veterinaria.App.Dominio.Persona");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Propietario");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("Veterinaria.App.Dominio.Persona");

                    b.Property<int>("Tarjeta_Profesional")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EstadodeSalud", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.Mascota", "masco_estadosalud")
                        .WithMany()
                        .HasForeignKey("masco_estadosaludid");

                    b.HasOne("Veterinaria.App.Dominio.Visita", "visit")
                        .WithMany()
                        .HasForeignKey("visitid");

                    b.Navigation("masco_estadosalud");

                    b.Navigation("visit");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Mascota", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.Propietario", "dueño")
                        .WithMany()
                        .HasForeignKey("dueñoId");

                    b.Navigation("dueño");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Visita", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.Mascota", "mascota")
                        .WithMany()
                        .HasForeignKey("mascotaid");

                    b.HasOne("Veterinaria.App.Dominio.Veterinario", "veterinario_visita")
                        .WithMany()
                        .HasForeignKey("veterinario_visitaId");

                    b.Navigation("mascota");

                    b.Navigation("veterinario_visita");
                });
#pragma warning restore 612, 618
        }
    }
}
