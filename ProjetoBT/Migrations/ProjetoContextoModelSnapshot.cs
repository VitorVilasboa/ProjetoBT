// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoBT.Models;

namespace ProjetoBT.Migrations
{
    [DbContext(typeof(ProjetoContexto))]
    partial class ProjetoContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoBT.Models.Processos", b =>
                {
                    b.Property<int>("idProcessos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProcessosidProcessos")
                        .HasColumnType("int");

                    b.Property<string>("nmContratante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nmEscritorio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("vlCausa")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("idProcessos");

                    b.HasIndex("ProcessosidProcessos");

                    b.ToTable("Processos");
                });

            modelBuilder.Entity("ProjetoBT.Models.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dcSenhaUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nmUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProjetoBT.Models.Processos", b =>
                {
                    b.HasOne("ProjetoBT.Models.Processos", null)
                        .WithMany("LProcessos")
                        .HasForeignKey("ProcessosidProcessos");
                });

            modelBuilder.Entity("ProjetoBT.Models.Processos", b =>
                {
                    b.Navigation("LProcessos");
                });
#pragma warning restore 612, 618
        }
    }
}
