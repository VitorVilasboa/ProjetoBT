using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ProjetoBT.Models
{
    public class ProjetoContexto : DbContext
    {
        public ProjetoContexto(DbContextOptions<ProjetoContexto> options) : base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Processos> Processos { get; set; }

    }

    public class Processos
    {
        [Key]
        public int idProcessos { get; set; }

        public decimal vlCausa { get; set; }

        public string nmContratante { get; set; }

        public string nmEscritorio { get; set; }

    }

    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string nmUsuario { get; set; }

        public string dcSenhaUsuario { get; set; }

    }
}
