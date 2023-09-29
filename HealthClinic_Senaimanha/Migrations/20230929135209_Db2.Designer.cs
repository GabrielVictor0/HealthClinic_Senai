﻿// <auto-generated />
using System;
using HealthClinic_Senaimanha.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HealthClinic_Senaimanha.Migrations
{
    [DbContext(typeof(HealthClinicContext))]
    [Migration("20230929135209_Db2")]
    partial class Db2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.Clinica", b =>
                {
                    b.Property<Guid>("IdClinica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("CHAR(14)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<TimeSpan?>("HorarioAbertura")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("HorarioFechamento")
                        .HasColumnType("time");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdClinica");

                    b.HasIndex("CNPJ")
                        .IsUnique();

                    b.HasIndex("RazaoSocial")
                        .IsUnique();

                    b.ToTable("Clinica");
                });

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.Comentario", b =>
                {
                    b.Property<Guid>("IdComentario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("VARCHAR(300)");

                    b.Property<bool>("Exibir")
                        .HasColumnType("BIT");

                    b.Property<Guid>("IdConsulta")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdComentario");

                    b.HasIndex("IdConsulta");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.Consulta", b =>
                {
                    b.Property<Guid>("IdConsulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("SMALLDATETIME");

                    b.Property<TimeSpan?>("HorarioConsulta")
                        .IsRequired()
                        .HasColumnType("time");

                    b.Property<Guid>("IdMedico")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPaciente")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdConsulta");

                    b.HasIndex("IdMedico");

                    b.HasIndex("IdPaciente");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.Especialidade", b =>
                {
                    b.Property<Guid>("IdEspecialidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdEspecialidade");

                    b.ToTable("Especialidade");
                });

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.Medico", b =>
                {
                    b.Property<Guid>("IdMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("IdClinica")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdEspecialidade")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdMedico");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("CRM")
                        .IsUnique();

                    b.HasIndex("IdClinica");

                    b.HasIndex("IdEspecialidade");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.Paciente", b =>
                {
                    b.Property<Guid>("IdPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("CHAR(11)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("DATE");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdPaciente");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("IdUsuario");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.TipoDeUsuario", b =>
                {
                    b.Property<Guid>("IdTipoDeUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdTipoDeUsuario");

                    b.ToTable("TipoDeUsuario");
                });

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("IdTipoDeUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Senha")
                        .HasMaxLength(60)
                        .HasColumnType("CHAR(60)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("IdTipoDeUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.Comentario", b =>
                {
                    b.HasOne("HealthClinic_Senaimanha.Domains.Consulta", "Consulta")
                        .WithMany()
                        .HasForeignKey("IdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");
                });

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.Consulta", b =>
                {
                    b.HasOne("HealthClinic_Senaimanha.Domains.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("IdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthClinic_Senaimanha.Domains.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.Medico", b =>
                {
                    b.HasOne("HealthClinic_Senaimanha.Domains.Clinica", "Clinica")
                        .WithMany()
                        .HasForeignKey("IdClinica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthClinic_Senaimanha.Domains.Especialidade", "Especialidade")
                        .WithMany()
                        .HasForeignKey("IdEspecialidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthClinic_Senaimanha.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinica");

                    b.Navigation("Especialidade");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.Paciente", b =>
                {
                    b.HasOne("HealthClinic_Senaimanha.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("HealthClinic_Senaimanha.Domains.Usuario", b =>
                {
                    b.HasOne("HealthClinic_Senaimanha.Domains.TipoDeUsuario", "TipoDeUsuario")
                        .WithMany()
                        .HasForeignKey("IdTipoDeUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoDeUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
