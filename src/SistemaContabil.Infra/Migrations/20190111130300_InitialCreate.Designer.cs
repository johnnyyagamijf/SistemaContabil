﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaContabil.Infra.Data;

namespace SistemaContabil.Infra.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20190111130300_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaContabil.Core.Aggregates.Fiscal.Entities.NotaFiscalEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CnpjDestinatarioNf")
                        .HasColumnName("CnpjDestinatarioNf")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("CnpjEmissorNf")
                        .HasColumnName("CnpjEmissorNf")
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("DataNf")
                        .HasColumnName("DataNf");

                    b.Property<int>("NumeroNf")
                        .HasColumnName("NumeroNf");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnName("ValorTotal")
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("Id");

                    b.ToTable("NotaFiscal");
                });
#pragma warning restore 612, 618
        }
    }
}
