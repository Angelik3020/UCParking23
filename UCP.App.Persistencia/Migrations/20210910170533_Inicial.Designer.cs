﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UCP.App.Persistencia;

namespace UCP.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210910170533_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("UCP.App.Dominio.Parqueadero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numeroPuestos")
                        .HasColumnType("int");

                    b.Property<string>("picoPlaca")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Parqueaderos");
                });

            modelBuilder.Entity("UCP.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Parqueaderoid")
                        .HasColumnType("int");

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("vehiculo_1id")
                        .HasColumnType("int");

                    b.Property<int?>("vehiculo_2id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Parqueaderoid");

                    b.HasIndex("vehiculo_1id");

                    b.HasIndex("vehiculo_2id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("UCP.App.Dominio.Puesto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Parqueaderoid")
                        .HasColumnType("int");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<int>("numeroParqueadero")
                        .HasColumnType("int");

                    b.Property<int>("tipoVehiculo")
                        .HasColumnType("int");

                    b.Property<int?>("vehiculoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Parqueaderoid");

                    b.HasIndex("vehiculoid");

                    b.ToTable("Puestos");
                });

            modelBuilder.Entity("UCP.App.Dominio.Transaccion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Parqueaderoid")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaSalida")
                        .HasColumnType("datetime2");

                    b.Property<float>("valorHora")
                        .HasColumnType("real");

                    b.Property<int?>("vehiculoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Parqueaderoid");

                    b.HasIndex("vehiculoid");

                    b.ToTable("Transacciones");
                });

            modelBuilder.Entity("UCP.App.Dominio.Vehiculo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipovehiculo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("UCP.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("UCP.App.Dominio.Persona");

                    b.Property<string>("programa")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("UCP.App.Dominio.PersonalAdministrativo", b =>
                {
                    b.HasBaseType("UCP.App.Dominio.Persona");

                    b.Property<string>("dependencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("oficina")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("PersonalAdministrativo");
                });

            modelBuilder.Entity("UCP.App.Dominio.Profesor", b =>
                {
                    b.HasBaseType("UCP.App.Dominio.Persona");

                    b.Property<string>("cubiculo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("facultad")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("UCP.App.Dominio.Visitante", b =>
                {
                    b.HasBaseType("UCP.App.Dominio.Persona");

                    b.Property<string>("actividad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("autorizaid")
                        .HasColumnType("int");

                    b.HasIndex("autorizaid");

                    b.HasDiscriminator().HasValue("Visitante");
                });

            modelBuilder.Entity("UCP.App.Dominio.Persona", b =>
                {
                    b.HasOne("UCP.App.Dominio.Parqueadero", null)
                        .WithMany("personasAutorizadas")
                        .HasForeignKey("Parqueaderoid");

                    b.HasOne("UCP.App.Dominio.Vehiculo", "vehiculo_1")
                        .WithMany()
                        .HasForeignKey("vehiculo_1id");

                    b.HasOne("UCP.App.Dominio.Vehiculo", "vehiculo_2")
                        .WithMany()
                        .HasForeignKey("vehiculo_2id");

                    b.Navigation("vehiculo_1");

                    b.Navigation("vehiculo_2");
                });

            modelBuilder.Entity("UCP.App.Dominio.Puesto", b =>
                {
                    b.HasOne("UCP.App.Dominio.Parqueadero", null)
                        .WithMany("puestos")
                        .HasForeignKey("Parqueaderoid");

                    b.HasOne("UCP.App.Dominio.Vehiculo", "vehiculo")
                        .WithMany()
                        .HasForeignKey("vehiculoid");

                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("UCP.App.Dominio.Transaccion", b =>
                {
                    b.HasOne("UCP.App.Dominio.Parqueadero", null)
                        .WithMany("transacciones")
                        .HasForeignKey("Parqueaderoid");

                    b.HasOne("UCP.App.Dominio.Vehiculo", "vehiculo")
                        .WithMany()
                        .HasForeignKey("vehiculoid");

                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("UCP.App.Dominio.Visitante", b =>
                {
                    b.HasOne("UCP.App.Dominio.Persona", "autoriza")
                        .WithMany()
                        .HasForeignKey("autorizaid");

                    b.Navigation("autoriza");
                });

            modelBuilder.Entity("UCP.App.Dominio.Parqueadero", b =>
                {
                    b.Navigation("personasAutorizadas");

                    b.Navigation("puestos");

                    b.Navigation("transacciones");
                });
#pragma warning restore 612, 618
        }
    }
}