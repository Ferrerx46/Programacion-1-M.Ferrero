﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaEntidadFinanciera;

#nullable disable

namespace SistemaEntidadFinanciera.Migrations
{
    [DbContext(typeof(FinancieraDBcontext))]
    [Migration("20231010235508_Migracion2")]
    partial class Migracion2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaEntidadFinanciera.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SistemaEntidadFinanciera.CuentaBancaria", b =>
                {
                    b.Property<int>("CuentaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CuentaID"));

                    b.Property<long>("NumeroCuenta")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CuentaID");

                    b.ToTable("CuentasBancarias");
                });

            modelBuilder.Entity("SistemaEntidadFinanciera.TarjetaCredito", b =>
                {
                    b.Property<int>("TarjetaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TarjetaID"));

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LimiteCredito")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MontoDeuda")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("NumeroTarjeta")
                        .HasColumnType("int");

                    b.Property<decimal>("SaldoDisponible")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TarjetaID");

                    b.ToTable("TarjetasCredito");
                });
#pragma warning restore 612, 618
        }
    }
}
